// Type: OpenQuant.QuantBase.ImportSettings
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.API;
using System;
using System.Collections.Generic;

namespace OpenQuant.QuantBase
{
  internal class ImportSettings
  {
    public List<DataSeriesItem> Items { get; private set; }

    public bool CreateNewInstruments { get; set; }

    public InstrumentType InstrumentType { get; set; }

    public DateTime? From { get; set; }

    public DateTime? To { get; set; }

    public ImportMode ImportMode { get; set; }

    public int BufferSize { get; set; }

    public ImportSettings()
    {
      this.Items = new List<DataSeriesItem>();
      this.CreateNewInstruments = true;
      this.InstrumentType = (InstrumentType) 0;
      this.ImportMode = ImportMode.Overwrite;
      this.BufferSize = 1000;
    }
  }
}
