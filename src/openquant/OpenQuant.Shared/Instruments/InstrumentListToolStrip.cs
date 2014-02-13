using FreeQuant.Instruments;
using FreeQuant.Series;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Instruments
{
	[ToolboxBitmap(typeof(ToolStrip))]
	public class InstrumentListToolStrip : ToolStrip
	{
		private InstrumentListSource instrumentListSource;
		private ToolStripComboBox comboBox;
		private ToolStripComboBox cbxSeries;
		private bool updating;

		public InstrumentListSource InstrumentListSource
		{
			get
			{
				return this.instrumentListSource;
			}
			set
			{
				if (this.instrumentListSource != null)
				{
					this.instrumentListSource.InstrumentListUpdated -= new EventHandler(this.instrumentListSource_InstrumentListUpdated);
					this.instrumentListSource.SelectedSeriesChanged -= new EventHandler(this.instrumentListSource_SelectedSeriesChanged);
					this.instrumentListSource.SeriesAdded -= new BarSeriesEventHandler(this.instrumentListSource_SeriesAdded);
					this.instrumentListSource.SeriesRenamed -= new BarSeriesEventHandler(this.instrumentListSource_SeriesRenamed);
				}
				this.instrumentListSource = value;
				if (this.instrumentListSource != null)
				{
					this.instrumentListSource.InstrumentListUpdated += new EventHandler(this.instrumentListSource_InstrumentListUpdated);
					this.instrumentListSource.SelectedSeriesChanged += new EventHandler(this.instrumentListSource_SelectedSeriesChanged);
					this.instrumentListSource.SeriesAdded += new BarSeriesEventHandler(this.instrumentListSource_SeriesAdded);
					this.instrumentListSource.SeriesRenamed += new BarSeriesEventHandler(this.instrumentListSource_SeriesRenamed);
				}
				this.UpdateGui();
			}
		}

		public InstrumentListToolStrip()
		{
			this.comboBox = new ToolStripComboBox();
			this.comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox.SelectedIndexChanged += new EventHandler(this.comboBox_SelectedIndexChanged);
			this.comboBox.AutoSize = false;
			this.comboBox.Width = 80;
			this.cbxSeries = new ToolStripComboBox();
			this.cbxSeries.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbxSeries.SelectedIndexChanged += new EventHandler(this.cbxSeries_SelectedIndexChanged);
			this.cbxSeries.AutoSize = false;
			this.cbxSeries.Width = 80;
			this.Items.Add((ToolStripItem)this.comboBox);
			this.Items.Add((ToolStripItem)this.cbxSeries);
		}

		private void instrumentListSource_InstrumentListUpdated(object sender, EventArgs e)
		{
			this.UpdateGui();
		}

		private void UpdateGui()
		{
			this.updating = true;
			this.comboBox.BeginUpdate();
			this.comboBox.Items.Clear();
			if (this.instrumentListSource == null)
			{
				this.comboBox.Enabled = false;
				this.cbxSeries.Enabled = false;
			}
			else
			{
				this.comboBox.Enabled = true;
				if (this.instrumentListSource.AllowAll)
					this.comboBox.Items.Add((object)"-ALL-");
				using (Dictionary<Instrument, InstrumentEntry>.KeyCollection.Enumerator enumerator = this.instrumentListSource.InstrumentTable.Keys.GetEnumerator())
				{
					while (enumerator.MoveNext())
						this.comboBox.Items.Add((object)enumerator.Current);
				}
				if (this.instrumentListSource.SelectedInstrument != null)
					this.comboBox.SelectedItem = (object)this.instrumentListSource.SelectedInstrument;
				else
					this.comboBox.SelectedIndex = !this.instrumentListSource.AllowAll ? -1 : 0;
				this.UpdateSeries();
			}
			this.comboBox.EndUpdate();
			this.updating = false;
		}

		private void UpdateSeries()
		{
			this.cbxSeries.Items.Clear();
			this.cbxSeries.Enabled = this.instrumentListSource.ShowSeries;
			if (!this.instrumentListSource.ShowSeries || this.instrumentListSource.SelectedInstrument == null)
				return;
			using (List<BarSeries>.Enumerator enumerator = this.instrumentListSource.InstrumentTable[this.instrumentListSource.SelectedInstrument].SeriesList.GetEnumerator())
			{
				while (enumerator.MoveNext())
					this.cbxSeries.Items.Add((object)new BarSeriesItem(enumerator.Current, this.instrumentListSource.SelectedInstrument));
			}
			if (this.cbxSeries.SelectedIndex != -1 || this.cbxSeries.Items.Count <= 0)
				return;
			this.cbxSeries.SelectedIndex = 0;
		}

		private void instrumentListSource_SeriesAdded(object sender, BarSeriesEventArgs args)
		{
			if (this.instrumentListSource == null || !this.instrumentListSource.ShowSeries || args.Instrument != this.instrumentListSource.SelectedInstrument)
				return;
			this.Invoke((Action)(() =>
			{
				this.cbxSeries.Items.Add((object)new BarSeriesItem(args.BarSeries, args.Instrument));
				if (this.cbxSeries.Items.Count != 1)
					return;
				this.cbxSeries.SelectedIndex = 0;
			}));
		}

		private void instrumentListSource_SeriesRenamed(object sender, BarSeriesEventArgs args)
		{
			if (this.instrumentListSource == null || !this.instrumentListSource.ShowSeries)
				return;
			MethodInvoker methodInvoker = (MethodInvoker)(() =>
			{
				if (this.cbxSeries.SelectedItem == null || (this.cbxSeries.SelectedItem as BarSeriesItem).Series != args.BarSeries)
					return;
				BarSeriesItem local_0 = this.cbxSeries.SelectedItem as BarSeriesItem;
				this.cbxSeries.Items.Remove((object)local_0);
				local_0.RefreshName();
				this.cbxSeries.Items.Add((object)local_0);
				this.cbxSeries.SelectedIndex = 0;
			});
			if (!this.InvokeRequired)
				return;
			this.Invoke((Delegate)methodInvoker);
		}

		private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.updating)
				return;
			this.instrumentListSource.SelectedInstrument = this.comboBox.SelectedItem as Instrument;
			this.UpdateSeries();
		}

		private void cbxSeries_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.updating)
				return;
			this.instrumentListSource.SelectedSeries = (this.cbxSeries.SelectedItem as BarSeriesItem).Series;
		}

		private void instrumentListSource_SelectedSeriesChanged(object sender, EventArgs e)
		{
			this.Invoke((Action)(() =>
			{
				if (this.instrumentListSource.SelectedSeries == null || this.comboBox.SelectedItem as Instrument != this.instrumentListSource.SelectedInstrument)
					return;
				foreach (BarSeriesItem item_0 in this.cbxSeries.Items)
				{
					if (item_0.Series == this.instrumentListSource.SelectedSeries)
					{
						this.cbxSeries.SelectedItem = (object)item_0;
						break;
					}
				}
			}));
		}
	}
}
