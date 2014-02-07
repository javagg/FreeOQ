namespace FreeQuant.Data
{
	public class DailyArray : BarArray
	{
		public new Daily this[int index]
		{
			get
			{
				return base[index] as Daily;
			}
		}

		public DailyArray() : base()
		{
		}
	}
}
