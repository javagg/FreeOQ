using FreeQuant.Instruments;
using FreeQuant.Series;
using System;
using System.Collections.Generic;
using System.Threading;

namespace OpenQuant.Shared.Instruments
{
	public class InstrumentListSource
	{
//		private InstrumentEventHandler SelectedInstrumentChanged;
//		private BarSeriesEventHandler SeriesAdded;
//		private BarSeriesEventHandler SeriesRenamed;

		public event InstrumentEventHandler SelectedInstrumentChanged;
		public event BarSeriesEventHandler SeriesAdded;
		public event BarSeriesEventHandler SeriesRenamed;

		private Instrument selectedInstrument;
		private Dictionary<Instrument, InstrumentEntry> instrumentTable;
		private bool allowAll;

		private BarSeries selectedSeries;

		public bool ShowSeries { get; set; }

		public Dictionary<Instrument, InstrumentEntry> InstrumentTable
		{
			get
			{
				return this.instrumentTable;
			}
		}

		public Instrument SelectedInstrument
		{
			get
			{
				return this.selectedInstrument;
			}
			set
			{
				this.selectedInstrument = value;
				if (this.SelectedInstrumentChanged == null)
					return;
				this.SelectedInstrumentChanged.Invoke(new InstrumentEventArgs(this.selectedInstrument));
			}
		}

		public BarSeries SelectedSeries
		{
			get
			{
				return this.selectedSeries;
			}
			set
			{
				this.selectedSeries = value;
				if (this.SelectedSeriesChanged != null)
				this.SelectedSeriesChanged(this, EventArgs.Empty);
			}
		}

		public bool AllowAll { get; set; }

//		    public event InstrumentEventHandler SelectedInstrumentChanged
//		    {
//		      add
//		      {
//		        InstrumentEventHandler instrumentEventHandler = this.SelectedInstrumentChanged;
//		        InstrumentEventHandler comparand;
//		        do
//		        {
//		          comparand = instrumentEventHandler;
//		          instrumentEventHandler = Interlocked.CompareExchange<InstrumentEventHandler>(ref this.SelectedInstrumentChanged, (InstrumentEventHandler) Delegate.Combine((Delegate) comparand, (Delegate) value), comparand);
//		        }
//		        while (instrumentEventHandler != comparand);
//		      }
//		      remove
//		      {
//		        InstrumentEventHandler instrumentEventHandler = this.SelectedInstrumentChanged;
//		        InstrumentEventHandler comparand;
//		        do
//		        {
//		          comparand = instrumentEventHandler;
//		          instrumentEventHandler = Interlocked.CompareExchange<InstrumentEventHandler>(ref this.SelectedInstrumentChanged, (InstrumentEventHandler) Delegate.Remove((Delegate) comparand, (Delegate) value), comparand);
//		        }
//		        while (instrumentEventHandler != comparand);
//		      }
//		    }
		public event EventHandler SelectedSeriesChanged;
		public event EventHandler InstrumentListUpdated;
		//    public event BarSeriesEventHandler SeriesAdded
		//    {
		//      add
		//      {
		//        BarSeriesEventHandler seriesEventHandler = this.SeriesAdded;
		//        BarSeriesEventHandler comparand;
		//        do
		//        {
		//          comparand = seriesEventHandler;
		//          seriesEventHandler = Interlocked.CompareExchange<BarSeriesEventHandler>(ref this.SeriesAdded, (BarSeriesEventHandler) Delegate.Combine((Delegate) comparand, (Delegate) value), comparand);
		//        }
		//        while (seriesEventHandler != comparand);
		//      }
		//      remove
		//      {
		//        BarSeriesEventHandler seriesEventHandler = this.SeriesAdded;
		//        BarSeriesEventHandler comparand;
		//        do
		//        {
		//          comparand = seriesEventHandler;
		//          seriesEventHandler = Interlocked.CompareExchange<BarSeriesEventHandler>(ref this.SeriesAdded, (BarSeriesEventHandler) Delegate.Remove((Delegate) comparand, (Delegate) value), comparand);
		//        }
		//        while (seriesEventHandler != comparand);
		//      }
		//    }
		//    public event BarSeriesEventHandler SeriesRenamed
		//    {
		//      add
		//      {
		//        BarSeriesEventHandler seriesEventHandler = this.SeriesRenamed;
		//        BarSeriesEventHandler comparand;
		//        do
		//        {
		//          comparand = seriesEventHandler;
		//          seriesEventHandler = Interlocked.CompareExchange<BarSeriesEventHandler>(ref this.SeriesRenamed, (BarSeriesEventHandler) Delegate.Combine((Delegate) comparand, (Delegate) value), comparand);
		//        }
		//        while (seriesEventHandler != comparand);
		//      }
		//      remove
		//      {
		//        BarSeriesEventHandler seriesEventHandler = this.SeriesRenamed;
		//        BarSeriesEventHandler comparand;
		//        do
		//        {
		//          comparand = seriesEventHandler;
		//          seriesEventHandler = Interlocked.CompareExchange<BarSeriesEventHandler>(ref this.SeriesRenamed, (BarSeriesEventHandler) Delegate.Remove((Delegate) comparand, (Delegate) value), comparand);
		//        }
		//        while (seriesEventHandler != comparand);
		//      }
		//    }
		public InstrumentListSource()
		{
			this.instrumentTable = new Dictionary<Instrument, InstrumentEntry>();
			this.allowAll = true;
		}

		public void Clear()
		{
			this.instrumentTable.Clear();
			this.selectedInstrument = (Instrument)null;
			this.selectedSeries = (BarSeries)null;
		}

		public void AddInstrument(Instrument instrument)
		{
			this.instrumentTable.Add(instrument, new InstrumentEntry(instrument));
		}

		public void AddSeries(Instrument instrument, BarSeries series)
		{
			if (!this.instrumentTable.ContainsKey(instrument))
				return;
			this.instrumentTable[instrument].SeriesList.Add(series);
			if (this.SeriesAdded != null)
				this.SeriesAdded.Invoke((object)this, new BarSeriesEventArgs(series, instrument));
			if (instrument != this.selectedInstrument || this.instrumentTable[instrument].SeriesList.Count != 1)
				return;
			this.SelectedSeries = series;
		}

		public void RenameSeries(Instrument instrument, BarSeries series)
		{
			if (!this.instrumentTable[instrument].SeriesList.Contains(series) || this.SeriesRenamed == null)
				return;
			this.SeriesRenamed.Invoke((object)this, new BarSeriesEventArgs(series, instrument));
		}

		public void Refresh()
		{
			if (this.InstrumentListUpdated == null)
				return;
			this.InstrumentListUpdated((object)this, EventArgs.Empty);
		}
	}
}
