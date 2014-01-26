using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading.Conditions
{
  public abstract class Condition : RuleItem
  {
    protected Hashtable childs;

    public Hashtable Childs
    {
       get
      {
        return this.childs;
      }
    }

    
		public Condition():base()
    {
      this.childs = new Hashtable();
    }

    public abstract string GetInitCode(string name);
  }
}
