using FreeQuant.FinChart;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Charting
{
	partial class ChartToolStrip
	{

		private IContainer components;
		private ToolStripButton tsbCrosshair;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton tsbZoomIn;
		private ToolStripButton tsbZoomOut;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripButton tsbLinear;
		private ToolStripButton tsbLog;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripButton tsbTrailing;
		private ToolStripButton tsbFixed;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripButton tsbCandle;
		private ToolStripButton tsbBar;
		private ToolStripButton tsbLine;
		private ToolStripSeparator toolStripSeparator5;
		private ToolStripButton tsbCursor;
		private ToolStripButton tsbWeek;
		private ToolStripButton tsbDay;
		private ToolStripButton tsbYear;
		private ToolStripButton tsbMonth;
		private ToolStripDropDownButton tsbTimeFrame;
		private ToolStripMenuItem dailyToolStripMenuItem;
		private ToolStripMenuItem weeklyToolStripMenuItem;
		private ToolStripMenuItem monthlyToolStripMenuItem;
		private ToolStripMenuItem annualToolStripMenuItem;
		private ToolStripDropDownButton tsbTemplate;
		private ToolStripMenuItem applyToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem1;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem emptyToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem2;
		private ToolStripMenuItem defaultTemplateToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem3;
		private ToolStripSeparator toolStripMenuItem4;
		private ToolStripMenuItem setAsDefaultTemplateToolStripMenuItem;
		private Chart chart;
		private ChartUpdateStyle chartUpdateStyle;
		private bool barStyleButtonsEnabled;
		private ToolStripMenuItem selectedItem;

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
				this.components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ChartToolStrip));
			this.tsbCursor = new ToolStripButton();
			this.tsbCrosshair = new ToolStripButton();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.tsbZoomIn = new ToolStripButton();
			this.tsbZoomOut = new ToolStripButton();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.tsbLinear = new ToolStripButton();
			this.tsbLog = new ToolStripButton();
			this.toolStripSeparator3 = new ToolStripSeparator();
			this.tsbTrailing = new ToolStripButton();
			this.tsbFixed = new ToolStripButton();
			this.toolStripSeparator4 = new ToolStripSeparator();
			this.tsbCandle = new ToolStripButton();
			this.tsbBar = new ToolStripButton();
			this.tsbLine = new ToolStripButton();
			this.toolStripSeparator5 = new ToolStripSeparator();
			this.tsbDay = new ToolStripButton();
			this.tsbWeek = new ToolStripButton();
			this.tsbMonth = new ToolStripButton();
			this.tsbYear = new ToolStripButton();
			this.tsbTimeFrame = new ToolStripDropDownButton();
			this.dailyToolStripMenuItem = new ToolStripMenuItem();
			this.weeklyToolStripMenuItem = new ToolStripMenuItem();
			this.monthlyToolStripMenuItem = new ToolStripMenuItem();
			this.annualToolStripMenuItem = new ToolStripMenuItem();
			this.tsbTemplate = new ToolStripDropDownButton();
			this.applyToolStripMenuItem = new ToolStripMenuItem();
			this.emptyToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripMenuItem2 = new ToolStripSeparator();
			this.defaultTemplateToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripMenuItem3 = new ToolStripSeparator();
			this.toolStripMenuItem1 = new ToolStripSeparator();
			this.saveToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripMenuItem4 = new ToolStripSeparator();
			this.setAsDefaultTemplateToolStripMenuItem = new ToolStripMenuItem();
			this.SuspendLayout();
			this.tsbCursor.Checked = true;
			this.tsbCursor.CheckState = CheckState.Checked;
			this.tsbCursor.DisplayStyle = ToolStripItemDisplayStyle.Image;
