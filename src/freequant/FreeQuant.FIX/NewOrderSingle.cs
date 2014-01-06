// Type: SmartQuant.FIX.NewOrderSingle
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class NewOrderSingle : FIXNewOrderSingle
  {
    public Side Side
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXSide.FromFIX(base.Side);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.Side = FIXSide.ToFIX(value);
      }
    }

    public OrdType OrdType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXOrdType.FromFIX(base.OrdType);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.OrdType = FIXOrdType.ToFIX(value);
      }
    }

    public TimeInForce TimeInForce
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXTimeInForce.FromFIX(base.TimeInForce);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.TimeInForce = FIXTimeInForce.ToFIX(value);
      }
    }

    public FaMethod FaMethod
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXFaMethod.FromFIX(base.FaMethod);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.FaMethod = FIXFaMethod.ToFIX(value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NewOrderSingle()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
