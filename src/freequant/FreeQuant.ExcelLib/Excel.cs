using Interop.Excel;

namespace FreeQuant.ExcelLib
{
	public class Excel
	{
		private Application app;
		private WorkbookList wbList;

		public bool Visible
		{
			get
			{
				return this.app.Visible;
			}
			set
			{
				this.app.Visible = value;
			}
		}

		public WorkbookList Workbooks
		{
			get
			{
				return this.wbList;
			}
		}

		public Excel()
		{
			this.app = new ApplicationClass();
			this.wbList = new WorkbookList(this.app.Workbooks);
		}
	}
}
