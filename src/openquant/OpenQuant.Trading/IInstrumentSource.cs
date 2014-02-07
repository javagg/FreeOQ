using FreeQuant.Instruments;
using FreeQuant.Testing;
using FreeQuant.Trading;
using FreeQuant.Charting;
using System.Collections.Generic;

namespace OpenQuant.Trading
{
	public interface IInstrumentSource
	{
		List<Instrument> Instruments { get; }
		List<ATSStop> Stops { get; }
		Portfolio Portfolio { get; }
		LiveTester Tester { get; }
		event StopEventHandler StopAdded;
	}
}
