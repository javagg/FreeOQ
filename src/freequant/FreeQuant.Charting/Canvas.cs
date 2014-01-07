// Type: SmartQuant.Charting.Canvas
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

using cPAIWng0kq1SUTh6h4;
using gyr6NSGRxNZcTviJZk;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SmartQuant.Charting
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return Chart.Pad;
      }
    }

    public string Title
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Text;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Text = value;
      }
    }

    public static bool FileEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return Canvas.ppm6BPFcVg;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        Canvas.ppm6BPFcVg = value;
      }
    }

    public static string FileDir
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return Canvas.CJy6CmouJG;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        Canvas.CJy6CmouJG = value;
      }
    }

    public static string FileNamePrefix
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return Canvas.ANH66vA6dt;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        Canvas.ANH66vA6dt = value;
      }
    }

    public static string FileNameSuffix
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return Canvas.i4P6YLI4vV;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        Canvas.i4P6YLI4vV = value;
      }
    }

    public bool GroupZoomEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nvt6KwgxYV.GroupZoomEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nvt6KwgxYV.GroupZoomEnabled = value;
      }
    }

    public bool GroupLeftMarginEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nvt6KwgxYV.GroupLeftMarginEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nvt6KwgxYV.GroupLeftMarginEnabled = value;
      }
    }

    public bool DoubleBufferingEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nvt6KwgxYV.DoubleBufferingEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nvt6KwgxYV.DoubleBufferingEnabled = value;
      }
    }

    public bool SmoothingEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nvt6KwgxYV.SmoothingEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nvt6KwgxYV.SmoothingEnabled = value;
      }
    }

    public bool AntiAliasingEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nvt6KwgxYV.AntiAliasingEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nvt6KwgxYV.AntiAliasingEnabled = value;
      }
    }

    public PrintDocument PrintDocument
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nvt6KwgxYV.PrintDocument;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nvt6KwgxYV.PrintDocument = value;
      }
    }

    public int PrintX
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nvt6KwgxYV.PrintX;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nvt6KwgxYV.PrintX = value;
      }
    }

    public int PrintY
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nvt6KwgxYV.PrintY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nvt6KwgxYV.PrintY = value;
      }
    }

    public int PrintWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nvt6KwgxYV.PrintWidth;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nvt6KwgxYV.PrintWidth = value;
      }
    }

    public int PrintHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nvt6KwgxYV.PrintHeight;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nvt6KwgxYV.PrintHeight = value;
      }
    }

    public EPrintAlign PrintAlign
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nvt6KwgxYV.PrintAlign;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nvt6KwgxYV.PrintAlign = value;
      }
    }

    public EPrintLayout PrintLayout
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nvt6KwgxYV.PrintLayout;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nvt6KwgxYV.PrintLayout = value;
      }
    }

    public Chart Chart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nvt6KwgxYV;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Canvas()
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      Canvas.CJy6CmouJG = "";
      Canvas.ANH66vA6dt = "";
      Canvas.i4P6YLI4vV = "";
      Canvas.ppm6BPFcVg = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Canvas()
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.CNA6nGRr44();
      this.Name = RA7k7APgXK5aSsnmA9.qBCYFXVOKp(898);
      this.Text = RA7k7APgXK5aSsnmA9.qBCYFXVOKp(914);
      this.Wnm6oPv8qu();
      CanvasManager.Add(this);
      if (Canvas.ppm6BPFcVg)
        return;
      ((Control) this).Show();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Canvas(string Name, string Title)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.CNA6nGRr44();
      this.Name = Name;
      this.Text = Title;
      this.Wnm6oPv8qu();
      CanvasManager.Add(this);
      if (Canvas.FileEnabled)
        return;
      ((Control) this).Show();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Canvas(string name)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.CNA6nGRr44();
      this.Name = name;
      this.Text = name;
      this.Wnm6oPv8qu();
      CanvasManager.Add(this);
      if (Canvas.FileEnabled)
        return;
      ((Control) this).Show();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Canvas(string Name, string Title, string FileName)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.CNA6nGRr44();
      this.Name = Name;
      this.Text = Title;
      this.Wnm6oPv8qu();
      this.nvt6KwgxYV.FileName = FileName;
      CanvasManager.Add(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Canvas(string Name, string Title, int Width, int Height)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Canvas(string Name, int Width, int Height)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Canvas(string Name, string Title, string FileName, int Width, int Height)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.CNA6nGRr44();
      this.Name = Name;
      this.Text = Title;
      this.Wnm6oPv8qu();
      this.nvt6KwgxYV.FileName = FileName;
      CanvasManager.Add(this);
      this.Width = Width;
      this.Height = Height;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CNA6nGRr44()
    {
      this.drh63ZfGFV();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Wnm6oPv8qu()
    {
      if (!Canvas.ppm6BPFcVg)
        return;
      this.nvt6KwgxYV.FileName = Canvas.CJy6CmouJG + RA7k7APgXK5aSsnmA9.qBCYFXVOKp(848) + Canvas.ANH66vA6dt + this.Name + DateTime.Now.ToString(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(856)) + Canvas.i4P6YLI4vV + RA7k7APgXK5aSsnmA9.qBCYFXVOKp(886);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Pad cd(int pad)
    {
      return this.nvt6KwgxYV.cd(pad);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.nvt6KwgxYV.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateChart()
    {
      this.nvt6KwgxYV.UpdatePads();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public new void Update()
    {
      base.Update();
      this.UpdateChart();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Pad AddPad(double x1, double y1, double x2, double y2)
    {
      return this.nvt6KwgxYV.AddPad(x1, y1, x2, y2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Divide(int x, int y)
    {
      this.nvt6KwgxYV.Divide(x, y);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Divide(int x, int y, double[] widths, double[] heights)
    {
      this.nvt6KwgxYV.Divide(x, y, widths, heights);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      CanvasManager.Remove(this);
      if (disposing && this.yeZ6fGuZt9 != null)
        this.yeZ6fGuZt9.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Print()
    {
      this.nvt6KwgxYV.Print();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void PrintPreview()
    {
      this.nvt6KwgxYV.PrintPreview();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void PrintSetup()
    {
      this.nvt6KwgxYV.PrintSetup();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void PrintPageSetup()
    {
      this.nvt6KwgxYV.PrintPageSetup();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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
      this.nvt6KwgxYV.Name = RA7k7APgXK5aSsnmA9.qBCYFXVOKp(952);
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
      this.Name = RA7k7APgXK5aSsnmA9.qBCYFXVOKp(968);
      this.Text = RA7k7APgXK5aSsnmA9.qBCYFXVOKp(986);
      this.ResumeLayout(false);
    }
  }
}
