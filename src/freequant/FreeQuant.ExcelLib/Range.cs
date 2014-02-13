namespace FreeQuant.ExcelLib
{
	public class Range
	{
		private Interop.Excel.Range range;

		public bool Italic
		{
			set
			{
				this.range.Font.Italic = value ? 1 : 0;
			}
		}

		public bool Bold
		{
			set
			{
				this.range.Font.Bold = value ? 1 : 0;
			}
		}

		public bool Underline
		{
			set
			{
				this.range.Font.Underline = value ? 1 : 0;
			}
		}

		public object Value
		{
			get
			{
				return this.range.Value2;
			}
			set
			{
				this.range.Value2 = value;
			}
		}

		internal Range(Interop.Excel.Range range)
		{
			this.range = range;
		}

		public void Select()
		{
			this.range.Select();
		}
	}
}
