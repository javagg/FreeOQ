using System.ComponentModel;

namespace OpenQuant.Trading
{
	public enum ObjectiveType
	{
		[Description ("Final Wealth")] 
		FinalWealth,
		[Description ("Maximum Drawdown")]
		MaxDrawdown,
		[Description ("Final Wealth / Maximum Drawdown")]
		FinalWealthDivMaxDrawdown,
	}
}
