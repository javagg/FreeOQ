using Interop.Excel;

namespace FreeQuant.ExcelLib
{
	public class WorkbookList
	{
		private Workbooks workbooks;

		public Workbook this[int index]
		{
			get
			{
				return new Workbook(this.workbooks[index]);
			}
		}

		public int Count
		{
			get
			{
				return this.workbooks.Count;
			}
		}

		internal WorkbookList(Workbooks workbooks)
		{
			this.workbooks = workbooks;
		}

		public Workbook Add()
		{
			return new Workbook(this.workbooks.Add(XlWBATemplate.xlWBATWorksheet));
		}
	}
}
