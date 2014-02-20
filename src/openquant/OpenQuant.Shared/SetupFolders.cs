using System;
using System.IO;

namespace OpenQuant.Shared
{
	public class SetupFolders
	{
		public virtual DirectoryInfo Base
		{
			get
			{
                return Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory.TrimEnd(new char[] { Path.DirectorySeparatorChar }));
			}
		}

		public virtual DirectoryInfo Help
		{
			get
			{
                return Directory.CreateDirectory(Path.Combine(this.Base.FullName, "Help"));
			}
		}

		public virtual DirectoryInfo AppDataSource
		{
			get
			{
                return Directory.CreateDirectory(Path.Combine(this.Base.FullName, "Setup", "AppData"));
			}
		}

		public virtual DirectoryInfo DocumentsSource
		{
			get
			{
                return Directory.CreateDirectory(Path.Combine(this.Base.FullName, "Setup", "Documents"));
			}
		}
	}
}
