using FreeQuant.Instruments;
using System.Collections;

namespace FreeQuant.Trading
{
  public class IntParam
  {
    private Hashtable Whi61bRdZC;

    public int this[Instrument instrument]
    {
       get
      {
        object obj = this.Whi61bRdZC[instrument];
			return (obj != null) ? (int)obj : 0;
      }
       set
      {
        this.Whi61bRdZC[instrument] = value;
      }
    }

    
    public IntParam()
    {
      this.Whi61bRdZC = new Hashtable();
    }
  }
}
