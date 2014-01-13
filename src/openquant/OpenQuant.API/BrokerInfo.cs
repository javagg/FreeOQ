using FreeQuant.Providers;

namespace OpenQuant.API
{
	///<summary>
	///  Holds broker information such as Account list
	///</summary>
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

		///<summary>
		///  Initializes a new instance of this class
		///</summary>
		public BrokerInfo() : this(new FreeQuant.Providers.BrokerInfo())
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
