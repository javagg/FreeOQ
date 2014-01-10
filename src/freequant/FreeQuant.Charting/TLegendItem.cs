using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
  [Serializable]
  public class TLegendItem
  {
    private string xCiCPTiFh5;
    private Color yQbCG11LAA;
    private Font vEiCRZq66V;

    public string Text
    {
       get
      {
        return this.xCiCPTiFh5;
      }
       set
      {
        this.xCiCPTiFh5 = value;
      }
    }

    public Color Color
    {
       get
      {
        return this.yQbCG11LAA;
      }
       set
      {
        this.yQbCG11LAA = value;
      }
    }

    public Font Font
    {
       get
      {
        return this.vEiCRZq66V;
      }
       set
      {
        this.vEiCRZq66V = value;
      }
    }

    
    public TLegendItem(string Text, Color Color, Font Font):base()
    {
      this.xCiCPTiFh5 = Text;
      this.yQbCG11LAA = Color;
      this.vEiCRZq66V = Font;
    }


    public TLegendItem(string Text, Color Color):base()
    {
      this.xCiCPTiFh5 = Text;
      this.yQbCG11LAA = Color;
      this.vEiCRZq66V = new Font(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(752), 8f);
    }
  }
}
