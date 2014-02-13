using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using System;
using System.Drawing;
using System.Globalization;

namespace OpenQuant.Shared.TradingTools
{
	class QuoteViewRow : MarketDataViewRow
	{
		private double prevPrice;

		public QuoteViewRow(Instrument instrument)
      : base(instrument, 10)
		{
			this.prevPrice = 0.0;
			Color color1 = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 200);
			Color color2 = Color.FromArgb((int)byte.MaxValue, 230, 230);
			Color color3 = Color.FromArgb(220, (int)byte.MaxValue, 220);
			this.Cells[0].Value = (object)((FIXInstrument)instrument).Symbol;
			this.Cells[0].Style.BackColor = color1;
			this.Cells[2].Style.Format = instrument.PriceDisplay;
			this.Cells[3].Style.Format = instrument.PriceDisplay;
			this.Cells[7].Style.Format = instrument.PriceDisplay;
			this.Cells[7].Style.BackColor = color2;
			this.Cells[8].Style.Format = instrument.PriceDisplay;
			this.Cells[8].Style.BackColor = color3;
			NumberFormatInfo numberFormatInfo = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
			numberFormatInfo.NumberDecimalDigits = 0;
			this.Cells[4].Style.FormatProvider = (IFormatProvider)numberFormatInfo;
			this.Cells[6].Style.FormatProvider = (IFormatProvider)numberFormatInfo;
			this.Cells[6].Style.BackColor = color2;
			this.Cells[9].Style.FormatProvider = (IFormatProvider)numberFormatInfo;
			this.Cells[9].Style.BackColor = color3;
			this.Cells[4].Style.Format = "n";
			this.Cells[6].Style.Format = "n";
			this.Cells[9].Style.Format = "n";
			this.Cells[1].Style.Format = DateTimeFormatInfo.CurrentInfo.LongTimePattern;
		}

		protected override void OnUpdateQuote(Quote quote)
		{
			this.Cells[1].Value = quote.DateTime;
			this.Cells[6].Value = quote.BidSize;
			this.Cells[7].Value = quote.Bid;
			this.Cells[8].Value = quote.Ask;
			this.Cells[9].Value = quote.AskSize;
		}

		protected override void OnUpdateTrade(Trade trade)
		{
			double change = this.GetChange(trade.Price);
			this.Cells[1].Value = trade.DateTime;
			this.Cells[2].Value = trade.Price;
			this.Cells[3].Value = change;
			this.Cells[4].Value = trade.Size;
			if (change > 0.0)
				this.Cells[2].Style.ForeColor = Color.Green;
			else if (change < 0.0)
			{
				this.Cells[2].Style.ForeColor = Color.Red;
			}
			else
			{
				if (this.DataGridView == null)
					return;
				this.Cells[2].Style.ForeColor = this.DataGridView.Columns[2].DefaultCellStyle.ForeColor;
			}
		}

		private double GetChange(double price)
		{
			double num = this.prevPrice == 0.0 ? 0.0 : price - this.prevPrice;
			this.prevPrice = price;
			return num;
		}
	}
}
