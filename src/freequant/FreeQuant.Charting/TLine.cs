using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
  [Serializable]
  public class TLine : IDrawable
  {
    private double sJtCYICQXO;
    private double h5GCBxGygl;
    private double PufClO5avv;
    private double ow8CKw3ueB;
    private Color esOCfcSMpP;
    private int RbYCFcVuCb;
    private DashStyle EbYCO1lcN4;
    private bool HrpCJRNn2N;
    private string QC5CM77ORT;

    public bool ToolTipEnabled
    {
       get
      {
        return this.HrpCJRNn2N;
      }
       set
      {
        this.HrpCJRNn2N = value;
      }
    }

    public string ToolTipFormat
    {
       get
      {
        return this.QC5CM77ORT;
      }
       set
      {
        this.QC5CM77ORT = value;
      }
    }

    public double X1
    {
       get
      {
        return this.sJtCYICQXO;
      }
       set
      {
        this.sJtCYICQXO = value;
      }
    }

    public double Y1
    {
       get
      {
        return this.h5GCBxGygl;
      }
       set
      {
        this.h5GCBxGygl = value;
      }
    }

    public double X2
    {
       get
      {
        return this.PufClO5avv;
      }
       set
      {
        this.PufClO5avv = value;
      }
    }

    public double Y2
    {
       get
      {
        return this.ow8CKw3ueB;
      }
       set
      {
        this.ow8CKw3ueB = value;
      }
    }

    public DashStyle DashStyle
    {
       get
      {
        return this.EbYCO1lcN4;
      }
       set
      {
        this.EbYCO1lcN4 = value;
      }
    }

    public Color Color
    {
       get
      {
        return this.esOCfcSMpP;
      }
       set
      {
        this.esOCfcSMpP = value;
      }
    }

    public int Width
    {
       get
      {
        return this.RbYCFcVuCb;
      }
       set
      {
        this.RbYCFcVuCb = value;
      }
    }

    
    public TLine(double X1, double Y1, double X2, double Y2)
    {
      this.sJtCYICQXO = X1;
      this.h5GCBxGygl = Y1;
      this.PufClO5avv = X2;
      this.ow8CKw3ueB = Y2;
      this.esOCfcSMpP = Color.Black;
      this.EbYCO1lcN4 = DashStyle.Solid;
      this.RbYCFcVuCb = 1;
    }

    
    public TLine(DateTime X1, double Y1, DateTime X2, double Y2)
    {
      this.sJtCYICQXO = (double) X1.Ticks;
      this.h5GCBxGygl = Y1;
      this.PufClO5avv = (double) X2.Ticks;
      this.ow8CKw3ueB = Y2;
      this.esOCfcSMpP = Color.Black;
      this.EbYCO1lcN4 = DashStyle.Solid;
      this.RbYCFcVuCb = 1;
    }

    
    public virtual void Draw()
    {
      if (Chart.Pad == null)
      {
				Canvas canvas = new Canvas("d", "d");
      }
      Chart.Pad.Add((IDrawable) this);
    }

    
    public virtual void Paint(Pad Pad, double XMin, double XMax, double YMin, double YMax)
    {
      Pad.DrawLine(new Pen(this.esOCfcSMpP)
      {
        Width = (float) this.RbYCFcVuCb,
        DashStyle = this.EbYCO1lcN4
      }, this.sJtCYICQXO, this.h5GCBxGygl, this.PufClO5avv, this.ow8CKw3ueB);
    }

    
    public TDistance Distance(double X, double Y)
    {
      return (TDistance) null;
    }
  }
}
