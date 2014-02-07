using OpenQuant.API;

namespace OpenQuant.API.Compression
{
	internal class TickBarCompressor : BarCompressor
	{
		private long tickCount = 0;

		protected override void Add(DataEntry entry)
		{
			if (this.bar == null) this.CreateNewBar(BarType.Tick, entry.DateTime, entry.DateTime, entry.Items[0].Price);

			this.AddItemsToBar(entry.Items);
			this.bar.bar.EndTime = entry.DateTime;
			this.tickCount += this.oldBarSize;
			if (this.tickCount != this.newBarSize)
				return;
			this.EmitNewCompressedBar();
			this.bar = null;
			this.tickCount = 0;
		}
	}
}
