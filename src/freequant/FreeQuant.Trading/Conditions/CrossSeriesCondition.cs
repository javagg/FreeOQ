using FreeQuant.Series;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading.Conditions
{
	public class CrossSeriesCondition : Condition
	{
//		private DoubleSeries series1;
//		private DoubleSeries series2;
//		private RuleItemList above;
//		private RuleItemList below;
//		private RuleItemList none;

		public RuleItemList Above { get; set; }

		public RuleItemList Below { get; set; }
		public RuleItemList None { get; set; }
		public DoubleSeries Series1 { get; set; }

		public DoubleSeries Series2 { get; set; }

		public override string Name
		{
			get
			{
//        if (this.qcp6k8UGuY == null || this.rhO6pQ5uxM == null)
//          return USaG3GpjZagj1iVdv4u.Y4misFk9D9(4350);
				return  this.Series1.Name + this.Series2.Name;
			}
		}

		public override string CodeName
		{
			get
			{
				return this.Series1.Name.Replace("dfsdfs", "") + this.Series2.Name.Replace("fddfs", "");
			}
		}

		public CrossSeriesCondition(DoubleSeries series1, DoubleSeries series2) : base()
		{
			this.Series1 = series1;
			this.Series2 = series2;
			this.Init();
		}

		public CrossSeriesCondition() : base()
		{
			this.Init();
		}

		public override string GetInitCode(string name)
		{
			return  this.Series1.Name.Replace("fssf", "") + this.Series2.Name.Replace("fdfd", "");
		}

		private void Init()
		{
			this.Above = new RuleItemList();
			this.Below = new RuleItemList();
			this.None = new RuleItemList();
			this.childs.Add("", this.Above);
			this.childs.Add("", this.Below);
			this.childs.Add("", this.None);
		}

		public override void Execute()
		{
			if (this.Series1.Count == 0 || this.Series2.Count == 0)
			{
				this.None.Execute();
			}
			else
			{
				switch (this.Series1.Crosses(this.Series2, this.Series1.LastDateTime))
				{
					case ECross.Above:
						this.Above.Execute();
						break;
					case ECross.Below:
						this.Below.Execute();
						break;
					case ECross.None:
						this.None.Execute();
						break;
				}
			}
		}
	}
}
