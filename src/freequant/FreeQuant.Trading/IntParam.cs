using FreeQuant.Instruments;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class IntParam
  {
    private Hashtable Whi61bRdZC;

    public int this[Instrument instrument]
    {
       get
      {
        object obj = this.Whi61bRdZC[(object) instrument];
        if (obj != null)
          return (int) obj;
        else
          return 0;
      }
       set
      {
        this.Whi61bRdZC[(object) instrument] = (object) value;
      }
    }

    
    public IntParam()
    {
      this.Whi61bRdZC = new Hashtable();
    }
  }
}
