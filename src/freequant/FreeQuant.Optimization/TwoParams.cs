using System.Runtime.CompilerServices;

namespace FreeQuant.Optimization
{
  public struct TwoParams
  {
    private double CwWkYwplC;
    private double vfgdZxO2y;

    public double Param1
    {
       get
      {
        return this.CwWkYwplC;
      }
    }

    public double Param2
    {
       get
      {
        return this.vfgdZxO2y;
      }
    }

	public TwoParams(double param1, double param2) 
    {

      this.CwWkYwplC = param1;
      this.vfgdZxO2y = param2;
    }

    public override bool Equals(object obj)
    {
      TwoParams twoParams = (TwoParams) obj;
      if (twoParams.CwWkYwplC == this.CwWkYwplC)
        return twoParams.vfgdZxO2y == this.vfgdZxO2y;
      else
        return false;
    }

    public override int GetHashCode()
    {
      return 1;
    }
  }
}
