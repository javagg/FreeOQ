using System;
using System.Drawing;

using OpenQuant.API;
using OpenQuant.API.Indicators;

// this enum defines allowed filter values
public enum FilterType {
	None,
	RAVI,
	ADX
}

public class MyStrategy : Strategy
{
	[Parameter("Order quantity (number of contracts to trade)")]
	double Qty = 100;
	
	[Parameter("Bars Exit Level", "Bars Exit")]
	bool BarCountExitEnabled;

	[Parameter("Bars to Exit Count", "Bars Exit")]
	int BarsToExitCount = 20;
	
	[Parameter("Consecutive Closes Count")]
	int ConsClosesCount = 3;
	
	[Parameter("SMA Length")]
	int SMALength = 65;
	
	[Parameter("Stop Exit Level", "Stop Exit")]
	double TrailingStopLevel = 500;

	[Parameter("Stop Exit Enabled", "Stop Exit")]
	bool TrailingStopEnabled;
	
	[Parameter("Trend-Following Exit Enabled", "Trend-Following Exit")]
	bool TrendFollowingExitEnabled;

	[Parameter("Trend-Following Exit Length", "Trend-Following Exit")]
	int TrendFollowingExitLength = 14;
	
	[Parameter("Filter Type", "Filter")]
	FilterType FilterType = FilterType.None;
	
	[Parameter("ADX Length", "ADX")]
	int ADXLength = 14;	

	[Parameter("ADX Level", "ADX")]
	double ADXLevel = 20;
	
	[Parameter("Short SMA Length (RAVI)", "RAVI")]
	int ShortSMALength = 7;

	[Parameter("RAVI Percent Level", "RAVI")]
	double RAVILevel = 0.5;
	
	// the slow average is 65 bars long by default
	SMA sma;

	// only enter new trades if no position exists
	bool entryEnabled = false;

	// for consecutive closes 
	int ccCount = 0;

	// record the crossing state
	Cross smaCross = Cross.None;

	// for the bar count exit method
	int barsFromEntry = 0;

	// for the trailing stop exit method
	Stop trailingStop;

	// Exit when High/Low exceed previous price range
	bool exitOnBarOpen = false;

	// RAVI Filter parameters
	SMA shortSMA;
	
	// ADX Filter parameters
	ADX adx;

	// shares to buy, and trading orders
	Order buyOrder;
	Order sellOrder;

	public override void OnStrategyStart()
	{
		sma = new SMA(Bars, SMALength);
		sma.Color = Color.Yellow;
		Draw(sma, 0);

		// if required, set up the RAVI moving average
		if (FilterType == FilterType.RAVI)
		{
			shortSMA = new SMA(Bars, ShortSMALength);
			shortSMA.Color = Color.Pink;
			Draw(shortSMA, 0);
		}
		//if required, set up the ADX moving average 
		if (FilterType == FilterType.ADX)
		{
			// ADX is a builtin function, like SMA
			adx = new ADX(Bars, ADXLength);
			adx.Color = Color.Wheat;
			Draw(adx, 2);
		}
	}

	public override void OnBar(Bar bar)
	{
		if (sma.Count == 0)
			return;

		// if we are using a trend-following exit and have an open
		// positiong that we should close
		if (TrendFollowingExitEnabled && HasPosition && Bars.Count > TrendFollowingExitLength + 1)
		{
			// check if we are long and today's close is lower than 
			// lowest low of the last "trendFollowingExitLength" bars.
			// If so, then exit on the next bar open
			if (Position.Side == PositionSide.Long)
			{
				double prevLow = Bars.LowestLow(Bars.Count - TrendFollowingExitLength - 1, Bars.Count - 2);

				if (bar.Close < prevLow)
					exitOnBarOpen = true;
			}

			// check if we are short and today's close is higher than 
			// highest high of the last "trendFollowingExitLength" bars
			// If so, exit on the next bar open
			if (Position.Side == PositionSide.Short)
			{
				double prevHigh = Bars.HighestHigh(Bars.Count - TrendFollowingExitLength - 1, Bars.Count - 2);

				if (bar.Close > prevHigh)
					exitOnBarOpen = true;
			}
		}

		// look for N consecutive closes after a crossover
		Cross cross = Bars.Crosses(sma, bar);
		// if any cross occurred, reset the consecutive close count,
		// and copy the cross value so we can reset our copy of it
		// without wiping out the original indicator.
		if (cross != Cross.None)
		{
			smaCross = cross;
			ccCount = 0;
		}

		// if a cross occurred, increment the cc count, because the 
		// first bar counts as the first consecutive close
		if (smaCross != Cross.None)
			ccCount++;

		// if we have enough consecutive closes, it's time to trade
		if (ccCount == ConsClosesCount)
		{
			// if we have no position open, or if we have a position
			// that is opposite the cross direction (ie, we need to 
			// close the position)
			if (!HasPosition ||
				(Position.Side == PositionSide.Long && smaCross == Cross.Below) ||
				(Position.Side == PositionSide.Short && smaCross == Cross.Above))
			{
				switch (FilterType)
				{
					// enter a trade if no filters are being used
					case FilterType.None:
					{
						entryEnabled = true;
						break;
					}
					// enter a trade if the RAVI filter says ok
					case FilterType.RAVI:
					{
						entryEnabled = FilterRAVI();
						break;
					}
					// enable a trade if the ADX filter says ok
					case FilterType.ADX:
					{
						entryEnabled = FilterADX();
						break;
					}
				}

				// if an entry was enabled, open a position on next bar open
				if (entryEnabled)
					exitOnBarOpen = false;
				// and reset our copy of the cross status to none
				smaCross = Cross.None;
			}
			// reset the consecutive close count too
			ccCount = 0;
		}
	}

