using System.Threading;
using System.Xml.Serialization;

namespace OpenQuant.Shared.Options
{
	[XmlRoot("data")]
	public struct ScriptsXmlData
	{
		[XmlElement("apartment.state")]
		public ApartmentState ApartmentState;
	}
}
