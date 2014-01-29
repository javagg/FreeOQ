using System.Runtime.CompilerServices;

namespace FreeQuant.Optimization
{
	public struct TwoParams
	{
		public double Param1 { get; private set; }
		public double Param2 { get; private set; }

		public TwoParams(double param1 = 0, double param2 = 0) : this()
		{
			this.Param1 = param1;
			this.Param2 = param2;
		}

		public override bool Equals(object obj)
		{
			TwoParams twoParams = (TwoParams)obj;
			return (twoParams.Param1 == this.Param1) && (twoParams.Param2 == this.Param2);
		}

		public override int GetHashCode()
		{
			return 1;
		}
	}
}