//			this.tsbCursor.Image = (Image)componentResourceManager.GetObject("tsbCursor.Image");
			this.tsbCursor.ImageTransparentColor = Color.Magenta;
			this.tsbCursor.Name = "tsbCursor";
			this.tsbCursor.Size = new Size(23, 22);
			this.tsbCursor.ToolTipText = "Cursor";
			this.tsbCursor.Click += new EventHandler(this.tsbCursor_Click);
			this.tsbCrosshair.DisplayStyle = ToolStripItemDisplayStyle.Image;
		//	this.tsbCrosshair.Image = (Image)componentResourceManager.GetObject("tsbCrosshair.Image");
			this.tsbCrosshair.ImageTransparentColor = Color.Magenta;
			this.tsbCrosshair.Name = "tsbCrosshair";
			this.tsbCrosshair.Size = new Size(23, 22);
			this.tsbCrosshair.Text = "Crosshair";
			this.tsbCrosshair.Click += new EventHandler(this.tsbCrosshair_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(6, 25);
			this.tsbZoomIn.DisplayStyle = ToolStripItemDisplayStyle.Image;
		//	this.tsbZoomIn.Image = (Image)componentResourceManager.GetObject("tsbZoomIn.Image");
			this.tsbZoomIn.ImageTransparentColor = Color.Magenta;
			this.tsbZoomIn.Name = "tsbZoomIn";
			this.tsbZoomIn.Size = new Size(23, 22);
			this.tsbZoomIn.Text = "Zoom In";
			this.tsbZoomIn.Click += new EventHandler(this.tsbZoomIn_Click);
			this.tsbZoomOut.DisplayStyle = ToolStripItemDisplayStyle.Image;
		//	this.tsbZoomOut.Image = (Image)componentResourceManager.GetObject("tsbZoomOut.Image");
			this.tsbZoomOut.ImageTransparentColor = Color.Magenta;
			this.tsbZoomOut.Name = "tsbZoomOut";
			this.tsbZoomOut.Size = new Size(23, 22);
			this.tsbZoomOut.Text = "Zoom Out";
			this.tsbZoomOut.Click += new EventHandler(this.tsbZoomOut_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(6, 25);
			this.tsbLinear.Checked = true;
			this.tsbLinear.CheckState = CheckState.Checked;
			this.tsbLinear.DisplayStyle = ToolStripItemDisplayStyle.Image;
	//		this.tsbLinear.Image = (Image)componentResourceManager.GetObject("tsbLinear.Image");
			this.tsbLinear.ImageTransparentColor = Color.Magenta;
			this.tsbLinear.Name = "tsbLinear";
			this.tsbLinear.Size = new Size(23, 22);
			this.tsbLinear.Text = "Linear Scale";
			this.tsbLinear.Click += new EventHandler(this.tsbLinear_Click);
			this.tsbLog.DisplayStyle = ToolStripItemDisplayStyle.Image;
	//		this.tsbLog.Image = (Image)componentResourceManager.GetObject("tsbLog.Image");
			this.tsbLog.ImageTransparentColor = Color.Magenta;
			this.tsbLog.Name = "tsbLog";
			this.tsbLog.Size = new Size(23, 22);
			this.tsbLog.Text = "Log Scale";
			this.tsbLog.Click += new EventHandler(this.tsbLog_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new Size(6, 25);
			this.tsbTrailing.DisplayStyle = ToolStripItemDisplayStyle.Image;
	//		this.tsbTrailing.Image = (Image)componentResourceManager.GetObject("tsbTrailing.Image");
			this.tsbTrailing.ImageTransparentColor = Color.Magenta;
			this.tsbTrailing.Name = "tsbTrailing";
			this.tsbTrailing.Size = new Size(23, 22);
			this.tsbTrailing.Text = "toolStripButton1";
			this.tsbTrailing.ToolTipText = "Trailing Mode";
			this.tsbTrailing.Click += new EventHandler(this.tsbTrailing_Click);
			this.tsbFixed.DisplayStyle = ToolStripItemDisplayStyle.Image;
	//		this.tsbFixed.Image = (Image)componentResourceManager.GetObject("tsbFixed.Image");
			this.tsbFixed.ImageTransparentColor = Color.Magenta;
			this.tsbFixed.Name = "tsbFixed";
			this.tsbFixed.Size = new Size(23, 22);
			this.tsbFixed.Text = "toolStripButton2";
			this.tsbFixed.ToolTipText = "Fixed Mode";
			this.tsbFixed.Click += new EventHandler(this.tsbFixed_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new Size(6, 25);
			this.tsbCandle.DisplayStyle = ToolStripItemDisplayStyle.Image;
//			this.tsbCandle.Image = (Image)componentResourceManager.GetObject("tsbCandle.Image");
			this.tsbCandle.ImageTransparentColor = Color.Magenta;
			this.tsbCandle.Name = "tsbCandle";
			this.tsbCandle.Size = new Size(23, 22);
			this.tsbCandle.Text = "toolStripButton1";
			this.tsbCandle.ToolTipText = "Candle";
			this.tsbCandle.Click += new EventHandler(this.tsbCandle_Click);
			this.tsbBar.DisplayStyle = ToolStripItemDisplayStyle.Image;
//			this.tsbBar.Image = (Image)componentResourceManager.GetObject("tsbBar.Image");
			this.tsbBar.ImageTransparentColor = Color.Magenta;
			this.tsbBar.Name = "tsbBar";
			this.tsbBar.Size = new Size(23, 22);
			this.tsbBar.Text = "toolStripButton2";
			this.tsbBar.ToolTipText = "Bar";
			this.tsbBar.Click += new EventHandler(this.tsbBar_Click);
			this.tsbLine.DisplayStyle = ToolStripItemDisplayStyle.Image;
//			this.tsbLine.Image = (Image)componentResourceManager.GetObject("tsbLine.Image");
			this.tsbLine.ImageTransparentColor = Color.Magenta;
			this.tsbLine.Name = "tsbLine";
			this.tsbLine.Size = new Size(23, 22);
			this.tsbLine.Text = "toolStripButton3";
			this.tsbLine.ToolTipText = "Line";
			this.tsbLine.Click += new EventHandler(this.tsbLine_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new Size(6, 25);
			this.tsbDay.DisplayStyle = ToolStripItemDisplayStyle.Image;
//			this.tsbDay.Image = (Image)componentResourceManager.GetObject("tsbDay.Image");
			this.tsbDay.ImageTransparentColor = Color.Magenta;
			this.tsbDay.Name = "tsbDay";
			this.tsbDay.Size = new Size(23, 22);
			this.tsbDay.Text = "Daily";
			this.tsbDay.Visible = false;
			this.tsbDay.Click += new EventHandler(this.tsbDay_Click);
			this.tsbWeek.DisplayStyle = ToolStripItemDisplayStyle.Image;
	//		this.tsbWeek.Image = (Image)componentResourceManager.GetObject("tsbWeek.Image");
			this.tsbWeek.ImageTransparentColor = Color.Magenta;
			this.tsbWeek.Name = "tsbWeek";
			this.tsbWeek.Size = new Size(23, 22);
			this.tsbWeek.Text = "Weekly";
			this.tsbWeek.Visible = false;
			this.tsbWeek.Click += new EventHandler(this.tsbWeek_Click);
			this.tsbMonth.DisplayStyle = ToolStripItemDisplayStyle.Image;
	//		this.tsbMonth.Image = (Image)componentResourceManager.GetObject("tsbMonth.Image");
			this.tsbMonth.ImageTransparentColor = Color.Magenta;
			this.tsbMonth.Name = "tsbMonth";
			this.tsbMonth.Size = new Size(23, 22);
			this.tsbMonth.Text = "Monthly";
			this.tsbMonth.Visible = false;
			this.tsbMonth.Click += new EventHandler(this.tsbMonth_Click);
			this.tsbYear.DisplayStyle = ToolStripItemDisplayStyle.Image;
	//		this.tsbYear.Image = (Image)componentResourceManager.GetObject("tsbYear.Image");
			this.tsbYear.ImageTransparentColor = Color.Magenta;
			this.tsbYear.Name = "tsbYear";
			this.tsbYear.Size = new Size(23, 22);
			this.tsbYear.Text = "Annual";
			this.tsbYear.Visible = false;
			this.tsbYear.Click += new EventHandler(this.tsbYear_Click);
			this.tsbTimeFrame.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbTimeFrame.DropDownItems.AddRange(new ToolStripItem[4]
			{
				(ToolStripItem)this.dailyToolStripMenuItem,
				(ToolStripItem)this.weeklyToolStripMenuItem,
				(ToolStripItem)this.monthlyToolStripMenuItem,
				(ToolStripItem)this.annualToolStripMenuItem
			});
	//		this.tsbTimeFrame.Image = (Image)componentResourceManager.GetObject("tsbTimeFrame.Image");
			this.tsbTimeFrame.ImageTransparentColor = Color.Magenta;
			this.tsbTimeFrame.Name = "tsbTimeFrame";
			this.tsbTimeFrame.Size = new Size(29, 22);
			this.tsbTimeFrame.Text = "Daily";
	//		this.dailyToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("dailyToolStripMenuItem.Image");
			this.dailyToolStripMenuItem.Name = "dailyToolStripMenuItem";
			this.dailyToolStripMenuItem.Size = new Size(119, 22);
			this.dailyToolStripMenuItem.Text = "Daily";
			this.dailyToolStripMenuItem.Click += new EventHandler(this.tsbDay_Click);
	//		this.weeklyToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("weeklyToolStripMenuItem.Image");
			this.weeklyToolStripMenuItem.Name = "weeklyToolStripMenuItem";
			this.weeklyToolStripMenuItem.Size = new Size(119, 22);
			this.weeklyToolStripMenuItem.Text = "Weekly";
			this.weeklyToolStripMenuItem.Click += new EventHandler(this.tsbWeek_Click);
	//		this.monthlyToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("monthlyToolStripMenuItem.Image");
			this.monthlyToolStripMenuItem.Name = "monthlyToolStripMenuItem";
			this.monthlyToolStripMenuItem.Size = new Size(119, 22);
			this.monthlyToolStripMenuItem.Text = "Monthly";
			this.monthlyToolStripMenuItem.Click += new EventHandler(this.tsbMonth_Click);
	//		this.annualToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("annualToolStripMenuItem.Image");
			this.annualToolStripMenuItem.Name = "annualToolStripMenuItem";
			this.annualToolStripMenuItem.Size = new Size(119, 22);
			this.annualToolStripMenuItem.Text = "Annual";
			this.annualToolStripMenuItem.Click += new EventHandler(this.tsbYear_Click);
			this.tsbTemplate.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbTemplate.DropDownItems.AddRange(new ToolStripItem[5]
			{
				(ToolStripItem)this.applyToolStripMenuItem,
				(ToolStripItem)this.toolStripMenuItem1,
				(ToolStripItem)this.saveToolStripMenuItem,
				(ToolStripItem)this.toolStripMenuItem4,
				(ToolStripItem)this.setAsDefaultTemplateToolStripMenuItem
			});
	//		this.tsbTemplate.Image = (Image)Resources.chart_templates;
			this.tsbTemplate.ImageTransparentColor = Color.Magenta;
			this.tsbTemplate.Name = "tsbTemplate";
			this.tsbTemplate.Size = new Size(29, 22);
			this.tsbTemplate.Text = "Templates";
			this.applyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[4]
			{
				(ToolStripItem)this.emptyToolStripMenuItem,
				(ToolStripItem)this.toolStripMenuItem2,
				(ToolStripItem)this.defaultTemplateToolStripMenuItem,
				(ToolStripItem)this.toolStripMenuItem3
			});
			this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
			this.applyToolStripMenuItem.Size = new Size(198, 22);
			this.applyToolStripMenuItem.Text = "Apply";
			this.applyToolStripMenuItem.DropDownOpening += new EventHandler(this.applyToolStripMenuItem_DropDownOpening);
//			this.emptyToolStripMenuItem.Image = (Image)Resources.chart_template_empty;
			this.emptyToolStripMenuItem.Name = "emptyToolStripMenuItem";
			this.emptyToolStripMenuItem.Size = new Size(165, 22);
			this.emptyToolStripMenuItem.Text = "Empty Template";
			this.emptyToolStripMenuItem.Click += new EventHandler(this.emptyToolStripMenuItem_Click);
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new Size(162, 6);
	//		this.defaultTemplateToolStripMenuItem.Image = (Image)Resources.chart_template_default;
			this.defaultTemplateToolStripMenuItem.Name = "defaultTemplateToolStripMenuItem";
			this.defaultTemplateToolStripMenuItem.Size = new Size(165, 22);
			this.defaultTemplateToolStripMenuItem.Text = "Default Template";
			this.defaultTemplateToolStripMenuItem.Click += new EventHandler(this.defaultTemplateToolStripMenuItem_Click);
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new Size(162, 6);
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new Size(195, 6);
		//	this.saveToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("saveToolStripMenuItem.Image");
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new Size(198, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new EventHandler(this.saveToolStripMenuItem_Click);
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new Size(195, 6);
	//		this.setAsDefaultTemplateToolStripMenuItem.Image = (Image)Resources.chart_template_default;
			this.setAsDefaultTemplateToolStripMenuItem.Name = "setAsDefaultTemplateToolStripMenuItem";
			this.setAsDefaultTemplateToolStripMenuItem.Size = new Size(198, 22);
			this.setAsDefaultTemplateToolStripMenuItem.Text = "Set as Default Template";
			this.setAsDefaultTemplateToolStripMenuItem.Click += new EventHandler(this.setAsDefaultTemplateToolStripMenuItem_Click);
			this.Items.AddRange(new ToolStripItem[22]
			{
				(ToolStripItem)this.tsbCursor,
				(ToolStripItem)this.tsbCrosshair,
				(ToolStripItem)this.toolStripSeparator1,
				(ToolStripItem)this.tsbZoomIn,
				(ToolStripItem)this.tsbZoomOut,
				(ToolStripItem)this.toolStripSeparator2,
				(ToolStripItem)this.tsbLinear,
				(ToolStripItem)this.tsbLog,
				(ToolStripItem)this.toolStripSeparator3,
				(ToolStripItem)this.tsbTrailing,
				(ToolStripItem)this.tsbFixed,
				(ToolStripItem)this.toolStripSeparator4,
				(ToolStripItem)this.tsbCandle,
				(ToolStripItem)this.tsbBar,
				(ToolStripItem)this.tsbLine,
				(ToolStripItem)this.toolStripSeparator5,
				(ToolStripItem)this.tsbDay,
				(ToolStripItem)this.tsbWeek,
				(ToolStripItem)this.tsbMonth,
				(ToolStripItem)this.tsbYear,
				(ToolStripItem)this.tsbTimeFrame,
				(ToolStripItem)this.tsbTemplate
			});
			this.Size = new Size(469, 25);
			this.ResumeLayout(false);
		}


	}
}
