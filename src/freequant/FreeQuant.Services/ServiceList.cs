// Type: SmartQuant.Services.ServiceList
// Assembly: SmartQuant.Services, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: BBD4879A-0902-4B9F-9A9A-214E03CD2FAE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Services.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using yVXZ4JIJtSP6EX4fjq;

namespace SmartQuant.Services
{
  public class ServiceList : ICollection, IEnumerable
  {
    private SortedList<string, IService> l6LAy7BYb;
    private SortedList<byte, IService> wsSykLPBq;
    private List<IService> Vag5R41WI;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Vag5R41WI.Count;
      }
    }

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return false;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (object) null;
      }
    }

    public IService this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        IService service;
        if (this.l6LAy7BYb.TryGetValue(name, out service))
          return service;
        else
          return (IService) null;
      }
    }

    public IService this[byte id]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        IService service;
        if (this.wsSykLPBq.TryGetValue(id, out service))
          return service;
        else
          return (IService) null;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ServiceList()
    {
      BjOiEgGuG7SsSXTumY.w07s1ndzACihi();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.l6LAy7BYb = new SortedList<string, IService>();
      this.wsSykLPBq = new SortedList<byte, IService>();
      this.Vag5R41WI = new List<IService>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.Vag5R41WI.ToArray().CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.Vag5R41WI.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void jLl6RmfZp([In] IService obj0)
    {
      this.l6LAy7BYb.Add(obj0.Name, obj0);
      this.wsSykLPBq.Add(obj0.Id, obj0);
      this.k7BVcoadr();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void k7BVcoadr()
    {
      this.Vag5R41WI.Clear();
      foreach (IService service in (IEnumerable<IService>) this.l6LAy7BYb.Values)
        this.Vag5R41WI.Add(service);
    }
  }
}
