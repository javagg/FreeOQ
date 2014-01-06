using OpenQuant.API;

public class MyStrategy : Strategy
{
	[Parameter("Order quantity (number of contracts to trade)")]
	int Qty = 100;
	
	// enter trade on 4 breakoutPercent breakout
	[Parameter("Percent")]
	double BreakoutPercent = 4;
	
	// orders and trade quantity
	Order buyOrder;
	// for calculating breakout price limit
	double prevClose;

	public override void OnStrategyStart()
	{
		prevClose = -1;
	}

	public override void OnBarOpen(Bar bar)
	{
		// we need to let the first bar go by before we can
		// calculate the breakout limit
		if (prevClose != -1)
		{
			// if we do not have a position, then cancel the
			// previous limit order (it is out of date)
			if (!HasPosition)
			{
				if (buyOrder != null)
					buyOrder.Cancel();

				// now try to enter a trade by setting a limit order
				// to automatically buy in if the big 4% jump arrives.
				// This order will reside on the exchange servers, and 
				// will execute during the day if the limit is triggered.
				double breakout_fraction = 1 + (BreakoutPercent / 100);
				double breakout_price = prevClose * breakout_fraction;
				buyOrder = BuyStopOrder(Qty, breakout_price, "Entry");	
				buyOrder.Send();
			}

				// if we have a position open, then close it now. 
				// Now (which is the leading edge of today's daily bar)
				// is the start of the day after the trade was opened.
			else
				Sell(Qty, "Exit");
		}
	}

	public override void OnBar(Bar bar)
	{
		// update the prevClose value for the breakout calculation
		prevClose = bar.Close;
	}
}
