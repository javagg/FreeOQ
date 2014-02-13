using FreeQuant.Data;
using System;

namespace OpenQuant.Shared.Data.Bars
{
	class TimeBarCompressor : BarCompressor
	{
		public override void Add(CompressorDataItem data)
		{
			if (this.bar == null || this.bar.EndTime <= data.DateTime)
			{
				if (this.bar != null)
					this.EmitNewCompressedBar();
				DateTime barBeginTime = this.GetBarBeginTime(data.DateTime);
				this.CreateNewBar(BarType.Time, barBeginTime, barBeginTime.AddSeconds(this.barSize), data.Items[0].Price);
				this.AddDataToBar(data.Items);
			}
			else
				this.AddDataToBar(data.Items);
		}

		private DateTime GetBarBeginTime(DateTime datetime)
		{
			long num = (long)datetime.TimeOfDay.TotalSeconds / this.barSize * this.barSize;
			return datetime.Date.AddSeconds(num);
		}
	}
}
