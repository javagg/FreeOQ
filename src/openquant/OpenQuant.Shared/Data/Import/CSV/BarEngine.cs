using FreeQuant.Data;
using System;

namespace OpenQuant.Shared.Data.Import.CSV
{
	internal class BarEngine : Engine
	{
		private bool makeDaily;

		public BarEngine(bool makeDaily)
		{
			this.makeDaily = makeDaily;
		}

		protected override IDataObject Process()
		{
			DateTime dateTime = this.GetDateTime();
			double doubleValue1 = this.GetDoubleValue(ColumnType.High);
			double doubleValue2 = this.GetDoubleValue(ColumnType.Low);
			double doubleValue3 = this.GetDoubleValue(ColumnType.Open);
			double doubleValue4 = this.GetDoubleValue(ColumnType.Close);
			long int64Value1 = this.GetInt64Value(ColumnType.Volume);
			long int64Value2 = this.GetInt64Value(ColumnType.OpenInt);
			IDataObject idataObject;
			if (this.makeDaily)
			{
				idataObject = (IDataObject)new Daily(dateTime, doubleValue3, doubleValue1, doubleValue2, doubleValue4, int64Value1, int64Value2);
			}
			else
			{
				if (this.template.DataOptions.BarDateTime == BarDateTime.EndTime)
					dateTime = dateTime.AddSeconds((double)-this.template.DataOptions.BarSize);
				Bar bar = new Bar(dateTime, doubleValue3, doubleValue1, doubleValue2, doubleValue4, int64Value1, this.template.DataOptions.BarSize);
				bar.OpenInt = int64Value2;
				idataObject = (IDataObject)bar;
			}
			return idataObject;
		}

		protected override void Add(IDataSeries series, IDataObject obj)
		{
			series.Update(obj.DateTime, obj);
		}
	}
}
