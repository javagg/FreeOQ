using System.Management;

namespace FreeQuant
{
	public class InfoItemBase
	{
		protected internal ManagementObject managementObject;

		protected string GetStringValue(string propertyName)
		{
			return null;
		}

		protected long GetInt64Value(string propertyName)
		{
			return 0;
		}
	}
}
