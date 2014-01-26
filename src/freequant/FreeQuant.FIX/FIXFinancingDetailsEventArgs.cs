using System;

namespace FreeQuant.FIX
{
	public class FIXFinancingDetailsEventArgs : EventArgs
	{
		public FIXFinancingDetails FinancingDetails { get; set; }

		public FIXFinancingDetailsEventArgs(FIXFinancingDetails financingDetails)
		{
			this.FinancingDetails = financingDetails;
		}
	}
}
