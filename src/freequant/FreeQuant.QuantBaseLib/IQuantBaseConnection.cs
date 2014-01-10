using System;

namespace FreeQuant.QuantBaseLib
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
