using FreeQuant.Instruments;
using FreeQuant.Series;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class SeriesParam
  {
    private Hashtable BxPphSSHW;

    public TimeSeries this[Instrument instrument]
    {
       get
      {
        return (TimeSeries) this.BxPphSSHW[(object) instrument];
      }
       set
      {
        this.BxPphSSHW[(object) instrument] = (object) value;
      }
    }

    
		public SeriesParam():base()
    {
      this.BxPphSSHW = new Hashtable();
    }
  }
}
