using QuickFix;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIXApplication
{
  public class NullLogFactory : LogFactory
  {

    public Log create()
    {
      return (Log) new WD6JNiar276TG6CxuK();
    }

    public Log create(SessionID value)
    {
      return (Log) new WD6JNiar276TG6CxuK();
    }
  }
}
