using FreeQuant.Instruments;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Testing.RoundTrips
{
  public class OpenRoundTripList : IEnumerable
  {
    private Hashtable t3XyVaLbw1;
    private ArrayList KxFygqIpbZ;

    public int Count
    {
       get
      {
        return this.KxFygqIpbZ.Count;
      }
    }

    public RoundTrip this[int index]
    {
       get
      {
        return this.KxFygqIpbZ[index] as RoundTrip;
      }
    }

    public RoundTrip this[Instrument instrument]
    {
       get
      {
        return this.t3XyVaLbw1[(object) instrument] as RoundTrip;
      }
    }

    
		public OpenRoundTripList(): base()
    {

      this.R6wycgOcBh();
    }

    
    private void R6wycgOcBh()
    {
      this.t3XyVaLbw1 = new Hashtable();
      this.KxFygqIpbZ = new ArrayList();
    }

    
    private void AWvyKropOG([In] RoundTrip obj0)
    {
      DateTime entryDateTime = obj0.EntryDateTime;
      int index = 0;
      int num1 = 0;
      int num2 = this.KxFygqIpbZ.Count - 1;
      bool flag = true;
      while (flag)
      {
        if (num2 < num1)
        {
          if (num1 == 0)
          {
            this.KxFygqIpbZ.Insert(0, (object) obj0);
            return;
          }
          else
          {
            this.KxFygqIpbZ.Insert(this.KxFygqIpbZ.Count, (object) obj0);
            return;
          }
        }
        else
        {
          index = (num1 + num2) / 2;
          if ((this.KxFygqIpbZ[index] as RoundTrip).EntryDateTime == entryDateTime && (index + 1 == this.KxFygqIpbZ.Count || (this.KxFygqIpbZ[index + 1] as RoundTrip).EntryDateTime > entryDateTime))
            flag = false;
          else if ((this.KxFygqIpbZ[index] as RoundTrip).EntryDateTime > entryDateTime)
            num2 = index - 1;
          else if ((this.KxFygqIpbZ[index] as RoundTrip).EntryDateTime <= entryDateTime)
            num1 = index + 1;
        }
      }
      this.KxFygqIpbZ.Insert(index, (object) obj0);
    }

    
    public void Add(RoundTrip roundTrip)
    {
      this.t3XyVaLbw1.Add((object) roundTrip.Instrument, (object) roundTrip);
      this.AWvyKropOG(roundTrip);
    }

    
    public void Remove(RoundTrip roundTrip)
    {
      this.t3XyVaLbw1.Remove((object) roundTrip.Instrument);
      this.KxFygqIpbZ.Remove((object) roundTrip);
    }

    
    public void Remove(Instrument instrument)
    {
      if (!this.t3XyVaLbw1.Contains((object) instrument))
        return;
      this.KxFygqIpbZ.Remove((object) (this.t3XyVaLbw1[(object) instrument] as RoundTrip));
      this.t3XyVaLbw1.Remove((object) instrument);
    }

    
    public void Clear()
    {
      this.t3XyVaLbw1.Clear();
      this.KxFygqIpbZ.Clear();
    }

    
    public bool Contains(RoundTrip roundTrip)
    {
      return this.KxFygqIpbZ.Contains((object) roundTrip);
    }

    
    public bool Contains(Instrument instrument)
    {
      return this.t3XyVaLbw1.Contains((object) instrument);
    }

    
    public IEnumerator GetEnumerator()
    {
      return this.KxFygqIpbZ.GetEnumerator();
    }
  }
}
