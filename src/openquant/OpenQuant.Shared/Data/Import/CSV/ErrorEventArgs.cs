using System;
using System.IO;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class ErrorEventArgs : EventArgs
	{
		public FileInfo File { get; private set; }

		public string Line { get; private set; }

		public string Message { get; private set; }

		public int Row { get; private set; }

		public int Column { get; private set; }

		public ErrorEventArgs(FileInfo file, string line, string message, int row, int column)
		{
			this.File = file;
			this.Line = line;
			this.Message = message;
			this.Row = row;
			this.Column = column;
		}
	}
}
