using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
	public class MarginPosition
	{
		public Position position;
		public double margin;

		public Position Position
		{
			get
			{
				return this.position;
			}
			set
			{
				this.position = value;
			}
		}

		public double Margin
		{
			get
			{
				return this.margin;
			}
			set
			{
				this.margin = value;
			}
		}

		public MarginPosition(Position position)
		{
			this.position = position;
		}

		public MarginPosition(Position position, double margin)
		{
			this.position = position;
			this.margin = margin;
		}
	}
}
