// Type: SmartQuant.Shared.Data.Import.CSV.Column
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.Runtime.CompilerServices;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class Column
  {
    private ColumnType aBGgvFVujA;
    private string NrkgoRFju2;

    public ColumnType ColumnType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aBGgvFVujA;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.aBGgvFVujA = value;
      }
    }

    public string ColumnFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.NrkgoRFju2;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.NrkgoRFju2 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Column()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.aBGgvFVujA = ColumnType.Skipped;
      this.NrkgoRFju2 = "";
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToString(ColumnType columnType)
    {
      switch (columnType)
      {
        case ColumnType.AskSize:
          return RNaihRhYEl0wUmAftnB.aYu7exFQKN(30932);
        case ColumnType.Skipped:
          return RNaihRhYEl0wUmAftnB.aYu7exFQKN(30952);
        case ColumnType.BidSize:
          return RNaihRhYEl0wUmAftnB.aYu7exFQKN(30902);
        case ColumnType.Ask:
          return RNaihRhYEl0wUmAftnB.aYu7exFQKN(30922);
        case ColumnType.OpenInt:
          return RNaihRhYEl0wUmAftnB.aYu7exFQKN(30872);
        case ColumnType.Bid:
          return RNaihRhYEl0wUmAftnB.aYu7exFQKN(30892);
        case ColumnType.Close:
          return RNaihRhYEl0wUmAftnB.aYu7exFQKN(30842);
        case ColumnType.Volume:
          return RNaihRhYEl0wUmAftnB.aYu7exFQKN(30856);
        case ColumnType.High:
          return RNaihRhYEl0wUmAftnB.aYu7exFQKN(30820);
        case ColumnType.Low:
          return RNaihRhYEl0wUmAftnB.aYu7exFQKN(30832);
        case ColumnType.Size:
          return RNaihRhYEl0wUmAftnB.aYu7exFQKN(30796);
        case ColumnType.Open:
          return RNaihRhYEl0wUmAftnB.aYu7exFQKN(30808);
        case ColumnType.Symbol:
          return RNaihRhYEl0wUmAftnB.aYu7exFQKN(30722);
        case ColumnType.DateTime:
          return RNaihRhYEl0wUmAftnB.aYu7exFQKN(30738);
        case ColumnType.Date:
          return RNaihRhYEl0wUmAftnB.aYu7exFQKN(30758);
        case ColumnType.Time:
          return RNaihRhYEl0wUmAftnB.aYu7exFQKN(30770);
        case ColumnType.Price:
          return RNaihRhYEl0wUmAftnB.aYu7exFQKN(30782);
        default:
          throw new ArgumentException(RNaihRhYEl0wUmAftnB.aYu7exFQKN(30974) + ((object) columnType).ToString());
      }
    }
  }
}
