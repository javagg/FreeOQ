using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXInstrumentLegEventArgs : EventArgs
  {
    private FIXInstrumentLeg QRpY3vqbDK;

    public FIXInstrumentLeg InstrumentLeg
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.QRpY3vqbDK;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.QRpY3vqbDK = value;
      }
    }

    public FIXInstrumentLegEventArgs(FIXInstrumentLeg InstrumentLeg)
    {
      this.QRpY3vqbDK = InstrumentLeg;
    }
  }
}
