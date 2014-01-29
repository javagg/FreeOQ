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

		public Canvas(string Name = "CanvasName", string Title = "CanvasText") : base()
		{
			this.CNA6nGRr44();
			this.Name = Name;
			this.Text = Title;
			this.Wnm6oPv8qu();
			CanvasManager.Add(this);
			if (Canvas.FileEnabled)
				return;
			this.Show();
		}

		public Canvas(string name) : base()
		{

			this.CNA6nGRr44();
			this.Name = name;
			this.Text = name;
			this.Wnm6oPv8qu();
			CanvasManager.Add(this);
			if (Canvas.FileEnabled)
				return;
			((Control)this).Show();
		}

		public Canvas(string name, string title, string fileName) : base()
		{

			this.CNA6nGRr44();
			this.Name = name;
			this.Text = title;
			this.Wnm6oPv8qu();
			this.chart.FileName = fileName;
			CanvasManager.Add(this);
		}

		public Canvas(string name, string title, int width, int height) : base()
		{
			this.CNA6nGRr44();
			this.Name = name;
			this.Text = title;
			this.Wnm6oPv8qu();
			CanvasManager.Add(this);
			this.Width = width;
			this.Height = height;
			if (Canvas.FileEnabled)
				return;
			((Control)this).Show();
		}

		public Canvas(string Name, int Width, int Height) : base()
		{
			this.CNA6nGRr44();
			this.Name = Name;
			this.Text = Name;
			this.Wnm6oPv8qu();
			CanvasManager.Add(this);
			this.Width = Width;
			this.Height = Height;
			if (Canvas.FileEnabled)
				return;
			this.Show();
		}

		public Canvas(string Name, string Title, string FileName, int Width, int Height) : base()
		{
			this.CNA6nGRr44();
			this.Name = Name;
			this.Text = Title;
			this.Wnm6oPv8qu();
			this.chart.FileName = FileName;
			CanvasManager.Add(this);
			this.Width = Width;
			this.Height = Height;
		}

		private void CNA6nGRr44()
		{
			this.drh63ZfGFV();
		}

		private void Wnm6oPv8qu()
		{
			if (!Canvas.FileEnabled)
				return;
			this.chart.FileName = Canvas.FileDir + "dd" + Canvas.FileNamePrefix + this.Name + DateTime.Now.ToString("D") + Canvas.FileNameSuffix + "dd";
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

		private void drh63ZfGFV()
		{
			this.helpProvider = new HelpProvider();
			this.chart = new Chart();
			this.SuspendLayout();
			this.chart.AntiAliasingEnabled = false;
			this.chart.Dock = DockStyle.Fill;
			this.chart.DoubleBufferingEnabled = true;
			this.chart.FileName = (string)null;
			this.chart.GroupLeftMarginEnabled = false;
			this.chart.GroupZoomEnabled = false;
			this.chart.ImeMode = ImeMode.Off;
			this.chart.Location = new Point(0, 0);
			this.chart.Name = "Text11w1";
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
			this.Controls.Add((Control)this.chart);
			this.Name = "Name";
			this.Text = "Text111";
			this.ResumeLayout(false);
		}
	}
}
