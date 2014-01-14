using FreeQuant.Trading;
using System;

namespace OpenQuant.API
{
	///<summary>
	///  A stop
	///</summary>
	public class Stop
	{
		internal ATSStop stop;
		private Position position;

		public Instrument Instrument
		{
			get
			{
				return this.position.Instrument;
			}
		}

		///<summary>
		///  Gets fill price of the stop
		///</summary>
		public double FillPrice
		{
			get
			{
				return this.stop.get_FillPrice();
			}
		}

		///<summary>
		///  Gets stop price of the stop
		///</summary>
		public double StopPrice
		{
			get
			{
				return this.stop.get_StopPrice();
			}
		}

		///<summary>
		///  Gets stop level 
		///</summary>
		public double Level
		{
			get
			{
				return ((StopBase)this.stop).get_Level();
			}
		}

		///<summary>
		///  Gets stop type 
		///</summary>
		public StopType Type
		{
			get
			{
				return EnumConverter.Convert(((StopBase)this.stop).get_Type());
			}
		}

		///<summary>
		///  Gets stop mode 
		///</summary>
		public StopMode Mode
		{
			get
			{
				return EnumConverter.Convert(((StopBase)this.stop).get_Mode());
			}
		}

		///<summary>
		///  Gets stop status
		///</summary>
		public StopStatus Status
		{
			get
			{
				return EnumConverter.Convert(((StopBase)this.stop).get_Status());
			}
		}

		///<summary>
		///  Returns true if the stop traces bars
		///</summary>
		public bool TraceOnBar
		{
			get
			{
				return ((StopBase)this.stop).get_TraceOnBar();
			}
			set
			{
				((StopBase)this.stop).set_TraceOnBar(value);
			}
		}

		///<summary>
		///  Returns true if the stop traces trades
		///</summary>
		public bool TraceOnTrade
		{
			get
			{
				return ((StopBase)this.stop).get_TraceOnTrade();
			}
			set
			{
				((StopBase)this.stop).set_TraceOnTrade(value);
			}
		}

		///<summary>
		///  Returns true if the stop traces quotes
		///</summary>
		public bool TraceOnQuote
		{
			get
			{
				return ((StopBase)this.stop).get_TraceOnQuote();
			}
			set
			{
				((StopBase)this.stop).set_TraceOnQuote(value);
			}
		}

		///<summary>
		///  Gets stop creation time 
		///</summary>
		public DateTime CreationTime
		{
			get
			{
				return ((StopBase)this.stop).get_CreationTime();
			}
		}

		///<summary>
		///  Gets stop complition time 
		///</summary>
		public DateTime CompletionTime
		{
			get
			{
				return ((StopBase)this.stop).get_CompletionTime();
			}
		}

		internal Stop(Position position, DateTime dateTime)
		{
			this.position = position;
			this.stop = new ATSStop(position.position, dateTime);
			((StopBase)this.stop).set_TrailOnHighLow(true);
			((StopBase)this.stop).set_TraceOnBarOpen(true);
			((StopBase)this.stop).set_TraceOnBar(true);
			((StopBase)this.stop).set_TraceOnQuote(true);
			((StopBase)this.stop).set_TraceOnTrade(true);
		}

		internal Stop(Position position, double level, StopType type, StopMode mode)
		{
			this.position = position;
			StopType stopType = EnumConverter.Convert(type);
			StopMode stopMode = EnumConverter.Convert(mode);
			this.stop = new ATSStop(position.position, level, stopType, stopMode);
			((StopBase)this.stop).set_TrailOnHighLow(true);
			((StopBase)this.stop).set_TraceOnBarOpen(true);
			((StopBase)this.stop).set_TraceOnBar(true);
			((StopBase)this.stop).set_TraceOnQuote(true);
			((StopBase)this.stop).set_TraceOnTrade(true);
		}

		///<summary>
		///  Sets a bar size and type to filter bars 
		///</summary>
		public void SetBarFilter(long barSize, BarType barType)
		{
			((StopBase)this.stop).SetBarFilter(barSize, EnumConverter.Convert(barType));
		}

		///<summary>
		///  Sets a bar size to filter time bars
		///</summary>
		public void SetBarFilter(long barSize)
		{
			this.SetBarFilter(barSize, BarType.Time);
		}

		///<summary>
		///  Cancels this stop
		///</summary>
		public void Cancel()
		{
			this.stop.Cancel();
		}

		private void stop_StatusChanged(StopEventArgs args)
		{
		}

		///<summary>
		///  Disconnects this stop
		///</summary>
		public void Disconnect()
		{
			((StopBase)this.stop).Disconnect();
		}
	}
}
