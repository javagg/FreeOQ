using OpenQuant.API;
using FreeQuant.Data;
using System;

namespace OpenQuant.API.Compression
{
	internal abstract class BarCompressor
	{
		protected long oldBarSize;
		protected long newBarSize;
		protected OpenQuant.API.Bar bar;

		private event CompressedBarEventHandler NewCompressedBar;

		protected BarCompressor()
		{
			this.bar = (OpenQuant.API.Bar)null;
		}

		public static BarCompressor GetCompressor(OpenQuant.API.BarType barType, long oldBarSize, long newBarSize)
		{
			BarCompressor barCompressor;
			switch (barType)
			{
				case OpenQuant.API.BarType.Time:
					barCompressor = (BarCompressor)new TimeBarCompressor();
					break;
				case OpenQuant.API.BarType.Tick:
					barCompressor = (BarCompressor)new TickBarCompressor();
					break;
				case OpenQuant.API.BarType.Volume:
					barCompressor = (BarCompressor)new VolumeBarCompressor();
					break;
				case OpenQuant.API.BarType.Range:
					barCompressor = (BarCompressor)new RangeBarCompressor();
					break;
				default:
					throw new ArgumentException(string.Format("Unknown bar type - {0}", (object)barType));
			}
			barCompressor.oldBarSize = oldBarSize;
			barCompressor.newBarSize = newBarSize;
			return barCompressor;
		}

		protected abstract void Add(DataEntry entry);

		protected void AddItemsToBar(PriceSizeItem[] items)
		{
			foreach (PriceSizeItem priceSizeItem in items)
				this.AddItemToBar(priceSizeItem);
		}

		protected void CreateNewBar(OpenQuant.API.BarType barType, DateTime beginTime, DateTime endTime, double price)
		{
			if (barType == OpenQuant.API.BarType.Time && this.newBarSize == 86400L)
				this.bar = new OpenQuant.API.Bar((SmartQuant.Data.Bar)new Daily(beginTime, price, price, price, price, 0L));
			else
				this.bar = new OpenQuant.API.Bar(new SmartQuant.Data.Bar(EnumConverter.Convert(barType), this.newBarSize, beginTime, endTime, price, price, price, price, 0L, 0L));
		}

		protected void EmitNewCompressedBar()
		{
			if (this.NewCompressedBar == null)
				return;
			this.NewCompressedBar((object)this, new CompressedBarEventArgs(this.bar));
		}

		public BarSeries Compress(DataEntryEnumerator enumerator)
		{
			BarSeries series = new BarSeries();
			this.NewCompressedBar += (CompressedBarEventHandler)((sender, args) => series.Add(args.Bar));
			while (enumerator.MoveNext())
				this.Add(enumerator.Current);
			this.Flush();
			return series;
		}

		private void AddItemToBar(PriceSizeItem item)
		{
			if (item.Price < this.bar.Low)
				this.bar.bar.Low = item.Price;
			if (item.Price > this.bar.High)
				this.bar.bar.High = item.Price;
			this.bar.bar.Close = item.Price;
			this.bar.bar.Volume += (long)item.Size;
		}

		private void Flush()
		{
			if (this.bar == null)
				return;
			this.EmitNewCompressedBar();
		}
	}
}
