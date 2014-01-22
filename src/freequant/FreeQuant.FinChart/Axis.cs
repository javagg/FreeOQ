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
     get
      {
        return this.color;
      }
      set
      {
        this.color = value;
      }
    }

    public bool MajorTicksEnabled
    {
      get
      {
        return this.majorTicksEnabled;
      }
      set
      {
        this.majorTicksEnabled = value;
      }
    }

    public Color MajorTicksColor
    {
      get
      {
        return this.majorTicksColor;
      }
      set
      {
        this.majorTicksColor = value;
      }
    }

    public float MajorTicksWidth
    {
      get
      {
        return this.majorTicksWidth;
      }
      set
      {
        this.majorTicksWidth = value;
      }
    }

    public int MajorTicksLength
    {
      get
      {
        return this.majorTicksLength;
      }
      set
      {
        this.majorTicksLength = value;
      }
    }

    public bool MinorTicksEnabled
    {
      get
      {
        return this.minorTicksEnabled;
      }
      set
      {
        this.minorTicksEnabled = value;
      }
    }

    public Color MinorTicksColor
    {
      get
      {
        return this.minorTicksColor;
      }
      set
      {
        this.minorTicksColor = value;
      }
    }

    public float MinorTicksWidth
    {
      get
      {
        return this.minorTicksWidth;
      }
      set
      {
        this.minorTicksWidth = value;
      }
    }

    public int MinorTicksLength
    {
      get
      {
        return this.minorTicksLength;
      }
      set
      {
        this.minorTicksLength = value;
      }
    }

    public EAxisTitlePosition TitlePosition
    {
      get
      {
        return this.titlePosition;
      }
      set
      {
        this.titlePosition = value;
      }
    }

    public Font TitleFont
    {
      get
      {
        return this.titleFont;
      }
      set
      {
        this.titleFont = value;
      }
    }

    public Color TitleColor
    {
      get
      {
        return this.titleColor;
      }
      set
      {
        this.titleColor = value;
      }
    }

    public int TitleOffset
    {
      get
      {
        return this.titleOffset;
      }
      set
      {
        this.titleOffset = value;
      }
    }

    public double Min
    {
      get
      {
        return this.min;
      }
      set
      {
        this.min = value;
      }
    }

    public double Max
    {
      get
      {
        return this.max;
      }
      set
      {
        this.max = value;
      }
    }

    public bool Enabled
    {
      get
      {
        return this.enabled;
      }
      set
      {
        this.enabled = value;
      }
    }

    public bool Zoomed
    {
      get
      {
        return this.zoomed;
      }
      set
      {
        this.zoomed = value;
      }
    }

    public bool GridEnabled
    {
      get
      {
        return this.gridEnabled;
      }
      set
      {
        this.gridEnabled = value;
      }
    }

    public Color GridColor
    {
      get
      {
        return this.gridColor;
      }
      set
      {
        this.gridColor = value;
      }
    }

    public float GridWidth
    {
      get
      {
        return this.gridWidth;
      }
      set
      {
        this.gridWidth = value;
      }
    }

    public DashStyle GridDashStyle
    {
      get
      {
        return this.gridDashStyle;
      }
      set
      {
        this.gridDashStyle = value;
      }
    }

    public bool MinorGridEnabled
    {
      get
      {
        return this.minorGridEnabled;
      }
      set
      {
        this.minorGridEnabled = value;
      }
    }

    public Color MinorGridColor
    {
      get
      {
        return this.minorGridColor;
      }
      set
      {
        this.minorGridColor = value;
      }
    }

    public float MinorGridWidth
    {
      get
      {
        return this.minorGridWidth;
      }
      set
      {
        this.minorGridWidth = value;
      }
    }

    public DashStyle MinorGridDashStyle
    {
      get
      {
        return this.minorGridDashStyle;
      }
      set
      {
        this.minorGridDashStyle = value;
      }
    }

    public bool TitleEnabled
    {
      get
      {
        return this.titleEnabled;
      }
      set
      {
        this.titleEnabled = value;
      }
    }

    public bool LabelEnabled
    {
      get
      {
        return this.labelEnabled;
      }
      set
      {
        this.labelEnabled = value;
      }
    }

    public Font LabelFont
    {
      get
      {
        return this.labelFont;
      }
      set
      {
        this.labelFont = value;
      }
    }

    public Color LabelColor
    {
      get
      {
        return this.labelColor;
      }
      set
      {
        this.labelColor = value;
      }
    }

    public int LabelOffset
    {
      get
      {
        return this.labelOffset;
      }
      set
      {
        this.labelOffset = value;
      }
    }

    public string LabelFormat
    {
      get
      {
        return this.labelFormat;
      }
      set
      {
        this.labelFormat = value;
      }
    }

    public EAxisLabelAlignment LabelAlignment
    {
      get
      {
        return this.labelAlignment;
      }
      set
      {
        this.labelAlignment = value;
      }
    }

    public int Width
    {
      get
      {
        return this.width;
      }
      set
      {
        this.width = value;
      }
    }

    public int Height
    {
      get
      {
        return this.height;
      }
      set
      {
        this.height = value;
      }
    }

    public string Title
    {
      get
      {
        return this.title;
      }
      set
      {
        this.title = value;
      }
    }
  }
}
