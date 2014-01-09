using QuickFix;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIXApplication
{
	public class NullLogFactory : LogFactory
	{
		public Log create()
		{
			return new NullLog();
		}

		public Log create(SessionID value)
		{
			return new NullLog();
		}
	}
}
