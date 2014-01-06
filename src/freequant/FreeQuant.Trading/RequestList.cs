// Type: SmartQuant.Trading.RequestList
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SlN8f6pWyHStvuMgWbM;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
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
