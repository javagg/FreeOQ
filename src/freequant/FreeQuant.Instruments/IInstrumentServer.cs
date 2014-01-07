// Type: SmartQuant.Instruments.IInstrumentServer
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using System;

namespace FreeQuant.Instruments
{
  public interface IInstrumentServer
  {
    void Open(Type connectionType, string connectionString);

    InstrumentList Load();

    void Save(Instrument instrument);

    void Remove(Instrument instrument);

    void Close();
  }
}
