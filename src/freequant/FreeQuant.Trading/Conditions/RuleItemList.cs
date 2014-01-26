using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading.Conditions
{
  public class RuleItemList : ICollection, IEnumerable
  {
    private ArrayList aC6RxcUWk1;

    public bool IsSynchronized
    {
       get
      {
        return this.aC6RxcUWk1.IsSynchronized;
      }
    }

    public int Count
    {
       get
      {
        return this.aC6RxcUWk1.Count;
      }
    }

    public object SyncRoot
    {
       get
      {
        return this.aC6RxcUWk1.SyncRoot;
      }
    }

    public RuleItem this[int index]
    {
       get
      {
        return this.aC6RxcUWk1[index] as RuleItem;
      }
    }

    
		public RuleItemList():base()
    {
      this.aC6RxcUWk1 = new ArrayList();
    }

    
    public void CopyTo(Array array, int index)
    {
      this.aC6RxcUWk1.CopyTo(array, index);
    }

    
    public IEnumerator GetEnumerator()
    {
      return this.aC6RxcUWk1.GetEnumerator();
    }

    
    public void Add(RuleItem item)
    {
      this.aC6RxcUWk1.Add((object) item);
    }

    
    public void Remove(RuleItem item)
    {
      this.aC6RxcUWk1.Remove((object) item);
    }

    
    public void Clear()
    {
      this.aC6RxcUWk1.Clear();
    }

    
    public void Execute()
    {
      foreach (RuleItem ruleItem in this.aC6RxcUWk1)
        ruleItem.Execute();
    }
  }
}
