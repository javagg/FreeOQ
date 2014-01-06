using OpenQuant.API;
using OpenQuant.API.Indicators;

using System.Drawing;

public class MyStrategy : Strategy
{
	[Parameter("Length of SMA")]
	int Length = 200;

	[Parameter("Order quantity (number of contracts to trade)")]
	double Qty = 100;

	SMA sma;
	double prevClose = -1;

	public override void OnStrategyStart()
	{
		sma = new SMA(Bars, Length, Color.Yellow);

		Draw(sma, 0);
	}

	public override void OnBar(Bar bar)
	{
		if (sma.Contains(bar))
		{
			if (prevClose != -1)
			{
				if (!HasPosition && prevClose <= sma[bar] && bar.Close > sma[bar])
					Buy(Qty, "Entry");

				if (HasPosition && prevClose >= sma[bar] && bar.Close < sma[bar])
					Sell(Qty, "Exit");
			}

			prevClose = bar.Close;
		}
	}
}
