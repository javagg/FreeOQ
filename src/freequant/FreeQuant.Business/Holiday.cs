using System;

namespace FreeQuant.Business
{
	[Serializable]
	public class Holiday
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime Date { get; set; }

		public Holiday(DateTime date, string name, string description = null)
		{
			this.Date = date;
			this.Name = name;
			this.Description = description;
		}
	}
}
