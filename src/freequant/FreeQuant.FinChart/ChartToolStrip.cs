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
    private IContainer mLvcUAxdtm;
    private ToolStripButton BajclxbZrs;
    private ToolStripButton XA4cvACCns;
    private ToolStripSeparator gImcdp29gx;
    private ToolStripButton wSqcuFpCG0;
    private ToolStrip pNPcxOTJVx;
    private ToolStripButton RVncAmH7ZD;
    private ToolStripSeparator magc50SFDF;
    private ToolStripButton gjKcZ28hMU;
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

    
	public ChartToolStrip() :base()
    {
      this.mU9cTyJqiF();
    }

    
    private void Ib1wW2Sljv([In] object obj0, [In] EventArgs obj1)
    {
      this.chart.ActionType = ChartActionType.None;
    }

    
    private void yB0wF4OxjP([In] object obj0, [In] EventArgs obj1)
    {
      this.chart.ActionType = ChartActionType.Cross;
    }

    
    private void lrCwI8sugV([In] object obj0, [In] EventArgs obj1)
    {
      this.chart.ZoomIn();
    }

    
    private void si0wzAnoUg([In] object obj0, [In] EventArgs obj1)
    {
      this.chart.ZoomOut();
    }

    
    private void RiUct5bNDO([In] object obj0, [In] EventArgs obj1)
    {
      this.chart.ScaleStyle = PadScaleStyle.Arith;
    }

    
    private void nLBcwE0kD9([In] object obj0, [In] EventArgs obj1)
    {
      this.chart.ScaleStyle = PadScaleStyle.Log;
    }

    
    private void J6pccasRQb([In] object obj0, [In] EventArgs obj1)
    {
      this.chart.UpdateStyle = ChartUpdateStyle.Trailing;
    }

    
    private void GnhcJDCpbI([In] object obj0, [In] EventArgs obj1)
    {
      this.chart.UpdateStyle = ChartUpdateStyle.Fixed;
    }

    
    private void zp7cy9i5y0([In] object obj0, [In] EventArgs obj1)
    {
      this.chart.BarSeriesStyle = BSStyle.Candle;
    }

    
    private void GCWcSArxSA([In] object obj0, [In] EventArgs obj1)
    {
      this.chart.BarSeriesStyle = BSStyle.Bar;
    }

    
    private void HSLc0kgK4E([In] object obj0, [In] EventArgs obj1)
    {
      this.chart.BarSeriesStyle = BSStyle.Line;
    }

    
    private void v4ncrpO7y9([In] object obj0, [In] EventArgs obj1)
    {
      this.chart.BarSeriesStyle = BSStyle.PointAndFigure;
      this.chart.DrawItems = false;
    }

    
    private void AqGcKEUcwd()
    {
      if (this.chart == null)
        return;
      this.chart.ActionTypeChanged -= new EventHandler(this.QaicEQAa3l);
      this.chart.UpdateStyleChanged -= new EventHandler(this.K6scn2C04y);
      this.chart.VolumeVisibleChanged -= new EventHandler(this.QFlc7BkMTp);
      this.chart.BarSeriesStyleChanged -= new EventHandler(this.onkcRs6s8G);
      this.chart.ScaleStyleChanged -= new EventHandler(this.TiFcPjuKcW);
    }

    
    private void DaociS2YZP()
    {
      if (this.chart == null)
        return;
      this.chart.ActionTypeChanged += new EventHandler(this.QaicEQAa3l);
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
        this.RVncAmH7ZD.Checked = true;
        this.SfwcOA7wk9.Checked = false;
      }
      if (this.chart.ActionType != ChartActionType.None)
        return;
      this.RVncAmH7ZD.Checked = false;
      this.SfwcOA7wk9.Checked = true;
    }

    
    private void k1nceBNLGc()
    {
      if (this.chart.ScaleStyle == PadScaleStyle.Arith)
      {
        this.wSqcuFpCG0.Checked = true;
        this.gjKcZ28hMU.Checked = false;
      }
      if (this.chart.ScaleStyle != PadScaleStyle.Log)
        return;
      this.wSqcuFpCG0.Checked = false;
      this.gjKcZ28hMU.Checked = true;
    }

    
    private void K6scn2C04y([In] object obj0, [In] EventArgs obj1)
    {
      this.FYpcXcTm5K();
    }

    
    private void QFlc7BkMTp([In] object obj0, [In] EventArgs obj1)
    {
      this.QwTcDTfHxx();
    }

    
    private void onkcRs6s8G([In] object obj0, [In] EventArgs obj1)
    {
      this.wixchCxoOR();
    }

    
    private void QaicEQAa3l([In] object obj0, [In] EventArgs obj1)
    {
      this.PUOcbN0NeH();
    }

    
    private void TiFcPjuKcW([In] object obj0, [In] EventArgs obj1)
    {
      this.k1nceBNLGc();
    }

    
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.mLvcUAxdtm != null)
        this.mLvcUAxdtm.Dispose();
      base.Dispose(disposing);
    }

    
    private void mU9cTyJqiF()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ChartToolStrip));
      this.BajclxbZrs = new ToolStripButton();
      this.XA4cvACCns = new ToolStripButton();
      this.gImcdp29gx = new ToolStripSeparator();
      this.wSqcuFpCG0 = new ToolStripButton();
      this.pNPcxOTJVx = new ToolStrip();
      this.magc50SFDF = new ToolStripSeparator();
      this.RVncAmH7ZD = new ToolStripButton();
      this.gjKcZ28hMU = new ToolStripButton();
      this.ULKcQDLvrP = new ToolStripButton();
      this.eTmcMZk3N2 = new ToolStripButton();
      this.EVWc9EB5Fv = new ToolStripButton();
      this.fNtc6GDVDA = new ToolStripButton();
      this.X4xcf07fkS = new ToolStripButton();
      this.sSic4dRWKp = new ToolStripSeparator();
      this.gJyck4TMTf = new ToolStripSeparator();
      this.v67cGZ0JAC = new ToolStripButton();
      this.SfwcOA7wk9 = new ToolStripButton();
      this.pNPcxOTJVx.SuspendLayout();
      this.SuspendLayout();
      this.BajclxbZrs.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.BajclxbZrs.Image = (Image) componentResourceManager.GetObject(FJDHryrxb1WIq5jBAt.mT707pbkgT(778));
      this.BajclxbZrs.ImageTransparentColor = Color.Magenta;
      this.BajclxbZrs.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(812);
      this.BajclxbZrs.Size = new Size(23, 22);
      this.BajclxbZrs.Text = FJDHryrxb1WIq5jBAt.mT707pbkgT(834);
      this.BajclxbZrs.Click += new EventHandler(this.lrCwI8sugV);
      this.XA4cvACCns.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.XA4cvACCns.Image = (Image) componentResourceManager.GetObject(FJDHryrxb1WIq5jBAt.mT707pbkgT(852));
      this.XA4cvACCns.ImageTransparentColor = Color.Magenta;
      this.XA4cvACCns.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(888);
      this.XA4cvACCns.Size = new Size(23, 22);
      this.XA4cvACCns.Text = FJDHryrxb1WIq5jBAt.mT707pbkgT(912);
      this.XA4cvACCns.Click += new EventHandler(this.si0wzAnoUg);
      this.gImcdp29gx.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(932);
      this.gImcdp29gx.Size = new Size(6, 25);
      this.wSqcuFpCG0.Checked = true;
      this.wSqcuFpCG0.CheckState = CheckState.Checked;
      this.wSqcuFpCG0.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.wSqcuFpCG0.Image = (Image) componentResourceManager.GetObject(FJDHryrxb1WIq5jBAt.mT707pbkgT(974));
      this.wSqcuFpCG0.ImageTransparentColor = Color.Magenta;
      this.wSqcuFpCG0.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(1008);
      this.wSqcuFpCG0.Size = new Size(23, 22);
      this.wSqcuFpCG0.Text = FJDHryrxb1WIq5jBAt.mT707pbkgT(1030);
      this.wSqcuFpCG0.Click += new EventHandler(this.RiUct5bNDO);
      this.pNPcxOTJVx.GripStyle = ToolStripGripStyle.Hidden;
      this.pNPcxOTJVx.Items.AddRange(new ToolStripItem[16]
      {
        (ToolStripItem) this.SfwcOA7wk9,
        (ToolStripItem) this.RVncAmH7ZD,
        (ToolStripItem) this.magc50SFDF,
        (ToolStripItem) this.BajclxbZrs,
        (ToolStripItem) this.XA4cvACCns,
        (ToolStripItem) this.gImcdp29gx,
        (ToolStripItem) this.wSqcuFpCG0,
        (ToolStripItem) this.gjKcZ28hMU,
        (ToolStripItem) this.sSic4dRWKp,
        (ToolStripItem) this.X4xcf07fkS,
        (ToolStripItem) this.v67cGZ0JAC,
        (ToolStripItem) this.gJyck4TMTf,
        (ToolStripItem) this.eTmcMZk3N2,
        (ToolStripItem) this.ULKcQDLvrP,
        (ToolStripItem) this.fNtc6GDVDA,
        (ToolStripItem) this.EVWc9EB5Fv
      });
      this.pNPcxOTJVx.Location = new Point(0, 0);
      this.pNPcxOTJVx.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(1058);
      this.pNPcxOTJVx.Size = new Size(302, 25);
      this.pNPcxOTJVx.TabIndex = 0;
      this.pNPcxOTJVx.Text = FJDHryrxb1WIq5jBAt.mT707pbkgT(1080);
      this.magc50SFDF.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(1104);
      this.magc50SFDF.Size = new Size(6, 25);
      this.RVncAmH7ZD.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.RVncAmH7ZD.Image = (Image) componentResourceManager.GetObject(FJDHryrxb1WIq5jBAt.mT707pbkgT(1146));
      this.RVncAmH7ZD.ImageTransparentColor = Color.Magenta;
      this.RVncAmH7ZD.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(1186);
      this.RVncAmH7ZD.Size = new Size(23, 22);
      this.RVncAmH7ZD.Text = FJDHryrxb1WIq5jBAt.mT707pbkgT(1214);
      this.RVncAmH7ZD.Click += new EventHandler(this.yB0wF4OxjP);
      this.gjKcZ28hMU.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.gjKcZ28hMU.Image = (Image) componentResourceManager.GetObject(FJDHryrxb1WIq5jBAt.mT707pbkgT(1236));
      this.gjKcZ28hMU.ImageTransparentColor = Color.Magenta;
      this.gjKcZ28hMU.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(1264);
      this.gjKcZ28hMU.Size = new Size(23, 22);
      this.gjKcZ28hMU.Text = FJDHryrxb1WIq5jBAt.mT707pbkgT(1280);
      this.gjKcZ28hMU.Click += new EventHandler(this.nLBcwE0kD9);
      this.ULKcQDLvrP.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ULKcQDLvrP.Image = (Image) componentResourceManager.GetObject(FJDHryrxb1WIq5jBAt.mT707pbkgT(1302));
      this.ULKcQDLvrP.ImageTransparentColor = Color.Magenta;
      this.ULKcQDLvrP.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(1330);
      this.ULKcQDLvrP.Size = new Size(23, 22);
      this.ULKcQDLvrP.Text = FJDHryrxb1WIq5jBAt.mT707pbkgT(1346);
      this.ULKcQDLvrP.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(1382);
      this.ULKcQDLvrP.Click += new EventHandler(this.GCWcSArxSA);
      this.eTmcMZk3N2.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.eTmcMZk3N2.Image = (Image) componentResourceManager.GetObject(FJDHryrxb1WIq5jBAt.mT707pbkgT(1392));
      this.eTmcMZk3N2.ImageTransparentColor = Color.Magenta;
      this.eTmcMZk3N2.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(1426);
      this.eTmcMZk3N2.Size = new Size(23, 22);
      this.eTmcMZk3N2.Text = FJDHryrxb1WIq5jBAt.mT707pbkgT(1448);
      this.eTmcMZk3N2.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(1484);
      this.eTmcMZk3N2.Click += new EventHandler(this.zp7cy9i5y0);
      this.EVWc9EB5Fv.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.EVWc9EB5Fv.Image = (Image) componentResourceManager.GetObject(FJDHryrxb1WIq5jBAt.mT707pbkgT(1500));
      this.EVWc9EB5Fv.ImageTransparentColor = Color.Magenta;
      this.EVWc9EB5Fv.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(1528);
      this.EVWc9EB5Fv.Size = new Size(23, 22);
      this.EVWc9EB5Fv.Text = FJDHryrxb1WIq5jBAt.mT707pbkgT(1544);
      this.EVWc9EB5Fv.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(1580);
      this.EVWc9EB5Fv.Click += new EventHandler(this.v4ncrpO7y9);
      this.fNtc6GDVDA.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.fNtc6GDVDA.Image = (Image) componentResourceManager.GetObject(FJDHryrxb1WIq5jBAt.mT707pbkgT(1612));
      this.fNtc6GDVDA.ImageTransparentColor = Color.Magenta;
      this.fNtc6GDVDA.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(1642);
      this.fNtc6GDVDA.Size = new Size(23, 22);
      this.fNtc6GDVDA.Text = FJDHryrxb1WIq5jBAt.mT707pbkgT(1660);
      this.fNtc6GDVDA.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(1696);
      this.fNtc6GDVDA.Click += new EventHandler(this.HSLc0kgK4E);
      this.X4xcf07fkS.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.X4xcf07fkS.Image = (Image) componentResourceManager.GetObject(FJDHryrxb1WIq5jBAt.mT707pbkgT(1708));
      this.X4xcf07fkS.ImageTransparentColor = Color.Magenta;
      this.X4xcf07fkS.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(1746);
      this.X4xcf07fkS.Size = new Size(23, 22);
      this.X4xcf07fkS.Text = FJDHryrxb1WIq5jBAt.mT707pbkgT(1772);
      this.X4xcf07fkS.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(1808);
      this.X4xcf07fkS.Click += new EventHandler(this.J6pccasRQb);
      this.sSic4dRWKp.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(1838);
      this.sSic4dRWKp.Size = new Size(6, 25);
      this.gJyck4TMTf.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(1880);
      this.gJyck4TMTf.Size = new Size(6, 25);
      this.v67cGZ0JAC.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.v67cGZ0JAC.Image = (Image) componentResourceManager.GetObject(FJDHryrxb1WIq5jBAt.mT707pbkgT(1922));
      this.v67cGZ0JAC.ImageTransparentColor = Color.Magenta;
      this.v67cGZ0JAC.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(1954);
      this.v67cGZ0JAC.Size = new Size(23, 22);
      this.v67cGZ0JAC.Text = FJDHryrxb1WIq5jBAt.mT707pbkgT(1974);
      this.v67cGZ0JAC.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(2010);
      this.v67cGZ0JAC.Click += new EventHandler(this.GnhcJDCpbI);
      this.SfwcOA7wk9.Checked = true;
      this.SfwcOA7wk9.CheckState = CheckState.Checked;
      this.SfwcOA7wk9.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.SfwcOA7wk9.Image = (Image) componentResourceManager.GetObject(FJDHryrxb1WIq5jBAt.mT707pbkgT(2034));
      this.SfwcOA7wk9.ImageTransparentColor = Color.Magenta;
      this.SfwcOA7wk9.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(2068);
      this.SfwcOA7wk9.Size = new Size(23, 22);
      this.SfwcOA7wk9.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(2090);
      this.SfwcOA7wk9.Click += new EventHandler(this.Ib1wW2Sljv);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.pNPcxOTJVx);
      this.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(2106);
      this.Size = new Size(302, 26);
      this.pNPcxOTJVx.ResumeLayout(false);
      this.pNPcxOTJVx.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
