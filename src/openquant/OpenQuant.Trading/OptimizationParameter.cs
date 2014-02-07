using FreeQuant.Optimization;

namespace OpenQuant.Trading
{
	public class OptimizationParameter
	{
		public string Strategy { get; private set; }

		public EParamType Type { get; private set; }

		public string Name { get; private set; }

		public double Start { get; private set; }

		public double Stop { get; private set; }

		public double Step { get; private set; }

		public bool Enabled { get; set; }

		public int Number { get; set; }

		public int Loops
		{
			get
			{
				return (this.Stop <= this.Start) ? 1 : (int)((this.Stop - this.Start) / this.Step) + 1;
			}
		}

		public OptimizationParameter(string strategy, string name, double start, double stop, double step, EParamType type)
		{
			this.Strategy = strategy;
			this.Type = type;
			this.Name = name;
			this.Start = start;
			this.Stop = stop;
			this.Step = step;
			this.Enabled = true;
		}

		public override string ToString()
		{
			return this.Name;
		}
	}
}
