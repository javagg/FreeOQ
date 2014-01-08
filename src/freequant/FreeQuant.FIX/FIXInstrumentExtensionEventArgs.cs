using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXInstrumentExtensionEventArgs : EventArgs
  {
    private FIXInstrumentExtension WSt8WlBwZ2;

    public FIXInstrumentExtension InstrumentExtension
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WSt8WlBwZ2;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.WSt8WlBwZ2 = value;
      }
    }

    public FIXInstrumentExtensionEventArgs(FIXInstrumentExtension InstrumentExtension)
    {
      this.WSt8WlBwZ2 = InstrumentExtension;
    }
  }
}
