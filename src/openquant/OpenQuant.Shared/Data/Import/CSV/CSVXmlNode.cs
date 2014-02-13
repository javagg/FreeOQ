using FreeQuant.Xml;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class CSVXmlNode : XmlNodeBase
	{
		private const string ATTR_SEPARATOR = "separator";
		private const string ATTR_HEADER_LINE_COUNT = "headerLineCount";
		private const string ATTR_CULTURE_INFO = "culture";

		public override string NodeName
		{
			get
			{
				return "csv";
			}
		}

		public string Separator
		{
			get
			{
				return this.GetStringAttribute("separator");
			}
			set
			{
				this.SetAttribute("separator", value);
			}
		}

		public int HeaderLineCount
		{
			get
			{
				return this.GetInt32Attribute("headerLineCount");
			}
			set
			{
				this.SetAttribute("headerLineCount", value);
			}
		}

		public string Culture
		{
			get
			{
				return this.GetStringAttribute("culture");
			}
			set
			{
				this.SetAttribute("culture", value);
			}
		}

		public CSVXmlNode() : base()
		{
		}
	}
}
