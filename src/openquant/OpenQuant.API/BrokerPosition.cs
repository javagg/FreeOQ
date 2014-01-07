using System;

namespace OpenQuant.API
{
  public class BrokerPosition
  {
		private FreeQuant.Providers.BrokerPosition brokerPosition;

    public string Symbol
    {
      get
      {
        return this.brokerPosition.Symbol;
      }
      set
      {
        this.brokerPosition.Symbol = value;
      }
    }

    public InstrumentType InstrumentType
    {
      get
      {
        return EnumConverter.Convert(this.brokerPosition.SecurityType);
      }
      set
      {
        this.brokerPosition.SecurityType = EnumConverter.Convert(value);
      }
    }

    public string Exchange
    {
      get
      {
        return this.brokerPosition.SecurityExchange;
      }
      set
      {
        this.brokerPosition.SecurityExchange = value;
      }
    }

    public string Currency
    {
      get
      {
        return this.brokerPosition.Currency;
      }
      set
      {
        this.brokerPosition.Currency = value;
      }
    }

    public DateTime Maturity
    {
      get
      {
        return this.brokerPosition.MaturityDate;
      }
      set
      {
        this.brokerPosition.MaturityDate = value;
      }
    }

    public PutCall PutCall
    {
      get
      {
        return EnumConverter.Convert(this.brokerPosition.PutOrCall);
      }
      set
      {
        this.brokerPosition.PutOrCall = EnumConverter.Convert(value);
      }
    }

    public double Strike
    {
      get
      {
        return this.brokerPosition.Strike;
      }
      set
      {
        this.brokerPosition.Strike = value;
      }
    }

    public double Qty
    {
      get
      {
        return this.brokerPosition.Qty;
      }
      set
      {
        this.brokerPosition.Qty = value;
      }
    }

    public double LongQty
    {
      get
      {
        return this.brokerPosition.LongQty;
      }
      set
      {
        this.brokerPosition.LongQty = value;
      }
    }

    public double ShortQty
    {
      get
      {
        return this.brokerPosition.ShortQty;
      }
      set
      {
        this.brokerPosition.ShortQty = value;
      }
    }

    public BrokerPositionFieldList Fields
    {
      get
      {
        return new BrokerPositionFieldList(this.brokerPosition.GetCustomFields());
      }
    }

		internal BrokerPosition(FreeQuant.Providers.BrokerPosition brokerPosition)
    {
      this.brokerPosition = brokerPosition;
    }

    public void AddCustomField(string name, string value)
    {
      this.brokerPosition.AddCustomField(name, value);
    }
  }
}
