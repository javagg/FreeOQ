using System;

namespace FreeQuant.FIX
{
	public class FIXListCancelRequestEventArgs : EventArgs
	{
		public FIXListCancelRequest ListCancelRequest { get; set; }

		public FIXListCancelRequestEventArgs(FIXListCancelRequest listCancelRequest)
		{
			this.ListCancelRequest = listCancelRequest;
		}
	}
}
