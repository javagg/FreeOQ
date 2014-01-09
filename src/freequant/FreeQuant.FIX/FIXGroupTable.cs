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

    public FIXGroupTable():base()
    {

      this.QNhZdTCxCY = new Hashtable();
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
