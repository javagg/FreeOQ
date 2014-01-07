// Type: SmartQuant.Shared.Data.Import.CSV.TradeEngine
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant.Data;
using System.Runtime.CompilerServices;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class TradeEngine : Engine
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TradeEngine()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override IDataObject Process()
    {
      return (IDataObject) new Trade(this.GetDateTime(), this.GetDoubleValue(ColumnType.Price), this.GetIntValue(ColumnType.Size));
    }
  }
}
