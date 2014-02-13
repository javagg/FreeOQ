using FreeQuant.Data;
using System;

namespace OpenQuant.Shared.Data.Bars
{
	class RangeBarCompressor : BarCompressor
	{
		private const long MULTIPLIER = 10000;

		public override void Add(CompressorDataItem data)
		{
			if (data.Items.Count != 1)
				throw new ArgumentException(string.Format("Cannot make range bars from {0}", (object)this.dataSource.Input));
			double price = data.Items[0].Price;
			if (this.bar == null)
			{
				this.CreateNewBar((BarType)4, data.DateTime, data.DateTime, price);
			}
			else
			{
				this.AddDataToBar(data.Items);
				this.bar.EndTime = data.DateTime;
				bool flag = false;
				while (!flag)
				{
					if (10000.0 * (this.bar.High - this.bar.Low) >= (double)this.barSize)
					{
						Bar bar = new Bar(BarType.Range, this.barSize, data.DateTime, data.DateTime, price, price, price, price, 0, 0);
						if (this.bar.High == price)
						{
							this.bar.High = this.bar.Low + (double)this.barSize / 10000.0;
							this.bar.Close = this.bar.High;
							bar.Low = this.bar.High;
						}
						if (this.bar.Low == price)
						{
							this.bar.Low = this.bar.High - (double)this.barSize / 10000.0;
							this.bar.Close = this.bar.Low;
							bar.High = this.bar.Low;
						}
						this.EmitNewCompressedBar();
						this.bar = bar;
						flag = 10000.0 * (this.bar.High - this.bar.Low) < (double)this.barSize;
					}
					else
						flag = true;
				}
			}
		}
	}
}
