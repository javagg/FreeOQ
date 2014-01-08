namespace OpenQuant.Finam
{
	public class OpenBookData
	{
		public double Price { get; set; }

		public int Size { get; set; }

		public OpenBookData(double price, int size)
		{
			this.Price = price;
			this.Size = size;
		}
	}
}
