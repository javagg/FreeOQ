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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.HrpCJRNn2N;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.HrpCJRNn2N = value;
      }
    }

    public string ToolTipFormat
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QC5CM77ORT;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.QC5CM77ORT = value;
      }
    }

    public double X1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sJtCYICQXO;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.sJtCYICQXO = value;
      }
    }

    public double Y1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.h5GCBxGygl;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.h5GCBxGygl = value;
      }
    }

    public double X2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.PufClO5avv;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.PufClO5avv = value;
      }
    }

    public double Y2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ow8CKw3ueB;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.ow8CKw3ueB = value;
      }
    }

    public DashStyle DashStyle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.EbYCO1lcN4;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.EbYCO1lcN4 = value;
      }
    }

    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.esOCfcSMpP;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.esOCfcSMpP = value;
      }
    }

    public int Width
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.RbYCFcVuCb;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.RbYCFcVuCb = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TLine(double X1, double Y1, double X2, double Y2)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.sJtCYICQXO = X1;
      this.h5GCBxGygl = Y1;
      this.PufClO5avv = X2;
      this.ow8CKw3ueB = Y2;
      this.esOCfcSMpP = Color.Black;
      this.EbYCO1lcN4 = DashStyle.Solid;
      this.RbYCFcVuCb = 1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TLine(DateTime X1, double Y1, DateTime X2, double Y2)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.sJtCYICQXO = (double) X1.Ticks;
      this.h5GCBxGygl = Y1;
      this.PufClO5avv = (double) X2.Ticks;
      this.ow8CKw3ueB = Y2;
      this.esOCfcSMpP = Color.Black;
      this.EbYCO1lcN4 = DashStyle.Solid;
      this.RbYCFcVuCb = 1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Draw()
    {
      if (Chart.Pad == null)
      {
        Canvas canvas = new Canvas(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(720), RA7k7APgXK5aSsnmA9.qBCYFXVOKp(736));
      }
      Chart.Pad.Add((IDrawable) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Paint(Pad Pad, double XMin, double XMax, double YMin, double YMax)
    {
      Pad.DrawLine(new Pen(this.esOCfcSMpP)
      {
        Width = (float) this.RbYCFcVuCb,
        DashStyle = this.EbYCO1lcN4
      }, this.sJtCYICQXO, this.h5GCBxGygl, this.PufClO5avv, this.ow8CKw3ueB);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TDistance Distance(double X, double Y)
    {
      return (TDistance) null;
    }
  }
}
