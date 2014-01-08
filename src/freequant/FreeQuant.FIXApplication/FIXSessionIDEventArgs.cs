using QuickFix;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIXApplication
{
	public class FIXSessionIDEventArgs : EventArgs
	{
		public SessionID SessionID { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

		public FIXSessionIDEventArgs(SessionID sessionID)
		{
			this.SessionID = sessionID;
		}
	}
}
