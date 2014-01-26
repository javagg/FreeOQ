using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class RequestList : CollectionBase
  {
    public string this[int index]
    {
      get
      {
        return this.InnerList[index] as string;
      }
    }

   
		public RequestList():base()
    {
    }

   
    public void Add(string request)
    {
      this.List.Add((object) request);
    }

   
    public void Remove(string request)
    {
      if (!this.List.Contains((object) request))
        return;
      this.List.Remove((object) request);
    }

   
    public bool Contains(string request)
    {
      return this.InnerList.Contains((object) request);
    }

   
    protected override void OnInsert(int index, object value)
    {
      if (value == null)
				throw new ArgumentNullException("dfdfs", "fdsf");
      string str = value as string;
      if (str == null)
        throw new ArgumentException(value.GetType().ToString());
      if (this.InnerList.Contains((object) str))
        throw new ArgumentException(str);
    }
  }
}
