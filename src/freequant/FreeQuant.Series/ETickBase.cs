namespace FreeQuant.Series
{
	public enum ETickBase
	{
		Ignore = -1,
		Second = 1,
		Minute = 60,
		FiveMinute = 60 * 5,
		FifteenMinute = 60 * 15,
		ThirtyMinute = 60 * 30,
		Hour = 60 * 60,
		FourHour = 4 * 60 * 60,
		Day = 24 * 60 * 60,
		Week = 7 * 24 * 60 * 60,
		Month = 4 * 7 * 24 * 60 * 60,
		Year = 12 * 4 * 7 * 24 * 60 * 60
	}
}
