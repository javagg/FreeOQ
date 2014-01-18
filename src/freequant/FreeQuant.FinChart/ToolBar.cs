using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FreeQuant.FinChart
{
  public class ToolBar : UserControl
  {
    private Chart JvfSB0faP3;
    private ToolTip sf4SjX1ToR;
    private ImageList N8BSouAZN1;
    private ToolBarButton GHZSaNnkGg;
    private ToolBarButton tM9SpQ48d1;
    private ToolBarButton d90SW54h6P;
    private System.Windows.Forms.ToolBar uPSSFuKEDk;
    private ToolBarButton kbZSI7yHWF;
    private ToolBarButton SHBSzi5RWV;
    private ToolBarButton sav0tem4ql;
    private ToolBarButton rTk0wOhRro;
    private ToolBarButton L4H0cGUhOc;
    private ToolBarButton gnW0JYdeuq;
    private ToolBarButton W840yr4JgF;
    private ToolBarButton tk80SKptT6;
    private ToolBarButton SDT00J8DRD;
    private ToolBarButton Bla0rORiyV;
    private ToolBarButton Jxd0K4UyYR;
    private ToolBarButton SYG0iI8HBl;
    private ToolBarButton HOr0XJ5GIq;
    private ToolBarButton GW90DgPn0G;
    private IContainer JHF0h2KEDN;

    public Chart Chart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.JvfSB0faP3;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.PUISLLKlgW();
        this.JvfSB0faP3 = value;
        this.drPSqOMJnJ();
        this.gLtSH1DvrV();
        this.CmxSgv1abt();
        this.roGSVnjCu8();
        this.d3gS2B1EsO();
        this.csRSYcSfK9();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ToolBar()
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.tb4SlKoQaK();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ToolBar(Chart chart)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      this.\u002Ector();
      this.Chart = chart;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.JHF0h2KEDN != null)
        this.JHF0h2KEDN.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void tb4SlKoQaK()
    {
      this.JHF0h2KEDN = (IContainer) new Container();
      ResourceManager resourceManager = new ResourceManager(typeof (ToolBar));
      this.uPSSFuKEDk = new System.Windows.Forms.ToolBar();
      this.kbZSI7yHWF = new ToolBarButton();
      this.SHBSzi5RWV = new ToolBarButton();
      this.GHZSaNnkGg = new ToolBarButton();
      this.sav0tem4ql = new ToolBarButton();
      this.rTk0wOhRro = new ToolBarButton();
      this.tM9SpQ48d1 = new ToolBarButton();
      this.L4H0cGUhOc = new ToolBarButton();
      this.gnW0JYdeuq = new ToolBarButton();
      this.d90SW54h6P = new ToolBarButton();
      this.Jxd0K4UyYR = new ToolBarButton();
      this.SYG0iI8HBl = new ToolBarButton();
      this.HOr0XJ5GIq = new ToolBarButton();
      this.Bla0rORiyV = new ToolBarButton();
      this.W840yr4JgF = new ToolBarButton();
      this.tk80SKptT6 = new ToolBarButton();
      this.SDT00J8DRD = new ToolBarButton();
      this.GW90DgPn0G = new ToolBarButton();
      this.N8BSouAZN1 = new ImageList(this.JHF0h2KEDN);
      this.sf4SjX1ToR = new ToolTip(this.JHF0h2KEDN);
      this.SuspendLayout();
      this.uPSSFuKEDk.Appearance = ToolBarAppearance.Flat;
      this.uPSSFuKEDk.Buttons.AddRange(new ToolBarButton[17]
      {
        this.kbZSI7yHWF,
        this.SHBSzi5RWV,
        this.GHZSaNnkGg,
        this.sav0tem4ql,
        this.rTk0wOhRro,
        this.tM9SpQ48d1,
        this.L4H0cGUhOc,
        this.gnW0JYdeuq,
        this.d90SW54h6P,
        this.Jxd0K4UyYR,
        this.SYG0iI8HBl,
        this.HOr0XJ5GIq,
        this.Bla0rORiyV,
        this.W840yr4JgF,
        this.tk80SKptT6,
        this.SDT00J8DRD,
        this.GW90DgPn0G
      });
      this.uPSSFuKEDk.Dock = DockStyle.Fill;
      this.uPSSFuKEDk.DropDownArrows = true;
      this.uPSSFuKEDk.ImageList = this.N8BSouAZN1;
      this.uPSSFuKEDk.Location = new Point(0, 0);
      this.uPSSFuKEDk.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(3628);
      this.uPSSFuKEDk.ShowToolTips = true;
      this.uPSSFuKEDk.Size = new Size(408, 28);
      this.uPSSFuKEDk.TabIndex = 0;
      this.uPSSFuKEDk.ButtonClick += new ToolBarButtonClickEventHandler(this.AiQSsBlXRC);
      this.kbZSI7yHWF.ImageIndex = 7;
      this.kbZSI7yHWF.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(3656);
      this.SHBSzi5RWV.ImageIndex = 8;
      this.SHBSzi5RWV.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(3672);
      this.GHZSaNnkGg.Style = ToolBarButtonStyle.Separator;
      this.sav0tem4ql.ImageIndex = 5;
      this.sav0tem4ql.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(3694);
      this.rTk0wOhRro.ImageIndex = 6;
      this.rTk0wOhRro.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(3712);
      this.tM9SpQ48d1.Style = ToolBarButtonStyle.Separator;
      this.L4H0cGUhOc.ImageIndex = 9;
      this.L4H0cGUhOc.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(3732);
      this.gnW0JYdeuq.ImageIndex = 10;
      this.gnW0JYdeuq.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(3760);
      this.d90SW54h6P.Style = ToolBarButtonStyle.Separator;
      this.Jxd0K4UyYR.ImageIndex = 17;
      this.Jxd0K4UyYR.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(3782);
      this.Jxd0K4UyYR.Visible = false;
      this.SYG0iI8HBl.ImageIndex = 19;
      this.SYG0iI8HBl.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(3818);
      this.HOr0XJ5GIq.ImageIndex = 18;
      this.HOr0XJ5GIq.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(3848);
      this.Bla0rORiyV.Style = ToolBarButtonStyle.Separator;
      this.W840yr4JgF.ImageIndex = 11;
      this.W840yr4JgF.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(3872);
      this.tk80SKptT6.ImageIndex = 12;
      this.tk80SKptT6.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(3888);
      this.SDT00J8DRD.ImageIndex = 13;
      this.SDT00J8DRD.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(3898);
      this.GW90DgPn0G.ImageIndex = 20;
      this.GW90DgPn0G.ToolTipText = FJDHryrxb1WIq5jBAt.mT707pbkgT(3910);
      this.N8BSouAZN1.ImageSize = new Size(16, 16);
      this.N8BSouAZN1.ImageStream = (ImageListStreamer) resourceManager.GetObject(FJDHryrxb1WIq5jBAt.mT707pbkgT(3946));
      this.N8BSouAZN1.TransparentColor = Color.Transparent;
      this.Controls.Add((Control) this.uPSSFuKEDk);
      this.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(3992);
      this.Size = new Size(408, 32);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VTHSvlWY7P()
    {
      this.JvfSB0faP3.BarSeriesStyle = BSStyle.Candle;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void fqTSdJFT0I()
    {
      this.JvfSB0faP3.BarSeriesStyle = BSStyle.Bar;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void C9MSu2Qyh1()
    {
      this.JvfSB0faP3.BarSeriesStyle = BSStyle.Line;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OrDSxvD1vo()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void fgSSACIZ2R()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void U74S52iXhy()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void toySZxwXk7()
    {
      this.JvfSB0faP3.ScaleStyle = PadScaleStyle.Arith;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DF4S4Bvlpe()
    {
      this.JvfSB0faP3.ScaleStyle = PadScaleStyle.Log;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ogbSfOH4BE()
    {
      this.JvfSB0faP3.ActionType = ChartActionType.Cross;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Jx5SGKnSDm()
    {
      this.JvfSB0faP3.ActionType = ChartActionType.None;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ruCSkCeEMT()
    {
      this.JvfSB0faP3.ZoomIn();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void JcbSM8Pqgr()
    {
      this.JvfSB0faP3.ZoomOut();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void dVYSQC1Tub()
    {
      this.JvfSB0faP3.UpdateStyle = ChartUpdateStyle.WholeRange;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IRdS60EPof()
    {
      this.JvfSB0faP3.UpdateStyle = ChartUpdateStyle.Trailing;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void G8SS93JwmO()
    {
      this.JvfSB0faP3.UpdateStyle = ChartUpdateStyle.Fixed;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ocMSO3R2u1()
    {
      this.JvfSB0faP3.BarSeriesStyle = BSStyle.PointAndFigure;
      this.JvfSB0faP3.DrawItems = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AiQSsBlXRC([In] object obj0, [In] ToolBarButtonClickEventArgs obj1)
    {
      if (obj1.Button == this.sav0tem4ql)
        this.ruCSkCeEMT();
      if (obj1.Button == this.rTk0wOhRro)
        this.JcbSM8Pqgr();
      if (obj1.Button == this.SHBSzi5RWV)
        this.ogbSfOH4BE();
      if (obj1.Button == this.kbZSI7yHWF)
        this.Jx5SGKnSDm();
      if (obj1.Button == this.L4H0cGUhOc)
        this.toySZxwXk7();
      if (obj1.Button == this.gnW0JYdeuq)
        this.DF4S4Bvlpe();
      if (obj1.Button == this.W840yr4JgF)
        this.VTHSvlWY7P();
      if (obj1.Button == this.tk80SKptT6)
        this.fqTSdJFT0I();
      if (obj1.Button == this.SDT00J8DRD)
        this.C9MSu2Qyh1();
      if (obj1.Button == this.Jxd0K4UyYR)
        this.dVYSQC1Tub();
      if (obj1.Button == this.SYG0iI8HBl)
        this.IRdS60EPof();
      if (obj1.Button == this.HOr0XJ5GIq)
        this.G8SS93JwmO();
      if (obj1.Button != this.GW90DgPn0G)
        return;
      this.ocMSO3R2u1();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PUISLLKlgW()
    {
      if (this.JvfSB0faP3 == null)
        return;
      this.JvfSB0faP3.ActionTypeChanged -= new EventHandler(this.lQxSNSiaOm);
      this.JvfSB0faP3.UpdateStyleChanged -= new EventHandler(this.GhiSCyiVRF);
      this.JvfSB0faP3.VolumeVisibleChanged -= new EventHandler(this.GRbSm8MtY1);
      this.JvfSB0faP3.BarSeriesStyleChanged -= new EventHandler(this.KSTS3uqLm4);
      this.JvfSB0faP3.ScaleStyleChanged -= new EventHandler(this.hUMS8DFqNU);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void drPSqOMJnJ()
    {
      if (this.JvfSB0faP3 == null)
        return;
      this.JvfSB0faP3.ActionTypeChanged += new EventHandler(this.lQxSNSiaOm);
      this.JvfSB0faP3.UpdateStyleChanged += new EventHandler(this.GhiSCyiVRF);
      this.JvfSB0faP3.VolumeVisibleChanged += new EventHandler(this.GRbSm8MtY1);
      this.JvfSB0faP3.BarSeriesStyleChanged += new EventHandler(this.KSTS3uqLm4);
      this.JvfSB0faP3.ScaleStyleChanged += new EventHandler(this.hUMS8DFqNU);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void roGSVnjCu8()
    {
      if (this.JvfSB0faP3.UpdateStyle == ChartUpdateStyle.Fixed)
      {
        this.HOr0XJ5GIq.Pushed = true;
        this.SYG0iI8HBl.Pushed = false;
        this.Jxd0K4UyYR.Pushed = false;
      }
      if (this.JvfSB0faP3.UpdateStyle == ChartUpdateStyle.Trailing)
      {
        this.HOr0XJ5GIq.Pushed = false;
        this.SYG0iI8HBl.Pushed = true;
        this.Jxd0K4UyYR.Pushed = false;
      }
      if (this.JvfSB0faP3.UpdateStyle != ChartUpdateStyle.WholeRange)
        return;
      this.HOr0XJ5GIq.Pushed = false;
      this.SYG0iI8HBl.Pushed = false;
      this.Jxd0K4UyYR.Pushed = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void d3gS2B1EsO()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CmxSgv1abt()
    {
      if (this.JvfSB0faP3.BarSeriesStyle == BSStyle.Bar)
      {
        this.tk80SKptT6.Pushed = true;
        this.W840yr4JgF.Pushed = false;
        this.SDT00J8DRD.Pushed = false;
        this.GW90DgPn0G.Pushed = false;
      }
      if (this.JvfSB0faP3.BarSeriesStyle == BSStyle.Candle)
      {
        this.tk80SKptT6.Pushed = false;
        this.W840yr4JgF.Pushed = true;
        this.SDT00J8DRD.Pushed = false;
        this.GW90DgPn0G.Pushed = false;
      }
      if (this.JvfSB0faP3.BarSeriesStyle == BSStyle.Line)
      {
        this.tk80SKptT6.Pushed = false;
        this.W840yr4JgF.Pushed = false;
        this.SDT00J8DRD.Pushed = true;
        this.GW90DgPn0G.Pushed = false;
      }
      if (this.JvfSB0faP3.BarSeriesStyle != BSStyle.PointAndFigure)
        return;
      this.tk80SKptT6.Pushed = false;
      this.W840yr4JgF.Pushed = false;
      this.SDT00J8DRD.Pushed = false;
      this.GW90DgPn0G.Pushed = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void gLtSH1DvrV()
    {
      if (this.JvfSB0faP3.ActionType == ChartActionType.Cross)
      {
        this.SHBSzi5RWV.Pushed = true;
        this.kbZSI7yHWF.Pushed = false;
      }
      if (this.JvfSB0faP3.ActionType != ChartActionType.None)
        return;
      this.SHBSzi5RWV.Pushed = false;
      this.kbZSI7yHWF.Pushed = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void csRSYcSfK9()
    {
      if (this.JvfSB0faP3.ScaleStyle == PadScaleStyle.Arith)
      {
        this.L4H0cGUhOc.Pushed = true;
        this.gnW0JYdeuq.Pushed = false;
      }
      if (this.JvfSB0faP3.ScaleStyle != PadScaleStyle.Log)
        return;
      this.L4H0cGUhOc.Pushed = false;
      this.gnW0JYdeuq.Pushed = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GhiSCyiVRF([In] object obj0, [In] EventArgs obj1)
    {
      this.roGSVnjCu8();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GRbSm8MtY1([In] object obj0, [In] EventArgs obj1)
    {
      this.d3gS2B1EsO();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void KSTS3uqLm4([In] object obj0, [In] EventArgs obj1)
    {
      this.CmxSgv1abt();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void lQxSNSiaOm([In] object obj0, [In] EventArgs obj1)
    {
      this.gLtSH1DvrV();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void hUMS8DFqNU([In] object obj0, [In] EventArgs obj1)
    {
      this.csRSYcSfK9();
    }
  }
}
