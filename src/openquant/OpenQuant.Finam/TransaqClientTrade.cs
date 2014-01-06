// Type: OpenQuant.Finam.TransaqClientTrade
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

using System;
using System.Globalization;

namespace OpenQuant.Finam
{
  public sealed class TransaqClientTrade
  {
    public long TradeNo { get; private set; }

    public long OrderNo { get; private set; }

    public double Commission { get; private set; }

    public double Price { get; private set; }

    public int Quantity { get; private set; }

    public TransaqClientTrade(string data)
    {
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      for (int index = 0; index < strArray.Length - 1; ++index)
      {
        switch (strArray[index])
        {
          case "tradeno":
            this.TradeNo = long.Parse(strArray[index + 1]);
            break;
          case "orderno":
            this.OrderNo = long.Parse(strArray[index + 1]);
            break;
          case "comission":
            this.Commission = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "price":
            this.Price = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "quantity":
            this.Quantity = int.Parse(strArray[index + 1]);
            break;
        }
      }
    }
  }
}
