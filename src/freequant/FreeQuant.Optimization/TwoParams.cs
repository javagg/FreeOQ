namespace FreeQuant.Optimization
{
	public struct TwoParams
	{
		private double param1;
		private double param2;

		public double Param1
		{
			get
			{
				return param1;
			}
		}

		public double Param2 
		{
			get
			{
				return param2;
			}
		}

		public TwoParams(double param1, double param2)
		{
			this.param1 = param1;
			this.param2 = param2;
		}

		public override bool Equals(object obj)
		{
			TwoParams that = (TwoParams)obj;
			return (that.Param1 == this.Param1) && (that.Param2 == this.Param2);
		}

		public override int GetHashCode()
		{
			return 1;
		}
	}
}
