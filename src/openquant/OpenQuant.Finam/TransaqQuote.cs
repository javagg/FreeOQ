using System;
using System.Globalization;

namespace OpenQuant.Finam
{
  public sealed class TransaqQuote
  {
    public int SecId { get; private set; }

    public string SecCode { get; private set; }

    public string Board { get; private set; }

    public double Bid { get; private set; }

    public double Offer { get; private set; }

    public double BidSize { get; private set; }

    public double OfferSize { get; private set; }

    public string SecCodeBoard { get; private set; }

    public TransaqQuote(string data)
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
          case "bid":
            this.Bid = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "offer":
            this.Offer = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "biddepth":
            this.BidSize = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "offerdepth":
            this.OfferSize = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
        }
        index += 2;
      }
      this.SecCodeBoard = this.SecCode + "|" + this.Board;
    }
  }
}
