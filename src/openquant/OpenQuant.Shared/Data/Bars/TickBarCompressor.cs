using FreeQuant.Data;

namespace OpenQuant.Shared.Data.Bars
{
	class TickBarCompressor : BarCompressor
	{
		private long tickCount;

		public TickBarCompressor()
		{
			this.tickCount = 0;
		}

		public override void Add(CompressorDataItem data)
		{
			if (this.bar == null)
				this.CreateNewBar(BarType.Tick, data.DateTime, data.DateTime, data.Items[0].Price);
			this.AddDataToBar(data.Items);
			this.bar.EndTime = data.DateTime;
			if (this.dataSource.Input == DataSourceInput.Bar)
				this.tickCount += ((BarDataSource)this.dataSource).BarSize;
			else
				++this.tickCount;
			if (this.tickCount != this.barSize)
				return;
			this.EmitNewCompressedBar();
			this.bar = null;
			this.tickCount = 0;
		}
	}
}
