namespace FreeQuant.Instruments
{
	public class AccountPosition
	{
		internal Currency currency;
		internal double value;

		public Currency Currency
		{
			get
			{
				return this.currency;
			}
		}

		public double Value
		{
			get
			{
				return this.value;
			}
		}

		public AccountPosition(Currency currency)
		{
			this.currency = currency;
		}
	}
}
