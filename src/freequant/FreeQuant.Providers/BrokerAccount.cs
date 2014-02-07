using System.Collections.Generic;

namespace FreeQuant.Providers
{
	public class BrokerAccount
	{
		private SortedList<string, SortedList<string, string>> fields;
		private List<BrokerPosition> positions;
		private List<BrokerOrder> orders;

		public string Name { get; private set; }
		public double BuyingPower  { get; set; }

		public BrokerAccount(string name)
		{
			this.Name = name;
			this.fields = new SortedList<string, SortedList<string, string>>();
			this.positions = new List<BrokerPosition>();
			this.orders = new List<BrokerOrder>();
		}

		public void AddField(string name, string currency, string value)
		{
			SortedList<string, string> sortedList;
			if (!this.fields.TryGetValue(name, out sortedList))
			{
				sortedList = new SortedList<string, string>();
				this.fields.Add(name, sortedList);
			}
			sortedList.Add(currency, value);
		}

		public void AddField(string name, string value)
		{
			this.AddField(name, string.Empty, value);
		}

		public BrokerAccountField[] GetFields()
		{
			var list = new List<BrokerAccountField>();
			foreach (var field in this.fields)
			{
				string key = field.Key;
				foreach (var pair in field.Value)
					list.Add(new BrokerAccountField(key, pair.Key, pair.Value));
			}
			return list.ToArray();
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
