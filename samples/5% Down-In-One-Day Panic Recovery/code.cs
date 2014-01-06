using OpenQuant.API;

public class MyStrategy : Strategy
{
	[Parameter("Buy when a stock drops this number of percents in one day")]
	double Percent = 5;

	[Parameter("Order quantity (number of contracts to trade)")]
	double Qty = 100;

	Order buyOrder;

	public override void OnBar(Bar bar)
	{
		// if we do not have a position, update the limit buy order to be 5% above today's close
		if (!HasPosition)
		{
			// cancel the old limit order (it's out of date now)
			if (buyOrder != null)
				buyOrder.Cancel();

			// issue a new buy order at 5% below today's close this order will execute tomorrow 
			// if price is matched
			double buy_price = bar.Close * (1 - (Percent / 100));

			buyOrder = BuyLimitOrder(Qty, buy_price, "Entry");
			buyOrder.Send();
		}

		// else we opened a position today using our limit order from yesterday, so now close 
		// the position at the end of today. We expect that such a big drop was freaky, and that 
		// prices recovered during the day. If not, this order stops further losses.
		else
			Sell(Qty, "Exit");
	}
}