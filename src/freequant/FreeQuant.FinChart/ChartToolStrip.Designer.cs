namespace FreeQuant.FinChart
{
    public partial class ChartToolStrip
	{
		private Chart chart;
		private System.ComponentModel.IContainer container;
		private System.Windows.Forms.ToolStripButton zoomInBtn;
		private System.Windows.Forms.ToolStripButton zoomOutBtn;
		private System.Windows.Forms.ToolStripSeparator gImcdp29gx;
		private System.Windows.Forms.ToolStripButton padScaleStyleArithBtn;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton chartActionTypeCrossBtn;
		private System.Windows.Forms.ToolStripSeparator magc50SFDF;
		private System.Windows.Forms.ToolStripButton padScaleStyleLogBtn;
		private System.Windows.Forms.ToolStripSeparator sSic4dRWKp;
		private System.Windows.Forms.ToolStripButton X4xcf07fkS;
		private System.Windows.Forms.ToolStripButton v67cGZ0JAC;
		private System.Windows.Forms.ToolStripSeparator gJyck4TMTf;
		private System.Windows.Forms.ToolStripButton eTmcMZk3N2;
		private System.Windows.Forms.ToolStripButton ULKcQDLvrP;
		private System.Windows.Forms.ToolStripButton fNtc6GDVDA;
		private System.Windows.Forms.ToolStripButton EVWc9EB5Fv;
		private System.Windows.Forms.ToolStripButton SfwcOA7wk9;

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.container != null)
				this.container.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.gImcdp29gx = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.SfwcOA7wk9 = new System.Windows.Forms.ToolStripButton();
            this.chartActionTypeCrossBtn = new System.Windows.Forms.ToolStripButton();
            this.magc50SFDF = new System.Windows.Forms.ToolStripSeparator();
            this.zoomInBtn = new System.Windows.Forms.ToolStripButton();
            this.zoomOutBtn = new System.Windows.Forms.ToolStripButton();
            this.padScaleStyleArithBtn = new System.Windows.Forms.ToolStripButton();
            this.padScaleStyleLogBtn = new System.Windows.Forms.ToolStripButton();
            this.sSic4dRWKp = new System.Windows.Forms.ToolStripSeparator();
            this.X4xcf07fkS = new System.Windows.Forms.ToolStripButton();
            this.v67cGZ0JAC = new System.Windows.Forms.ToolStripButton();
            this.gJyck4TMTf = new System.Windows.Forms.ToolStripSeparator();
            this.eTmcMZk3N2 = new System.Windows.Forms.ToolStripButton();
            this.ULKcQDLvrP = new System.Windows.Forms.ToolStripButton();
            this.fNtc6GDVDA = new System.Windows.Forms.ToolStripButton();
            this.EVWc9EB5Fv = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gImcdp29gx
            // 
            this.gImcdp29gx.Name = "gImcdp29gx";
            this.gImcdp29gx.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SfwcOA7wk9,
            this.chartActionTypeCrossBtn,
            this.magc50SFDF,
            this.zoomInBtn,
            this.zoomOutBtn,
            this.gImcdp29gx,
            this.padScaleStyleArithBtn,
            this.padScaleStyleLogBtn,
            this.sSic4dRWKp,
            this.X4xcf07fkS,
            this.v67cGZ0JAC,
            this.gJyck4TMTf,
            this.eTmcMZk3N2,
            this.ULKcQDLvrP,
            this.fNtc6GDVDA,
            this.EVWc9EB5Fv});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(302, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "dfddd";
            // 
            // SfwcOA7wk9
            // 
            this.SfwcOA7wk9.Checked = true;
            this.SfwcOA7wk9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SfwcOA7wk9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SfwcOA7wk9.Image = global::FreeQuant.FinChart.Properties.Resources.tsbCursor_Image;
            this.SfwcOA7wk9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SfwcOA7wk9.Name = "SfwcOA7wk9";
            this.SfwcOA7wk9.Size = new System.Drawing.Size(23, 22);
            this.SfwcOA7wk9.ToolTipText = "None";
            this.SfwcOA7wk9.Click += new System.EventHandler(this.SetChartActionTypeToNone);
            // 
            // chartActionTypeCrossBtn
            // 
            this.chartActionTypeCrossBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chartActionTypeCrossBtn.Image = global::FreeQuant.FinChart.Properties.Resources.tsbCrosshair_Image;
            this.chartActionTypeCrossBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chartActionTypeCrossBtn.Name = "chartActionTypeCrossBtn";
            this.chartActionTypeCrossBtn.Size = new System.Drawing.Size(23, 22);
            this.chartActionTypeCrossBtn.Text = "Cross";
            this.chartActionTypeCrossBtn.Click += new System.EventHandler(this.ChangeChartActionTypeToCross);
            // 
            // magc50SFDF
            // 
            this.magc50SFDF.Name = "magc50SFDF";
            this.magc50SFDF.Size = new System.Drawing.Size(6, 25);
            // 
            // zoomInBtn
            // 
            this.zoomInBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInBtn.Image = global::FreeQuant.FinChart.Properties.Resources.tsbZoomIn_Image;
            this.zoomInBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInBtn.Name = "zoomInBtn";
            this.zoomInBtn.Size = new System.Drawing.Size(23, 22);
            this.zoomInBtn.Text = "ZoomIn";
            this.zoomInBtn.Click += new System.EventHandler(this.ZoomIn);
            // 
            // zoomOutBtn
            // 
            this.zoomOutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutBtn.Image = global::FreeQuant.FinChart.Properties.Resources.tsbZoomOut_Image;
            this.zoomOutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutBtn.Name = "zoomOutBtn";
            this.zoomOutBtn.Size = new System.Drawing.Size(23, 22);
            this.zoomOutBtn.Text = "ZoomOut";
            this.zoomOutBtn.Click += new System.EventHandler(this.ZoomOut);
            // 
            // padScaleStyleArithBtn
            // 
            this.padScaleStyleArithBtn.Checked = true;
            this.padScaleStyleArithBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.padScaleStyleArithBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.padScaleStyleArithBtn.Image = global::FreeQuant.FinChart.Properties.Resources.tsbLinear_Image;
            this.padScaleStyleArithBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.padScaleStyleArithBtn.Name = "padScaleStyleArithBtn";
            this.padScaleStyleArithBtn.Size = new System.Drawing.Size(23, 22);
            this.padScaleStyleArithBtn.Text = "Linear";
            this.padScaleStyleArithBtn.Click += new System.EventHandler(this.ChangePadScaleStyleToArith);
            // 
            // padScaleStyleLogBtn
            // 
            this.padScaleStyleLogBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.padScaleStyleLogBtn.Image = global::FreeQuant.FinChart.Properties.Resources.tsbLog_Image;
            this.padScaleStyleLogBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.padScaleStyleLogBtn.Name = "padScaleStyleLogBtn";
            this.padScaleStyleLogBtn.Size = new System.Drawing.Size(23, 22);
            this.padScaleStyleLogBtn.Text = "Log";
            this.padScaleStyleLogBtn.Click += new System.EventHandler(this.ChangePadScaleStyleToLog);
            // 
            // sSic4dRWKp
            // 
            this.sSic4dRWKp.Name = "sSic4dRWKp";
            this.sSic4dRWKp.Size = new System.Drawing.Size(6, 25);
            // 
            // X4xcf07fkS
            // 
            this.X4xcf07fkS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.X4xcf07fkS.Image = global::FreeQuant.FinChart.Properties.Resources.tsbTrailing_Image;
            this.X4xcf07fkS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.X4xcf07fkS.Name = "X4xcf07fkS";
            this.X4xcf07fkS.Size = new System.Drawing.Size(23, 22);
            this.X4xcf07fkS.Text = "Trailing";
            this.X4xcf07fkS.ToolTipText = "Trailing";
            this.X4xcf07fkS.Click += new System.EventHandler(this.SetChartUpdateStyleToTrailing);
            // 
            // v67cGZ0JAC
            // 
            this.v67cGZ0JAC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.v67cGZ0JAC.Image = global::FreeQuant.FinChart.Properties.Resources.tsbFixed_Image;
            this.v67cGZ0JAC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.v67cGZ0JAC.Name = "v67cGZ0JAC";
            this.v67cGZ0JAC.Size = new System.Drawing.Size(23, 22);
            this.v67cGZ0JAC.Text = "Fixed";
            this.v67cGZ0JAC.ToolTipText = "Fixed";
            this.v67cGZ0JAC.Click += new System.EventHandler(this.SetChartUpdateStyleToFixed);
            // 
            // gJyck4TMTf
            // 
            this.gJyck4TMTf.Name = "gJyck4TMTf";
            this.gJyck4TMTf.Size = new System.Drawing.Size(6, 25);
            // 
            // eTmcMZk3N2
            // 
            this.eTmcMZk3N2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eTmcMZk3N2.Image = global::FreeQuant.FinChart.Properties.Resources.tsbBar_Image;
            this.eTmcMZk3N2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eTmcMZk3N2.Name = "eTmcMZk3N2";
            this.eTmcMZk3N2.Size = new System.Drawing.Size(23, 22);
            this.eTmcMZk3N2.Text = "Bar";
            this.eTmcMZk3N2.ToolTipText = "Bar";
            this.eTmcMZk3N2.Click += new System.EventHandler(this.zp7cy9i5y0);
            // 
            // ULKcQDLvrP
            // 
            this.ULKcQDLvrP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ULKcQDLvrP.Image = global::FreeQuant.FinChart.Properties.Resources.tsbCandle_Image;
            this.ULKcQDLvrP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ULKcQDLvrP.Name = "ULKcQDLvrP";
            this.ULKcQDLvrP.Size = new System.Drawing.Size(23, 22);
            this.ULKcQDLvrP.Text = "Candle";
            this.ULKcQDLvrP.ToolTipText = "Candle";
            this.ULKcQDLvrP.Click += new System.EventHandler(this.GCWcSArxSA);
            // 
            // fNtc6GDVDA
            // 
            this.fNtc6GDVDA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fNtc6GDVDA.Image = global::FreeQuant.FinChart.Properties.Resources.tsbLine_Image;
            this.fNtc6GDVDA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fNtc6GDVDA.Name = "fNtc6GDVDA";
            this.fNtc6GDVDA.Size = new System.Drawing.Size(23, 22);
            this.fNtc6GDVDA.Text = "Line";
            this.fNtc6GDVDA.ToolTipText = "Line";
            this.fNtc6GDVDA.Click += new System.EventHandler(this.SetBSStyleToLine);
            // 
            // EVWc9EB5Fv
            // 
            this.EVWc9EB5Fv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EVWc9EB5Fv.Image = global::FreeQuant.FinChart.Properties.Resources.tsbPnF_Image;
            this.EVWc9EB5Fv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EVWc9EB5Fv.Name = "EVWc9EB5Fv";
            this.EVWc9EB5Fv.Size = new System.Drawing.Size(23, 20);
            this.EVWc9EB5Fv.Text = "PointAndFigure";
            this.EVWc9EB5Fv.ToolTipText = "PointAndFigure";
            this.EVWc9EB5Fv.Click += new System.EventHandler(this.SetBSStyleToPointAndFigure);
            // 
            // ChartToolStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip);
            this.Name = "ChartToolStrip";
            this.Size = new System.Drawing.Size(302, 26);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
	}
}
