using FreeQuant.FIX;
using FreeQuant.Instruments;
using System;

namespace OpenQuant.Shared.Instruments
{
	class MaturityGroupNode : GroupNode
	{
		public DateTime Maturity { get; private set; }

		public MaturityGroupNode(DateTime maturity)
		{
			this.Maturity = maturity;
			if (maturity == DateTime.MinValue)
				this.SetText(null);
			else
				this.SetText(maturity.ToShortDateString());
		}

		public override bool IsInstrumentValid(Instrument instrument)
		{
			return ((FIXInstrument)instrument).MaturityDate == this.Maturity;
		}
	}
}
