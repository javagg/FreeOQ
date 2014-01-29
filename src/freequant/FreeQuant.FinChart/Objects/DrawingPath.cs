using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.FinChart.Objects
{
	public class DrawingPath : IUpdatable
	{
		private List<DrawingPoint> points;
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

		public List<DrawingPoint> Points
		{
			get
			{
				return this.points; 
			}
		}

		public event EventHandler Updated;

		public DrawingPath(string name) : base()
		{
			this.width = 1;
			this.Name = name;
			this.points = new List<DrawingPoint>();
		}

		public void Add(DateTime x, double y)
		{
			this.points.Add(new DrawingPoint(x, y));
			this.EmitUpdated();
		}

		public void RemoveAt(int index)
		{
			this.points.RemoveAt(index);
			this.EmitUpdated();
		}

		public void Insert(int index, DateTime x, double y)
		{
			this.points.Insert(index, new DrawingPoint(x, y));
			this.EmitUpdated();
		}

		private void EmitUpdated()
		{
			if (this.Updated == null)
				return;
			this.Updated(this, EventArgs.Empty);
		}
	}
}
