using OpenQuant.API;
using OpenQuant.API.Indicators;

using System.Drawing;

public class MyStrategy : Strategy
{
	[Parameter("Order quantity (number of contracts to trade)")]
	double Qty = 100;
	
	[Parameter("Length of BBL")]
	int BBLLength = 10;
	
	[Parameter("Order of BBL")]
	double BBLOrder = 1.5;	
	
	[Parameter("Max number of bars, while position is active")]
	int MaxDuration = 20;
	
	// bollinger band, 10 days, 1.5 std deviation
	BBL bbl;
	// remember what you paid on entry
	double entryPrice;
	// exit after 20 days
	int barsFromEntry = 0;	
	// orders and quantity
	Order buyOrder;	

	public override void OnStrategyStart()
	{
		// set up bollinger bands
		bbl = new BBL(Bars, BBLLength, BBLOrder);
		bbl.Color = Color.Yellow;
		Draw(bbl, 0);
	}

	public override void OnBar(Bar bar)
	{
		// if we don't have a position and we have some bars
		// in the bollinger series, try to enter a new trade
		if (!HasPosition)
		{
			if (bbl.Count > 0)
			{
				// if the current bar is below the lower bollinger band
				// buy long to close the gap
				if (Bars.Crosses(bbl, bar) == Cross.Below)
				{
					buyOrder = MarketOrder(OrderSide.Buy, Qty, "Entry");					
					buyOrder.Send();
				}
			}
		}
		else
		{
			// else if we DO have an existing position, and if
			// today's bar is above our entry price (profitable),
			// then close the position with a market order
			if (entryPrice < bar.Close)
			{
				barsFromEntry = 0;
				
				Sell(Qty, "Exit (Take Profit)");
			}
			else
				barsFromEntry++;
		}
	}

	public override void OnBarOpen(Bar bar)
	{
		if (barsFromEntry == MaxDuration)
			Sell(Qty, "Sell");
	}

	public override void OnPositionOpened()
	{
		// when a position is opened, remember what we paid for
		// the instrument. Notice we use the average price of 
		// all the partial fills that we might have received.
		entryPrice = buyOrder.AvgPrice;
	}

	public override void OnPositionClosed()
	{
		barsFromEntry = 0;
	}
}
