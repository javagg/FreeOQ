using System;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class DateOptions
	{
		private DateTime date;

		public DateType DateType { get; set; }

		public DateTime Date
		{
			get
			{
				return this.date.Date;
			}
			set
			{
				this.date = value.Date;
			}
		}

		public DateOptions()
		{
			this.DateType = DateType.Column;
			this.date = DateTime.Today;
		}
	}
}
