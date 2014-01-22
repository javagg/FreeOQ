using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.RoundTrips
{
  public class RoundTripListEnumerator : IEnumerator
  {
    private int fC8yjAcy31;
    private RoundTripList HZMyZ8mCTS;

    public object Current
    {
       get
      {
        return (object) this.HZMyZ8mCTS[this.fC8yjAcy31];
      }
    }

    
		public RoundTripListEnumerator(RoundTripList roundTripList):base() 
    {
      this.fC8yjAcy31 = -1;
      this.HZMyZ8mCTS = roundTripList;
    }

    
    public void Reset()
    {
      this.fC8yjAcy31 = -1;
    }

    
    public bool MoveNext()
    {
      return ++this.fC8yjAcy31 != this.HZMyZ8mCTS.Count;
    }
  }
}
