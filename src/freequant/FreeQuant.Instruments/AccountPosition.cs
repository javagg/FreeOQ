namespace FreeQuant.Instruments
{
	public class AccountPosition
	{
		public Currency Currency { get; private set; }
		public double Value { get; set; }
		public AccountPosition(Currency currency)
		{
			this.Currency = currency;
		}
	}
}
