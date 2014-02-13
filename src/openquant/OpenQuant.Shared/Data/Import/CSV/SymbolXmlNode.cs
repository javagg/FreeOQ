using FreeQuant.Xml;
using System;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class SymbolXmlNode : XmlNodeBase
	{
		private const string ATTR_OPTION = "option";
		private const string ATTR_NAME = "name";

		public override string NodeName
		{
			get
			{
				return "symbol";
			}
		}

		public SymbolOption SymbolOption
		{
			get
			{
				return (SymbolOption)this.GetEnumAttribute("option", typeof(SymbolOption));
			}
			set
			{
				this.SetAttribute("option", (Enum)value);
			}
		}

		public string Name_
		{
			get
			{
				return this.GetStringAttribute("name");
			}
			set
			{
				this.SetAttribute("name", value);
			}
		}

		public SymbolXmlNode() : base()
		{
		}
	}
}
