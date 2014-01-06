// Type: SmartQuant.Simulation.SeriesObjectEventArgs
// Assembly: SmartQuant.Simulation, Version=1.0.5036.28353, Culture=neutral, PublicKeyToken=null
// MVID: 7CFB1E94-1672-436F-90C9-C8B7893A5618
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Simulation.dll

using CJ5Xsgeg9JvhJUnvO3D;
using SmartQuant.Data;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Simulation
{
  public class SeriesObjectEventArgs : EventArgs
  {
    private IDataSeries hFCPq0vSfe;
    private IDataObject TF3PMehmVT;

    public IDataObject Object
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.TF3PMehmVT;
      }
    }

    public IDataSeries Series
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.hFCPq0vSfe;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SeriesObjectEventArgs(IDataSeries series, IDataObject obj)
    {
      eekpcgzPjZLOyP2Ysv.eyppkuTzDkifX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.hFCPq0vSfe = series;
      this.TF3PMehmVT = obj;
    }
  }
}
