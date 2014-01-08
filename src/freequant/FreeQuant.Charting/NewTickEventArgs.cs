using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
  public class NewTickEventArgs : EventArgs
  {
    private DateTime KbAS54W9O;

    public DateTime DateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.KbAS54W9O;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.KbAS54W9O = value;
      }
    }

    public NewTickEventArgs(DateTime datetime)
    {
      this.KbAS54W9O = datetime;
    }
  }
}
