using System;

namespace FreeQuant.Instruments
{
	public class PositionEventArgs : EventArgs
	{
		public Position Position { get; private set; }
		public PositionEventArgs(Position position) : base()
		{
			this.Position = position;
		}
	}
}
