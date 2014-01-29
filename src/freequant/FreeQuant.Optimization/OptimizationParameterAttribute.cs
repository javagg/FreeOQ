using System;

namespace FreeQuant.Optimization
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
	public class OptimizationParameterAttribute : Attribute
	{
		public double LowerBound { get; private set; }
		public double UpperBound { get; private set; }
		public double Step { get; private set; }

		public OptimizationParameterAttribute(double lowerBound, double upperBound, double step = 1.0) : base()
		{
			this.LowerBound = lowerBound;
			this.UpperBound = upperBound;
			this.Step = step;
		}
	}
}
