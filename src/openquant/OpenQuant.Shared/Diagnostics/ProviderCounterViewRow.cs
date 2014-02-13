using System.Windows.Forms;

namespace OpenQuant.Shared.Diagnostics
{
	class ProviderCounterViewRow : EventCounterViewRow
	{
		public ProviderCounterViewRow(ProviderCounter counter) : base(counter, 1)
		{
			this.Cells[0].Value = counter.Provider.Name;
		}

		protected override DataGridViewCellCollection CreateCellsInstance()
		{
			DataGridViewCellCollection cellsInstance = base.CreateCellsInstance();
			cellsInstance.Insert(0, new DataGridViewTextBoxCell());
			return cellsInstance;
		}
	}
}
