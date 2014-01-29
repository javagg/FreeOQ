using System;
using System.Drawing;

namespace FreeQuant.FinChart.Objects
{
	public class DrawingLine : IUpdatable
	{
		private DateTime x1;
		private DateTime x2;
		private double y1;
		private double y2;
		public bool rangeY;
		private Color color;
		private int width;

		public bool RangeY
		{
			get
			{
				return this.rangeY;
			}
			set
			{
				this.rangeY = value;
				this.EmitUpdated();
			}
		}

		public Color Color
		{
			get
			{
				return this.color; 
			}
			set
			{
				this.color = value;
				this.EmitUpdated();
			}
		}

		public int Width
		{
			get
			{
				return this.width; 
			}
			set
			{
				this.width = value;
				this.EmitUpdated();
			}
		}

		public string Name { get; private set; }

		public DateTime X1
		{
			get
			{
				return this.x1; 
			}
			set
			{
				this.x1 = value;
				this.EmitUpdated();
			}
		}

		public DateTime X2
		{
			get
			{
				return this.x2; 
			}
			set
			{
				this.x2 = value;
				this.EmitUpdated();
			}
		}

		public double Y1
		{
			get
			{
				return this.y1; 
			}
			set
			{
				this.y1 = value;
				this.EmitUpdated();
			}
		}

		public double Y2
		{
			get
			{
				return this.y2; 
			}
			set
			{
				this.y2 = value;
				this.EmitUpdated();
			}
		}

		public event EventHandler Updated;

		public DrawingLine(DateTime x1, double y1, DateTime x2, double y2, string name) : base()
		{
			this.width = 1;
			this.Name = name;
			this.x1 = x1;
			this.y1 = y1;
			this.x2 = x2;
			this.y2 = y2;
		}

		private void EmitUpdated()
		{
			if (this.Updated == null)
				return;
			this.Updated(this, EventArgs.Empty);
		}
	}
}
