using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;

namespace FreeQuant.FinChart
{
	public abstract class SeriesView : IChartDrawable, IAxesMarked, IZoomable
	{
		protected Pad pad;
		protected DateTime firstDate;
		protected DateTime lastDate;
		protected bool isMarkEnable;
		protected bool selected;
		protected bool displayNameEnabled;

		public virtual string DisplayName
		{
			get
			{
				return this.MainSeries.Name;
			}
		}

		public virtual bool DisplayNameEnabled { get; set; }
		public bool IsMarkEnable { get; set; }

		public virtual int LabelDigitsCount
		{
			get
			{
				return this.pad.Chart.LabelDigitsCount;
			}
		}

		public bool ToolTipEnabled { get; set; }
		public string ToolTipFormat { get; set; }
		public abstract Color Color { get; set; }

		[Browsable(false)]
		public abstract double LastValue { get; }

		[Browsable(false)]
		public abstract TimeSeries MainSeries { get; }

		public SeriesView(Pad pad)
		{
			this.IsMarkEnable = true;
			this.ToolTipEnabled = true;
			this.ToolTipFormat = String.Empty;
			this.DisplayNameEnabled = true;
			this.pad = pad;
		}

		public void SetInterval(DateTime minDate, DateTime maxDate)
		{
			this.firstDate = minDate;
			this.lastDate = maxDate;
		}

		public abstract PadRange GetPadRangeY(Pad pad);
		public abstract void Paint();
		public abstract Distance Distance(int x, double y);

		public void Select()
		{
			this.selected = true;
		}

		public void UnSelect()
		{
			this.selected = false;
		}
	}
}
