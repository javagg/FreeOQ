using OpenQuant.Shared;
using FreeQuant.Data;
using FreeQuant.FinChart;
using FreeQuant.FIX;
using FreeQuant.Indicators;
using FreeQuant.Instruments;
using FreeQuant.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;

namespace OpenQuant.Shared.Charting
{
	public partial class ChartColorManagerForm : Form
  {
    private Dictionary<string, ChartColorPropertyViewItem> propertyViewItems = new Dictionary<string, ChartColorPropertyViewItem>();
    private ChartColorTemplate defaultTemplate = new ChartColorTemplate("Default");

    private ChartColorTemplate currentTemplate;
    private bool updating;

    public ChartColorManagerForm()
    {
      this.InitializeComponent();
      this.colorEditor.Init();
      this.AddProperty("ChartBackColor", "Back Color", this.chart.ChartBackColor);
      this.AddProperty("CanvasColor", "Fore Color", this.chart.CanvasColor);
      this.AddProperty("BorderColor", "Border", this.chart.BorderColor);
      this.AddProperty("SplitterColor", "Splitter", this.chart.SplitterColor);
      this.AddProperty("CandleUpColor", "Candle Up", this.chart.CandleUpColor);
      this.AddProperty("CandleDownColor", "Candle Down", this.chart.CandleDownColor);
      this.AddProperty("DefaultLineColor", "Line", this.chart.DefaultLineColor);
      this.AddProperty("VolumeColor", "Volume", this.chart.VolumeColor);
      this.AddProperty("DateTipRectangleColor", "DateTime Tip Area", this.chart.DateTipRectangleColor);
      this.AddProperty("DateTipTextColor", "DateTime Tip Text", this.chart.DateTipTextColor);
      this.AddProperty("ValTipRectangleColor", "Value Tip Area", this.chart.ValTipRectangleColor);
      this.AddProperty("ValTipTextColor", "Value Text Area", this.chart.ValTipTextColor);
      this.AddProperty("CrossColor", "Cross Color", this.chart.CrossColor);
      this.AddProperty("BottomAxisLabelColor", "Bottom Axis Label", this.chart.BottomAxisLabelColor);
      this.AddProperty("BottomAxisGridColor", "Bottom Axis Grid", this.chart.BottomAxisGridColor);
      this.AddProperty("RightAxisGridColor", "Right Axis Grid", this.chart.RightAxisGridColor);
      this.AddProperty("RightAxisTextColor", "Right Axis Text", this.chart.RightAxisTextColor);
      this.AddProperty("RightAxisMajorTicksColor", "Right Axis Major Ticks", this.chart.RightAxisMajorTicksColor);
      this.AddProperty("RightAxisMinorTicksColor", "Right Axis Minor Ticks", this.chart.RightAxisMinorTicksColor);
      this.AddProperty("ItemTextColor", "Transaction Text", this.chart.ItemTextColor);
      this.AddProperty("SelectedItemTextColor", "Selected Transaction Text", this.chart.SelectedItemTextColor);
			this.AddProperty("SelectedTransactionHighlightColor", "Selected Transaction Highlight", this.chart.SelectedTransactionHighlightColor);
      this.ltvColorProperties.Items[0].Selected = true;
      BarSeries barSeries = this.GenerateSeries();
      this.chart.Reset();
      this.chart.SetMainSeries((DoubleSeries) barSeries, true);
      this.chart.AddPad();
      SMA sma = new SMA((TimeSeries) barSeries, 14);
			sma.Name = "Line";
      this.chart.DrawDefaultColoredSeries((DoubleSeries) sma, 2, (SimpleDSStyle) 0, SmoothingMode.AntiAlias);
      Instrument instrument = Activator.CreateInstance(typeof (Instrument), true) as Instrument;
			 instrument.Symbol = "Symbol";
			Transaction transaction1 = new Transaction(((TimeSeries) barSeries).GetDateTime(barSeries.Count - 5), Side.Buy, 100.0, instrument, barSeries[barSeries.Count - 5].Low);
			Transaction transaction2 = new Transaction(((TimeSeries) barSeries).GetDateTime(barSeries.Count - 20), Side.Sell, 100.0, instrument, barSeries[barSeries.Count - 20].High);
      this.chart.DrawTransaction(transaction1, 0);
      this.chart.DrawTransaction(transaction2, 0);
      this.chart.EnsureVisible(transaction1);
      foreach (ChartColorTemplate template in Global.ChartManager.ColorTemplates.All.Values)
        this.ltvTemplates.Items.Add((ListViewItem) new ChartColorTemplateViewItem(template));
      if (this.ltvTemplates.Items.Count <= 0)
        return;
      this.ltvTemplates.Items[0].Selected = true;
    }

    private BarSeries GenerateSeries()
    {
      BarSeries barSeries = new BarSeries("Symbol", "Symbol");
      Random random = new Random();
      double num1 = 500.0;
      long num2 = 100000L;
      DateTime dateTime = new DateTime(2007, 1, 18);
      for (int index = 0; index < 100; ++index)
      {
        num1 = num1 + (double) random.Next(11) - 5.0;
        double num3 = num1 - 6.0 - (double) random.Next(6);
        double num4 = num1 - (double) random.Next(6);
        double num5 = num4 - (double) random.Next(6);
        if (random.Next(2) == 1)
        {
          double num6 = num4;
          num4 = num5;
          num5 = num6;
        }
        barSeries.Add(new Bar(dateTime, num4, num1, num3, num5, num2 + num2 / 10L * (long) random.Next(10), 86400L));
        dateTime = dateTime.AddDays(1.0);
        if (dateTime.DayOfWeek == DayOfWeek.Saturday)
          dateTime = dateTime.AddDays(2.0);
      }
      return barSeries;
    }

