using OpenQuant.API.Design;
using FreeQuant.Execution;
using FreeQuant.FIX;
using System;
using System.ComponentModel;

namespace OpenQuant.API
{
	[TypeConverter(typeof(IBExTypeConverter))]
	public class IBEx
	{
		private SingleOrder order;

		public bool Hidden
		{
			get
			{
				return ((FIXNewOrderSingle)this.order).Hidden;
			}
			set
			{
				((FIXNewOrderSingle)this.order).Hidden = value;
			}
		}

		public double DisplaySize
		{
			get
			{
				return ((FIXNewOrderSingle)this.order).DisplaySize;
			}
			set
			{
				((FIXNewOrderSingle)this.order).DisplaySize = value;
			}
		}

		public string FaGroup
		{
			get
			{
				return ((FIXNewOrderSingle)this.order).FaGroup;
			}
			set
			{
				((FIXNewOrderSingle)this.order).FaGroup = value;
			}
		}

		public IBFaMethod FaMethod
		{
			get
			{
				switch (((NewOrderSingle)this.order).FaMethod)
				{
					case FreeQuant.FIX.FaMethod.PctChange:
						return IBFaMethod.PctChange;
					case FreeQuant.FIX.FaMethod.AvailableEquity:
						return IBFaMethod.AvailableEquity;
					case FreeQuant.FIX.FaMethod.NetLiq:
						return IBFaMethod.NetLiq;
					case FreeQuant.FIX.FaMethod.EqualQuantity:
						return IBFaMethod.EqualQuantity;
					case FreeQuant.FIX.FaMethod.Undefined:
						return IBFaMethod.Undefined;
					default:
						throw new ArgumentException(string.Format("Unknown method - {0}", (object)((NewOrderSingle)this.order).FaMethod));
				}
			}
			set
			{
				switch (value)
				{
					case IBFaMethod.PctChange:
						((NewOrderSingle)this.order).FaMethod = FreeQuant.FIX.FaMethod.PctChange;
						break;
					case IBFaMethod.AvailableEquity:
						((NewOrderSingle)this.order).FaMethod = FreeQuant.FIX.FaMethod.AvailableEquity;
						break;
					case IBFaMethod.NetLiq:
						((NewOrderSingle)this.order).FaMethod = FreeQuant.FIX.FaMethod.NetLiq;
						break;
					case IBFaMethod.EqualQuantity:
						((NewOrderSingle)this.order).FaMethod = FreeQuant.FIX.FaMethod.EqualQuantity;
						break;
					case IBFaMethod.Undefined:
						break;
					default:
						throw new ArgumentException(string.Format("Unknown method - {0}", (object)value));
				}
			}
		}

		public double FaPercentage
		{
			get
			{
				return ((FIXNewOrderSingle)this.order).FaPercentage;
			}
			set
			{
				((FIXNewOrderSingle)this.order).FaPercentage = value;
			}
		}

		public string FaProfile
		{
			get
			{
				return ((FIXNewOrderSingle)this.order).FaProfile;
			}
			set
			{
				((FIXNewOrderSingle)this.order).FaProfile = value;
			}
		}

		internal IBEx(SingleOrder order)
		{
			this.order = order;
		}
	}
}
