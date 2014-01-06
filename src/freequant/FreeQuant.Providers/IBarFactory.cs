// Type: SmartQuant.Providers.IBarFactory
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using A9PhgAbigUGdNqGynZ;
using SmartQuant.Data;
using SmartQuant.FIX;
using System.ComponentModel;

namespace SmartQuant.Providers
{
  [TypeConverter(typeof (CSb1wLshQIL8PByHOP))]
  public interface IBarFactory
  {
    bool Enabled { get; set; }

    BarFactoryInput Input { get; set; }

    BarFactoryItemList Items { get; }

    event BarEventHandler NewBar;

    event BarEventHandler NewBarOpen;

    event BarSliceEventHandler NewBarSlice;

    void OnNewTrade(IFIXInstrument instrument, Trade trade);

    void OnNewQuote(IFIXInstrument instrument, Quote quote);

    void Reset();
  }
}
