// Type: OpenQuant.Projects.Xml.ProjectXmlDocument
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared.Compiler;
using SmartQuant.Xml;
using System;

namespace OpenQuant.Projects.Xml
{
  internal class ProjectXmlDocument : XmlDocumentBase
  {
    private const string ATTR_NAME = "name";
    private const string ATTR_DESCRIPTION = "description";
    private const string ATTR_VERSION = "version";
    private const string ATTR_CODE_LANG = "lang";

    public string ProjectName
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

    public string Description
    {
      get
      {
        return this.GetStringAttribute("description");
      }
      set
      {
        this.SetAttribute("description", value);
      }
    }

    public int Version
    {
      get
      {
        return this.GetInt32Attribute("version");
      }
      set
      {
        this.SetAttribute("version", value);
      }
    }

    public CodeLang CodeLang
    {
      get
      {
        return (CodeLang) this.GetEnumAttribute("lang", typeof (CodeLang));
      }
      set
      {
        this.SetAttribute("lang", (Enum) (object) value);
      }
    }

    public InstrumentListXmlNode Instruments
    {
      get
      {
        return this.GetChildNode<InstrumentListXmlNode>();
      }
    }

    public PropertyListXmlNode Properties
    {
      get
      {
        return this.GetChildNode<PropertyListXmlNode>();
      }
    }

    public ProjectXmlDocument()
      : base("project", "project file")
    {
    }
  }
}
