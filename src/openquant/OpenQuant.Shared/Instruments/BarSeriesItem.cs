using OpenQuant.Shared.Data;
using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Series;
using System;

namespace OpenQuant.Shared.Instruments
{
  class BarSeriesItem
  {
    private BarSeries series;
    private Instrument instrument;
    private string name;

    public BarSeries Series
    {
      get
      {
        return this.series;
      }
      set
      {
        this.series = value;
      }
    }

    public BarSeriesItem(BarSeries series, Instrument instrument)
    {
      this.series = series;
      this.instrument = instrument;
      this.RefreshName();
    }

    public void RefreshName()
    {
      string name = ((TimeSeries) this.series).Name;
      this.name = "";
      if (name.StartsWith(((FIXInstrument) this.instrument).Symbol))
      {
        string str1 = name.Remove(0, ((FIXInstrument) this.instrument).Symbol.Length);
        if (str1.StartsWith(" ("))
        {
          string str2 = str1.Remove(0, 2);
          if (str2.EndsWith(")"))
          {
            string[] strArray = str2.Substring(0, str2.Length - 1).Split(new char[1]
            {
              ' '
            });
            if (strArray.Length == 2 && Enum.IsDefined(typeof (BarType), (object) strArray[0]))
            {
              BarType barType = (BarType) Enum.Parse(typeof (BarType), strArray[0]);
              long result;
              if (long.TryParse(strArray[1], out result))
                this.name = DataSeriesHelper.BarTypeSizeToString(barType, result);
            }
          }
        }
      }
      if (!(this.name == ""))
        return;
      this.name = ((TimeSeries) this.series).Name;
    }

    public override string ToString()
    {
      return this.name;
    }
  }
}
