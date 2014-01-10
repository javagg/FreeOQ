using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
	public class FIXTradSesStatus : FIXIntField
	{
		public const int Halted = 1;
		public const int Open = 2;
		public const int Closed = 3;
		public const int PreOpen = 4;
		public const int PreClose = 5;

		public FIXTradSesStatus(int value) : base(340, value)
		{
		}

		public static string ToString(int value)
		{
			switch (value)
			{
				case 1:
					return "Halted";


				case 2:
					return "Open";
				case 3:
					return "Closed";
				case 4:
					return "PreOpen";
				case 5:
					return "PreClose";
				default:
					return "Unknown";
			}
		}
	}
}
