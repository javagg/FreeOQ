// Type: SmartQuant.Trading.Conditions.RuleItemList
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading.Conditions
{
  public class RuleItemList : ICollection, IEnumerable
  {
    private ArrayList aC6RxcUWk1;

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aC6RxcUWk1.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aC6RxcUWk1.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aC6RxcUWk1.SyncRoot;
      }
    }

    public RuleItem this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aC6RxcUWk1[index] as RuleItem;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RuleItemList()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.aC6RxcUWk1 = new ArrayList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.aC6RxcUWk1.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.aC6RxcUWk1.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(RuleItem item)
    {
      this.aC6RxcUWk1.Add((object) item);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(RuleItem item)
    {
      this.aC6RxcUWk1.Remove((object) item);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.aC6RxcUWk1.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute()
    {
      foreach (RuleItem ruleItem in this.aC6RxcUWk1)
        ruleItem.Execute();
    }
  }
}
