namespace FreeQuant.FIX
{
	public class ExecutionReportList : FIXGroupList
	{
        public new ExecutionReport this[int index]
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

        public new ExecutionReport GetById(int id)
		{
			return base.GetById(id) as ExecutionReport;
		}
	}
}
