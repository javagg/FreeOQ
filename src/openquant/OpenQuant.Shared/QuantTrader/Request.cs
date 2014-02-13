using OpenQuant.Shared.Data;

namespace OpenQuant.Shared.QuantTrader
{
	public class Request
	{
		public DataType DataType { get; private set; }

		public Request(DataType dataType)
		{
			this.DataType = dataType;
		}
	}
}
