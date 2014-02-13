using OpenQuant.Shared.Data;
using FreeQuant.Data;

namespace OpenQuant.Shared.QuantTrader
{
	public class BarRequest : Request
	{
		public BarType BarType { get; private set; }

		public long BarSize { get; private set; }

		public BarRequest(BarType barType, long barSize) : base(DataType.Bar)
		{
			this.BarType = barType;
			this.BarSize = barSize;
		}
	}
}
