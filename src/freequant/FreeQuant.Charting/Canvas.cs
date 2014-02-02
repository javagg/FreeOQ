using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FreeQuant.Charting
{
	[Serializable]
	public class Canvas : Form
	{
		private HelpProvider helpProvider;
		private Chart chart;
		private Container container;

		public Pad Pad
		{
			get
			{
				return Chart.Pad;
			}
		}

		public string Title
		{
			get
			{
				return this.Text;
			}
			set
			{
				this.Text = value;
			}
		}

		public static bool FileEnabled { get; set; }

		public static string FileDir { get; set; }

		public static string FileNamePrefix { get; set; }

		public static string FileNameSuffix { get; set; }

		public bool GroupZoomEnabled
		{
			get
			{
				return this.chart.GroupZoomEnabled;
			}
			set
			{
				this.chart.GroupZoomEnabled = value;
			}
		}

		public bool GroupLeftMarginEnabled
		{
			get
			{
				return this.chart.GroupLeftMarginEnabled;
			}
			set
			{
				this.chart.GroupLeftMarginEnabled = value;
			}
		}

		public bool DoubleBufferingEnabled
		{
			get
			{
				return this.chart.DoubleBufferingEnabled;
			}
			set
			{
				this.chart.DoubleBufferingEnabled = value;
			}
		}

		public bool SmoothingEnabled
		{
			get
			{
				return this.chart.SmoothingEnabled;
			}
			set
			{
				this.chart.SmoothingEnabled = value;
			}
		}

		public bool AntiAliasingEnabled
		{
			get
			{
				return this.chart.AntiAliasingEnabled;
			}
			set
			{
				this.chart.AntiAliasingEnabled = value;
			}
		}

		public PrintDocument PrintDocument
		{
			get
			{
				return this.chart.PrintDocument;
			}
			set
			{
				this.chart.PrintDocument = value;
			}
		}

		public int PrintX
		{
			get
			{
				return this.chart.PrintX;
			}
			set
			{
				this.chart.PrintX = value;
			}
		}

		public int PrintY
		{
			get
			{
				return this.chart.PrintY;
			}
			set
			{
				this.chart.PrintY = value;
			}
		}

		public int PrintWidth
		{
			get
			{
				return this.chart.PrintWidth;
			}
			set
			{
				this.chart.PrintWidth = value;
			}
		}

		public int PrintHeight
		{
			get
			{
				return this.chart.PrintHeight;
			}
			set
			{
				this.chart.PrintHeight = value;
			}
		}

		public EPrintAlign PrintAlign
		{
			get
			{
				return this.chart.PrintAlign;
			}
			set
			{
				this.chart.PrintAlign = value;
			}
		}

		public EPrintLayout PrintLayout
		{
			get
			{
				return this.chart.PrintLayout;
			}
			set
			{
				this.chart.PrintLayout = value;
			}
		}

		public Chart Chart
		{
			get
			{
				return this.chart; 
			}
		}

		static Canvas()
		{
			Canvas.FileDir = String.Empty;
			Canvas.FileNamePrefix = String.Empty;
			Canvas.FileNameSuffix = String.Empty;
			Canvas.FileEnabled = false;
		}

		public Canvas(string name, string title) : this(name, title, null)
		{
		}

		public Canvas(string name) : this(name, name, null)
		{
		}

		public Canvas(string name, string title, string fileName) : base()
		{
			this.InitializeComponent();
			this.Name = name;
			this.Text = title;
			if (Canvas.FileEnabled)
			{
				this.chart.FileName = Canvas.FileDir + "dd" + Canvas.FileNamePrefix + this.Name + DateTime.Now.ToString("D") + Canvas.FileNameSuffix + "dd";
			}
			this.chart.FileName = fileName;
			CanvasManager.Add(this);
			if (!Canvas.FileEnabled)
			{
				this.Show();
			}
		}

		public Canvas(string name, string title, int width, int height) : this(name, title, null, width, height)
		{
		}

		public Canvas(string name, int width, int height) : this(name, name, null, width, height)
		{
		}

		public Canvas(string name, string title, string fileName, int width, int height) : base()
		{
			this.InitializeComponent();
			this.Name = name;
			this.Text = title;
			if (Canvas.FileEnabled)
			{
				this.chart.FileName = Canvas.FileDir + Canvas.FileNamePrefix + this.Name + DateTime.Now.ToString("D") + Canvas.FileNameSuffix;
			}
			if (fileName != null) 
			{
				this.chart.FileName = fileName;
			}
			CanvasManager.Add(this);
			this.Width = width;
			this.Height = height;
			if (!Canvas.FileEnabled)
			{
				this.Show();
			}
		}

		public Pad cd(int pad)
		{
			return this.chart.cd(pad);
		}

		public void Clear()
		{
			this.chart.Clear();
		}

		public void UpdateChart()
		{
			this.chart.UpdatePads();
		}

		new public void Update()
		{
			base.Update();
			this.UpdateChart();
		}

		public Pad AddPad(double x1, double y1, double x2, double y2)
		{
			return this.chart.AddPad(x1, y1, x2, y2);
		}

		public void Divide(int x, int y)
		{
			this.chart.Divide(x, y);
		}

		public void Divide(int x, int y, double[] widths, double[] heights)
		{
			this.chart.Divide(x, y, widths, heights);
		}

		protected override void Dispose(bool disposing)
		{
			CanvasManager.Remove(this);
			if (disposing && this.container != null)
				this.container.Dispose();
			base.Dispose(disposing);
		}

		public virtual void Print()
		{
			this.chart.Print();
		}

		public virtual void PrintPreview()
		{
			this.chart.PrintPreview();
		}

		public virtual void PrintSetup()
		{
			this.chart.PrintSetup();
		}

		public virtual void PrintPageSetup()
		{
			this.chart.PrintPageSetup();
		}

		private void InitializeComponent()
		{
			this.helpProvider = new HelpProvider();
			this.chart = new Chart();
			this.SuspendLayout();
			this.chart.AntiAliasingEnabled = false;
			this.chart.Dock = DockStyle.Fill;
			this.chart.DoubleBufferingEnabled = true;
			this.chart.FileName = null;
			this.chart.GroupLeftMarginEnabled = false;
			this.chart.GroupZoomEnabled = false;
			this.chart.ImeMode = ImeMode.Off;
			this.chart.Location = new Point(0, 0);
			this.chart.Name = "ChartName";
			this.chart.PrintAlign = EPrintAlign.None;
			this.chart.PrintHeight = 400;
			this.chart.PrintLayout = EPrintLayout.Portrait;
			this.chart.PrintWidth = 600;
			this.chart.PrintX = 10;
			this.chart.PrintY = 10;
			this.chart.Size = new Size(488, 293);
			this.chart.SmoothingEnabled = false;
			this.chart.TabIndex = 0;
			this.AutoScaleBaseSize = new Size(5, 13);
			this.ClientSize = new Size(488, 293);
			this.Controls.Add(this.chart);
			this.ResumeLayout(false);
		}
	}
}
