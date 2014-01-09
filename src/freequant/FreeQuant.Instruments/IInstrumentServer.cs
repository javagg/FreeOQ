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
