using SharpZipLib.Zip;
using System.IO;

namespace OpenQuant.Shared.QuantTrader
{
	public class ZipPackageReader : PackageReader
	{
		private Stream input;
		private string packageName;

		public ZipPackageReader(Stream input)
		{
			this.input = input;
			this.packageName = null;
		}

		public ZipPackageReader(FileInfo file) : this(new FileStream(file.FullName, FileMode.Open, FileAccess.Read))
		{
			this.packageName = Path.GetFileNameWithoutExtension(file.Name);
		}

		public override Package Read()
		{
			Package package = new Package();
			package.Name = this.packageName;
			ZipInputStream zipInputStream = new ZipInputStream(this.input);
			ZipEntry nextEntry;
			while ((nextEntry = zipInputStream.GetNextEntry()) != null)
			{
				if (!nextEntry.IsDirectory)
				{
					byte[] numArray = new byte[nextEntry.Size];
					int offset = 0;
					int length = numArray.Length;
					int num;
					do
					{
						num = ((Stream)zipInputStream).Read(numArray, offset, length);
						offset += num;
						length -= num;
					}
					while (num > 0);
					string path = nextEntry.Name.Replace('/', '\\').Trim(new char[]	{ '\\' });
					this.AddEntry(package, path, numArray);
				}
			}
			return package;
		}

		public override void Close()
		{
			this.input.Close();
		}
	}
}
