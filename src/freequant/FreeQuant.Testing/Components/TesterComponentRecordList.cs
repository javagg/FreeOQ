using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Testing.Components
{
  public class TesterComponentRecordList : ICollection, IEnumerable
  {
    private Hashtable jLpy88DHjp;

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jLpy88DHjp.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jLpy88DHjp.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jLpy88DHjp.SyncRoot;
      }
    }

    public TesterComponentRecord this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jLpy88DHjp[(object) name] as TesterComponentRecord;
      }
    }


		public TesterComponentRecordList():base()
    {
      this.jLpy88DHjp = new Hashtable();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.jLpy88DHjp.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.jLpy88DHjp.Values.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void x1QyU3cJOi([In] TesterComponentRecord obj0)
    {
      this.jLpy88DHjp.Add((object) obj0.Name, (object) obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void YnJykIGr6N([In] string obj0)
    {
      this.jLpy88DHjp.Remove((object) obj0);
    }
  }
}
