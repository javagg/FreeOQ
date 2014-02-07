using System;

namespace FreeQuant.Data
{
	public class OrderBookEntry
	{
		public DateTime DateTime { get; set; }
		public double Price { get; set; }
		public int Size { get; set; }

		public OrderBookEntry(DateTime dateTime, double price, int size)
		{
			this.DateTime = dateTime;
			this.Price = price;
			this.Size = size;
		}

		// TODO:
		public override string ToString()
		{
			return string.Format("", this.DateTime, this.Price, this.Size);
		}
	}
}

