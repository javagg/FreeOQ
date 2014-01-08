using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Simulation
{
  public class SlippageProvider : ISlippageProvider
  {
    private double HvMPtuVkeV;

    [Description("Slippage in percents, 0.01 = 1%")]
    [DefaultValue(0.0)]
    [Category("Parameter")]
    public double Slippage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.HvMPtuVkeV;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.HvMPtuVkeV = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SlippageProvider()
    {
      eekpcgzPjZLOyP2Ysv.eyppkuTzDkifX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetExecutionPrice(ExecutionReport report)
    {
      double avgPx = report.AvgPx;
      if (report.OrdStatus == OrdStatus.Filled)
      {
        switch (report.Side)
        {
          case Side.Buy:
            avgPx += avgPx * this.HvMPtuVkeV;
            break;
          case Side.Sell:
          case Side.SellShort:
            avgPx -= avgPx * this.HvMPtuVkeV;
            break;
        }
      }
      return report.AvgPx = avgPx;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return v6F3C32VVUpp2OYb5n.VVyFVqM4b6(4850);
    }
  }
}
