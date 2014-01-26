using FreeQuant.Series;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading.Conditions
{
  public class CrossLevelCondition : Condition
  {
    private DoubleSeries BmF6ZarrHH;
    private double T4k6nZLg7c;
    private RuleItemList ieU6u8F4Hp;
    private RuleItemList hhW6Y3jWrG;
    private RuleItemList j2c6ooZQmO;

    public RuleItemList Above
    {
       get
      {
        return this.ieU6u8F4Hp;
      }
       set
      {
        this.ieU6u8F4Hp = value;
      }
    }

    public RuleItemList Below
    {
       get
      {
        return this.hhW6Y3jWrG;
      }
       set
      {
        this.hhW6Y3jWrG = value;
      }
    }

    public RuleItemList None
    {
       get
      {
        return this.j2c6ooZQmO;
      }
       set
      {
        this.j2c6ooZQmO = value;
      }
    }

    public DoubleSeries Series
    {
       get
      {
        return this.BmF6ZarrHH;
      }
       set
      {
        this.BmF6ZarrHH = value;
      }
    }

    public double Level
    {
       get
      {
        return this.T4k6nZLg7c;
      }
       set
      {
        this.T4k6nZLg7c = value;
      }
    }

    public override string Name
    {
       get
      {
//        if (this.BmF6ZarrHH == null)
//          return USaG3GpjZagj1iVdv4u.Y4misFk9D9(5124);
				return this.BmF6ZarrHH.Name + this.T4k6nZLg7c.ToString();
      }
    }

    public override string CodeName
    {
       get
      {
				return this.BmF6ZarrHH.Name.Replace("Codename", "") + (string) (object) this.T4k6nZLg7c;
      }
    }

    
		public CrossLevelCondition(DoubleSeries series, double level):base()
    {

      this.BmF6ZarrHH = series;
      this.T4k6nZLg7c = level;
      this.at56qqG7NE();
    }

    
		public CrossLevelCondition():base()
    {
      this.at56qqG7NE();
    }

    
    public override string GetInitCode(string name)
    {
			return (object) name + this.BmF6ZarrHH.Name.Replace("dfdsf", "") + (string) (object) this.T4k6nZLg7c ;
    }

    
    private void at56qqG7NE()
    {
      this.ieU6u8F4Hp = new RuleItemList();
      this.hhW6Y3jWrG = new RuleItemList();
      this.j2c6ooZQmO = new RuleItemList();
			this.childs.Add("fsd", (object) this.ieU6u8F4Hp);
			this.childs.Add("dfdfs", (object) this.hhW6Y3jWrG);
			this.childs.Add("fdsdfs", (object) this.j2c6ooZQmO);
    }

    
    public override void Execute()
    {
      switch (this.BmF6ZarrHH.Crosses(this.T4k6nZLg7c, this.BmF6ZarrHH.Count - 1))
      {
        case ECross.Above:
          this.ieU6u8F4Hp.Execute();
          break;
        case ECross.Below:
          this.hhW6Y3jWrG.Execute();
          break;
        case ECross.None:
          this.j2c6ooZQmO.Execute();
          break;
      }
    }
  }
}
