namespace FreeQuant.QuantRouterLib.Data
{
    public class Order
    {
        public char OrdType { get; set; }

        public char Side { get; set; }

        public char TimeInForce { get; set; }

        public double Qty { get; set; }

        public double Price { get; set; }

        public double StopPx { get; set; }

        public string Account { get; set; }

        public string ClientId { get; set; }

        public Order()
        {
            this.OrdType = char.MinValue;
            this.Side = char.MinValue;
            this.TimeInForce = char.MinValue;
            this.Qty = 0.0;
            this.Price = 0.0;
            this.StopPx = 0.0;
            this.Account = string.Empty;
            this.ClientId = string.Empty;
        }
    }
}
