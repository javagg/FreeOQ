// Type: SmartQuant.FIX.FIXContraBrokersGroup
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXContraBrokersGroup : FIXGroup
  {
    [FIXField("375", EFieldOption.Optional)]
    public string ContraBroker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(375).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(375, value);
      }
    }

    [FIXField("337", EFieldOption.Optional)]
    public string ContraTrader
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(337).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(337, value);
      }
    }

    [FIXField("437", EFieldOption.Optional)]
    public double ContraTradeQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(437).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(437, value);
      }
    }

    [FIXField("438", EFieldOption.Optional)]
    public DateTime ContraTradeTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeField(438).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDateTimeField(438, value);
      }
    }

    [FIXField("655", EFieldOption.Optional)]
    public string ContraLegRefID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(655).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(655, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXContraBrokersGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
