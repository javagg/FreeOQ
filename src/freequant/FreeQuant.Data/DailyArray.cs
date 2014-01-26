namespace FreeQuant.Data
{
	public class DailyArray : BarArray
	{
		new public Daily this[int index]
		{
			get
			{
				return base[index] as Daily;
			}
		}
	}
}
