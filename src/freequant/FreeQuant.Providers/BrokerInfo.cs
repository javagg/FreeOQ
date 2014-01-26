namespace FreeQuant.Providers
{
	public class BrokerInfo
	{
		public BrokerAccountList Accounts { get; private set; }

		public BrokerInfo()
		{
			this.Accounts = new BrokerAccountList();
		}
	}
}
