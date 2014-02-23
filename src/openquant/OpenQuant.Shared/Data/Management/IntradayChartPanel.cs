using OpenQuant.Shared.Properties;
using FreeQuant.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using IDataObject = FreeQuant.Data.IDataObject;
using FreeQuant.Charting;

namespace OpenQuant.Shared.Data.Management
{
  internal class IntradayChartPanel : ChartPanel
  {
        private IContainer components = null;
    private ToolStrip toolStrip;
        protected FreeQuant.Charting.Chart chart;
    private ToolStripTextBox tbxSelectedDate;
    private ToolStripButton btnDate;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripLabel lblObjectCount;
    private DateTime selectedDate;
    private SortedList<DateTime, int> dates;

    public IntradayChartPanel()
    {
      this.InitializeComponent();
			this.chart.Pads[0].MarginBottom = 0;
			this.chart.Pads[0].XGridDashStyle = DashStyle.Dot;
			this.chart.Pads[0].YGridDashStyle = DashStyle.Dot;
			this.chart.Pads[0].XAxisType = (EAxisType) 1;
			this.chart.Pads[0].XAxisTitleEnabled = false;
			this.chart.Pads[0].XAxisLabelEnabled = false;
			this.chart.Pads[0].YAxisTitleEnabled = false;
			this.chart.Pads[0].YAxisLabelEnabled = false;
			this.chart.Pads[0].LegendEnabled = false;
			this.chart.Pads[0].BorderEnabled = false;
			this.chart.Pads[0].TitleEnabled = false;
			this.chart.Pads[0].BackColor = Color.FromKnownColor(KnownColor.Control);
			this.chart.Pads[0].AxisTop.Zoomed =true;
			this.chart.Pads[0].AxisLeft.Zoomed =true;
			this.chart.Pads[0].AxisLeft.GridDashStyle = DashStyle.Dot;
			this.chart.Pads[0].AxisLeft.TitleEnabled = false;
			this.chart.Pads[0].AxisLeft.LabelEnabled = false;
			this.chart.Pads[0].AxisRight.Zoomed = true;
			this.chart.Pads[0].AxisRight.LabelEnabled = true;
			this.chart.Pads[0].AxisRight.LabelFormat = "F2";
			this.chart.Pads[0].AxisBottom.Type = (EAxisType) 1;
			this.chart.Pads[0].AxisBottom.Zoomed = true;
			this.chart.Pads[0].AxisBottom.GridDashStyle = DashStyle.Dot;
			this.chart.Pads[0].AxisBottom.TitleEnabled = true;
			this.chart.Pads[0].AxisBottom.LabelEnabled = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.toolStrip = new ToolStrip();
      this.tbxSelectedDate = new ToolStripTextBox();
      this.btnDate = new ToolStripButton();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.lblObjectCount = new ToolStripLabel();
      this.chart = new Chart();
      this.toolStrip.SuspendLayout();
      this.SuspendLayout();
      this.toolStrip.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.tbxSelectedDate,
        (ToolStripItem) this.btnDate,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.lblObjectCount
      });
      this.toolStrip.Location = new Point(0, 0);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new Size(415, 25);
      this.toolStrip.TabIndex = 0;
      this.toolStrip.Text = "toolStrip1";
      this.tbxSelectedDate.BackColor = SystemColors.Window;
      this.tbxSelectedDate.Name = "tbxSelectedDate";
      this.tbxSelectedDate.ReadOnly = true;
      this.tbxSelectedDate.Size = new Size(100, 25);
      this.tbxSelectedDate.TextBoxTextAlign = HorizontalAlignment.Center;
      this.btnDate.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.btnDate.Image = (Image) Resources.dropdown;
      this.btnDate.ImageTransparentColor = Color.Magenta;
      this.btnDate.Name = "btnDate";
      this.btnDate.Size = new Size(23, 22);
      this.btnDate.ToolTipText = "Select date";
      this.btnDate.Click += new EventHandler(this.btnDate_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(6, 25);
      this.lblObjectCount.Name = "lblObjectCount";
      this.lblObjectCount.Size = new Size(0, 22);
			this.chart.AntiAliasingEnabled = false;
      ((Control) this.chart).Dock = DockStyle.Fill;
			this.chart.DoubleBufferingEnabled = true;
			this.chart.FileName = null;
			this.chart.GroupLeftMarginEnabled = false;
			this.chart.GroupRightMarginEnabled = false;
			this.chart.GroupZoomEnabled = false;
      ((Control) this.chart).Location = new Point(0, 25);
      ((Control) this.chart).Name = "chart";
			this.chart.PadsForeColor = Color.White;
			this.chart.PrintAlign = (EPrintAlign) 3;
			this.chart.PrintHeight=400;
			this.chart.PrintLayout = (EPrintLayout) 0;
			this.chart.PrintWidth = 600;
			this.chart.PrintX = 10;
			this.chart.PrintY = 10;
			this.chart.SessionEnd = TimeSpan.Parse("1.00:00:00");
			this.chart.SessionGridColor = Color.Blue;
			this.chart.SessionGridEnabled = false;
			this.chart.SessionStart = TimeSpan.Parse("00:00:00");
      ((Control) this.chart).Size = new Size(415, 186);
			this.chart.SmoothingEnabled = false;
      ((Control) this.chart).TabIndex = 1;
			this.chart.TransformationType = (ETransformationType) 0;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.Controls.Add((Control) this.chart);
      this.Controls.Add((Control) this.toolStrip);
      this.Name = "IntradayChartPanel";
      this.Size = new Size(415, 211);
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void btnDate_Click(object sender, EventArgs e)
    {
      if (this.dates == null)
      {
        this.dates = new SortedList<DateTime, int>();
        foreach (IDataObject idataObject in (IEnumerable) this.dataSeries)
        {
          DateTime date = idataObject.DateTime.Date;
          if (!this.dates.ContainsKey(date))
            this.dates.Add(date, 0);
          SortedList<DateTime, int> sortedList;
          DateTime index;
          (sortedList = this.dates)[index = date] = sortedList[index] + 1;
        }
      }
      DataSeriesCalendarForm seriesCalendarForm = new DataSeriesCalendarForm();
      seriesCalendarForm.Init((IDictionary<DateTime, int>) this.dates, this.selectedDate);
      if (seriesCalendarForm.ShowDialog((IWin32Window) this) == DialogResult.OK && this.selectedDate != seriesCalendarForm.SelectedDate)
      {
        this.selectedDate = seriesCalendarForm.SelectedDate;
        this.UpdateChart();
      }
      seriesCalendarForm.Dispose();
    }

    protected virtual void OnUpdateChart(ICollection<IDataObject> objects)
    {
    }

    protected override void OnInit()
    {
      if (this.dataSeries.Count > 0)
        this.SetSelectedDate(this.dataSeries.FirstDateTime.Date);
      else
        this.btnDate.Enabled = false;
      this.UpdateChart();
    }

    private void UpdateChart()
    {
      List<IDataObject> list = new List<IDataObject>();
      foreach (IDataObject idataObject in (IEnumerable) this.dataSeries)
      {
        DateTime date = idataObject.DateTime.Date;
        if (!(date < this.selectedDate))
        {
          if (!(date > this.selectedDate))
            list.Add(idataObject);
          else
            break;
        }
      }
      this.tbxSelectedDate.Text = this.selectedDate.ToShortDateString();
      this.lblObjectCount.Text = string.Format("  {0:n0} objects", list.Count);
	this.chart.Pads[0].Primitives.Clear();
      this.chart.cd(1);
      this.OnUpdateChart((ICollection<IDataObject>) list);
      this.chart.UpdatePads();
    }

    private void SetSelectedDate(DateTime date)
    {
      this.selectedDate = date;
      this.Cursor = Cursors.WaitCursor;
      this.UpdateChart();
      this.Cursor = Cursors.Default;
    }
  }
}
