using System.ComponentModel;

namespace FreeQuant.Trading
{
	public class ComponentBase : IComponentBase
	{
		protected string name;
		protected string description;

		[Category("Description")]
		[ReadOnly(true)]
		[Description("Component name")]
		public virtual string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		[Category("Description")]
		[ReadOnly(true)]
		[Description("Component description")]
		public virtual string Description
		{
			get
			{
				return this.description;
			}
			set
			{
				this.description = value;
			}
		}

		public ComponentBase()
		{
		}

		public virtual void Init()
		{
		}

		public virtual void Connect()
		{
		}

		public virtual void Disconnect()
		{
		}

		public virtual void OnStrategyStop()
		{
		}
	}
}
