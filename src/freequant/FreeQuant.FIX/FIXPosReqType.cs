using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
	public class FIXPosReqType : FIXIntField
	{
		public const int Positions = 0;
		public const int Trades = 1;
		public const int Exercises = 2;
		public const int Assignments = 3;

		public static PosReqType FromFIX(int value)
		{
			switch (value)
			{
				case Positions:
					return PosReqType.Positions;
				case Trades:
					return PosReqType.Trades;
				case Exercises:
					return PosReqType.Exercises;
				case Assignments:
					return PosReqType.Assignments;
				default:
					throw new ArgumentException(string.Format("value not supported {0}", value));
			}
		}

		public static int ToFIX(PosReqType value)
		{
			switch (value)
			{
				case PosReqType.Positions:
					return Positions;
				case PosReqType.Trades:
					return Trades;
				case PosReqType.Exercises:
					return Exercises;
				case PosReqType.Assignments:
					return Assignments;
				default:
					throw new ArgumentException(string.Format("value not supported {0}", value));
			}
		}
	}
}
