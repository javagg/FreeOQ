// Type: SmartQuant.Trading.Conditions.EntryRule
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SmartQuant.Trading;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading.Conditions
{
  public class EntryRule
  {
    private SmartQuant.Trading.Entry A6AjNEf2lw;
    private ArrayList TILjzjh40W;
    private SignalItem pLmWkBkPge;
    private SignalItem I8JWpL5Fgi;

    public SignalItem LongEntry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.pLmWkBkPge;
      }
    }

    public SignalItem ShortEntry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.I8JWpL5Fgi;
      }
    }

    public ArrayList ItemList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.TILjzjh40W;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EntryRule(SmartQuant.Trading.Entry entry)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.A6AjNEf2lw = entry;
      this.mYhjgGMMit();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void mYhjgGMMit()
    {
      this.TILjzjh40W = new ArrayList();
      this.pLmWkBkPge = new SignalItem(SignalItemType.Long, (IStrategyComponent) this.A6AjNEf2lw);
      this.I8JWpL5Fgi = new SignalItem(SignalItemType.Short, (IStrategyComponent) this.A6AjNEf2lw);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(RuleItem ruleItem)
    {
      this.TILjzjh40W.Add((object) ruleItem);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute()
    {
      foreach (RuleItem ruleItem in this.TILjzjh40W)
        ruleItem.Execute();
    }
  }
}
