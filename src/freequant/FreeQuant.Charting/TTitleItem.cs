// Type: SmartQuant.Charting.TTitleItem
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

using cPAIWng0kq1SUTh6h4;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace SmartQuant.Charting
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
