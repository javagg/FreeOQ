namespace OpenQuant.Shared.QuantTrader
{
	public abstract class PackageReader
	{
		public abstract Package Read();

		public abstract void Close();

		protected void AddEntry(Package package, string path, byte[] data)
		{
			string[] strArray = path.Split(new char[] { '\\' });
			PackageFolder packageFolder = (PackageFolder)package;
			for (int index = 0; index < strArray.Length - 1; ++index)
				packageFolder = packageFolder.GetEntry<PackageFolder>(strArray[index]);
			packageFolder.GetEntry<PackageFile>(strArray[strArray.Length - 1]).Data = data;
		}
	}
}
