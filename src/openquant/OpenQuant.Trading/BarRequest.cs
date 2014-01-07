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
		public BarType BarType
		{
			get
			{
				return this.type;
			}
		}

		[Browsable(false)]
		public long BarSize
		{
			get
			{
				return this.size;
			}
		}

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
				if (this.IsBarFactoryChanged == null)
					return;
				this.IsBarFactoryChanged((object)this, EventArgs.Empty);
			}
		}

		public event EventHandler IsBarFactoryChanged;

		public BarRequest(BarType type, long size)
      : base(RequestType.Bar)
		{
			this.type = type;
			this.size = size;
			this.isBarFactoryRequest = true;
		}

		public BarRequest()
      : this(DataManager.DefaultBarType, DataManager.DefaultBarSize)
		{
		}

		public BarRequest(string request)
      : base("Bar")
		{
			string[] strArray = request.Split(new char[1]
			{
				'.'
			});
			this.type = (BarType)Enum.Parse(typeof(BarType), strArray[1]);
			this.size = long.Parse(strArray[2]);
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
			return "Bar." + ((object)this.type).ToString() + "." + this.size.ToString();
		}

		public override string GetName()
		{
			return this.GetSeriesSuffix();
		}

		public override string ToString()
		{
			switch (this.type)
			{
				case BarType.Time:
					switch (this.size)
					{
						case 21600L:
							return "Bars 6 hours";
						case 43200L:
							return "Bars 12 hours";
						case 86400L:
							return "Daily Bars";
						case 3600L:
							return "Bars 1 hour";
						case 7200L:
							return "Bars 2 hours";
						case 10800L:
							return "Bars 3 hours";
						case 900L:
							return "Bars 15 min";
						case 1200L:
							return "Bars 20 min";
						case 1800L:
							return "Bars 30 min";
						case 60L:
							return "Bars 1 min";
						case 300L:
							return "Bars 5 min";
						case 600L:
							return "Bars 10 min";
						default:
							return this.GetSeriesSuffix();
					}
				case BarType.Tick:
					return "Bars " + (object)this.size + " ticks";
				case BarType.Volume:
					return "Bars " + (object)this.size + " volume";
				default:
					return this.GetSeriesSuffix();
			}
		}
	}
}
