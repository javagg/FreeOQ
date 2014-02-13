using FreeQuant.Data;
using FreeQuant.Instruments;
using System.Windows.Forms;

namespace OpenQuant.Shared.TradingTools
{
	class MarketDataViewRow : DataGridViewRow
	{
		private Instrument instrument;
		private volatile bool enabled;
		private int cellCount;

		public Instrument Instrument
		{
			get
			{
				return this.instrument;
			}
		}

		protected MarketDataViewRow(Instrument instrument, int cellCount)
		{
			this.instrument = instrument;
			this.cellCount = cellCount;
			this.enabled = true;
		}

		public void Disconnect()
		{
			this.enabled = false;
		}

		public void Update(Quote quote, Trade trade, Bar bar)
		{
			if (!this.enabled)
				return;
			if (quote != null)
				this.OnUpdateQuote(quote);
			if (trade != null)
				this.OnUpdateTrade(trade);
			if (bar == null)
				return;
			this.OnUpdateBar(bar);
		}

		protected virtual void OnUpdateQuote(Quote quote)
		{
		}

		protected virtual void OnUpdateTrade(Trade trade)
		{
		}

		protected virtual void OnUpdateBar(Bar bar)
		{
		}

		protected override DataGridViewCellCollection CreateCellsInstance()
		{
			DataGridViewCellCollection viewCellCollection = new DataGridViewCellCollection((DataGridViewRow)this);
			for (int index = 0; index < this.cellCount; ++index)
				viewCellCollection.Add((DataGridViewCell)new DataGridViewTextBoxCell());
			return viewCellCollection;
		}
	}
}
