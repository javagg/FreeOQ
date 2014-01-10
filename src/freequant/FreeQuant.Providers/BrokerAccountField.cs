namespace FreeQuant.Providers
{
	public class BrokerAccountField : BrokerInfoField
	{
		public string Currency { get; private set; }

		public BrokerAccountField(string name, string currency, string value) : base(name, value)
		{
			this.Currency = currency;
		}
	}
}
