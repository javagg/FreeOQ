using FreeQuant.Data;
using System;

namespace OpenQuant.Shared.Data.Bars
{
	internal abstract class BarCompressor
	{
		protected long barSize;
		protected DataSource dataSource;
		protected Bar bar;

		public event EventHandler<CompressedBarEventArgs> NewCompressedBar;

		protected BarCompressor()
		{
			this.bar = null;
		}

		public static BarCompressor GetCompressor(BarTypeSize barTypeSize, DataSource dataSource)
		{
			BarCompressor barCompressor;
			switch (barTypeSize.BarType)
			{
				case BarType.Time:
					barCompressor = new TimeBarCompressor();
					break;
				case BarType.Tick:
					barCompressor = new TickBarCompressor();
					break;
				case BarType.Volume:
					barCompressor = new VolumeBarCompressor();
					break;
				case BarType.Range:
					barCompressor = new RangeBarCompressor();
					break;
				default:
					throw new ArgumentException(string.Format("Unsupported bar type - {0}", barTypeSize.BarType));
			}
			barCompressor.barSize = barTypeSize.BarSize;
			barCompressor.dataSource = dataSource;
			return barCompressor;
		}

		protected void EmitNewCompressedBar()
		{
			if (this.NewCompressedBar == null)
				return;
			this.NewCompressedBar(this, new CompressedBarEventArgs(this.bar));
		}

		protected void CreateNewBar(BarType barType, DateTime beginTime, DateTime endTime, double price)
		{
			if (barType == BarType.Time && this.barSize == 86400)
				this.bar = new Daily(beginTime, price, price, price, price, 0);
			else
				this.bar = new Bar(barType, this.barSize, beginTime, endTime, price, price, price, price, 0, 0);
		}

		protected void AddDataToBar(BarDataItem data)
		{
			if (data.Price > this.bar.High)
				this.bar.High = data.Price;
			if (data.Price < this.bar.Low)
				this.bar.Low = data.Price;
			this.bar.Close = data.Price;
			Bar bar1 = this.bar;
			long num1 = bar1.Volume + data.Volume;
			bar1.Volume = num1;
			Bar bar2 = this.bar;
			long num2 = bar2.OpenInt + data.OpenInt;
			bar2.OpenInt = num2;
		}

		protected void AddDataToBar(BarDataItemList list)
		{
			foreach (BarDataItem data in list)
				this.AddDataToBar(data);
		}

		public abstract void Add(CompressorDataItem data);

		public void Flush()
		{
			if (this.bar != null)
				this.EmitNewCompressedBar();
		}
	}
}
