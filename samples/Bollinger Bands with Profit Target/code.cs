using OpenQuant.API;
using OpenQuant.API.Indicators;

using System.Drawing;

public class MyStrategy : Strategy
{
	[Parameter("Order quantity (number of contracts to trade)")]
	double Qty = 100;

	[Parameter("Bollinger Band level to go long")]
	double BLevel = -20;

	[Parameter("Percent profit target")]
	double ProfitPercent = 15;

	[Parameter("Max number of bars, while position is active")]
	int MaxDuration = 4;

	[Parameter("Length of Bollinger Band")]
	int BLength = 10;

	[Parameter("Order of Bollinger Band")]
	double BOrder = 1.5;

	B b;
	int barsFromEntry = 0;
	double exitPrice;
	Order sellOrder;
	Order buyOrder;

	public override void OnStrategyStart()
	{
		// set up bollinger bands
		BBL bbl = new BBL(Bars, BLength, BOrder, Color.Pink);

		// set up a series for B (breakout force) value
		b = new B(Bars, BLength, BOrder, Color.Yellow);

		Draw(bbl, 0);
		Draw(b, 2);
	}

	public override void OnBar(Bar bar)
	{
		// good practice to check if a series has the date you are interested in before you try 
		// to use it
		if (b.Contains(bar))
		{
			// if we don't have a position and prices are below the lower band, open a long position
			if (!HasPosition)
			{
				if (b[bar.DateTime] * 100 <= BLevel)
				{
					buyOrder = BuyOrder(Qty, "Entry");
					buyOrder.Send();
				}
			}
			else
			{
				barsFromEntry++;

				// if we _have_ reached the exit day (4 days after entry), cancel the profit target 
				// sell order, and issue a new market order to close the position now.
				if (barsFromEntry == MaxDuration)
				{
					barsFromEntry = 0;

					// cancel existing sell order if there is one
					if (sellOrder != null)
						sellOrder.Cancel();

					Sell(Qty, "Exit (Max Duration)");
				}
			}
		}
	}

	public override void OnPositionOpened()
	{
		// when a position is opened, calculate profit target
		exitPrice = buyOrder.AvgPrice * (1 + ProfitPercent / 100);

		// cancel existing sell order if there is one
		if (sellOrder != null)
			sellOrder.Cancel();

		// issue a new sell limit order at the profit target price
		sellOrder = SellLimitOrder(Qty, exitPrice, "Exit (Profit Target)");
		sellOrder.Send();
	}

	public override void OnPositionClosed()
	{
		barsFromEntry = 0;
	}
}
