namespace FreeQuant.Data
{
	public class BarSize
	{
		public const long Second = 1;
		public const long Minute = 60;
		public const long Hour = 60 * 60;             // 3600
		public const long Day = 24 * 60 * 60;         // 86400
		public const long Week = 7 * 24 * 60 * 60;    // 604800
		public const long Month = 30 * 24 * 60 * 60;  // 2592000
		public const long Year = 365 * 24 * 60 * 60;  // 31536000;
	}
}
