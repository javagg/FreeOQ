using FreeQuant.Xml;

namespace OpenQuant.Shared.Updates
{
	class NoteXmlNode : XmlNodeBase
	{
		public override string NodeName
		{
			get
			{
				return "note";
			}
		}

		public string Text
		{
			get
			{
				return this.GetStringValue();
			}
		}

		public NoteXmlNode() : base()
		{
			;
		}
	}
}
