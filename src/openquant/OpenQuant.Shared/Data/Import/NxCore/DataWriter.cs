using FreeQuant.Data;
using FreeQuant.Instruments;

namespace OpenQuant.Shared.Data.Import.NxCore
{
	abstract class DataWriter
	{
		public virtual void BeginWrite()
		{
		}

		public virtual void EndWrite()
		{
			DataManager.Server.Flush();
		}

		public abstract void Write(Instrument instrument, Trade trade);

		public abstract void Write(Instrument instrument, Quote quote);
	}
}
