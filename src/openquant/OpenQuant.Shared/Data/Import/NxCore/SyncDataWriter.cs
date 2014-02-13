using FreeQuant.Data;
using FreeQuant.Instruments;

namespace OpenQuant.Shared.Data.Import.NxCore
{
  internal class SyncDataWriter : DataWriter
  {
    public override void Write(Instrument instrument, Trade trade)
    {
      instrument.Add(trade);
    }

    public override void Write(Instrument instrument, Quote quote)
    {
      instrument.Add(quote);
    }
  }
}
