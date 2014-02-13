using FreeQuant.Data;
using FreeQuant.Instruments;

namespace OpenQuant.Shared.Data.Bars
{
	class CompressorTask
	{
		public IDataSeries InputSeries { get; set; }

		public Instrument Instrument { get; set; }

		public DataSource DataSource { get; set; }

		public BarTypeSize BarTypeSize { get; set; }

		public ExistentDataSeries ExistentDataSeries { get; set; }
	}
}
