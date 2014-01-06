using System;
using System.Drawing;

using OpenQuant.API;
using OpenQuant.API.Indicators;

public class MyStrategy : Strategy
{
	[Parameter("Order quantity (number of contracts to trade)")]
	double Qty = 100;

	[Parameter("Percent")]
	double Percent = 2;	
	
	private Order sellOrder;
	
	private double prevClose;
	
	private bool downDay = false;
	
	public override void OnBar(Bar bar)
	{
		prevClose = bar.Close;
		
		downDay = (bar.Open > bar.Close);
		
		if (HasPosition)
		{
			sellOrder.Cancel();
			
			Sell(Qty, "Exit");
		}
	}

	public override void OnBarOpen(Bar bar)
	{	
		if (downDay)
		{
			if ((prevClose - bar.Open) / prevClose > Percent / 100)
				Buy(Qty, "Entry");
		}
	}
	
	public override void OnPositionOpened()
	{
		sellOrder = SellLimitOrder(Qty, prevClose, "Limit Exit");
		sellOrder.Send();
	}	
}
