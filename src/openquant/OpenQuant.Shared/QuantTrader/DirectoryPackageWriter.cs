using System.Collections.Generic;
using System.IO;

namespace OpenQuant.Shared.QuantTrader
{
	public class DirectoryPackageWriter : PackageWriter
	{
		private DirectoryInfo directory;

		public DirectoryPackageWriter(DirectoryInfo directory)
		{
			this.directory = directory;
		}

		public override void Write(Package package)
		{
			this.Write(this.directory, package);
		}

		public override void Close()
		{
		}

		protected virtual bool FilterEntry(PackageEntry entry)
		{
			return false;
		}

		private void Write(DirectoryInfo directory, PackageFolder folder)
		{
			foreach (PackageEntry entry in (IEnumerable<PackageEntry>) folder.GetEntries())
			{
				if (!this.FilterEntry(entry))
				{
					if (entry is PackageFolder)
						this.Write(directory.CreateSubdirectory(entry.Name), (PackageFolder)entry);
					if (entry is PackageFile)
						File.WriteAllBytes(string.Format("{0}\\{1}", directory.FullName, entry.Name), ((PackageFile)entry).Data);
				}
			}
		}
	}
}
