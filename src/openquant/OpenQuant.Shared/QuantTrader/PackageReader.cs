using System.IO;

namespace OpenQuant.Shared.QuantTrader
{
	public abstract class PackageReader
	{
		public abstract Package Read();

		public abstract void Close();

		protected void AddEntry(Package package, string path, byte[] data)
		{
            string[] array = path.Split(new char[] { Path.DirectorySeparatorChar });
			PackageFolder packageFolder = (PackageFolder)package;
            for (int i = 0; i < array.Length - 1; ++i)
				packageFolder = packageFolder.GetEntry<PackageFolder>(array[i]);
			packageFolder.GetEntry<PackageFile>(array[array.Length - 1]).Data = data;
		}
	}
}
