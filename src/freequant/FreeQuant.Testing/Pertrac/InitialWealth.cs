using FreeQuant.Testing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Pertrac
{
  public class InitialWealth : SimpleItem
  {
    protected LiveTester tester;

    public override double LastValue
    {
      get
      {
        return this.tester.InitialWealth;
      }
    }

   
    public InitialWealth(string name, LiveTester tester, string format)
			: base(name, format) {
      this.tester = tester;
    }

   
    public InitialWealth(string name, LiveTester tester)
			:     base(name, "")
		 {
       this.tester = tester;
    }

   
		public InitialWealth(string name) : base(name)
    {
    }
  }
}
