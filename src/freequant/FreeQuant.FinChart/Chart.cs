using FreeQuant.Execution;
using FreeQuant.FinChart.Objects;
using FreeQuant.Instruments;
using FreeQuant.Series;
using FreeQuant.Trading;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FreeQuant.FinChart
{
	public class Chart : UserControl
	{
		private IContainer container;
		private int PRRwtLFpd5;
		private int etYww3BBO8;
		protected bool sessionGridEnabled;
		protected SmoothingMode smoothingMode;
		protected SmoothingMode doubleSeriesSmoothingMode;
		protected BSStyle barSeriesStyle;
		protected SeriesView mainSeriesView;
		protected PadList pads;
		protected int minCountOfBars;
		protected int canvasLeftOffset;
		protected int canvasTopOffset;
		protected int canvasRightOffset;
		protected int canvasBottomOffset;
		protected TimeSeries mainSeries;
		protected TimeSeries series;
		protected Color canvasColor;
		protected int firstIndex;
		protected int lastIndex;
		private HScrollBar hScrollBar;
		protected Graphics graphics;
		protected double intervalWidth;
		protected AxisBottom axisBottom;
		protected ArrayList padsHeightArray;
		protected int mouseX;
		protected int mouseY;
		protected bool padSplit;
		protected int padSplitIndex;
		protected bool isMouseOverCanvas;
		protected bool contentUpdated;
		protected Bitmap bitmap;
		internal ToolTip toolTip;
		private ChartActionType actionType;
		protected DateTime leftDateTime;
		protected DateTime rightDateTime;
		protected ChartUpdateStyle updateStyle;
		protected bool volumePadShown;
		protected int minAxisGap;
		protected PadScaleStyle scaleStyle;
		protected VolumeBSView volumeView;
		private int rightAxesFontSize;
		internal Font font;
		private Color chartBackColor;
		private Color dateTipRectangleColor;
		private Color dateTipTextColor;
		private Color valTipRectangleColor;
		private Color valTipTextColor;
		private Color crossColor;
		private Color borderColor;
		private Color splitterColor;
		private Color candleUpColor;
		private Color candleDownColor;
		private Color volumeColor;
		private Color rightAxisGridColor;
		private Color rightAxisTextColor;
		private Color rightAxisMinorTickColor;
		private Color rightAxisMajorTicksColor;
		private Color itemTextColor;
		private Color selectedItemTextColor;
		private Color selectedTransactionHighlightColor;
		private Color activeStopColor;
		private Color executedStopColor;
		private Color canceledStopColor;
		private object dataLock;
		private DateTime MPmwkOLBbW;
		private DateTime AAUwMEaLwI;

		public bool ContextMenuEnabled { get; set; }

		public int RightAxesFontSize
		{
			get
			{
				return this.rightAxesFontSize;
			}
			 set
			{
				this.rightAxesFontSize = value;
				this.font = new Font(this.Font.FontFamily, this.rightAxesFontSize);
			}
		}

		public int LabelDigitsCount {	get; set; }
		public Image PrimitiveDeleteImage { get; set; }
		public Image PrimitivePropertiesImage { get; set; }

		[Browsable(false)]
		public bool DrawItems { get; set; }

		[Browsable(false)]
		public bool VolumePadVisible
		{
			 get
			{
				return this.volumePadShown;
			}
			 set
			{
				if (value)
					this.ShowVolumePad();
				else
					this.HideVolumePad();
			}
		}

		public ChartUpdateStyle UpdateStyle
		{
			 get
			{
				return this.updateStyle;
			}
			 set
			{
				this.updateStyle = value;
				this.EmitUpdateStyleChanged();
			}
		}

		public BSStyle BarSeriesStyle
		{
			 get
			{
				return this.barSeriesStyle;
			}
			 set
			{
				this.DrawItems = true;
				if (this.barSeriesStyle == value)
					return;
				lock (this.dataLock)
				{
					this.barSeriesStyle = value;
					if (this.mainSeries != null)
					{
						bool local_0 = this.vA32MRaPG(this.barSeriesStyle, false);
						if (this.volumePadShown && local_0)
						{
							this.pads[1].RemovePrimitive((IChartDrawable)this.volumeView);
							this.volumeView = new VolumeBSView(this.pads[1], this.mainSeries as DoubleSeries);
							this.volumeView.Color = this.volumeColor;
							this.pads[1].AddPrimitive((IChartDrawable)this.volumeView);
						}
						if (local_0)
						{
							this.firstIndex = Math.Max(0, this.mainSeries.Count - this.minCountOfBars);
							this.lastIndex = this.mainSeries.Count - 1;
							if (this.mainSeries.Count == 0)
								this.firstIndex = -1;
							if (this.lastIndex >= 0)
								this.xhyOat6AP(this.firstIndex, this.lastIndex);
						}
						this.contentUpdated = true;
					}
					this.EmitBarSeriesStyleChanged();
					this.Invalidate();
				}
			}
		}

		[Description("")]
		[Category("Transformation")]
		public bool SessionGridEnabled
		{
			 get
			{
				return this.sessionGridEnabled;
			}
			 set
			{
				this.sessionGridEnabled = value;
			}
		}

		[Category("Transformation")]
		[Description("")]
		public Color SessionGridColor { get; set; }

		[Description("")]
		[Category("Transformation")]
		public TimeSpan SessionStart { get; set; }

		[Category("Transformation")]
		[Description("")]
		public TimeSpan SessionEnd { get; set; }
		public double IntervalWidth
		{
			 get
			{
				return this.intervalWidth;
			}
		}

		public Graphics Graphics
		{
			 get
			{
				return this.graphics;
			}
		}

		public SmoothingMode SmoothingMode { get; set; }

		public TimeSeries MainSeries
		{
			 get
			{
				return this.mainSeries;
			}
		}

		public int FirstIndex
		{
			 get
			{
				return this.firstIndex;
			}
		}

		public int LastIndex
		{
			 get
			{
				return this.lastIndex;
			}
		}

		public int PadCount
		{
			 get
			{
				return this.pads.Count;
			}
		}

		public Color CanvasColor
		{
			 get
			{
				return this.canvasColor;
			}
			 set
			{
				this.contentUpdated = true;
				this.canvasColor = value;
			}
		}

		public Color ChartBackColor
		{
			 get
			{
				return this.chartBackColor; 
			}
			 set
			{
				this.contentUpdated = true;
				this.chartBackColor = value;
			}
		}

		public ChartActionType ActionType
		{
			 get
			{
				return this.actionType;
			}
			 set
			{
				if (this.actionType == value)
					return;
				this.actionType = value;
				this.EmitActionTypeChanged();
				this.Invalidate();
			}
		}

		public int MinNumberOfBars
		{
			 get
			{
				return this.minCountOfBars;
			}
			 set
			{
				this.minCountOfBars = value;
			}
		}

		public Color SelectedTransactionHighlightColor
		{
			 get
			{
				return this.selectedTransactionHighlightColor;
			}
			 set
			{
				this.selectedTransactionHighlightColor = Color.FromArgb(100, value);
				this.contentUpdated = true;
			}
		}

		public Color ItemTextColor
		{
			 get
			{
				return this.itemTextColor;
			}
			 set
			{
				this.itemTextColor = value;
				this.contentUpdated = true;
			}
		}

		public Color SelectedItemTextColor
		{
			 get
			{
				return this.selectedItemTextColor;
			}
			 set
			{
				this.selectedItemTextColor = value;
				this.contentUpdated = true;
			}
		}

		public Color BottomAxisGridColor
		{
			 get
			{
				return this.axisBottom.GridColor;
			}
			 set
			{
				this.contentUpdated = true;
				this.axisBottom.GridColor = value;
			}
		}

		public Color BottomAxisLabelColor
		{
			 get
			{
				return this.axisBottom.LabelColor;
			}
			 set
			{
				this.contentUpdated = true;
				this.axisBottom.LabelColor = value;
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
				this.contentUpdated = true;
				foreach (Pad pad in this.pads)
					pad.Axis.GridColor = value;
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
				this.contentUpdated = true;
				foreach (Pad pad in this.pads)
					pad.Axis.LabelColor = value;
				this.rightAxisTextColor = value;
			}
		}

		public Color RightAxisMinorTicksColor
		{
			 get
			{
				return this.rightAxisMinorTickColor; 
			}
			 set
			{
				this.contentUpdated = true;
				foreach (Pad pad in this.pads)
					pad.Axis.MinorTicksColor = value;
				this.rightAxisMinorTickColor = value;
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
				this.contentUpdated = true;
				foreach (Pad pad in this.pads)
					pad.Axis.MajorTicksColor = value;
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
				this.contentUpdated = true;
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
				this.contentUpdated = true;
				this.dateTipTextColor = value;
			}
		}

		public Color ValTipRectangleColor
		{
			get 
			{
				return this.valTipRectangleColor;
			}
			 set
			{
				this.contentUpdated = true;
				this.valTipRectangleColor = value;
			}
		}

		public Color ValTipTextColor
		{
			get 
			{
				return this.valTipTextColor;
			}
			 set
			{
				this.contentUpdated = true;
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
				this.contentUpdated = true;
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
				this.contentUpdated = true;
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
				this.contentUpdated = true;
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
				this.contentUpdated = true;
				this.candleUpColor = value;
				if (!(this.mainSeriesView is SimpleBSView))
					return;
				(this.mainSeriesView as SimpleBSView).UpColor = this.candleUpColor;
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
				this.contentUpdated = true;
				this.candleDownColor = value;
				if (!(this.mainSeriesView is SimpleBSView))
					return;
				(this.mainSeriesView as SimpleBSView).DownColor = this.candleDownColor;
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
				this.contentUpdated = true;
				this.volumeColor = value;
				if (this.volumeView == null)
					return;
				this.volumeView.Color = this.volumeColor;
			}
		}

		public Color ActiveStopColor
		{
			 get
			{
				return this.activeStopColor;
			}
			 set
			{
				this.contentUpdated = true;
				this.activeStopColor = value;
				foreach (Pad pad in this.pads)
				{
					foreach (IChartDrawable chartDrawable in pad.Primitives)
					{
						if (chartDrawable is StopView)
							(chartDrawable as StopView).ActiveColor = value;
					}
				}
			}
		}

		public Color CanceledStopColor
		{
			 get
			{
				return this.canceledStopColor;
			}
			 set
			{
				this.contentUpdated = true;
				this.canceledStopColor = value;
				foreach (Pad pad in this.pads)
				{
					foreach (IChartDrawable chartDrawable in pad.Primitives)
					{
						if (chartDrawable is StopView)
							(chartDrawable as StopView).CanceledColor = value;
					}
				}
			}
		}

		public Color ExecutedStopColor
		{
			 get
			{
				return this.executedStopColor;
			}
			 set
			{
				this.contentUpdated = true;
				this.executedStopColor = value;
				foreach (Pad pad in this.pads)
				{
					foreach (IChartDrawable chartDrawable in pad.Primitives)
					{
						if (chartDrawable is StopView)
							(chartDrawable as StopView).ExecutedColor = value;
					}
				}
			}
		}

		public PadScaleStyle ScaleStyle
		{
			 get
			{
				return this.scaleStyle;
			}
			 set
			{
				this.scaleStyle = value;
				this.pads[0].ScaleStyle = value;
				this.contentUpdated = true;
				this.Invalidate();
				this.EmitScaleStyleChanged();
			}
		}

		public event EventHandler UpdateStyleChanged;
		public event EventHandler VolumeVisibleChanged;
		public event EventHandler ActionTypeChanged;
		public event EventHandler BarSeriesStyleChanged;
		public event EventHandler ScaleStyleChanged;
			
		public Chart() : base()
		{
			this.PRRwtLFpd5 = -1;
			this.etYww3BBO8 = -1;
			this.doubleSeriesSmoothingMode = SmoothingMode.HighSpeed;
			this.pads = new PadList();
			this.minCountOfBars = 125;
			this.canvasLeftOffset = 20;
			this.canvasTopOffset = 20;
			this.canvasRightOffset = 20;
			this.canvasBottomOffset = 30;
			this.canvasColor = Color.MidnightBlue;
			this.padsHeightArray = new ArrayList();
			this.padSplitIndex = -1;
			this.contentUpdated = true;
			this.actionType = ChartActionType.None;
			this.updateStyle = ChartUpdateStyle.Trailing;
			this.minAxisGap = 50;
			this.ContextMenuEnabled = true;
			this.LabelDigitsCount = 2;
			this.rightAxesFontSize = 7;
			this.dateTipRectangleColor = Color.LightGray;
			this.dateTipTextColor = Color.Black;
			this.valTipRectangleColor = Color.LightGray;
			this.valTipTextColor = Color.Black;
			this.crossColor = Color.DarkGray;
			this.borderColor = Color.Gray;
			this.splitterColor = Color.LightGray;
			this.candleUpColor = Color.Black;
			this.candleDownColor = Color.Lime;
			this.volumeColor = Color.SteelBlue;
			this.rightAxisGridColor = Color.DimGray;
			this.rightAxisTextColor = Color.LightGray;
			this.rightAxisMinorTickColor = Color.LightGray;
			this.rightAxisMajorTicksColor = Color.LightGray;
			this.itemTextColor = Color.LightGray;
			this.selectedItemTextColor = Color.Yellow;
			this.selectedTransactionHighlightColor = Color.LightBlue;
			this.activeStopColor = Color.Yellow;
			this.executedStopColor = Color.MediumSeaGreen;
			this.canceledStopColor = Color.Gray;
			this.dataLock = new object();
			this.MPmwkOLBbW = DateTime.MaxValue;
			this.AAUwMEaLwI = DateTime.MinValue;

			this.InitializeComponent();
			this.font = new Font(this.Font.FontFamily, (float)this.rightAxesFontSize);
			this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
			this.UpdateStyles();
			this.canvasLeftOffset = 10;
			this.canvasTopOffset = 10;
			this.canvasRightOffset = 40;
			this.canvasBottomOffset = 40;
			this.MouseWheel += new MouseEventHandler(this.HandleMouseWheel);
			this.AddPad();
			this.axisBottom = new AxisBottom(this, this.canvasLeftOffset, this.Width - this.canvasRightOffset, this.Height - this.canvasTopOffset);
			this.hScrollBar.Minimum = 0;
			this.chartBackColor = Color.MidnightBlue;
			this.firstIndex = -1;
			this.lastIndex = -1;
		}

		public Chart(DoubleSeries mainSeries) : this()
		{
			this.SetMainSeries(mainSeries);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.container != null)
				this.container.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.container = new Container();
			this.hScrollBar = new HScrollBar();
			this.toolTip = new ToolTip(this.container);
			this.SuspendLayout();
			this.hScrollBar.Dock = DockStyle.Bottom;
			this.hScrollBar.Location = new Point(0, 455);
			this.hScrollBar.Name = "hscbar name";
			this.hScrollBar.Size = new Size(512, 17);
			this.hScrollBar.TabIndex = 0;
			this.hScrollBar.Scroll += new ScrollEventHandler(this.FSOLY9YLw);
			this.AutoScroll = true;
			this.Controls.Add(this.hScrollBar);
			this.Font = new Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.Name = "Chart name";
			this.Size = new Size(512, 472);
			this.MouseDown += new MouseEventHandler(this.HandleMouseDown);
			this.MouseLeave += new EventHandler(this.HandleMouseLeave);
			this.MouseUp += new MouseEventHandler(this.HandleMouseUp);
			this.ResumeLayout(false);
		}

		internal TimeSeries GetSeries()
		{
			return this.series;
		}

		internal bool IsContentUpdated()
		{
			return this.contentUpdated;
		}

		internal void SetContentUpdated(bool value)
		{
			this.contentUpdated = value;
		}

		internal void NXKu7WiuX(Pen pen, long obj1, int obj2)
		{
			this.graphics.DrawLine(pen, this.ClientX(new DateTime(obj1)), this.canvasTopOffset + this.Height - (this.canvasBottomOffset + this.canvasTopOffset), this.ClientX(new DateTime(obj1)), this.canvasTopOffset + this.Height - (this.canvasBottomOffset + this.canvasTopOffset) + obj2);
		}
		
		internal void IXrxgFKyT(Pen pen, long obj1)
		{
			int x1 = this.ClientX(new DateTime(obj1));
			this.graphics.DrawLine(pen, x1, this.canvasTopOffset, this.ClientX(new DateTime(obj1)), this.canvasTopOffset + this.Height - (this.canvasBottomOffset + this.canvasTopOffset));
		}

		internal void pw9AQjMR6(Pen pen, long obj1)
		{
			this.graphics.DrawLine(pen, (int)((double)this.ClientX(new DateTime(obj1)) - this.intervalWidth / 2.0), this.canvasTopOffset, (int)((double)this.ClientX(new DateTime(obj1)) - this.intervalWidth / 2.0), this.canvasTopOffset + this.Height - (this.canvasBottomOffset + this.canvasTopOffset));
		}

		public void DrawSeries(DoubleSeries series, int padNumber, Color color)
		{
			this.DrawSeries(series, padNumber, color, EIndexOption.Null);
		}

		public void DrawSeries(DoubleSeries series, int padNumber, Color color, EIndexOption option)
		{
			lock(this.dataLock)
			{
				if (!this.volumePadShown && padNumber > 1)
					--padNumber;
				DSView view = new DSView(this.pads[padNumber], series, color, option, this.doubleSeriesSmoothingMode);
				this.pads[padNumber].AddPrimitive(view);
				view.SetInterval(this.leftDateTime, this.rightDateTime);
				this.contentUpdated = true;
			}
		}

		public void DrawSeries(DoubleSeries series, int padNumber, Color color, SimpleDSStyle style)
		{
			this.DrawSeries(series, padNumber, color, style, EIndexOption.Null, this.doubleSeriesSmoothingMode);
		}
		
		public void DrawSeries(DoubleSeries series, int padNumber, Color color, SimpleDSStyle style, SmoothingMode smoothingMode)
		{
			this.DrawSeries(series, padNumber, color, style, EIndexOption.Null, smoothingMode);
		}

		public void DrawSeries(DoubleSeries series, int padNumber, Color color, SimpleDSStyle style, EIndexOption option, SmoothingMode smoothingMode)
		{
			lock(this.dataLock)
			{
				if (!this.volumePadShown && padNumber > 1)
					--padNumber;
				DSView view = new DSView(this.pads[padNumber], series, color, option, smoothingMode);
				view.Style = style;
				this.pads[padNumber].AddPrimitive(view);
				view.SetInterval(this.leftDateTime, this.rightDateTime);
				this.contentUpdated = true;
			}
		}

		public void DrawTransaction(Transaction transaction, int padNumber)
		{
			lock (this.dataLock)
			{
				if (!this.volumePadShown && padNumber > 1)
					--padNumber;
				TransactionView view = new TransactionView(transaction, this.pads[padNumber]);
				this.pads[padNumber].AddPrimitive(view);
				view.SetInterval(this.leftDateTime, this.rightDateTime);
			}
		}

		public void DrawRay(DrawingRay ray, int padNumber)
		{
			lock(this.dataLock)
			{
				if (!this.volumePadShown && padNumber > 1)
					--padNumber;
				RayView view = new RayView(ray, this.pads[padNumber]);
				ray.Updated += new EventHandler(this.Xsr5a43Ll);
				this.pads[padNumber].AddPrimitive(view);
				view.SetInterval(this.leftDateTime, this.rightDateTime);
				this.contentUpdated = true;
			}
		}

		private void Xsr5a43Ll(object sender, EventArgs e)
		{
			this.contentUpdated = true;
			this.Invalidate();
		}

		public void DrawLine(DrawingLine line, int padNumber)
		{
			lock(this.dataLock)
			{
				if (!this.volumePadShown && padNumber > 1)
					--padNumber;
				LineView view = new LineView(line, this.pads[padNumber]);
				line.Updated += new EventHandler(this.Xsr5a43Ll);
				this.pads[padNumber].AddPrimitive((IChartDrawable)view);
				view.SetInterval(this.leftDateTime, this.rightDateTime);
				this.contentUpdated = true;
			}
		}

		public void DrawEllipse(DrawingEllipse circle, int padNumber)
		{
			lock (this.dataLock)
			{
				if (!this.volumePadShown && padNumber > 1)
					--padNumber;
				EllipseView view = new EllipseView(circle, this.pads[padNumber]);
				circle.Updated += new EventHandler(this.Xsr5a43Ll);
				this.pads[padNumber].AddPrimitive(view);
				view.SetInterval(this.leftDateTime, this.rightDateTime);
				this.contentUpdated = true;
			}
		}

		public void DrawRectangle(DrawingRectangle rect, int padNumber)
		{
			lock (this.dataLock)
			{
				if (!this.volumePadShown && padNumber > 1)
					--padNumber;
				RectangleView view = new RectangleView(rect, this.pads[padNumber]);
				rect.Updated += new EventHandler(this.Xsr5a43Ll);
				this.pads[padNumber].AddPrimitive(view);
				view.SetInterval(this.leftDateTime, this.rightDateTime);
				this.contentUpdated = true;
			}
		}

		public void DrawPath(DrawingPath path, int padNumber)
		{
			lock(this.dataLock)
			{
				if (!this.volumePadShown && padNumber > 1)
					--padNumber;
				PathView view = new PathView(path, this.pads[padNumber]);
				path.Updated += new EventHandler(this.Xsr5a43Ll);
				this.pads[padNumber].AddPrimitive(view);
				view.SetInterval(this.leftDateTime, this.rightDateTime);
				this.contentUpdated = true;
			}
		}

		public void DrawImage(DrawingImage image, int padNumber)
		{
			lock(this.dataLock)
			{
				if (!this.volumePadShown && padNumber > 1)
					--padNumber;
				ImageView view = new ImageView(image, this.pads[padNumber]);
				image.Updated += new EventHandler(this.Xsr5a43Ll);
				this.pads[padNumber].AddPrimitive(view);
				view.SetInterval(this.leftDateTime, this.rightDateTime);
				this.contentUpdated = true;
			}
		}

		public void DrawSignal(Signal signal, int padNumber)
		{
			lock(this.dataLock)
			{
				if (!this.volumePadShown && padNumber > 1)
					--padNumber;
				SignalView view = new SignalView(signal, this.pads[padNumber]);
				this.pads[padNumber].AddPrimitive(view);
				view.SetInterval(this.leftDateTime, this.rightDateTime);
			}
		}

		public void DrawOrder(SingleOrder order, int padNumber)
		{
		}
		
		public void DrawStop(ATSStop stop, int padNumber)
		{
			lock (this.dataLock)
			{
				if (!this.volumePadShown && padNumber > 1)
					--padNumber;
				StopView view = new StopView(stop, this.pads[padNumber]);
				this.pads[padNumber].AddPrimitive(view);
				view.ExecutedColor = this.executedStopColor;
				view.ActiveColor = this.activeStopColor;
				view.CanceledColor = this.canceledStopColor;
				view.SetInterval(this.leftDateTime, this.rightDateTime);
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			lock (this.dataLock)
			{
				try
				{
					this.HNXZVR2bH(e.Graphics);
					if (this.lastIndex <= 0 || this.firstIndex < 0)
						return;
					if (this.hScrollBar.Maximum != this.mainSeries.Count - (this.lastIndex - this.firstIndex + 1) + this.hScrollBar.LargeChange - 1)
						this.hScrollBar.Maximum = this.mainSeries.Count - (this.lastIndex - this.firstIndex + 1) + this.hScrollBar.LargeChange - 1;
					if (this.hScrollBar.Value == this.firstIndex)
						return;
					this.hScrollBar.Value = this.firstIndex;
				}
				catch
				{
				}
			}
		}

		private void HNXZVR2bH(Graphics obj0)
		{
			if (this.lastIndex - this.firstIndex + 1 == 0)
				return;
			int num1 = this.Width - this.canvasLeftOffset - this.canvasRightOffset;
			int height = this.Height;
			this.intervalWidth = (double)(num1 / (this.lastIndex - this.firstIndex + 1));
			if (this.contentUpdated)
			{
				if (this.bitmap != null)
					this.bitmap.Dispose();
				this.bitmap = new Bitmap(this.Width, this.Height);
				Graphics graphics = Graphics.FromImage(this.bitmap);
				graphics.SmoothingMode = this.smoothingMode;
				graphics.Clear(this.chartBackColor);
				this.graphics = graphics;
				int val1 = int.MinValue;
				foreach (Pad pad in this.pads)
				{
					pad.q1WJ72NWjL();
					if (val1 < pad.getAxisGap() + 2)
						val1 = pad.getAxisGap() + 2;
				}
				this.canvasRightOffset = Math.Max(val1, this.minAxisGap);
				foreach (Pad pad in this.pads)
				{
					pad.DrawItems = this.DrawItems;
					pad.setWidth(this.Width - this.canvasRightOffset - this.canvasLeftOffset);
				}
				graphics.FillRectangle((Brush)new SolidBrush(this.canvasColor), this.canvasLeftOffset, this.canvasTopOffset, this.Width - this.canvasRightOffset - this.canvasLeftOffset, this.Height - this.canvasBottomOffset - this.canvasLeftOffset);
				if (this.AAUwMEaLwI != DateTime.MinValue)
				{
					int num2 = this.ClientX(this.AAUwMEaLwI);
					if (num2 > this.canvasLeftOffset && num2 < this.Width - this.canvasRightOffset)
						graphics.FillRectangle((Brush)new SolidBrush(this.selectedTransactionHighlightColor), (float)num2 - (float)this.intervalWidth / 2f, (float)this.canvasTopOffset, (float)this.intervalWidth, (float)(this.Height - this.canvasBottomOffset - this.canvasLeftOffset));
				}
				graphics.DrawRectangle(new Pen(this.borderColor), this.canvasLeftOffset, this.canvasTopOffset, this.Width - this.canvasRightOffset - this.canvasLeftOffset, this.Height - this.canvasBottomOffset - this.canvasLeftOffset);
				if (this.mainSeries != null && this.mainSeries.Count != 0)
					this.axisBottom.PaintWithDates(this.mainSeries.GetDateTime(this.firstIndex), this.mainSeries.GetDateTime(this.lastIndex));
				foreach (Pad pad in this.pads)
					pad.WxfJR1jrge(graphics);
				for (int index = 1; index < this.pads.Count; ++index)
					graphics.DrawLine(new Pen(this.splitterColor), this.pads[index].X1, this.pads[index].Y1, this.pads[index].X2, this.pads[index].Y1);
				graphics.Dispose();
				this.contentUpdated = false;
			}
			if (this.mainSeries != null && this.mainSeries.Count != 0 && (this.actionType == ChartActionType.Cross && this.isMouseOverCanvas) && this.bitmap != null)
			{
				obj0.DrawImage((Image)this.bitmap, 0, 0);
				obj0.SmoothingMode = this.smoothingMode;
				Point point = this.PointToClient(Cursor.Position);
				this.mouseX = point.X;
				this.mouseY = point.Y;
				obj0.DrawLine(new Pen(this.crossColor, 0.5f), this.canvasLeftOffset, this.mouseY, this.mouseX - 10, this.mouseY);
				obj0.DrawLine(new Pen(this.crossColor, 0.5f), this.mouseX + 10, this.mouseY, this.Width - this.canvasRightOffset, this.mouseY);
				obj0.DrawLine(new Pen(this.crossColor, 0.5f), this.mouseX, this.canvasTopOffset, this.mouseX, this.mouseY - 10);
				obj0.DrawLine(new Pen(this.crossColor, 0.5f), this.mouseX, this.mouseY + 10, this.mouseX, this.Height - this.canvasBottomOffset);
				string str1 = this.GetDateTime(this.mouseX).ToString();
				SizeF sizeF1 = obj0.MeasureString(str1, this.Font);
				obj0.FillRectangle((Brush)new SolidBrush(this.dateTipRectangleColor), (float)((double)this.mouseX - (double)sizeF1.Width / 2.0 - 2.0), (float)(this.Height - this.canvasBottomOffset), sizeF1.Width, sizeF1.Height + 2f);
				obj0.DrawString(str1, this.Font, (Brush)new SolidBrush(this.dateTipTextColor), (float)((double)this.mouseX - (double)sizeF1.Width / 2.0 - 1.0), (float)(this.Height - this.canvasBottomOffset + 2));
				double num2 = 0.0;
				for (int index = 0; index < this.pads.Count; ++index)
				{
					Pad pad = this.pads[index];
					if (pad.Y2 > this.mouseY && pad.Y1 < this.mouseY)
					{
						num2 = pad.WorldY(this.mouseY);
						break;
					}
				}
				string str2 = num2.ToString("D" + this.LabelDigitsCount);
				SizeF sizeF2 = obj0.MeasureString(str2, this.Font);
				obj0.FillRectangle(new SolidBrush(this.valTipRectangleColor), (float)(this.Width - this.canvasRightOffset), (float)(this.mouseY - sizeF2.Height / 2.0 - 2.0), sizeF2.Width, sizeF2.Height + 2f);
				obj0.DrawString(str2, this.Font, new SolidBrush(this.valTipTextColor), (float)(this.Width - this.canvasRightOffset + 2), (float)(this.mouseY - sizeF2.Height / 2.0 - 1.0));
			}
			else
			{
				if (this.bitmap == null)
					return;
				obj0.DrawImage(this.bitmap, 0, 0);
			}
		}

		private void HandleMouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				if (this.isMouseOverCanvas)
				{
					foreach (Pad pad in this.pads)
					{
						if (pad.Y1 - 1 <= e.Y && e.Y <= pad.Y1 + 1)
						{
							this.padSplit = true;
							this.padSplitIndex = this.pads.IndexOf(pad);
							return;
						}
					}
				}
				foreach (Pad pad in this.pads)
				{
					if (pad.X1 <= e.X && pad.X2 >= e.X && (pad.Y1 <= e.Y && pad.Y2 >= e.Y))
						pad.MouseDown(e);
				}
			}
			catch
			{
			}
		}

		private void HandleMouseUp(object sender, MouseEventArgs e)
		{
			try
			{
				if (this.padSplit)
					this.padSplit = false;
				foreach (Pad pad in this.pads)
				{
					if (pad.X1 <= e.X && pad.X2 >= e.X && (pad.Y1 <= e.Y && pad.Y2 >= e.Y))
						pad.MouseUp(e);
				}
				this.Invalidate();
			}
			catch
			{
			}
		}

		private void HandleMouseWheel(object sender, MouseEventArgs e)
		{
			if (e.Delta > 0)
				this.yHuMeqhH1(e.Delta / 20);
			else
				this.HS5QjNKgD(-e.Delta / 20);
			this.Invalidate();
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			try
			{
				this.mouseX = e.X;
				this.mouseY = e.Y;
				if (this.PRRwtLFpd5 != this.mouseX || this.etYww3BBO8 != this.mouseY)
				{
					if (e.X > this.canvasLeftOffset && e.X < this.Width - this.canvasRightOffset && (e.Y > this.canvasTopOffset && e.Y < this.Height - this.canvasBottomOffset))
					{
						this.isMouseOverCanvas = true;
						if (this.actionType == ChartActionType.Cross)
							this.Cursor = Cursors.Cross;
					}
					else
					{
						this.isMouseOverCanvas = false;
						if (this.actionType == ChartActionType.Cross)
							this.Invalidate();
						this.Cursor = Cursors.Default;
					}
					if (this.padSplit && this.padSplitIndex != 0)
					{
						Pad pad1 = this.pads[this.padSplitIndex];
						Pad pad2 = this.pads[this.padSplitIndex - 1];
						int num1 = e.Y;
						if (pad1.Y2 - e.Y < 20)
							num1 = pad1.Y2 - 20;
						if (e.Y - pad2.Y1 < 20)
							num1 = pad2.Y1 + 20;
						if (pad1.Y2 - num1 >= 20 && num1 - pad2.Y1 >= 20)
						{
							int num2 = pad1.Y2 - num1;
							int num3 = num1 - pad2.Y1;
							this.padsHeightArray[this.padSplitIndex] = (object)((double)num2 / (double)(this.Height - this.canvasTopOffset - this.canvasBottomOffset));
							this.padsHeightArray[this.padSplitIndex - 1] = (object)((double)num3 / (double)(this.Height - this.canvasTopOffset - this.canvasBottomOffset));
							pad1.SetCanvas(pad1.X1, pad1.X2, num1, pad1.Y2);
							pad2.SetCanvas(pad2.X1, pad2.X2, pad2.Y1, num1);
						}
						this.contentUpdated = true;
						this.Invalidate();
					}
					foreach (Pad pad in this.pads)
					{
						if (pad.Y1 - 1 <= e.Y && e.Y <= pad.Y1 + 1 && (this.pads.IndexOf(pad) != 0 && Cursor.Current != Cursors.HSplit))
							Cursor.Current = Cursors.HSplit;
					}
					foreach (Pad pad in this.pads)
					{
						if (pad.X1 <= e.X && pad.X2 >= e.X && (pad.Y1 <= e.Y && pad.Y2 >= e.Y))
							pad.MouseMove(e);
					}
					if (this.isMouseOverCanvas && this.actionType == ChartActionType.Cross)
						this.Invalidate();
				}
				this.PRRwtLFpd5 = this.mouseX;
				this.etYww3BBO8 = this.mouseY;
			}
			catch
			{
			}
		}

		private void HandleMouseLeave(object sender, EventArgs e)
		{
			this.isMouseOverCanvas = false;
			this.Invalidate();
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.J3J6sEr6u();
			this.contentUpdated = true;
			if (this.axisBottom != null)
				this.axisBottom.SetBounds(this.canvasLeftOffset, this.Width - this.canvasRightOffset, this.Height - this.canvasBottomOffset);
			this.Invalidate();
		}

		private void yHuMeqhH1(int obj0)
		{
			this.xhyOat6AP(Math.Min(this.firstIndex + obj0, this.lastIndex - 1 + 1), this.lastIndex);
			this.Invalidate();
		}

		private void HS5QjNKgD(int obj0)
		{
			if (this.mainSeries == null || this.mainSeries.Count == 0)
				return;
			this.xhyOat6AP(Math.Max(0, this.firstIndex - obj0), this.lastIndex);
			this.Invalidate();
		}

		public void ZoomIn()
		{
			this.yHuMeqhH1((this.lastIndex - this.firstIndex) / 5);
		}

		public void ZoomOut()
		{
			this.HS5QjNKgD((this.lastIndex - this.firstIndex) / 10 + 1);
		}

		public void UnSelectAll()
		{
			foreach (Pad pad in this.pads)
			{
				if (pad.getChartDrawable() != null)
				{
					pad.getChartDrawable().UnSelect();
					pad.setChartDrawable(null);
				}
			}
		}

		public virtual void ShowProperties(DSView view, Pad pad, bool forceShowProperties)
		{
		}
		
		public void AddPad()
		{
			this.Eqy9o6NL3();
			this.pads.Add(new Pad(this, this.canvasLeftOffset, this.Width - this.canvasRightOffset, this.canvasTopOffset, this.Height - this.canvasBottomOffset));
			this.J3J6sEr6u();
			this.contentUpdated = true;
		}

		private void J3J6sEr6u()
		{
			int y1 = this.canvasTopOffset;
			int num1 = this.Height - this.canvasBottomOffset - this.canvasTopOffset;
			int index = 0;
			double num2 = 0.0;
			foreach (Pad pad in this.pads)
			{
				num2 += (double)this.padsHeightArray[index];
				int y2 = (int)(this.canvasTopOffset + num1 * num2);
				pad.SetCanvas(this.canvasLeftOffset, this.Width - this.canvasRightOffset, y1, y2);
				++index;
				y1 = y2;
			}
		}

		private void Eqy9o6NL3()
		{
			if (this.padsHeightArray.Count == 0)
			{
				this.padsHeightArray.Add(1.0);
			}
			else
			{
				this.padsHeightArray.Add(0);
				int count = this.padsHeightArray.Count;
				if (this.volumePadShown)
					--count;
				this.padsHeightArray[0] = (object)(3.0 / (double)(count + 2));
				for (int index = 1; index < this.padsHeightArray.Count; ++index)
				{
					if (this.volumePadShown && index == 1)
					{
						this.padsHeightArray[1] = (object)((double)this.padsHeightArray[0] / 6.0);
						this.padsHeightArray[0] = (object)((double)this.padsHeightArray[1] * 5.0);
					}
					else
						this.padsHeightArray[index] = (object)(1.0 / (double)(count + 2));
				}
			}
		}

		public void ShowVolumePad()
		{
			if (this.volumePadShown || !(this.mainSeries is BarSeries))
				return;
			this.volumePadShown = true;
			this.Eqy9o6NL3();
			Pad pad = new Pad(this, this.canvasLeftOffset, this.Width - this.canvasRightOffset, this.canvasTopOffset, this.Height - this.canvasBottomOffset);
			pad.AxisLabelFormat = "xaxis";
			pad.DrawGrid = false;
			this.volumeView = new VolumeBSView(pad, (DoubleSeries)(this.mainSeries as BarSeries));
			this.volumeView.Color = this.volumeColor;
			pad.AddPrimitive(this.volumeView);
			this.pads.Insert(1, pad);
			this.J3J6sEr6u();
			this.EmitVolumeVisibleChanged();
		}

		public void HideVolumePad()
		{
			if (!this.volumePadShown)
				return;
			this.pads.RemoveAt(1);
			this.volumePadShown = false;
			this.Eqy9o6NL3();
			this.J3J6sEr6u();
			this.EmitVolumeVisibleChanged();
		}

		public int ClientX(DateTime dateTime)
		{
			double num = (double)(this.Width - this.canvasLeftOffset - this.canvasRightOffset) / (double)(this.lastIndex - this.firstIndex + 1);
			return this.canvasLeftOffset + (int)((double)(this.mainSeries.GetIndex(dateTime) - this.firstIndex) * num + num / 2.0);
		}

		public DateTime GetDateTime(int x)
		{
			double num = (double)(this.Width - this.canvasLeftOffset - this.canvasRightOffset) / (double)(this.lastIndex - this.firstIndex + 1);
			return this.mainSeries.GetDateTime((int)Math.Floor((double)(x - this.canvasLeftOffset) / num) + this.firstIndex);
		}

		public void Reset()
		{
			lock (this.dataLock)
			{
				foreach (Pad pad in this.pads)
				{
					pad.Clear();
					foreach (object item_0 in pad.Primitives)
					{
						if (item_0 is IUpdatable)
							(item_0 as IUpdatable).Updated -= new EventHandler(this.Xsr5a43Ll);
					}
				}
				this.pads.Clear();
				this.padsHeightArray.Clear();
				this.volumePadShown = false;
				this.AddPad();
				this.firstIndex = -1;
				this.lastIndex = -1;
				if (this.series != null)
					this.series.ItemAdded -= new ItemAddedEventHandler(this.EevqwoC33);
				this.mainSeries = null;
				this.AAUwMEaLwI = DateTime.MinValue;
				this.contentUpdated = true;
				if (this.updateStyle == ChartUpdateStyle.Fixed)
					this.UpdateStyle = ChartUpdateStyle.Trailing;
				this.BarSeriesStyle = BSStyle.Candle;
			}
		}

		public void SetMainSeries(DoubleSeries mainSeries, bool showVolumePad = false)
		{
			lock (this.dataLock)
			{
				if (this.mainSeries != null)
				{
					this.series.ItemAdded -= new ItemAddedEventHandler(this.EevqwoC33);
					this.series.Cleared -= new EventHandler(this.L8iVpVKax);
				}
				this.series = (TimeSeries)mainSeries;
				if (mainSeries is BarSeries)
				{
					this.vA32MRaPG(this.barSeriesStyle, true);
				}
				else
				{
					this.mainSeries = this.series;
					this.mainSeriesView = (SeriesView)new DSView(this.pads[0], mainSeries, mainSeries.Color, EIndexOption.Null, SmoothingMode.HighSpeed);
					this.pads[0].AddPrimitive((IChartDrawable)this.mainSeriesView);
				}
				this.series.ItemAdded += new ItemAddedEventHandler(this.EevqwoC33);
				this.series.Cleared += new EventHandler(this.L8iVpVKax);
				this.pads[0].ScaleStyle = this.scaleStyle;
				if (showVolumePad)
					this.ShowVolumePad();
				this.firstIndex = this.updateStyle != ChartUpdateStyle.WholeRange ? Math.Max(0, mainSeries.Count - this.minCountOfBars) : 0;
				this.lastIndex = mainSeries.Count - 1;
				if (mainSeries.Count == 0)
					this.firstIndex = -1;
				if (this.lastIndex >= 0)
					this.xhyOat6AP(this.firstIndex, this.lastIndex);
				this.contentUpdated = true;
				this.Invalidate();
			}
		}

		private void xhyOat6AP(int firstIndex, int lastIndex)
		{
			if (this.mainSeries == null || firstIndex < 0 || lastIndex > this.mainSeries.Count - 1)
				return;
			this.firstIndex = firstIndex;
			this.lastIndex = lastIndex;
			this.leftDateTime = firstIndex >= 0 ? this.mainSeries.GetDateTime(this.firstIndex) : DateTime.MaxValue;
			this.rightDateTime = lastIndex < 0 || lastIndex > this.mainSeries.Count - 1 ? DateTime.MinValue : this.mainSeries.GetDateTime(this.lastIndex);
			foreach (Pad pad in this.pads)
				pad.SetInterval(this.leftDateTime, this.rightDateTime);
			this.contentUpdated = true;
		}

		private void SetInterval(DateTime minDate, DateTime maxDate)
		{
			this.xhyOat6AP(this.MainSeries.GetIndex(minDate, EIndexOption.Next), this.MainSeries.GetIndex(maxDate, EIndexOption.Prev));
		}

		private void FSOLY9YLw(object sender, ScrollEventArgs e)
		{
			if (this.hScrollBar.Value == e.NewValue)
				return;
			int num = e.NewValue - this.hScrollBar.Value;
			this.xhyOat6AP(this.firstIndex + num, this.lastIndex + num);
			this.Invalidate();
		}

		private void EevqwoC33(object sender, DateTimeEventArgs e)
		{
			bool flag = false;
			lock (this.dataLock)
			{
				this.contentUpdated = true;
				if (this.firstIndex == -1)
					this.firstIndex = 0;
				switch (this.updateStyle)
				{
					case ChartUpdateStyle.WholeRange:
						this.xhyOat6AP(0, this.mainSeries.Count - 1);
						flag = true;
						break;
					case ChartUpdateStyle.Trailing:
						if (this.lastIndex - this.firstIndex + 1 < this.minCountOfBars)
							this.xhyOat6AP(this.firstIndex, this.lastIndex + 1);
						else
							this.xhyOat6AP(this.firstIndex + 1, this.lastIndex + 1);
						flag = true;
						break;
				}
			}
			if (flag)
				this.Invalidate();
			Application.DoEvents();
		}

		private void L8iVpVKax(object sender, EventArgs e)
		{
			this.firstIndex = -1;
			this.lastIndex = -1;
		}

		private bool vA32MRaPG(BSStyle style, bool obj1)
		{
			bool flag = true;
			if (style == BSStyle.Candle || style == BSStyle.Bar || style == BSStyle.Line)
			{
				if (!(this.mainSeriesView is SimpleBSView) || obj1)
				{
					this.pads[0].RemovePrimitive((IChartDrawable)this.mainSeriesView);
					this.mainSeriesView = (SeriesView)new SimpleBSView(this.pads[0], this.series as BarSeries);
					(this.mainSeriesView as SimpleBSView).UpColor = this.candleUpColor;
					(this.mainSeriesView as SimpleBSView).DownColor = this.candleDownColor;
					this.mainSeries = this.mainSeriesView.MainSeries;
					this.pads[0].AddPrimitive((IChartDrawable)this.mainSeriesView);
				}
				else
					flag = false;
				if (style == BSStyle.Candle)
					(this.mainSeriesView as SimpleBSView).Style = SimpleBSStyle.Candle;
				if (style == BSStyle.Bar)
					(this.mainSeriesView as SimpleBSView).Style = SimpleBSStyle.Bar;
				if (style == BSStyle.Line)
					(this.mainSeriesView as SimpleBSView).Style = SimpleBSStyle.Line;
			}
			else if (style == BSStyle.Kagi)
			{
				if (!(this.mainSeriesView is KagiBaView) || obj1)
				{
					this.pads[0].RemovePrimitive((IChartDrawable)this.mainSeriesView);
					this.mainSeriesView = (SeriesView)new KagiBaView(this.pads[0], this.series as BarSeries);
					this.mainSeries = this.mainSeriesView.MainSeries;
					this.pads[0].AddPrimitive((IChartDrawable)this.mainSeriesView);
				}
			}
			else if (style == BSStyle.LineBreak)
			{
				if (!(this.mainSeriesView is LineBreakBSView) || obj1)
				{
					this.pads[0].RemovePrimitive((IChartDrawable)this.mainSeriesView);
					this.mainSeriesView = (SeriesView)new LineBreakBSView(this.pads[0], this.series as BarSeries);
					this.mainSeries = this.mainSeriesView.MainSeries;
					this.pads[0].AddPrimitive((IChartDrawable)this.mainSeriesView);
				}
			}
			else if (style == BSStyle.Ranko)
			{
				if (!(this.mainSeriesView is RankoBSView) || obj1)
				{
					this.pads[0].RemovePrimitive((IChartDrawable)this.mainSeriesView);
					this.mainSeriesView = (SeriesView)new RankoBSView(this.pads[0], this.series as BarSeries);
					this.mainSeries = this.mainSeriesView.MainSeries;
					this.pads[0].AddPrimitive((IChartDrawable)this.mainSeriesView);
				}
			}
			else if (style == BSStyle.PointAndFigure && (!(this.mainSeriesView is PnFBSView) || obj1))
			{
				this.pads[0].RemovePrimitive((IChartDrawable)this.mainSeriesView);
				this.mainSeriesView = (SeriesView)this.AaUga350I(this.pads[0], this.series as BarSeries);
				this.mainSeries = this.mainSeriesView.MainSeries;
				this.pads[0].AddPrimitive((IChartDrawable)this.mainSeriesView);
			}
			return flag;
		}

		
		private PnFBSView AaUga350I(Pad pad, BarSeries series)
		{
			return new PnFBSView(pad, series, 1.0, 3);
		}

		
		private void EmitUpdateStyleChanged()
		{
			if (this.UpdateStyleChanged != null)
				this.UpdateStyleChanged(this, EventArgs.Empty);
		}

		
		private void EmitVolumeVisibleChanged()
		{
			if (this.VolumeVisibleChanged != null) 
				this.VolumeVisibleChanged(this, EventArgs.Empty);
		}

		private void EmitBarSeriesStyleChanged()
		{
			if (this.BarSeriesStyleChanged != null)
				this.BarSeriesStyleChanged(this, EventArgs.Empty);
		}

		private void EmitActionTypeChanged()
		{
			if (this.ActionTypeChanged != null)
				this.ActionTypeChanged(this, EventArgs.Empty);
		}

		private void EmitScaleStyleChanged()
		{
			if (this.ScaleStyleChanged != null)
				this.ScaleStyleChanged(this, EventArgs.Empty);
		}

		public void EnsureVisible(Transaction transaction)
		{
			if (transaction.DateTime < this.mainSeries.FirstDateTime)
				return;
			int num1 = Math.Max(this.mainSeries.GetIndex(transaction.DateTime, EIndexOption.Prev), 0);
			int val2 = this.lastIndex - this.firstIndex + 1;
			int num2 = Math.Max(Math.Min(this.mainSeries.Count - 1, num1 + val2 / 5), val2);
			this.xhyOat6AP(num2 - val2 + 1, num2);
			this.pads[0].SetSelectedObject(transaction);
			this.AAUwMEaLwI = this.mainSeries.GetDateTime(this.mainSeries.GetIndex(transaction.DateTime, EIndexOption.Prev));
			this.contentUpdated = true;
			this.Invalidate();
		}

		public int GetPadNumber(Point point)
		{
			int y = point.Y;
			for (int i = 0; i < this.pads.Count; ++i)
			{
				if (this.pads[i].Y1 <= y && y <= this.pads[i].Y2)
					return i;
			}
			return -1;
		}

		private delegate void I9hOMiynBlKXwGeySC(int firstIndex, int lastIndex);
	}
}
