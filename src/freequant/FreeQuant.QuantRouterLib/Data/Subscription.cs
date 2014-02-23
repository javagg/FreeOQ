namespace FreeQuant.QuantRouterLib.Data
{
    public class Subscription
    {
        public int RequestId { get; set; }

        public string Symbol { get; set; }

        public string Formula { get; set; }

        public Subscription()
        {
            this.RequestId = 0;
            this.Symbol = string.Empty;
            this.Formula = string.Empty;
        }
    }
}
