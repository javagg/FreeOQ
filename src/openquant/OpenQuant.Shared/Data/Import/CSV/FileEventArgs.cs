using System;
using System.IO;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class FileEventArgs : EventArgs
	{
		public FileInfo File { get; private set; }

		public FileStatus Status { get; private set; }

		public int ObjectCount { get; private set; }

		public FileEventArgs(FileInfo file, FileStatus status, int objectCount)
		{
			this.File = file;
			this.Status = status;
			this.ObjectCount = objectCount;
		}
	}
}
