// Type: SmartQuant.FinChart.Axis
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace FreeQuant.FinChart
{
  public class Axis
  {
    protected Chart chart;
    protected EAxisTitlePosition titlePosition;
    protected bool enabled;
    protected bool zoomed;
    protected Color color;
    protected bool titleEnabled;
    protected string title;
    protected Font titleFont;
    protected Color titleColor;
    protected int titleOffset;
    protected bool labelEnabled;
    protected Font labelFont;
    protected Color labelColor;
    protected int labelOffset;
    protected string labelFormat;
    protected EAxisLabelAlignment labelAlignment;
    protected bool gridEnabled;
    protected Color gridColor;
    protected float gridWidth;
    protected DashStyle gridDashStyle;
    protected bool minorGridEnabled;
    protected Color minorGridColor;
    protected float minorGridWidth;
    protected DashStyle minorGridDashStyle;
    protected bool majorTicksEnabled;
    protected Color majorTicksColor;
    protected float majorTicksWidth;
    protected int majorTicksLength;
    protected bool minorTicksEnabled;
    protected Color minorTicksColor;
    protected float minorTicksWidth;
    protected int minorTicksLength;
    protected double min;
    protected double max;
    protected int width;
    protected int height;

    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.color;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.color = value;
      }
    }

    public bool MajorTicksEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.majorTicksEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.majorTicksEnabled = value;
      }
    }

    public Color MajorTicksColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.majorTicksColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.majorTicksColor = value;
      }
    }

    public float MajorTicksWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.majorTicksWidth;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.majorTicksWidth = value;
      }
    }

    public int MajorTicksLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.majorTicksLength;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.majorTicksLength = value;
      }
    }

    public bool MinorTicksEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.minorTicksEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.minorTicksEnabled = value;
      }
    }

    public Color MinorTicksColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.minorTicksColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.minorTicksColor = value;
      }
    }

    public float MinorTicksWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.minorTicksWidth;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.minorTicksWidth = value;
      }
    }

    public int MinorTicksLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.minorTicksLength;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.minorTicksLength = value;
      }
    }

    public EAxisTitlePosition TitlePosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.titlePosition;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.titlePosition = value;
      }
    }

    public Font TitleFont
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.titleFont;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.titleFont = value;
      }
    }

    public Color TitleColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.titleColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.titleColor = value;
      }
    }

    public int TitleOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.titleOffset;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.titleOffset = value;
      }
    }

    public double Min
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.min;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.min = value;
      }
    }

    public double Max
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.max;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.max = value;
      }
    }

    public bool Enabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.enabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.enabled = value;
      }
    }

    public bool Zoomed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.zoomed;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.zoomed = value;
      }
    }

    public bool GridEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.gridEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.gridEnabled = value;
      }
    }

    public Color GridColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.gridColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.gridColor = value;
      }
    }

    public float GridWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.gridWidth;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.gridWidth = value;
      }
    }

    public DashStyle GridDashStyle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.gridDashStyle;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.gridDashStyle = value;
      }
    }

    public bool MinorGridEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.minorGridEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.minorGridEnabled = value;
      }
    }

    public Color MinorGridColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.minorGridColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.minorGridColor = value;
      }
    }

    public float MinorGridWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.minorGridWidth;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.minorGridWidth = value;
      }
    }

    public DashStyle MinorGridDashStyle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.minorGridDashStyle;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.minorGridDashStyle = value;
      }
    }

    public bool TitleEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.titleEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.titleEnabled = value;
      }
    }

    public bool LabelEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.labelEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.labelEnabled = value;
      }
    }

    public Font LabelFont
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.labelFont;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.labelFont = value;
      }
    }

    public Color LabelColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.labelColor;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.labelColor = value;
      }
    }

    public int LabelOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.labelOffset;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.labelOffset = value;
      }
    }

    public string LabelFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.labelFormat;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.labelFormat = value;
      }
    }

    public EAxisLabelAlignment LabelAlignment
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.labelAlignment;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.labelAlignment = value;
      }
    }

    public int Width
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.width;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.width = value;
      }
    }

    public int Height
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.height;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.height = value;
      }
    }

    public string Title
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.title;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.title = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Axis()
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
