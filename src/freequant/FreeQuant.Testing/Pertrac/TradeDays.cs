using FreeQuant.Testing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Pertrac
{
  public class TradeDays : SimpleItem
  {
    protected LiveTester tester;

    public override double LastValue
    {
       get
      {
        return (double) this.tester.TradeDays;
      }
    }

    
    public TradeDays(string name, LiveTester tester, string format)
			: base(name, format)
		{

      this.tester = tester;
    }

    
    public TradeDays(string name, LiveTester tester)
			:      base(name) {
      this.tester = tester;
    }

    
		public TradeDays(string name) : base(name)
    {

    }
  }
}
