using System;
using System.Globalization;

namespace OpenQuant.Finam
{
  public sealed class TransaqStoploss
  {
    public string UseCredit { get; private set; }

    public double ActivationPrice { get; private set; }

    public DateTime GuardTime { get; private set; }

    public string BrokerRef { get; private set; }

    public int Quantity { get; private set; }

    public string ByMarket { get; private set; }

    public double OrderPrice { get; private set; }

    public TransaqStoploss(string data)
    {
      this.UseCredit = this.BrokerRef = this.ByMarket = string.Empty;
      this.ActivationPrice = this.OrderPrice = -1.0;
      this.GuardTime = DateTime.MinValue;
      this.Quantity = -1;
      string[] strArray = data.Split(new char[1]
      {
        ';'
      });
      int index = 1;
      while (index < strArray.Length)
      {
        switch (strArray[index])
        {
          case "usecredit":
            this.UseCredit = strArray[index + 1];
            break;
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
          case "bymarket":
            this.ByMarket = strArray[index + 1];
            break;
          case "orderprice":
            this.OrderPrice = double.Parse(strArray[index + 1], (IFormatProvider) CultureInfo.InvariantCulture);
            break;
        }
        index += 2;
      }
    }

    public void Update(TransaqStoploss ts)
    {
      if (ts.UseCredit != string.Empty)
        this.UseCredit = ts.UseCredit;
      if (ts.ActivationPrice != -1.0)
        this.ActivationPrice = ts.ActivationPrice;
      if (ts.GuardTime != DateTime.MinValue)
        this.GuardTime = ts.GuardTime;
      if (ts.BrokerRef != string.Empty)
        this.BrokerRef = ts.BrokerRef;
      if (ts.Quantity != -1)
        this.Quantity = ts.Quantity;
      if (ts.ByMarket != string.Empty)
        this.ByMarket = ts.ByMarket;
      if (ts.OrderPrice == -1.0)
        return;
      this.OrderPrice = ts.OrderPrice;
    }
  }
}
