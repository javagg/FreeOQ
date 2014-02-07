using FreeQuant.FIX;
using System;
using System.Collections.Generic;

namespace FreeQuant.Providers
{
	public class BrokerPosition
	{
		private SortedList<string, string> customFields;
		public string Symbol { get; set; }
		public string SecurityType { get; set; }
		public string SecurityExchange { get; set; }
		public string Currency { get; set; }
		public DateTime MaturityDate { get; set; }
		public PutOrCall PutOrCall { get; set; }
		public double Strike { get; set; }
		public double Qty { get; set; }
		public double LongQty { get; set; }
		public double ShortQty { get; set; }
	
		public BrokerPosition()
		{
			this.customFields = new SortedList<string, string>(); 
		}

		public void AddCustomField(string name, string value)
		{
			this.customFields.Add(name, value); 
		}

		public BrokerPositionField[] GetCustomFields()
		{
			var list = new List<BrokerPositionField>();
			foreach (var field in this.customFields)
				list.Add(new BrokerPositionField(field.Key, field.Value));
			return list.ToArray();
		}
	}
}
