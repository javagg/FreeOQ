using OpenQuant.API;

public class MyStrategy : Strategy
{
	[Parameter("Gap percent")]
	double Percent = 2;

	[Parameter("Order quantity (number of contracts to trade)")]
	double Qty = 100;

	double prevClose;
	Order sellOrder;

	public override void OnBar(Bar bar)
	{
		prevClose = bar.Close;

		if (HasPosition)
		{
			sellOrder.Cancel();

			Sell(Qty, "Exit");
		}
	}

	public override void OnBarOpen(Bar bar)
	{
		if ((prevClose - bar.Open) / prevClose > Percent / 100)
			Buy(Qty, "Entry");
	}

	public override void OnPositionOpened()
	{
		sellOrder = SellLimitOrder(Qty, prevClose, "Limit Exit");
		sellOrder.Send();
	}
}