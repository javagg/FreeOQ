using FreeQuant.Trading;
using System;

namespace OpenQuant.API
{
  public class Stop
  {
    internal ATSStop stop;
    private Position position;

    public Instrument Instrument
    {
      get
      {
        return this.position.Instrument;
      }
    }

    public double FillPrice
    {
      get
      {
        return this.stop.get_FillPrice();
      }
    }

    public double StopPrice
    {
      get
      {
        return this.stop.get_StopPrice();
      }
    }

    public double Level
    {
      get
      {
        return ((StopBase) this.stop).get_Level();
      }
    }

    public StopType Type
    {
      get
      {
        return EnumConverter.Convert(((StopBase) this.stop).get_Type());
      }
    }

    public StopMode Mode
    {
      get
      {
        return EnumConverter.Convert(((StopBase) this.stop).get_Mode());
      }
    }

    public StopStatus Status
    {
      get
      {
        return EnumConverter.Convert(((StopBase) this.stop).get_Status());
      }
    }

    public bool TraceOnBar
    {
      get
      {
        return ((StopBase) this.stop).get_TraceOnBar();
      }
      set
      {
        ((StopBase) this.stop).set_TraceOnBar(value);
      }
    }

    public bool TraceOnTrade
    {
      get
      {
        return ((StopBase) this.stop).get_TraceOnTrade();
      }
      set
      {
        ((StopBase) this.stop).set_TraceOnTrade(value);
      }
    }

    public bool TraceOnQuote
    {
      get
      {
        return ((StopBase) this.stop).get_TraceOnQuote();
      }
      set
      {
        ((StopBase) this.stop).set_TraceOnQuote(value);
      }
    }

    public DateTime CreationTime
    {
      get
      {
        return ((StopBase) this.stop).get_CreationTime();
      }
    }

    public DateTime CompletionTime
    {
      get
      {
        return ((StopBase) this.stop).get_CompletionTime();
      }
    }

    internal Stop(Position position, DateTime dateTime)
    {
      this.position = position;
      this.stop = new ATSStop(position.position, dateTime);
      ((StopBase) this.stop).set_TrailOnHighLow(true);
      ((StopBase) this.stop).set_TraceOnBarOpen(true);
      ((StopBase) this.stop).set_TraceOnBar(true);
      ((StopBase) this.stop).set_TraceOnQuote(true);
      ((StopBase) this.stop).set_TraceOnTrade(true);
    }

    internal Stop(Position position, double level, StopType type, StopMode mode)
    {
      this.position = position;
      StopType stopType = EnumConverter.Convert(type);
      StopMode stopMode = EnumConverter.Convert(mode);
      this.stop = new ATSStop(position.position, level, stopType, stopMode);
      ((StopBase) this.stop).set_TrailOnHighLow(true);
      ((StopBase) this.stop).set_TraceOnBarOpen(true);
      ((StopBase) this.stop).set_TraceOnBar(true);
      ((StopBase) this.stop).set_TraceOnQuote(true);
      ((StopBase) this.stop).set_TraceOnTrade(true);
    }

    public void SetBarFilter(long barSize, BarType barType)
    {
      ((StopBase) this.stop).SetBarFilter(barSize, EnumConverter.Convert(barType));
    }

    public void SetBarFilter(long barSize)
    {
      this.SetBarFilter(barSize, BarType.Time);
    }

    public void Cancel()
    {
      this.stop.Cancel();
    }

    private void stop_StatusChanged(StopEventArgs args)
    {
    }

    public void Disconnect()
    {
      ((StopBase) this.stop).Disconnect();
    }
  }
}
