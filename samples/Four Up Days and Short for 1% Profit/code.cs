using OpenQuant.API;

public class MyStrategy : Strategy
{
	[Parameter("Order quantity (number of contracts to trade)")]
	double Qty = 100;
	
	// exit with a profit target of 1%
	[Parameter("Profit Target")]
	double ProfitTarget = 1;
	
	// last day up must be a big 2% up day
	[Parameter("Up Move")]
	double UpPercent = 2;
	
	// Number of consecutive down closes
	[Parameter("Number of consecutive down closes")]
	int ConsClosesCount = 4;
	
	// count of up days
	int count;
	double prevClose;

	// orders
	Order buyOrder;
	Order sellOrder;
	
	public override void OnStrategyStart()
	{
		prevClose = -1;

		count = 0;
	}

	public override void OnBar(Bar bar)
	{
		// we need to let a bar go by to capture the prev close
		if (prevClose != -1)
		{
			// if we don't have a position open, update the count
			// of up days, and try to enter a trade
			if (!HasPosition)
			{
				if (prevClose < bar.Close)
					count++;
				else
					count = 0;

				// if we have seen 4 (consClosesCount is equal to 4 by default) up days, AND if the last day 
				// up was 2% or more, then open a new position, 
				// going short on the day's close
				if (count == ConsClosesCount)
				{
					if ((bar.Close - prevClose) / prevClose >= UpPercent / 100)
					{
						sellOrder = MarketOrder(OrderSide.Sell, Qty, "Entry");						
						sellOrder.Send();
					}
				}
			}

				// if we have a position open, cancel our previous 
				// 1% profit target order, and close using a market order
			else
			{
				buyOrder.Cancel();

				Buy(Qty, "Buy Cover");				
			}
		}

		// now today's close becomes the previous close
		prevClose = bar.Close;
	}

	public override void OnPositionOpened()
	{
		// when we open a position, immediately issue a limit order 
		// for our 1% profit target
		double target_price = sellOrder.AvgPrice * (1 - ProfitTarget / 100);
		buyOrder = BuyLimitOrder(Qty, target_price, "Exit (Take Profit)");
		buyOrder.Send();
	}
}
