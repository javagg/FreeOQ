using System;

namespace FreeQuant.FinChart.Objects
{
	public class DrawingPoint : IUpdatable
	{
		private DateTime x;
		private double y;

		public DateTime X
		{
			get
			{
				return this.x; 
			}
			set
			{
				this.x = value;
				this.EmitUpdated();
			}
		}

		public double Y
		{
			get
			{
				return this.y; 
			}
			set
			{
				this.y = value;
				this.EmitUpdated();
			}
		}

		public event EventHandler Updated;

		public DrawingPoint(DateTime x, double y) : base()
		{
			this.x = x;
			this.y = y;
		}

		private void EmitUpdated()
		{
			if (this.Updated == null)
				return;
			this.Updated(this, EventArgs.Empty);
		}
	}
}
