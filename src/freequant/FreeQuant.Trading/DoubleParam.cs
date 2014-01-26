using FreeQuant.Instruments;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class DoubleParam
  {
    private Hashtable yvNRbXLeMW;

    public double this[Instrument instrument]
    {
       get
      {
        object obj = this.yvNRbXLeMW[(object) instrument];
        if (obj != null)
          return (double) obj;
        else
          return 0.0;
      }
       set
      {
        this.yvNRbXLeMW[(object) instrument] = (object) value;
      }
    }

    
    public DoubleParam()
    {
      this.yvNRbXLeMW = new Hashtable();
    }
  }
}
