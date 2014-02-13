namespace OpenQuant.Shared.TradingTools
{
	class RouteItem
	{
		public string Name { get; private set; }

		public byte ID { get; private set; }

		public RouteItem(string name, byte id)
		{
			this.Name = name;
			this.ID = id;
		}

		public override string ToString()
		{
			return this.Name;
		}
	}
}
