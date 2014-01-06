using System;
using System.Globalization;

namespace OpenQuant.Finam
{
  public sealed class TransaqSecurity
  {
    public int SecId { get; private set; }

    public bool Active { get; private set; }

    public string SecCode { get; private set; }

    public string Board { get; private set; }

    public int Market { get; private set; }

    public string ShortName { get; private set; }

    public int Decimals { get; private set; }

    public double MinStep { get; private set; }

    public int LotSize { get; private set; }

    public double PointCost { get; private set; }

    public bool UseCredit { get; private set; }

    public bool ByMarket { get; private set; }

    public bool NoSplit { get; private set; }

    public bool ImmOrCancel { get; private set; }

    public bool CancelBalance { get; private set; }

    public string SecType { get; private set; }

    public string SecCodeBoard { get; private set; }

    public string SecCodeMarket { get; private set; }

    public TransaqSecurity(string data)
    {
      this.SecCode = this.Board = this.ShortName = this.SecType = string.Empty;
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      int index = 0;
      while (index < strArray.Length - 1)
      {
        switch (strArray[index])
        {
          case "secid":
            this.SecId = int.Parse(strArray[index + 1]);
            break;
          case "active":
            this.Active = bool.Parse(strArray[index + 1]);
            break;
          case "seccode":
            this.SecCode = strArray[index + 1];
            break;
          case "board":
            this.Board = strArray[index + 1];
            break;
          case "market":
            this.Market = int.Parse(strArray[index + 1]);
            break;
          case "shortname":
            this.ShortName = strArray[index + 1];
            break;
          case "decimals":
            this.Decimals = int.Parse(strArray[index + 1]);
            break;
          case "minstep":
            this.MinStep = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "lotsize":
            this.LotSize = int.Parse(strArray[index + 1]);
            break;
          case "point_cost":
            this.PointCost = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "usecredit":
            this.UseCredit = strArray[index + 1] == "yes";
            break;
          case "bymarket":
            this.ByMarket = strArray[index + 1] == "yes";
            break;
          case "nosplit":
            this.NoSplit = strArray[index + 1] == "yes";
            break;
          case "immorcancel":
            this.ImmOrCancel = strArray[index + 1] == "yes";
            break;
          case "cancelbalance":
            this.CancelBalance = strArray[index + 1] == "yes";
            break;
          case "sectype":
            this.SecType = strArray[index + 1];
            break;
        }
        index += 2;
      }
      this.SecCodeBoard = this.SecCode + "|" + this.Board;
      this.SecCodeMarket = this.SecCode + (object) this.Market;
    }
  }
}
