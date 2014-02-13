using OpenQuant.Shared.Compiler;
using FreeQuant.Xml;
using System;

namespace OpenQuant.Shared.Options
{
  class BuildReferenceXmlNode : XmlNodeBase
  {
    private const string ATTR_TYPE = "type";
    private const string ATTR_NAME = "name";
    private const string ATTR_VERSION = "version";

		public override string NodeName
    {
      get
      {
        return "reference";
      }
    }

    public BuildReferenceType ReferenceType
    {
      get
      {
        return (BuildReferenceType) this.GetEnumAttribute("type", typeof (BuildReferenceType));
      }
      set
      {
        this.SetAttribute("type", (Enum) value);
      }
    }

    public string ReferenceName
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

    public Version ReferenceVersion
    {
      get
      {
        string stringAttribute = this.GetStringAttribute("version");
        if (stringAttribute != null)
          return new Version(stringAttribute);
        else
          return (Version) null;
      }
      set
      {
        this.SetAttribute("version", value.ToString(4));
      }
    }

    public string HintPath
    {
      get
      {
        return this.GetStringValue();
      }
      set
      {
        this.SetValue(value);
      }
    }

		public BuildReferenceXmlNode(): base()
    {
    }
  }
}
