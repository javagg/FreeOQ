namespace OpenQuant.Shared.QuantTrader
{
	public class AssemblyFile : PackageFile
	{
		public string AssemblyName
		{
			get
			{
				return this.Name;
			}
		}

		public byte[] RawAssembly
		{
			get
			{
				return this.Data;
			}
			set
			{
				this.Data = value;
			}
		}
	}
}
