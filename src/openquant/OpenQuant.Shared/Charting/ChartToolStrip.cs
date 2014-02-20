using FreeQuant.FinChart;
using OpenQuant.Shared.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace OpenQuant.Shared.Charting
{
	[ToolboxBitmap(typeof(ToolStrip))]
	public partial class ChartToolStrip : ToolStrip
	{
		private bool additionalButtonsEnabled = true;
        private OpenQuant.Shared.Charting.Chart chart;
		private FreeQuant.FinChart.ChartUpdateStyle chartUpdateStyle;
		private bool barStyleButtonsEnabled;
		
				private System.Windows.Forms.ToolStripMenuItem selectedItem;
				
		private bool BarStyleButtonsEnabled
		{
			get
			{
				return this.barStyleButtonsEnabled;
			}
			set
			{
				this.barStyleButtonsEnabled = value;
				this.tsbBar.Enabled = this.tsbCandle.Enabled = this.tsbLine.Enabled = value;
			}
		}

		public bool AdditionalButtonsEnabled
		{
			get
			{
				return this.additionalButtonsEnabled;
			}
			set
			{
				this.additionalButtonsEnabled = value;
				this.tsbTimeFrame.Visible = this.additionalButtonsEnabled;
				this.tsbTemplate.Visible = this.additionalButtonsEnabled;
				this.toolStripSeparator5.Visible = this.additionalButtonsEnabled;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Chart Chart
		{
			get
			{
				return this.chart;
			}
			set
			{
				this.Disconnect();
				this.chart = value;
				this.Connect();
				if (this.chart != null)
				{
					this.SetEnabled(true);
					this.AdditionalButtonsEnabled = this.chart.AdditionalButtonsEnabled;
					this.BarStyleButtonsEnabled = this.chart.BarStyleButtonsEnabled;
					this.ChangeActionType();
					this.ChangeBarSeriesStyle();
					this.ChangeUpdateStyle();
					this.ChangeVolumeVisible();
					this.ChangeScaleStyle();
					this.chartUpdateStyle = this.chart.UpdateStyle;
				}
				else
					this.SetEnabled(false);
			}
		}

		public ChartToolStrip()
		{
			this.InitializeComponent();
			this.selectedItem = this.dailyToolStripMenuItem;
			this.dailyToolStripMenuItem.Checked = true;
			this.tsbLinear.Visible = false;
			this.tsbCursor.Visible = false;
			this.tsbTrailing.Visible = false;
			this.SetEnabled(false);
		}

		private void SetEnabled(bool enabled)
		{
			foreach (ToolStripItem toolStripItem in (ArrangedElementCollection) this.Items)
				toolStripItem.Enabled = enabled;
		}

		private void tsbCursor_Click(object sender, EventArgs e)
		{
			this.chart.ActionType = (ChartActionType)1;
		}

		private void tsbCrosshair_Click(object sender, EventArgs e)
		{
			if (this.tsbCrosshair.Checked)
				this.chart.ActionType = (ChartActionType)1;
			else
				this.chart.ActionType = (ChartActionType)0;
		}

		private void tsbZoomIn_Click(object sender, EventArgs e)
		{
			this.chart.ZoomIn();
		}

		private void tsbZoomOut_Click(object sender, EventArgs e)
		{
			this.chart.ZoomOut();
		}

		private void tsbLinear_Click(object sender, EventArgs e)
		{
			this.chart.ScaleStyle = (PadScaleStyle)0;
		}

		private void tsbLog_Click(object sender, EventArgs e)
		{
			if (this.tsbLog.Checked)
				this.chart.ScaleStyle = (PadScaleStyle)0;
			else
				this.chart.ScaleStyle = (PadScaleStyle)1;
		}

		private void tsbTrailing_Click(object sender, EventArgs e)
		{
			this.chart.UpdateStyle = (ChartUpdateStyle)1;
		}

		private void tsbFixed_Click(object sender, EventArgs e)
		{
			if (this.tsbFixed.Checked)
				this.chart.UpdateStyle = this.chartUpdateStyle;
			else
				this.chart.UpdateStyle = (ChartUpdateStyle)2;
		}

		private void tsbCandle_Click(object sender, EventArgs e)
		{
			this.chart.BarSeriesStyle = (BSStyle)0;
		}

		private void tsbBar_Click(object sender, EventArgs e)
		{
			this.chart.BarSeriesStyle = (BSStyle)1;
		}

		private void tsbLine_Click(object sender, EventArgs e)
		{
			this.chart.BarSeriesStyle = (BSStyle)2;
		}

		private void tsbPnF_Click(object sender, EventArgs e)
		{
			this.chart.BarSeriesStyle = (BSStyle)6;
			this.chart.DrawItems = false;
		}

		private void Disconnect()
		{
			if (this.chart == null)
				return;
			this.chart.ActionTypeChanged -= new EventHandler(this.chart_ActionTypeChanged);
			this.chart.UpdateStyleChanged -= new EventHandler(this.chart_UpdateStyleChanged);
			this.chart.VolumeVisibleChanged -= new EventHandler(this.chart_VolumeVisibleChanged);
			this.chart.BarSeriesStyleChanged -= new EventHandler(this.chart_BarSeriesStyleChanged);
			this.chart.ScaleStyleChanged -= new EventHandler(this.chart_ScaleStyleChanged);
		}

		private void Connect()
		{
			if (this.chart == null)
				return;
			this.chart.ActionTypeChanged += new EventHandler(this.chart_ActionTypeChanged);
			this.chart.UpdateStyleChanged += new EventHandler(this.chart_UpdateStyleChanged);
			this.chart.VolumeVisibleChanged += new EventHandler(this.chart_VolumeVisibleChanged);
			this.chart.BarSeriesStyleChanged += new EventHandler(this.chart_BarSeriesStyleChanged);
			this.chart.ScaleStyleChanged += new EventHandler(this.chart_ScaleStyleChanged);
		}

		private void ChangeUpdateStyle()
		{
			if (this.chart.UpdateStyle == ChartUpdateStyle.Fixed)
			{
				this.tsbFixed.Checked = true;
				this.tsbTrailing.Checked = false;
			}
			if (this.chart.UpdateStyle == ChartUpdateStyle.Trailing)
			{
				this.tsbFixed.Checked = false;
				this.tsbTrailing.Checked = true;
			}
			if (this.chart.UpdateStyle != null)
				return;
			this.tsbFixed.Checked = false;
			this.tsbTrailing.Checked = false;
		}

		private void ChangeVolumeVisible()
		{
		}

		private void ChangeBarSeriesStyle()
		{
			if (!this.barStyleButtonsEnabled)
			{
				this.tsbBar.Checked = this.tsbCandle.Checked = this.tsbLine.Checked = false;
			}
			else
			{
				if (this.chart.BarSeriesStyle == BSStyle.Bar)
				{
					this.tsbBar.Checked = true;
					this.tsbCandle.Checked = false;
					this.tsbLine.Checked = false;
				}
				if (this.chart.BarSeriesStyle == null)
				{
					this.tsbBar.Checked = false;
					this.tsbCandle.Checked = true;
					this.tsbLine.Checked = false;
				}
				if (this.chart.BarSeriesStyle == BSStyle.Line)
				{
					this.tsbBar.Checked = false;
					this.tsbCandle.Checked = false;
					this.tsbLine.Checked = true;
				}
				if (this.chart.BarSeriesStyle != BSStyle.PointAndFigure)
					return;
				this.tsbBar.Checked = false;
				this.tsbCandle.Checked = false;
				this.tsbLine.Checked = false;
			}
		}

		private void ChangeActionType()
		{
			if (this.chart.ActionType == null)
			{
				this.tsbCrosshair.Checked = true;
				this.tsbCursor.Checked = false;
			}
			if (this.chart.ActionType != ChartActionType.None)
				return;
			this.tsbCrosshair.Checked = false;
			this.tsbCursor.Checked = true;
		}

		private void ChangeScaleStyle()
		{
			if (this.chart.ScaleStyle == null)
				this.tsbLog.Checked = false;
			if (this.chart.ScaleStyle != PadScaleStyle.Log)
				return;
			this.tsbLog.Checked = true;
		}

		private void chart_UpdateStyleChanged(object sender, EventArgs e)
		{
			this.ChangeUpdateStyle();
		}

		private void chart_VolumeVisibleChanged(object sender, EventArgs e)
		{
			this.ChangeVolumeVisible();
		}

		private void chart_BarSeriesStyleChanged(object sender, EventArgs e)
		{
			this.ChangeBarSeriesStyle();
		}

		private void chart_ActionTypeChanged(object sender, EventArgs e)
		{
			this.ChangeActionType();
		}

		private void chart_ScaleStyleChanged(object sender, EventArgs e)
		{
			this.ChangeScaleStyle();
		}

		private void tsbDay_Click(object sender, EventArgs e)
		{
			this.chart.EmitTimeFrameChanged(ChartTimeFrame.Day);
			this.selectedItem.Checked = false;
			this.dailyToolStripMenuItem.Checked = true;
			this.selectedItem = this.dailyToolStripMenuItem;
			this.tsbTimeFrame.Image = this.dailyToolStripMenuItem.Image;
			this.tsbTimeFrame.ToolTipText = "Daily";
		}

		private void tsbWeek_Click(object sender, EventArgs e)
		{
			this.chart.EmitTimeFrameChanged(ChartTimeFrame.Week);
			this.selectedItem.Checked = false;
			this.weeklyToolStripMenuItem.Checked = true;
			this.selectedItem = this.weeklyToolStripMenuItem;
			this.tsbTimeFrame.Image = this.weeklyToolStripMenuItem.Image;
			this.tsbTimeFrame.ToolTipText = "Weekly";
		}

		private void tsbMonth_Click(object sender, EventArgs e)
		{
			this.chart.EmitTimeFrameChanged(ChartTimeFrame.Month);
			this.selectedItem.Checked = false;
			this.monthlyToolStripMenuItem.Checked = true;
			this.selectedItem = this.monthlyToolStripMenuItem;
			this.tsbTimeFrame.Image = this.monthlyToolStripMenuItem.Image;
			this.tsbTimeFrame.ToolTipText = "Monthly";
		}

		private void tsbYear_Click(object sender, EventArgs e)
		{
			this.chart.EmitTimeFrameChanged(ChartTimeFrame.Year);
			this.selectedItem.Checked = false;
			this.annualToolStripMenuItem.Checked = true;
			this.selectedItem = this.annualToolStripMenuItem;
			this.tsbTimeFrame.Image = this.annualToolStripMenuItem.Image;
			this.tsbTimeFrame.ToolTipText = "Annual";
		}

		private void applyToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
		{
			while (this.applyToolStripMenuItem.DropDownItems.Count > 4)
				this.applyToolStripMenuItem.DropDownItems.RemoveAt(this.applyToolStripMenuItem.DropDownItems.Count - 1);
			foreach (string text in Global.ChartManager.Templates.TemplateNames)
			{
				if (text != "Default Template")
				{
					ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(text, (Image)Resources.chart_template);
					toolStripMenuItem.Tag = (object)text;
					toolStripMenuItem.Click += new EventHandler(this.templateMenuItem_Click);
					this.applyToolStripMenuItem.DropDownItems.Add((ToolStripItem)toolStripMenuItem);
				}
			}
		}

		private void templateMenuItem_Click(object sender, EventArgs e)
		{
			this.chart.EmitTemplateAction(TemplateActionType.Load, (string)(sender as ToolStripMenuItem).Tag);
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.chart.EmitTemplateAction(TemplateActionType.Save);
		}

		private void emptyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.chart.EmitTemplateAction(TemplateActionType.ChooseEmpty);
		}

		private void defaultTemplateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.chart.EmitTemplateAction(TemplateActionType.ChooseDefault);
		}

		private void setAsDefaultTemplateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.chart.EmitTemplateAction(TemplateActionType.SetDefault);
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.chart.EmitTemplateAction(TemplateActionType.SaveAs);
		}
	}
}
