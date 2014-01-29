namespace FreeQuant.Optimization
{
	public interface IOptimizable
	{
		void Init(ParamSet paramSet);
		void Update(ParamSet paramSet);
		double Objective();
		void OnStep();
		void OnCircle();
	}
}
