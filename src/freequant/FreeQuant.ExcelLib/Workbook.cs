namespace FreeQuant.ExcelLib
{
	public class Workbook
	{
		private Interop.Excel.Workbook workbook;

		public WorksheetList Worksheets
		{
			get
			{
				return new WorksheetList(this.workbook.Worksheets);
			}
		}

		internal Workbook(Interop.Excel.Workbook workbook)
		{
			this.workbook = workbook;
		}
	}
}
