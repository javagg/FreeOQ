using FreeQuant.Series;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading.Conditions
{
  public class CrossSeriesCondition : Condition
  {
    private DoubleSeries qcp6k8UGuY;
    private DoubleSeries rhO6pQ5uxM;
    private RuleItemList fIL66Bb1BO;
    private RuleItemList owT6ARA0Tf;
    private RuleItemList nY56jSKj9G;

    public RuleItemList Above
    {
       get
      {
        return this.fIL66Bb1BO;
      }
       set
      {
        this.fIL66Bb1BO = value;
      }
    }

    public RuleItemList Below
    {
       get
      {
        return this.owT6ARA0Tf;
      }
       set
      {
        this.owT6ARA0Tf = value;
      }
    }

    public RuleItemList None
    {
       get
      {
        return this.nY56jSKj9G;
      }
       set
      {
        this.nY56jSKj9G = value;
      }
    }

    public DoubleSeries Series1
    {
       get
      {
        return this.qcp6k8UGuY;
      }
       set
      {
        this.qcp6k8UGuY = value;
      }
    }

    public DoubleSeries Series2
    {
       get
      {
        return this.rhO6pQ5uxM;
      }
       set
      {
        this.rhO6pQ5uxM = value;
      }
    }

    public override string Name
    {
       get
      {
//        if (this.qcp6k8UGuY == null || this.rhO6pQ5uxM == null)
//          return USaG3GpjZagj1iVdv4u.Y4misFk9D9(4350);
				return  this.qcp6k8UGuY.Name + this.rhO6pQ5uxM.Name;
      }
    }

    public override string CodeName
    {
       get
      {
				return this.qcp6k8UGuY.Name.Replace("dfsdfs", "") + this.rhO6pQ5uxM.Name.Replace("fddfs", "");
      }
    }

    
		public CrossSeriesCondition(DoubleSeries series1, DoubleSeries series2):base()
    {
      this.qcp6k8UGuY = series1;
      this.rhO6pQ5uxM = series2;
      this.QUupz0XrCD();
    }

    
		public CrossSeriesCondition():base()
    {
      this.QUupz0XrCD();
    }

    
    public override string GetInitCode(string name)
    {
			return  name +  this.qcp6k8UGuY.Name.Replace("fssf", "") + this.rhO6pQ5uxM.Name.Replace("fdfd", "");
    }

    
    private void QUupz0XrCD()
    {
      this.fIL66Bb1BO = new RuleItemList();
      this.owT6ARA0Tf = new RuleItemList();
      this.nY56jSKj9G = new RuleItemList();
			this.childs.Add("", (object) this.fIL66Bb1BO);
			this.childs.Add("", (object) this.owT6ARA0Tf);
			this.childs.Add("", (object) this.nY56jSKj9G);
    }

    
    public override void Execute()
    {
      if (this.qcp6k8UGuY.Count == 0 || this.rhO6pQ5uxM.Count == 0)
      {
        this.nY56jSKj9G.Execute();
      }
      else
      {
        switch (this.qcp6k8UGuY.Crosses((TimeSeries) this.rhO6pQ5uxM, this.qcp6k8UGuY.LastDateTime))
        {
          case ECross.Above:
            this.fIL66Bb1BO.Execute();
            break;
          case ECross.Below:
            this.owT6ARA0Tf.Execute();
            break;
          case ECross.None:
            this.nY56jSKj9G.Execute();
            break;
        }
      }
    }
  }
}
