using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace FreeQuant.Charting
{
  public class TImage : IDrawable, IMovable
  {
    private Image jOZ39kecDV;
    private double wPV3e4U3q3;
    private double cnj378aqIs;
    private bool KWs3zs7q7q;
    private string ARXCnXs0bV;

    [Description("X position of this image on the pad. (World coordinate system)")]
    [Category("Position")]
    public double X
    {
       get
      {
        return this.wPV3e4U3q3;
      }
       set
      {
        this.wPV3e4U3q3 = value;
      }
    }

    [Description("Y position of this image on the pad. (World coordinate system)")]
    [Category("Position")]
    public double Y
    {
       get
      {
        return this.cnj378aqIs;
      }
       set
      {
        this.cnj378aqIs = value;
      }
    }

    [Description("Enable or disable tooltip appearance for this image.")]
    [Category("ToolTip")]
    public bool ToolTipEnabled
    {
       get
      {
        return this.KWs3zs7q7q;
      }
       set
      {
        this.KWs3zs7q7q = value;
      }
    }

    [Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
    [Category("ToolTip")]
    public string ToolTipFormat
    {
       get
      {
        return this.ARXCnXs0bV;
      }
       set
      {
        this.ARXCnXs0bV = value;
      }
    }

    
    public TImage(Image Image, double X, double Y):base()
    {

      this.jOZ39kecDV = Image;
      this.wPV3e4U3q3 = X;
      this.cnj378aqIs = Y;
      this.yee3w4ff2w();
    }


    public TImage(Image Image, DateTime X, double Y):base()
    {

      this.jOZ39kecDV = Image;
      this.wPV3e4U3q3 = (double) X.Ticks;
      this.cnj378aqIs = Y;
      this.yee3w4ff2w();
    }

    
    public TImage(string FileName, double X, double Y):base()
    {

      this.jOZ39kecDV = Image.FromFile(FileName);
      this.wPV3e4U3q3 = X;
      this.cnj378aqIs = Y;
      this.yee3w4ff2w();
    }

    
    public TImage(string FileName, DateTime X, double Y):base()
    {
      this.jOZ39kecDV = Image.FromFile(FileName);
      this.wPV3e4U3q3 = (double) X.Ticks;
      this.cnj378aqIs = Y;
      this.yee3w4ff2w();
    }

    [SpecialName]
    
    private Image T343SKhwwY()
    {
      return this.jOZ39kecDV;
    }

    [SpecialName]
    
    private void uYZ3jN1m5i(Image value)
    {
      this.jOZ39kecDV = value;
    }

    
    private void yee3w4ff2w()
    {
      this.KWs3zs7q7q = true;
      this.ARXCnXs0bV = RA7k7APgXK5aSsnmA9.qBCYFXVOKp(642);
    }

    
    public virtual void Draw()
    {
      if (Chart.Pad == null)
      {
        Canvas canvas = new Canvas(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(688), RA7k7APgXK5aSsnmA9.qBCYFXVOKp(704));
      }
      Chart.Pad.Add((IDrawable) this);
    }

    
    public virtual void Paint(Pad Pad, double XMin, double XMax, double YMin, double YMax)
    {
      int x = Pad.ClientX(this.wPV3e4U3q3);
      int y = Pad.ClientY(this.cnj378aqIs);
      Pad.Graphics.DrawImage(this.jOZ39kecDV, x, y);
    }

    
    public TDistance Distance(double X, double Y)
    {
      TDistance tdistance = new TDistance();
      tdistance.X = this.wPV3e4U3q3;
      tdistance.Y = this.cnj378aqIs;
      tdistance.dX = Math.Abs(X - this.wPV3e4U3q3);
      tdistance.dY = Math.Abs(Y - this.cnj378aqIs);
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(this.ARXCnXs0bV, (object) this.wPV3e4U3q3, (object) this.cnj378aqIs);
      tdistance.ToolTipText = ((object) stringBuilder).ToString();
      return tdistance;
    }

    
    public void Move(double X, double Y, double dX, double dY)
    {
      this.wPV3e4U3q3 += dX;
      this.cnj378aqIs += dY;
    }
  }
}
