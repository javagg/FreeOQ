using FreeQuant.Testing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Pertrac
{
  public class TotalDays : SimpleItem
  {
    protected LiveTester tester;

    public override double LastValue
    {
       get
      {
        return (double) this.tester.TestDays;
      }
    }

    
    public TotalDays(string name, LiveTester tester, string format)
			:  base(name, format)  {

      this.tester = tester;
    }

    
    public TotalDays(string name, LiveTester tester)
			:      base(name) {
        this.tester = tester;
    }

    
		public TotalDays(string name) : base(name)
    {

    }
  }
}
