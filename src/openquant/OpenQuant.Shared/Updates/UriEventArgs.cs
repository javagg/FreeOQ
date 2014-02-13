using System;

namespace OpenQuant.Shared.Updates
{
	public class UriEventArgs : EventArgs
	{
		public Uri Uri { get; private set; }

		public UriEventArgs(Uri uri)
		{
			this.Uri = uri;
		}
	}
}
