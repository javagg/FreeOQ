using OpenQuant.Shared;
using OpenQuant.Shared.Indicators;
//using OpenQuant.Shared.Properties;
using FreeQuant.FinChart;
using FreeQuant.Indicators;
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
	public partial class Chart : FreeQuant.FinChart.Chart
	{
		private Color defaultLineColor;
		private bool indicatorDropEnabled;
		private List<DoubleSeries> defaultColoredSeriesList;
		private bool additionalButtonsEnabled;
		private bool barStyleButtonsEnabled;

		public bool IndicatorDropEnabled
		{
			get
			{
				return this.indicatorDropEnabled;
			}
			set
			{
				this.indicatorDropEnabled = value;
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
			}
		}

		public bool BarStyleButtonsEnabled
		{
			get
			{
				return this.barStyleButtonsEnabled;
			}
			set
			{
				this.barStyleButtonsEnabled = value;
			}
		}

		public Color DefaultLineColor
		{
			get
			{
				return this.defaultLineColor;
			}
			set
			{
				this.defaultLineColor = value;
				using (List<DoubleSeries>.Enumerator enumerator = this.defaultColoredSeriesList.GetEnumerator())
				{
					while (enumerator.MoveNext())
						((TimeSeries)enumerator.Current).Color = this.defaultLineColor;
				}
				this.contentUpdated = true; // (__Null)1;
			}
		}

		internal event TimeFrameEventHandler TimeFrameChanged;
		internal event EventHandler<TemplateActionEventArgs> TemplateAction;
		internal event IndicatorEventHandler IndicatorDropped;
		internal event EventHandler ChartPropertiesCalled;

		public Chart() : base()
		{
			this.InitializeComponent();
			this.barStyleButtonsEnabled = true;
			this.doubleSeriesSmoothingMode = SmoothingMode.AntiAlias;
			Global.ChartManager.Add(this);
		}

		public void ApplyDefaultTemplate()
		{
			foreach (KeyValuePair<string, Color> keyValuePair in Global.ChartManager.ColorTemplates.DefaultTemplate.Settings)
				((object)this).GetType().GetProperty(keyValuePair.Key, BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty).SetValue((object)this, (object)keyValuePair.Value, (object[])null);
		}

		public void SetDefaultColoredMainSeries(DoubleSeries series)
		{
			series.Color = this.defaultLineColor;
			this.defaultColoredSeriesList.Add(series);
			this.SetMainSeries(series);
		}

		public void DrawDefaultColoredSeries(DoubleSeries series, int padNumber, SimpleDSStyle style, SmoothingMode smoothing)
		{
			series.Color = this.defaultLineColor;
			this.defaultColoredSeriesList.Add(series);
			this.DrawSeries(series, padNumber, this.defaultLineColor, style, smoothing);
		}

		internal void EmitTemplateAction(TemplateActionType actionType, string templateName)
		{
			if (this.TemplateAction == null)
				return;
			this.TemplateAction((object)this, new TemplateActionEventArgs(actionType, templateName));
		}

		internal void EmitTemplateAction(TemplateActionType actionType)
		{
			this.EmitTemplateAction(actionType, (string)null);
		}

		internal void EmitTimeFrameChanged(ChartTimeFrame timeFrame)
		{
			if (this.TimeFrameChanged == null)
				return;
			this.TimeFrameChanged(timeFrame);
		}

		protected override void OnDragOver(DragEventArgs drgevent)
		{
			if (!this.indicatorDropEnabled || !drgevent.Data.GetDataPresent(typeof(IndicatorData)))
				return;
			drgevent.Effect = DragDropEffects.Copy;
		}

		protected override void OnDragDrop(DragEventArgs drgevent)
		{
			if (!this.indicatorDropEnabled || !drgevent.Data.GetDataPresent(typeof(IndicatorData)) || this.IndicatorDropped == null)
				return;
			this.IndicatorDropped(((IndicatorData)drgevent.Data.GetData(typeof(IndicatorData))).IndicatorType, ((Control)this).PointToClient(new Point(drgevent.X, drgevent.Y)));
		}

		public override void ShowProperties(DSView seriesView, Pad pad, bool forceShowProperties)
		{
			object obj = (object)null;
			if (seriesView.MainSeries.GetType().IsSubclassOf(typeof(Indicator)))
			{
				obj = Activator.CreateInstance(System.Type.GetType("OpenQuant.API.Indicators." + ((object)((SeriesView)seriesView).MainSeries).GetType().Name + ", OpenQuant.API"), true);
				obj.GetType().GetField("indicator", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).SetValue(obj, (object)((SeriesView)seriesView).MainSeries);
			}
			if (this.ChartPropertiesCalled == null)
				return;
			this.ChartPropertiesCalled((object)new Tuple<object, bool>(obj, forceShowProperties), EventArgs.Empty);
		}
	}
}
