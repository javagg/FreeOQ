using OpenQuant.Shared.Data;
using FreeQuant.Data;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Bars
{
	class DataSeriesViewItem : ListViewItem
	{
		public IDataSeries DataSeries { get; private set; }

		public DataSeriesViewItem(IDataSeries dataSeries) : base(new string[1])
		{
			this.DataSeries = dataSeries;
			this.SubItems[0].Text = DataSeriesHelper.GetDataSeriesInfo(dataSeries.Name).Symbol;
			this.ImageIndex = 0;
		}
	}
}
