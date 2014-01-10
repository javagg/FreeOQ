namespace FreeQuant.Providers
{
	public class BrokerInfo
	{
		private BrokerAccountList list;

		public BrokerAccountList Accounts
		{
			get
			{
				return this.list;
			}
		}

		public BrokerInfo()
		{
			this.list = new BrokerAccountList();
		}
	}
}
