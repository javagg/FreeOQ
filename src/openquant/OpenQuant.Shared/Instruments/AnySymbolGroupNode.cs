using FreeQuant.Instruments;

namespace OpenQuant.Shared.Instruments
{
	class AnySymbolGroupNode : GroupNode
	{
		public AnySymbolGroupNode()
		{
			this.SetText("Instruments");
		}

		public override bool IsInstrumentValid(Instrument instrument)
		{
			return true;
		}
	}
}
