using System;
using System.Collections.Generic;
using System.Text;

using OpenQuant.API;
using OpenQuant.API.Engine;
using OpenQuant.API.Indicators;

// This demo scenario shows:
// 
// - how to filter and add the most liquid stocks into strategy project
// - how to implement brute force optimization and perform walk-forward backtest on out-of-sample data interval

public class MyScenario : Scenario
{
	public override void Run()
	{    
		// get reference to strategy project
        
		Project project = Solution.Projects[0];
        
		// clear project instrument list 
        
		project.ClearInstruments();
        
		// add most liquid stocks to instrument list 
        
		foreach (Instrument instrument in InstrumentManager.Instruments)
			if (instrument.Type == InstrumentType.Stock)
			{
				BarSeries series = DataManager.GetHistoricalBars(instrument, BarType.Time, 86400);
            
				if (series.Count != 0 && series.Last.Volume > 50000000)
				{
					Console.WriteLine("Adding " + instrument);
                
					project.AddInstrument(instrument);
				}
			}
        
		// start backtest
        
		Start();
        
		// set in-sample data interval
        
		Solution.StartDate = new DateTime(1995, 1, 1);
		Solution.StopDate  = new DateTime(2001, 1, 1);
    
		// define variables
        
		int best_length1 = 0;
		int best_length2 = 0;
		double best_objective = 0;
        
		// brute force optimization loop
        
		for (int length1 = 3;length1 <= 7;length1++)
			for (int length2 = 3;length2 <= 7;length2++)
				if (length2 > length1)
				{
					// set new parameters
                    
					project.Parameters["Length1"].Value = length1;
					project.Parameters["Length2"].Value = length2;
                    
					// print parameters
                            
					Console.Write("Length1 = " + length1 + " Length2 = " + length2);
        
					// start backtest
                    
					Start();
                    
					// calculate objective function
                    
					double objective = Solution.Portfolio.GetValue();

					// print objective
                    
					Console.WriteLine(" Objective = " + objective);
        
					// check best objective
                    
					if (objective > best_objective)
					{
						best_objective = objective;
						best_length1 = length1;
						best_length2 = length2;
					}
				}    
        
		// print best parameters
        
		Console.WriteLine("BEST PARAMETERS");
		Console.WriteLine();
		Console.WriteLine("SMA1 Length = " + best_length1);
		Console.WriteLine("SMA2 Length = " + best_length2);
		Console.WriteLine("Objective   = " + best_objective);

		// run strategy with the best parameters on out-of-sample data interval
        
		project.Parameters["Length1"].Value = best_length1;
		project.Parameters["Length2"].Value = best_length2;

		Solution.StartDate = new DateTime(2001, 1, 1);
		Solution.StopDate  = new DateTime(2005, 1, 1);        
        
		Start();
	}
}
