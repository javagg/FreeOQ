using System.Globalization;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class CultureInfoItem
	{
		public CultureInfo CultureInfo { get; private set; }

		public CultureInfoItem(CultureInfo cultureInfo)
		{
			this.CultureInfo = cultureInfo;
		}

		public override string ToString()
		{
			return this.CultureInfo.DisplayName;
		}
	}
}
