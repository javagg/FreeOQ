using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Instruments
{
  public class PortfolioList : IEnumerable
  {
		private SortedList portfolios; 
    private Hashtable pnfEc3IewS;

    public int Count
    {
       get
      {
        return this.portfolios.Count;
      }
    }

    public Portfolio this[string name]
    {
       get
      {
        return this.portfolios[(object) name] as Portfolio;
      }
    }

    
    internal PortfolioList()
    {
      this.portfolios = new SortedList();
      this.pnfEc3IewS = new Hashtable();
    }

    
    public static implicit operator Portfolio[](PortfolioList list)
    {
      return new ArrayList(list.portfolios.Values).ToArray(typeof (Portfolio)) as Portfolio[];
    }

    
    internal void VJDEDjQE7o([In] Portfolio obj0)
    {
      if (this.portfolios.Contains((object) obj0.Name))
				throw new ApplicationException("" + obj0.Name);
      this.portfolios.Add((object) obj0.Name, (object) obj0);
      if (obj0.Id == -1)
        return;
      if (this.pnfEc3IewS.Contains((object) obj0.Id))
				throw new ApplicationException("" + (object) obj0.Id);
      this.pnfEc3IewS.Add((object) obj0.Id, (object) obj0);
    }

    
    internal void kD1E0Sjpl1([In] Portfolio obj0)
    {
      this.portfolios.Remove((object) obj0.Name);
      this.pnfEc3IewS.Remove((object) obj0.Id);
    }

    
    public Portfolio GetById(int id)
    {
      return this.pnfEc3IewS[(object) id] as Portfolio;
    }

    
    public bool Contains(string name)
    {
      return this.portfolios.ContainsKey((object) name);
    }

    
    public void Rename(string oldName, string newName)
    {
      Portfolio portfolio = this[oldName];
      portfolio.Name = newName;
      this.portfolios.Remove((object) oldName);
      this.portfolios.Add((object) newName, (object) portfolio);
    }

    
    public IEnumerator GetEnumerator()
    {
      return this.portfolios.Values.GetEnumerator();
    }
  }
}
