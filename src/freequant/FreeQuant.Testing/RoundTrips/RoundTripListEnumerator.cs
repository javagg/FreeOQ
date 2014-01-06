// Type: SmartQuant.Testing.RoundTrips.RoundTripListEnumerator
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.RoundTrips
{
  public class RoundTripListEnumerator : IEnumerator
  {
    private int fC8yjAcy31;
    private RoundTripList HZMyZ8mCTS;

    public object Current
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (object) this.HZMyZ8mCTS[this.fC8yjAcy31];
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RoundTripListEnumerator(RoundTripList roundTripList)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fC8yjAcy31 = -1;
      this.HZMyZ8mCTS = roundTripList;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset()
    {
      this.fC8yjAcy31 = -1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool MoveNext()
    {
      return ++this.fC8yjAcy31 != this.HZMyZ8mCTS.Count;
    }
  }
}
