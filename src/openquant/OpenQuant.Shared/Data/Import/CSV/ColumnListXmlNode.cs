using FreeQuant.Xml;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class ColumnListXmlNode : XmlNodeBase, IEnumerable
	{
		public override string NodeName
		{
			get
			{
				return "columns";
			}
		}

		public ColumnListXmlNode() : base()
		{
		}

		public void Add(Column column)
		{
			ColumnXmlNode columnXmlNode = (ColumnXmlNode)this.AppendChildNode<ColumnXmlNode>();
			columnXmlNode.ColumnType = column.ColumnType;
			columnXmlNode.Format = column.ColumnFormat;
		}

		public IEnumerator GetEnumerator()
		{
			return ((List<ColumnXmlNode>)this.GetChildNodes<ColumnXmlNode>()).GetEnumerator();
		}
	}
}
