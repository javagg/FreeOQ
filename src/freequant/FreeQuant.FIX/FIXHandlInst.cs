// Type: SmartQuant.FIX.FIXHandlInst
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using iL6jh33hEcPk05eVIF;
using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXHandlInst : FIXCharField
  {
    public const char AutomatedExecutionOrderPrivate = '1';
    public const char AutomatedExecutionOrderPublic = '2';
    public const char ManualOrderBestExecution = '3';

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXHandlInst(char val)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(21, val);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToString(char c)
    {
      switch (c)
      {
        case '1':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3570);
        case '2':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3634);
        case '3':
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3696);
        default:
          return Ugjylcah9mCMM4kO7N.tLah92SpBQ(3748);
      }
    }
  }
}
