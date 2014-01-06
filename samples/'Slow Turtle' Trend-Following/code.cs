using OpenQuant.API;
using OpenQuant.API.Indicators;

using System.Drawing;

public class MyStrategy : Strategy
{
	// quantity to buy on a trade
	[Parameter("Order quantity (number of contracts to trade)")]	
	double Qty = 100;
	
	[Parameter("Bar Block Size")]
	int BarBlockSize = 6;
	
	[Parameter("Length of SMA in blocks (weeks)", "SMA")]
	int FastSMALength = 22;
	
	[Parameter("Length of SMA in blocks (weeks)", "SMA")]
	int SlowSMALength = 55;

	int positionInBlock = 0;
	bool buyOnNewBlock;
	bool sellOnNewBlock;
	
	// two moving averages
	SMA fastSMA;
	SMA slowSMA;
	
	public override void OnStrategyStart()
	{		
		// set up the fast average
		fastSMA = new SMA(Bars, FastSMALength * 7, Color.Yellow);		
		Draw(fastSMA, 0);
		// set up the slow average
		slowSMA = new SMA(Bars, SlowSMALength * 7, Color.Pink);		
		Draw(slowSMA, 0);
	}

	public override void OnBarOpen(Bar bar)
	{
		// calc quantity to reverse a position
		double orderQty = 2 * Qty;

		if (!HasPosition)
			orderQty = Qty;

		if (positionInBlock == 0)
		{
			if (buyOnNewBlock)
			{
				Buy(orderQty, "Reverse to Long");

				buyOnNewBlock = false;
			}

			if (sellOnNewBlock)
			{
				Sell(orderQty, "Reverse to Short");				

				sellOnNewBlock = false;
			}
		}
	}

	public override void OnBar(Bar bar)
	{
		// if our SMAs contain the current bar date
		if (fastSMA.Contains(bar.DateTime) && slowSMA.Contains(bar.DateTime))
		{
			// see which one is above the other
			Cross cross = fastSMA.Crosses(slowSMA, bar);

			if (cross == Cross.Above)
				buyOnNewBlock = true;

			if (cross == Cross.Below)
				sellOnNewBlock = true;
		}

		positionInBlock = (positionInBlock++) % BarBlockSize;
	}
}
