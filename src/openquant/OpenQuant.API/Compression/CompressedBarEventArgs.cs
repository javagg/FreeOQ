using OpenQuant.API;
using System;

namespace OpenQuant.API.Compression
{
  internal class CompressedBarEventArgs : EventArgs
  {
    public Bar Bar { get; private set; }

    public CompressedBarEventArgs(Bar bar)
    {
      this.Bar = bar;
    }
  }
}
