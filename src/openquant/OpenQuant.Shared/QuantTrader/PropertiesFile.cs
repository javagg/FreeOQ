using FreeQuant.Xml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace OpenQuant.Shared.QuantTrader
{
	public class PropertiesFile : XmlFile
	{
		public Property[] Properties
		{
			get
			{
				List<Property> list = new List<Property>();
				IEnumerator enumerator = ((ListXmlNode<PropertyXmlNode>)this.GetDocument<PropertiesXmlDocument>().Properties).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						PropertyXmlNode propertyXmlNode = (PropertyXmlNode)enumerator.Current;
						if (propertyXmlNode.Type != null)
						{
							TypeConverter converter = TypeDescriptor.GetConverter(propertyXmlNode.Type);
							if (converter != null)
							{
								if (converter.CanConvertFrom(typeof(string)))
								{
									try
									{
										list.Add(new Property(propertyXmlNode.Name, propertyXmlNode.Type, converter.ConvertFromInvariantString(propertyXmlNode.Value)));
									}
									catch
									{
									}
								}
							}
						}
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
						disposable.Dispose();
				}
				return list.ToArray();
			}
			set
			{
				PropertiesXmlDocument propertiesXmlDocument = new PropertiesXmlDocument();
				foreach (Property property in value)
				{
					if (property.Value != null)
					{
						TypeConverter converter = TypeDescriptor.GetConverter(property.Type);
						if (converter != null && converter.CanConvertTo(typeof(string)) && converter.CanConvertFrom(typeof(string)))
							propertiesXmlDocument.Properties.Add(property.Name, property.Type, converter.ConvertToInvariantString(property.Value));
					}
				}
				this.SetDocument(propertiesXmlDocument);
			}
		}
	}
}
