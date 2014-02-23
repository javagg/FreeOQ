using System.Drawing;

namespace OpenQuant.Shared.Charting
{
	public partial class ChartToolStrip
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ToolStripButton tsbCrosshair;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbZoomIn;
		private System.Windows.Forms.ToolStripButton tsbZoomOut;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsbLinear;
		private System.Windows.Forms.ToolStripButton tsbLog;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tsbTrailing;
		private System.Windows.Forms.ToolStripButton tsbFixed;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton tsbCandle;
		private System.Windows.Forms.ToolStripButton tsbBar;
		private System.Windows.Forms.ToolStripButton tsbLine;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton tsbCursor;
		private System.Windows.Forms.ToolStripButton tsbWeek;
		private System.Windows.Forms.ToolStripButton tsbDay;
		private System.Windows.Forms.ToolStripButton tsbYear;
		private System.Windows.Forms.ToolStripButton tsbMonth;
		private System.Windows.Forms.ToolStripDropDownButton tsbTimeFrame;
		private System.Windows.Forms.ToolStripMenuItem dailyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annualToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsbTemplate;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem defaultTemplateToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem setAsDefaultTemplateToolStripMenuItem;


		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
				this.components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
		    this.components = new System.ComponentModel.Container();
System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(ChartToolStrip));
			this.tsbCursor = new System.Windows.Forms.ToolStripButton();
			this.tsbCrosshair = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbZoomIn = new System.Windows.Forms.ToolStripButton();
			this.tsbZoomOut = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbLinear = new System.Windows.Forms.ToolStripButton();
			this.tsbLog = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbTrailing = new System.Windows.Forms.ToolStripButton();
			this.tsbFixed = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbCandle = new System.Windows.Forms.ToolStripButton();
			this.tsbBar = new System.Windows.Forms.ToolStripButton();
			this.tsbLine = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbDay = new System.Windows.Forms.ToolStripButton();
			this.tsbWeek = new System.Windows.Forms.ToolStripButton();
			this.tsbMonth = new System.Windows.Forms.ToolStripButton();
			this.tsbYear = new System.Windows.Forms.ToolStripButton();
			this.tsbTimeFrame = new System.Windows.Forms.ToolStripDropDownButton();
			this.dailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.weeklyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.monthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.annualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsbTemplate = new System.Windows.Forms.ToolStripDropDownButton();
			this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.emptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.defaultTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.setAsDefaultTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SuspendLayout();
			this.tsbCursor.Checked = true;
			this.tsbCursor.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tsbCursor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//			this.tsbCursor.Image = (Image)componentResourceManager.GetObject("tsbCursor.Image");
			this.tsbCursor.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCursor.Name = "tsbCursor";
			this.tsbCursor.Size = new System.Drawing.Size(23, 22);
			this.tsbCursor.ToolTipText = "Cursor";
			this.tsbCursor.Click += new System.EventHandler(this.tsbCursor_Click);
			this.tsbCrosshair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//			this.tsbCrosshair.Image = (Image)componentResourceManager.GetObject("tsbCrosshair.Image");
			this.tsbCrosshair.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCrosshair.Name = "tsbCrosshair";
			this.tsbCrosshair.Size = new System.Drawing.Size(23, 22);
			this.tsbCrosshair.Text = "Crosshair";
			this.tsbCrosshair.Click += new System.EventHandler(this.tsbCrosshair_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			this.tsbZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//			this.tsbZoomIn.Image = (Image)componentResourceManager.GetObject("tsbZoomIn.Image");
			this.tsbZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbZoomIn.Name = "tsbZoomIn";
			this.tsbZoomIn.Size = new System.Drawing.Size(23, 22);
			this.tsbZoomIn.Text = "Zoom In";
			this.tsbZoomIn.Click += new System.EventHandler(this.tsbZoomIn_Click);
			this.tsbZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		//	this.tsbZoomOut.Image = (Image)componentResourceManager.GetObject("tsbZoomOut.Image");
			this.tsbZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbZoomOut.Name = "tsbZoomOut";
			this.tsbZoomOut.Size = new System.Drawing.Size(23, 22);
			this.tsbZoomOut.Text = "Zoom Out";
			this.tsbZoomOut.Click += new System.EventHandler(this.tsbZoomOut_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			this.tsbLinear.Checked = true;
			this.tsbLinear.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tsbLinear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	//		this.tsbLinear.Image = (Image)componentResourceManager.GetObject("tsbLinear.Image");
			this.tsbLinear.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbLinear.Name = "tsbLinear";
			this.tsbLinear.Size = new System.Drawing.Size(23, 22);
			this.tsbLinear.Text = "Linear Scale";
			this.tsbLinear.Click += new System.EventHandler(this.tsbLinear_Click);
			this.tsbLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	//		this.tsbLog.Image = (Image)componentResourceManager.GetObject("tsbLog.Image");
			this.tsbLog.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbLog.Name = "tsbLog";
			this.tsbLog.Size = new System.Drawing.Size(23, 22);
			this.tsbLog.Text = "Log Scale";
			this.tsbLog.Click += new System.EventHandler(this.tsbLog_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			this.tsbTrailing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	//		this.tsbTrailing.Image = (Image)componentResourceManager.GetObject("tsbTrailing.Image");
			this.tsbTrailing.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbTrailing.Name = "tsbTrailing";
			this.tsbTrailing.Size = new System.Drawing.Size(23, 22);
			this.tsbTrailing.Text = "toolStripButton1";
			this.tsbTrailing.ToolTipText = "Trailing Mode";
			this.tsbTrailing.Click += new System.EventHandler(this.tsbTrailing_Click);
			this.tsbFixed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	//		this.tsbFixed.Image = (Image)componentResourceManager.GetObject("tsbFixed.Image");
			this.tsbFixed.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbFixed.Name = "tsbFixed";
			this.tsbFixed.Size = new System.Drawing.Size(23, 22);
			this.tsbFixed.Text = "toolStripButton2";
			this.tsbFixed.ToolTipText = "Fixed Mode";
			this.tsbFixed.Click += new System.EventHandler(this.tsbFixed_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			this.tsbCandle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	//		this.tsbCandle.Image = (Image)componentResourceManager.GetObject("tsbCandle.Image");
			this.tsbCandle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCandle.Name = "tsbCandle";
			this.tsbCandle.Size = new System.Drawing.Size(23, 22);
			this.tsbCandle.Text = "toolStripButton1";
			this.tsbCandle.ToolTipText = "Candle";
			this.tsbCandle.Click += new System.EventHandler(this.tsbCandle_Click);
			this.tsbBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	//	this.tsbBar.Image = (Image)componentResourceManager.GetObject("tsbBar.Image");
			this.tsbBar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbBar.Name = "tsbBar";
			this.tsbBar.Size = new System.Drawing.Size(23, 22);
			this.tsbBar.Text = "toolStripButton2";
			this.tsbBar.ToolTipText = "Bar";
			this.tsbBar.Click += new System.EventHandler(this.tsbBar_Click);
			this.tsbLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//			this.tsbLine.Image = (Image)componentResourceManager.GetObject("tsbLine.Image");
			this.tsbLine.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbLine.Name = "tsbLine";
			this.tsbLine.Size = new System.Drawing.Size(23, 22);
			this.tsbLine.Text = "toolStripButton3";
			this.tsbLine.ToolTipText = "Line";
			this.tsbLine.Click += new System.EventHandler(this.tsbLine_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			this.tsbDay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	//		this.tsbDay.Image = (Image)componentResourceManager.GetObject("tsbDay.Image");
			this.tsbDay.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbDay.Name = "tsbDay";
			this.tsbDay.Size = new System.Drawing.Size(23, 22);
			this.tsbDay.Text = "Daily";
			this.tsbDay.Visible = false;
			this.tsbDay.Click += new System.EventHandler(this.tsbDay_Click);
			this.tsbWeek.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		//	this.tsbWeek.Image = (Image)componentResourceManager.GetObject("tsbWeek.Image");
			this.tsbWeek.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbWeek.Name = "tsbWeek";
			this.tsbWeek.Size = new System.Drawing.Size(23, 22);
			this.tsbWeek.Text = "Weekly";
			this.tsbWeek.Visible = false;
			this.tsbWeek.Click += new System.EventHandler(this.tsbWeek_Click);
			this.tsbMonth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		//	this.tsbMonth.Image = (Image)componentResourceManager.GetObject("tsbMonth.Image");
			this.tsbMonth.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbMonth.Name = "tsbMonth";
			this.tsbMonth.Size = new System.Drawing.Size(23, 22);
			this.tsbMonth.Text = "Monthly";
			this.tsbMonth.Visible = false;
			this.tsbMonth.Click += new System.EventHandler(this.tsbMonth_Click);
			this.tsbYear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	//		this.tsbYear.Image = (Image)componentResourceManager.GetObject("tsbYear.Image");
			this.tsbYear.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbYear.Name = "tsbYear";
			this.tsbYear.Size = new System.Drawing.Size(23, 22);
			this.tsbYear.Text = "Annual";
			this.tsbYear.Visible = false;
			this.tsbYear.Click += new System.EventHandler(this.tsbYear_Click);
			this.tsbTimeFrame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbTimeFrame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.dailyToolStripMenuItem,
				this.weeklyToolStripMenuItem,
				this.monthlyToolStripMenuItem,
				this.annualToolStripMenuItem
			});
	//		this.tsbTimeFrame.Image = (Image)componentResourceManager.GetObject("tsbTimeFrame.Image");
			this.tsbTimeFrame.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbTimeFrame.Name = "tsbTimeFrame";
			this.tsbTimeFrame.Size = new System.Drawing.Size(29, 22);
			this.tsbTimeFrame.Text = "Daily";
	//		this.dailyToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("dailyToolStripMenuItem.Image");
			this.dailyToolStripMenuItem.Name = "dailyToolStripMenuItem";
			this.dailyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.dailyToolStripMenuItem.Text = "Daily";
			this.dailyToolStripMenuItem.Click += new System.EventHandler(this.tsbDay_Click);
	//		this.weeklyToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("weeklyToolStripMenuItem.Image");
			this.weeklyToolStripMenuItem.Name = "weeklyToolStripMenuItem";
			this.weeklyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.weeklyToolStripMenuItem.Text = "Weekly";
			this.weeklyToolStripMenuItem.Click += new System.EventHandler(this.tsbWeek_Click);
	//		this.monthlyToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("monthlyToolStripMenuItem.Image");
			this.monthlyToolStripMenuItem.Name = "monthlyToolStripMenuItem";
			this.monthlyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.monthlyToolStripMenuItem.Text = "Monthly";
			this.monthlyToolStripMenuItem.Click += new System.EventHandler(this.tsbMonth_Click);
	//		this.annualToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("annualToolStripMenuItem.Image");
			this.annualToolStripMenuItem.Name = "annualToolStripMenuItem";
			this.annualToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.annualToolStripMenuItem.Text = "Annual";
			this.annualToolStripMenuItem.Click += new System.EventHandler(this.tsbYear_Click);
			this.tsbTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbTemplate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.applyToolStripMenuItem,
				this.toolStripMenuItem1,
				this.saveToolStripMenuItem,
				this.toolStripMenuItem4,
				this.setAsDefaultTemplateToolStripMenuItem
			});
			this.tsbTemplate.Image = Properties.Resources.chart_templates;
			this.tsbTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbTemplate.Name = "tsbTemplate";
			this.tsbTemplate.Size = new System.Drawing.Size(29, 22);
			this.tsbTemplate.Text = "Templates";
			this.applyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.emptyToolStripMenuItem,
				this.toolStripMenuItem2,
				this.defaultTemplateToolStripMenuItem,
				this.toolStripMenuItem3
			});
			this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
			this.applyToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.applyToolStripMenuItem.Text = "Apply";
			this.applyToolStripMenuItem.DropDownOpening += new System.EventHandler(this.applyToolStripMenuItem_DropDownOpening);
			this.emptyToolStripMenuItem.Image = Properties.Resources.chart_template_empty;
			this.emptyToolStripMenuItem.Name = "emptyToolStripMenuItem";
			this.emptyToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.emptyToolStripMenuItem.Text = "Empty Template";
			this.emptyToolStripMenuItem.Click += new System.EventHandler(this.emptyToolStripMenuItem_Click);
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 6);
			this.defaultTemplateToolStripMenuItem.Image = Properties.Resources.chart_template_default;
			this.defaultTemplateToolStripMenuItem.Name = "defaultTemplateToolStripMenuItem";
			this.defaultTemplateToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.defaultTemplateToolStripMenuItem.Text = "Default Template";
			this.defaultTemplateToolStripMenuItem.Click += new System.EventHandler(this.defaultTemplateToolStripMenuItem_Click);
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(162, 6);
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 6);
//			this.saveToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("saveToolStripMenuItem.Image");
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(195, 6);
			this.setAsDefaultTemplateToolStripMenuItem.Image = Properties.Resources.chart_template_default;
			this.setAsDefaultTemplateToolStripMenuItem.Name = "setAsDefaultTemplateToolStripMenuItem";
			this.setAsDefaultTemplateToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.setAsDefaultTemplateToolStripMenuItem.Text = "Set as Default Template";
			this.setAsDefaultTemplateToolStripMenuItem.Click += new System.EventHandler(this.setAsDefaultTemplateToolStripMenuItem_Click);
			this.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.tsbCursor,
				this.tsbCrosshair,
				this.toolStripSeparator1,
				this.tsbZoomIn,
				this.tsbZoomOut,
				this.toolStripSeparator2,
				this.tsbLinear,
				this.tsbLog,
				this.toolStripSeparator3,
				this.tsbTrailing,
				this.tsbFixed,
				this.toolStripSeparator4,
				this.tsbCandle,
				this.tsbBar,
				this.tsbLine,
				this.toolStripSeparator5,
				this.tsbDay,
				this.tsbWeek,
				this.tsbMonth,
				this.tsbYear,
				this.tsbTimeFrame,
				this.tsbTemplate
			});
			this.Size = new System.Drawing.Size(469, 25);
			this.ResumeLayout(false);
		}


	}
}
