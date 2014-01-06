using System;
using System.Drawing;

using OpenQuant.API;
using OpenQuant.API.Indicators;

public class MyStrategy : Strategy
{	
	[Parameter("Order quantity (number of contracts to trade)")]
	double Qty = 100;
	
	[Parameter("Number of bars to calculate channels")]
	int EntryLength = 20;
	
	[Parameter("Exit on crossing extremum channels enabled", "Extreme Exit")]
	bool ExtremeExitEnabled = false;

	[Parameter("Volatility exit enabled", "Volatility Exit")]
	bool VolatilityExitEnabled = true;	

	[Parameter("Tick Barrier entry enabled", "Tick Barrier Entry")]
	bool TickBarrierEnabled = false;	

	[Parameter("Volatility Barrier exit enabled", "Volatility Barrier Exit")]
	bool VolatilityBarrierEnabled = true;
	
	[Parameter("Number of bars to calculate extremums", "Extreme Exit")]
	int ExitLength = 5;
	
	[Parameter("Number of valatilities to create volatility exit channels", "Volatility Exit")]
	int VolatilitiesCount = 3;

	[Parameter("SMA length", "Volatility Exit")]
	int VolatilitySMALength = 10;

	[Parameter("Number of ticks to create entry barriers", "Tick Barrier Entry")]
	int BarrierSize = 20;

	[Parameter("Tick Size", "Tick Barrier Exit")]
	double TickSize = 0.2;
	
	private BarSeries series;
	
	private TimeSeries lowestLowSeries;
	private TimeSeries highestHighSeries;
	
	// volatility
	private TimeSeries rangeSeries;	
	private SMA rangeSMA;

	private TimeSeries channelHighSeries;
	private TimeSeries channelLowSeries;
	
	// fields
	private Order exitExtremeOrder;
	private Order exitVolatilityOrder;

	private double barrier = double.Epsilon;
	
	private int ocaCount = 1;

	public override void OnStrategyStart()
	{
		series = new BarSeries();

		if (VolatilityExitEnabled || VolatilityBarrierEnabled)
		{
			rangeSeries = new TimeSeries();
			
			rangeSMA = new SMA(rangeSeries, VolatilitySMALength);
		}
		
		if (TickBarrierEnabled)
			barrier = TickSize * BarrierSize;
		
		lowestLowSeries   = new TimeSeries();
		highestHighSeries = new TimeSeries();		
		channelLowSeries  = new TimeSeries();
		channelHighSeries = new TimeSeries();
		
		lowestLowSeries  .Color = Color.Blue;
		highestHighSeries.Color = Color.Blue;
		channelLowSeries .Color = Color.Brown;
		channelHighSeries.Color = Color.Brown;
		
		Draw(lowestLowSeries  , 0);
		Draw(highestHighSeries, 0);
		Draw(channelLowSeries , 0);
		Draw(channelHighSeries, 0);
	}

	public override void OnBar(Bar bar)
	{
		if (VolatilityExitEnabled)
			rangeSeries.Add(bar.DateTime, bar.High - bar.Low);
		
		// check if there are least "length" bars
		if (series.Count >= EntryLength && rangeSMA.Count > 0)
		{
			double highestHigh = series.HighestHigh(EntryLength);
			double lowestLow   = series.LowestLow  (EntryLength);
				
			double volatilty = 0;
			
			if (VolatilityBarrierEnabled)
				volatilty = rangeSMA.Last;			
			
			highestHighSeries.Add(bar.DateTime, highestHigh);			
			lowestLowSeries  .Add(bar.DateTime, lowestLow  );
			
			double channelHigh = highestHigh + barrier - volatilty;
			double channelLow  = lowestLow   - barrier + volatilty;
		
			channelHighSeries.Add(bar.DateTime, channelHigh);		
			channelLowSeries .Add(bar.DateTime, channelLow );
			
			if (!HasPosition)
			{
				if (channelHigh <= bar.Close)
					OpenPosition(OrderSide.Buy);
				else
					if (channelLow >= bar.Close)
					OpenPosition(OrderSide.Sell);
			}
			else				
			{
				SetExit();
			}
		}
		
		series.Add(bar);
	}
	
	private void OpenPosition(OrderSide side)
	{
		Order order = MarketOrder(side, Qty, "Entry");
		order.Send();
	}
	
	public override void OnPositionOpened()
	{
		SetExit();	
	}
	
	private void SetExit()
	{
		if (ExtremeExitEnabled)
		{
			if (exitExtremeOrder != null)
				exitExtremeOrder.Cancel();
		
			if (Position.Side == PositionSide.Long)
				exitExtremeOrder = SellStopOrder(Qty, Bars.LowestLow(ExitLength), "Exit (Extreme");
			else
				exitExtremeOrder = BuyStopOrder(Qty, Bars.HighestHigh(ExitLength), "Exit (Extreme");
			
			exitExtremeOrder.OCAGroup = Instrument.Symbol + " OCA " + ocaCount;
		}
		
		if (VolatilityExitEnabled)
		{		
			if (rangeSMA.Count > 0)
			{
				if (exitVolatilityOrder != null)
					exitVolatilityOrder.Cancel();
		
				if (Position.Side == PositionSide.Long)
					exitVolatilityOrder = SellStopOrder(Qty, series.HighestHigh(EntryLength) - rangeSMA.Last * VolatilitiesCount, "Exit (Volatility)");
				else
					exitVolatilityOrder = BuyStopOrder(Qty, series.LowestLow(EntryLength) + rangeSMA.Last * VolatilitiesCount, "Exit (Volatility)");
			
				exitVolatilityOrder.OCAGroup = Instrument.Symbol + " OCA " + ocaCount;
			}
		}
		
		if (ExtremeExitEnabled)
		{
			exitExtremeOrder.Send();
		}
		
		if (VolatilityExitEnabled)
		{
			exitVolatilityOrder.Send();			
		}
		
		ocaCount++;
	}
}
