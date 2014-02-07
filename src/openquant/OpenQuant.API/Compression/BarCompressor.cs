using OpenQuant.API;
using FreeQuant.Data;
using System;

namespace OpenQuant.API.Compression
{
	internal abstract class BarCompressor
	{
		protected long oldBarSize;
		protected long newBarSize;
		protected Bar bar;

		private event CompressedBarEventHandler NewCompressedBar;

		protected BarCompressor()
		{
		}

		public static BarCompressor GetCompressor(BarType barType, long oldBarSize, long newBarSize)
		{
			BarCompressor barCompressor;
			switch (barType)
			{
				case BarType.Time:
					barCompressor = new TimeBarCompressor();
					break;
				case  BarType.Tick:
					barCompressor = new TickBarCompressor();
					break;
				case  BarType.Volume:
					barCompressor = new VolumeBarCompressor();
					break;
				case BarType.Range:
					barCompressor = new RangeBarCompressor();
					break;
				default:
					throw new ArgumentException(string.Format("Unknown bar type - {0}", barType));
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

		protected void CreateNewBar(BarType barType, DateTime beginTime, DateTime endTime, double price)
		{
			if (barType == BarType.Time && this.newBarSize == 86400)
				this.bar = new Bar(new FreeQuant.Data.Daily(beginTime, price, price, price, price, 0));
			else
				this.bar = new Bar(new FreeQuant.Data.Bar(EnumConverter.Convert(barType), this.newBarSize, beginTime, endTime, price, price, price, price, 0, 0));
		}

		protected void EmitNewCompressedBar()
		{
			if (this.NewCompressedBar != null)
				this.NewCompressedBar(this, new CompressedBarEventArgs(this.bar));
		}

		public BarSeries Compress(DataEntryEnumerator enumerator)
		{
			BarSeries series = new BarSeries();
			this.NewCompressedBar += (sender, args) => series.Add(args.Bar);
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
			this.bar.bar.Volume += item.Size;
		}

		private void Flush()
		{
			if (this.bar != null)
				this.EmitNewCompressedBar();
		}
	}
}
