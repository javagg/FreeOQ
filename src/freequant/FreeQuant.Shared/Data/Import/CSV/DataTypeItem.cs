// Type: SmartQuant.Shared.Data.Import.CSV.DataTypeItem
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class DataTypeItem
  {
    private DataType mjxdnU89b0;
    private ArrayList Awnd7GaIPh;

    public DataType DataType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mjxdnU89b0;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataTypeItem(DataType dataType, ColumnType[] allowedColumns)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.mjxdnU89b0 = dataType;
      this.Awnd7GaIPh = new ArrayList((ICollection) allowedColumns);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return ((object) this.mjxdnU89b0).ToString();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsColumnAllowed(ColumnType columnType)
    {
      return this.Awnd7GaIPh.Contains((object) columnType);
    }
  }
}
