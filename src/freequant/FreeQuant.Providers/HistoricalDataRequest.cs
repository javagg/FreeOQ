// Type: SmartQuant.Providers.HistoricalDataRequest
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using dW79p7NPlS6ZxObcx3;
using Obgh2s3A3GOOarwj6c;
using SmartQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Providers
{
  public class HistoricalDataRequest
  {
    private static int ScTgOyCwNp;
    private string H5ygRPXX3V;
    private IFIXInstrument HpSg99FMLB;
    private HistoricalDataType FZdgYFaSe5;
    private DateTime DhGgsoa2Jr;
    private DateTime vFigbZop99;
    private int mjRgd5sOrY;
    private int HDbgrnSn2C;
    private long f85gKJ2B79;

    public string RequestId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.H5ygRPXX3V;
      }
    }

    public IFIXInstrument Instrument
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.HpSg99FMLB;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.HpSg99FMLB = value;
      }
    }

    public HistoricalDataType DataType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.FZdgYFaSe5;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.FZdgYFaSe5 = value;
      }
    }

    public DateTime BeginDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.DhGgsoa2Jr;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.DhGgsoa2Jr = value;
      }
    }

    public DateTime EndDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.vFigbZop99;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.vFigbZop99 = value;
      }
    }

    public int DaysAgo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mjRgd5sOrY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.mjRgd5sOrY = value;
      }
    }

    public int BarsAgo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.HDbgrnSn2C;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.HDbgrnSn2C = value;
      }
    }

    public long BarSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.f85gKJ2B79;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.f85gKJ2B79 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static HistoricalDataRequest()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      HistoricalDataRequest.ScTgOyCwNp = 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HistoricalDataRequest()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      lock (typeof (HistoricalDataRequest))
        this.H5ygRPXX3V = string.Format(GojrKtfk5NMi1fou68.a17L2Y7Wnd(750), (object) DateTime.Now, (object) HistoricalDataRequest.ScTgOyCwNp++);
    }
  }
}
