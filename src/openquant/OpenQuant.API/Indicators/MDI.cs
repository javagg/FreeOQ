// Type: OpenQuant.API.Indicators.MDI
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class MDI : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as MDI).get_Length();
      }
      set
      {
        (this.indicator as MDI).set_Length(value);
      }
    }

    public IndicatorStyle Style
    {
      get
      {
        return OpenQuant.API.EnumConverter.Convert((this.indicator as MDI).get_Style());
      }
      set
      {
        (this.indicator as MDI).set_Style(OpenQuant.API.EnumConverter.Convert(value));
      }
    }

    private MDI()
    {
      this.indicator = (Indicator) new MDI();
    }

    public MDI(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new MDI((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public MDI(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new MDI((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public MDI(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new MDI((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public MDI(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new MDI((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }
  }
}
