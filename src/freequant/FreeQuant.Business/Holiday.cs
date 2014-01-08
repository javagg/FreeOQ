using System;

namespace FreeQuant.Business
{
	[Serializable]
	public class Holiday
	{
		private string name;
		private string description;
		private DateTime date;

		public string Name
		{
			get
			{
				return this.name; 
			}
			set
			{
				this.name = value;
			}
		}

		public string Description
		{
			get
			{
				return this.description; 
			}
			set
			{
				this.description = value;
			}
		}

		public DateTime Date
		{
			get
			{
				return this.date; 
			}
			set
			{
				this.date = value;
			}
		}

		public Holiday(DateTime date, string name)
		{
			this.date = this.Date;
			this.name = name;
		}

		public Holiday(DateTime date, string name, string description)
		{
			this.date = date;
			this.name = name;
			this.description = description;
		}
	}
}
