namespace FreeQuant.QuantRouterLib.Data
{
    public class SubscriptionStatus
    {
        public const byte Undefined = 0;
        public const byte Accepted = 1;
        public const byte Rejected = 2;
        public const byte Stopped = 3;

        public byte Status { get; set; }

        public string Text { get; set; }

        public SubscriptionStatus()
        {
            this.Status = (byte)0;
            this.Text = string.Empty;
        }
    }
}
