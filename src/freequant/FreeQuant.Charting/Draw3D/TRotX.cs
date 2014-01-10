using System.Runtime.CompilerServices;

namespace FreeQuant.Charting.Draw3D
{
	public class TRotX : TMat3x3
	{
		public TRotX(double Angle) : base()
		{

			this.SetRotX(Angle);
		}
	}
}
