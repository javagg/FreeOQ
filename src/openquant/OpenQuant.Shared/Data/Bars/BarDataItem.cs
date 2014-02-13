namespace OpenQuant.Shared.Data.Bars
{
	internal class BarDataItem
	{
		public double Price { get; private set; }

		public long Volume { get; private set; }

		public long OpenInt { get; private set; }

		public BarDataItem(double price, long volume, long openInt)
		{
			this.Price = price;
			this.Volume = volume;
			this.OpenInt = openInt;
		}

		public BarDataItem(double price, long volume) : this(price, volume, 0)
		{
		}

		public BarDataItem(double price) : this(price, 0)
		{
		}
	}
}
