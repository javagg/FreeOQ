// Type: SmartQuant.Instruments.PortfolioList
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using VFUvY5knK01pUIalDo;

namespace SmartQuant.Instruments
{
  public class PortfolioList : IEnumerable
  {
    private SortedList wOyEHTauNW;
    private Hashtable pnfEc3IewS;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.wOyEHTauNW.Count;
      }
    }

    public Portfolio this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.wOyEHTauNW[(object) name] as Portfolio;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal PortfolioList()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.wOyEHTauNW = new SortedList();
      this.pnfEc3IewS = new Hashtable();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator Portfolio[](PortfolioList list)
    {
      return new ArrayList(list.wOyEHTauNW.Values).ToArray(typeof (Portfolio)) as Portfolio[];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void VJDEDjQE7o([In] Portfolio obj0)
    {
      if (this.wOyEHTauNW.Contains((object) obj0.Name))
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(5406) + obj0.Name);
      this.wOyEHTauNW.Add((object) obj0.Name, (object) obj0);
      if (obj0.Id == -1)
        return;
      if (this.pnfEc3IewS.Contains((object) obj0.Id))
        throw new ApplicationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(5530) + (object) obj0.Id);
      this.pnfEc3IewS.Add((object) obj0.Id, (object) obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void kD1E0Sjpl1([In] Portfolio obj0)
    {
      this.wOyEHTauNW.Remove((object) obj0.Name);
      this.pnfEc3IewS.Remove((object) obj0.Id);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Portfolio GetById(int id)
    {
      return this.pnfEc3IewS[(object) id] as Portfolio;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(string name)
    {
      return this.wOyEHTauNW.ContainsKey((object) name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Rename(string oldName, string newName)
    {
      Portfolio portfolio = this[oldName];
      portfolio.Name = newName;
      this.wOyEHTauNW.Remove((object) oldName);
      this.wOyEHTauNW.Add((object) newName, (object) portfolio);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.wOyEHTauNW.Values.GetEnumerator();
    }
  }
}
