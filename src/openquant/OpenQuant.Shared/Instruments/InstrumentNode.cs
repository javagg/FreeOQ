using FreeQuant.FIX;
using FreeQuant.Instruments;
using System.Windows.Forms;

namespace OpenQuant.Shared.Instruments
{
	class InstrumentNode : TreeNode
	{
		public Instrument Instrument { get; private set; }

		public InstrumentNode(Instrument instrument) : base(instrument.Symbol, 0, 0)
		{
			this.Instrument = instrument;
		}
	}
}
