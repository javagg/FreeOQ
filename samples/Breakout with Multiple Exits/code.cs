using OpenQuant.API;

public class MyStrategy : Strategy
{
	[Parameter("Order quantity (number of contracts to trade)")]
	double Qty = 100;	
	
	[Parameter("Length")]	
	int Length = 30;

	[Parameter("Stop OCA Level", "OCA")]	
	double StopOCALevel  = 0.98;
	
	[Parameter("Length", "OCA")]	
	double LimitOCALevel = 1.05;
	
	[Parameter("Stop Level", "Stop")]
	double   StopLevel = 0.05;
	
	[Parameter("Stop Type", "Stop")]
	StopType StopType  = StopType.Trailing;
	
	[Parameter("Stop Mode", "Stop")]
	StopMode StopMode  = StopMode.Percent;

	[Parameter("OCA Exit Enabled", "Exit")]	
	bool OCAExitEnabled  = true;
	
	[Parameter("Time Exit Enabled", "Exit")]	
	bool TimeExitEnabled = false;
	
	[Parameter("Stop Exit Enabled", "Exit")]
	bool StopExitEnabled = false;
	
	[Parameter("Bars to Exit", "Exit")]
	int BarsToExit = 10;

	Order limitOrder, stopOrder;
	
	int OCACount = 0;
	int barCount;
	
	bool entryEnabled    = true;

	double highestHigh;

	public override void OnBar(Bar bar)
	{
		if (entryEnabled)
		{
			if (Bars.Count > Length)
				if (bar.High > highestHigh)
				{
					Buy(Qty, "Entry");

					if (OCAExitEnabled)
					{
						limitOrder = SellLimitOrder(Qty, LimitOCALevel * bar.Close, "Limit OCA " + OCACount);
						limitOrder.OCAGroup = "OCA " + Instrument.Symbol + " " + OCACount;						

						stopOrder = SellStopOrder(Qty, StopOCALevel * bar.Close, "Stop OCA " + OCACount);
						stopOrder.OCAGroup = "OCA " + Instrument.Symbol + " " + OCACount;						

						limitOrder.Send();
						stopOrder .Send();

						OCACount++;
					}

					entryEnabled = false;

					barCount = 0;
				}
		}
		else
		{
			barCount++;

			if (TimeExitEnabled && barCount > BarsToExit)
			{
				Sell(Qty, "Time Exit");			
				
				entryEnabled = true;
			}
		}
		
		if (Bars.Count >= Length)
			highestHigh = Bars.HighestHigh(Length);
	}

	public override void OnPositionOpened()
	{
		if (StopExitEnabled)
			SetStop(StopLevel, StopType, StopMode);
	}

	public override void OnPositionClosed()
	{
		// cancel OCA

		if (OCAExitEnabled && !(limitOrder.IsFilled || limitOrder.IsCancelled))
			limitOrder.Cancel();

		// can entry again now

		entryEnabled = true;
	}

	public override void OnStopExecuted(Stop stop)
	{
		Sell(Qty, "Stop Exit");
	}
}
