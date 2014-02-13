using FreeQuant.Xml;

namespace OpenQuant.Shared.Updates
{
	class NoteListXmlNode : ListXmlNode<NoteXmlNode>
	{
		public override string NodeName
		{
			get
			{
				return "notes";
			}
		}

		public NoteListXmlNode() : base()
		{
		}
	}
}