	public override void OnBarOpen(Bar bar)
	{
		// if we should close our position due to the trend-following exit
		if (exitOnBarOpen)
		{
			exitOnBarOpen = false;
			// if we have a position open, close it
			if (HasPosition)
			{
				ClosePosition();
				return;
			}
		}

		// if we should enter a trade
		if (entryEnabled)
		{
			entryEnabled = false;
			// and if we have no existing position
			if (!HasPosition)
			{
				// go long if our bar is above the moving average
				if (Bars.Last.Close >= sma.Last)
					OpenPosition(OrderSide.Buy);
				// go short if our bar is below the moving average
				if (Bars.Last.Close <= sma.Last)
					OpenPosition(OrderSide.Sell);
			}
				// if we have an existing position, reverse it,
				// because the trend direction has changed.
			else
				ReversePosition();
		}
			// else if we should be using the bar count exit instead
			// of the trend following exit
		else
		{
			// bars exit
			if (BarCountExitEnabled)
			{
				// if we have a position to close, 
				// close the position and reset the bar counters
				if (HasPosition)
				{
					barsFromEntry++;

					if (barsFromEntry == BarsToExitCount)
					{
						barsFromEntry = 0;

						ClosePosition();
					}
				}
					// else if we have no position open, 
					// reset the bars count to zero for next time
				else
					barsFromEntry = 0;
			}
		}
	}

	public override void OnPositionChanged()
	{
		// every time our position size or direction changes,
		// cancel the old trailing stop and set a new one
		CancelExit();
		if (HasPosition)
			SetExit();
	}

	private void CancelExit()
	{
		// reset the bar counter and cancel the trailing stop
		barsFromEntry = 0;
		if (trailingStop != null)
			trailingStop.Cancel();
	}

	private void SetExit()
	{
		// reset the bar counter and set a new trailing stop
		// Notice this stop is just an internal signal, it is 
		// not a real stop loss order. The real order is issued
		// in OnStopExecuted, when the stop is triggered.
		barsFromEntry = 0;

		if (TrailingStopEnabled)
			trailingStop = SetStop(TrailingStopLevel / Qty, StopType.Trailing, StopMode.Absolute);
	}

	public override void OnStopExecuted(Stop stop)
	{
		// when the stop is triggered, close the position
		ClosePosition();
	}

	private void ClosePosition()
	{
		// create and send a market order to close the position
		if (Position.Side == PositionSide.Long)
			Sell(Qty, "Exit");
		else
			Buy(Qty, "Exit");
	}

	private void OpenPosition(OrderSide side)
	{
		// create and send a market order to open the position
		Order order = MarketOrder(side, Qty, "Entry");

		if (side == OrderSide.Buy)
			buyOrder = order;
		else
			sellOrder = order;

		order.Send();
	}

	private void ReversePosition()
	{
		// reverse the position with a market order
		// Use double the position size to flip the position
		if (Position.Side == PositionSide.Long)
		{
			sellOrder = MarketOrder(OrderSide.Sell, Qty * 2, "Reverse the Position");
			sellOrder.Send();
		}
		else
		{
			buyOrder = MarketOrder(OrderSide.Buy, Qty * 2, "Reverse the Position");
			buyOrder.Send();
		}
	}

	private bool FilterRAVI()
	{
		// calculate the latest RAVI value
		if (shortSMA.Count == 0)
			return false;

		double smaLast = sma.Last;
		double shortSMALast = shortSMA.Last;

		double ravi = Math.Abs(smaLast - shortSMALast) / Math.Min(smaLast, shortSMALast) * 100;

		// return true to accept the trade, false to block it
		if (ravi >= RAVILevel)
			return true;
		else
			return false;
	}

	private bool FilterADX()
	{
		if (adx.Count == 0)
			return false;

		// return true to accept the trade, false to block it
		if (adx.Last >= ADXLevel)
			return true;
		else
			return false;
	}
}
