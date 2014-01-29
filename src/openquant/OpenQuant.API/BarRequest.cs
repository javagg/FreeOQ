namespace OpenQuant.API
{
	public class BarRequest
	{
		public long BarSize { get; private set; }
		public BarType BarType { get; private set; }
		public bool IsBarFactoryRequest { get; set; }

		public BarRequest(BarType barType, long barSize, bool isBarFactoryRequest)
		{
			this.BarType = barType;
			this.BarSize = barSize;
			this.IsBarFactoryRequest = isBarFactoryRequest;
		}

		public override bool Equals(object obj)
		{
			BarRequest barRequest = obj as BarRequest;
			return barRequest != null && barRequest.BarType == this.BarType && barRequest.BarSize == this.BarSize;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		private BarRequest(FreeQuant.Data.BarType barType, long barSize, bool isBarFactoryRequest)
			: this(EnumConverter.Convert(barType), barSize, isBarFactoryRequest)
		{
		}
	}
}
