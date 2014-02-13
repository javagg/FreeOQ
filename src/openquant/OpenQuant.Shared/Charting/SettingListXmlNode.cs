using FreeQuant.Xml;
using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.Shared.Charting
{
	class SettingListXmlNode : XmlNodeBase, IEnumerable
	{
		public override string NodeName
		{
			get
			{
				return "settings";
			}
		}

		public SettingListXmlNode() : base()
		{
		}

		public void Add(string name, Type type, string value)
		{
			SettingXmlNode settingXmlNode = (SettingXmlNode)this.AppendChildNode<SettingXmlNode>();
			settingXmlNode.Name = name;
			settingXmlNode.Type = type;
			settingXmlNode.Value = value;
		}

		public IEnumerator GetEnumerator()
		{
			return ((List<SettingXmlNode>)this.GetChildNodes<SettingXmlNode>()).GetEnumerator();
		}
	}
}
