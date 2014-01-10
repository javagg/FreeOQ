using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
	public class PositionEventArgs : EventArgs
	{
		private Position position;

		public Position Position
		{
			get
			{
				return this.position; 
			}
		}

		public PositionEventArgs(Position position) : base()
		{
			this.position = position;
		}
	}
}
