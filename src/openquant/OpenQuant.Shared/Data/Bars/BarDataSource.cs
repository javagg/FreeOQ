using OpenQuant.Shared.Data;
using FreeQuant.Data;

namespace OpenQuant.Shared.Data.Bars
{
	internal class BarDataSource : DataSource
	{
		private string key;

		public BarType BarType { get; private set; }

		public long BarSize { get; private set; }

		public BarDataSource(BarType barType, long barSize) : base(DataSourceInput.Bar)
		{
			this.BarType = barType;
			this.BarSize = barSize;
			this.key = string.Format("{0}{1}{2}", barType, '.', barSize);
		}

		public override string ToString()
		{
			return string.Format("Bar {0}", DataSeriesHelper.BarTypeSizeToString(this.BarType, this.BarSize));
		}

		public override int GetHashCode()
		{
			return this.key.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			return (obj is BarDataSource) ?  ((BarDataSource)obj).key == this.key : base.Equals(obj);
		}
	}
}
