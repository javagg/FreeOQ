using System.Drawing;

namespace FreeQuant.Charting.Draw3D
{
	public class TSurface
	{
		public TColor Diffuse;
		public TColor GridDiffuse;
		public TColor Specular;

		public TSurface()
		{
			this.Diffuse = new TColor(Color.White);
			this.GridDiffuse = new TColor(Color.Orange);
			this.Specular = new TColor(Color.White);
		}
	}
}
