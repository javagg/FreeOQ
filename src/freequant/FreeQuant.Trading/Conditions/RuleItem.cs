using System;

namespace FreeQuant.Trading.Conditions
{
	public abstract class RuleItem
	{
		public virtual string Name	{ get	{ return String.Empty; } }
		public abstract string CodeName { get; }

		public RuleItem()
		{
		}

		public abstract void Execute();
	}
}
