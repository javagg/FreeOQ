using CJ5Xsgeg9JvhJUnvO3D;
using FreeQuant.Data;
using FreeQuant.Instruments;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Y9kGLiKILMabFE38T3;

namespace FreeQuant.Simulation
{
  public class BarFilterItem
  {
    private const string JiLF9ZfbvN = "Status";
    private const string yRAFpVJKGu = "Properties";
    private bool iZaFhJBw29;
    private BarType Dp4F5bWmV2;
    private long F8PFiYdG2a;

    [DefaultValue(true)]
    [Category("Status")]
    public bool Enabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.iZaFhJBw29;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.iZaFhJBw29 = value;
      }
    }

    [Category("Properties")]
    public BarType BarType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Dp4F5bWmV2;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Dp4F5bWmV2 = value;
      }
    }

    [Category("Properties")]
    public long BarSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.F8PFiYdG2a;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.F8PFiYdG2a = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarFilterItem(BarType barType, long barSize, bool enabled)
    {
      eekpcgzPjZLOyP2Ysv.eyppkuTzDkifX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Dp4F5bWmV2 = barType;
      this.F8PFiYdG2a = barSize;
      this.iZaFhJBw29 = enabled;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarFilterItem()
    {
      eekpcgzPjZLOyP2Ysv.eyppkuTzDkifX();
      // ISSUE: explicit constructor call
      this.\u002Ector(DataManager.DefaultBarType, DataManager.DefaultBarSize, true);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return string.Format(v6F3C32VVUpp2OYb5n.VVyFVqM4b6(5932), (object) this.Dp4F5bWmV2, (object) this.F8PFiYdG2a, (object) (bool) (this.iZaFhJBw29 ? 1 : 0));
    }
  }
}
