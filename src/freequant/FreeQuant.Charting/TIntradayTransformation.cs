using System;
using System.Runtime.InteropServices;

namespace FreeQuant.Charting
{
	[Serializable]
	public class TIntradayTransformation : IChartTransformation
	{
		private long firstSessionTick;
		private long lastSessionTick;
		private long session;
		private long gWjCgJN3TA;
		private bool sessionGridEnabled;

		public long FirstSessionTick
		{
			get
			{
				return this.firstSessionTick; 
			}
			set
			{
				this.firstSessionTick = value;
				this.session = this.lastSessionTick - this.firstSessionTick;
			}
		}

		public long LastSessionTick
		{
			get
			{
				return this.lastSessionTick;  
			}
			set
			{
				this.lastSessionTick = value;
				this.session = this.lastSessionTick - this.firstSessionTick;
			}
		}

		public long Session
		{
			get
			{
				return this.session; 
			}
		}

		public bool SessionGridEnabled
		{
			get
			{
				return this.sessionGridEnabled; 
			}
			set
			{
				this.sessionGridEnabled = value;
			}
		}

		public TIntradayTransformation()
		{
			this.SessionGridEnabled = true;
			this.SetSessionBounds(0, 864000000000);
		}

		public TIntradayTransformation(long FirstSessionTick, long LastSessionTick)
		{
			this.SessionGridEnabled = true;
			this.SetSessionBounds(FirstSessionTick, LastSessionTick);
		}

		public void SetSessionBounds(long FirstSessionTick, long LastSessionTick)
		{
			this.firstSessionTick = FirstSessionTick;
			this.lastSessionTick = LastSessionTick;
			this.session = this.lastSessionTick - this.firstSessionTick;
		}

		public void GetFirstGridDivision(ref EGridSize gridSize, ref double min, ref double max, ref DateTime firstDateTime)
		{
			if ((max - min) / (double)this.session <= 10.0)
			{
				gridSize = Axis.CalculateSize(max - min);
				max = min + this.CalculateRealQuantityOfTicks_Right(min, max);
			}
			else
			{
				max = min + this.CalculateRealQuantityOfTicks_Right(min, max);
				gridSize = Axis.CalculateSize(max - min);
			}
			this.gWjCgJN3TA = this.af0CimWcds((long)min, (long)gridSize);
			if ((long)min / 864000000000L - (long)((long)min + this.gWjCgJN3TA + gridSize) / 864000000000L < 0L && gridSize < (EGridSize)576000000000)
			{
				min += (double)this.BOvCDY6BLq((long)min, (long)gridSize);
				this.gWjCgJN3TA = this.af0CimWcds((long)min, (long)gridSize);
			}
			if (gridSize < (EGridSize)576000000000)
				firstDateTime = new DateTime((long)min + this.gWjCgJN3TA);
			else
				this.gWjCgJN3TA = -this.firstSessionTick;
		}

		public double GetNextGridDivision(double firstTick, double prevMajor, int majorCount, EGridSize gridSize)
		{
			return majorCount != 0 ? (gridSize >= (EGridSize)576000000000 ? (double)Axis.GetNextMajor((long)prevMajor, gridSize) : this.x4KCNJAMeJ(prevMajor, (long)gridSize)) : (double)this.B63C22nX2q((long)firstTick - this.gWjCgJN3TA);
		}

		private double x4KCNJAMeJ([In] double obj0, [In] long obj1)
		{
			double num1 = 0.0;
			if (obj0 > 10000.0)
			{
				if (obj0 % 864000000000.0 < (double)this.firstSessionTick)
					obj0 = (double)((long)obj0 / 864000000000L * 864000000000L + this.firstSessionTick);
				else if (obj0 % 864000000000.0 > (double)this.lastSessionTick)
					obj0 = (double)(((long)obj0 / 864000000000L + 1L) * 864000000000L + this.firstSessionTick);
				double num2 = (double)((long)obj0 / 864000000000L * 864000000000L + this.lastSessionTick);
				double num3 = num2 - obj0;
				num1 = num3 >= (double)obj1 ? obj0 + (double)obj1 : num2 + 864000000000.0 - (double)this.session - num3 + (double)obj1;
			}
			return num1;
		}

		private long B63C22nX2q([In] long obj0)
		{
			long num = 0L;
			if (obj0 > 10000L)
				num = obj0 % 864000000000L < this.firstSessionTick || obj0 % 864000000000L > this.lastSessionTick ? this.B63C22nX2q(obj0 + 864000000000L - this.session) : obj0;
			return num;
		}

		public double CalculateRealQuantityOfTicks_Right(double x, double y)
		{
			long num1 = (long)(y - x) / this.session * 864000000000L;
			long num2 = (long)(y - x) % this.session;
			return (double)((long)(x + (double)num1) / 864000000000L * 864000000000L + this.lastSessionTick) - (x + (double)num1) < (double)num2 ? (double)(num1 + num2 + 864000000000L - this.session) : (double)(num1 + num2);
		}

		public double CalculateRealQuantityOfTicks_Left(double x, double y)
		{
			long num1 = (long)(x - y) / this.session * 864000000000L;
			long num2 = (long)(x - y) % this.session;
			long num3 = (long)(x - (double)num1) / 864000000000L * 864000000000L + this.firstSessionTick;
			return (double)-(x - (double)num1 - (double)num3 < (double)num2 ? num1 + num2 + 864000000000L - this.session : num1 + num2);
		}

		private long af0CimWcds([In] long obj0, [In] long obj1)
		{
			obj0 = obj0 / 864000000000L * 864000000000L + this.firstSessionTick;
			return -((obj0 - this.firstSessionTick) / 864000000000L) * ((864000000000L - this.session) % obj1) % obj1;
		}

		private long BOvCDY6BLq([In] long obj0, [In] long obj1)
		{
			if ((obj0 + obj1) / 864000000000L - obj0 / 864000000000L > 0L && (obj0 + obj1) % 864000000000L > this.firstSessionTick && obj1 < 576000000000L)
				return (obj0 / 864000000000L + 1L) * 864000000000L + this.firstSessionTick - obj0;
			else
				return 0L;
		}

		public double CalculateNotInSessionTicks(double x, double y)
		{
			if (y <= 10000.0)
				return 0.0;
			long num1 = (long)x % 864000000000L;
			long num2 = (long)y % 864000000000L;
			double num3 = (double)((long)x / 864000000000L * 864000000000L);
			double num4 = (double)((long)y / 864000000000L * 864000000000L);
			double num5 = 0.0;
			double num6 = 0.0;
			double num7 = num3 + (double)this.lastSessionTick;
			if (num1 < this.firstSessionTick)
				num5 = (double)(this.firstSessionTick - num1);
			if (num1 > this.lastSessionTick)
				num5 = (double)(this.firstSessionTick + 864000000000L - num1);
			double num8 = num4 + (double)this.lastSessionTick;
			if (num2 < this.firstSessionTick)
				num6 = (double)(-this.firstSessionTick + num2);
			if (num2 > this.lastSessionTick)
				num6 = (double)(num2 - this.lastSessionTick);
			return num5 + num6 + (double)(864000000000L - this.session) * ((num8 - num7) / 864000000000.0);
		}
	}
}
