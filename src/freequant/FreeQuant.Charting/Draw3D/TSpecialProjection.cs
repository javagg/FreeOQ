
namespace FreeQuant.Charting.Draw3D
{
	public class TSpecialProjection : TMat3x3
	{
		public TSpecialProjection(double Angle) : base()
		{
			this.SetSpecialProjection(Angle);
		}
	}
}
