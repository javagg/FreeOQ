namespace FreeQuant.Charting.Draw3D
{
	public class TMat3x3Diagonal : TMat3x3
	{
		public TMat3x3Diagonal(double lx, double ly, double lz) : base()
		{
			this.SetDiagonal(lx, ly, lz);
		}
	}
}
