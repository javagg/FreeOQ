using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXStandardTrailerEventArgs : EventArgs
  {
    private FIXStandardTrailer BggZuEkqvu;

    public FIXStandardTrailer StandardTrailer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.BggZuEkqvu;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.BggZuEkqvu = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXStandardTrailerEventArgs(FIXStandardTrailer StandardTrailer)
    {

      this.BggZuEkqvu = StandardTrailer;
    }
  }
}
