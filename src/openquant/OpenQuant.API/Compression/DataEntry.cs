using System;

namespace OpenQuant.API.Compression
{
  internal class DataEntry
  {
    public DateTime DateTime { get; private set; }

    public PriceSizeItem[] Items { get; private set; }

    public DataEntry(DateTime datetime, PriceSizeItem[] items)
    {
      this.DateTime = datetime;
      this.Items = items;
    }
  }
}
