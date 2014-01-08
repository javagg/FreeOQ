using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Optimization
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
  public class OptimizationParameterAttribute : Attribute
  {
    private double LdRDXSRAOu;
    private double FESDpQtr6q;
    private double DadDi5QRSS;

    public double LowerBound
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.LdRDXSRAOu;
      }
    }

    public double UpperBound
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.FESDpQtr6q;
      }
    }

    public double Step
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.DadDi5QRSS;
      }
    }

	public OptimizationParameterAttribute(double lowerBound, double upperBound, double step) : base()
    {

      this.LdRDXSRAOu = lowerBound;
      this.FESDpQtr6q = upperBound;
      this.DadDi5QRSS = step;
    }

	public OptimizationParameterAttribute(double lowerBound, double upperBound) : base()
    {
      this.LdRDXSRAOu = lowerBound;
      this.FESDpQtr6q = upperBound;
      this.DadDi5QRSS = 1.0;
    }
  }
}
