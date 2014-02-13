using System.Collections.Generic;
using System.IO;

namespace OpenQuant.Shared
{
	public class DataInstaller
	{
		public void Install (DirectoryInfo srcDirectory, DirectoryInfo dstDirectory, bool alwaysCopyFiles)
		{
			foreach (string str in this.GetFileNames(srcDirectory, new string[0])) {
				FileInfo fileInfo1 = new FileInfo (string.Format ("{0}\\{1}", (object)srcDirectory.FullName, (object)str));
				FileInfo fileInfo2 = new FileInfo (string.Format ("{0}\\{1}", (object)dstDirectory.FullName, (object)str));
				if (fileInfo2.Directory.Exists) {
					if (!fileInfo2.Exists && alwaysCopyFiles)
						File.Copy (fileInfo1.FullName, fileInfo2.FullName);
				} else {
					fileInfo2.Directory.Create ();
					File.Copy (fileInfo1.FullName, fileInfo2.FullName);
				}
			}
		}

		private string[] GetFileNames (DirectoryInfo directory, string[] path)
		{
			List<string> list = new List<string> ();
			foreach (FileInfo fileInfo in directory.GetFiles())
				list.Add (string.Join ("\\", (IEnumerable<string>)new List<string> ((IEnumerable<string>)path) {
					fileInfo.Name
				}));
			foreach (DirectoryInfo directory1 in directory.GetDirectories())
				list.AddRange ((IEnumerable<string>)this.GetFileNames (directory1, new List<string> ((IEnumerable<string>)path) {
					directory1.Name
				}.ToArray ()));
			return list.ToArray ();
		}
	}
}
