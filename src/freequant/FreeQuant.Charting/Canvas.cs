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
    private static string CJy6CmouJG;
    private static string ANH66vA6dt;
    private static string i4P6YLI4vV;
    private static bool ppm6BPFcVg;
    private HelpProvider OkJ6lpo8hb;
    private Chart nvt6KwgxYV;
    private Container yeZ6fGuZt9;

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

    public static bool FileEnabled
    {
       get
      {
        return Canvas.ppm6BPFcVg;
      }
       set
      {
        Canvas.ppm6BPFcVg = value;
      }
    }

    public static string FileDir
    {
       get
      {
        return Canvas.CJy6CmouJG;
      }
       set
      {
        Canvas.CJy6CmouJG = value;
      }
    }

    public static string FileNamePrefix
    {
       get
      {
        return Canvas.ANH66vA6dt;
      }
       set
      {
        Canvas.ANH66vA6dt = value;
      }
    }

    public static string FileNameSuffix
    {
       get
      {
        return Canvas.i4P6YLI4vV;
      }
       set
      {
        Canvas.i4P6YLI4vV = value;
      }
    }

    public bool GroupZoomEnabled
    {
       get
      {
        return this.nvt6KwgxYV.GroupZoomEnabled;
      }
       set
      {
        this.nvt6KwgxYV.GroupZoomEnabled = value;
      }
    }

    public bool GroupLeftMarginEnabled
    {
       get
      {
        return this.nvt6KwgxYV.GroupLeftMarginEnabled;
      }
       set
      {
        this.nvt6KwgxYV.GroupLeftMarginEnabled = value;
      }
    }

    public bool DoubleBufferingEnabled
    {
       get
      {
        return this.nvt6KwgxYV.DoubleBufferingEnabled;
      }
       set
      {
        this.nvt6KwgxYV.DoubleBufferingEnabled = value;
      }
    }

    public bool SmoothingEnabled
    {
       get
      {
        return this.nvt6KwgxYV.SmoothingEnabled;
      }
       set
      {
        this.nvt6KwgxYV.SmoothingEnabled = value;
      }
    }

    public bool AntiAliasingEnabled
    {
       get
      {
        return this.nvt6KwgxYV.AntiAliasingEnabled;
      }
       set
      {
        this.nvt6KwgxYV.AntiAliasingEnabled = value;
      }
    }

    public PrintDocument PrintDocument
    {
       get
      {
        return this.nvt6KwgxYV.PrintDocument;
      }
       set
      {
        this.nvt6KwgxYV.PrintDocument = value;
      }
    }

    public int PrintX
    {
       get
      {
        return this.nvt6KwgxYV.PrintX;
      }
       set
      {
        this.nvt6KwgxYV.PrintX = value;
      }
    }

    public int PrintY
    {
       get
      {
        return this.nvt6KwgxYV.PrintY;
      }
       set
      {
        this.nvt6KwgxYV.PrintY = value;
      }
    }

    public int PrintWidth
    {
       get
      {
        return this.nvt6KwgxYV.PrintWidth;
      }
       set
      {
        this.nvt6KwgxYV.PrintWidth = value;
      }
    }

    public int PrintHeight
    {
       get
      {
        return this.nvt6KwgxYV.PrintHeight;
      }
       set
      {
        this.nvt6KwgxYV.PrintHeight = value;
      }
    }

    public EPrintAlign PrintAlign
    {
       get
      {
        return this.nvt6KwgxYV.PrintAlign;
      }
       set
      {
        this.nvt6KwgxYV.PrintAlign = value;
      }
    }

    public EPrintLayout PrintLayout
    {
       get
      {
        return this.nvt6KwgxYV.PrintLayout;
      }
       set
      {
        this.nvt6KwgxYV.PrintLayout = value;
      }
    }

    public Chart Chart
    {
       get
      {
        return this.nvt6KwgxYV;
      }
    }

    
    static Canvas()
    {
      Canvas.CJy6CmouJG = "";
      Canvas.ANH66vA6dt = "";
      Canvas.i4P6YLI4vV = "";
      Canvas.ppm6BPFcVg = false;
    }

    
		public Canvas() : base()
    {
      this.CNA6nGRr44();
		this.Name = "CanvasName";
		this.Text = "CanvasText";
      this.Wnm6oPv8qu();
      CanvasManager.Add(this);
      if (Canvas.ppm6BPFcVg)
        return;
      ((Control) this).Show();
    }


    public Canvas(string Name, string Title):base()
    {

      this.CNA6nGRr44();
      this.Name = Name;
      this.Text = Title;
      this.Wnm6oPv8qu();
      CanvasManager.Add(this);
      if (Canvas.FileEnabled)
        return;
      ((Control) this).Show();
    }

    
    public Canvas(string name):base()
    {

      this.CNA6nGRr44();
      this.Name = name;
      this.Text = name;
      this.Wnm6oPv8qu();
      CanvasManager.Add(this);
      if (Canvas.FileEnabled)
        return;
      ((Control) this).Show();
    }

    
    public Canvas(string Name, string Title, string FileName):base()
    {

      this.CNA6nGRr44();
      this.Name = Name;
      this.Text = Title;
      this.Wnm6oPv8qu();
      this.nvt6KwgxYV.FileName = FileName;
      CanvasManager.Add(this);
    }

    
    public Canvas(string Name, string Title, int Width, int Height):base()
    {
      this.CNA6nGRr44();
      this.Name = Name;
      this.Text = Title;
      this.Wnm6oPv8qu();
      CanvasManager.Add(this);
      this.Width = Width;
      this.Height = Height;
      if (Canvas.FileEnabled)
        return;
      ((Control) this).Show();
    }

    
    public Canvas(string Name, int Width, int Height):base()
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
      ((Control) this).Show();
    }

    public Canvas(string Name, string Title, string FileName, int Width, int Height):base()
    {
      this.CNA6nGRr44();
      this.Name = Name;
      this.Text = Title;
      this.Wnm6oPv8qu();
      this.nvt6KwgxYV.FileName = FileName;
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
      if (!Canvas.ppm6BPFcVg)
        return;
      this.nvt6KwgxYV.FileName = Canvas.CJy6CmouJG + RA7k7APgXK5aSsnmA9.qBCYFXVOKp(848) + Canvas.ANH66vA6dt + this.Name + DateTime.Now.ToString(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(856)) + Canvas.i4P6YLI4vV + RA7k7APgXK5aSsnmA9.qBCYFXVOKp(886);
    }

    
    public Pad cd(int pad)
    {
      return this.nvt6KwgxYV.cd(pad);
    }

    
    public void Clear()
    {
      this.nvt6KwgxYV.Clear();
    }

    
    public void UpdateChart()
    {
      this.nvt6KwgxYV.UpdatePads();
    }

    
    public new void Update()
    {
      base.Update();
      this.UpdateChart();
    }

    
    public Pad AddPad(double x1, double y1, double x2, double y2)
    {
      return this.nvt6KwgxYV.AddPad(x1, y1, x2, y2);
    }

    
    public void Divide(int x, int y)
    {
      this.nvt6KwgxYV.Divide(x, y);
    }

    
    public void Divide(int x, int y, double[] widths, double[] heights)
    {
      this.nvt6KwgxYV.Divide(x, y, widths, heights);
    }

    
    protected override void Dispose(bool disposing)
    {
      CanvasManager.Remove(this);
      if (disposing && this.yeZ6fGuZt9 != null)
        this.yeZ6fGuZt9.Dispose();
      base.Dispose(disposing);
    }

    
    public virtual void Print()
    {
      this.nvt6KwgxYV.Print();
    }

    
    public virtual void PrintPreview()
    {
      this.nvt6KwgxYV.PrintPreview();
    }

    
    public virtual void PrintSetup()
    {
      this.nvt6KwgxYV.PrintSetup();
    }

    
    public virtual void PrintPageSetup()
    {
      this.nvt6KwgxYV.PrintPageSetup();
    }

    
    private void drh63ZfGFV()
    {
      this.OkJ6lpo8hb = new HelpProvider();
      this.nvt6KwgxYV = new Chart();
      this.SuspendLayout();
      this.nvt6KwgxYV.AntiAliasingEnabled = false;
      this.nvt6KwgxYV.Dock = DockStyle.Fill;
      this.nvt6KwgxYV.DoubleBufferingEnabled = true;
      this.nvt6KwgxYV.FileName = (string) null;
      this.nvt6KwgxYV.GroupLeftMarginEnabled = false;
      this.nvt6KwgxYV.GroupZoomEnabled = false;
      this.nvt6KwgxYV.ImeMode = ImeMode.Off;
      this.nvt6KwgxYV.Location = new Point(0, 0);
			this.nvt6KwgxYV.Name = "Text11w1";
      this.nvt6KwgxYV.PrintAlign = EPrintAlign.None;
      this.nvt6KwgxYV.PrintHeight = 400;
      this.nvt6KwgxYV.PrintLayout = EPrintLayout.Portrait;
      this.nvt6KwgxYV.PrintWidth = 600;
      this.nvt6KwgxYV.PrintX = 10;
      this.nvt6KwgxYV.PrintY = 10;
      this.nvt6KwgxYV.Size = new Size(488, 293);
      this.nvt6KwgxYV.SmoothingEnabled = false;
      this.nvt6KwgxYV.TabIndex = 0;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(488, 293);
      this.Controls.Add((Control) this.nvt6KwgxYV);
			this.Name = "Name";
			this.Text = "Text111";
      this.ResumeLayout(false);
    }
  }
}
