using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FreeQuant.FinChart
{
    public partial class ChartToolStrip : UserControl
	{

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
			this.InitializeComponent();
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
	}
}
