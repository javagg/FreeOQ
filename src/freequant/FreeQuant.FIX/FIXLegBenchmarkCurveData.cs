using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXLegBenchmarkCurveData : FIXMessage
  {
    [FIXField("676", EFieldOption.Optional)]
    public double LegBenchmarkCurveCurrency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(676).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(676, value);
      }
    }

    [FIXField("677", EFieldOption.Optional)]
    public string LegBenchmarkCurveName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(677).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(677, value);
      }
    }

    [FIXField("678", EFieldOption.Optional)]
    public string LegBenchmarkCurvePoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(678).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(678, value);
      }
    }

    [FIXField("679", EFieldOption.Optional)]
    public double LegBenchmarkPrice
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(679).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(679, value);
      }
    }

    [FIXField("680", EFieldOption.Optional)]
    public int LegBenchmarkPriceType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(680).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(680, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXLegBenchmarkCurveData()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
