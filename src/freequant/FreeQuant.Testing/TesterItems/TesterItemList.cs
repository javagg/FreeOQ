// Type: SmartQuant.Testing.TesterItems.TesterItemList
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Testing.TesterItems
{
  public class TesterItemList : ICollection, IEnumerable
  {
    private SortedList hkbUUuuoD;
    private bool V66kiXDe9;

    public bool ActivateItemOnRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.V66kiXDe9;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.V66kiXDe9 = value;
      }
    }

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.hkbUUuuoD.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.hkbUUuuoD.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.hkbUUuuoD.SyncRoot;
      }
    }

    public TesterItem this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        TesterItem testerItem = this.hkbUUuuoD[(object) name] as TesterItem;
        if (this.V66kiXDe9 && testerItem is SeriesTesterItem)
          (testerItem as SeriesTesterItem).Enabled = true;
        return testerItem;
      }
    }

    public TesterItem this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        TesterItem testerItem = this.hkbUUuuoD.GetByIndex(index) as TesterItem;
        if (this.V66kiXDe9 && testerItem is SeriesTesterItem)
          (testerItem as SeriesTesterItem).Enabled = true;
        return testerItem;
      }
    }

    public event EventHandler ComponentListChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TesterItemList()
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.hkbUUuuoD = new SortedList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.hkbUUuuoD.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.hkbUUuuoD.Values.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void f9Ww98OVG([In] TesterItem obj0)
    {
      this.hkbUUuuoD.Remove((object) obj0.Name);
      this.hkbUUuuoD.Add((object) obj0.Name, (object) obj0);
      obj0.ComponentNameChanged += new TesterComponentNameEventHandler(this.Jg1BmDxeQ);
      this.XTfEbTDSH();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RY4dKuMHX([In] string obj0)
    {
      if (!this.hkbUUuuoD.Contains((object) obj0))
        return;
      TesterItem testerItem = this.hkbUUuuoD[(object) obj0] as TesterItem;
      this.hkbUUuuoD.Remove((object) obj0);
      testerItem.ComponentNameChanged -= new TesterComponentNameEventHandler(this.Jg1BmDxeQ);
      this.XTfEbTDSH();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void TTi4Kk2c9()
    {
      foreach (TesterItem testerItem in this.hkbUUuuoD)
        this.RY4dKuMHX(testerItem.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(string name)
    {
      return this.hkbUUuuoD.ContainsKey((object) name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Jg1BmDxeQ([In] TesterItem obj0, [In] ComponentNameEventArgs obj1)
    {
      this.hkbUUuuoD.Remove((object) obj1.OldName);
      this.hkbUUuuoD.Add((object) obj1.NewName, (object) obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void XTfEbTDSH()
    {
      if (this.eBL8bwjVC == null)
        return;
      this.eBL8bwjVC((object) this, EventArgs.Empty);
    }
  }
}
