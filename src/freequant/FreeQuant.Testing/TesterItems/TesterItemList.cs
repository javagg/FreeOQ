using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Testing.TesterItems
{
  public class TesterItemList : ICollection, IEnumerable
  {
    private SortedList hkbUUuuoD;
    private bool V66kiXDe9;

    public bool ActivateItemOnRequest
    {
      get
      {
        return this.V66kiXDe9;
      }
      set
      {
        this.V66kiXDe9 = value;
      }
    }

    public bool IsSynchronized
    {
      get
      {
        return this.hkbUUuuoD.IsSynchronized;
      }
    }

    public int Count
    {
      get
      {
        return this.hkbUUuuoD.Count;
      }
    }

    public object SyncRoot
    {
      get
      {
        return this.hkbUUuuoD.SyncRoot;
      }
    }

    public TesterItem this[string name]
    {
      get
      {
        TesterItem testerItem = this.hkbUUuuoD[(object) name] as TesterItem;
        if (this.V66kiXDe9 && testerItem is SeriesTesterItem)
          (testerItem as SeriesTesterItem).Enabled = true;
        return testerItem;
      }
    }

    public TesterItem this[int index]
    {
      get
      {
        TesterItem testerItem = this.hkbUUuuoD.GetByIndex(index) as TesterItem;
        if (this.V66kiXDe9 && testerItem is SeriesTesterItem)
          (testerItem as SeriesTesterItem).Enabled = true;
        return testerItem;
      }
    }

    public event EventHandler ComponentListChanged;

   
		public TesterItemList():base()
    {

      this.hkbUUuuoD = new SortedList();
    }

   
    public void CopyTo(Array array, int index)
    {
      this.hkbUUuuoD.CopyTo(array, index);
    }

   
    public IEnumerator GetEnumerator()
    {
      return this.hkbUUuuoD.Values.GetEnumerator();
    }

   
    internal void f9Ww98OVG([In] TesterItem obj0)
    {
      this.hkbUUuuoD.Remove((object) obj0.Name);
      this.hkbUUuuoD.Add((object) obj0.Name, (object) obj0);
      obj0.ComponentNameChanged += new TesterComponentNameEventHandler(this.Jg1BmDxeQ);
      this.XTfEbTDSH();
    }

   
    internal void RY4dKuMHX([In] string obj0)
    {
      if (!this.hkbUUuuoD.Contains((object) obj0))
        return;
      TesterItem testerItem = this.hkbUUuuoD[(object) obj0] as TesterItem;
      this.hkbUUuuoD.Remove((object) obj0);
      testerItem.ComponentNameChanged -= new TesterComponentNameEventHandler(this.Jg1BmDxeQ);
      this.XTfEbTDSH();
    }

   
    internal void TTi4Kk2c9()
    {
      foreach (TesterItem testerItem in this.hkbUUuuoD)
        this.RY4dKuMHX(testerItem.Name);
    }

   
    public bool Contains(string name)
    {
      return this.hkbUUuuoD.ContainsKey((object) name);
    }

   
    private void Jg1BmDxeQ([In] TesterItem obj0, [In] ComponentNameEventArgs obj1)
    {
      this.hkbUUuuoD.Remove((object) obj1.OldName);
      this.hkbUUuuoD.Add((object) obj1.NewName, (object) obj0);
    }

   
    private void XTfEbTDSH()
    {
//      if (this.eBL8bwjVC == null)
//        return;
//      this.eBL8bwjVC((object) this, EventArgs.Empty);
    }
  }
}
