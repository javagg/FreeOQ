using FreeQuant.Xml;
using System;

namespace OpenQuant.Shared.Updates
{
	class ReleaseXmlNode : XmlNodeBase
	{
		public override string NodeName
		{
			get
			{
				return "release";
			}
		}

		public Version Version
		{
			get
			{
				return new Version(this.GetStringAttribute("version"));
			}
		}

		public DateTime Date
		{
			get
			{
				return this.GetDateTimeAttribute("date");
			}
		}

		public Uri Url86
		{
			get
			{
				string stringAttribute = this.GetStringAttribute("url86");
				if (stringAttribute != null)
					return new Uri(stringAttribute);
				else
					return (Uri)null;
			}
		}

		public Uri Url64
		{
			get
			{
				string stringAttribute = this.GetStringAttribute("url64");
				if (stringAttribute != null)
					return new Uri(stringAttribute);
				else
					return null;
			}
		}

		public NoteListXmlNode Notes
		{
			get
			{
				return this.GetChildNode<NoteListXmlNode>();
			}
		}

		public ReleaseXmlNode() : base()
		{
		}
	}
}
