using FreeQuant.FIX;
using System;
using System.Collections.Generic;

namespace FreeQuant.Providers
{
	public class BrokerPosition
	{
		private string symbol;
		private string securityType;
		private string securityExchange;
		private string currency;
		private DateTime maturityDate;
		private PutOrCall putOrcall;
		private double strike;
		private double qty;
		private double longQty;
		private double shortQty;
		private SortedList<string, string> customFields;

		public string Symbol
		{
			get
			{
				return this.symbol; 
			}
			set
			{
				this.symbol = value;
			}
		}

		public string SecurityType
		{
			get
			{
				return this.securityType; 
			}
			set
			{
				this.securityType = value;
			}
		}

		public string SecurityExchange
		{
			get
			{
				return this.securityExchange; 
			}
			set
			{
				this.securityExchange = value;
			}
		}

		public string Currency
		{
			get
			{
				return this.currency; 
			}
			set
			{
				this.currency = value;
			}
		}

		public DateTime MaturityDate
		{
			get
			{
				return this.maturityDate; 
			}
			set
			{
				this.maturityDate = value;
			}
		}

		public PutOrCall PutOrCall
		{
			get
			{
				return this.putOrcall; 
			}
			set
			{
				this.putOrcall = value;
			}
		}

		public double Strike
		{
			get
			{
				return this.strike; 
			}
			set
			{
				this.strike = value;
			}
		}

		public double Qty
		{
			get
			{
				return this.qty; 
			}
			set
			{
				this.qty = value;
			}
		}

		public double LongQty
		{
			get
			{
				return this.longQty; 
			}
			set
			{
				this.longQty = value;
			}
		}

		public double ShortQty
		{
			get
			{
				return this.shortQty; 
			}
			set
			{
				this.shortQty = value;
			}
		}

		public BrokerPosition()
		{
			this.symbol = string.Empty;
			this.securityType = string.Empty;
			this.securityExchange = string.Empty;
			this.currency = string.Empty;
			this.maturityDate = DateTime.MinValue;
			this.putOrcall = PutOrCall.Put;
			this.strike = 0.0;
			this.qty = 0.0;
			this.longQty = 0.0;
			this.shortQty = 0.0;
			this.customFields = new SortedList<string, string>(); 
		}

		public void AddCustomField(string name, string value)
		{
			this.customFields.Add(name, value); 
		}

		public BrokerPositionField[] GetCustomFields()
		{
			List<BrokerPositionField> list = new List<BrokerPositionField>();
			foreach (KeyValuePair<string, string> keyValuePair in this.customFields)
				list.Add(new BrokerPositionField(keyValuePair.Key, keyValuePair.Value));
			return list.ToArray();
		}
	}
}
