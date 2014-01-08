using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantBaseLib
{
  [Serializable]
  public class DataSeriesInfo
  {
    public string Name { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public string Description { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public int Count { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public DateTime? Begin { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    public DateTime? End { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataSeriesInfo()
    {
      eqv8L4m3VQyMGRLykq.UXAt7k5zdpi3d();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Name = string.Empty;
      this.Description = string.Empty;
      this.Count = 0;
      this.Begin = new DateTime?();
      this.End = new DateTime?();
    }
  }
}
