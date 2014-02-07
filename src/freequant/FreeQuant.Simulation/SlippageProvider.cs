using System.ComponentModel;
using FreeQuant.FIX;

namespace FreeQuant.Simulation
{
	public class SlippageProvider : ISlippageProvider
	{
		[Description("Slippage in percents, 0.01 = 1%")]
		[DefaultValue(0.0)]
		[Category("Parameter")]
		public double Slippage { get; set; }

		public double GetExecutionPrice(ExecutionReport report)
		{
			double avgPx = report.AvgPx;
			if (report.OrdStatus == OrdStatus.Filled)
			{
				switch (report.Side)
				{
					case Side.Buy:
						avgPx += avgPx * this.Slippage;
						break;
					case Side.Sell:
					case Side.SellShort:
						avgPx -= avgPx * this.Slippage;
						break;
				}
			}
			return report.AvgPx = avgPx;
		}

		public override string ToString()
		{
			return "SlippageProvider";
		}
	}
}
