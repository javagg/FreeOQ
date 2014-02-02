using System.ComponentModel;

namespace FreeQuant
{
	public class RAMInfo : InfoBase<RAMItemInfo>
	{
		public long TotalCapacity { get { return 0; } }

		public string TotalCapacityString
		{
			get
			{
				return TotalCapacity.ToString();
			}
		}
	}
}
