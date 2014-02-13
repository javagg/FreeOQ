using System.IO;

namespace OpenQuant.Shared.QuantTrader
{
	public class DirectoryPackageReader : PackageReader
	{
		private DirectoryInfo directory;

		public DirectoryPackageReader(DirectoryInfo directory)
		{
			this.directory = directory;
		}

		public override Package Read()
		{
			Package package = new Package();
			package.Name = this.directory.Name;
			foreach (FileInfo fileInfo in this.directory.GetFiles("*.*", SearchOption.AllDirectories))
			{
				string path = fileInfo.FullName.Substring(this.directory.FullName.Length + 1);
				byte[] data = File.ReadAllBytes(fileInfo.FullName);
				this.AddEntry(package, path, data);
			}
			return package;
		}

		public override void Close()
		{
		}
	}
}
