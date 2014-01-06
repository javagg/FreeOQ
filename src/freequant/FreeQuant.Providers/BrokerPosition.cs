// Type: SmartQuant.Providers.BrokerPosition
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using dW79p7NPlS6ZxObcx3;
using SmartQuant.FIX;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SmartQuant.Providers
{
  public class BrokerPosition
  {
    private string jRxx0BXt1;
    private string dFWE8WPjx;
    private string Tw4Hxt2Cq;
    private string cS7A3TaAk;
    private DateTime wwNacbMO9;
    private PutOrCall VS64GROvE;
    private double H77FCo1R9;
    private double Q5OUEr8NS;
    private double DCpksBxeD;
    private double yPi0BmEIj;
    private SortedList<string, string> j7IhoCdXp;

    public string Symbol
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jRxx0BXt1;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.jRxx0BXt1 = value;
      }
    }

    public string SecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.dFWE8WPjx;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.dFWE8WPjx = value;
      }
    }

    public string SecurityExchange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Tw4Hxt2Cq;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Tw4Hxt2Cq = value;
      }
    }

    public string Currency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.cS7A3TaAk;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.cS7A3TaAk = value;
      }
    }

    public DateTime MaturityDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.wwNacbMO9;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.wwNacbMO9 = value;
      }
    }

    public PutOrCall PutOrCall
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.VS64GROvE;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.VS64GROvE = value;
      }
    }

    public double Strike
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.H77FCo1R9;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.H77FCo1R9 = value;
      }
    }

    public double Qty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Q5OUEr8NS;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Q5OUEr8NS = value;
      }
    }

    public double LongQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.DCpksBxeD;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.DCpksBxeD = value;
      }
    }

    public double ShortQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.yPi0BmEIj;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.yPi0BmEIj = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BrokerPosition()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.jRxx0BXt1 = string.Empty;
      this.dFWE8WPjx = string.Empty;
      this.Tw4Hxt2Cq = string.Empty;
      this.cS7A3TaAk = string.Empty;
      this.wwNacbMO9 = DateTime.MinValue;
      this.VS64GROvE = PutOrCall.Put;
      this.H77FCo1R9 = 0.0;
      this.Q5OUEr8NS = 0.0;
      this.DCpksBxeD = 0.0;
      this.yPi0BmEIj = 0.0;
      this.j7IhoCdXp = new SortedList<string, string>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddCustomField(string name, string value)
    {
      this.j7IhoCdXp.Add(name, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BrokerPositionField[] GetCustomFields()
    {
      List<BrokerPositionField> list = new List<BrokerPositionField>();
      foreach (KeyValuePair<string, string> keyValuePair in this.j7IhoCdXp)
        list.Add(new BrokerPositionField(keyValuePair.Key, keyValuePair.Value));
      return list.ToArray();
    }
  }
}
