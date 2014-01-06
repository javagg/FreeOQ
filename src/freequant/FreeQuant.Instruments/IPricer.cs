// Type: SmartQuant.Instruments.IPricer
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using System;

namespace SmartQuant.Instruments
{
  public interface IPricer
  {
    double Price(Instrument instrument);

    double Volatility(Instrument instrument);

    double Delta(Instrument instrument);

    double Gamma(Instrument instrument);

    double Theta(Instrument instrument);

    double Vega(Instrument instrument);

    double Rho(Instrument instrument);

    double Price(Instrument instrument, DateTime dateTime);

    double Volatility(Instrument instrument, DateTime dateTime1, DateTime dateTime2);

    double Delta(Instrument instrument, DateTime dateTime);

    double Gamma(Instrument instrument, DateTime dateTime);

    double Theta(Instrument instrument, DateTime dateTime);

    double Vega(Instrument instrument, DateTime dateTime);

    double Rho(Instrument instrument, DateTime dateTime);
  }
}
