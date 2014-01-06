// Type: SmartQuant.FIX.ExecutionReportList
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class ExecutionReportList : FIXGroupList
  {
    public ExecutionReport this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fList[index] as ExecutionReport;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExecutionReportList()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator ExecutionReport[](ExecutionReportList list)
    {
      ExecutionReport[] executionReportArray = new ExecutionReport[list.Count];
      for (int index = 0; index < executionReportArray.Length; ++index)
        executionReportArray[index] = list[index];
      return executionReportArray;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExecutionReport GetById(int id)
    {
      return base.GetById(id) as ExecutionReport;
    }
  }
}
