using FreeQuant.Xml;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class TemplateListXmlNode : XmlNodeBase, IEnumerable
	{
		public override string NodeName
		{
			get
			{
				return "templates";
			}
		}

		public TemplateListXmlNode() : base()
		{
		}

		public void Add(Template template)
		{
			TemplateXmlNode templateXmlNode = (TemplateXmlNode)this.AppendChildNode<TemplateXmlNode>();
			templateXmlNode.TemplateName = template.Name;
			templateXmlNode.CSV.Separator = template.CSVOptions.Separator.DisplayName;
			templateXmlNode.CSV.HeaderLineCount = template.CSVOptions.HeaderLineCount;
			templateXmlNode.CSV.Culture = template.CSVOptions.CultureInfo.Name;
			templateXmlNode.Data.DataType = template.DataOptions.DataType;
			templateXmlNode.Data.BarSize = template.DataOptions.BarSize;
			templateXmlNode.Data.BarDateTime = template.DataOptions.BarDateTime;
			templateXmlNode.Date.DateType = template.DateOptions.DateType;
			templateXmlNode.Date.Date = template.DateOptions.Date;
			templateXmlNode.Symbol.SymbolOption = template.SymbolOptions.Option;
			templateXmlNode.Symbol.Name_ = template.SymbolOptions.Name;
			templateXmlNode.Other.CreateInstrument = template.OtherOptions.CreateInstrument;
			templateXmlNode.Other.InstrumentType = template.OtherOptions.InstrumentType;
			templateXmlNode.Other.ClearSeries = template.OtherOptions.ClearSeries;
			templateXmlNode.Other.SkipDataInsideExistingRange = template.OtherOptions.SkipDataInsideExistingRange;
			foreach (Column column in (List<Column>) template.Columns)
				templateXmlNode.Columns.Add(column);
		}

		public IEnumerator GetEnumerator()
		{
			return (IEnumerator)((List<TemplateXmlNode>)this.GetChildNodes<TemplateXmlNode>()).GetEnumerator();
		}
	}
}
