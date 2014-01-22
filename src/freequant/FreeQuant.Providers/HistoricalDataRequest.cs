using FreeQuant.FIX;
using System;
namespace FreeQuant.Providers
{
  public class HistoricalDataRequest
  {
    private static int ScTgOyCwNp;
    private string H5ygRPXX3V;
    private IFIXInstrument HpSg99FMLB;
    private HistoricalDataType FZdgYFaSe5;
    private DateTime DhGgsoa2Jr;
    private DateTime vFigbZop99;
    private int mjRgd5sOrY;
    private int HDbgrnSn2C;
    private long f85gKJ2B79;

    public string RequestId
    {
       get
      {
        return this.H5ygRPXX3V;
      }
    }

    public IFIXInstrument Instrument
    {
       get
      {
        return this.HpSg99FMLB;
      }
       set
      {
        this.HpSg99FMLB = value;
      }
    }

    public HistoricalDataType DataType
    {
       get
      {
        return this.FZdgYFaSe5;
      }
       set
      {
        this.FZdgYFaSe5 = value;
      }
    }

    public DateTime BeginDate
    {
       get
      {
        return this.DhGgsoa2Jr;
      }
       set
      {
        this.DhGgsoa2Jr = value;
      }
    }

    public DateTime EndDate
    {
       get
      {
        return this.vFigbZop99;
      }
       set
      {
        this.vFigbZop99 = value;
      }
    }

    public int DaysAgo
    {
       get
      {
        return this.mjRgd5sOrY;
      }
       set
      {
        this.mjRgd5sOrY = value;
      }
    }

    public int BarsAgo
    {
       get
      {
        return this.HDbgrnSn2C;
      }
       set
      {
        this.HDbgrnSn2C = value;
      }
    }

    public long BarSize
    {
       get
      {
        return this.f85gKJ2B79;
      }
       set
      {
        this.f85gKJ2B79 = value;
      }
    }

    
    static HistoricalDataRequest()
    {
      HistoricalDataRequest.ScTgOyCwNp = 0;
    }

    
    public HistoricalDataRequest()
    {
      lock (typeof (HistoricalDataRequest))
				this.H5ygRPXX3V = string.Format("", DateTime.Now, HistoricalDataRequest.ScTgOyCwNp++);
    }
  }
}
