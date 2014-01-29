using System;

namespace OpenQuant.API
{
	/// <summary>
	/// Optimization parameter attribute
	/// </summary>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class OptimizationParameterAttribute : Attribute
	{
		/// <summary>
		/// Start value of the parameter
		/// </summary>
		public double Start { get; private set; }

		/// <summary>
		/// Stop value of the parameter
		/// </summary>
		public double Stop { get; private set; }

		/// <summary>
		/// Step value of the parameter
		/// </summary>
		public double Step { get; private set; }

		/// <summary>
		/// Creates an instance of this attribute
		/// </summary>
		public OptimizationParameterAttribute(double start, double stop, double step)
		{
			this.Start = start;
			this.Stop = stop;
			this.Step = step;
		}
	}
}
