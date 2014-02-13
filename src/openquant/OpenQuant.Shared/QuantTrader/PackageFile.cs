namespace OpenQuant.Shared.QuantTrader
{
	public class PackageFile : PackageEntry
	{
		internal byte[] Data { get; set; }

		public PackageFile()
		{
			this.Data = new byte[0];
		}

		internal override void InitFrom(PackageEntry entry)
		{
			base.InitFrom(entry);
			this.Data = ((PackageFile)entry).Data;
		}
	}
}
