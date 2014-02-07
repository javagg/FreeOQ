namespace FreeQuant.Optimization
{
	public abstract class TOptimizable : IOptimizable
	{
		public virtual void Init(ParamSet paramSet)
		{
		}

		public virtual void Update(ParamSet paramSet)
		{
		}

		public abstract double Objective();

		public virtual void OnStep()
		{
		}

		public virtual void OnCircle()
		{
		}
	}
}
