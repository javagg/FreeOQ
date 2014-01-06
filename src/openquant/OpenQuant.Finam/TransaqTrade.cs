// Type: OpenQuant.Finam.TransaqTrade
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

using System;
using System.Globalization;

namespace OpenQuant.Finam
{
  public sealed class TransaqTrade
  {
    public int SecId { get; private set; }

    public string SecCode { get; private set; }

    public string Board { get; private set; }

    public double Price { get; private set; }

    public int Quantity { get; private set; }

    public string SecCodeBoard { get; private set; }

    public TransaqTrade(string data)
    {
      this.SecId = this.Quantity = -1;
      this.Price = -1.0;
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      for (int index = 0; index < strArray.Length - 1; ++index)
      {
        switch (strArray[index])
        {
          case "secid":
            this.SecId = int.Parse(strArray[index + 1]);
            break;
          case "seccode":
            this.SecCode = strArray[index + 1];
            break;
          case "board":
            this.Board = strArray[index + 1];
            break;
          case "price":
            this.Price = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "quantity":
            this.Quantity = int.Parse(strArray[index + 1]);
            break;
        }
      }
      this.SecCodeBoard = this.SecCode + "|" + this.Board;
    }
  }
}
