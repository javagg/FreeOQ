using FreeQuant.Xml;
using System;

namespace OpenQuant.Shared.Options
{
	class AutoSaveXmlNode : XmlNodeBase
	{
		private const string ATTR_ENABLED = "enabled";

		public override string NodeName
		{
			get
			{
				return "AutoSave";
			}
		}

		public bool Enabled
		{
			get
			{
				if (this.ContainsAttribute("enabled"))
					return this.GetBooleanAttribute("enabled");
				else
					return false;
			}
			set
			{
				this.SetAttribute("enabled", value);
			}
		}

		public TimeSpan Interval
		{
			get
			{
				TimeSpan result;
				if (TimeSpan.TryParse(this.GetStringValue(), out result))
					return result;
				else
					return TimeSpan.FromMinutes(1.0);
			}
			set
			{
				this.SetValue(value.ToString());
			}
		}

		public AutoSaveXmlNode() : base()
		{
			;
		}
	}
}
