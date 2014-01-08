using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXAdvertisementEventArgs : EventArgs
  {
    private FIXAdvertisement nIiAhh4MUM;

    public FIXAdvertisement Advertisement
    {
       get
      {
        return this.nIiAhh4MUM;
      }
       set
      {
        this.nIiAhh4MUM = value;
      }
    }

    public FIXAdvertisementEventArgs(FIXAdvertisement Advertisement)
    {
      this.nIiAhh4MUM = Advertisement;
    }
  }
}
