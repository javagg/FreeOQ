using System.Windows.Forms;

namespace OpenQuant.Shared.Diagnostics
{
  class EventCounterViewRow : DataGridViewRow
  {
    private int columnIndex;

    public EventCounter Counter { get; private set; }

    protected EventCounterViewRow(EventCounter counter, int columnIndex)
    {
      this.Counter = counter;
      this.columnIndex = columnIndex;
    }

    public void UpdateCounter(EventCounter counter)
    {
      EventCounter counter1 = this.Counter;
      this.Counter = counter;
      this.Cells[this.columnIndex].Value = (object) counter.Trades.Value;
      this.Cells[this.columnIndex + 1].Value = (object) (counter.Trades.Value - counter1.Trades.Value);
      this.Cells[this.columnIndex + 2].Value = (object) counter.Quotes.Value;
      this.Cells[this.columnIndex + 3].Value = (object) (counter.Quotes.Value - counter1.Quotes.Value);
    }

    protected override DataGridViewCellCollection CreateCellsInstance()
    {
      DataGridViewCellCollection viewCellCollection = new DataGridViewCellCollection((DataGridViewRow) this)
      {
        (DataGridViewCell) new DataGridViewTextBoxCell(),
        (DataGridViewCell) new DataGridViewTextBoxCell(),
        (DataGridViewCell) new DataGridViewTextBoxCell(),
        (DataGridViewCell) new DataGridViewTextBoxCell()
      };
      return base.CreateCellsInstance();
    }
  }
}
