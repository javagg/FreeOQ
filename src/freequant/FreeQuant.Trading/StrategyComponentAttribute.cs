using System;

namespace FreeQuant.Trading
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class StrategyComponentAttribute : Attribute
	{
		public Guid GUID { get; private set; }
		public ComponentType Type { get; private set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public StrategyComponentAttribute(string guid, ComponentType type) : base()
		{
			this.GUID = new Guid(guid);
			this.Type = type;
		}
	}
}
