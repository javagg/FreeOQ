using System;

namespace FreeQuant.QuantRouterLib.Data
{
    public class ExecutionReport
    {
        public int CommandId { get; set; }

        public Order Order { get; private set; }

        public char ExecType { get; set; }

        public DateTime TransactTime { get; set; }

        public char OrdStatus { get; set; }

        public double LastPx { get; set; }

        public double LastQty { get; set; }

        public double AvgPx { get; set; }

        public double CumQty { get; set; }

        public double LeavesQty { get; set; }

        public double Commission { get; set; }

        public char CommType { get; set; }

        public string Text { get; set; }

        public ExecutionReport() : base()
        {
            this.Order = new Order();
            this.ExecType = char.MinValue;
            this.OrdStatus = char.MinValue;
            this.CommType = char.MinValue;
        }
    }
}
