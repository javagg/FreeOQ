// Type: SmartQuant.Simulation.Interval
// Assembly: SmartQuant.Simulation, Version=1.0.5036.28353, Culture=neutral, PublicKeyToken=null
// MVID: 7CFB1E94-1672-436F-90C9-C8B7893A5618
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Simulation.dll

using CJ5Xsgeg9JvhJUnvO3D;
using System;
using System.Runtime.CompilerServices;
using Y9kGLiKILMabFE38T3;

namespace SmartQuant.Simulation
{
  public class Interval
  {
    private DateTime a9ymD86i6;
    private DateTime uwkfK3F1e;

    public DateTime Begin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.a9ymD86i6;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.a9ymD86i6 = value;
      }
    }

    public DateTime End
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.uwkfK3F1e;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.uwkfK3F1e = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Interval(DateTime begin, DateTime end)
    {
      eekpcgzPjZLOyP2Ysv.eyppkuTzDkifX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      if (end < begin)
        throw new ArgumentException(v6F3C32VVUpp2OYb5n.VVyFVqM4b6(0));
      this.a9ymD86i6 = begin;
      this.uwkfK3F1e = end;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Interval()
    {
      eekpcgzPjZLOyP2Ysv.eyppkuTzDkifX();
      // ISSUE: explicit constructor call
      this.\u002Ector(new DateTime(1900, 1, 1), new DateTime(2100, 1, 1));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return v6F3C32VVUpp2OYb5n.VVyFVqM4b6(70);
    }
  }
}
