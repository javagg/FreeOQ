namespace OpenQuant.API
{
	public class BrokerOrder
	{
		private FreeQuant.Providers.BrokerOrder brokerOrder;

		public string OrderID
		{
			get
			{
				return this.brokerOrder.OrderID;
			}
			set
			{
				this.brokerOrder.OrderID = value;
			}
		}

		public string Symbol
		{
			get
			{
				return this.brokerOrder.Symbol;
			}
			set
			{
				this.brokerOrder.Symbol = value;
			}
		}

		public InstrumentType InstrumentType
		{
			get
			{
				return EnumConverter.Convert(this.brokerOrder.SecurityType);
			}
			set
			{
				this.brokerOrder.SecurityType = EnumConverter.Convert(value);
			}
		}

		public string Exchange
		{
			get
			{
				return this.brokerOrder.SecurityExchange;
			}
			set
			{
				this.brokerOrder.SecurityExchange = value;
			}
		}

		public string Currency
		{
			get
			{
				return this.brokerOrder.Currency;
			}
			set
			{
				this.brokerOrder.Currency = value;
			}
		}

		public OrderSide Side
		{
			get
			{
				return EnumConverter.Convert(this.brokerOrder.Side);
			}
			set
			{
				this.brokerOrder.Side = EnumConverter.Convert(value);
			}
		}

		public OrderType Type
		{
			get
			{
				return EnumConverter.Convert(this.brokerOrder.OrdType);
			}
			set
			{
				this.brokerOrder.OrdType = EnumConverter.Convert(value);
			}
		}

		public OrderStatus Status
		{
			get
			{
				return EnumConverter.Convert(this.brokerOrder.OrdStatus);
			}
			set
			{
				this.brokerOrder.OrdStatus = EnumConverter.Convert(value);
			}
		}

		public double Qty
		{
			get
			{
				return this.brokerOrder.OrderQty;
			}
			set
			{
				this.brokerOrder.OrderQty = value;
			}
		}

		public double Price
		{
			get
			{
				return this.brokerOrder.Price;
			}
			set
			{
				this.brokerOrder.Price = value;
			}
		}

		public double StopPrice
		{
			get
			{
				return this.brokerOrder.StopPx;
			}
			set
			{
				this.brokerOrder.StopPx = value;
			}
		}

		public BrokerOrderFieldList Fields
		{
			get
			{
				return new BrokerOrderFieldList(this.brokerOrder.GetCustomFields());
			}
		}

		internal BrokerOrder(FreeQuant.Providers.BrokerOrder brokerOrder)
		{
			this.brokerOrder = brokerOrder;
		}

		public void AddCustomField(string name, string value)
		{
			this.brokerOrder.AddCustomField(name, value);
		}
	}
}
