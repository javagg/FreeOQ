using FreeQuant;
using FreeQuant.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace FreeQuant.Simulation
{
	//  [TypeConverter(typeof (YYAsqAaDblBde0lNpo))]
	public class BarFilter
	{
		private List<BarFilterItem> items;

		[DefaultValue(false)]
		public bool Enabled { get; set; }
		//    [Editor(typeof (BarFilterItemListEditor), typeof (UITypeEditor))]
		public List<BarFilterItem> Items  { get; private set; }

		public BarFilter()
		{
			this.Items = new List<BarFilterItem>();
			this.Enabled = false;
		}

		public bool Contains(BarType barType, long barSize)
		{
			if (!this.Enabled)
				return true;
			foreach (BarFilterItem barFilterItem in this.items)
			{
				if (barFilterItem.BarType == barType && barFilterItem.BarSize == barSize)
					return barFilterItem.Enabled;
			}
			return false;
		}

		public void Reset()
		{
			this.Enabled = false;
			this.Items.Clear();
		}

		public override string ToString()
		{
			List<string> list = new List<string>();
//			list.Add(this.Enabled);
//			foreach (BarFilterItem barFilterItem in this.Items)
//				list.Add(string.Format("dfsd", barFilterItem.Enabled, barFilterItem.BarType, barFilterItem.BarSize));
			return string.Join(",", list.ToArray());
		}

		internal void Vx1yomJJIf([In] string obj0)
		{
			try
			{
				this.Reset();
				string[] strArray1 = obj0.Split(new char[1]
				{
					'-'
				});
				this.Enabled = bool.Parse(strArray1[0]);

				for (int index = 1; index < strArray1.Length; ++index)
				{
					string[] strArray2 = strArray1[index].Split(new char[1]
					{
						','
					});
					this.Items.Add(new BarFilterItem((BarType)Enum.Parse(typeof(BarType), strArray2[1]), long.Parse(strArray2[2]), bool.Parse(strArray2[0])));
				}
			}
			catch (Exception ex)
			{
//        if (Trace.IsLevelEnabled(TraceLevel.Error))
//          Trace.WriteLine(ex);
				this.Reset();
			}
		}
	}
}
