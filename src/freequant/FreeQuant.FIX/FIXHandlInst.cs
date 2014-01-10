using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXHandlInst : FIXCharField
  {
    public const char AutomatedExecutionOrderPrivate = '1';
    public const char AutomatedExecutionOrderPublic = '2';
    public const char ManualOrderBestExecution = '3';

    public FIXHandlInst(char val): base(21, val)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToString(char c)
    {
      switch (c)
      {
        case '1':
					return "AutomatedExecutionOrderPrivate";
        case '2':
					return "AutomatedExecutionOrderPublic";
        case '3':
					return "ManualOrderBestExecution";
        default:
					return "[unknow]";
      }
    }
  }
}
