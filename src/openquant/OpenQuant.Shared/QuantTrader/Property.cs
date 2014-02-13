using System;

namespace OpenQuant.Shared.QuantTrader
{
	public class Property
	{
		public string Name { get; private set; }

		public Type Type { get; private set; }

		public object Value { get; set; }

		public Property(string name, Type type, object value)
		{
			this.Name = name;
			this.Type = type;
			this.Value = value;
		}
	}
}
