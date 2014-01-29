using FreeQuant.FinChart;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.FinChart.Objects
{
	public class ImageView : IChartDrawable, IZoomable
	{
		private DrawingImage drawingImage;
		protected DateTime firstDate;
		protected DateTime lastDate;
		protected bool toolTipEnabled;
		protected string toolTipFormat;
		protected bool selected;
		protected DateTime chartFirstDate;
		protected DateTime chartLastDate;

		public Pad Pad { get; set; }

		[Description("Enable or disable tooltip appearance for this marker.")]
		[Category("ToolTip")]
		public bool ToolTipEnabled
		{
			get
			{
				return this.toolTipEnabled;
			}
			set
			{
				this.toolTipEnabled = value;
			}
		}

		[Category("ToolTip")]
		[Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
		public string ToolTipFormat
		{
			get
			{
				return this.toolTipFormat;
			}
			set
			{
				this.toolTipFormat = value;
			}
		}

		public ImageView(DrawingImage image, Pad pad) : base()
		{
			this.drawingImage = image;
			this.Pad = pad;
			this.ToolTipEnabled = true;
			this.ToolTipFormat = "ttoot";
		}

		public void Paint()
		{
			this.fEtwjGRar7();
		}

		public void SetInterval(DateTime minDate, DateTime maxDate)
		{
			this.firstDate = minDate;
			this.lastDate = maxDate;
		}

		public Distance Distance(int x, double y)
		{
			return this.pr8woqu2jc(x, y);
		}

		public void Select()
		{
		}

		public void UnSelect()
		{
		}

		private void fEtwjGRar7()
		{
			this.Pad.Graphics.DrawImage(this.drawingImage.Image, this.Pad.ClientX(this.drawingImage.X), this.Pad.ClientY(this.drawingImage.Y));
		}

		private Distance pr8woqu2jc([In] int obj0, [In] double obj1)
		{
			return (Distance)null;
		}

		public PadRange GetPadRangeY(Pad pad)
		{
			return new PadRange(0.0, 0.0);
		}
	}
}
