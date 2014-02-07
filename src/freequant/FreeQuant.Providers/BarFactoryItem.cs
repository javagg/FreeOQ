using FreeQuant.Data;
using System;
using System.ComponentModel;

namespace FreeQuant.Providers
{
	public class BarFactoryItem : IComparable
	{
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
			BarFactoryItem that = obj as BarFactoryItem;
			if (that != null)
			{
				if (this.BarSize > that.BarSize)
					return 1;
				if (this.BarSize < that.BarSize)
					return -1;
			}
			return 0;
		}

		public override string ToString()
		{
			return string.Format("BarType: {0}, BarSize: {1}, Enabled: {2}", this.BarType, this.BarSize, this.Enabled);
		}
	}
}
