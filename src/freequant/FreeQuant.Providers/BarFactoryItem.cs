using FreeQuant.Data;
using System;
using System.ComponentModel;

namespace FreeQuant.Providers
{
	public class BarFactoryItem : IComparable
	{
		internal const BarType aYrgwoBvsH = BarType.Time;
		internal const long l27gtTMOx0 = 60;
		internal const bool dAxggIVaoI = true;

		[DefaultValue(BarType.Time)]
		public BarType BarType { get; set; }

		[DefaultValue(60)]
		public long BarSize { get; set; }

		[DefaultValue(true)]
		public bool Enabled { get; set; }

		public BarFactoryItem(BarType barType, long barSize, bool enabled)
		{
			this.BarType = barType;
			this.BarSize = barSize;
			this.Enabled = enabled;
		}

		public BarFactoryItem() : this(BarType.Time, 60, true)
		{
		}

		public int CompareTo(object obj)
		{
			BarFactoryItem barFactoryItem = obj as BarFactoryItem;
			if (barFactoryItem != null)
			{
				if (this.BarSize > barFactoryItem.BarSize)
					return 1;
				if (this.BarSize < barFactoryItem.BarSize)
					return -1;
			}
			return 0;
		}

		public override string ToString()
		{
			return string.Format("{0}", this.BarType, this.BarSize, this.Enabled);
		}
	}
}
