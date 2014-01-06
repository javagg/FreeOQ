// Type: SmartQuant.Optimization.TwoParams
// Assembly: SmartQuant.Optimization, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 1C417731-0514-4808-9329-6B635F19637E
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Optimization.dll

using E32I8CMPFnk6XwkgnC;
using System.Runtime.CompilerServices;

namespace SmartQuant.Optimization
{
  public struct TwoParams
  {
    private double CwWkYwplC;
    private double vfgdZxO2y;

    public double Param1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.CwWkYwplC;
      }
    }

    public double Param2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.vfgdZxO2y;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TwoParams(double param1, double param2)
    {
      C7bjlF4Ph208kGmVJO.IHdBTbCzDaa6o();
      this.CwWkYwplC = param1;
      this.vfgdZxO2y = param2;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj)
    {
      TwoParams twoParams = (TwoParams) obj;
      if (twoParams.CwWkYwplC == this.CwWkYwplC)
        return twoParams.vfgdZxO2y == this.vfgdZxO2y;
      else
        return false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode()
    {
      return 1;
    }
  }
}
