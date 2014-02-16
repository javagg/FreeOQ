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
				return new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory.TrimEnd(new char[] { Path.DirectorySeparatorChar }));
			}
		}

		public virtual DirectoryInfo Help
		{
			get
			{
				return new DirectoryInfo(Path.Combine(this.Base.FullName, "Help"));
			}
		}

		public virtual DirectoryInfo AppDataSource
		{
			get
			{
				return new DirectoryInfo(Path.Combine(this.Base.FullName, "Setup", "AppData"));
			}
		}

		public virtual DirectoryInfo DocumentsSource
		{
			get
			{
				return new DirectoryInfo(Path.Combine(this.Base.FullName, "Setup", "Documents"));
			}
		}
	}
}
