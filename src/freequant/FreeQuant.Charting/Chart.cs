// Type: SmartQuant.Charting.Chart
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

using cPAIWng0kq1SUTh6h4;
using gyr6NSGRxNZcTviJZk;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FreeQuant.Charting
{
  [Serializable]
  public class Chart : UserControl
  {
    protected static Pad fPad;
    protected PadList fPads;
    protected bool fPadSplit;
    protected int fPadSplitIndex;
    protected bool fDoubleBufferingEnabled;
    protected bool fSmoothingEnabled;
    protected bool fAntiAliasingEnabled;
    protected bool fIsUpdating;
    protected bool fGroupZoomEnabled;
    protected bool fGroupLeftMarginEnabled;
    protected bool fGroupRightMarginEnabled;
    protected string fFileName;
    protected ToolTip fToolTip;
    protected PrintDocument fPrintDocument;
    protected int fPrintX;
    protected int fPrintY;
    protected int fPrintWidth;
    protected int fPrintHeight;
    protected EPrintAlign fPrintAlign;
    protected EPrintLayout fPrintLayout;
    protected ETransformationType fTransformationType;
    protected Color fSessionGridColor;
    protected TimeSpan fSessionStart;
    protected TimeSpan fSessionEnd;
    protected bool fSessionGridEnabled;
    protected Color fPadsForeColor;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public PadList Pads
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fPads;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fPads = value;
      }
    }

    public bool GroupLeftMarginEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fGroupLeftMarginEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fGroupLeftMarginEnabled = value;
      }
    }

    public bool GroupRightMarginEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fGroupRightMarginEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fGroupRightMarginEnabled = value;
      }
    }

    public bool GroupZoomEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fGroupZoomEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fGroupZoomEnabled = value;
      }
    }

    public bool DoubleBufferingEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fDoubleBufferingEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fDoubleBufferingEnabled = value;
      }
    }

    public bool SmoothingEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fSmoothingEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fSmoothingEnabled = value;
      }
    }

    public bool AntiAliasingEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAntiAliasingEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAntiAliasingEnabled = value;
      }
    }

    public static Pad Pad
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return Chart.fPad;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        Chart.fPad = value;
      }
    }

    public ToolTip ToolTip
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fToolTip;
      }
    }

    public PrintDocument PrintDocument
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.fPrintDocument == null)
        {
          this.fPrintDocument = new PrintDocument();
          this.fPrintDocument.PrintPage += new PrintPageEventHandler(this.DrZCe67Y7d);
          this.fPrintDocument.DefaultPageSettings.Landscape = this.fPrintLayout == EPrintLayout.Landscape;
        }
        return this.fPrintDocument;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.fPrintDocument != null)
          this.fPrintDocument.PrintPage -= new PrintPageEventHandler(this.DrZCe67Y7d);
        this.fPrintDocument = value;
        this.fPrintDocument.PrintPage += new PrintPageEventHandler(this.DrZCe67Y7d);
      }
    }

    public int PrintX
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fPrintX;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fPrintX = value;
      }
    }

    public int PrintY
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fPrintY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fPrintY = value;
      }
    }

    public int PrintWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fPrintWidth;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fPrintWidth = value;
      }
    }

    public int PrintHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fPrintHeight;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fPrintHeight = value;
      }
    }

    public EPrintAlign PrintAlign
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fPrintAlign;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fPrintAlign = value;
      }
    }

    public EPrintLayout PrintLayout
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fPrintLayout;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fPrintLayout = value;
        if (this.fPrintDocument == null)
          return;
        if (this.fPrintLayout == EPrintLayout.Landscape)
          this.fPrintDocument.DefaultPageSettings.Landscape = true;
        else
          this.fPrintDocument.DefaultPageSettings.Landscape = false;
      }
    }

    public string FileName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fFileName;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fFileName = value;
      }
    }

    public Color PadsForeColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fPadsForeColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fPadsForeColor = value;
        foreach (Pad pad in this.fPads)
          pad.ForeColor = this.fPadsForeColor;
      }
    }

    [RefreshProperties(RefreshProperties.All)]
    [Category("Transformation")]
    [Description("")]
    public ETransformationType TransformationType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTransformationType;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTransformationType = value;
        this.fSessionStart = new TimeSpan(0, 0, 0, 0);
        this.fSessionEnd = new TimeSpan(0, 24, 0, 0);
        foreach (Pad pad in this.fPads)
          pad.TransformationType = value;
      }
    }

    [Category("Transformation")]
    [Description("")]
    public bool SessionGridEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fSessionGridEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fSessionGridEnabled = value;
        foreach (Pad pad in this.fPads)
          pad.SessionGridEnabled = value;
      }
    }

    [Category("Transformation")]
    [Description("")]
    public Color SessionGridColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fSessionGridColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fSessionGridColor = value;
        foreach (Pad pad in this.fPads)
          pad.SessionGridColor = value;
      }
    }

    [Category("Transformation")]
    [Description("")]
    public TimeSpan SessionStart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fSessionStart;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fSessionStart = value;
        foreach (Pad pad in this.fPads)
          pad.SessionStart = value;
      }
    }

    [Description("")]
    [Category("Transformation")]
    public TimeSpan SessionEnd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fSessionEnd;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fSessionEnd = value;
        foreach (Pad pad in this.fPads)
          pad.SessionEnd = value;
      }
    }

    public event EventHandler PadSplitMouseUp;

    public Chart():base()
    {
      this.Init();
      this.Name = "";
    }

    public Chart(string Name):base()
    {

      this.Init();
      this.Name = Name;
    }


    protected virtual void Init()
    {
      this.InitializeComponent();
      this.ResizeRedraw = true;
      this.fPadsForeColor = Color.White;
      this.fPads = new PadList();
      this.AddPad(0.0, 0.0, 1.0, 1.0);
      this.fPadSplit = false;
      this.fPadSplitIndex = 0;
      this.fDoubleBufferingEnabled = true;
      this.fSmoothingEnabled = false;
      this.fAntiAliasingEnabled = false;
      this.fToolTip = new ToolTip();
      this.fIsUpdating = false;
      this.SetStyle(ControlStyles.StandardClick, true);
      this.SetStyle(ControlStyles.StandardDoubleClick, true);
      this.SetStyle(ControlStyles.UserPaint, true);
      this.fPrintX = 10;
      this.fPrintY = 10;
      this.fPrintWidth = 600;
      this.fPrintHeight = 400;
      this.fPrintAlign = EPrintAlign.None;
      this.fPrintLayout = EPrintLayout.Portrait;
      this.fSessionGridColor = Color.Blue;
    }

    public Pad cd(int padIndex)
    {
      if (padIndex < 1)
        padIndex = 1;
      if (padIndex > this.fPads.Count)
        padIndex = this.fPads.Count;
      Chart.fPad = this.fPads[padIndex - 1];
      return Chart.fPad;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.fPads.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRangeX(double Min, double Max)
    {
      foreach (Pad pad in this.fPads)
        pad.SetRangeX(Min, Max);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRangeX(DateTime Min, DateTime Max)
    {
      foreach (Pad pad in this.fPads)
        pad.SetRangeX(Min, Max);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRangeY(double Min, double Max)
    {
      foreach (Pad pad in this.fPads)
        pad.SetRangeY(Min, Max);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Pad AddPad(double X1, double Y1, double X2, double Y2)
    {
      Chart.fPad = new Pad(this, X1, Y1, X2, Y2);
      Chart.fPad.Name = RA7k7APgXK5aSsnmA9.qBCYFXVOKp(836) + (this.fPads.Count + 1).ToString();
      Chart.fPad.ForeColor = this.fPadsForeColor;
      this.fPads.Add(Chart.fPad);
      Chart.fPad.Zoom += new ZoomEventHandler(this.ZoomChanged);
      return Chart.fPad;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Connect()
    {
      foreach (Pad pad in this.fPads)
        pad.Zoom += new ZoomEventHandler(this.ZoomChanged);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Disconnect()
    {
      foreach (Pad pad in this.fPads)
        pad.Zoom -= new ZoomEventHandler(this.ZoomChanged);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void ZoomChanged(object sender, ZoomEventArgs e)
    {
      if (!this.GroupZoomEnabled)
        return;
      foreach (Pad pad in this.fPads)
      {
        if (e.fZoomUnzoom)
        {
          pad.AxisBottom.SetRange(e.XMin, e.XMax);
          pad.AxisTop.SetRange(e.XMin, e.XMax);
          pad.AxisBottom.Zoomed = true;
          pad.AxisTop.Zoomed = true;
        }
        else
          pad.UnZoom();
      }
      this.UpdatePads();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void iLkC1B5ln0()
    {
      int val1 = 0;
      foreach (Pad pad in this.fPads)
        val1 = Math.Max(val1, pad.AxisLeft.LastValidAxisWidth);
      foreach (Pad pad in this.fPads)
        pad.MarginLeft = val1 - pad.AxisLeft.LastValidAxisWidth;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MCCC9wTn5m()
    {
      int val1 = 0;
      foreach (Pad pad in this.fPads)
        val1 = Math.Max(val1, pad.AxisRight.LastValidAxisWidth);
      foreach (Pad pad in this.fPads)
        pad.MarginRight = val1 - pad.AxisRight.LastValidAxisWidth;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Divide(int X, int Y)
    {
      this.fPads.Clear();
      double num1 = 1.0 / (double) X;
      double num2 = 1.0 / (double) Y;
      for (int index1 = 0; index1 < Y; ++index1)
      {
        for (int index2 = 0; index2 < X; ++index2)
        {
          double X1 = (double) index2 * num1;
          double X2 = (double) (index2 + 1) * num1;
          double Y1 = (double) index1 * num2;
          double Y2 = (double) (index1 + 1) * num2;
          this.AddPad(X1, Y1, X2, Y2);
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Divide(int X, int Y, double[] Widths, double[] Heights)
    {
      this.fPads.Clear();
      double Y1 = 0.0;
      double Y2 = 0.0;
      for (int index1 = 0; index1 < Y; ++index1)
      {
        if (index1 > 0)
          Y1 += Heights[index1 - 1];
        Y2 += Heights[index1];
        double X1 = 0.0;
        double X2 = 0.0;
        for (int index2 = 0; index2 < X; ++index2)
        {
          if (index2 > 0)
            X1 = Widths[index2 - 1];
          X2 += Widths[index2];
          this.AddPad(X1, Y1, X2, Y2);
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePads(Graphics PadGraphics, int X, int Y, int Width, int Height)
    {
      PadGraphics.Clear(this.BackColor);
      if (this.SmoothingEnabled)
        PadGraphics.SmoothingMode = SmoothingMode.AntiAlias;
      if (this.AntiAliasingEnabled)
        PadGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;
      foreach (Pad pad in this.fPads)
      {
        pad.SetCanvas(Width, Height);
        pad.X1 += X;
        pad.X2 += X;
        pad.Y1 += Y;
        pad.Y2 += Y;
        pad.Update(PadGraphics);
        pad.X1 -= X;
        pad.X2 -= X;
        pad.Y1 -= Y;
        pad.Y2 -= Y;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Bitmap GetBitmap()
    {
      return new Bitmap((Image) this.GetMetafile(EmfType.EmfPlusOnly));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Bitmap GetBitmap(float Dpi)
    {
      Graphics graphics = this.CreateGraphics();
      int num1 = (int) ((double) this.ClientRectangle.Width * (double) Dpi / (double) graphics.DpiX);
      int num2 = (int) ((double) this.ClientRectangle.Height * (double) Dpi / (double) graphics.DpiY);
      Bitmap bitmap = new Bitmap(num1, num2);
      bitmap.SetResolution(Dpi, Dpi);
      Graphics Graphics = Graphics.FromImage((Image) bitmap);
      Graphics.Clear(this.BackColor);
      if (this.SmoothingEnabled)
        Graphics.SmoothingMode = SmoothingMode.AntiAlias;
      if (this.AntiAliasingEnabled)
        Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
      if (this.GroupLeftMarginEnabled)
        this.iLkC1B5ln0();
      if (this.GroupRightMarginEnabled)
        this.MCCC9wTn5m();
      foreach (Pad pad in this.fPads)
      {
        pad.SetCanvas(num1, num2);
        pad.Update(Graphics);
      }
      Graphics.Dispose();
      return bitmap;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Metafile GetMetafile(EmfType type)
    {
      int width = this.ClientRectangle.Width;
      int height = this.ClientRectangle.Height;
      Graphics graphics = this.CreateGraphics();
      IntPtr hdc = graphics.GetHdc();
      Metafile metafile = new Metafile(hdc, type);
      graphics.ReleaseHdc(hdc);
      graphics.Dispose();
      Graphics Graphics = Graphics.FromImage((Image) metafile);
      Graphics.Clear(this.BackColor);
      if (this.SmoothingEnabled)
        Graphics.SmoothingMode = SmoothingMode.AntiAlias;
      if (this.AntiAliasingEnabled)
        Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
      if (this.GroupLeftMarginEnabled)
        this.iLkC1B5ln0();
      if (this.GroupRightMarginEnabled)
        this.MCCC9wTn5m();
      foreach (Pad pad in this.fPads)
      {
        pad.SetCanvas(width, height);
        pad.Update(Graphics);
      }
      Graphics.Dispose();
      return metafile;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveImage(string filename, ImageFormat format)
    {
      Metafile metafile = this.GetMetafile(EmfType.EmfPlusOnly);
      metafile.Save(filename, format);
      metafile.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePads()
    {
      this.Invalidate();
      Application.DoEvents();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePads(Graphics g)
    {
      if (this.Disposing || this.fIsUpdating)
        return;
      this.fIsUpdating = true;
      int width = this.ClientRectangle.Width;
      int height = this.ClientRectangle.Height;
      Bitmap bitmap = (Bitmap) null;
      Graphics Graphics;
      try
      {
        if (this.fDoubleBufferingEnabled)
        {
          bitmap = new Bitmap(width, height);
          Graphics = Graphics.FromImage((Image) bitmap);
        }
        else
          Graphics = g;
      }
      catch
      {
        this.fIsUpdating = false;
        return;
      }
      Graphics.Clear(this.BackColor);
      if (this.SmoothingEnabled)
        Graphics.SmoothingMode = SmoothingMode.AntiAlias;
      if (this.AntiAliasingEnabled)
        Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
      if (this.GroupLeftMarginEnabled)
        this.iLkC1B5ln0();
      if (this.GroupRightMarginEnabled)
        this.MCCC9wTn5m();
      foreach (Pad pad in this.fPads)
      {
        pad.SetCanvas(width, height);
        pad.Update(Graphics);
      }
      if (this.fDoubleBufferingEnabled)
      {
        Graphics graphics;
        try
        {
          graphics = g;
        }
        catch
        {
          this.fIsUpdating = false;
          return;
        }
        if (graphics != null)
        {
          graphics.DrawImage((Image) bitmap, 0, 0);
          if (this.fFileName != null)
            bitmap.Save(this.FileName, ImageFormat.Gif);
          bitmap.Dispose();
          graphics.Dispose();
        }
      }
      Graphics.Dispose();
      this.fIsUpdating = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Print()
    {
      this.PrintDocument.Print();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void PrintPreview()
    {
      ((Control) new PrintPreviewDialog()
      {
        Document = this.PrintDocument
      }).Show();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void PrintSetup()
    {
      int num = (int) new PrintDialog()
      {
        Document = this.PrintDocument
      }.ShowDialog();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void PrintPageSetup()
    {
      int num = (int) new PageSetupDialog()
      {
        Document = this.PrintDocument
      }.ShowDialog();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrZCe67Y7d([In] object obj0, [In] PrintPageEventArgs obj1)
    {
      int X = this.fPrintX;
      int Y = this.fPrintY;
      switch (this.fPrintAlign)
      {
        case EPrintAlign.Veritcal:
          Y = (obj1.PageBounds.Height - this.fPrintHeight) / 2;
          break;
        case EPrintAlign.Horizontal:
          X = (obj1.PageBounds.Width - this.fPrintWidth) / 2;
          break;
        case EPrintAlign.Center:
          X = (obj1.PageBounds.Width - this.fPrintWidth) / 2;
          Y = (obj1.PageBounds.Height - this.fPrintHeight) / 2;
          break;
      }
      this.UpdatePads(obj1.Graphics, X, Y, this.fPrintWidth, this.fPrintHeight);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void InitializeComponent()
    {
      this.Size = new Size(272, 168);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnPaint(PaintEventArgs pe)
    {
      this.UpdatePads(pe.Graphics);
      base.OnPaint(pe);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnPaintBackground(PaintEventArgs e)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnMouseMove(MouseEventArgs e)
    {
      if (this.fPadSplit)
      {
        Pad pad1 = this.fPads[this.fPadSplitIndex];
        int width = this.ClientRectangle.Width;
        int height = this.ClientRectangle.Height;
        double num = (double) e.Y / (double) height;
        pad1.SetCanvas(pad1.CanvasX1, num, pad1.CanvasX2, pad1.CanvasY2, width, height);
        if (this.fPadSplitIndex != 0)
        {
          Pad pad2 = this.fPads[this.fPadSplitIndex - 1];
          pad2.SetCanvas(pad2.CanvasX1, pad2.CanvasY1, pad2.CanvasX2, num, width, height);
        }
        this.UpdatePads();
      }
      foreach (Pad pad in this.fPads)
      {
        if (pad.Y1 - 1 <= e.Y && e.Y <= pad.Y1 + 1)
        {
          if (!(Cursor.Current != Cursors.HSplit))
            return;
          Cursor.Current = Cursors.HSplit;
          return;
        }
      }
      foreach (Pad pad in this.fPads)
      {
        if (pad.X1 <= e.X && pad.X2 >= e.X && (pad.Y1 <= e.Y && pad.Y2 >= e.Y))
          pad.MouseMove(e);
      }
      base.OnMouseMove(e);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnMouseWheel(MouseEventArgs e)
    {
      foreach (Pad pad in this.fPads)
      {
        if (pad.X1 <= e.X && pad.X2 >= e.X && (pad.Y1 <= e.Y && pad.Y2 >= e.Y))
          pad.MouseWheel(e);
      }
      base.OnMouseWheel(e);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnMouseDown(MouseEventArgs e)
    {
      foreach (Pad pad in this.fPads)
      {
        if (pad.Y1 - 1 <= e.Y && e.Y <= pad.Y1 + 1)
        {
          this.fPadSplit = true;
          this.fPadSplitIndex = this.fPads.IndexOf(pad);
          return;
        }
      }
      foreach (Pad pad in this.fPads)
      {
        if (pad.X1 <= e.X && pad.X2 >= e.X && (pad.Y1 <= e.Y && pad.Y2 >= e.Y))
          pad.MouseDown(e);
      }
      base.OnMouseDown(e);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnMouseUp(MouseEventArgs e)
    {
      if (this.fPadSplit)
      {
        this.fPadSplit = false;
        if (this.JxOC7adEtl == null)
          return;
        this.JxOC7adEtl((object) this, EventArgs.Empty);
      }
      else
      {
        foreach (Pad pad in this.fPads)
          pad.MouseUp(e);
        base.OnMouseUp(e);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDoubleClick(EventArgs e)
    {
      Point point = this.PointToClient(Cursor.Position);
      foreach (Pad pad in this.fPads)
      {
        if (pad.X1 <= point.X && pad.X2 >= point.X && (pad.Y1 <= point.Y && pad.Y2 >= point.Y))
          pad.DoubleClick(point.X, point.Y);
      }
      base.OnDoubleClick(e);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      foreach (Pad pad in this.fPads)
        pad.Monitored = false;
      base.Dispose(disposing);
    }
  }
}
