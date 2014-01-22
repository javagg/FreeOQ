using System.ComponentModel;
using System.Runtime.CompilerServices;
using FreeQuant.FIX;

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
       get
      {
        return this.HvMPtuVkeV;
      }
       set
      {
        this.HvMPtuVkeV = value;
      }
    }

    
    public SlippageProvider()
    {

    }

    
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

    
    public override string ToString()
    {
			return "";
    }
  }
}
