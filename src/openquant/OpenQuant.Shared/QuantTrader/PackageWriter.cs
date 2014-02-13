namespace OpenQuant.Shared.QuantTrader
{
	public abstract class PackageWriter
	{
		public abstract void Write(Package package);

		public abstract void Close();
	}
}
