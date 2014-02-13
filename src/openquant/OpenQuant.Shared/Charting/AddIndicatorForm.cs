//using OpenQuant.API;
using FreeQuant.Indicators;
using FreeQuant.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

using Indicator = FreeQuant.Indicators.Indicator;
using TimeSeries = FreeQuant.Series.TimeSeries;

namespace OpenQuant.Shared.Charting
{
	partial class AddIndicatorForm : Form
  {


    private Indicator indicator;
	private Indicator sq_indicator; 
    private int padNumber;

    public Indicator Indicator
    {
      get
      {
        return this.sq_indicator;
      }
    }

    public int PadNumber
    {
      get
      {
        if (this.cbxNewPad.Checked)
          return -1;
        else
          return (int) this.cbxPads.SelectedItem;
      }
    }

    internal SeriesItem SeriesItem
    {
      get
      {
        return this.cbxSeries.SelectedItem as SeriesItem;
      }
    }

    public AddIndicatorForm(System.Type indicatorType, int padCount, DoubleSeries series, List<Indicator> indicatorList, int selectedPad, Color color)
    {
      this.InitializeComponent();
      this.padNumber = padCount;
      this.sq_indicator = Activator.CreateInstance(indicatorType) as Indicator;
      this.indicator = Activator.CreateInstance(System.Type.GetType("OpenQuant.API.Indicators." + indicatorType.Name + ", OpenQuant.API"), true) as Indicator;
      this.sq_indicator = this.indicator.GetType().GetField("indicator", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).GetValue((object) this.indicator) as Indicator;
      this.txtName.Text = ((TimeSeries) this.sq_indicator).Name;
			((TimeSeries) this.sq_indicator).Color = color;
      this.propertyGrid1.SelectedObject = (object) this.indicator;
      for (int index = 0; index < this.padNumber; ++index)
        this.cbxPads.Items.Add((object) index);
      this.cbxSeries.Items.Add((object) new SeriesItem(series));
      using (List<Indicator>.Enumerator enumerator = indicatorList.GetEnumerator())
      {
        while (enumerator.MoveNext())
          this.cbxSeries.Items.Add((object) new SeriesItem((DoubleSeries) enumerator.Current));
      }
      this.cbxPads.SelectedIndex = selectedPad;
      this.cbxSeries.SelectedIndex = 0;
			if (selectedPad != -1 && this.sq_indicator.Type == EIndicatorType.Price)
        return;
      this.cbxNewPad.Checked = true;
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
			((TimeSeries) this.sq_indicator).Name = this.txtName.Text;
			this.sq_indicator.Input = (TimeSeries) (this.cbxSeries.SelectedItem as SeriesItem).Series;
    }

    private void cbxNewPad_CheckedChanged(object sender, EventArgs e)
    {
      this.cbxPads.Enabled = !this.cbxNewPad.Checked;
    }
  }
}
