namespace FreeQuant.QuantRouterLib.Data
{
    public class Command
    {
        public Instrument Instrument { get; private set; }

        public Order Order { get; private set; }

        public int CommandId { get; set; }

        public byte CommandType { get; set; }

        public byte ProviderId { get; set; }

        public string Text { get; set; }

        public Command()
        {
            this.Instrument = new Instrument();
            this.Order = new Order();
            this.Text = string.Empty;
        }
    }
}
