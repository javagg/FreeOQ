using System;
using System.Reflection;

namespace OpenQuant.Shared
{
	public class ProductInfo
	{
		public virtual string Name
		{
			get
			{
				object[] customAttributes = Assembly.GetEntryAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
				if (customAttributes.Length <= 0)
					return string.Empty;
				else
					return ((AssemblyProductAttribute)customAttributes[0]).Product;
			}
		}

		public virtual Version Version
		{
			get
			{
				return Assembly.GetEntryAssembly().GetName().Version;
			}
		}

		public virtual string Platform
		{
			get
			{
				return !Environment.Is64BitProcess ? "32 bit" : "64 bit";
			}
		}

		public virtual string Copyright
		{
			get
			{
				object[] customAttributes = Assembly.GetEntryAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
				if (customAttributes.Length <= 0)
					return string.Empty;
				else
					return ((AssemblyCopyrightAttribute)customAttributes[0]).Copyright;
			}
		}
	}
}
