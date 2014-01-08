using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
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
