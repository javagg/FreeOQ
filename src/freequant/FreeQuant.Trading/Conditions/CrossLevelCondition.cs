// Type: SmartQuant.Trading.Conditions.CrossLevelCondition
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SlN8f6pWyHStvuMgWbM;
using SmartQuant.Series;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading.Conditions
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ieU6u8F4Hp;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.ieU6u8F4Hp = value;
      }
    }

    public RuleItemList Below
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.hhW6Y3jWrG;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.hhW6Y3jWrG = value;
      }
    }

    public RuleItemList None
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.j2c6ooZQmO;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.j2c6ooZQmO = value;
      }
    }

    public DoubleSeries Series
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.BmF6ZarrHH;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.BmF6ZarrHH = value;
      }
    }

    public double Level
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.T4k6nZLg7c;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.T4k6nZLg7c = value;
      }
    }

    public override string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.BmF6ZarrHH == null)
          return USaG3GpjZagj1iVdv4u.Y4misFk9D9(5124);
        return USaG3GpjZagj1iVdv4u.Y4misFk9D9(5066) + this.BmF6ZarrHH.Name + USaG3GpjZagj1iVdv4u.Y4misFk9D9(5110) + this.T4k6nZLg7c.ToString() + USaG3GpjZagj1iVdv4u.Y4misFk9D9(5118);
      }
    }

    public override string CodeName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.BmF6ZarrHH.Name.Replace(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5176), "") + (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(5182) + (string) (object) this.T4k6nZLg7c;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CrossLevelCondition(DoubleSeries series, double level)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.BmF6ZarrHH = series;
      this.T4k6nZLg7c = level;
      this.at56qqG7NE();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CrossLevelCondition()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.at56qqG7NE();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetInitCode(string name)
    {
      return USaG3GpjZagj1iVdv4u.Y4misFk9D9(5200) + (object) name + USaG3GpjZagj1iVdv4u.Y4misFk9D9(5244) + this.BmF6ZarrHH.Name.Replace(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5302), "") + USaG3GpjZagj1iVdv4u.Y4misFk9D9(5308) + (string) (object) this.T4k6nZLg7c + USaG3GpjZagj1iVdv4u.Y4misFk9D9(5316);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void at56qqG7NE()
    {
      this.ieU6u8F4Hp = new RuleItemList();
      this.hhW6Y3jWrG = new RuleItemList();
      this.j2c6ooZQmO = new RuleItemList();
      this.childs.Add((object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(5324), (object) this.ieU6u8F4Hp);
      this.childs.Add((object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(5338), (object) this.hhW6Y3jWrG);
      this.childs.Add((object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(5352), (object) this.j2c6ooZQmO);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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
