namespace FreeQuant.Data
{
	public class DailyArray : BarArray
	{
		public Daily this[int index]
		{
			get
			{
				return base[index] as Daily;
			}
		}
	}
}
