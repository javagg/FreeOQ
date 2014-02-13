using System;

namespace OpenQuant.Shared.Updates
{
	public class ReleaseInfo
	{
		public Version Version { get; internal set; }

		public DateTime Date { get; internal set; }

		public NoteInfo[] Notes { get; internal set; }

		public Uri Url86 { get; internal set; }

		public Uri Url64 { get; internal set; }

		internal ReleaseInfo()
		{
		}
	}
}
