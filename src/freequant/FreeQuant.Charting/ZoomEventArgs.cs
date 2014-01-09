using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
  public class ZoomEventArgs : EventArgs
  {
    public double fXMin;
    public double fXMax;
    public double fYMin;
    public double fYMax;
    public bool fZoomUnzoom;

    public double XMin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fXMin;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fXMin = value;
      }
    }

    public double XMax
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fXMax;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fXMax = value;
      }
    }

    public ZoomEventArgs(double XMin, double XMax, double YMin, double YMax, bool ZoomUnzoom):base()
    {
      this.fXMin = XMin;
      this.fXMax = XMax;
      this.fYMin = YMin;
      this.fYMax = YMax;
      this.fZoomUnzoom = ZoomUnzoom;
    }
  }
}
