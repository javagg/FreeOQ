// Type: SmartQuant.Services.ExecutionServiceList
// Assembly: SmartQuant.Services, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: BBD4879A-0902-4B9F-9A9A-214E03CD2FAE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Services.dll

using System.Runtime.CompilerServices;
using yVXZ4JIJtSP6EX4fjq;

namespace SmartQuant.Services
{
  public class ExecutionServiceList : ServiceList
  {
    public IExecutionService this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return base[name] as IExecutionService;
      }
    }

    public IExecutionService this[byte id]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return base[id] as IExecutionService;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExecutionServiceList()
    {
      BjOiEgGuG7SsSXTumY.w07s1ndzACihi();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
