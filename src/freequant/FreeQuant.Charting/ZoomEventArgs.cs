// Type: SmartQuant.Charting.ZoomEventArgs
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

using cPAIWng0kq1SUTh6h4;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Charting
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ZoomEventArgs(double XMin, double XMax, double YMin, double YMax, bool ZoomUnzoom)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fXMin = XMin;
      this.fXMax = XMax;
      this.fYMin = YMin;
      this.fYMax = YMax;
      this.fZoomUnzoom = ZoomUnzoom;
    }
  }
}
