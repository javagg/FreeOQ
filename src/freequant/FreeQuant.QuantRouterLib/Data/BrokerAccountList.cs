// Type: SmartQuant.QuantRouterLib.Data.BrokerAccountList
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using NI8YCE6tH4BIeIEcEy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SmartQuant.QuantRouterLib.Data
{
  public class BrokerAccountList : ICollection, IEnumerable
  {
    private SortedList<string, BrokerAccount> yJ5u1odcpC;
    private List<BrokerAccount> ufGuL3AIDY;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ufGuL3AIDY.Count;
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

    public BrokerAccount this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ufGuL3AIDY[index];
      }
    }

    public BrokerAccount this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.yJ5u1odcpC[name];
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal BrokerAccountList()
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.yJ5u1odcpC = new SortedList<string, BrokerAccount>();
      this.ufGuL3AIDY = new List<BrokerAccount>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.ufGuL3AIDY.ToArray().CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.ufGuL3AIDY.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(BrokerAccount account)
    {
      this.yJ5u1odcpC.Add(account.Name, account);
      this.ufGuL3AIDY.Add(account);
    }
  }
}
