using System.Drawing;

namespace OpenQuant.API
{
	/// <summary>
	/// The Chart class is used to modify visual appearence of the project's BarChart.
	/// </summary>
	public class Chart
	{
		private Color chartBackColor = Color.Transparent;
		private Color canvasColor = Color.Transparent;
		private Color axisBottomGridColor = Color.Transparent;
		private Color axisBottomLabelColor = Color.Transparent;
		private Color dateTipRectangleColor = Color.Transparent;
		private Color dateTipTextColor = Color.Transparent;
		private Color valTipRectangleColor = Color.Transparent;
		private Color valTipTextColor = Color.Transparent;
		private Color crossColor = Color.Transparent;
		private Color borderColor = Color.Transparent;
		private Color splitterColor = Color.Transparent;
		private Color candleUpColor = Color.Transparent;
		private Color candleDownColor = Color.Transparent;
		private Color volumeColor = Color.Transparent;
		private Color rightAxisGridColor = Color.Transparent;
		private Color rightAxisTextColor = Color.Transparent;
		private Color rightAxisMinorTicksColor = Color.Transparent;
		private Color rightAxisMajorTicksColor = Color.Transparent;

		/// <summary>
		/// Initializes a new instance of this class
		/// </summary>
		public Chart()
		{
		}

		public Color ForeColor
		{
			get
			{
				return this.canvasColor;
			}
			set
			{
				this.canvasColor = value;
			}
		}

		public Color BackColor
		{
			get
			{
				return this.chartBackColor;
			}
			set
			{
				this.chartBackColor = value;
			}
		}

		public Color BottomAxisGridColor
		{
			get
			{
				return this.axisBottomGridColor;
			}
			set
			{
				this.axisBottomGridColor = value;
			}
		}

		public Color BottomAxisTextColor
		{
			get
			{
				return this.axisBottomLabelColor;
			}
			set
			{
				this.axisBottomLabelColor = value;
			}
		}

		public Color RightAxisGridColor
		{
			get
			{
				return this.rightAxisGridColor;
			}
			set
			{
				this.rightAxisGridColor = value;
			}
		}

		public Color RightAxisTextColor
		{
			get
			{
				return this.rightAxisTextColor;
			}
			set
			{
				this.rightAxisTextColor = value;
			}
		}

		public Color RightAxisMinorTicksColor
		{
			get
			{
				return this.rightAxisMinorTicksColor;
			}
			set
			{
				this.rightAxisMinorTicksColor = value;
			}
		}

		public Color RightAxisMajorTicksColor
		{
			get
			{
				return this.rightAxisMajorTicksColor;
			}
			set
			{
				this.rightAxisMajorTicksColor = value;
			}
		}

		public Color DateTipRectangleColor
		{
			get
			{
				return this.dateTipRectangleColor;
			}
			set
			{
				this.dateTipRectangleColor = value;
			}
		}

		public Color DateTipTextColor
		{
			get
			{
				return this.dateTipTextColor;
			}
			set
			{
				this.dateTipTextColor = value;
			}
		}

		public Color ValueTipRectangleColor
		{
			get
			{
				return this.valTipRectangleColor;
			}
			set
			{
				this.valTipRectangleColor = value;
			}
		}

		public Color ValueTipTextColor
		{
			get
			{
				return this.valTipTextColor;
			}
			set
			{
				this.valTipTextColor = value;
			}
		}

		public Color CrossColor
		{
			get
			{
				return this.crossColor;
			}
			set
			{
				this.crossColor = value;
			}
		}

		public Color BorderColor
		{
			get
			{
				return this.borderColor;
			}
			set
			{
				this.borderColor = value;
			}
		}

		public Color SplitterColor
		{
			get
			{
				return this.splitterColor;
			}
			set
			{
				this.splitterColor = value;
			}
		}

		public Color CandleUpColor
		{
			get
			{
				return this.candleUpColor;
			}
			set
			{
				this.candleUpColor = value;
			}
		}

		public Color CandleDownColor
		{
			get
			{
				return this.candleDownColor;
			}
			set
			{
				this.candleDownColor = value;
			}
		}

		public Color VolumeColor
		{
			get
			{
				return this.volumeColor;
			}
			set
			{
				this.volumeColor = value;
			}
		}
	}
}
