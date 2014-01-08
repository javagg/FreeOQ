using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
  [Serializable]
  public class TTitleItem
  {
    private string IXv0bEUjj;
    private Color RGgaNDXfm;

    public string Text
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.IXv0bEUjj;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.IXv0bEUjj = value;
      }
    }

    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.RGgaNDXfm;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.RGgaNDXfm = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TTitleItem()
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.IXv0bEUjj = "";
      this.RGgaNDXfm = Color.Black;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TTitleItem(string Text)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.IXv0bEUjj = Text;
      this.RGgaNDXfm = Color.Black;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TTitleItem(string Text, Color Color)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.IXv0bEUjj = Text;
      this.RGgaNDXfm = Color;
    }
  }
}
