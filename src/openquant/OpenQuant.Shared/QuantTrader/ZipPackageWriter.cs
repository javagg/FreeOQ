using SharpZipLib.Zip;
using SharpZipLib.Zip.Compression.Streams;
using System.Collections.Generic;
using System.IO;

namespace OpenQuant.Shared.QuantTrader
{
	public class ZipPackageWriter : PackageWriter
	{
		private Stream output;

		public ZipPackageWriter(Stream output)
		{
			this.output = output;
		}

		public override void Write(Package package)
		{
			MemoryStream memoryStream = new MemoryStream();
			ZipOutputStream zipStream = new ZipOutputStream(memoryStream);
			this.WriteFolder(zipStream, string.Empty, (PackageFolder)package);
			((DeflaterOutputStream)zipStream).Finish();
			memoryStream.WriteTo(this.output);
		}

		public override void Close()
		{
			this.output.Close();
		}

		private void WriteFolder(ZipOutputStream zipStream, string path, PackageFolder folder)
		{
			foreach (PackageEntry packageEntry in (IEnumerable<PackageEntry>) folder.GetEntries())
			{
				if (packageEntry is PackageFile)
				{
					zipStream.PutNextEntry(new ZipEntry(this.CombinePath(path, packageEntry.Name)));
					byte[] data = ((PackageFile)packageEntry).Data;
					((Stream)zipStream).Write(data, 0, data.Length);
					zipStream.CloseEntry();
				}
				if (packageEntry is PackageFolder)
					this.WriteFolder(zipStream, this.CombinePath(path, packageEntry.Name), (PackageFolder)packageEntry);
			}
		}

		private string CombinePath(string path, string name)
		{
			if (path == string.Empty)
				return name;
			else
				return path + "\\" + name;
		}
	}
}
