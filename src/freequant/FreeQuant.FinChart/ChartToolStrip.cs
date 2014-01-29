using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FreeQuant.FinChart
{
	public class ChartToolStrip : UserControl
	{
		private Chart chart;
		private IContainer container;
		private ToolStripButton zoomInBtn;
		private ToolStripButton zoomOutBtn;
		private ToolStripSeparator gImcdp29gx;
		private ToolStripButton padScaleStyleArithBtn;
		private ToolStrip toolStrip;
		private ToolStripButton chartActionTypeCrossBtn;
		private ToolStripSeparator magc50SFDF;
		private ToolStripButton padScaleStyleLogBtn;
		private ToolStripSeparator sSic4dRWKp;
		private ToolStripButton X4xcf07fkS;
		private ToolStripButton v67cGZ0JAC;
		private ToolStripSeparator gJyck4TMTf;
		private ToolStripButton eTmcMZk3N2;
		private ToolStripButton ULKcQDLvrP;
		private ToolStripButton fNtc6GDVDA;
		private ToolStripButton EVWc9EB5Fv;
		private ToolStripButton SfwcOA7wk9;

		public Chart Chart
		{
			get
			{
				return this.chart; 
			}
			set
			{
				this.AqGcKEUcwd();
				this.chart = value;
				this.DaociS2YZP();
				this.PUOcbN0NeH();
				this.wixchCxoOR();
				this.FYpcXcTm5K();
				this.QwTcDTfHxx();
				this.k1nceBNLGc();
			}
		}

		public ChartToolStrip() : base()
		{
			this.Init();
		}

		private void SetChartActionTypeToNone(object sender, EventArgs e)
		{
			this.chart.ActionType = ChartActionType.None;
		}

		private void ChangeChartActionTypeToCross(object sender, EventArgs e)
		{
			this.chart.ActionType = ChartActionType.Cross;
		}

		private void ZoomIn(object sender, EventArgs e)
		{
			this.chart.ZoomIn();
		}

		private void ZoomOut(object sender, [In] EventArgs e)
		{
			this.chart.ZoomOut();
		}

		private void ChangePadScaleStyleToArith(object sender, [In] EventArgs e)
		{
			this.chart.ScaleStyle = PadScaleStyle.Arith;
		}

		private void ChangePadScaleStyleToLog(object sender, EventArgs e)
		{
			this.chart.ScaleStyle = PadScaleStyle.Log;
		}

		private void SetChartUpdateStyleToTrailing(object sender, EventArgs e)
		{
			this.chart.UpdateStyle = ChartUpdateStyle.Trailing;
		}

		private void SetChartUpdateStyleToFixed(object sender, EventArgs e)
		{
			this.chart.UpdateStyle = ChartUpdateStyle.Fixed;
		}

		private void zp7cy9i5y0(object sender, EventArgs e)
		{
			this.chart.BarSeriesStyle = BSStyle.Candle;
		}

		private void GCWcSArxSA(object sender, EventArgs e)
		{
			this.chart.BarSeriesStyle = BSStyle.Bar;
		}

		private void SetBSStyleToLine(object sender, EventArgs e)
		{
			this.chart.BarSeriesStyle = BSStyle.Line;
		}

		private void SetBSStyleToPointAndFigure(object sender, EventArgs e)
		{
			this.chart.BarSeriesStyle = BSStyle.PointAndFigure;
			this.chart.DrawItems = false;
		}

		private void AqGcKEUcwd()
		{
			if (this.chart == null)
				return;
			this.chart.ActionTypeChanged -= new EventHandler(this.OnActionTypeChanged);
			this.chart.UpdateStyleChanged -= new EventHandler(this.K6scn2C04y);
			this.chart.VolumeVisibleChanged -= new EventHandler(this.QFlc7BkMTp);
			this.chart.BarSeriesStyleChanged -= new EventHandler(this.onkcRs6s8G);
			this.chart.ScaleStyleChanged -= new EventHandler(this.TiFcPjuKcW);
		}

		private void DaociS2YZP()
		{
			if (this.chart == null)
				return;
			this.chart.ActionTypeChanged += new EventHandler(this.OnActionTypeChanged);
			this.chart.UpdateStyleChanged += new EventHandler(this.K6scn2C04y);
			this.chart.VolumeVisibleChanged += new EventHandler(this.QFlc7BkMTp);
			this.chart.BarSeriesStyleChanged += new EventHandler(this.onkcRs6s8G);
			this.chart.ScaleStyleChanged += new EventHandler(this.TiFcPjuKcW);
		}

		private void FYpcXcTm5K()
		{
			if (this.chart.UpdateStyle == ChartUpdateStyle.Fixed)
			{
				this.v67cGZ0JAC.Checked = true;
				this.X4xcf07fkS.Checked = false;
			}
			if (this.chart.UpdateStyle == ChartUpdateStyle.Trailing)
			{
				this.v67cGZ0JAC.Checked = false;
				this.X4xcf07fkS.Checked = true;
			}
			if (this.chart.UpdateStyle != ChartUpdateStyle.WholeRange)
				return;
			this.v67cGZ0JAC.Checked = false;
			this.X4xcf07fkS.Checked = false;
		}

		private void QwTcDTfHxx()
		{
		}

		private void wixchCxoOR()
		{
			if (this.chart.BarSeriesStyle == BSStyle.Bar)
			{
				this.ULKcQDLvrP.Checked = true;
				this.eTmcMZk3N2.Checked = false;
				this.fNtc6GDVDA.Checked = false;
				this.EVWc9EB5Fv.Checked = false;
			}
			if (this.chart.BarSeriesStyle == BSStyle.Candle)
			{
				this.ULKcQDLvrP.Checked = false;
				this.eTmcMZk3N2.Checked = true;
				this.fNtc6GDVDA.Checked = false;
				this.EVWc9EB5Fv.Checked = false;
			}
			if (this.chart.BarSeriesStyle == BSStyle.Line)
			{
				this.ULKcQDLvrP.Checked = false;
				this.eTmcMZk3N2.Checked = false;
				this.fNtc6GDVDA.Checked = true;
				this.EVWc9EB5Fv.Checked = false;
			}
			if (this.chart.BarSeriesStyle != BSStyle.PointAndFigure)
				return;
			this.ULKcQDLvrP.Checked = false;
			this.eTmcMZk3N2.Checked = false;
			this.fNtc6GDVDA.Checked = false;
			this.EVWc9EB5Fv.Checked = true;
		}

		private void PUOcbN0NeH()
		{
			if (this.chart.ActionType == ChartActionType.Cross)
			{
				this.chartActionTypeCrossBtn.Checked = true;
				this.SfwcOA7wk9.Checked = false;
			}
			if (this.chart.ActionType != ChartActionType.None)
				return;
			this.chartActionTypeCrossBtn.Checked = false;
			this.SfwcOA7wk9.Checked = true;
		}

		private void k1nceBNLGc()
		{
			if (this.chart.ScaleStyle == PadScaleStyle.Arith)
			{
				this.padScaleStyleArithBtn.Checked = true;
				this.padScaleStyleLogBtn.Checked = false;
			}
			if (this.chart.ScaleStyle != PadScaleStyle.Log)
				return;
			this.padScaleStyleArithBtn.Checked = false;
			this.padScaleStyleLogBtn.Checked = true;
		}

		private void K6scn2C04y(object sender, EventArgs e)
		{
			this.FYpcXcTm5K();
		}

		private void QFlc7BkMTp(object sender, EventArgs e)
		{
			this.QwTcDTfHxx();
		}

		private void onkcRs6s8G(object sender, EventArgs e)
		{
			this.wixchCxoOR();
		}

		private void OnActionTypeChanged(object sender, EventArgs e)
		{
			this.PUOcbN0NeH();
		}

		private void TiFcPjuKcW(object sender, EventArgs e)
		{
			this.k1nceBNLGc();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.container != null)
				this.container.Dispose();
			base.Dispose(disposing);
		}

		private void Init()
		{
			ComponentResourceManager crm = new ComponentResourceManager(typeof(ChartToolStrip));
			this.zoomInBtn = new ToolStripButton();
			this.zoomOutBtn = new ToolStripButton();
			this.gImcdp29gx = new ToolStripSeparator();
			this.padScaleStyleArithBtn = new ToolStripButton();
			this.toolStrip = new ToolStrip();
			this.magc50SFDF = new ToolStripSeparator();
			this.chartActionTypeCrossBtn = new ToolStripButton();
			this.padScaleStyleLogBtn = new ToolStripButton();
			this.ULKcQDLvrP = new ToolStripButton();
			this.eTmcMZk3N2 = new ToolStripButton();
			this.EVWc9EB5Fv = new ToolStripButton();
			this.fNtc6GDVDA = new ToolStripButton();
			this.X4xcf07fkS = new ToolStripButton();
			this.sSic4dRWKp = new ToolStripSeparator();
			this.gJyck4TMTf = new ToolStripSeparator();
			this.v67cGZ0JAC = new ToolStripButton();
			this.SfwcOA7wk9 = new ToolStripButton();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			this.zoomInBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.zoomInBtn.Image = (Image)crm.GetObject("ZoomIn");
			this.zoomInBtn.ImageTransparentColor = Color.Magenta;
			this.zoomInBtn.Name = "ZoomIn";
			this.zoomInBtn.Size = new Size(23, 22);
			this.zoomInBtn.Text = "ZoomIn";
			this.zoomInBtn.Click += new EventHandler(this.ZoomIn);
			this.zoomOutBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.zoomOutBtn.Image = (Image)crm.GetObject("ZoomOut");
			this.zoomOutBtn.ImageTransparentColor = Color.Magenta;
			this.zoomOutBtn.Name = "ZoomOut";
			this.zoomOutBtn.Size = new Size(23, 22);
			this.zoomOutBtn.Text = "ZoomOut";
			this.zoomOutBtn.Click += new EventHandler(this.ZoomOut);
			this.gImcdp29gx.Name = "fddss";
			this.gImcdp29gx.Size = new Size(6, 25);
			this.padScaleStyleArithBtn.Checked = true;
			this.padScaleStyleArithBtn.CheckState = CheckState.Checked;
			this.padScaleStyleArithBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.padScaleStyleArithBtn.Image = (Image)crm.GetObject("Arith");
			this.padScaleStyleArithBtn.ImageTransparentColor = Color.Magenta;
			this.padScaleStyleArithBtn.Name = "Arith";
			this.padScaleStyleArithBtn.Size = new Size(23, 22);
			this.padScaleStyleArithBtn.Text = "Arith";
			this.padScaleStyleArithBtn.Click += new EventHandler(this.ChangePadScaleStyleToArith);
			this.toolStrip.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new ToolStripItem[16]
			{
				(ToolStripItem)this.SfwcOA7wk9,
				(ToolStripItem)this.chartActionTypeCrossBtn,
				(ToolStripItem)this.magc50SFDF,
				(ToolStripItem)this.zoomInBtn,
				(ToolStripItem)this.zoomOutBtn,
				(ToolStripItem)this.gImcdp29gx,
				(ToolStripItem)this.padScaleStyleArithBtn,
				(ToolStripItem)this.padScaleStyleLogBtn,
				(ToolStripItem)this.sSic4dRWKp,
				(ToolStripItem)this.X4xcf07fkS,
				(ToolStripItem)this.v67cGZ0JAC,
				(ToolStripItem)this.gJyck4TMTf,
				(ToolStripItem)this.eTmcMZk3N2,
				(ToolStripItem)this.ULKcQDLvrP,
				(ToolStripItem)this.fNtc6GDVDA,
				(ToolStripItem)this.EVWc9EB5Fv
			});
			this.toolStrip.Location = new Point(0, 0);
			this.toolStrip.Name = "dfddd";
			this.toolStrip.Size = new Size(302, 25);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "dfddd";
			this.magc50SFDF.Name = "rtyrr";
			this.magc50SFDF.Size = new Size(6, 25);
			this.chartActionTypeCrossBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.chartActionTypeCrossBtn.Image = (Image)crm.GetObject("Cross");
			this.chartActionTypeCrossBtn.ImageTransparentColor = Color.Magenta;
			this.chartActionTypeCrossBtn.Name = "Cross";
			this.chartActionTypeCrossBtn.Size = new Size(23, 22);
			this.chartActionTypeCrossBtn.Text = "Cross";
			this.chartActionTypeCrossBtn.Click += new EventHandler(this.ChangeChartActionTypeToCross);
			this.padScaleStyleLogBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.padScaleStyleLogBtn.Image = (Image)crm.GetObject("Log");
			this.padScaleStyleLogBtn.ImageTransparentColor = Color.Magenta;
			this.padScaleStyleLogBtn.Name = "Log";
			this.padScaleStyleLogBtn.Size = new Size(23, 22);
			this.padScaleStyleLogBtn.Text = "Log";
			this.padScaleStyleLogBtn.Click += new EventHandler(this.ChangePadScaleStyleToLog);
			this.ULKcQDLvrP.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.ULKcQDLvrP.Image = (Image)crm.GetObject("ddddfds");
			this.ULKcQDLvrP.ImageTransparentColor = Color.Magenta;
			this.ULKcQDLvrP.Name = "ddddfds";
			this.ULKcQDLvrP.Size = new Size(23, 22);
			this.ULKcQDLvrP.Text = "ddddfds";
			this.ULKcQDLvrP.ToolTipText = "ddddfds";
			this.ULKcQDLvrP.Click += new EventHandler(this.GCWcSArxSA);
			this.eTmcMZk3N2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.eTmcMZk3N2.Image = (Image)crm.GetObject("dfds");
			this.eTmcMZk3N2.ImageTransparentColor = Color.Magenta;
			this.eTmcMZk3N2.Name = "dfds";
			this.eTmcMZk3N2.Size = new Size(23, 22);
			this.eTmcMZk3N2.Text = "dfds";
			this.eTmcMZk3N2.ToolTipText = "dfds";
			this.eTmcMZk3N2.Click += new EventHandler(this.zp7cy9i5y0);
			this.EVWc9EB5Fv.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.EVWc9EB5Fv.Image = (Image)crm.GetObject("PointAndFigure");
			this.EVWc9EB5Fv.ImageTransparentColor = Color.Magenta;
			this.EVWc9EB5Fv.Name = "PointAndFigure";
			this.EVWc9EB5Fv.Size = new Size(23, 22);
			this.EVWc9EB5Fv.Text = "PointAndFigure";
			this.EVWc9EB5Fv.ToolTipText = "PointAndFigure";
			this.EVWc9EB5Fv.Click += new EventHandler(this.SetBSStyleToPointAndFigure);
			this.fNtc6GDVDA.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.fNtc6GDVDA.Image = (Image)crm.GetObject("Line");
			this.fNtc6GDVDA.ImageTransparentColor = Color.Magenta;
			this.fNtc6GDVDA.Name = "Line";
			this.fNtc6GDVDA.Size = new Size(23, 22);
			this.fNtc6GDVDA.Text = "Line";
			this.fNtc6GDVDA.ToolTipText = "Line";
			this.fNtc6GDVDA.Click += new EventHandler(this.SetBSStyleToLine);
			this.X4xcf07fkS.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.X4xcf07fkS.Image = (Image)crm.GetObject("Trailing");
			this.X4xcf07fkS.ImageTransparentColor = Color.Magenta;
			this.X4xcf07fkS.Name = "Trailing";
			this.X4xcf07fkS.Size = new Size(23, 22);
			this.X4xcf07fkS.Text = "Trailing";
			this.X4xcf07fkS.ToolTipText = "Trailing";
			this.X4xcf07fkS.Click += new EventHandler(this.SetChartUpdateStyleToTrailing);
			this.sSic4dRWKp.Name = "";
			this.sSic4dRWKp.Size = new Size(6, 25);
			this.gJyck4TMTf.Name = "";
			this.gJyck4TMTf.Size = new Size(6, 25);
			this.v67cGZ0JAC.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.v67cGZ0JAC.Image = (Image)crm.GetObject("Fixed");
			this.v67cGZ0JAC.ImageTransparentColor = Color.Magenta;
			this.v67cGZ0JAC.Name = "Fixed";
			this.v67cGZ0JAC.Size = new Size(23, 22);
			this.v67cGZ0JAC.Text = "Fixed";
			this.v67cGZ0JAC.ToolTipText = "Fixed";
			this.v67cGZ0JAC.Click += new EventHandler(this.SetChartUpdateStyleToFixed);
			this.SfwcOA7wk9.Checked = true;
			this.SfwcOA7wk9.CheckState = CheckState.Checked;
			this.SfwcOA7wk9.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.SfwcOA7wk9.Image = (Image)crm.GetObject("None");
			this.SfwcOA7wk9.ImageTransparentColor = Color.Magenta;
			this.SfwcOA7wk9.Name = "None";
			this.SfwcOA7wk9.Size = new Size(23, 22);
			this.SfwcOA7wk9.ToolTipText = "None";
			this.SfwcOA7wk9.Click += new EventHandler(this.SetChartActionTypeToNone);
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add((Control)this.toolStrip);
			this.Name = "sdfds";
			this.Size = new Size(302, 26);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
