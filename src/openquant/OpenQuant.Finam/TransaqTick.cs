using System;
using System.Globalization;

namespace OpenQuant.Finam
{
  public sealed class TransaqTick
  {
    public int SecId { get; private set; }

    public string SecCode { get; private set; }

    public string Board { get; private set; }

    public DateTime TradeTime { get; private set; }

    public double Price { get; private set; }

    public int Quantity { get; private set; }

    public string SecCodeBoard { get; private set; }

    public TransaqTick(string data)
    {
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      int index = 0;
      while (index < strArray.Length)
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
          case "tradetime":
            this.TradeTime = DateTime.ParseExact(strArray[index + 1], "d.M.yyyy HH:mm:ss", (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "price":
            this.Price = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "quantity":
            this.Quantity = int.Parse(strArray[index + 1]);
            break;
        }
        index += 2;
      }
      this.SecCodeBoard = this.SecCode + "|" + this.Board;
    }
  }
}
