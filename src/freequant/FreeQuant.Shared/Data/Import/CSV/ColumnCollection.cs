// Type: SmartQuant.Shared.Data.Import.CSV.ColumnCollection
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class ColumnCollection : CollectionBase
  {
    public Column this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.List[index] as Column;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColumnCollection()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Column column)
    {
      this.List.Add((object) column);
    }
  }
}
