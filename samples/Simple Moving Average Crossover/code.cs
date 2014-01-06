using System;
using System.Drawing;

using OpenQuant.API;
using OpenQuant.API.Indicators;

public class MyStrategy : Strategy
{
	[Parameter("Length of SMA1", "SMA")]
	int Length1 = 3;

	[Parameter("Length of SMA2", "SMA")]
	int Length2 = 7;

	[Parameter("Color of SMA1", "SMA")]
	Color Color1 = Color.Yellow;	

	[Parameter("Color of SMA2", "SMA")]
	Color Color2 = Color.LightBlue;
	
	[Parameter("Stop OCA Level", "OCA")]
	double StopOCALevel = 0.98;

	[Parameter("Limit OCA Level", "OCA")]
	double LimitOCALevel = 1.05;
	
	[Parameter("Stop Level", "Stop")]
	double StopLevel = 0.05;

	[Parameter("Stop Type", "Stop")]
	StopType StopType = StopType.Trailing;
	
	[Parameter("StopMode", "Stop")]
	StopMode StopMode = StopMode.Percent;
	
	[Parameter("CrossoverExitEnabled", "Exit")]
	bool CrossoverExitEnabled = true;
	
	[Parameter("OCA Exit Enabled", "Exit")]
	bool OCAExitEnabled = true;

	[Parameter("Stop Exit Enabled", "Exit")]
	bool StopExitEnabled = true;
	
	// this strategy uses some of the same exit methods
	// as the breakout strategy described earlier. Look
	// there for additional documentation
	// lengths and colors of the simple moving averages	
	SMA sma1;
	SMA sma2;

	// only one trade is allowed at a time
	bool entryEnabled = true;	
	
	int OCACount = 0;

	// for the orders used by this strategy
	Order marketOrder,
		limitOrder,
		stopOrder;

	[Parameter("Order quantity (number of contracts to trade)")]
	double Qty = 100;

	public override void OnStrategyStart()
	{
		// set up the moving averages, based on closing prices
		sma1 = new SMA(Bars, Length1, Color1);
		sma2 = new SMA(Bars, Length2, Color2);
		// 0 means draw both averages on the price chart
		Draw(sma1, 0);
		Draw(sma2, 0);
	}

	public override void OnBar(Bar bar)
	{
		// does the fast average cross over the slow average?
		// if so, time to buy long
		Cross cross = sma1.Crosses(sma2, bar);
		// we only allow one active position at a time
		if (entryEnabled)
		{
			// if price trend is moving upward, open a long
			// position using a market order, and send it in
			if (cross == Cross.Above)
			{
				marketOrder = MarketOrder(OrderSide.Buy, Qty, "Entry");				
				marketOrder.Send();
				// if one cancels all exit method is desired, we
				// also issue a limit (profit target) order, and
				// a stop loss order in case the breakout fails.
				// The OCA exit method uses a real stop loss order.
				// The Stop exit method uses a stop indicator.
				// Use either the OCA or Stop method, not both at once.
				if (OCAExitEnabled)
				{
					// create and send a profit limit order
					double profitTarget = LimitOCALevel * bar.Close;
					limitOrder = SellLimitOrder(Qty, profitTarget, "Limit OCA " + OCACount);
					limitOrder.OCAGroup = "OCA " + Instrument.Symbol + " "
						+ OCACount;					
					limitOrder.Send();
					// create and send a stop loss order
					double lossTarget = StopOCALevel * bar.Close;
					stopOrder = SellStopOrder(Qty, lossTarget, "Stop OCA " + OCACount);
					stopOrder.OCAGroup = "OCA " + Instrument.Symbol + " "
						+ OCACount;					
					stopOrder.Send();
					// bump the OCA count to make OCA group strings unique
					OCACount++;
				}
				entryEnabled = false;
			}
		}
			// else if entry is disabled on this bar, we have an open position
		else
		{
			// if we are using the crossover exit, and if the fast
			// average just crossed below the slow average, issue a
			// market order to close the existing position
			if (CrossoverExitEnabled)
				if (cross == Cross.Below)
				{
					marketOrder = MarketOrder(OrderSide.Sell, Qty, "Crossover Exit");					
					marketOrder.Send();
				}
		}
	}
	public override void OnPositionOpened()
	{
		// if we want to exit trades using the Stop method, set a
		// a trailing stop indicator when the position is
		// first opened. The stop indicator is not a stop loss
		// order that can be executed by a broker. Instead, the stop
		// just fires the OnStopExecuted event when it it triggered.
		if (StopExitEnabled)
			SetStop(StopLevel, StopType, StopMode);
	}

	public override void OnPositionClosed()
	{
		// when a position is closed, cancel the limit and stop
		// orders that might be associated with this position.
		// But only cancel if the order has not been filled or
		// not been cancelled already.
		if (OCAExitEnabled &&
			!(limitOrder.IsFilled || limitOrder.IsCancelled))
		{
			limitOrder.Cancel();
		}
		// allow entries once again, since our position is closed
		entryEnabled = true;
	}

	public override void OnStopExecuted(Stop stop)
	{
		// if our trailing stop indicator was executed,
		// issue a market sell order to close the position.
		marketOrder = MarketOrder(OrderSide.Sell, Qty, "Stop Exit");		
		marketOrder.Send();
	}
}
