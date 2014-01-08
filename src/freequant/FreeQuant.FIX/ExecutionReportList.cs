using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class ExecutionReportList : FIXGroupList
  {
    public ExecutionReport this[int index]
    {
       get
      {
        return this.fList[index] as ExecutionReport;
      }
    }

    public static implicit operator ExecutionReport[](ExecutionReportList list)
    {
      ExecutionReport[] executionReportArray = new ExecutionReport[list.Count];
      for (int index = 0; index < executionReportArray.Length; ++index)
        executionReportArray[index] = list[index];
      return executionReportArray;
    }

    public ExecutionReport GetById(int id)
    {
      return base.GetById(id) as ExecutionReport;
    }
  }
}
