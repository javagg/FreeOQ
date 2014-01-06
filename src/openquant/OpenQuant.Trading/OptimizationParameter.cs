using FreeQuant.Optimization;

namespace OpenQuant.Trading
{
  public class OptimizationParameter
  {
    private EParamType type;
    private string name;
    private double start;
    private double stop;
    private double step;
    private bool enabled;
    private int number;
    private string strategy;

    public string Strategy
    {
      get
      {
        return this.strategy;
      }
    }

    public EParamType Type
    {
      get
      {
        return this.type;
      }
    }

    public string Name
    {
      get
      {
        return this.name;
      }
    }

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

    public bool Enabled
    {
      get
      {
        return this.enabled;
      }
      set
      {
        this.enabled = value;
      }
    }

    public int Number
    {
      get
      {
        return this.number;
      }
      set
      {
        this.number = value;
      }
    }

    public int Loops
    {
      get
      {
        if (this.stop <= this.start)
          return 1;
        else
          return (int) ((this.stop - this.start) / this.step) + 1;
      }
    }

    public OptimizationParameter(string strategy, string name, double start, double stop, double step, EParamType type)
    {
      this.strategy = strategy;
      this.type = type;
      this.name = name;
      this.start = start;
      this.stop = stop;
      this.step = step;
      this.enabled = true;
    }

    public override string ToString()
    {
      return this.name;
    }
  }
}
