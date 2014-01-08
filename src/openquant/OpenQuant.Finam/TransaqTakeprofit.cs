using System;
using System.Globalization;

namespace OpenQuant.Finam
{
  public sealed class TransaqTakeprofit
  {
    public double ActivationPrice { get; private set; }

    public DateTime GuardTime { get; private set; }

    public string BrokerRef { get; private set; }

    public int Quantity { get; private set; }

    public string Extremum { get; private set; }

    public string Level { get; private set; }

    public string Correction { get; private set; }

    public string GuardSpread { get; private set; }

    public TransaqTakeprofit(string data)
    {
      this.ActivationPrice = -1.0;
      this.GuardTime = DateTime.MinValue;
      this.Quantity = -1;
      this.BrokerRef = this.Extremum = this.Level = this.Correction = this.GuardSpread = string.Empty;
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      int index = 1;
      while (index < strArray.Length)
      {
        switch (strArray[index])
        {
          case "activationprice":
            this.ActivationPrice = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "guardtime":
            this.GuardTime = DateTime.ParseExact(strArray[index + 1], "d.M.yyyy HH:mm:ss", (IFormatProvider) CultureInfo.InvariantCulture);
            break;
          case "brokerref":
            this.BrokerRef = strArray[index + 1];
            break;
          case "quantity":
            this.Quantity = int.Parse(strArray[index + 1]);
            break;
          case "extremum":
            this.Extremum = strArray[index + 1];
            break;
          case "level":
            this.Level = strArray[index + 1];
            break;
          case "correction":
            this.Correction = strArray[index + 1];
            break;
          case "guardspread":
            this.GuardSpread = strArray[index + 1];
            break;
        }
        index += 2;
      }
    }

    public void Update(TransaqTakeprofit tt)
    {
      if (tt.ActivationPrice != -1.0)
        this.ActivationPrice = tt.ActivationPrice;
      if (tt.GuardTime != DateTime.MinValue)
        this.GuardTime = tt.GuardTime;
      if (tt.BrokerRef != string.Empty)
        this.BrokerRef = tt.BrokerRef;
      if (tt.Quantity != -1)
        this.Quantity = tt.Quantity;
      if (tt.Extremum != string.Empty)
        this.Extremum = tt.Extremum;
      if (tt.Level != string.Empty)
        this.Level = tt.Level;
      if (tt.Correction != string.Empty)
        this.Correction = tt.Correction;
      if (!(tt.GuardSpread != string.Empty))
        return;
      this.GuardSpread = tt.GuardSpread;
    }
  }
}
