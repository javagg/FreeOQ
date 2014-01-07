using OpenQuant.ObjectMap;

namespace OpenQuant.API
{
  public class BarSeriesList
  {
    public BarSeries this[Instrument instrument, BarType barType, long barSize]
    {
      get
      {
				return new BarSeries(FreeQuant.Instruments.DataManager.Bars[Map.OQ_SQ_Instrument[(object) instrument] as FreeQuant.Instruments.Instrument, EnumConverter.Convert(barType), barSize]);
      }
    }

    public BarSeries this[Instrument instrument]
    {
      get
      {
				return new BarSeries(FreeQuant.Instruments.DataManager.Bars[Map.OQ_SQ_Instrument[(object) instrument] as FreeQuant.Instruments.Instrument]);
      }
    }
  }
}
