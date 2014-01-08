using System;
using System.Globalization;

namespace OpenQuant.Finam
{
  public sealed class TransaqCandle
  {
    public DateTime Date { get; private set; }

    public double Open { get; private set; }

    public double High { get; private set; }

    public double Low { get; private set; }

    public double Close { get; private set; }

    public int Volume { get; private set; }

    public int OI { get; private set; }

    public TransaqCandle(string data)
    {
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      int index = 0;
      while (index < strArray.Length - 1)
      {
        switch (strArray[index])
        {
          case "date":
            this.Date = DateTime.ParseExact(strArray[index + 1], "d.M.yyyy HH:mm:ss", (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "open":
            this.Open = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "high":
            this.High = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "low":
            this.Low = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "close":
            this.Close = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "volume":
            this.Volume = int.Parse(strArray[index + 1]);
            break;
          case "oi":
            this.OI = int.Parse(strArray[index + 1]);
            break;
        }
        index += 2;
      }
    }
  }
}
