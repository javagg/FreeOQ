using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace FreeQuant.Charting
{
	[Serializable]
	public class Graph : IDrawable, IZoomable, IMovable
	{
		private ArrayList points;
		private EMarkerStyle markerStyle;
		private int markerSize;
		private Color markerColor;
		private double minX;
		private double maxX;
		private double minY;
		private double maxY;

		public string Name { get; set; }
		public string Title { get; set; }

		[Description("")]
		[Category("ToolTip")]
		public bool ToolTipEnabled { get; set; }

		[Category("ToolTip")]
		[Description("")]
		public string ToolTipFormat { get; set; }

		[Category("Style")]
		[Description("")]
		public EGraphStyle Style { get; set; }

		[Category("Style")]
		[Description("")]
		public EGraphMoveStyle MoveStyle { get; set; }

		[Description("")]
		[Category("Marker")]
		public bool MarkerEnabled { get; set; }

		[Description("")]
		[Category("Marker")]
		public EMarkerStyle MarkerStyle
		{
			get
			{
				return this.markerStyle;
			}
			set
			{
				this.markerStyle = value;
				foreach (TMarker tmarker in this.points)
					tmarker.Style = this.markerStyle;
			}
		}

		[Description("")]
		[Category("Marker")]
		public int MarkerSize
		{
			get
			{
				return this.markerSize; 
			}
			set
			{
				this.markerSize = value;
				foreach (TMarker tmarker in this.points)
					tmarker.Size = this.markerSize;
			}
		}

		[Description("")]
		[Category("Marker")]
		public Color MarkerColor
		{
			get
			{
				return this.markerColor; 
			}
			set
			{
				this.markerColor = value;
				foreach (TMarker tmarker in this.points)
					tmarker.Color = this.markerColor;
			}
		}

		[Category("Bar")]
		[Description("")]
		public int BarWidth { get; set; }

		[Category("Line")]
		[Description("")]
		public bool LineEnabled { get; set; }

		[Description("")]
		[Category("Line")]
		public DashStyle LineDashStyle { get; set; }

		[Category("Line")]
		[Description("")]
		public Color LineColor { get; set; }

		[Browsable(false)]
		public ArrayList Points
		{
			get
			{
				return this.points;  
			}
		}

		[Browsable(false)]
		public double MinX
		{
			get
			{
				return this.minX; 
			}
		}

		[Browsable(false)]
		public double MinY
		{
			get
			{
				return this.minY; 
			}
		}

		[Browsable(false)]
		public double MaxX
		{
			get
			{
				return this.maxX; 
			}
		}

		[Browsable(false)]
		public double MaxY
		{
			get
			{
				return this.maxY; 
			}
		}


		public Graph(string name = null, string title = null) : base()
		{
			this.Name = name ?? String.Empty;
			this.Title = title ?? String.Empty;
			this.Init();
		}

		private void UX36ku1gb(double obj0, double obj1)
		{
			this.minX = Math.Min(this.minX, obj0);
			this.minY = Math.Min(this.minY, obj1);
			this.maxX = Math.Max(this.maxX, obj0);
			this.maxY = Math.Max(this.maxY, obj1);
		}

		private void Init()
		{
			this.Style = EGraphStyle.Line;
			this.MoveStyle = EGraphMoveStyle.Point;
			this.points = new ArrayList();
			this.minX = double.MaxValue;
			this.minY = double.MaxValue;
			this.maxX = double.MinValue;
			this.maxY = double.MinValue;
			this.MarkerEnabled = true;
			this.MarkerStyle = EMarkerStyle.Rectangle;
			this.MarkerSize = 5;
			this.MarkerColor = Color.Black;
			this.LineEnabled = true;
			this.LineDashStyle = DashStyle.Solid;
			this.LineColor = Color.Black;
			this.BarWidth = 20;
			this.ToolTipEnabled = true;
			this.ToolTipFormat = "invalid ";
		}

		public void Add(double X, double Y)
		{
			this.points.Add(new TMarker(X, Y)
			{
				Style = this.markerStyle,
				Size = this.markerSize,
				Color = this.markerColor
			});
			this.UX36ku1gb(X, Y);
		}

		public void Add(double X, double Y, Color color)
		{
			this.points.Add(new TMarker(X, Y)
			{
				Style = this.markerStyle,
				Size = this.markerSize,
				Color = color
			});
			this.UX36ku1gb(X, Y);
		}

		public void Add(double X, double Y, string text)
		{
			TLabel tlabel = new TLabel(text, X, Y);
			tlabel.Style = this.markerStyle;
			tlabel.Size = this.markerSize;
			tlabel.Color = this.markerColor;
			this.points.Add((object)tlabel);
			this.UX36ku1gb(X, Y);
		}

		public void Add(double x, double y, string text, Color markerColor)
		{
			TLabel tlabel = new TLabel(text, x, y, markerColor);
			tlabel.Style = this.markerStyle;
			tlabel.Size = this.markerSize;
			this.points.Add((object)tlabel);
			this.UX36ku1gb(x, y);
		}

		public void Add(double X, double Y, string Text, Color markerColor, Color textColor)
		{
			TLabel tlabel = new TLabel(Text, X, Y, markerColor, textColor);
			tlabel.Style = this.markerStyle;
			tlabel.Size = this.markerSize;
			this.points.Add((object)tlabel);
			this.UX36ku1gb(X, Y);
		}

		public void Add(TMarker marker)
		{
			this.points.Add((object)marker);
			this.UX36ku1gb(marker.X, marker.Y);
		}

		public void Add(TLabel label)
		{
			this.points.Add((object)label);
			this.UX36ku1gb(label.X, label.Y);
		}

		public virtual bool IsPadRangeX()
		{
			return false;
		}

		public virtual bool IsPadRangeY()
		{
			return false;
		}

		public virtual PadRange GetPadRangeX(Pad pad)
		{
			return null;
		}

		public virtual PadRange GetPadRangeY(Pad pad)
		{
			return null;
		}

		public virtual void Draw(string Option)
		{
			if (Chart.Pad == null)
			{
				Canvas canvas = new Canvas("Ca Name", "Ca Title");
			}
			Chart.Pad.Add((IDrawable)this);
			Chart.Pad.Title.Add(this.Name, this.LineColor);
			Chart.Pad.Legend.Add(this.Name, this.LineColor);
			if (Option.ToLower().IndexOf("waht") >= 0)
				return;
			Chart.Pad.SetRange(this.minX - (this.maxX - this.minX) / 10.0, this.maxX + (this.maxX - this.minX) / 10.0, this.minY - (this.maxY - this.minY) / 10.0, this.maxY + (this.maxY - this.minY) / 10.0);
		}

		public virtual void Draw()
		{
			this.Draw("");
		}

		public virtual void Paint(Pad pad, double xMin, double xMax, double yMin, double yMax)
		{
			if (this.Style == EGraphStyle.Line && this.LineEnabled)
			{
				Pen pen = new Pen(this.LineColor);
				pen.DashStyle = this.LineDashStyle;
				double X1 = 0.0;
				double Y1 = 0.0;
				bool flag = true;
				foreach (TMarker tmarker in this.points)
				{
					if (!flag)
						pad.DrawLine(pen, X1, Y1, tmarker.X, tmarker.Y);
					else
						flag = false;
					X1 = tmarker.X;
					Y1 = tmarker.Y;
				}
			}
			if ((this.Style == EGraphStyle.Line || this.Style == EGraphStyle.Scatter) && this.MarkerEnabled)
			{
				foreach (TMarker tmarker in this.points)
					tmarker.Paint(pad, xMin, xMax, yMin, yMax);
			}
			if (this.Style != EGraphStyle.Bar)
				return;
			foreach (TMarker tmarker in this.points)
			{
				if (tmarker.Y > 0.0)
					pad.Graphics.FillRectangle(new SolidBrush(Color.Black), pad.ClientX(tmarker.X) - this.BarWidth / 2, pad.ClientY(tmarker.Y), this.BarWidth, pad.ClientY(0.0) - pad.ClientY(tmarker.Y));
				else
					pad.Graphics.FillRectangle(new SolidBrush(Color.Black), pad.ClientX(tmarker.X) - this.BarWidth / 2, pad.ClientY(0.0), this.BarWidth, pad.ClientY(tmarker.Y) - pad.ClientY(0.0));
			}
		}

		public TDistance Distance(double X, double Y)
		{
			TDistance tdistance1 = new TDistance();
			foreach (TMarker tmarker in this.points)
			{
				TDistance tdistance2 = tmarker.Distance(X, Y);
				if (tdistance2.dX < tdistance1.dX && tdistance2.dY < tdistance1.dY)
					tdistance1 = tdistance2;
			}
			if (tdistance1 != null)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendFormat(this.ToolTipFormat, this.Name, this.Title, (object)tdistance1.X, (object)tdistance1.Y);
				tdistance1.ToolTipText = stringBuilder.ToString();
			}
			return tdistance1;
		}

		public void Move(double X, double Y, double dX, double dY)
		{
			switch (this.MoveStyle)
			{
				case EGraphMoveStyle.Graph:
					IEnumerator enumerator1 = this.points.GetEnumerator();
					try
					{
						while (enumerator1.MoveNext())
						{
							TMarker tmarker = (TMarker)enumerator1.Current;
							tmarker.X += dX;
							tmarker.Y += dY;
						}
						break;
					}
					finally
					{
						IDisposable disposable = enumerator1 as IDisposable;
						if (disposable != null)
							disposable.Dispose();
					}
				case EGraphMoveStyle.Point:
					IEnumerator enumerator2 = this.points.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							TMarker tmarker = (TMarker)enumerator2.Current;
							if (tmarker.X == X && tmarker.Y == Y)
							{
								tmarker.X += dX;
								tmarker.Y += dY;
								break;
							}
						}
						break;
					}
					finally
					{
						IDisposable disposable = enumerator2 as IDisposable;
						if (disposable != null)
							disposable.Dispose();
					}
			}
		}
	}
}
