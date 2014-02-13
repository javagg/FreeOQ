using FreeQuant.Instruments;
using System;

namespace OpenQuant.Shared.Data.Import.NxCore
{
  internal class ImportSettings
  {
    public string[] TapeFiles { get; set; }

    public Instrument[] Instruments { get; set; }

    public bool Trades { get; set; }

    public bool Quotes { get; set; }

    public TimeSpan? From { get; set; }

    public TimeSpan? To { get; set; }

    public AdvancedImportSettings Advanced { get; private set; }

    public ImportSettings()
    {
      this.TapeFiles = new string[0];
      this.Instruments = new Instrument[0];
      this.Trades = true;
      this.Quotes = true;
      this.From = new TimeSpan?(new TimeSpan(9, 30, 0));
      this.To = new TimeSpan?(new TimeSpan(16, 0, 0));
      this.Advanced = new AdvancedImportSettings();
    }
  }
}
