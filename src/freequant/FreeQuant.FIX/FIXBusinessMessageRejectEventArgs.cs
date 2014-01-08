using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXBusinessMessageRejectEventArgs : EventArgs
  {
    private FIXBusinessMessageReject Or4UkwF6Vl;

    public FIXBusinessMessageReject BusinessMessageReject
    {
        get
      {
        return this.Or4UkwF6Vl;
      }
       set
      {
        this.Or4UkwF6Vl = value;
      }
    }

	public FIXBusinessMessageRejectEventArgs(FIXBusinessMessageReject BusinessMessageReject) : base()
    {

      this.Or4UkwF6Vl = BusinessMessageReject;
    }
  }
}
