using System;

namespace FreeQuant.QuantRouterLib.Data
{
    public class OrderCancelReject
    {
        public int CommandId { get; set; }

        public string Text { get; set; }

        public string ClOrdID { get; set; }

        public string OrigClOrdID { get; set; }

        public string OrderID { get; set; }

        public int CxlRejReason { get; set; }

        public char CxlRejResponseTo { get; set; }

        public char OrdStatus { get; set; }

        public DateTime TransactTime { get; set; }

        public OrderCancelReject()
        {
            this.Text = string.Empty;
            this.ClOrdID = string.Empty;
            this.OrigClOrdID = string.Empty;
            this.OrderID = string.Empty;
            this.CxlRejResponseTo = char.MinValue;
            this.OrdStatus = char.MinValue;
        }
    }
}
