using FreeQuant.Instruments;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class BoolParam
  {
    private Hashtable GCRR8QLLE5;

    public bool this[Instrument instrument]
    {
       get
      {
        object obj = this.GCRR8QLLE5[(object) instrument];
        if (obj != null)
          return (bool) obj;
        else
          return false;
      }
       set
      {
        this.GCRR8QLLE5[instrument] = value;
      }
    }

    
    public BoolParam()
    {
      this.GCRR8QLLE5 = new Hashtable();
    }
  }
}
