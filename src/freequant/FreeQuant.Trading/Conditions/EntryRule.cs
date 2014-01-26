using FreeQuant.Trading;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading.Conditions
{
  public class EntryRule
  {
		private FreeQuant.Trading.Entry A6AjNEf2lw;
    private ArrayList TILjzjh40W;
    private SignalItem pLmWkBkPge;
    private SignalItem I8JWpL5Fgi;

    public SignalItem LongEntry
    {
       get
      {
        return this.pLmWkBkPge;
      }
    }

    public SignalItem ShortEntry
    {
       get
      {
        return this.I8JWpL5Fgi;
      }
    }

    public ArrayList ItemList
    {
       get
      {
        return this.TILjzjh40W;
      }
    }

    
		public EntryRule(FreeQuant.Trading.Entry entry)
    {
      this.A6AjNEf2lw = entry;
      this.mYhjgGMMit();
    }

    
    private void mYhjgGMMit()
    {
      this.TILjzjh40W = new ArrayList();
      this.pLmWkBkPge = new SignalItem(SignalItemType.Long, (IStrategyComponent) this.A6AjNEf2lw);
      this.I8JWpL5Fgi = new SignalItem(SignalItemType.Short, (IStrategyComponent) this.A6AjNEf2lw);
    }

    
    public void Add(RuleItem ruleItem)
    {
      this.TILjzjh40W.Add((object) ruleItem);
    }

    
    public void Execute()
    {
      foreach (RuleItem ruleItem in this.TILjzjh40W)
        ruleItem.Execute();
    }
  }
}
