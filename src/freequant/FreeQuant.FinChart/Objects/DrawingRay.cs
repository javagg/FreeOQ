using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.FinChart.Objects
{
	public class DrawingRay : IUpdatable
	{
		private DateTime x;
		private double y;
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

		public DrawingRay(DateTime x, double y, string name) : base()
		{
			this.width = 1;
			this.Name = name;
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
