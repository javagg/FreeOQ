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
			ExecutionReport[] array = new ExecutionReport[list.Count];
			for (int i = 0; i < array.Length; ++i)
				array[i] = list[i];
			return array;
		}

		public ExecutionReport GetById(int id)
		{
			return base.GetById(id) as ExecutionReport;
		}
	}
}
