using FreeQuant.FIX;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
	public class Underlying : FIXGroup
	{
		private Instrument instrument;
		//    [Editor(typeof (K87hpw9XvbU6vpD5hK), typeof (UITypeEditor))]
		public Instrument Instrument
		{
			get
			{
				return this.instrument;
			}
			set
			{
				this.instrument = value;
			}
		}

		[FIXField("318", EFieldOption.Optional)]
		public string UnderlyingCurrency
		{
			get
			{
				return this.GetStringValue(318);
			}
			set
			{
				this.SetStringValue(318, value);
			}
		}

		[FIXField("879", EFieldOption.Optional)]
		public double UnderlyingQty
		{
			get
			{
				return this.GetDoubleValue(879);
			}
			set
			{
				this.SetDoubleValue(879, value);
			}
		}

		[FIXField("810", EFieldOption.Optional)]
		public double UnderlyingPx
		{
			get
			{
				return this.GetDoubleValue(810);
			}
			set
			{
				this.SetDoubleValue(810, value);
			}
		}

		[FIXField("882", EFieldOption.Optional)]
		public double UnderlyingDirtyPrice
		{
			get
			{
				return this.GetDoubleValue(882);
			}
			set
			{
				this.SetDoubleValue(882, value);
			}
		}

		[FIXField("883", EFieldOption.Optional)]
		public double UnderlyingEndPrice
		{
			get
			{
				return this.GetDoubleValue(883);
			}
			set
			{
				this.SetDoubleValue(883, value);
			}
		}

		[FIXField("884", EFieldOption.Optional)]
		public double UnderlyingStartValue
		{
			get
			{
				return this.GetDoubleValue(884);
			}
			set
			{
				this.SetDoubleValue(884, value);
			}
		}

		[FIXField("885", EFieldOption.Optional)]
		public double UnderlyingCurrentValue
		{
			get
			{
				return this.GetDoubleValue(885);
			}
			set
			{
				this.SetDoubleValue(885, value);
			}
		}

		[FIXField("886", EFieldOption.Optional)]
		public double UnderlyingEndValue
		{
			get
			{
				return this.GetDoubleValue(886);
			}
			set
			{
				this.SetDoubleValue(886, value);
			}
		}

		public Underlying() : base()
		{

		}

		public Underlying(Instrument instrument) : base()
		{

			this.instrument = instrument;
		}

		public Underlying(string symbol) : base()
		{

			this.instrument = InstrumentManager.Instruments[symbol];
			if (this.instrument == null)
				throw new ArgumentException("" + symbol);
		}

		public override string ToString()
		{
			if (this.instrument != null)
				return this.instrument.Symbol;
			else
				return "fsdddd";
		}
	}
}
