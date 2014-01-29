using FreeQuant.Series;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace FreeQuant.FinChart
{
	public class Pad
	{
		private Chart chart;
		private AxisRight axis;
		private ArrayList primitives;
		private ArrayList notDatePrimitives;
		private SortedRangeList datePrimitives;
		private SortedRangeList F3nJMka9IZ;
		private SortedRangeList xFrJQlHpbJ;
		private bool drawGrid;
		private int axisGap;
		private object selectedObject;
		private int x1;
		private int x2;
		private int y1;
		private int y2;
		private int width;
		private int height;
		private int leftPadding;
		private int rightPadding;
		private double maxValue;
		private double minValue;
		private Graphics graphics;
		private IChartDrawable chartDrawable;
		private bool rGBJ83tF8c;
		private bool UYFJBKF5fG;
		private Rectangle rect;
		private PadScaleStyle scaleStyle;
		private string axisLabelFormat;
		private bool drawItems;

		public AxisRight Axis
		{
			get
			{
				return this.axis; 
			}
		}

		internal Chart Chart
		{
			get
			{
				return this.chart;
			}
		}

		public bool DrawItems
		{
			get
			{
				return this.drawItems; 
			}
			set
			{
				this.drawItems = value;
			}
		}

		public string AxisLabelFormat
		{
			get
			{
				if (this.axisLabelFormat == null)
					return "" + this.chart.LabelDigitsCount.ToString();
				else
					return this.axisLabelFormat;
			}
			set
			{
				this.axisLabelFormat = value; 
			}
		}

		public bool DrawGrid
		{
			get
			{
				return this.drawGrid; 
			}
			set
			{
				this.drawGrid = value;
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
			}
		}

		public int X1
		{
			get
			{
				return this.x1; 
			}
		}

		public int X2
		{
			get
			{
				return this.x2; 
			}
		}

		public int Y1
		{
			get
			{
				return this.y1; 
			}
		}

		public int Y2
		{
			get
			{
				return this.y2; 
			}
		}

		public double MaxValue
		{
			get
			{
				return this.maxValue; 
			}
		}

		public double MinValue
		{
			get
			{
				return this.minValue; 
			}
		}

		public TimeSeries Series
		{
			get
			{
				return this.chart.OkdNNmbiw();
			}
		}

		public TimeSeries MainSeries
		{
			get
			{
				return this.chart.MainSeries;
			}
		}

		public double IntervalWidth
		{
			get
			{
				return this.chart.IntervalWidth;
			}
		}

		public int FirstIndex
		{
			get
			{
				return this.chart.FirstIndex;
			}
		}

		public int LastIndex
		{
			get
			{
				return this.chart.LastIndex;
			}
		}

		public Graphics Graphics
		{
			get
			{
				return this.graphics; 
			}
		}

		public ArrayList Primitives
		{
			get
			{
				return this.primitives;
			}
		}

		public Pad(Chart chart, int x1, int x2, int y1, int y2)
		{
			this.drawGrid = true;
			this.chart = chart;
			this.SetCanvas(x1, x2, y1, y2);
			this.primitives = ArrayList.Synchronized(new ArrayList());
			this.notDatePrimitives = new ArrayList();
			this.datePrimitives = new SortedRangeList();
			this.F3nJMka9IZ = new SortedRangeList();
			this.xFrJQlHpbJ = new SortedRangeList(true);
		}

		internal int getAxisGap()
		{
			return this.axisGap;
		}

		internal IChartDrawable getChartDrawable()
		{
			return this.chartDrawable;
		}

		internal void setChartDrawable(IChartDrawable value)
		{
			this.chartDrawable = value;
		}

		internal int getWidth()
		{
			return this.width;
		}

		internal void setWidth(int value)
		{
			this.width = value;
			this.x2 = this.x1 + this.width;
			this.axis.SetBounds(this.x2, this.y1, this.y2);
		}

		public void SetCanvas(int x1, int x2, int y1, int y2)
		{
			this.y1 = y1;
			this.y2 = y2;
			this.x1 = x1 + this.leftPadding;
			this.x2 = x2 - this.rightPadding;
			this.width = this.x2 - this.x1;
			this.height = this.y2 - this.y1;
			if (this.axis == null)
				this.axis = new AxisRight(this.chart, this, x2, y1, y2);
			else
				this.axis.SetBounds(x2, y1, y2);
		}

		public void AddPrimitive(IChartDrawable primitive)
		{
			this.primitives.Add(primitive);
			if (primitive is IDateDrawable)
				this.datePrimitives.Add(primitive as IDateDrawable);
			else
				this.notDatePrimitives.Add(primitive); 
		}

		public void RemovePrimitive(IChartDrawable primitive)
		{
			this.primitives.Remove(primitive);
			if (primitive is IDateDrawable)
				this.datePrimitives[(primitive as IDateDrawable).DateTime].Remove(primitive);
			else
				this.notDatePrimitives.Remove(primitive);
		}

		public void ClearPrimitives()
		{
			this.primitives.Clear();
			this.datePrimitives.Clear();
			this.notDatePrimitives.Clear();
		}

		public void SetSelectedObject(object obj)
		{
			this.selectedObject = obj;
		}

		internal void Clear()
		{
			this.ClearPrimitives();
		}

		public int ClientX(DateTime dateTime)
		{
			double num = (double)this.width / (double)(this.LastIndex - this.FirstIndex + 1);
			return this.x1 + (int)((double)(this.MainSeries.GetIndex(dateTime) - this.FirstIndex) * num + num / 2.0);
		}

		public int ClientY(double worldY)
		{
			if (this.scaleStyle == PadScaleStyle.Log)
				return this.y1 + (int)((1.0 - (Math.Log10(worldY) - Math.Log10(this.minValue)) / (Math.Log10(this.maxValue) - Math.Log10(this.minValue))) * this.height);
			else
				return this.y1 + (int)((1.0 - (worldY - this.minValue) / (this.maxValue - this.minValue)) * this.height);
		}

		public void SetInterval(DateTime minDate, DateTime maxDate)
		{
			foreach (IChartDrawable chartDrawable in this.primitives)
				chartDrawable.SetInterval(minDate, maxDate);
		}

		public void DrawHorizontalGrid(Pen pen, double y)
		{
			if (!this.drawGrid)
				return;
			this.graphics.DrawLine(pen, this.x1, this.ClientY(y), this.x2, this.ClientY(y));
		}

		public void DrawHorizontalTick(Pen pen, double x, double y, int length)
		{
			this.graphics.DrawLine(pen, (int)x, this.ClientY(y), (int)x + length, this.ClientY(y));
		}

		internal void q1WJ72NWjL()
		{
			this.axisGap = -1;
			if (this.chart.MainSeries == null || this.chart.MainSeries.Count == 0)
				return;
			this.maxValue = double.MinValue;
			this.minValue = double.MaxValue;
			ArrayList arrayList;
			lock (this.primitives.SyncRoot)
				arrayList = new ArrayList(this.primitives);
			foreach (IChartDrawable chartDrawable in arrayList)
			{
				if ((this.drawItems || chartDrawable is SeriesView) && chartDrawable is IZoomable)
				{
					PadRange padRangeY = (chartDrawable as IZoomable).GetPadRangeY(this);
					if (padRangeY.IsValid)
					{
						if (this.maxValue < padRangeY.Max)
							this.maxValue = padRangeY.Max;
						if (this.minValue > padRangeY.Min)
							this.minValue = padRangeY.Min;
					}
				}
			}
			if (this.minValue != double.MaxValue && this.maxValue != double.MinValue)
			{
				this.minValue -= (this.maxValue - this.minValue) / 10.0;
				this.maxValue += (this.maxValue - this.minValue) / 10.0;
				this.axisGap = this.axis.GetAxisGap();
			}
			else
				this.axisGap = -1;
		}

		internal void WxfJR1jrge(Graphics obj0)
		{
			if (this.chart.MainSeries == null || this.chart.MainSeries.Count == 0)
				return;
			this.graphics = obj0;
			if (this.minValue != double.MaxValue && this.maxValue != double.MinValue)
			{
				this.axis.Paint();
				obj0.SetClip(new Rectangle(this.x1, this.y1, this.width, this.height));
				foreach (IChartDrawable chartDrawable in this.notDatePrimitives)
				{
					if (this.drawItems || chartDrawable is SeriesView)
						chartDrawable.Paint();
				}
				if (this.drawItems)
				{
					int nextIndex = this.datePrimitives.GetNextIndex(this.chart.MainSeries.GetDateTime(this.chart.FirstIndex));
					int prevIndex = this.datePrimitives.GetPrevIndex(this.chart.MainSeries.GetDateTime(this.chart.LastIndex));
					if (nextIndex != -1 && prevIndex != -1)
					{
						for (int index = nextIndex; index <= prevIndex; ++index)
						{
							foreach (IChartDrawable chartDrawable in this.datePrimitives[index])
							{
								if (this.selectedObject != null && chartDrawable is TransactionView && (chartDrawable as TransactionView).Compare(this.selectedObject))
								{
									(chartDrawable as TransactionView).GBIw6qlqgC(true);
									chartDrawable.Paint();
									(chartDrawable as TransactionView).GBIw6qlqgC(false);
								}
								else
									chartDrawable.Paint();
							}
						}
					}
				}
				obj0.ResetClip();
			}
			bool flag = true;
			float num = (float)(this.x1 + 2);
			foreach (IChartDrawable chartDrawable in this.notDatePrimitives)
			{
				if (chartDrawable is SeriesView)
				{
					SeriesView seriesView = chartDrawable as SeriesView;
					if (seriesView.DisplayNameEnabled)
					{
						string str;
						if (flag)
						{
							str = seriesView.DisplayName;
							flag = false;
						}
						else
							str = "" + seriesView.DisplayName;
						SizeF sizeF = obj0.MeasureString(str, this.chart.Font);
						obj0.FillRectangle((Brush)new SolidBrush(this.chart.CanvasColor), num + 2f, (float)(this.y1 + 2), sizeF.Width, sizeF.Height);
						obj0.DrawString(str, this.chart.Font, (Brush)new SolidBrush(seriesView.Color), num + 2f, (float)(this.y1 + 2));
						num += sizeF.Width;
					}
				}
			}
			if (!this.UYFJBKF5fG)
				return;
			obj0.DrawRectangle(new Pen(Color.Green), this.rect);
		}

		public DateTime GetDateTime(int x)
		{
			return this.chart.GetDateTime(x);
		}

		public double WorldY(int y)
		{
			if (this.scaleStyle == PadScaleStyle.Log)
				return Math.Pow(10.0, (double)(this.y2 - y) / (double)(this.y2 - this.y1) * (Math.Log10(this.maxValue) - Math.Log10(this.minValue))) * this.minValue;
			else
				return this.minValue + (this.maxValue - this.minValue) * (double)(this.y2 - y) / (double)(this.y2 - this.y1);
		}

		public virtual void MouseDown(MouseEventArgs e)
		{
			if (this.chart.MainSeries == null || this.chart.MainSeries.Count == 0 || (e.X <= this.x1 || e.X >= this.x2))
				return;
			double num1 = 10.0;
			double num2 = (this.maxValue - this.minValue) / 20.0;
			int x = e.X;
			double y = this.WorldY(e.Y);
			foreach (IChartDrawable chartDrawable in this.notDatePrimitives)
			{
				if (chartDrawable is DSView)
				{
					Distance distance = chartDrawable.Distance(x, y);
					if (distance != null)
					{
						this.chart.UnSelectAll();
						if (distance.DX < num1 && distance.DY < num2)
						{
							chartDrawable.Select();
							this.chart.SetContentUpdated(true);
							this.chart.Invalidate();
							this.chart.ShowProperties(chartDrawable as DSView, this, false);
							this.chartDrawable = chartDrawable;
							if (!this.chart.ContextMenuEnabled || e.Button != MouseButtons.Right)
								break;
							this.getContextMenuStrip(chartDrawable).Show((Control)this.chart, new Point(e.X, e.Y));
							break;
						}
					}
				}
			}
		}

		public virtual void MouseUp(MouseEventArgs Event)
		{
			this.chart.SetContentUpdated(true);
			this.chart.Invalidate();
		}

		public virtual void MouseMove(MouseEventArgs Event)
		{
			if (this.chart.MainSeries == null || this.chart.MainSeries.Count == 0 || (Event.X <= this.x1 || Event.X >= this.x2))
				return;
			double num1 = 10.0;
			double num2 = (this.maxValue - this.minValue) / 20.0;
			int x = Event.X;
			double y = this.WorldY(Event.Y);
			bool flag = false;
			string caption = "";
			this.rGBJ83tF8c = false;
			foreach (IChartDrawable chartDrawable in this.notDatePrimitives)
			{
				if (this.drawItems || chartDrawable is SeriesView)
				{
					Distance distance = chartDrawable.Distance(x, y);
					if (distance != null && distance.DX < num1 && distance.DY < num2)
					{
						if (chartDrawable.ToolTipEnabled)
						{
							if (caption != "")
								caption = caption + ";";
							caption = caption + distance.ToolTipText;
							flag = true;
						}
						this.rGBJ83tF8c = true;
						if (Cursor.Current != Cursors.Hand)
							Cursor.Current = Cursors.Hand;
					}
				}
			}
			if (this.drawItems)
			{
				int num3 = 0;
				int index1 = this.chart.MainSeries.GetIndex(this.GetDateTime(Event.X));
				DateTime dateTime1 = this.chart.MainSeries.GetDateTime(index1);
				if (index1 != 0)
				{
					DateTime dateTime2 = this.chart.MainSeries.GetDateTime(index1 - 1);
					num3 = this.datePrimitives.GetNextIndex(dateTime2);
					if (this.datePrimitives.Contains(dateTime2))
						++num3;
				}
				int prevIndex = this.datePrimitives.GetPrevIndex(dateTime1);
				if (num3 != -1 && prevIndex != -1)
				{
					for (int index2 = num3; index2 <= prevIndex; ++index2)
					{
						foreach (IChartDrawable chartDrawable in this.datePrimitives[index2])
						{
							Distance distance = chartDrawable.Distance(x, y);
							if (distance != null && distance.DX < num1 && distance.DY < num2)
							{
								if (chartDrawable.ToolTipEnabled)
								{
									if (caption != "")
										caption = caption + "";
									caption = caption + distance.ToolTipText;
									flag = true;
								}
								this.rGBJ83tF8c = true;
								if (Cursor.Current != Cursors.Hand)
									Cursor.Current = Cursors.Hand;
							}
						}
					}
				}
			}
			if (flag)
			{
				this.chart.toolTip.SetToolTip((Control)this.chart, caption);
				this.chart.toolTip.Active = true;
			}
			else
				this.chart.toolTip.Active = false;
		}

		private ContextMenuStrip getContextMenuStrip(IChartDrawable chartDrawable)
		{
			ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
			ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem();
			ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
			ToolStripSeparator toolStripSeparator = new ToolStripSeparator();
			toolStripMenuItem1.Text = (chartDrawable as DSView).DisplayName;
			toolStripMenuItem1.Click += new EventHandler(this.Tw6JTbZTIn);
			toolStripMenuItem1.Image = this.chart.PrimitiveDeleteImage;
			toolStripMenuItem2.Text = (chartDrawable as DSView).DisplayName;
			toolStripMenuItem2.Click += new EventHandler(this.TyLJPdb2Ng);
			toolStripMenuItem2.Image = this.chart.PrimitivePropertiesImage;
			contextMenuStrip.Items.Add((ToolStripItem)toolStripMenuItem1);
			contextMenuStrip.Items.Add((ToolStripItem)toolStripSeparator);
			contextMenuStrip.Items.Add((ToolStripItem)toolStripMenuItem2);
			return contextMenuStrip;
		}

		private void TyLJPdb2Ng(object sender, EventArgs e)
		{
			this.chart.ShowProperties(this.chartDrawable as DSView, this, true);
		}

		private void Tw6JTbZTIn(object sender, EventArgs e)
		{
			this.primitives.Remove(this.chartDrawable);
			this.notDatePrimitives.Remove(this.chartDrawable);
			this.chart.SetContentUpdated(true);
			this.chart.Invalidate();
		}

		public bool IsInRange(double x, double y)
		{
			return this.x1 <= x && x <= this.x2 && this.y1 <= y && y <= this.y2;
		}
	}
}
