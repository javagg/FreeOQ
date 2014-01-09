namespace OpenQuant.API
{
	public class BrokerInfo
	{
		internal FreeQuant.Providers.BrokerInfo brokerInfo;

		public BrokerAccountList Accounts
		{
			get
			{
				return new BrokerAccountList(this.brokerInfo.Accounts);
			}
		}

		internal BrokerInfo(FreeQuant.Providers.BrokerInfo brokerInfo)
		{
			this.brokerInfo = brokerInfo;
		}

		public BrokerInfo()
			: this(new FreeQuant.Providers.BrokerInfo())
		{
		}

		public BrokerAccount AddAccount(string name)
		{
			FreeQuant.Providers.BrokerAccount brokerAccount = new FreeQuant.Providers.BrokerAccount(name);
			this.brokerInfo.Accounts.Add(brokerAccount);
			return new BrokerAccount(brokerAccount);
		}
	}
}
