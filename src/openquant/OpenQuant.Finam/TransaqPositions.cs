// Type: OpenQuant.Finam.TransaqPositions
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

using System.Collections.Generic;

namespace OpenQuant.Finam
{
  public sealed class TransaqPositions
  {
    public object lockerMoneyPosition;
    public object lockerSecPosition;
    public object lockerFortsPosition;
    public object lockerFortsMoney;
    public object lockerFortsCollaterals;
    public object lockerSpotLimit;

    public Dictionary<string, Dictionary<string, TransaqMoneyPosition>> MoneyPosition { get; private set; }

    public Dictionary<string, Dictionary<string, TransaqSecPosition>> SecPosition { get; private set; }

    public Dictionary<string, Dictionary<string, TransaqFortsPosition>> FortsPosition { get; private set; }

    public Dictionary<string, TransaqFortsMoney> FortsMoney { get; private set; }

    public Dictionary<string, TransaqFortsCollaterals> FortsCollaterals { get; private set; }

    public Dictionary<string, TransaqSpotLimit> SpotLimit { get; private set; }

    public TransaqPositions()
    {
      this.lockerMoneyPosition = new object();
      this.lockerSecPosition = new object();
      this.lockerFortsPosition = new object();
      this.lockerFortsMoney = new object();
      this.lockerFortsCollaterals = new object();
      this.lockerSpotLimit = new object();
      this.MoneyPosition = new Dictionary<string, Dictionary<string, TransaqMoneyPosition>>();
      this.SecPosition = new Dictionary<string, Dictionary<string, TransaqSecPosition>>();
      this.FortsPosition = new Dictionary<string, Dictionary<string, TransaqFortsPosition>>();
      this.FortsMoney = new Dictionary<string, TransaqFortsMoney>();
      this.FortsCollaterals = new Dictionary<string, TransaqFortsCollaterals>();
      this.SpotLimit = new Dictionary<string, TransaqSpotLimit>();
    }

    public void AddMoneyPositionInfo(string data)
    {
      TransaqMoneyPosition tmpNew = new TransaqMoneyPosition(data);
      lock (this.lockerMoneyPosition)
      {
        if (!this.MoneyPosition.ContainsKey(tmpNew.Client))
        {
          this.MoneyPosition.Add(tmpNew.Client, new Dictionary<string, TransaqMoneyPosition>());
          this.MoneyPosition[tmpNew.Client].Add(tmpNew.Register, tmpNew);
        }
        else if (!this.MoneyPosition[tmpNew.Client].ContainsKey(tmpNew.Register))
          this.MoneyPosition[tmpNew.Client].Add(tmpNew.Register, tmpNew);
        else
          this.MoneyPosition[tmpNew.Client][tmpNew.Register].Update(tmpNew);
      }
    }

    public void AddSecPositionInfo(string data)
    {
      TransaqSecPosition tsp = new TransaqSecPosition(data);
      lock (this.lockerSecPosition)
      {
        if (!this.SecPosition.ContainsKey(tsp.Client))
        {
          this.SecPosition.Add(tsp.Client, new Dictionary<string, TransaqSecPosition>());
          this.SecPosition[tsp.Client].Add(tsp.SecCode + tsp.Register, tsp);
        }
        else if (!this.SecPosition[tsp.Client].ContainsKey(tsp.SecCode + tsp.Register))
          this.SecPosition[tsp.Client].Add(tsp.SecCode + tsp.Register, tsp);
        else
          this.SecPosition[tsp.Client][tsp.SecCode + tsp.Register].Update(tsp);
      }
    }

    public void AddFortsPositionInfo(string data)
    {
      TransaqFortsPosition tfp = new TransaqFortsPosition(data);
      lock (this.lockerFortsPosition)
      {
        if (!this.FortsPosition.ContainsKey(tfp.Client))
        {
          this.FortsPosition.Add(tfp.Client, new Dictionary<string, TransaqFortsPosition>());
          this.FortsPosition[tfp.Client].Add(tfp.SecCode, tfp);
        }
        else if (!this.FortsPosition[tfp.Client].ContainsKey(tfp.SecCode))
          this.FortsPosition[tfp.Client].Add(tfp.SecCode, tfp);
        else
          this.FortsPosition[tfp.Client][tfp.SecCode].Update(tfp);
      }
    }

    public void AddFortsMoneyInfo(string data)
    {
      TransaqFortsMoney tfm = new TransaqFortsMoney(data);
      lock (this.lockerFortsMoney)
      {
        if (!this.FortsMoney.ContainsKey(tfm.Client))
          this.FortsMoney.Add(tfm.Client, tfm);
        else
          this.FortsMoney[tfm.Client].Update(tfm);
      }
    }

    public void AddFortsCollateralsInfo(string data)
    {
      TransaqFortsCollaterals tfc = new TransaqFortsCollaterals(data);
      lock (this.lockerFortsCollaterals)
      {
        if (!this.FortsCollaterals.ContainsKey(tfc.Client))
          this.FortsCollaterals.Add(tfc.Client, tfc);
        else
          this.FortsCollaterals[tfc.Client].Update(tfc);
      }
    }

    public void AddSpotLimitInfo(string data)
    {
      TransaqSpotLimit tsl = new TransaqSpotLimit(data);
      lock (this.lockerSpotLimit)
      {
        if (!this.SpotLimit.ContainsKey(tsl.Client))
          this.SpotLimit.Add(tsl.Client, tsl);
        else
          this.SpotLimit[tsl.Client].Update(tsl);
      }
    }
  }
}
