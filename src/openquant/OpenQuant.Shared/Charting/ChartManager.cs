using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Shared.Charting
{
	public class ChartManager
	{
		private static List<Chart> charts;

		internal ChartColorTemplateList ColorTemplates { get; private set; }

		internal ChartTemplateList Templates { get; private set; }

		public ChartManager(DirectoryInfo chartDirectory)
		{
			ChartManager.charts = new List<Chart>();
			this.ColorTemplates = new ChartColorTemplateList(chartDirectory);
			this.Templates = new ChartTemplateList(chartDirectory);
		}

		internal void Add(Chart chart)
		{
			lock (ChartManager.charts)
			{
				ChartManager.charts.Add(chart);
				chart.Disposed += (sender, e) =>
				{
					lock (ChartManager.charts)
						ChartManager.charts.Remove(sender as Chart);
				};
//					new EventHandler(this.chart_Disposed);
			}
		}

		internal void Update()
		{
			lock (ChartManager.charts)
				ChartManager.charts.ToArray();
			foreach (Chart chart in ChartManager.charts)
			{
				chart.ApplyDefaultTemplate();
				chart.Refresh();
			}
		}
		//    private void chart_Disposed(object sender, EventArgs e)
		//    {
		//      lock (ChartManager.charts)
		//        ChartManager.charts.Remove(sender as Chart);
		//    }
	}
}
