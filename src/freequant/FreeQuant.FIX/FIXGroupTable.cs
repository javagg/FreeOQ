// Type: SmartQuant.FIX.FIXGroupTable
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXGroupTable : IEnumerable
  {
    private Hashtable QNhZdTCxCY;

    public ArrayList this[int tag]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QNhZdTCxCY[(object) tag] as ArrayList;
      }
    }

    public ArrayList this[FIXGroup group]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QNhZdTCxCY[(object) group.Tag] as ArrayList;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXGroupTable()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.QNhZdTCxCY = new Hashtable();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(FIXGroup group)
    {
      ArrayList arrayList = this[group.Tag];
      if (arrayList == null)
      {
        arrayList = new ArrayList();
        this.QNhZdTCxCY.Add((object) group.Tag, (object) arrayList);
      }
      arrayList.Add((object) group);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.QNhZdTCxCY.Values.GetEnumerator();
    }
  }
}
