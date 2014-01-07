// Type: SmartQuant.QuantRouterLib.Data.BrokerPosition
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using NI8YCE6tH4BIeIEcEy;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SmartQuant.QuantRouterLib.Data
{
  public class BrokerPosition
  {
    private string w4Bu6TX4jY;
    private string jIyuaxH31X;
    private string WAouGOUGDd;
    private string Va4uk7htSh;
    private DateTime rlKu3i5Hq2;
    private int Ku8uRTIaXL;
    private double iulufI5D1D;
    private double h6bu00fIoi;
    private double lxduUlk6Q3;
    private double lpCuONpjxD;
    private SortedList<string, string> Qebu97XTcP;

    public string Symbol
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.w4Bu6TX4jY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.w4Bu6TX4jY = value;
      }
    }

    public string SecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jIyuaxH31X;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.jIyuaxH31X = value;
      }
    }

    public string SecurityExchange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WAouGOUGDd;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.WAouGOUGDd = value;
      }
    }

    public string Currency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Va4uk7htSh;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Va4uk7htSh = value;
      }
    }

    public DateTime MaturityDate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.rlKu3i5Hq2;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.rlKu3i5Hq2 = value;
      }
    }

    public int PutOrCall
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Ku8uRTIaXL;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Ku8uRTIaXL = value;
      }
    }

    public double Strike
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.iulufI5D1D;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.iulufI5D1D = value;
      }
    }

    public double Qty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.h6bu00fIoi;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.h6bu00fIoi = value;
      }
    }

    public double LongQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.lxduUlk6Q3;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.lxduUlk6Q3 = value;
      }
    }

    public double ShortQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.lpCuONpjxD;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.lpCuONpjxD = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BrokerPosition()
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.w4Bu6TX4jY = string.Empty;
      this.jIyuaxH31X = string.Empty;
      this.WAouGOUGDd = string.Empty;
      this.Va4uk7htSh = string.Empty;
      this.rlKu3i5Hq2 = DateTime.MinValue;
      this.Ku8uRTIaXL = 0;
      this.iulufI5D1D = 0.0;
      this.h6bu00fIoi = 0.0;
      this.lxduUlk6Q3 = 0.0;
      this.lpCuONpjxD = 0.0;
      this.Qebu97XTcP = new SortedList<string, string>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddCustomField(string name, string value)
    {
      this.Qebu97XTcP.Add(name, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BrokerPositionField[] GetCustomFields()
    {
      List<BrokerPositionField> list = new List<BrokerPositionField>();
      foreach (KeyValuePair<string, string> keyValuePair in this.Qebu97XTcP)
        list.Add(new BrokerPositionField(keyValuePair.Key, keyValuePair.Value));
      return list.ToArray();
    }
  }
}
