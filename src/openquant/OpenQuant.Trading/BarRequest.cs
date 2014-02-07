using FreeQuant.Data;
using FreeQuant.Instruments;
using System;
using System.ComponentModel;

namespace OpenQuant.Trading
{
	public class BarRequest : MarketDataRequest
	{
		private bool isBarFactoryRequest = true;
		public const bool DefaultIsBarFactoryRequest = true;

		[Browsable(false)]
		public BarType BarType { get; private set; }

		[Browsable(false)]
		public long BarSize { get; private set; }

		public bool IsBarFactoryRequest
		{
			get
			{
				return this.isBarFactoryRequest;
			}
			set
			{
				if (this.isBarFactoryRequest == value)
					return;
				this.isBarFactoryRequest = value;
				if (this.IsBarFactoryChanged != null)
					this.IsBarFactoryChanged(this, EventArgs.Empty);
			}
		}

		public event EventHandler IsBarFactoryChanged;

		public BarRequest(BarType type, long size) : base(RequestType.Bar)
		{
			this.BarType = type;
			this.BarSize = size;
			this.isBarFactoryRequest = true;
		}

		public BarRequest() : this(DataManager.DefaultBarType, DataManager.DefaultBarSize)
		{
		}

		public BarRequest(string request) : base("Bar")
		{
			string[] strArray = request.Split(new char[1] {	'.' });
			this.BarType = (BarType)Enum.Parse(typeof(BarType), strArray[1]);
			this.BarSize = long.Parse(strArray[2]);
			this.isBarFactoryRequest = true;
		}

		public override bool Equals(object obj)
		{
			BarRequest barRequest = obj as BarRequest;
			return barRequest != null && barRequest.BarType == this.BarType && barRequest.BarSize == this.BarSize;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string GetSeriesSuffix()
		{
			return "Bar." + this.BarType.ToString() + "." + this.BarSize.ToString();
		}

		public override string GetName()
		{
			return this.GetSeriesSuffix();
		}

		public override string ToString()
		{
			switch (this.BarType)
			{
				case BarType.Time:
					switch (this.BarSize)
					{
						case 21600:
							return "Bars 6 hours";
						case 43200:
							return "Bars 12 hours";
						case 86400:
							return "Daily Bars";
						case 3600:
							return "Bars 1 hour";
						case 7200:
							return "Bars 2 hours";
						case 10800:
							return "Bars 3 hours";
						case 900:
							return "Bars 15 min";
						case 1200:
							return "Bars 20 min";
						case 1800:
							return "Bars 30 min";
						case 60:
							return "Bars 1 min";
						case 300:
							return "Bars 5 min";
						case 600:
							return "Bars 10 min";
						default:
							return this.GetSeriesSuffix();
					}
				case BarType.Tick:
					return "Bars " + this.BarSize + " ticks";
				case BarType.Volume:
					return "Bars " + this.BarSize + " volume";
				default:
					return this.GetSeriesSuffix();
			}
		}
	}
}
