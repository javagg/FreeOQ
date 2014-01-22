using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace FreeQuant.Charting
{
  [Serializable]
  public class Graph : IDrawable, IZoomable, IMovable
  {
    private string CFyB7PnIL;
    private string ts4lgt9JG;
    private ArrayList e22K3LcaE;
    private EGraphStyle CEIfvOoI5;
    private EGraphMoveStyle iOuFNJBoR;
    private bool NbUOZ0dZP;
    private EMarkerStyle nsSJmTaNr;
    private int mqwMljRFC;
    private Color Sh8Pvcna2;
    private bool h6CGJfbhn;
    private DashStyle spjRE18r7;
    private Color f62NoxStB;
    private double XD92QjcMc;
    private double jLKi0nS6x;
    private double Em4D3w3fP;
    private double Yy88JGLlR;
    private int g36ZOkTLS;
    private bool t9gXebKDr;
    private string toolTipFormat;

    public string Name
    {
       get
      {
        return this.CFyB7PnIL;
      }
       set
      {
        this.CFyB7PnIL = value;
      }
    }

    public string Title
    {
       get
      {
        return this.ts4lgt9JG;
      }
       set
      {
        this.ts4lgt9JG = value;
      }
    }

    [Description("")]
    [Category("ToolTip")]
    public bool ToolTipEnabled
    {
       get
      {
        return this.t9gXebKDr;
      }
       set
      {
        this.t9gXebKDr = value;
      }
    }

    [Category("ToolTip")]
    [Description("")]
    public string ToolTipFormat
    {
       get
      {
				return this.toolTipFormat; 
      }
       set
      {
        this.toolTipFormat = value;
      }
    }

    [Category("Style")]
    [Description("")]
    public EGraphStyle Style
    {
       get
      {
        return this.CEIfvOoI5;
      }
       set
      {
        this.CEIfvOoI5 = value;
      }
    }

    [Category("Style")]
    [Description("")]
    public EGraphMoveStyle MoveStyle
    {
       get
      {
        return this.iOuFNJBoR;
      }
       set
      {
        this.iOuFNJBoR = value;
      }
    }

    [Description("")]
    [Category("Marker")]
    public bool MarkerEnabled
    {
       get
      {
        return this.NbUOZ0dZP;
      }
       set
      {
        this.NbUOZ0dZP = value;
      }
    }

    [Description("")]
    [Category("Marker")]
    public EMarkerStyle MarkerStyle
    {
       get
      {
        return this.nsSJmTaNr;
      }
       set
      {
        this.nsSJmTaNr = value;
        foreach (TMarker tmarker in this.e22K3LcaE)
          tmarker.Style = this.nsSJmTaNr;
      }
    }

    [Description("")]
    [Category("Marker")]
    public int MarkerSize
    {
       get
      {
        return this.mqwMljRFC;
      }
       set
      {
        this.mqwMljRFC = value;
        foreach (TMarker tmarker in this.e22K3LcaE)
          tmarker.Size = this.mqwMljRFC;
      }
    }

    [Description("")]
    [Category("Marker")]
    public Color MarkerColor
    {
       get
      {
        return this.Sh8Pvcna2;
      }
       set
      {
        this.Sh8Pvcna2 = value;
        foreach (TMarker tmarker in this.e22K3LcaE)
          tmarker.Color = this.Sh8Pvcna2;
      }
    }

    [Category("Bar")]
    [Description("")]
    public int BarWidth
    {
       get
      {
        return this.g36ZOkTLS;
      }
       set
      {
        this.g36ZOkTLS = value;
      }
    }

    [Category("Line")]
    [Description("")]
    public bool LineEnabled
    {
       get
      {
        return this.h6CGJfbhn;
      }
       set
      {
        this.h6CGJfbhn = value;
      }
    }

    [Description("")]
    [Category("Line")]
    public DashStyle LineDashStyle
    {
       get
      {
        return this.spjRE18r7;
      }
       set
      {
        this.spjRE18r7 = value;
      }
    }

    [Category("Line")]
    [Description("")]
    public Color LineColor
    {
       get
      {
        return this.f62NoxStB;
      }
       set
      {
        this.f62NoxStB = value;
      }
    }

    [Browsable(false)]
    public ArrayList Points
    {
       get
      {
        return this.e22K3LcaE;
      }
    }

    [Browsable(false)]
    public double MinX
    {
       get
      {
        return this.XD92QjcMc;
      }
    }

    [Browsable(false)]
    public double MinY
    {
       get
      {
        return this.Em4D3w3fP;
      }
    }

    [Browsable(false)]
    public double MaxX
    {
       get
      {
        return this.jLKi0nS6x;
      }
    }

    [Browsable(false)]
    public double MaxY
    {
       get
      {
        return this.Yy88JGLlR;
      }
    }

    
    public Graph():base()
    {

      this.ITuYxYXJ3();
    }

    
    public Graph(string Name):base()
    {
      this.CFyB7PnIL = Name;
      this.ITuYxYXJ3();
    }

    
    public Graph(string Name, string Title):base()
    {

      this.CFyB7PnIL = Name;
      this.ts4lgt9JG = Title;
      this.ITuYxYXJ3();
    }


    private void UX36ku1gb([In] double obj0, [In] double obj1)
    {
      this.XD92QjcMc = Math.Min(this.XD92QjcMc, obj0);
      this.Em4D3w3fP = Math.Min(this.Em4D3w3fP, obj1);
      this.jLKi0nS6x = Math.Max(this.jLKi0nS6x, obj0);
      this.Yy88JGLlR = Math.Max(this.Yy88JGLlR, obj1);
    }

    
    private void ITuYxYXJ3()
    {
      this.CEIfvOoI5 = EGraphStyle.Line;
      this.iOuFNJBoR = EGraphMoveStyle.Point;
      this.e22K3LcaE = new ArrayList();
      this.XD92QjcMc = double.MaxValue;
      this.Em4D3w3fP = double.MaxValue;
      this.jLKi0nS6x = double.MinValue;
      this.Yy88JGLlR = double.MinValue;
      this.NbUOZ0dZP = true;
      this.nsSJmTaNr = EMarkerStyle.Rectangle;
      this.mqwMljRFC = 5;
      this.Sh8Pvcna2 = Color.Black;
      this.h6CGJfbhn = true;
      this.spjRE18r7 = DashStyle.Solid;
      this.f62NoxStB = Color.Black;
      this.g36ZOkTLS = 20;
      this.t9gXebKDr = true;
			this.toolTipFormat = "invalid ";
    }

    
    public void Add(double X, double Y)
    {
      this.e22K3LcaE.Add((object) new TMarker(X, Y)
      {
        Style = this.nsSJmTaNr,
        Size = this.mqwMljRFC,
        Color = this.Sh8Pvcna2
      });
      this.UX36ku1gb(X, Y);
    }

    
    public void Add(double X, double Y, Color Color)
    {
      this.e22K3LcaE.Add((object) new TMarker(X, Y)
      {
        Style = this.nsSJmTaNr,
        Size = this.mqwMljRFC,
        Color = Color
      });
      this.UX36ku1gb(X, Y);
    }

    
    public void Add(double X, double Y, string Text)
    {
      TLabel tlabel = new TLabel(Text, X, Y);
      tlabel.Style = this.nsSJmTaNr;
      tlabel.Size = this.mqwMljRFC;
      tlabel.Color = this.Sh8Pvcna2;
      this.e22K3LcaE.Add((object) tlabel);
      this.UX36ku1gb(X, Y);
    }

    
    public void Add(double X, double Y, string Text, Color MarkerColor)
    {
      TLabel tlabel = new TLabel(Text, X, Y, MarkerColor);
      tlabel.Style = this.nsSJmTaNr;
      tlabel.Size = this.mqwMljRFC;
      this.e22K3LcaE.Add((object) tlabel);
      this.UX36ku1gb(X, Y);
    }

    
    public void Add(double X, double Y, string Text, Color MarkerColor, Color TextColor)
    {
      TLabel tlabel = new TLabel(Text, X, Y, MarkerColor, TextColor);
      tlabel.Style = this.nsSJmTaNr;
      tlabel.Size = this.mqwMljRFC;
      this.e22K3LcaE.Add((object) tlabel);
      this.UX36ku1gb(X, Y);
    }

    
    public void Add(TMarker Marker)
    {
      this.e22K3LcaE.Add((object) Marker);
      this.UX36ku1gb(Marker.X, Marker.Y);
    }

    
    public void Add(TLabel Label)
    {
      this.e22K3LcaE.Add((object) Label);
      this.UX36ku1gb(Label.X, Label.Y);
    }

    
    public virtual bool IsPadRangeX()
    {
      return false;
    }

    
    public virtual bool IsPadRangeY()
    {
      return false;
    }

    
    public virtual PadRange GetPadRangeX(Pad Pad)
    {
      return (PadRange) null;
    }

    
    public virtual PadRange GetPadRangeY(Pad Pad)
    {
      return (PadRange) null;
    }

    
    public virtual void Draw(string Option)
    {
      if (Chart.Pad == null)
      {
				Canvas canvas = new Canvas("Ca Name", "Ca Title");
      }
      Chart.Pad.Add((IDrawable) this);
      Chart.Pad.Title.Add(this.CFyB7PnIL, this.f62NoxStB);
      Chart.Pad.Legend.Add(this.CFyB7PnIL, this.f62NoxStB);
			if (Option.ToLower().IndexOf("waht") >= 0)
        return;
      Chart.Pad.SetRange(this.XD92QjcMc - (this.jLKi0nS6x - this.XD92QjcMc) / 10.0, this.jLKi0nS6x + (this.jLKi0nS6x - this.XD92QjcMc) / 10.0, this.Em4D3w3fP - (this.Yy88JGLlR - this.Em4D3w3fP) / 10.0, this.Yy88JGLlR + (this.Yy88JGLlR - this.Em4D3w3fP) / 10.0);
    }

    
    public virtual void Draw()
    {
      this.Draw("");
    }

    
    public virtual void Paint(Pad Pad, double XMin, double XMax, double YMin, double YMax)
    {
      if (this.CEIfvOoI5 == EGraphStyle.Line && this.h6CGJfbhn)
      {
        Pen Pen = new Pen(this.f62NoxStB);
        Pen.DashStyle = this.spjRE18r7;
        double X1 = 0.0;
        double Y1 = 0.0;
        bool flag = true;
        foreach (TMarker tmarker in this.e22K3LcaE)
        {
          if (!flag)
            Pad.DrawLine(Pen, X1, Y1, tmarker.X, tmarker.Y);
          else
            flag = false;
          X1 = tmarker.X;
          Y1 = tmarker.Y;
        }
      }
      if ((this.CEIfvOoI5 == EGraphStyle.Line || this.CEIfvOoI5 == EGraphStyle.Scatter) && this.NbUOZ0dZP)
      {
        foreach (TMarker tmarker in this.e22K3LcaE)
          tmarker.Paint(Pad, XMin, XMax, YMin, YMax);
      }
      if (this.CEIfvOoI5 != EGraphStyle.Bar)
        return;
      foreach (TMarker tmarker in this.e22K3LcaE)
      {
        if (tmarker.Y > 0.0)
          Pad.Graphics.FillRectangle((Brush) new SolidBrush(Color.Black), Pad.ClientX(tmarker.X) - this.g36ZOkTLS / 2, Pad.ClientY(tmarker.Y), this.g36ZOkTLS, Pad.ClientY(0.0) - Pad.ClientY(tmarker.Y));
        else
          Pad.Graphics.FillRectangle((Brush) new SolidBrush(Color.Black), Pad.ClientX(tmarker.X) - this.g36ZOkTLS / 2, Pad.ClientY(0.0), this.g36ZOkTLS, Pad.ClientY(tmarker.Y) - Pad.ClientY(0.0));
      }
    }

    
    public TDistance Distance(double X, double Y)
    {
      TDistance tdistance1 = new TDistance();
      foreach (TMarker tmarker in this.e22K3LcaE)
      {
        TDistance tdistance2 = tmarker.Distance(X, Y);
        if (tdistance2.dX < tdistance1.dX && tdistance2.dY < tdistance1.dY)
          tdistance1 = tdistance2;
      }
      if (tdistance1 != null)
      {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendFormat(this.toolTipFormat, (object) this.CFyB7PnIL, (object) this.ts4lgt9JG, (object) tdistance1.X, (object) tdistance1.Y);
        tdistance1.ToolTipText = ((object) stringBuilder).ToString();
      }
      return tdistance1;
    }

    
    public void Move(double X, double Y, double dX, double dY)
    {
      switch (this.iOuFNJBoR)
      {
        case EGraphMoveStyle.Graph:
          IEnumerator enumerator1 = this.e22K3LcaE.GetEnumerator();
          try
          {
            while (enumerator1.MoveNext())
            {
              TMarker tmarker = (TMarker) enumerator1.Current;
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
          IEnumerator enumerator2 = this.e22K3LcaE.GetEnumerator();
          try
          {
            while (enumerator2.MoveNext())
            {
              TMarker tmarker = (TMarker) enumerator2.Current;
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
