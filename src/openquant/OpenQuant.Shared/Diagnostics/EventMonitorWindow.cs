using OpenQuant.Shared;
using OpenQuant.Shared.Properties;
using FreeQuant.FIX;
using FreeQuant.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Shared.Diagnostics
{
    public  partial class EventMonitorWindow : FreeQuant.Docking.WinForms.DockControl, ITimerItem
    {
        private TotalCounter counter;
        private Dictionary<IProvider, ProviderCounterViewRow> providerCounterRows;
        private Dictionary<IFIXInstrument, InstrumentCounterViewRow> instrumentCounterRows;
        private IProvider selectedProvider;

        public double Interval
        {
            get
            {
                return TimeSpan.FromSeconds(1.0).TotalMilliseconds;
            }
        }

        public ISynchronizeInvoke SynchronizingObject
        {
            get
            {
                return (ISynchronizeInvoke)this;
            }
        }

        public EventMonitorWindow()
        {
            this.InitializeComponent();
            this.counter = new TotalCounter();
            this.providerCounterRows = new Dictionary<IProvider, ProviderCounterViewRow>();
            this.instrumentCounterRows = new Dictionary<IFIXInstrument, InstrumentCounterViewRow>();
            this.selectedProvider = (IProvider)null;
        }

        protected override void OnInit()
        {
            // ISSUE: method pointer
            ProviderManager.NewTrade += new TradeEventHandler(this.ProviderManager_NewTrade);
            // ISSUE: method pointer
            ProviderManager.NewQuote += new QuoteEventHandler(this.ProviderManager_NewQuote);
            Global.TimerManager.Start((ITimerItem)this);
        }

        protected override void OnClosing(DockControlClosingEventArgs e)
        {
            Global.TimerManager.Stop((ITimerItem)this);
            // ISSUE: method pointer
            ProviderManager.NewTrade -= new TradeEventHandler(this.ProviderManager_NewTrade);
            // ISSUE: method pointer
            ProviderManager.NewQuote -= new QuoteEventHandler(this.ProviderManager_NewQuote);
            base.OnClosing(e);
        }

        private void tsbResetCounters_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show((IWin32Window)this, "Do you really want to reset counters?", "Reset Counters", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            this.counter.Reset();
            this.OnTotalCounterReset();
        }

        private void dgvProviderCounters_SelectionChanged(object sender, EventArgs e)
        {
            this.OnSelectedProviderCounterChanged();
        }

        private void ProviderManager_NewTrade(object sender, TradeEventArgs args)
        {
            this.counter.Add(args);
        }

        private void ProviderManager_NewQuote(object sender, QuoteEventArgs args)
        {
            this.counter.Add(args);
        }

        public void OnElapsed()
        {
            this.UpdateProviderCounters(this.counter.GetSnapshot().ProviderCounters);
        }

        private void OnTotalCounterReset()
        {
            this.providerCounterRows.Clear();
            this.dgvProviderCounters.Rows.Clear();
        }

        private void UpdateProviderCounters(ICollection<ProviderCounter> providerCounters)
        {
            foreach (ProviderCounter counter in (IEnumerable<ProviderCounter>) providerCounters)
            {
                ProviderCounterViewRow providerCounterViewRow;
                if (!this.providerCounterRows.TryGetValue(counter.Provider, out providerCounterViewRow))
                {
                    providerCounterViewRow = new ProviderCounterViewRow(counter);
                    providerCounterViewRow.Height = this.dgvProviderCounters.RowTemplate.Height;
                    this.providerCounterRows.Add(counter.Provider, providerCounterViewRow);
                    this.dgvProviderCounters.Rows.Add((DataGridViewRow)providerCounterViewRow);
                }
                providerCounterViewRow.UpdateCounter((EventCounter)counter);
                if (counter.Provider == this.selectedProvider)
                    this.UpdateInstrumentCounters(counter.InstrumentCounters);
            }
        }

        private void OnSelectedProviderCounterChanged()
        {
            this.instrumentCounterRows.Clear();
            this.dgvInstrumentCounters.Rows.Clear();
            this.selectedProvider = (IProvider)null;
            if (this.dgvProviderCounters.SelectedRows.Count != 1)
                return;
            ProviderCounter providerCounter = (ProviderCounter)((EventCounterViewRow)this.dgvProviderCounters.SelectedRows[0]).Counter;
            this.UpdateInstrumentCounters(providerCounter.InstrumentCounters);
            this.selectedProvider = providerCounter.Provider;
        }

        private void UpdateInstrumentCounters(ICollection<InstrumentCounter> instrumentCounters)
        {
            foreach (InstrumentCounter counter in (IEnumerable<InstrumentCounter>) instrumentCounters)
            {
                InstrumentCounterViewRow instrumentCounterViewRow;
                if (!this.instrumentCounterRows.TryGetValue(counter.Instrument, out instrumentCounterViewRow))
                {
                    instrumentCounterViewRow = new InstrumentCounterViewRow(counter);
                    instrumentCounterViewRow.Height = this.dgvInstrumentCounters.RowTemplate.Height;
                    this.instrumentCounterRows.Add(counter.Instrument, instrumentCounterViewRow);
                    this.dgvInstrumentCounters.Rows.Add((DataGridViewRow)instrumentCounterViewRow);
                }
                instrumentCounterViewRow.UpdateCounter((EventCounter)counter);
            }
        }
    }
}
