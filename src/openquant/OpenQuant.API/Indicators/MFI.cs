// Type: OpenQuant.API.Indicators.MFI
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class MFI : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as MFI).get_Length();
      }
      set
      {
        (this.indicator as MFI).set_Length(value);
      }
    }

    private MFI()
    {
      this.indicator = (Indicator) new MFI();
    }

    public MFI(OpenQuant.API.BarSeries series, int length)
    {
      this.indicator = (Indicator) new MFI((SmartQuant.Series.TimeSeries) series.series, length);
    }

    public MFI(Indicator indicator, int length)
    {
      this.indicator = (Indicator) new MFI((SmartQuant.Series.TimeSeries) indicator.indicator, length);
    }

    public MFI(OpenQuant.API.BarSeries series, int length, Color color)
    {
      this.indicator = (Indicator) new MFI((SmartQuant.Series.TimeSeries) series.series, length, color);
    }

    public MFI(Indicator indicator, int length, Color color)
    {
      this.indicator = (Indicator) new MFI((SmartQuant.Series.TimeSeries) indicator.indicator, length, color);
    }
  }
}
