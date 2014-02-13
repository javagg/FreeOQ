using FreeQuant.Data;
using System;
using System.Collections.Generic;

namespace OpenQuant.Shared.Data
{
	public static class DataSeriesHelper
	{
		public static DataSeriesInfo GetDataSeriesInfo(string seriesName)
		{
			DataSeriesInfo dataSeriesInfo = new DataSeriesInfo();
			dataSeriesInfo.SeriesName = seriesName;
			List<string> list = new List<string>((IEnumerable<string>)seriesName.Split(new char[] { '.' }));
			dataSeriesInfo.DataType = DataType.Unknown;
			switch (list[list.Count - 1])
			{
				case "Daily":
					dataSeriesInfo.DataType = DataType.Daily;
					break;
				case "Trade":
					dataSeriesInfo.DataType = DataType.Trade;
					break;
				case "Quote":
					dataSeriesInfo.DataType = DataType.Quote;
					break;
				case "Depth":
					dataSeriesInfo.DataType = DataType.MarketDepth;
					break;
			}
			int count = 1;
			long result;
			if (dataSeriesInfo.DataType == DataType.Unknown && list.Count >= 4 && (list[list.Count - 3] == "Bar" && Enum.IsDefined(typeof(BarType), (object)list[list.Count - 2])) && long.TryParse(list[list.Count - 1], out result))
			{
				dataSeriesInfo.DataType = DataType.Bar;
				dataSeriesInfo.BarType = (BarType)Enum.Parse(typeof(BarType), list[list.Count - 2]);
				dataSeriesInfo.BarSize = result;
				count = 3;
			}
			dataSeriesInfo.Symbol = string.Join('.'.ToString(), list.GetRange(0, list.Count - count).ToArray());
			dataSeriesInfo.Suffix = string.Join('.'.ToString(), list.GetRange(list.Count - count, count).ToArray());
			return dataSeriesInfo;
		}

		public static bool TryGetBarTypeSize(string seriesName, out BarType barType, out long barSize)
		{
			DataSeriesInfo dataSeriesInfo = DataSeriesHelper.GetDataSeriesInfo(seriesName);
			barType = dataSeriesInfo.BarType;
			barSize = dataSeriesInfo.BarSize;
			return dataSeriesInfo.DataType == DataType.Bar;
		}

		public static string SeriesNameToString(string seriesName)
		{
			DataSeriesInfo dataSeriesInfo = DataSeriesHelper.GetDataSeriesInfo(seriesName);
			switch (dataSeriesInfo.DataType)
			{
				case DataType.Bar:
					return string.Format("{0} {1}", (object)"Bar", (object)DataSeriesHelper.BarTypeSizeToString(dataSeriesInfo.BarType, dataSeriesInfo.BarSize));
				case DataType.MarketDepth:
					return ((object)dataSeriesInfo.DataType).ToString();
				default:
					return dataSeriesInfo.Suffix;
			}
		}

		public static string BarTypeSizeToString(BarType barType, long barSize)
		{
			switch (barType)
			{
				case BarType.Time:
					if (barSize == 86400L)
						return "Daily";
					if (barSize % 86400L == 0L)
						return string.Format("{0} day", (object)(barSize / 86400L));
					if (barSize % 3600L == 0L)
						return string.Format("{0} hour", (object)(barSize / 3600L));
					if (barSize % 60L == 0L)
						return string.Format("{0} min", (object)(barSize / 60L));
					else
						return string.Format("{0} sec", (object)barSize);
				case  BarType.Tick:
					return string.Format("{0} tick", (object)barSize);
				case BarType.Volume:
					return string.Format("{0} vol", (object)barSize);
				case BarType.Range:
					return string.Format("{0} range", (object)((double)barSize / 10000.0));
				default:
					throw new ArgumentException(string.Format("Unknown bar type - {0}", barType));
			}
		}
	}
}
