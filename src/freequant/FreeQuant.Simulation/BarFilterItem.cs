using FreeQuant.Data;
using FreeQuant.Instruments;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Simulation
{
	public class BarFilterItem
	{
		private const string Status = "Status";
		private const string Properties = "Properties";

		[DefaultValue(true)]
		[Category("Status")]
		public bool Enabled { get; set; }

		[Category("Properties")]
		public BarType BarType { get; set; }

		[Category("Properties")]
		public long BarSize { get; set; }

		public BarFilterItem(BarType barType, long barSize, bool enabled)
		{
			this.BarType = barType;
			this.BarSize = barSize;
			this.Enabled = enabled;
		}

		public BarFilterItem() : this(DataManager.DefaultBarType, DataManager.DefaultBarSize, true)
		{
		}

		public override string ToString()
		{
			return string.Format("", this.BarType, this.BarSize, this.Enabled);
		}
	}
}
