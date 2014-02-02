using System;

namespace OpenQuant.Trading
{
	public class MarketDataRequest
	{
		private RequestType requestType;
		private bool enabled;

		public RequestType RequestType
		{
			get
			{
				return this.requestType;
			}
		}

		public bool Enabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
				if (this.enabled == value)
					return;
				this.enabled = value;
				if (this.EnabledChanged == null)
					return;
				this.EnabledChanged((object)this, EventArgs.Empty);
			}
		}

		public event EventHandler EnabledChanged;

		public MarketDataRequest(RequestType requestType)
		{
			this.requestType = requestType;
			this.enabled = true;
		}

		public MarketDataRequest() : this(RequestType.Trade)
		{
		}

		public MarketDataRequest(string request)
      : this((RequestType)Enum.Parse(typeof(RequestType), request))
		{
		}

		public override bool Equals(object obj)
		{
			MarketDataRequest marketDataRequest = obj as MarketDataRequest;
			return marketDataRequest != null && marketDataRequest.requestType == this.requestType;
		}

		public override int GetHashCode()
		{
			return this.requestType.GetHashCode();
		}

		public virtual string GetSeriesSuffix()
		{
			switch (this.requestType)
			{
				case RequestType.Trade:
					return "Trade";
				case RequestType.Quote:
					return "Quote";
				case RequestType.MarketDepth:
					return "Depth";
				case RequestType.Fundamental:
					return "Fund";
				case RequestType.CorporateAction:
					return "Corp";
				case RequestType.Bar:
					return "Bar";
				case RequestType.Daily:
					return "Daily";
				default:
					return (string)null;
			}
		}

		public virtual string GetName()
		{
			return this.ToString();
		}

		public override string ToString()
		{
			return ((object)this.requestType).ToString();
		}
	}
}
