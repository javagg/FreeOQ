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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.xCiCPTiFh5;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.xCiCPTiFh5 = value;
      }
    }

    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.yQbCG11LAA;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.yQbCG11LAA = value;
      }
    }

    public Font Font
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.vEiCRZq66V;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.vEiCRZq66V = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TLegendItem(string Text, Color Color, Font Font)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.xCiCPTiFh5 = Text;
      this.yQbCG11LAA = Color;
      this.vEiCRZq66V = Font;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TLegendItem(string Text, Color Color)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.xCiCPTiFh5 = Text;
      this.yQbCG11LAA = Color;
      this.vEiCRZq66V = new Font(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(752), 8f);
    }
  }
}
