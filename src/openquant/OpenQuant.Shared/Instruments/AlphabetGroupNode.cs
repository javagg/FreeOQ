using FreeQuant.FIX;
using FreeQuant.Instruments;

namespace OpenQuant.Shared.Instruments
{
	class AlphabetGroupNode : GroupNode
	{
		private char letter;

		public AlphabetGroupNode(char letter)
		{
			this.letter = letter;
			this.SetText(letter.ToString());
		}

		public override bool IsInstrumentValid(Instrument instrument)
		{
			return (int)this.letter == (int)((FIXInstrument)instrument).Symbol[0];
		}
	}
}
