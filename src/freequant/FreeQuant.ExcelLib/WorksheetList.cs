using Interop.Excel;
using System.Reflection;

namespace FreeQuant.ExcelLib
{
	public class WorksheetList
	{
		private Sheets sheets;

		public int Count
		{
			get
			{
				return this.sheets.Count;
			}
		}

		public Worksheet this[int index]
		{
			get
			{
				return new Worksheet(this.sheets[index] as Interop.Excel.Worksheet);
			}
		}

		internal WorksheetList(Sheets sheets)
		{
			this.sheets = sheets;
		}

		public void Add()
		{
			this.sheets.Add(Missing.Value, Missing.Value, 1, XlSheetType.xlWorksheet);
		}

		public void AddLast()
		{
			this.sheets.Add(Missing.Value, this.sheets[this.sheets.Count], 1, XlSheetType.xlWorksheet);
		}
	}
}
