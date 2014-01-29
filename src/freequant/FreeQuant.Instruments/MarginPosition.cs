namespace FreeQuant.Instruments
{
	public class MarginPosition
	{
		public Position Position { get; set; }

		public double Margin { get; set; }

		public MarginPosition(Position position)
		{
			this.Position = position;
		}

		public MarginPosition(Position position, double margin)
		{
			this.Position = position;
			this.Margin = margin;
		}
	}
}
