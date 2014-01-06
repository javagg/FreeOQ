// Type: SmartQuant.Trading.Conditions.CrossSeriesCondition
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SlN8f6pWyHStvuMgWbM;
using SmartQuant.Series;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading.Conditions
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
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fIL66Bb1BO;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fIL66Bb1BO = value;
      }
    }

    public RuleItemList Below
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.owT6ARA0Tf;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.owT6ARA0Tf = value;
      }
    }

    public RuleItemList None
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.nY56jSKj9G;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.nY56jSKj9G = value;
      }
    }

    public DoubleSeries Series1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.qcp6k8UGuY;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.qcp6k8UGuY = value;
      }
    }

    public DoubleSeries Series2
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.rhO6pQ5uxM;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.rhO6pQ5uxM = value;
      }
    }

    public override string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        if (this.qcp6k8UGuY == null || this.rhO6pQ5uxM == null)
          return USaG3GpjZagj1iVdv4u.Y4misFk9D9(4350);
        return USaG3GpjZagj1iVdv4u.Y4misFk9D9(4290) + this.qcp6k8UGuY.Name + USaG3GpjZagj1iVdv4u.Y4misFk9D9(4336) + this.rhO6pQ5uxM.Name + USaG3GpjZagj1iVdv4u.Y4misFk9D9(4344);
      }
    }

    public override string CodeName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.qcp6k8UGuY.Name.Replace(USaG3GpjZagj1iVdv4u.Y4misFk9D9(4404), "") + USaG3GpjZagj1iVdv4u.Y4misFk9D9(4410) + this.rhO6pQ5uxM.Name.Replace(USaG3GpjZagj1iVdv4u.Y4misFk9D9(4428), "");
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CrossSeriesCondition(DoubleSeries series1, DoubleSeries series2)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.qcp6k8UGuY = series1;
      this.rhO6pQ5uxM = series2;
      this.QUupz0XrCD();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CrossSeriesCondition()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.QUupz0XrCD();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetInitCode(string name)
    {
      return USaG3GpjZagj1iVdv4u.Y4misFk9D9(4434) + name + USaG3GpjZagj1iVdv4u.Y4misFk9D9(4480) + this.qcp6k8UGuY.Name.Replace(USaG3GpjZagj1iVdv4u.Y4misFk9D9(4540), "") + USaG3GpjZagj1iVdv4u.Y4misFk9D9(4546) + this.rhO6pQ5uxM.Name.Replace(USaG3GpjZagj1iVdv4u.Y4misFk9D9(4554), "") + USaG3GpjZagj1iVdv4u.Y4misFk9D9(4560);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QUupz0XrCD()
    {
      this.fIL66Bb1BO = new RuleItemList();
      this.owT6ARA0Tf = new RuleItemList();
      this.nY56jSKj9G = new RuleItemList();
      this.childs.Add((object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(4568), (object) this.fIL66Bb1BO);
      this.childs.Add((object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(4582), (object) this.owT6ARA0Tf);
      this.childs.Add((object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(4596), (object) this.nY56jSKj9G);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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
