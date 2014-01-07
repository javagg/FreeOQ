// Type: SmartQuant.Charting.Pad
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

using cPAIWng0kq1SUTh6h4;
using gyr6NSGRxNZcTviJZk;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartQuant.Charting
{
  [Serializable]
  public class Pad
  {
    private Pad.ut9JGY6223LcaEWEIv VN5zSfcsG;
    [Browsable(false)]
    public bool Grid3D;
    protected int fX1;
    protected int fX2;
    protected int fY1;
    protected int fY2;
    protected double fCanvasX1;
    protected double fCanvasX2;
    protected double fCanvasY1;
    protected double fCanvasY2;
    protected int fClientX;
    protected int fClientY;
    protected int fClientWidth;
    protected int fClientHeight;
    protected double fXMin;
    protected double fXMax;
    protected double fYMin;
    protected double fYMax;
    protected int fMarginLeft;
    protected int fMarginRight;
    protected int fMarginTop;
    protected int fMarginBottom;
    protected int fWidth;
    protected int fHeight;
    [NonSerialized]
    protected Chart fChart;
    [NonSerialized]
    protected Graphics fGraphics;
    protected ArrayList fPrimitives;
    protected Color fBackColor;
    protected Color fForeColor;
    protected string fName;
    protected TTitle fTitle;
    protected bool fTitleEnabled;
    protected int fTitleOffsetX;
    protected int fTitleOffsetY;
    protected Axis fAxisLeft;
    protected Axis fAxisRight;
    protected Axis fAxisTop;
    protected Axis fAxisBottom;
    protected TLegend fLegend;
    protected bool fLegendEnabled;
    protected ELegendPosition fLegendPosition;
    protected int fLegendOffsetX;
    protected int fLegendOffsetY;
    protected bool fBorderEnabled;
    protected Color fBorderColor;
    protected int fBorderWidth;
    protected IDrawable fSelectedPrimitive;
    protected TDistance fSelectedPrimitiveDistance;
    protected bool fOnAxis;
    protected bool fOnPrimitive;
    protected bool fMouseDown;
    protected int fMouseDownX;
    protected int fMouseDownY;
    [NonSerialized]
    protected MouseButtons fMouseDownButton;
    protected bool fOutlineEnabled;
    protected Rectangle fOutlineRectangle;
    protected bool fMouseZoomEnabled;
    protected bool fMouseZoomXAxisEnabled;
    protected bool fMouseZoomYAxisEnabled;
    protected bool fMouseUnzoomEnabled;
    protected bool fMouseUnzoomXAxisEnabled;
    protected bool fMouseUnzoomYAxisEnabled;
    protected bool fMouseMoveContentEnabled;
    protected bool fMouseMovePrimitiveEnabled;
    protected bool fMouseDeletePrimitiveEnabled;
    protected bool fMousePadPropertiesEnabled;
    protected bool fMousePrimitivePropertiesEnabled;
    protected bool fMouseContextMenuEnabled;
    protected bool fMouseWheelEnabled;
    protected double fMouseWheelSensitivity;
    protected EMouseWheelMode fMouseWheelMode;
    protected int fWindowSize;
    protected bool fMonitored;
    protected bool fUpdating;
    protected int fLastTickTime;
    protected int fUpdateInterval;
    protected DateTime fLastUpdateDateTime;
    protected ETransformationType fTransformationType;
    protected IChartTransformation fTransformation;
    protected Color fSessionGridColor;
    [NonSerialized]
    private ContextMenu KtXo3eo8yY;
    [NonSerialized]
    private MenuItem rlboC951ES;
    [NonSerialized]
    private MenuItem kpXo6pj5Cs;

    [Browsable(false)]
    public bool For3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VN5zSfcsG.uRWofxiHHl();
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.VN5zSfcsG.jYkoFPyqxe(value);
      }
    }

    [Browsable(false)]
    public object View3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VN5zSfcsG.NHloRxNAlb;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.VN5zSfcsG.NHloRxNAlb = value;
      }
    }

    [Browsable(false)]
    public Axis[] Axes3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VN5zSfcsG.K7qoPqVA9V;
      }
    }

    [Browsable(false)]
    public Axis AxisX3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VN5zSfcsG.K7qoPqVA9V[0];
      }
    }

    [Browsable(false)]
    public Axis AxisY3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VN5zSfcsG.K7qoPqVA9V[1];
      }
    }

    [Browsable(false)]
    public Axis AxisZ3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VN5zSfcsG.K7qoPqVA9V[2];
      }
    }

    [Browsable(false)]
    public Chart Chart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fChart;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fChart = value;
      }
    }

    [Description("Enable or disable double buffering")]
    [Category("Appearance")]
    public bool DoubleBufferingEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fChart.DoubleBufferingEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fChart.DoubleBufferingEnabled = value;
      }
    }

    [Description("Enable or disable smoothing")]
    [Category("Appearance")]
    public bool SmoothingEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fChart.SmoothingEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fChart.SmoothingEnabled = value;
      }
    }

    [Category("Appearance")]
    [Description("Enable or disable antialiasing")]
    public bool AntiAliasingEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fChart.AntiAliasingEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fChart.AntiAliasingEnabled = value;
      }
    }

    [Description("")]
    [Category("Position")]
    public double CanvasX1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fCanvasX1;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fCanvasX1 = value;
      }
    }

    [Description("")]
    [Category("Position")]
    public double CanvasX2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fCanvasX2;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fCanvasX2 = value;
      }
    }

    [Description("")]
    [Category("Position")]
    public double CanvasY1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fCanvasY1;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fCanvasY1 = value;
      }
    }

    [Category("Position")]
    [Description("")]
    public double CanvasY2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fCanvasY2;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fCanvasY2 = value;
      }
    }

    [Browsable(false)]
    public double CanvasWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return Math.Abs(this.fCanvasX2 - this.fCanvasX1);
      }
    }

    [Browsable(false)]
    public double CanvasHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return Math.Abs(this.fCanvasY2 - this.fCanvasY1);
      }
    }

    [Browsable(false)]
    public virtual int X1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fX1;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fX1 = value;
        this.fWidth = this.fX2 - this.fX1;
      }
    }

    [Browsable(false)]
    public virtual int X2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fX2;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fX2 = value;
        this.fWidth = this.fX2 - this.fX1;
      }
    }

    [Browsable(false)]
    public int Y1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fY1;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fY1 = value;
        this.fHeight = this.fY2 - this.fY1;
      }
    }

    [Browsable(false)]
    public int Y2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fY2;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fY2 = value;
        this.fHeight = this.fY2 - this.fY1;
      }
    }

    [Browsable(false)]
    public int Width
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fWidth;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fWidth = value;
        this.fX2 = this.fX1 + this.fWidth;
      }
    }

    [Browsable(false)]
    public int Height
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fHeight;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fHeight = value;
        this.fY2 = this.fY1 + this.fHeight;
      }
    }

    [Browsable(false)]
    public double XMin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.fAxisBottom.Enabled && this.fAxisBottom.Zoomed)
          return this.fAxisBottom.Min;
        else
          return this.fXMin;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fXMin = value;
      }
    }

    [Browsable(false)]
    public double XMax
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.fAxisBottom.Enabled && this.fAxisBottom.Zoomed)
          return this.fAxisBottom.Max;
        else
          return this.fXMax;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fXMax = value;
      }
    }

    [Browsable(false)]
    public double YMin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.fAxisLeft.Enabled && this.fAxisLeft.Zoomed)
          return this.fAxisLeft.Min;
        else
          return this.fYMin;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fYMin = value;
      }
    }

    [Browsable(false)]
    public double YMax
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.fAxisLeft.Enabled && this.fAxisLeft.Zoomed)
          return this.fAxisLeft.Max;
        else
          return this.fYMax;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fYMax = value;
      }
    }

    [Browsable(false)]
    public double XRangeMin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fXMin;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fXMin = value;
      }
    }

    [Browsable(false)]
    public double XRangeMax
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fXMax;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fXMax = value;
      }
    }

    [Browsable(false)]
    public double YRangeMin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fYMin;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fYMin = value;
      }
    }

    [Browsable(false)]
    public double YRangeMax
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fYMax;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fYMax = value;
      }
    }

    [Category("Margin")]
    [Description("")]
    public int MarginLeft
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMarginLeft;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMarginLeft = value;
      }
    }

    [Description("")]
    [Category("Margin")]
    public int MarginRight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMarginRight;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMarginRight = value;
      }
    }

    [Category("Margin")]
    [Description("")]
    public int MarginTop
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMarginTop;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMarginTop = value;
      }
    }

    [Category("Margin")]
    [Description("")]
    public int MarginBottom
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMarginBottom;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMarginBottom = value;
      }
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fName;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fName = value;
      }
    }

    [Browsable(false)]
    public TTitle Title
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTitle;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTitle = value;
      }
    }

    [Description("")]
    [Category("Title")]
    public bool TitleEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTitleEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTitleEnabled = value;
      }
    }

    [Category("Title")]
    [Description("")]
    public ArrayList TitleItems
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTitle.Items;
      }
    }

    [Category("Title")]
    [Description("")]
    public bool TitleItemsEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTitle.ItemsEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTitle.ItemsEnabled = value;
      }
    }

    [Category("Title")]
    [Description("")]
    public string TitleText
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTitle.Text;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTitle.Text = value;
      }
    }

    [Description("")]
    [Category("Title")]
    public Font TitleFont
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTitle.Font;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTitle.Font = value;
      }
    }

    [Description("")]
    [Category("Title")]
    public Color TitleColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTitle.Color;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTitle.Color = value;
      }
    }

    [Category("Title")]
    [Description("Title offset alone X axis")]
    public int TitleOffsetX
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTitleOffsetX;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTitleOffsetX = value;
      }
    }

    [Description("Title offset alone Y axis")]
    [Category("Title")]
    public int TitleOffsetY
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTitleOffsetY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTitleOffsetY = value;
      }
    }

    [Description("")]
    [Category("Title")]
    public ETitlePosition TitlePosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTitle.Position;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTitle.Position = value;
      }
    }

    [Category("Title")]
    [Description("")]
    public ETitleStrategy TitleStrategy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTitle.Strategy;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fTitle.Strategy = value;
      }
    }

    [Description("")]
    [Category("Color")]
    public Color BackColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fBackColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fBackColor = value;
      }
    }

    [Description("")]
    [Category("Color")]
    public Color ForeColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fForeColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fForeColor = value;
      }
    }

    [Browsable(false)]
    public ArrayList Primitives
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fPrimitives;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fPrimitives = value;
      }
    }

    [Browsable(false)]
    public Graphics Graphics
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fGraphics;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fGraphics = value;
      }
    }

    [Browsable(false)]
    public Axis AxisLeft
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft;
      }
    }

    [Browsable(false)]
    public Axis AxisRight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisRight;
      }
    }

    [Browsable(false)]
    public Axis AxisTop
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisTop;
      }
    }

    [Browsable(false)]
    public Axis AxisBottom
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom;
      }
    }

    [Category("Grid")]
    [Description("")]
    public bool XGridEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.GridEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.GridEnabled = value;
      }
    }

    [Category("Grid")]
    [Description("")]
    public bool YGridEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.GridEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.GridEnabled = value;
      }
    }

    [Category("Grid")]
    [Description("")]
    public float XGridWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.GridWidth;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.GridWidth = value;
      }
    }

    [Category("Grid")]
    [Description("")]
    public float YGridWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.GridWidth;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.GridWidth = value;
      }
    }

    [Category("Grid")]
    [Description("")]
    public Color XGridColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.GridColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.GridColor = value;
      }
    }

    [Description("")]
    [Category("Grid")]
    public Color YGridColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.GridColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.GridColor = value;
      }
    }

    [Description("")]
    [Category("Grid")]
    public DashStyle XGridDashStyle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.GridDashStyle;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.GridDashStyle = value;
      }
    }

    [Description("")]
    [Category("Grid")]
    public DashStyle YGridDashStyle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.GridDashStyle;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.GridDashStyle = value;
      }
    }

    [Category("XAxis")]
    [Description("")]
    public EAxisType XAxisType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.Type;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.Type = value;
      }
    }

    [Category("XAxis")]
    [Description("")]
    public EAxisPosition XAxisPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.Position;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.Position = value;
      }
    }

    [Description("")]
    [Category("XAxis")]
    public bool XAxisMajorTicksEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.MajorTicksEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.MajorTicksEnabled = value;
      }
    }

    [Description("")]
    [Category("XAxis")]
    public bool XAxisMinorTicksEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.MinorTicksEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.MinorTicksEnabled = value;
      }
    }

    [Category("XAxis")]
    [Description("")]
    public bool XAxisTitleEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.TitleEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.TitleEnabled = value;
      }
    }

    [Description("")]
    [Category("XAxis")]
    public string XAxisTitle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.Title;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.Title = value;
      }
    }

    [Category("XAxis")]
    [Description("")]
    public Font XAxisTitleFont
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.TitleFont;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.TitleFont = value;
      }
    }

    [Description("")]
    [Category("XAxis")]
    public Color XAxisTitleColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.TitleColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.TitleColor = value;
      }
    }

    [Description("")]
    [Category("XAxis")]
    public int XAxisTitleOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.TitleOffset;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.TitleOffset = value;
      }
    }

    [Category("XAxis")]
    [Description("")]
    public EAxisTitlePosition XAxisTitlePosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.TitlePosition;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.TitlePosition = value;
      }
    }

    [Category("XAxis")]
    [Description("")]
    public bool XAxisLabelEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.LabelEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.LabelEnabled = value;
      }
    }

    [Description("")]
    [Category("XAxis")]
    public Font XAxisLabelFont
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.LabelFont;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.LabelFont = value;
      }
    }

    [Description("")]
    [Category("XAxis")]
    public Color XAxisLabelColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.LabelColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.LabelColor = value;
      }
    }

    [Description("")]
    [Category("XAxis")]
    public int XAxisLabelOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.LabelOffset;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.LabelOffset = value;
      }
    }

    [Description("")]
    [Category("XAxis")]
    public string XAxisLabelFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.LabelFormat;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.LabelFormat = value;
      }
    }

    [Description("")]
    [Category("XAxis")]
    public EAxisLabelAlignment XAxisLabelAlignment
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisBottom.LabelAlignment;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisBottom.LabelAlignment = value;
      }
    }

    [Category("YAxis")]
    [Description("")]
    public EAxisType YAxisType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.Type;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.Type = value;
        this.fAxisRight.Type = value;
      }
    }

    [Category("YAxis")]
    [Description("")]
    public EAxisPosition YAxisPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.Position;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.Position = value;
      }
    }

    [Category("YAxis")]
    [Description("")]
    public bool YAxisMajorTicksEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.MajorTicksEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.MajorTicksEnabled = value;
        this.fAxisRight.MajorTicksEnabled = value;
      }
    }

    [Category("YAxis")]
    [Description("")]
    public bool YAxisMinorTicksEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.MinorTicksEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.MinorTicksEnabled = value;
        this.fAxisRight.MinorTicksEnabled = value;
      }
    }

    [Description("")]
    [Category("YAxis")]
    public bool YAxisTitleEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.TitleEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.TitleEnabled = value;
      }
    }

    [Description("")]
    [Category("YAxis")]
    public string YAxisTitle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.Title;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.Title = value;
        this.fAxisRight.Title = value;
      }
    }

    [Description("")]
    [Category("YAxis")]
    public Font YAxisTitleFont
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.TitleFont;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.TitleFont = value;
        this.fAxisRight.TitleFont = value;
      }
    }

    [Category("YAxis")]
    [Description("")]
    public Color YAxisTitleColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.TitleColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.TitleColor = value;
        this.fAxisRight.TitleColor = value;
      }
    }

    [Category("YAxis")]
    [Description("")]
    public int YAxisTitleOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.TitleOffset;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.TitleOffset = value;
        this.fAxisRight.TitleOffset = value;
      }
    }

    [Description("")]
    [Category("YAxis")]
    public EAxisTitlePosition YAxisTitlePosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.TitlePosition;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.TitlePosition = value;
        this.fAxisRight.TitlePosition = value;
      }
    }

    [Description("")]
    [Category("YAxis")]
    public bool YAxisLabelEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.LabelEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.LabelEnabled = value;
      }
    }

    [Description("")]
    [Category("YAxis")]
    public Font YAxisLabelFont
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.LabelFont;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.LabelFont = value;
        this.fAxisRight.LabelFont = value;
      }
    }

    [Category("YAxis")]
    [Description("")]
    public Color YAxisLabelColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.LabelColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.LabelColor = value;
        this.fAxisRight.LabelColor = value;
      }
    }

    [Category("YAxis")]
    [Description("")]
    public int YAxisLabelOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.LabelOffset;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.LabelOffset = value;
        this.fAxisRight.LabelOffset = value;
      }
    }

    [Category("YAxis")]
    [Description("")]
    public string YAxisLabelFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.LabelFormat;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.LabelFormat = value;
        this.fAxisRight.LabelFormat = value;
      }
    }

    [Description("")]
    [Category("YAxis")]
    public EAxisLabelAlignment YAxisLabelAlignment
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fAxisLeft.LabelAlignment;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fAxisLeft.LabelAlignment = value;
        this.fAxisRight.LabelAlignment = value;
      }
    }

    [Browsable(false)]
    public TLegend Legend
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLegend;
      }
    }

    [Description("")]
    [Category("Legend")]
    public bool LegendEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLegendEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fLegendEnabled = value;
      }
    }

    [Description("")]
    [Category("Legend")]
    public ELegendPosition LegendPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLegendPosition;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fLegendPosition = value;
      }
    }

    [Category("Legend")]
    [Description("")]
    public int LegendOffsetX
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLegendOffsetX;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fLegendOffsetX = value;
      }
    }

    [Description("")]
    [Category("Legend")]
    public int LegendOffsetY
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLegendOffsetY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fLegendOffsetY = value;
      }
    }

    [Category("Legend")]
    [Description("")]
    public bool LegendBorderEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLegend.BorderEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fLegend.BorderEnabled = value;
      }
    }

    [Description("")]
    [Category("Legend")]
    public Color LegendBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLegend.BorderColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fLegend.BorderColor = value;
      }
    }

    [Category("Legend")]
    [Description("")]
    public Color LegendBackColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLegend.BackColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fLegend.BackColor = value;
      }
    }

    [Description("")]
    [Category("Border")]
    public bool BorderEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fBorderEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fBorderEnabled = value;
      }
    }

    [Description("")]
    [Category("Border")]
    public Color BorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fBorderColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fBorderColor = value;
      }
    }

    [Description("")]
    [Category("Border")]
    public int BorderWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fBorderWidth;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fBorderWidth = value;
      }
    }

    [Description("")]
    [Category("Mouse")]
    public bool MouseZoomEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMouseZoomEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMouseZoomEnabled = value;
      }
    }

    [Description("")]
    [Category("Mouse")]
    public bool MouseZoomXAxisEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMouseZoomXAxisEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMouseZoomXAxisEnabled = value;
      }
    }

    [Description("")]
    [Category("Mouse")]
    public bool MouseZoomYAxisEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMouseZoomYAxisEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMouseZoomYAxisEnabled = value;
      }
    }

    [Description("")]
    [Category("Mouse")]
    public bool MouseUnzoomEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMouseUnzoomEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMouseUnzoomEnabled = value;
      }
    }

    [Description("")]
    [Category("Mouse")]
    public bool MouseUnzoomXAxisEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMouseUnzoomXAxisEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMouseUnzoomXAxisEnabled = value;
      }
    }

    [Category("Mouse")]
    [Description("")]
    public bool MouseUnzoomYAxisEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMouseUnzoomYAxisEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMouseUnzoomYAxisEnabled = value;
      }
    }

    [Category("Mouse")]
    [Description("")]
    public bool MouseMoveContentEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMouseMoveContentEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMouseMoveContentEnabled = value;
      }
    }

    [Category("Mouse")]
    [Description("")]
    public bool MouseMovePrimitiveEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMouseMovePrimitiveEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMouseMovePrimitiveEnabled = value;
      }
    }

    [Category("Mouse")]
    [Description("")]
    public bool MouseDeletePrimitiveEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMouseDeletePrimitiveEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMouseDeletePrimitiveEnabled = value;
      }
    }

    [Category("Mouse")]
    [Description("")]
    public bool MousePadPropertiesEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMousePadPropertiesEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMousePadPropertiesEnabled = value;
      }
    }

    [Category("Mouse")]
    [Description("")]
    public bool MousePrimitivePropertiesEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMousePrimitivePropertiesEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMousePrimitivePropertiesEnabled = value;
      }
    }

    [Category("Mouse")]
    [Description("")]
    public bool MouseContextMenuEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMouseContextMenuEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMouseContextMenuEnabled = value;
      }
    }

    [Category("Mouse")]
    [Description("Enable or disable mouse wheel")]
    public bool MouseWheelEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMouseWheelEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMouseWheelEnabled = value;
      }
    }

    [Description("")]
    [Category("Mouse")]
    public double MouseWheelSensitivity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMouseWheelSensitivity;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMouseWheelSensitivity = value;
      }
    }

    [Category("Mouse")]
    [Description("")]
    public EMouseWheelMode MouseWheelMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMouseWheelMode;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMouseWheelMode = value;
      }
    }

    [Browsable(false)]
    public IChartTransformation Transformation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fTransformation;
      }
    }

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
        double Y1 = this.fXMin + this.CalculateRealQuantityOfTicks_Right(this.fXMin, this.fXMax);
        double Y2 = this.fAxisBottom.Min + this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.fAxisBottom.Max);
        if (this.fTransformationType == ETransformationType.Empty)
          this.fTransformation = (IChartTransformation) new TEmptyTransformation();
        if (this.fTransformationType == ETransformationType.Intraday)
          this.fTransformation = (IChartTransformation) new TIntradayTransformation();
        this.fXMax = Y1 - this.CalculateNotInSessionTicks(this.fXMin, Y1);
        this.fAxisBottom.Max = Y2 - this.CalculateNotInSessionTicks(this.fAxisBottom.Min, Y2);
        this.Update();
      }
    }

    [Description("")]
    [Category("Transformation")]
    public bool SessionGridEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.fTransformationType == ETransformationType.Intraday)
          return ((TIntradayTransformation) this.Transformation).SessionGridEnabled;
        else
          return false;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.fTransformationType != ETransformationType.Intraday)
          return;
        ((TIntradayTransformation) this.Transformation).SessionGridEnabled = value;
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
      }
    }

    [Category("Transformation")]
    [Description("")]
    public TimeSpan SessionStart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.fTransformationType == ETransformationType.Intraday)
          return new TimeSpan(((TIntradayTransformation) this.fTransformation).FirstSessionTick);
        else
          return new TimeSpan(0, 0, 0, 0);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        double Y1 = this.fXMin + this.CalculateRealQuantityOfTicks_Right(this.fXMin, this.fXMax);
        double Y2 = this.fAxisBottom.Min + this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.fAxisBottom.Max);
        if (this.fTransformationType == ETransformationType.Intraday)
          ((TIntradayTransformation) this.fTransformation).FirstSessionTick = value.Ticks;
        this.fXMax = Y1 - this.CalculateNotInSessionTicks(this.fXMin, Y1);
        this.fAxisBottom.Max = Y2 - this.CalculateNotInSessionTicks(this.fAxisBottom.Min, Y2);
        this.Update();
      }
    }

    [Description("")]
    [Category("Transformation")]
    public TimeSpan SessionEnd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.fTransformationType == ETransformationType.Intraday)
          return new TimeSpan(((TIntradayTransformation) this.fTransformation).LastSessionTick);
        else
          return new TimeSpan(0, 24, 0, 0);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        double Y1 = this.fXMin + this.CalculateRealQuantityOfTicks_Right(this.fXMin, this.fXMax);
        double Y2 = this.fAxisBottom.Min + this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.fAxisBottom.Max);
        if (this.fTransformationType == ETransformationType.Intraday)
          ((TIntradayTransformation) this.fTransformation).LastSessionTick = value.Ticks;
        this.fXMax = Y1 - this.CalculateNotInSessionTicks(this.fXMin, Y1);
        this.fAxisBottom.Max = Y2 - this.CalculateNotInSessionTicks(this.fAxisBottom.Min, Y2);
        this.Update();
      }
    }

    [Browsable(false)]
    public bool Monitored
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMonitored;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMonitored = value;
        if (this.fMonitored)
          Pad.NewTick += new NewTickEventHandler(this.H0Y9o0pgX);
        else
          Pad.NewTick -= new NewTickEventHandler(this.H0Y9o0pgX);
      }
    }

    [Browsable(false)]
    public int WindowSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fWindowSize;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fWindowSize = value;
      }
    }

    [Browsable(false)]
    public int UpdateInterval
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fUpdateInterval;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fUpdateInterval = value;
      }
    }

    public static event NewTickEventHandler NewTick;

    public event ZoomEventHandler Zoom;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Pad()
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Pad(Chart Chart)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fChart = Chart;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Pad(Chart Chart, double X1, double Y1, double X2, double Y2)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fChart = Chart;
      this.fCanvasX1 = X1;
      this.fCanvasX2 = X2;
      this.fCanvasY1 = Y1;
      this.fCanvasY2 = Y2;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetLastTickTime()
    {
      this.fLastTickTime = 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init()
    {
      this.fPrimitives = new ArrayList();
      Chart.Pad = this;
      this.VN5zSfcsG = new Pad.ut9JGY6223LcaEWEIv(this);
      this.fBackColor = Color.LightGray;
      this.fForeColor = Color.White;
      this.fX1 = 0;
      this.fX2 = 1;
      this.fY1 = 0;
      this.fY2 = 1;
      this.fWidth = this.fChart.ClientSize.Width;
      this.fHeight = this.fChart.ClientSize.Height;
      this.fClientX = 10;
      this.fClientY = 10;
      this.fClientWidth = 0;
      this.fClientHeight = 0;
      this.fMarginLeft = 10;
      this.fMarginRight = 20;
      this.fMarginTop = 10;
      this.fMarginBottom = 10;
      this.fTitle = new TTitle(this, "");
      this.fTitleEnabled = true;
      this.fTitleOffsetX = 5;
      this.fTitleOffsetY = 5;
      this.fTransformation = (IChartTransformation) new TIntradayTransformation();
      this.fTransformationType = ETransformationType.Empty;
      this.fSessionGridColor = Color.Blue;
      this.fAxisLeft = new Axis(this, EAxisPosition.Left);
      this.fAxisRight = new Axis(this, EAxisPosition.Right);
      this.fAxisTop = new Axis(this, EAxisPosition.Top);
      this.fAxisBottom = new Axis(this, EAxisPosition.Bottom);
      this.fAxisRight.LabelEnabled = false;
      this.fAxisRight.TitleEnabled = false;
      this.fAxisTop.LabelEnabled = false;
      this.fAxisTop.TitleEnabled = false;
      this.fLegend = new TLegend(this);
      this.fLegendEnabled = false;
      this.fLegendPosition = ELegendPosition.TopRight;
      this.fLegendOffsetX = 5;
      this.fLegendOffsetY = 5;
      this.fBorderEnabled = true;
      this.fBorderColor = Color.Black;
      this.fBorderWidth = 1;
      this.SetRange(0.0, 100.0, 0.0, 100.0);
      this.fGraphics = (Graphics) null;
      this.fOnAxis = false;
      this.fOnPrimitive = false;
      this.fMouseDown = false;
      this.fMouseDownX = 0;
      this.fMouseDownY = 0;
      this.fOutlineEnabled = false;
      this.fWindowSize = 600;
      this.fLastTickTime = 0;
      this.fUpdateInterval = 1;
      this.fLastUpdateDateTime = DateTime.Now;
      this.Monitored = false;
      this.fUpdating = false;
      this.fMouseZoomEnabled = true;
      this.fMouseZoomXAxisEnabled = true;
      this.fMouseZoomYAxisEnabled = true;
      this.fMouseUnzoomEnabled = true;
      this.fMouseUnzoomXAxisEnabled = true;
      this.fMouseUnzoomYAxisEnabled = true;
      this.fMouseMoveContentEnabled = true;
      this.fMouseMovePrimitiveEnabled = true;
      this.fMouseDeletePrimitiveEnabled = true;
      this.fMousePadPropertiesEnabled = true;
      this.fMousePrimitivePropertiesEnabled = true;
      this.fMouseContextMenuEnabled = true;
      this.fMouseWheelEnabled = true;
      this.fMouseWheelSensitivity = 0.1;
      this.fMouseWheelMode = EMouseWheelMode.ZoomX;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void yxJj9CwXy()
    {
      if (this.KtXo3eo8yY != null)
        return;
      this.KtXo3eo8yY = new ContextMenu();
      this.rlboC951ES = new MenuItem();
      this.kpXo6pj5Cs = new MenuItem();
      MenuItem menuItem = new MenuItem();
      this.KtXo3eo8yY.MenuItems.AddRange(new MenuItem[3]
      {
        this.rlboC951ES,
        menuItem,
        this.kpXo6pj5Cs
      });
      this.rlboC951ES.Index = 0;
      this.rlboC951ES.Text = RA7k7APgXK5aSsnmA9.qBCYFXVOKp(152);
      this.rlboC951ES.Click += new EventHandler(this.ruLesQ5Xv);
      menuItem.Index = 1;
      menuItem.Text = RA7k7APgXK5aSsnmA9.qBCYFXVOKp(168);
      this.kpXo6pj5Cs.Index = 2;
      this.kpXo6pj5Cs.Text = RA7k7APgXK5aSsnmA9.qBCYFXVOKp(174);
      this.kpXo6pj5Cs.Click += new EventHandler(this.hMr7kanRQ);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetCanvas(double X1, double Y1, double X2, double Y2, int Width, int Height)
    {
      this.fCanvasX1 = X1;
      this.fCanvasX2 = X2;
      this.fCanvasY1 = Y1;
      this.fCanvasY2 = Y2;
      this.SetCanvas(Width, Height);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetCanvas(double X1, double Y1, double X2, double Y2)
    {
      this.fCanvasX1 = X1;
      this.fCanvasX2 = X2;
      this.fCanvasY1 = Y1;
      this.fCanvasY2 = Y2;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetCanvas(int Width, int Height)
    {
      this.fX1 = (int) ((double) Width * this.fCanvasX1);
      this.fX2 = (int) ((double) Width * this.fCanvasX2);
      this.fY1 = (int) ((double) Height * this.fCanvasY1);
      this.fY2 = (int) ((double) Height * this.fCanvasY2);
      this.fWidth = this.fX2 - this.fX1;
      this.fHeight = this.fY2 - this.fY1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRangeX(double XMin, double XMax)
    {
      this.fXMin = XMin;
      this.fXMax = XMax - this.CalculateNotInSessionTicks(XMin, XMax);
      this.fAxisBottom.SetRange(this.fXMin, this.fXMax);
      this.fAxisTop.SetRange(this.fXMin, this.fXMax);
      this.VN5zSfcsG.DmboYWaZgW(this.fXMin, this.fXMax);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRangeX(DateTime XMin, DateTime XMax)
    {
      this.SetRangeX((double) XMin.Ticks, (double) XMax.Ticks);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRangeY(double YMin, double YMax)
    {
      this.fYMin = YMin;
      this.fYMax = YMax;
      this.fAxisLeft.SetRange(this.fYMin, this.fYMax);
      this.fAxisRight.SetRange(this.fYMin, this.fYMax);
      this.VN5zSfcsG.ebUoB1tdv8(this.fYMin, this.fYMax);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRange(double XMin, double XMax, double YMin, double YMax)
    {
      this.fXMin = XMin;
      this.fXMax = XMax - this.CalculateNotInSessionTicks(XMin, XMax);
      this.fYMin = YMin;
      this.fYMax = YMax;
      this.fAxisBottom.SetRange(this.fXMin, this.fXMax);
      this.fAxisTop.SetRange(this.fXMin, this.fXMax);
      this.fAxisLeft.SetRange(this.fYMin, this.fYMax);
      this.fAxisRight.SetRange(this.fYMin, this.fYMax);
      this.VN5zSfcsG.iGDoKyjUVx(this.fXMin, this.fXMax, this.fYMin, this.fYMax);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRange(DateTime XMin, DateTime XMax, double YMin, double YMax)
    {
      this.SetRange((double) XMin.Ticks, (double) XMax.Ticks, YMin, YMax);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRange(string XMin, string XMax, double YMin, double YMax)
    {
      this.SetRange((double) DateTime.Parse(XMin).Ticks, (double) DateTime.Parse(XMax).Ticks, YMin, YMax);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsInRange(double X, double Y)
    {
      return X >= this.XMin && X <= this.XMin + this.CalculateRealQuantityOfTicks_Right(this.XMin, this.XMax) && (Y >= this.YMin && Y <= this.YMax);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnZoomX()
    {
      this.fAxisBottom.UnZoom();
      this.fAxisTop.UnZoom();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnZoomY()
    {
      this.fAxisLeft.UnZoom();
      this.fAxisRight.UnZoom();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnZoom()
    {
      this.fAxisBottom.SetRange(this.fXMin, this.fXMax);
      this.fAxisTop.SetRange(this.fXMin, this.fXMax);
      this.fAxisLeft.SetRange(this.fYMin, this.fYMax);
      this.fAxisRight.SetRange(this.fYMin, this.fYMax);
      this.fAxisBottom.Zoomed = false;
      this.fAxisTop.Zoomed = false;
      this.fAxisLeft.Zoomed = false;
      this.fAxisRight.Zoomed = false;
      if (this.fChart.GroupZoomEnabled)
        return;
      this.Update();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetNextGridDivision(double FirstTick, double PrevMajor, int MajorCount, EGridSize GridSize)
    {
      return this.fTransformation.GetNextGridDivision(FirstTick, PrevMajor, MajorCount, GridSize);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CalculateRealQuantityOfTicks_Right(double X, double Y)
    {
      return this.fTransformation.CalculateRealQuantityOfTicks_Right(X, Y);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CalculateRealQuantityOfTicks_Left(double X, double Y)
    {
      return this.fTransformation.CalculateRealQuantityOfTicks_Left(X, Y);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetFirstGridDivision(ref EGridSize GridSize, ref double Min, ref double Max, ref DateTime FirstDateTime)
    {
      this.fTransformation.GetFirstGridDivision(ref GridSize, ref Min, ref Max, ref FirstDateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CalculateNotInSessionTicks(double X, double Y)
    {
      return this.fTransformation.CalculateNotInSessionTicks(X, Y);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int ClientX(double WorldX)
    {
      return (int) ((double) this.fClientX + (WorldX - this.XMin - this.CalculateNotInSessionTicks(this.XMin, WorldX)) * ((double) this.fClientWidth / (this.XMax - this.XMin)));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int ClientY(double WorldY)
    {
      return (int) ((double) this.fClientY + (double) this.fClientHeight * (1.0 - (WorldY - this.YMin) / (this.YMax - this.YMin)));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int ClientX()
    {
      return this.fClientX;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int ClientY()
    {
      return this.fClientY;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int ClientHeight()
    {
      return this.fClientHeight;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int ClientWidth()
    {
      return this.fClientWidth;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double WorldX(int ClientX)
    {
      return this.fAxisBottom.Min + this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.XMin + (double) (ClientX - this.fClientX) / (double) this.fClientWidth * (this.XMax - this.XMin));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double WorldY(int ClientY)
    {
      return this.YMin + (1.0 - (double) (ClientY - this.fClientY) / (double) this.fClientHeight) * (this.YMax - this.YMin);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(IDrawable Primitive)
    {
      this.fPrimitives.Add((object) Primitive);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(IDrawable Primitive)
    {
      this.fPrimitives.Remove((object) Primitive);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.fPrimitives.Clear();
      this.fLegend.Items.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Graphics GetGraphics()
    {
      if (Chart.Pad != null)
        return Chart.Pad.Graphics;
      else
        return (Graphics) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Update()
    {
      if (this.fUpdating)
        return;
      this.fUpdating = true;
      this.fChart.UpdatePads();
      this.fUpdating = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Update(Graphics Graphics)
    {
      double val1_1 = double.MaxValue;
      double val1_2 = double.MinValue;
      double val1_3 = double.MaxValue;
      double val1_4 = double.MinValue;
      bool flag1 = false;
      bool flag2 = false;
      try
      {
        foreach (IDrawable drawable in this.fPrimitives)
        {
          if (drawable is IZoomable)
          {
            IZoomable zoomable = (IZoomable) drawable;
            if (zoomable.IsPadRangeX())
            {
              PadRange padRangeX = zoomable.GetPadRangeX(this);
              if (padRangeX.IsValid)
              {
                val1_1 = Math.Min(val1_1, padRangeX.Min);
                val1_2 = Math.Max(val1_2, padRangeX.Max);
                flag1 = true;
              }
            }
            if (zoomable.IsPadRangeY())
            {
              double max = this.fAxisBottom.Max;
              double num = this.fXMax;
              this.fAxisBottom.Max = this.fAxisBottom.Min + this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.fAxisBottom.Max);
              this.fXMax = this.fAxisBottom.Max;
              PadRange padRangeY = zoomable.GetPadRangeY(this);
              if (padRangeY.IsValid)
              {
                val1_3 = Math.Min(val1_3, padRangeY.Min);
                val1_4 = Math.Max(val1_4, padRangeY.Max);
                flag2 = true;
              }
              this.fAxisBottom.Max = max;
              this.fXMax = num;
            }
          }
        }
      }
      catch
      {
      }
      if (flag1)
        this.SetRangeX(val1_1 - (val1_2 - val1_1) / 20.0, val1_2 + (val1_2 - val1_1) / 20.0);
      if (flag2)
        this.SetRangeY(val1_3 - (val1_4 - val1_3) / 20.0, val1_4 + (val1_4 - val1_3) / 20.0);
      this.fGraphics = Graphics;
      this.fGraphics.Clip = new Region(new Rectangle(this.fX1, this.fY1, this.fWidth + 1, this.fHeight + 1));
      this.fGraphics.FillRectangle((Brush) new SolidBrush(this.fBackColor), this.fX1, this.fY1, this.fWidth, this.fHeight);
      if (this.fBorderEnabled)
      {
        int height = this.fHeight;
        int width = this.fWidth;
        int num1 = this.fChart.ClientRectangle.Height - this.fY1 - 1;
        int num2 = this.fChart.ClientRectangle.Width - this.fX1 - 1;
        if (this.fHeight > num1)
          height = num1;
        if (this.fWidth > num2)
          width = num2;
        this.fGraphics.DrawRectangle(new Pen(this.fBorderColor)
        {
          Width = (float) this.fBorderWidth
        }, this.fX1, this.fY1, width, height);
      }
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      int num6 = 0;
      int num7 = 0;
      if (this.fTitleEnabled)
      {
        switch (this.fTitle.Position)
        {
          case ETitlePosition.Left:
            num3 = this.Title.Height + this.fTitleOffsetY;
            break;
          case ETitlePosition.Right:
            num3 = this.Title.Height + this.fTitleOffsetY;
            break;
          case ETitlePosition.Centre:
            num3 = this.Title.Height + this.fTitleOffsetY;
            break;
          case ETitlePosition.InsideLeft:
            num3 = 0;
            break;
          case ETitlePosition.InsideRight:
            num3 = 0;
            break;
          case ETitlePosition.InsideCentre:
            num3 = 0;
            break;
        }
      }
      if (this.fAxisBottom.Enabled)
        num4 = this.fAxisBottom.Height;
      if (this.fAxisTop.Enabled)
        num5 = this.fAxisTop.Height;
      if (this.fAxisRight.Enabled)
        num6 = this.fAxisRight.Width;
      if (this.fAxisLeft.Enabled)
        num7 = this.fAxisLeft.Width;
      this.fClientX = this.fX1 + num7 + this.fMarginLeft;
      this.fClientY = this.fY1 + num3 + num5 + this.fMarginTop;
      this.fClientWidth = this.fWidth - num7 - num6 - this.fMarginLeft - this.fMarginRight;
      this.fClientHeight = this.fHeight - num3 - num5 - num4 - this.fMarginTop - this.fMarginBottom;
      this.fGraphics.FillRectangle((Brush) new SolidBrush(this.fForeColor), this.fClientX, this.fClientY, this.fClientWidth, this.fClientHeight);
      if (this.fAxisBottom.Enabled)
      {
        this.fAxisBottom.SetLocation((double) this.fClientX, (double) (this.fClientY + this.fClientHeight), (double) (this.fClientX + this.fClientWidth), (double) (this.fClientY + this.fClientHeight));
        this.fAxisBottom.Paint();
      }
      if (this.fAxisLeft.Enabled)
      {
        this.fGraphics.Clip = new Region(new Rectangle(this.fX1, this.fY1, this.fWidth, this.fHeight));
        this.fAxisLeft.SetLocation((double) this.fClientX, (double) this.fClientY, (double) this.fClientX, (double) (this.fClientY + this.fClientHeight));
        this.fAxisLeft.Paint();
      }
      if (this.fAxisTop.Enabled)
      {
        this.fAxisTop.SetLocation((double) this.fClientX, (double) this.fClientY, (double) (this.fClientX + this.fClientWidth), (double) this.fClientY);
        this.fAxisTop.Paint();
      }
      if (this.fAxisRight.Enabled)
      {
        this.fAxisRight.SetLocation((double) (this.fClientX + this.fClientWidth), (double) this.fClientY, (double) (this.fClientX + this.fClientWidth), (double) (this.fClientY + this.fClientHeight));
        this.fAxisRight.Paint();
      }
      this.fGraphics.Clip = new Region(new Rectangle(this.fClientX + 1, this.fClientY + 1, this.fClientWidth - 1, this.fClientHeight - 1));
      try
      {
        foreach (IDrawable drawable in this.fPrimitives)
          drawable.Paint(this, this.XMin, this.XMin + this.CalculateRealQuantityOfTicks_Right(this.XMin, this.XMax), this.YMin, this.YMax);
      }
      catch
      {
      }
      if (this.fOutlineEnabled)
        this.fGraphics.DrawRectangle(new Pen(Color.Green), this.fOutlineRectangle);
      if (this.fTitleEnabled)
      {
        switch (this.fTitle.Position)
        {
          case ETitlePosition.Left:
            this.fGraphics.Clip = new Region(new Rectangle(this.fX1, this.fY1, this.fWidth, this.fHeight));
            this.fTitle.Y = this.fY1 + this.fMarginTop;
            this.fTitle.X = this.fClientX + this.fTitleOffsetX;
            break;
          case ETitlePosition.Right:
            this.fGraphics.Clip = new Region(new Rectangle(this.fX1, this.fY1, this.fWidth, this.fHeight));
            this.fTitle.Y = this.fY1 + this.fMarginTop;
            this.fTitle.X = this.fClientX + this.fClientWidth - this.fTitle.Width - this.fTitleOffsetX;
            break;
          case ETitlePosition.Centre:
            this.fGraphics.Clip = new Region(new Rectangle(this.fX1, this.fY1, this.fWidth, this.fHeight));
            this.fTitle.Y = this.fY1 + this.fMarginTop;
            this.fTitle.X = this.fClientX + this.fClientWidth / 2 - this.fTitle.Width / 2 + this.fTitleOffsetX;
            break;
          case ETitlePosition.InsideLeft:
            this.fTitle.Y = this.fClientY + this.fTitleOffsetY;
            this.fTitle.X = this.fClientX + this.fTitleOffsetX;
            this.fGraphics.FillRectangle((Brush) new SolidBrush(this.fForeColor), this.fTitle.X, this.fTitle.Y, this.fTitle.Width, this.fTitle.Height);
            break;
          case ETitlePosition.InsideRight:
            this.fTitle.Y = this.fClientY + this.fTitleOffsetY;
            this.fTitle.X = this.fClientX + this.fClientWidth - this.fTitle.Width - this.fTitleOffsetX;
            this.fGraphics.FillRectangle((Brush) new SolidBrush(this.fForeColor), this.fTitle.X, this.fTitle.Y, this.fTitle.Width, this.fTitle.Height);
            break;
          case ETitlePosition.InsideCentre:
            this.fTitle.Y = this.fClientY + this.fTitleOffsetY;
            this.fTitle.X = this.fClientX + this.fClientWidth / 2 - this.fTitle.Width / 2 + this.fTitleOffsetX;
            this.fGraphics.FillRectangle((Brush) new SolidBrush(this.fForeColor), this.fTitle.X, this.fTitle.Y, this.fTitle.Width, this.fTitle.Height);
            break;
        }
        this.fTitle.Paint();
      }
      if (!this.fLegendEnabled)
        return;
      switch (this.fLegendPosition)
      {
        case ELegendPosition.TopRight:
          this.fLegend.X = this.fClientX + this.fClientWidth - this.fLegendOffsetX - this.fLegend.Width;
          this.fLegend.Y = this.fClientY + this.fLegendOffsetY;
          break;
        case ELegendPosition.TopLeft:
          this.fLegend.X = this.fClientX + this.fLegendOffsetX;
          this.fLegend.Y = this.fClientY + this.fLegendOffsetY;
          break;
        case ELegendPosition.BottomRight:
          this.fLegend.X = this.fClientX + this.fClientWidth - this.fLegendOffsetX - this.fLegend.Width;
          this.fLegend.Y = this.fClientY + this.fClientHeight - this.fLegendOffsetY - this.fLegend.Height;
          break;
        case ELegendPosition.BottomLeft:
          this.fLegend.X = this.fClientX + this.fLegendOffsetX;
          this.fLegend.Y = this.fClientY + this.fClientHeight - this.fLegendOffsetY - this.fLegend.Height;
          break;
      }
      this.fLegend.Paint();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawLine(Pen Pen, double X1, double Y1, double X2, double Y2, bool DoTransform)
    {
      if (DoTransform)
        this.fGraphics.DrawLine(Pen, this.ClientX(X1), this.ClientY(Y1), this.ClientX(X2), this.ClientY(Y2));
      else
        this.fGraphics.DrawLine(Pen, (int) X1, (int) Y1, (int) X2, (int) Y2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawVerticalTick(Pen Pen, double X, double Y, int Length)
    {
      try
      {
        this.fGraphics.DrawLine(Pen, this.ClientX(X), (int) Y, this.ClientX(X), (int) Y + Length);
      }
      catch (Exception ex)
      {
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawHorizontalTick(Pen Pen, double X, double Y, int Length)
    {
      try
      {
        this.fGraphics.DrawLine(Pen, (int) X, this.ClientY(Y), (int) X + Length, this.ClientY(Y));
      }
      catch (Exception ex)
      {
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawVerticalGrid(Pen Pen, double X)
    {
      this.fGraphics.DrawLine(Pen, this.ClientX(X), this.fClientY, this.ClientX(X), this.fClientY + this.fClientHeight);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawHorizontalGrid(Pen Pen, double Y)
    {
      this.fGraphics.DrawLine(Pen, this.fClientX, this.ClientY(Y), this.fClientX + this.fClientWidth, this.ClientY(Y));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawLine(Pen Pen, double X1, double Y1, double X2, double Y2)
    {
      this.DrawLine(Pen, X1, Y1, X2, Y2, true);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawRectangle(Pen Pen, double X, double Y, int Width, int Height)
    {
      this.fGraphics.DrawRectangle(Pen, this.ClientX(X), this.ClientY(Y), Width, Height);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawEllipse(Pen Pen, double X, double Y, int Width, int Height)
    {
      this.fGraphics.DrawEllipse(Pen, this.ClientX(X), this.ClientY(Y), Width, Height);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawBeziers(Pen Pen, PointF[] Points)
    {
      Point[] points = new Point[Points.Length];
      for (int index = 0; index < Points.Length; ++index)
      {
        PointF pointF = Points[index];
        points[index] = new Point(this.ClientX((double) pointF.X), this.ClientY((double) pointF.Y));
      }
      this.fGraphics.DrawBeziers(Pen, points);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawText(string Text, Font Font, Brush Brush, int X, int Y)
    {
      this.fGraphics.DrawString(Text, Font, Brush, (float) X, (float) Y);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool RUo1ChdWx([In] int obj0, [In] int obj1)
    {
      if (obj0 > this.fClientX && obj0 < this.fClientX + this.fClientWidth && obj1 > this.fClientY)
        return obj1 < this.fClientY + this.fClientHeight;
      else
        return false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void MouseMove(MouseEventArgs Event)
    {
      try
      {
        if (!this.fMouseDown)
        {
          double num1 = (this.fXMax - this.fXMin) / 100.0;
          double num2 = (this.fYMax - this.fYMin) / 100.0;
          double X = this.WorldX(Event.X);
          double Y = this.WorldY(Event.Y);
          bool flag = false;
          string caption = "";
          this.fSelectedPrimitive = (IDrawable) null;
          this.fSelectedPrimitiveDistance = (TDistance) null;
          this.fOnPrimitive = false;
          foreach (IDrawable drawable in this.fPrimitives)
          {
            TDistance tdistance = drawable.Distance(X, Y);
            if (tdistance != null && tdistance.dX < num1 && tdistance.dY < num2)
            {
              if (drawable.ToolTipEnabled)
              {
                if (caption != "")
                  caption = caption + RA7k7APgXK5aSsnmA9.qBCYFXVOKp(198);
                caption = caption + tdistance.ToolTipText;
                flag = true;
              }
              this.fOnPrimitive = true;
              this.fSelectedPrimitive = drawable;
              this.fSelectedPrimitiveDistance = tdistance;
            }
          }
          if (flag)
          {
            this.fChart.ToolTip.SetToolTip((Control) this.fChart, caption);
            this.fChart.ToolTip.Active = true;
          }
          else
            this.fChart.ToolTip.Active = false;
        }
        if (this.fMouseMovePrimitiveEnabled && this.fMouseDown && (this.fMouseDownButton == MouseButtons.Left && this.fOnPrimitive) && this.fSelectedPrimitive is IMovable)
        {
          double num1 = this.WorldX(Event.X);
          double num2 = this.WorldY(Event.Y);
          ((IMovable) this.fSelectedPrimitive).Move(this.fSelectedPrimitiveDistance.X, this.fSelectedPrimitiveDistance.Y, num1 - this.fSelectedPrimitiveDistance.X, num2 - this.fSelectedPrimitiveDistance.Y);
          this.fSelectedPrimitiveDistance.X = num1;
          this.fSelectedPrimitiveDistance.Y = num2;
          this.fOnPrimitive = true;
          this.Update();
        }
        if (this.fMouseZoomEnabled && this.fMouseDown && (this.fMouseDownButton == MouseButtons.Left && !this.fOnPrimitive))
        {
          int num1 = Math.Abs(this.fMouseDownX - Event.X);
          int num2 = Math.Abs(this.fMouseDownY - Event.Y);
          int num3 = this.fMouseDownX >= Event.X ? Event.X : this.fMouseDownX;
          int num4 = this.fMouseDownY >= Event.Y ? Event.Y : this.fMouseDownY;
          this.fOutlineRectangle.X = num3;
          this.fOutlineRectangle.Y = num4;
          this.fOutlineRectangle.Width = num1;
          this.fOutlineRectangle.Height = num2;
          this.Update();
        }
        if (this.fMouseMoveContentEnabled && this.fMouseDown && this.fMouseDownButton == MouseButtons.Right)
        {
          double num1 = (double) (this.fMouseDownX - Event.X) / (double) this.fClientWidth * (this.XMax - this.XMin);
          double num2 = this.WorldY(this.fMouseDownY) - this.WorldY(Event.Y);
          double num3 = num1 <= 0.0 ? this.CalculateRealQuantityOfTicks_Left(this.fAxisBottom.Min, this.fAxisBottom.Min + num1) : this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.fAxisBottom.Min + num1);
          this.fMouseDownX = Event.X;
          this.fMouseDownY = Event.Y;
          this.fAxisBottom.SetRange(this.fAxisBottom.Min + num3, this.fAxisBottom.Max + num3);
          this.fAxisTop.SetRange(this.fAxisTop.Min + num3, this.fAxisTop.Max + num3);
          this.fAxisLeft.SetRange(this.fAxisLeft.Min + num2, this.fAxisLeft.Max + num2);
          this.fAxisRight.SetRange(this.fAxisRight.Min + num2, this.fAxisRight.Max + num2);
          this.fAxisBottom.Zoomed = true;
          this.fAxisTop.Zoomed = true;
          this.fAxisLeft.Zoomed = true;
          this.fAxisRight.Zoomed = true;
          if (!this.fChart.GroupZoomEnabled)
            this.Update();
          this.EmitZoom(true);
        }
        else
        {
          this.fOnAxis = false;
          this.fAxisLeft.MouseMove(Event);
          this.fAxisBottom.MouseMove(Event);
          if (this.fAxisLeft.X1 - 10.0 <= (double) Event.X && this.fAxisLeft.X1 >= (double) Event.X && (this.fAxisLeft.Y1 <= (double) Event.Y && this.fAxisLeft.Y2 >= (double) Event.Y))
            this.fOnAxis = true;
          if (this.fAxisBottom.X1 <= (double) Event.X && this.fAxisBottom.X2 >= (double) Event.X && (this.fAxisBottom.Y1 <= (double) Event.Y && this.fAxisBottom.Y1 + 10.0 >= (double) Event.Y))
            this.fOnAxis = true;
          if (this.fOnAxis || this.fOnPrimitive)
          {
            if (!(Cursor.Current != Cursors.Hand))
              return;
            Cursor.Current = Cursors.Hand;
          }
          else
          {
            if (!(Cursor.Current != Cursors.Default))
              return;
            Cursor.Current = Cursors.Default;
          }
        }
      }
      catch
      {
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void MouseWheel(MouseEventArgs Event)
    {
      if (!this.fMouseWheelEnabled)
        return;
      double min = this.fAxisBottom.Min;
      double max = this.fAxisBottom.Max;
      switch (this.fMouseWheelMode)
      {
        case EMouseWheelMode.MoveX:
          double num1 = (double) Event.Delta / 120.0 * (this.fAxisBottom.Max - this.fAxisBottom.Min) * this.fMouseWheelSensitivity;
          double num2 = num1 <= 0.0 ? this.CalculateRealQuantityOfTicks_Left(this.fAxisBottom.Min, this.fAxisBottom.Min + num1) : this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.fAxisBottom.Min + num1);
          this.fAxisBottom.SetRange(this.fAxisBottom.Min + num2, this.fAxisBottom.Max + num2);
          this.fAxisTop.SetRange(this.fAxisTop.Min + num2, this.fAxisTop.Max + num2);
          this.fAxisBottom.Zoomed = true;
          this.fAxisTop.Zoomed = true;
          this.EmitZoom(true);
          break;
        case EMouseWheelMode.MoveY:
          double num3 = (double) Event.Delta / 120.0 * (this.fYMax - this.fYMin) * this.fMouseWheelSensitivity;
          this.fAxisLeft.SetRange(this.fAxisLeft.Min + num3, this.fAxisLeft.Max + num3);
          this.fAxisRight.SetRange(this.fAxisRight.Min + num3, this.fAxisRight.Max + num3);
          this.fAxisLeft.Zoomed = true;
          this.fAxisRight.Zoomed = true;
          this.EmitZoom(true);
          break;
        case EMouseWheelMode.ZoomX:
          double num4 = (double) Event.Delta / 120.0 * (this.fAxisBottom.Max - this.fAxisBottom.Min) * this.fMouseWheelSensitivity;
          double num5 = num4 <= 0.0 ? this.CalculateRealQuantityOfTicks_Left(this.fAxisBottom.Min, this.fAxisBottom.Min + num4) : this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.fAxisBottom.Min + num4);
          double num6 = num5 - num4;
          this.fAxisBottom.SetRange(this.fAxisBottom.Min + num5, this.fAxisBottom.Max + num6);
          this.fAxisTop.SetRange(this.fAxisTop.Min + num5, this.fAxisTop.Max + num6);
          this.fAxisBottom.Zoomed = true;
          this.fAxisTop.Zoomed = true;
          this.EmitZoom(true);
          break;
        case EMouseWheelMode.ZoomY:
          double num7 = (double) Event.Delta / 120.0 * (this.fYMax - this.fYMin) * this.fMouseWheelSensitivity;
          this.fAxisLeft.SetRange(this.fAxisLeft.Min + num7, this.fAxisLeft.Max);
          this.fAxisRight.SetRange(this.fAxisRight.Min + num7, this.fAxisRight.Max);
          this.fAxisLeft.Zoomed = true;
          this.fAxisRight.Zoomed = true;
          this.EmitZoom(true);
          break;
        case EMouseWheelMode.Zoom:
          double num8 = this.fAxisBottom.Min + this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.fAxisBottom.Max);
          double num9 = (double) Event.Delta / 120.0 * (num8 - this.fAxisBottom.Min) * this.fMouseWheelSensitivity;
          double num10 = (double) Event.Delta / 120.0 * (this.fYMax - this.fYMin) * this.fMouseWheelSensitivity;
          double num11 = this.WorldX(Event.X);
          double num12 = this.WorldY(Event.Y);
          double num13 = (num11 - this.fAxisBottom.Min) / (num8 - this.fAxisBottom.Min) * num9;
          double num14 = (num8 - num11) / (num8 - this.fAxisBottom.Min) * num9;
          double num15 = (num12 - this.fYMin) / (this.fYMax - this.fYMin) * num10;
          double num16 = (this.fYMax - num12) / (this.fYMax - this.fYMin) * num10;
          double num17 = num13 <= 0.0 ? this.CalculateRealQuantityOfTicks_Left(this.fAxisBottom.Min, this.fAxisBottom.Min + num13) : this.CalculateRealQuantityOfTicks_Right(this.fAxisBottom.Min, this.fAxisBottom.Min + num13);
          double num18 = -num17 + num13 + num14;
          this.fAxisBottom.SetRange(this.fAxisBottom.Min + num17, this.fAxisBottom.Max - num18);
          this.fAxisTop.SetRange(this.fAxisTop.Min + num17, this.fAxisTop.Max - num18);
          this.fAxisLeft.SetRange(this.fAxisLeft.Min + num15, this.fAxisLeft.Max - num16);
          this.fAxisRight.SetRange(this.fAxisRight.Min + num15, this.fAxisRight.Max - num16);
          this.fAxisBottom.Zoomed = true;
          this.fAxisTop.Zoomed = true;
          this.fAxisLeft.Zoomed = true;
          this.fAxisRight.Zoomed = true;
          this.EmitZoom(true);
          break;
      }
      if (this.fChart.GroupZoomEnabled)
        return;
      this.Update();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void MouseDown(MouseEventArgs Event)
    {
      if (this.RUo1ChdWx(Event.X, Event.Y))
      {
        this.fMouseDown = true;
        this.fMouseDownX = Event.X;
        this.fMouseDownY = Event.Y;
        this.fMouseDownButton = Event.Button;
        if (this.fMouseZoomEnabled && this.fMouseDownButton == MouseButtons.Left && this.fSelectedPrimitive == null)
          this.fOutlineEnabled = true;
        if (this.fMouseContextMenuEnabled && this.fMouseDownButton == MouseButtons.Right && this.fOnPrimitive)
        {
          this.yxJj9CwXy();
          this.rlboC951ES.Text = RA7k7APgXK5aSsnmA9.qBCYFXVOKp(206) + this.fSelectedPrimitive.GetType().Name;
          this.KtXo3eo8yY.Show((Control) this.fChart, new Point(Event.X, Event.Y));
        }
      }
      this.fAxisLeft.MouseDown(Event);
      this.fAxisBottom.MouseDown(Event);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void MouseUp(MouseEventArgs Event)
    {
      if (this.fMouseZoomEnabled && this.fMouseDown && (this.fMouseDownButton == MouseButtons.Left && !this.fOnPrimitive))
      {
        this.fOutlineEnabled = false;
        if (Math.Abs(this.fMouseDownX - Event.X) > 2 && Math.Abs(this.fMouseDownY - Event.Y) > 2)
        {
          double num1 = this.WorldX(this.fMouseDownX);
          double num2 = this.WorldX(Event.X);
          double num3 = this.WorldY(this.fMouseDownY);
          double num4 = this.WorldY(Event.Y);
          double num5;
          double Y;
          if (num1 < num2)
          {
            num5 = num1;
            Y = num2;
          }
          else
          {
            num5 = num2;
            Y = num1;
          }
          double Min;
          double Max1;
          if (num3 < num4)
          {
            Min = num3;
            Max1 = num4;
          }
          else
          {
            Min = num4;
            Max1 = num3;
          }
          double Max2 = Y - this.CalculateNotInSessionTicks(num5, Y);
          this.fAxisBottom.SetRange(num5, Max2);
          this.fAxisTop.SetRange(num5, Max2);
          this.fAxisLeft.SetRange(Min, Max1);
          this.fAxisRight.SetRange(Min, Max1);
          this.fAxisBottom.Zoomed = true;
          this.fAxisTop.Zoomed = true;
          this.fAxisLeft.Zoomed = true;
          this.fAxisRight.Zoomed = true;
          if (!this.fChart.GroupZoomEnabled)
            this.Update();
          this.EmitZoom(true);
        }
        this.fMouseDown = false;
      }
      else
      {
        this.fAxisLeft.MouseUp(Event);
        this.fAxisBottom.MouseUp(Event);
        this.fMouseDown = false;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void DoubleClick(int X, int Y)
    {
      if (this.RUo1ChdWx(X, Y))
      {
        if (this.fOnPrimitive)
        {
          if (!this.fMousePrimitivePropertiesEnabled)
            return;
          this.fChart.ToolTip.Active = false;
          int num = (int) new PadProperyForm((object) this.fSelectedPrimitive, this).ShowDialog();
        }
        else
        {
          if (!this.fMouseUnzoomEnabled || !this.AxisLeft.Zoomed && !this.AxisBottom.Zoomed)
            return;
          this.fOutlineEnabled = false;
          if (!this.fChart.GroupZoomEnabled)
            this.UnZoom();
          this.EmitZoom(false);
        }
      }
      else
      {
        if (!this.fMousePadPropertiesEnabled)
          return;
        int num = (int) new PadProperyForm((object) this, this).ShowDialog();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void EmitNewTick(DateTime datetime)
    {
      if (Pad.LFkonyUD7i == null)
        return;
      Pad.LFkonyUD7i((object) null, new NewTickEventArgs(datetime));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void H0Y9o0pgX([In] object obj0, [In] NewTickEventArgs obj1)
    {
      if (!this.fMonitored)
        return;
      int num1 = obj1.DateTime.Hour * 60 * 60 + obj1.DateTime.Minute * 60 + obj1.DateTime.Second;
      if (num1 - this.fLastTickTime < this.fUpdateInterval)
        return;
      DateTime dateTime = obj1.DateTime;
      double XMin = (double) dateTime.AddSeconds((double) -this.fWindowSize).Ticks;
      double num2 = (double) dateTime.Ticks;
      this.SetRangeX(XMin, num2 + (num2 - XMin) / 20.0);
      if ((DateTime.Now.Ticks - this.fLastUpdateDateTime.Ticks) / 1000000L > 1L)
      {
        if (!this.fChart.GroupZoomEnabled)
          this.Update();
        this.EmitZoom(true);
        this.fLastUpdateDateTime = DateTime.Now;
      }
      this.fLastTickTime = num1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EmitZoom(bool zoom)
    {
      if (this.EEZoo0ML5l == null)
        return;
      this.EEZoo0ML5l((object) null, new ZoomEventArgs(this.XMin, this.XMax, this.YMin, this.YMax, zoom));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ruLesQ5Xv([In] object obj0, [In] EventArgs obj1)
    {
      this.fPrimitives.Remove((object) this.fSelectedPrimitive);
      this.Update();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void hMr7kanRQ([In] object obj0, [In] EventArgs obj1)
    {
      int num = (int) new PadProperyForm((object) this.fSelectedPrimitive, this).ShowDialog();
    }

    [Serializable]
    private class ut9JGY6223LcaEWEIv
    {
      private Pad lAkoJHQf6Z;
      private Pad.ut9JGY6223LcaEWEIv.joI5FOYuNJBoRabUZ0 z7ooMblc8S;
      public Axis[] K7qoPqVA9V;
      private bool om3oGeDKrb;
      public object NHloRxNAlb;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ut9JGY6223LcaEWEIv([In] Pad obj0)
      {
        Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.lAkoJHQf6Z = obj0;
        this.z7ooMblc8S = new Pad.ut9JGY6223LcaEWEIv.joI5FOYuNJBoRabUZ0(obj0);
        this.K7qoPqVA9V = new Axis[3]
        {
          new Axis(obj0),
          new Axis(obj0),
          new Axis(obj0)
        };
        for (int index = 0; index < this.K7qoPqVA9V.Length; ++index)
        {
          this.K7qoPqVA9V[index].Max = 1.0;
          this.K7qoPqVA9V[index].Min = 0.0;
        }
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool uRWofxiHHl()
      {
        return this.om3oGeDKrb;
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public void jYkoFPyqxe([In] bool obj0)
      {
        this.om3oGeDKrb = obj0;
        if (obj0)
        {
          this.z7ooMblc8S.PmGoDE5hSO();
          this.lAkoJHQf6Z.ForeColor = this.lAkoJHQf6Z.BackColor;
          this.lAkoJHQf6Z.AntiAliasingEnabled = true;
        }
        else
          this.z7ooMblc8S.DXRo8T6EZV();
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void DmboYWaZgW([In] double obj0, [In] double obj1)
      {
        this.K7qoPqVA9V[0].SetRange(obj0, obj1);
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void ebUoB1tdv8([In] double obj0, [In] double obj1)
      {
        this.K7qoPqVA9V[1].SetRange(obj0, obj1);
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void YKPolLFPSm([In] double obj0, [In] double obj1)
      {
        this.K7qoPqVA9V[2].SetRange(obj0, obj1);
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void iGDoKyjUVx([In] double obj0, [In] double obj1, [In] double obj2, [In] double obj3)
      {
        this.DmboYWaZgW(obj0, obj1);
        this.ebUoB1tdv8(obj2, obj3);
      }

      [Serializable]
      private class joI5FOYuNJBoRabUZ0
      {
        private Pad Tk3oZwwj0J;
        private bool g1aoXGuoJh;
        private Axis a32og8iTgD;
        private Axis pnGobIDDW0;
        private Axis WvtoESv7Qa;
        private Axis MsZoH8cva0;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public joI5FOYuNJBoRabUZ0([In] Pad obj0)
        {
          Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          this.Tk3oZwwj0J = obj0;
          this.a32og8iTgD = new Axis(obj0);
          this.pnGobIDDW0 = new Axis(obj0);
          this.WvtoESv7Qa = new Axis(obj0);
          this.MsZoH8cva0 = new Axis(obj0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private void LPYoNcQSe0([In] Axis obj0, [In] Axis obj1)
        {
          obj0.LabelEnabled = obj1.LabelEnabled;
          obj0.MajorTicksEnabled = obj1.MajorTicksEnabled;
          obj0.MinorTicksEnabled = obj1.MinorTicksEnabled;
          obj0.GridEnabled = obj1.GridEnabled;
          obj0.MinorGridEnabled = obj1.MinorGridEnabled;
          obj0.SetRange(obj1.Min, obj1.Max);
          obj0.Enabled = obj1.Enabled;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private void FGko2VPp2g([In] Axis obj0)
        {
          obj0.LabelEnabled = false;
          obj0.MajorTicksEnabled = false;
          obj0.MinorTicksEnabled = false;
          obj0.GridEnabled = false;
          obj0.MinorGridEnabled = false;
          obj0.SetRange(0.0, 1.0);
          obj0.Enabled = false;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void fGloiQPWIx()
        {
          this.LPYoNcQSe0(this.a32og8iTgD, this.Tk3oZwwj0J.fAxisTop);
          this.LPYoNcQSe0(this.pnGobIDDW0, this.Tk3oZwwj0J.fAxisBottom);
          this.LPYoNcQSe0(this.WvtoESv7Qa, this.Tk3oZwwj0J.fAxisLeft);
          this.LPYoNcQSe0(this.MsZoH8cva0, this.Tk3oZwwj0J.fAxisRight);
          this.g1aoXGuoJh = true;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void PmGoDE5hSO()
        {
          this.fGloiQPWIx();
          this.FGko2VPp2g(this.Tk3oZwwj0J.AxisTop);
          this.FGko2VPp2g(this.Tk3oZwwj0J.AxisBottom);
          this.FGko2VPp2g(this.Tk3oZwwj0J.AxisLeft);
          this.FGko2VPp2g(this.Tk3oZwwj0J.AxisRight);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void DXRo8T6EZV()
        {
          if (!this.g1aoXGuoJh)
            return;
          this.LPYoNcQSe0(this.Tk3oZwwj0J.fAxisTop, this.a32og8iTgD);
          this.LPYoNcQSe0(this.Tk3oZwwj0J.fAxisBottom, this.pnGobIDDW0);
          this.LPYoNcQSe0(this.Tk3oZwwj0J.fAxisLeft, this.WvtoESv7Qa);
          this.LPYoNcQSe0(this.Tk3oZwwj0J.fAxisRight, this.MsZoH8cva0);
        }
      }
    }
  }
}
