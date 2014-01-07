// Type: SmartQuant.Services.ServiceErrorList
// Assembly: SmartQuant.Services, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: BBD4879A-0902-4B9F-9A9A-214E03CD2FAE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Services.dll

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using yVXZ4JIJtSP6EX4fjq;

namespace SmartQuant.Services
{
  public class ServiceErrorList : ICollection, IEnumerable
  {
    private ArrayList hGPUy4Jmb;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.hGPUy4Jmb.Count;
      }
    }

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.hGPUy4Jmb.IsSynchronized;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.hGPUy4Jmb.SyncRoot;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ServiceErrorList()
    {
      BjOiEgGuG7SsSXTumY.w07s1ndzACihi();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.hGPUy4Jmb = new ArrayList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.hGPUy4Jmb.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.hGPUy4Jmb.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void EJUWWWMFm([In] ServiceError obj0)
    {
      this.hGPUy4Jmb.Add((object) obj0);
    }
  }
}
