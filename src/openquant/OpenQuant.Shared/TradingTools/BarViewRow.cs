using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using System;
using System.Drawing;
using System.Globalization;

namespace OpenQuant.Shared.TradingTools
{
	class BarViewRow : MarketDataViewRow
	{
		public BarViewRow(Instrument instrument)
      : base(instrument, 8)
		{
			this.Cells[0].Style.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 200);
			this.Cells[2].Style.Format = instrument.PriceDisplay;
			this.Cells[3].Style.Format = instrument.PriceDisplay;
			this.Cells[4].Style.Format = instrument.PriceDisplay;
			this.Cells[5].Style.Format = instrument.PriceDisplay;
			NumberFormatInfo numberFormatInfo = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
			numberFormatInfo.NumberDecimalDigits = 0;
			this.Cells[6].Style.Format = "n";
			this.Cells[6].Style.FormatProvider = (IFormatProvider)numberFormatInfo;
			this.Cells[0].Value = (object)((FIXInstrument)instrument).Symbol;
		}

		protected override void OnUpdateBar(Bar bar)
		{
			this.Cells[1].Value = !(bar is Daily) ? (!(bar.BeginTime != DateTime.MinValue) ? "" : string.Format("{0:T} - {1:T}", bar.BeginTime, bar.EndTime)) : bar.DateTime.ToShortDateString();
			this.Cells[2].Value = (object)bar.Open;
			this.Cells[3].Value = (object)bar.High;
			this.Cells[4].Value = (object)bar.Low;
			this.Cells[5].Value = (object)bar.Close;
			this.Cells[6].Value = (object)bar.Volume;
			this.Cells[7].Value = (object)new BarSizeInfo(bar.BarType, bar.Size);
		}
	}
}
