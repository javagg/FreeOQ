using System;

namespace FreeQuant.QuantRouterLib.Data
{
    public class ExecutionReportEventArgs : EventArgs
    {
        public ExecutionReport Report { get; private set; }

        public ExecutionReportEventArgs(ExecutionReport report)
        {
            this.Report = report;
        }
    }
}
