namespace FreeQuant.QuantRouterLib.Data
{
    public class Instrument
    {
        public string Symbol { get; set; }

        public string InstrumentType { get; set; }

        public string Exchange { get; set; }

        public string Currency { get; set; }

        public Instrument()
        {
            this.Symbol = string.Empty;
            this.InstrumentType = string.Empty;
            this.Exchange = string.Empty;
            this.Currency = string.Empty;
        }
    }
}