    private void AddProperty(string propertyName, string displayName, Color color)
    {
      ChartColorPropertyViewItem propertyViewItem = new ChartColorPropertyViewItem(propertyName, displayName, color);
      propertyViewItem.ColorChanged += new EventHandler(this.item_ColorChanged);
      this.ltvColorProperties.Items.Add((ListViewItem) propertyViewItem);
      this.defaultTemplate.Settings[propertyName] = color;
      this.propertyViewItems[propertyName] = propertyViewItem;
    }

    private void item_ColorChanged(object sender, EventArgs e)
    {
      ChartColorPropertyViewItem propertyViewItem = sender as ChartColorPropertyViewItem;
      this.SetProperty(propertyViewItem.PropertyName, propertyViewItem.Color);
      if (this.currentTemplate == null || this.updating)
        return;
      this.currentTemplate.Settings[propertyViewItem.PropertyName] = propertyViewItem.Color;
      ((Control) this.chart).Refresh();
    }

    private void SetProperty(string propertyName, Color color)
    {
      ((object) this.chart).GetType().GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty).SetValue((object) this.chart, (object) color, (object[]) null);
    }

    private void ltvColorProperties_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.ltvColorProperties.SelectedItems.Count <= 0)
        return;
      this.colorEditor.Select((this.ltvColorProperties.SelectedItems[0] as ChartColorPropertyViewItem).Color);
    }

    private void colorEditor_SelectedIndexChanged(object sender, EventArgs e)
    {
      (this.ltvColorProperties.SelectedItems[0] as ChartColorPropertyViewItem).Color = (Color) this.colorEditor.SelectedItem;
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
      NewChartColorTemplateDialog colorTemplateDialog = new NewChartColorTemplateDialog();
      if (colorTemplateDialog.ShowDialog() != DialogResult.OK)
        return;
      ChartColorTemplate template = new ChartColorTemplate(colorTemplateDialog.TemplateName);
      foreach (KeyValuePair<string, Color> keyValuePair in Global.ChartManager.ColorTemplates.DefaultTemplate.Settings)
        template.Settings.Add(keyValuePair.Key, keyValuePair.Value);
      Global.ChartManager.ColorTemplates.AddTemplate(colorTemplateDialog.TemplateName, template);
      ChartColorTemplateViewItem templateViewItem = new ChartColorTemplateViewItem(template);
      this.ltvTemplates.Items.Add((ListViewItem) templateViewItem);
      templateViewItem.Selected = true;
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      Global.ChartManager.ColorTemplates.SaveAll();
      Global.ChartManager.Update();
    }

    private void ltvTemplates_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.ltvTemplates.SelectedItems.Count <= 0)
        return;
      this.SelectTemplate(this.defaultTemplate);
      this.SelectTemplate((this.ltvTemplates.SelectedItems[0] as ChartColorTemplateViewItem).Template);
      if (this.ltvColorProperties.SelectedItems.Count > 0)
        this.colorEditor.Select((this.ltvColorProperties.SelectedItems[0] as ChartColorPropertyViewItem).Color);
      ((Control) this.chart).Refresh();
    }

    internal void SelectTemplate(ChartColorTemplate template)
    {
      this.currentTemplate = template;
      this.updating = true;
      foreach (KeyValuePair<string, Color> keyValuePair in template.Settings)
      {
        if (this.propertyViewItems.ContainsKey(keyValuePair.Key))
          this.propertyViewItems[keyValuePair.Key].Color = keyValuePair.Value;
      }
      this.updating = false;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (this.ltvTemplates.SelectedItems.Count <= 0 || MessageBox.Show((IWin32Window) this, "Are you sure that you want to delete selected template?", "Remove Template", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      ChartColorTemplateViewItem templateViewItem = this.ltvTemplates.SelectedItems[0] as ChartColorTemplateViewItem;
      Global.ChartManager.ColorTemplates.RemoveTemplate(templateViewItem.Template);
      templateViewItem.Remove();
      if (this.ltvTemplates.Items.Count <= 0)
        return;
      this.ltvTemplates.Items[0].Selected = true;
    }

    private void btnSetDefault_Click(object sender, EventArgs e)
    {
      if (this.ltvTemplates.SelectedItems.Count <= 0)
        return;
      ChartColorTemplate template = (this.ltvTemplates.SelectedItems[0] as ChartColorTemplateViewItem).Template;
      if (MessageBox.Show((IWin32Window) this, "Are you sure that you want to set " + template.Name + " as default?", "Default Template", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      Global.ChartManager.ColorTemplates.DefaultTemplate = template;
      this.ltvTemplates.BeginUpdate();
      foreach (ChartColorTemplateViewItem templateViewItem in this.ltvTemplates.Items)
        templateViewItem.CheckDefault();
      this.ltvTemplates.EndUpdate();
    }
  }
}
