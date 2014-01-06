using OpenQuant.API;

namespace OpenQuant.API.Compression
{
  internal class VolumeBarCompressor : BarCompressor
  {
    protected override void Add(DataEntry entry)
    {
      if (this.bar == null)
        this.CreateNewBar(BarType.Volume, entry.DateTime, entry.DateTime, entry.Items[0].Price);
      this.AddItemsToBar(entry.Items);
      this.bar.bar.EndTime = entry.DateTime;
      if (this.bar.Volume < this.newBarSize)
        return;
      this.EmitNewCompressedBar();
      this.bar = (Bar) null;
    }
  }
}
