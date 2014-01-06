using OpenQuant.API;
using OpenQuant.API.Indicators;

using System.Drawing;

public class MyStrategy : Strategy
{
	[Parameter("Order quantity (number of contracts to trade)")]
	double Qty = 100;
	
	[Parameter("Length of SMA")]
	int SMALength = 20;
	
	[Parameter("Order of BBL")]
	double BBLOrder = 2;

	// indicators
	BBL bbl;
	SMA sma;	

	Order buyOrder;
	Order sellOrder;

	public override void OnStrategyStart()
	{
		// set up the moving averages 
		sma = new SMA(Bars, SMALength);
		sma.Color = Color.Yellow;
		Draw(sma, 0);
		// set up bollinger bands
		bbl = new BBL(Bars, SMALength, BBLOrder);
		bbl.Color = Color.Pink;
		Draw(bbl, 0);
	}

	public override void OnBar(Bar bar)
	{
		// always a good practice to be sure a series contains
		// a bar for a particular date before you try to use it
		if (bbl.Contains(bar.DateTime))
		{
			// We are always trying to buy at the lower Bollinger
			// limit, and sell when the price goes up to the 
			// latest SMA value. So we are constantly
			// updating both the buy point and the sell point.

			// if we don't have an open position in this instrument,
			// update the buy point to the latest lower bbl limit 
			if (!HasPosition)
			{
				if (buyOrder != null)
					buyOrder.Cancel();

				buyOrder = BuyLimitOrder(Qty, bbl.Last, "Entry");				
				buyOrder.Send();
			}

				// else if we already have a position going, update 
				// the sell point to follow the latest SMA value 
			else
				UpdateExitLimit();
		}
	}

	public override void OnPositionOpened()
	{
		UpdateExitLimit();
	}

	private void UpdateExitLimit()
	{
		// cancel old exit point order, if it exists
		if (sellOrder != null)
			sellOrder.Cancel();
		// Issue a new order with the latest SMA value. This is 
		// kind of a "trailing SMA sell order" that follows the SMA.
		sellOrder = SellLimitOrder(Qty, sma.Last, "Exit");		
		sellOrder.Send();
	}
}
