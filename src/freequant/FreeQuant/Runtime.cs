using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant
{
  public class Runtime
  {
    public RuntimeMode Mode
    {
      get
      {
				return RuntimeMode._64bit;
      }
    }

    internal Runtime()
    {
    }
  }
}
