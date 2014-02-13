using FreeQuant.Charting;
using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Collections;

namespace OpenQuant.Shared.TradingTools
{
	class InstrumentPad
	{
		private bool isFirstTime = true;
		private DateTime lastUpdateDate = DateTime.MinValue;
		private const int NUM_OF_MINUTES = 15;
		private Pad pad;
		private Instrument instrument;
		private Hashtable padSizes;

		public Instrument Instrument
		{
			get
			{
				return this.instrument;
			}
			set
			{
				if (this.instrument != null && this.pad.XMax - this.pad.XMin > 1000000.0 && (DataManager.Trades.Count > 0 || DataManager.Quotes.Count > 0))
					this.padSizes[(object)((FIXInstrument)this.instrument).Symbol] = (object)(this.pad.XMax - this.pad.XMin);
				this.pad.ResetLastTickTime();
				this.pad.Monitored = false;
				this.pad.Clear();
				if (this.instrument != null)
				{
					((DataArray)DataManager.Trades[this.instrument]).Cleared -= new EventHandler(this.InstrumentPad_Cleared);
					((DataArray)DataManager.Quotes[this.instrument]).Cleared-= new EventHandler(this.InstrumentPad_Cleared);
				}
				this.instrument = value;
				if (this.instrument != null)
				{
					this.pad.YAxisLabelFormat = this.instrument.PriceDisplay;
					((DataArray)DataManager.Trades[this.instrument]).Cleared += new EventHandler(this.InstrumentPad_Cleared);
					((DataArray)DataManager.Quotes[this.instrument]).Cleared += new EventHandler(this.InstrumentPad_Cleared);
					Chart.Pad = this.pad;
					this.pad.Chart.cd(1);
					DataManager.Trades[this.instrument].Draw();
					this.pad.Chart.cd(1);
					DataManager.Quotes[this.instrument].Draw();
					DateTime dateTime1 = DateTime.MinValue;
					DateTime dateTime2 = DateTime.MinValue;
					if (((DataArray)DataManager.Quotes[this.instrument]).Count != 0)
						dateTime1 = ((DataArray)DataManager.Quotes[this.instrument]).LastDateTime;
					if (((DataArray)DataManager.Trades[this.instrument]).Count != 0)
						dateTime2 = ((DataArray)DataManager.Trades[this.instrument]).LastDateTime;
					DateTime dateTime3 = dateTime1 > dateTime2 ? dateTime1 : dateTime2;
					this.isFirstTime = false;
					this.lastUpdateDate = dateTime3;
					if (this.padSizes.Contains((object)((FIXInstrument)this.instrument).Symbol))
						this.pad.SetRangeX((double)this.lastUpdateDate.Ticks - (double)this.padSizes[(object)((FIXInstrument)this.instrument).Symbol], (double)this.lastUpdateDate.AddMilliseconds(1.0).Ticks);
					else if (((DataArray)DataManager.Trades[this.instrument]).Count > 0 || ((DataArray)DataManager.Quotes[this.instrument]).Count > 0)
					{
						this.pad.SetRangeX((double)(Math.Max(((DataArray)DataManager.Quotes[this.instrument]).LastDateTime.Ticks, ((DataArray)DataManager.Trades[this.instrument]).LastDateTime.Ticks) - 9000000000L), (double)Math.Max(((DataArray)DataManager.Quotes[this.instrument]).LastDateTime.Ticks, ((DataArray)DataManager.Trades[this.instrument]).LastDateTime.Ticks));
					}
					else
					{
						DateTime now = DateTime.Now;
						this.pad.SetRangeX((double)(now.Ticks - 9000000000L), (double)now.Ticks);
					}
				}
				else
				{
					DateTime now = DateTime.Now;
					this.pad.SetRangeX((double)(now.Ticks - 9000000000L), (double)now.Ticks);
				}
				this.pad.Update();
			}
		}

		public InstrumentPad(Pad pad)
		{
			this.pad = pad;
			this.padSizes = new Hashtable();
			pad.Chart.GroupRightMarginEnabled = true;
			pad.Chart.GroupRightMarginEnabled = true;
		}

		public void UpdatePad()
		{
			this.pad.Update();
		}

		public void OnNewTrade(object sender, TradeEventArgs args)
		{
			if (((IntradayEventArgs)args).Instrument != this.instrument)
				return;
			if (((DataArray)DataManager.Trades[this.instrument]).Count == 1 && ((DataArray)DataManager.Quotes[this.instrument]).Count == 0)
				this.isFirstTime = true;
			DateTime lastDateTime = ((DataArray)DataManager.Trades[this.instrument]).LastDateTime;
			int num = ((DataArray)DataManager.Trades[this.instrument]).Count - 2;
			while (num >= 0 && DataManager.Trades[this.instrument][num].DateTime == lastDateTime)
				--num;
			if (num < 0)
				return;
//			DataManager.Trades[this.instrument][num].DateTime;
			if (lastDateTime >= this.lastUpdateDate)
			{
				if (this.isFirstTime)
				{
					this.pad.SetRangeX((double)(((DataArray)DataManager.Trades[this.instrument]).LastDateTime.Ticks - 9000000000L), (double)((DataArray)DataManager.Trades[this.instrument]).LastDateTime.Ticks);
					this.isFirstTime = false;
				}
				else
					this.pad.SetRangeX((double)((DataArray)DataManager.Trades[this.instrument]).LastDateTime.Ticks + this.pad.XMin - (double)this.lastUpdateDate.Ticks, (double)((DataArray)DataManager.Trades[this.instrument]).LastDateTime.Ticks + (this.pad.XMax - (double)this.lastUpdateDate.Ticks));
			}
			this.lastUpdateDate = lastDateTime;
		}

		public void OnNewQuote(object sender, QuoteEventArgs args)
		{
			if (((IntradayEventArgs)args).Instrument != this.instrument)
				return;
			if (((DataArray)DataManager.Quotes[this.instrument]).Count == 1 && ((DataArray)DataManager.Trades[this.instrument]).Count == 0)
				this.isFirstTime = true;
			DateTime lastDateTime = ((DataArray)DataManager.Quotes[this.instrument]).LastDateTime;
			int num = ((DataArray)DataManager.Quotes[this.instrument]).Count - 2;
			while (num >= 0 && DataManager.Quotes[this.instrument][num].DateTime == lastDateTime)
				--num;
			if (num < 0)
				return;
//			DataManager.Quotes[this.instrument][num].DateTime;
			if (lastDateTime >= this.lastUpdateDate)
			{
				if (this.isFirstTime)
				{
					this.pad.SetRangeX((double)(((DataArray)DataManager.Quotes[this.instrument]).LastDateTime.Ticks - 9000000000L), (double)((DataArray)DataManager.Quotes[this.instrument]).LastDateTime.Ticks);
					this.isFirstTime = false;
				}
				else
					this.pad.SetRangeX((double)((DataArray)DataManager.Quotes[this.instrument]).LastDateTime.Ticks + this.pad.XMin - (double)this.lastUpdateDate.Ticks, (double)((DataArray)DataManager.Quotes[this.instrument]).LastDateTime.Ticks + (this.pad.XMax - (double)this.lastUpdateDate.Ticks));
			}
			this.lastUpdateDate = lastDateTime;
		}

		private void InstrumentPad_Cleared(object sender, EventArgs e)
		{
			this.isFirstTime = true;
			this.lastUpdateDate = DateTime.MinValue;
		}
	}
}
