using System;

namespace FreeQuant.Data
{
	public class OrderBookEntry
	{
		private DateTime dateTime;
		private double price;
		private int size;

		public DateTime DateTime
		{
			get
			{
				return this.dateTime; 
			}
			set
			{
				this.dateTime = value;
			}
		}

		public double Price
		{
			get
			{
				return this.price; 
			}
			set
			{
				this.price = value;
			}
		}

		public int Size
		{
			get
			{
				return this.size; 
			}
			set
			{
				this.size = value;
			}
		}

		public OrderBookEntry(DateTime datetime, double price, int size)
		{
			this.dateTime = datetime;
			this.price = price;
			this.size = size;
		}

		public override string ToString()
		{
			return string.Format(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(758), (object)this.dateTime, (object)this.price, (object)this.size);
		}
	}
}
