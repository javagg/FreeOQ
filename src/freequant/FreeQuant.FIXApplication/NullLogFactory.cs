using QuickFix;

namespace FreeQuant.FIXApplication
{
	public class NullLogFactory : ILogFactory
	{
		public ILog create()
		{
			return new NullLog();
		}

		public ILog create(SessionID value)
		{
			return new NullLog();
		}
	}
}
