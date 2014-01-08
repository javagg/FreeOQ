using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class RequestList : CollectionBase
  {
    public string this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.InnerList[index] as string;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RequestList()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(string request)
    {
      this.List.Add((object) request);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(string request)
    {
      if (!this.List.Contains((object) request))
        return;
      this.List.Remove((object) request);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(string request)
    {
      return this.InnerList.Contains((object) request);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInsert(int index, object value)
    {
      if (value == null)
        throw new ArgumentNullException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5364), USaG3GpjZagj1iVdv4u.Y4misFk9D9(5378));
      string str = value as string;
      if (str == null)
        throw new ArgumentException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5436) + value.GetType().ToString());
      if (this.InnerList.Contains((object) str))
        throw new ArgumentException(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5482) + str);
    }
  }
}
