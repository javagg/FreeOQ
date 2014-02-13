using System;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class ProgressEventArgs : EventArgs
	{
		public int Progress { get; private set; }

		public ProgressEventArgs(int progress)
		{
			this.Progress = progress;
		}
	}
}
