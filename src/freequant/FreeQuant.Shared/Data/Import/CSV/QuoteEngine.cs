// Type: SmartQuant.Shared.Data.Import.CSV.QuoteEngine
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant.Data;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class QuoteEngine : Engine
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuoteEngine()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override IDataObject Process()
    {
      DateTime dateTime = this.GetDateTime();
      double doubleValue1 = this.GetDoubleValue(ColumnType.Bid);
      double doubleValue2 = this.GetDoubleValue(ColumnType.Ask);
      int intValue1 = this.GetIntValue(ColumnType.BidSize);
      int intValue2 = this.GetIntValue(ColumnType.AskSize);
      return (IDataObject) new Quote(dateTime, doubleValue1, intValue1, doubleValue2, intValue2);
    }
  }
}
