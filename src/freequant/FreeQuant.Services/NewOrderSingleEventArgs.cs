// Type: SmartQuant.Services.NewOrderSingleEventArgs
// Assembly: SmartQuant.Services, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: BBD4879A-0902-4B9F-9A9A-214E03CD2FAE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Services.dll

using SmartQuant.FIX;
using System.Runtime.CompilerServices;
using yVXZ4JIJtSP6EX4fjq;

namespace SmartQuant.Services
{
  public class NewOrderSingleEventArgs : ExecutionServiceEventArgs
  {
    private FIXNewOrderSingle ghvwA1jOi;

    public FIXNewOrderSingle Order
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ghvwA1jOi;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NewOrderSingleEventArgs(IExecutionService service, FIXNewOrderSingle order)
    {
      BjOiEgGuG7SsSXTumY.w07s1ndzACihi();
      // ISSUE: explicit constructor call
      base.\u002Ector(service);
      this.ghvwA1jOi = order;
    }
  }
}
