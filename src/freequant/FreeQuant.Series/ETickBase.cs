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
		FourHour = 14400,
		Day = 86400,
		Week = 604800,
		Month = 2419200,
		Year = 29030400,
	}
}
