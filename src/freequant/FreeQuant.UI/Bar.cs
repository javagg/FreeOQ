using FreeQuant.Data;
using System;
using System.Drawing;

namespace FreeQuant.Data
{
	public partial class Bar
    {
		protected Color color;
		public Color Color { get; set; }

		private void InitializeUI()
		{
			this.color = Color.Empty;
		}
    }
}

