using FreeQuant.Instruments;
using System.Collections;

namespace FreeQuant.Trading
{
	public class DoubleParam
	{
		private Hashtable yvNRbXLeMW;

		public double this [Instrument instrument]
		{
			get
			{
				object obj = this.yvNRbXLeMW[instrument];
				return (obj != null) ? (double)obj : 0.0;
			}
			set
			{
				this.yvNRbXLeMW[instrument] = value;
			}
		}

		public DoubleParam()
		{
			this.yvNRbXLeMW = new Hashtable();
		}
	}
}
