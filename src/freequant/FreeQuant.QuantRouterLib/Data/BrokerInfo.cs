namespace FreeQuant.QuantRouterLib.Data
{
    public class BrokerInfo
    {
        private BrokerAccountList YZqfFTwQu;

        public byte ProviderId { get; set; }

        public BrokerAccountList Accounts
        {
            get
            {
                return this.YZqfFTwQu;
            }
        }

        public BrokerInfo()
        {
            this.YZqfFTwQu = new BrokerAccountList();
        }
    }
}
