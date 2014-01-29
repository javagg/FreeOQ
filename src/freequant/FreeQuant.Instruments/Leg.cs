using FreeQuant.FIX;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
	public class Leg : FIXGroup
	{
		//    [Editor(typeof (K87hpw9XvbU6vpD5hK), typeof (UITypeEditor))]
		public Instrument Instrument { get; set; }

		[FIXField("623", EFieldOption.Optional)]
		public double LegRatioQty
		{
			get
			{
				return this.GetDoubleValue(623);
			}
			set
			{
				this.SetDoubleValue(623, value);
			}
		}

		[FIXField("624", EFieldOption.Optional)]
		public char LegSide
		{
			get
			{
				return this.GetCharValue(624);
			}
			set
			{
				this.SetCharValue(624, value);
			}
		}

		[FIXField("556", EFieldOption.Optional)]
		public string LegCurrency
		{
			get
			{
				return this.GetStringValue(556);
			}
			set
			{
				this.SetStringValue(556, value);
			}
		}

		public Leg(Instrument instrument) : base()
		{
			this.Instrument = instrument;
		}

		public Leg(Instrument instrument, char side, double ratioQty) : base()
		{
			this.Instrument = instrument;
			this.LegSide = side;
			this.LegRatioQty = ratioQty;
		}

		public Leg(string symbol) : base()
		{
			this.Instrument = InstrumentManager.Instruments[symbol];
			if (this.Instrument == null)
				throw new ArgumentException("" + symbol);
		}

		public Leg(string symbol, char side, double ratioQty) : base()
		{
			this.Instrument = InstrumentManager.Instruments[symbol];
			if (this.Instrument == null)
				throw new ArgumentException("" + symbol);
			this.LegSide = side;
			this.LegRatioQty = ratioQty;
		}

		public override string ToString()
		{
			if (this.Instrument != null)
				return this.Instrument.Symbol;
			else
				return "";
		}
	}
}
