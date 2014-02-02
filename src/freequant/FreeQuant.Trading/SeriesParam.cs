using System.Collections;
using FreeQuant.Instruments;
using FreeQuant.Series;

namespace FreeQuant.Trading
{
	public class SeriesParam
	{
		private Hashtable serieses; 

		public TimeSeries this [Instrument instrument]
		{
			get
			{
				return this.serieses[instrument] as TimeSeries;
			}
			set
			{
				this.serieses[instrument] = value;
			}
		}

		public SeriesParam() : base()
		{
			this.serieses = new Hashtable();
		}
	}
}
