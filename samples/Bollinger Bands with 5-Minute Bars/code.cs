using OpenQuant.API;
using OpenQuant.API.Indicators;

using System.Drawing;

public class MyStrategy : Strategy
{
	[Parameter("Order quantity (number of contracts to trade)")]
	double Qty           = 100;
	
	[Parameter("Percent")]
	double Percent       = 3;
	
	[Parameter("Profit Target")]
	double ProfitTarget  = 1;
	
	[Parameter("Length of BBL", "BBL")]
	int    BBLLength = 10;
	
	[Parameter("Order of BBL", "BBL")]
	double BBLOrder  = 2;	
    
	BBL bbl; 
    
	Order sellLimit; 
	Order buyLimit; 
    
	private int barsFromEntry = 0; 
   
	public override void OnStrategyStart() 
	{ 
		bbl = new BBL(Bars, BBLLength, BBLOrder); 
          
		bbl.Color = Color.Yellow; 
       
		Draw(bbl, 0); 
	}    
    
	public override void OnBar(Bar bar) 
	{ 
		if (bbl.Contains(bar.DateTime)) 
		{ 
			if (!HasPosition) 
			{    
				// cancel previos buy limit 
				if (buyLimit != null) 
					buyLimit.Cancel();             
             
				// calculate limit price 
				double buyPrice = bbl.Last * (1 - Percent / 100); 
             
				// place new limit orders 
				buyLimit = BuyLimitOrder(Qty, buyPrice, "Entry"); 				
				buyLimit.Send(); 
			} 
			else 
			{ 
				barsFromEntry++; 
          
				// close position at the second bar after entry 
				if (barsFromEntry == 2) 
				{ 
					barsFromEntry = 0;                
                
					sellLimit.Cancel();
					
					Sell(Qty, "Exit (Second Bar After Entry)");
				} 
			} 
		} 
	} 
    
	public override void OnBarOpen(Bar bar) 
	{ 
		// place limit order at the beginning of the next bar after entry 
		if (barsFromEntry == 1)       
			PlaceSellLimit(); 
	} 
    
	public override void OnOrderFilled(Order order) 
	{ 
		if (order == sellLimit) 
			barsFromEntry = 0;    
	} 

	private void PlaceSellLimit() 
	{ 
		// calculate price that satisfies the profit target 
		double sellPrice = buyLimit.AvgPrice * (1 + ProfitTarget / 100); 
             
		sellLimit = SellLimitOrder(Qty, sellPrice, "Exit (Profit Target)");
		sellLimit.Send(); 
	} 
}
