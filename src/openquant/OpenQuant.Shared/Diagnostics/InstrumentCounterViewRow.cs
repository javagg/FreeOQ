using System.Windows.Forms;

namespace OpenQuant.Shared.Diagnostics
{
	class InstrumentCounterViewRow : EventCounterViewRow
	{
		public InstrumentCounterViewRow(InstrumentCounter counter) : base((EventCounter)counter, 1)
		{
			this.Cells[0].Value = counter.Instrument.Symbol;
		}

		protected override DataGridViewCellCollection CreateCellsInstance()
		{
			DataGridViewCellCollection cellsInstance = base.CreateCellsInstance();
			cellsInstance.Insert(0, (DataGridViewCell)new DataGridViewTextBoxCell());
			return cellsInstance;
		}
	}
}
