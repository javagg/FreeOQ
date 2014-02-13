using FreeQuant.Data;

namespace OpenQuant.Shared.Data.Bars
{
	class VolumeBarCompressor : BarCompressor
	{
		public override void Add(CompressorDataItem data)
		{
			if (this.bar == null)
				this.CreateNewBar(BarType.Volume, data.DateTime, data.DateTime, data.Items[0].Price);
			this.AddDataToBar(data.Items);
			this.bar.EndTime = data.DateTime;
			if (this.bar.Volume < this.barSize)
				return;
			this.EmitNewCompressedBar();
			this.bar = null;
		}
	}
}
