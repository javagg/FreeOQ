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
		private BarType type;
		private long size;

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
			this.Type = type;
			this.Size = size;
			this.isBarFactoryRequest = true;
		}

		public BarRequest() : this(DataManager.DefaultBarType, DataManager.DefaultBarSize)
		{
		}

		public BarRequest(string request) : base("Bar")
		{
			string[] strArray = request.Split(new char[1] {	'.' });
			this.Type = (BarType)Enum.Parse(typeof(BarType), strArray[1]);
			this.Size = long.Parse(strArray[2]);
			this.isBarFactoryRequest = true;
		}

		public override bool Equals(object obj)
		{
			BarRequest barRequest = obj as BarRequest;
			return barRequest != null && barRequest.BarType == this.type && barRequest.BarSize == this.size;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string GetSeriesSuffix()
		{
			return "Bar." + this.Type.ToString() + "." + this.Size.ToString();
		}

		public override string GetName()
		{
			return this.GetSeriesSuffix();
		}

		public override string ToString()
		{
			switch (this.Type)
			{
				case BarType.Time:
					switch (this.Size)
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
					return "Bars " + this.Size + " ticks";
				case BarType.Volume:
					return "Bars " + this.Size + " volume";
				default:
					return this.GetSeriesSuffix();
			}
		}
	}
}
