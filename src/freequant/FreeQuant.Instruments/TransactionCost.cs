using FreeQuant.FIX;
using System;

namespace FreeQuant.Instruments
{
	public class TransactionCost
	{
		private CommType commType;
		private double commission;

		public double Commission
		{
			get
			{
				return this.commission; 
			}
			set
			{
				this.commission = value;
			}
		}

		public CommType CommType
		{
			get
			{
				return this.commType; 
			}
			set
			{
				this.commType = value;
			}
		}

		public TransactionCost(CommType commType, double commission)
		{
			this.Set(commType, commission);
		}

		public TransactionCost() : this(CommType.Absolute, 0.0)
		{
		}

		public void Set(CommType commType, double commission)
		{
			this.commType = commType;
			this.commission = commission;
		}

		public virtual double GetCost(Transaction transaction)
		{
			if (this.commission == 0.0)
				return 0.0;
			switch (this.commType)
			{
				case CommType.PerShare:
					return this.Commission * transaction.Qty;
				case CommType.Percent:
					return this.Commission * transaction.Value;
				case CommType.Absolute:
					return this.Commission;
				default:
					throw new NotSupportedException("" + (object)this.commType);
			}
		}
	}
}
