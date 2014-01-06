using System;

namespace OpenQuant.API
{
  [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
  public class OptimizationParameterAttribute : Attribute
  {
    private double start;
    private double stop;
    private double step;

    public double Start
    {
      get
      {
        return this.start;
      }
    }

    public double Stop
    {
      get
      {
        return this.stop;
      }
    }

    public double Step
    {
      get
      {
        return this.step;
      }
    }

    public OptimizationParameterAttribute(double start, double stop, double step)
    {
      this.start = start;
      this.stop = stop;
      this.step = step;
    }
  }
}
