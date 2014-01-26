using System;

namespace FreeQuant.FIX
{
	public class ExecutionReportEventArgs : EventArgs
	{
		public NewOrderSingle Order { get; private set; }
		public ExecutionReport ExecutionReport{ get; private set; }

		public ExecutionReportEventArgs(NewOrderSingle order, ExecutionReport report)
		{
 			this.Order = order;
			this.ExecutionReport = report;
		}

		public ExecutionReportEventArgs(ExecutionReport report) : this(null, report)
		{
		}
	}
}
