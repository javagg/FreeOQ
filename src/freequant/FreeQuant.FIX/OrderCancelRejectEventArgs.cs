// Type: SmartQuant.FIX.OrderCancelRejectEventArgs
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class OrderCancelRejectEventArgs : EventArgs
  {
    private NewOrderSingle q7HQ2ja0mq;
    private OrderCancelReject UJYQc8UigN;

    public NewOrderSingle Order
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.q7HQ2ja0mq;
      }
    }

    public OrderCancelReject OrderCancelReject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.UJYQc8UigN;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrderCancelRejectEventArgs(NewOrderSingle order, OrderCancelReject reject)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.q7HQ2ja0mq = order;
      this.UJYQc8UigN = reject;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrderCancelRejectEventArgs(OrderCancelReject reject)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      this.\u002Ector((NewOrderSingle) null, reject);
    }
  }
}
