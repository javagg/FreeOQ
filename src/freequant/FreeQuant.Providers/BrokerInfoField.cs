using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
	public class BrokerInfoField
	{
		public string Name { get; private set; }
		public string Value { get; private set; }

		protected BrokerInfoField(string name, string value)
		{
			this.Name = name;
			this.Value = value;
		}
	}
}
