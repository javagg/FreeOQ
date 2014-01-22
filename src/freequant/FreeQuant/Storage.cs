using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant
{
  public class Storage
  {
    public DbServerType ServerType
    {
      get
      {
				return DbServerType.MYSQL;
      }
    }
  }
}
