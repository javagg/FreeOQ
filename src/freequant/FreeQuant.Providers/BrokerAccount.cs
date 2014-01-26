using System.Collections.Generic;

namespace FreeQuant.Providers
{
	public class BrokerAccount
	{
		private SortedList<string, SortedList<string, string>> accountFields;
		private List<BrokerPosition> positions;
		private List<BrokerOrder> orders;

		public string Name { get; private set; }
		public double BuyingPower  { get; set; }

		public BrokerAccount(string name)
		{
			this.Name = name;
			this.accountFields = new SortedList<string, SortedList<string, string>>();
			this.positions = new List<BrokerPosition>();
			this.orders = new List<BrokerOrder>();
		}

		public void AddField(string name, string currency, string value)
		{
			SortedList<string, string> sortedList;
			if (!this.accountFields.TryGetValue(name, out sortedList))
			{
				sortedList = new SortedList<string, string>();
				this.accountFields.Add(name, sortedList);
			}
			sortedList.Add(currency, value);
		}

		public void AddField(string name, string value)
		{
			this.AddField(name, string.Empty, value);
		}

		public BrokerAccountField[] GetFields()
		{
			var fields = new List<BrokerAccountField>();
			foreach (var account in this.accountFields)
			{
				string key = account.Key;
				foreach (var field in account.Value)
					fields.Add(new BrokerAccountField(key, field.Key, field.Value));
			}
			return fields.ToArray();
		}

		public void AddPosition(BrokerPosition position)
		{
			this.positions.Add(position); 
		}

		public BrokerPosition[] GetPositions()
		{
			return this.positions.ToArray();
		}

		public void AddOrder(BrokerOrder order)
		{
			this.orders.Add(order); 
		}

		public BrokerOrder[] GetOrders()
		{
			return this.orders.ToArray();
		}
	}
}
