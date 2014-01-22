using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.RoundTrips
{
  public class RoundTripListEventArgs
  {
    private int anFe9Vq0Nn;

    public int LastNotUpdatedIndex
    {
       get
      {
        return this.anFe9Vq0Nn;
      }
    }

    
		public RoundTripListEventArgs(int lastNotUpdatedIndex):base() 
    {

      this.anFe9Vq0Nn = lastNotUpdatedIndex;
    }
  }
}
