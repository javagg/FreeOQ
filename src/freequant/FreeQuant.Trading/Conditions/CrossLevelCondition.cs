using FreeQuant.Series;

namespace FreeQuant.Trading.Conditions
{
	public class CrossLevelCondition : Condition
	{
		private DoubleSeries series;
		private double level;
		private RuleItemList above;
		private RuleItemList below;
		private RuleItemList none;

		public RuleItemList Above
		{
			get
			{
				return this.above; 
			}
			set
			{
				this.above = value;
			}
		}

		public RuleItemList Below
		{
			get
			{
				return this.below; 
			}
			set
			{
				this.below = value;
			}
		}

		public RuleItemList None
		{
			get
			{
				return this.none; 
			}
			set
			{
				this.none = value;
			}
		}

		public DoubleSeries Series
		{
			get
			{
				return this.series; 
			}
			set
			{
				this.series = value;
			}
		}

		public double Level
		{
			get
			{
				return this.level; 
			}
			set
			{
				this.level = value;
			}
		}

		public override string Name
		{
			get
			{
				if (this.series == null)
					return "Series";
				return this.series.Name + this.level.ToString();
			}
		}

		public override string CodeName
		{
			get
			{
				return this.series.Name.Replace("Codename", "") + (string)(object)this.level;
			}
		}

		public CrossLevelCondition(DoubleSeries series, double level) : base()
		{

			this.series = series;
			this.level = level;
			this.Init();
		}

		public CrossLevelCondition() : base()
		{
			this.Init();
		}

		public override string GetInitCode(string name)
		{
			return name + this.series.Name.Replace("dfdsf", "") + this.level;
		}

		private void Init()
		{
			this.above = new RuleItemList();
			this.below = new RuleItemList();
			this.none = new RuleItemList();
			this.childs.Add("fsd", this.above);
			this.childs.Add("dfdfs", this.below);
			this.childs.Add("fdsdfs", this.none);
		}

		public override void Execute()
		{
			switch (this.series.Crosses(this.level, this.series.Count - 1))
			{
				case ECross.Above:
					this.above.Execute();
					break;
				case ECross.Below:
					this.below.Execute();
					break;
				case ECross.None:
					this.none.Execute();
					break;
			}
		}
	}
}
