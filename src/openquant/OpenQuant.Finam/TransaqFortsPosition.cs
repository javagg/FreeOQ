// Type: OpenQuant.Finam.TransaqFortsPosition
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

using System;
using System.Globalization;

namespace OpenQuant.Finam
{
  public sealed class TransaqFortsPosition
  {
    public int SecId { get; private set; }

    public string SecCode { get; private set; }

    public string Client { get; private set; }

    public string StartNet { get; private set; }

    public string OpenBuys { get; private set; }

    public string OpenSells { get; private set; }

    public double TotalNet { get; private set; }

    public string TodayBuy { get; private set; }

    public string TodaySell { get; private set; }

    public string OptMargin { get; private set; }

    public string VarMargin { get; private set; }

    public string ExpirationPos { get; private set; }

    public string UsedSellSpotLimit { get; private set; }

    public string SellSpotLimit { get; private set; }

    public string Netto { get; private set; }

    public string Kgo { get; private set; }

    public TransaqFortsPosition(string data)
    {
      this.SecId = -1;
      this.TotalNet = double.MaxValue;
      this.SecCode = this.Client = this.StartNet = this.OpenBuys = this.OpenSells = this.TodayBuy = this.TodaySell = string.Empty;
      this.OptMargin = this.VarMargin = this.ExpirationPos = this.UsedSellSpotLimit = this.SellSpotLimit = this.Netto = this.Kgo = string.Empty;
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      for (int index = 0; index < strArray.Length; ++index)
      {
        switch (strArray[index])
        {
          case "secid":
            this.SecId = int.Parse(strArray[index + 1]);
            break;
          case "seccode":
            this.SecCode = strArray[index + 1];
            break;
          case "client":
            this.Client = strArray[index + 1];
            break;
          case "startnet":
            this.StartNet = strArray[index + 1];
            break;
          case "openbuys":
            this.OpenBuys = strArray[index + 1];
            break;
          case "opensells":
            this.OpenSells = strArray[index + 1];
            break;
          case "totalnet":
            this.TotalNet = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "todaybuy":
            this.TodayBuy = strArray[index + 1];
            break;
          case "todaysell":
            this.TodaySell = strArray[index + 1];
            break;
          case "optmargin":
            this.OptMargin = strArray[index + 1];
            break;
          case "varmargin":
            this.VarMargin = strArray[index + 1];
            break;
          case "expirationpos":
            this.ExpirationPos = strArray[index + 1];
            break;
          case "usedsellspotlimit":
            this.UsedSellSpotLimit = strArray[index + 1];
            break;
          case "sellspotlimit":
            this.SellSpotLimit = strArray[index + 1];
            break;
          case "netto":
            this.Netto = strArray[index + 1];
            break;
          case "kgo":
            this.Kgo = strArray[index + 1];
            break;
        }
      }
    }

    public void Update(TransaqFortsPosition tfp)
    {
      if (tfp.SecId != -1)
        this.SecId = tfp.SecId;
      if (tfp.Client != string.Empty)
        this.Client = tfp.Client;
      if (tfp.StartNet != string.Empty)
        this.StartNet = tfp.StartNet;
      if (tfp.OpenBuys != string.Empty)
        this.OpenBuys = tfp.OpenBuys;
      if (tfp.OpenSells != string.Empty)
        this.OpenSells = tfp.OpenSells;
      if (tfp.TotalNet != double.MaxValue)
        this.TotalNet = tfp.TotalNet;
      if (tfp.TodayBuy != string.Empty)
        this.TodayBuy = tfp.TodayBuy;
      if (tfp.TodaySell != string.Empty)
        this.TodaySell = tfp.TodaySell;
      if (tfp.OptMargin != string.Empty)
        this.OptMargin = tfp.OptMargin;
      if (tfp.VarMargin != string.Empty)
        this.VarMargin = tfp.VarMargin;
      if (tfp.ExpirationPos != string.Empty)
        this.ExpirationPos = tfp.ExpirationPos;
      if (tfp.UsedSellSpotLimit != string.Empty)
        this.UsedSellSpotLimit = tfp.UsedSellSpotLimit;
      if (tfp.SellSpotLimit != string.Empty)
        this.SellSpotLimit = tfp.SellSpotLimit;
      if (tfp.Netto != string.Empty)
        this.Netto = tfp.Netto;
      if (!(tfp.Kgo != string.Empty))
        return;
      this.Kgo = tfp.Kgo;
    }
  }
}
