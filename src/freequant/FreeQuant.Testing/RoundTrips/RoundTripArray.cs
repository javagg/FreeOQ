using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.RoundTrips
{
  public class RoundTripArray : ICollection, IEnumerable
  {
    protected ArrayList array;

    public RoundTrip this[int index]
    {
      get
      {
        return this.array[index] as RoundTrip;
      }
    }

    public bool IsSynchronized
    {
      get
      {
        return this.array.IsSynchronized;
      }
    }

    public int Count
    {
      get
      {
        return this.array.Count;
      }
    }

    public object SyncRoot
    {
      get
      {
        return this.array.SyncRoot;
      }
    }

   
		public RoundTripArray(ArrayList array):base() 
    {

      this.array = array;
    }

   
		public RoundTripArray():base() 
    {

      this.array = new ArrayList();
    }

   
    public bool Contains(RoundTrip roundTrip)
    {
      return this.array.Contains((object) roundTrip);
    }

   
    public void Clear()
    {
      this.array.Clear();
    }

   
    public void Add(RoundTrip roundTrip)
    {
      this.array.Add((object) roundTrip);
    }

   
    public void CopyTo(Array array, int index)
    {
      array.CopyTo(array, index);
    }

   
    public IEnumerator GetEnumerator()
    {
      return this.array.GetEnumerator();
    }
  }
}
