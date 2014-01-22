using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Simulation
{
  public class ExceptionEventArgs : EventArgs
  {
    private Exception D4VelgZ5i4;

    public Exception Exception
    {
       get
      {
        return this.D4VelgZ5i4;
      }
    }

    
		public ExceptionEventArgs(Exception exception):base()
    {
      this.D4VelgZ5i4 = exception;
    }
  }
}
