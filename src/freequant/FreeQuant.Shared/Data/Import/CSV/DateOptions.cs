// Type: SmartQuant.Shared.Data.Import.CSV.DateOptions
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class DateOptions
  {
    private DateType AoQY1dhn6w;
    private DateTime x7jYd3p5R9;

    public DateType DateType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.AoQY1dhn6w;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AoQY1dhn6w = value;
      }
    }

    public DateTime Date
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.x7jYd3p5R9.Date;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.x7jYd3p5R9 = value.Date;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateOptions()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.AoQY1dhn6w = DateType.Column;
      this.x7jYd3p5R9 = DateTime.Today;
    }
  }
}
