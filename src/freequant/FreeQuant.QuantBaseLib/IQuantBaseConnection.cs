// Type: SmartQuant.QuantBaseLib.IQuantBaseConnection
// Assembly: SmartQuant.QuantBaseLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: 731FD5A4-BDE4-4DBE-9E03-2B8B62452B0C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantBaseLib.dll

using System;

namespace SmartQuant.QuantBaseLib
{
  public interface IQuantBaseConnection
  {
    event EventHandler Closed;

    void Close();

    DataSeriesInfo[] GetDataSeries();

    IDataSeriesReader GetReader(ReaderParameters parameters);

    Instrument[] GetInstruments(InstrumentFilter filter);
  }
}
