using FreeQuant.Testing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Pertrac
{
  public class FinalWealth : SimpleItem
  {
    protected LiveTester tester;

    public override double LastValue
    {
       get
      {
        return this.tester.FinalWealth;
      }
    }

    
    public FinalWealth(string name, LiveTester tester, string format)
			:  base(name, format) {
      this.tester = tester;
    }

    
    public FinalWealth(string name, LiveTester tester)
			:      base(name, "")
		{
      this.tester = tester;
    }

    
		public FinalWealth(string name) :   base(name)
    {
    }
  }
}
