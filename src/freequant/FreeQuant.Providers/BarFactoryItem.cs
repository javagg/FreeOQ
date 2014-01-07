using dW79p7NPlS6ZxObcx3;
using Obgh2s3A3GOOarwj6c;
using FreeQuant.Data;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class BarFactoryItem : IComparable
  {
    internal const BarType aYrgwoBvsH = BarType.Time;
    internal const long l27gtTMOx0 = 60L;
    internal const bool dAxggIVaoI = true;
    private BarType WdOgLDv873;
    private long peigWZAUss;
    private bool pKNgSFEXfx;

    [DefaultValue(BarType.Time)]
    public BarType BarType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WdOgLDv873;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.WdOgLDv873 = value;
      }
    }

    [DefaultValue(60L)]
    public long BarSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.peigWZAUss;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.peigWZAUss = value;
      }
    }

    [DefaultValue(true)]
    public bool Enabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.pKNgSFEXfx;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.pKNgSFEXfx = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarFactoryItem(BarType barType, long barSize, bool enabled)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.WdOgLDv873 = barType;
      this.peigWZAUss = barSize;
      this.pKNgSFEXfx = enabled;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarFactoryItem()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      this.\u002Ector(BarType.Time, 60L, true);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CompareTo(object obj)
    {
      BarFactoryItem barFactoryItem = obj as BarFactoryItem;
      if (barFactoryItem != null)
      {
        if (this.peigWZAUss > barFactoryItem.peigWZAUss)
          return 1;
        if (this.peigWZAUss < barFactoryItem.peigWZAUss)
          return -1;
      }
      return 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return string.Format(GojrKtfk5NMi1fou68.a17L2Y7Wnd(718), (object) this.WdOgLDv873, (object) this.peigWZAUss, (object) (bool) (this.pKNgSFEXfx ? 1 : 0));
    }
  }
}
