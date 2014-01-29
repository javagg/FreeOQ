namespace FreeQuant.Charting.Draw3D
{
	public class TSpecialProjection : TMat3x3
	{
		public TSpecialProjection(double angle) : base()
		{
			this.SetSpecialProjection(angle);
		}
	}
}
