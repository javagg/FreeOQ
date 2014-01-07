// Type: OpenQuant.Projects.Xml.SolutionXmlDocument
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared.Compiler;
using SmartQuant.Xml;
using System;

namespace OpenQuant.Projects.Xml
{
  internal class SolutionXmlDocument : XmlDocumentBase
  {
    private const string ATTR_NAME = "name";
    private const string ATTR_CODE_LANG = "lang";

    public string SolutionName
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

    public CodeLang CodeLang
    {
      get
      {
        if (this.ContainsAttribute("lang"))
          return (CodeLang) this.GetEnumAttribute("lang", typeof (CodeLang));
        else
          return (CodeLang) 1;
      }
      set
      {
        this.SetAttribute("lang", (Enum) (object) value);
      }
    }

    public ProjectListXmlNode Projects
    {
      get
      {
        return this.GetChildNode<ProjectListXmlNode>();
      }
    }

    public RequestListXmlNode Requests
    {
      get
      {
        return this.GetChildNode<RequestListXmlNode>();
      }
    }

    public SimulationSettingsXmlNode SimulationSettings
    {
      get
      {
        return this.GetChildNode<SimulationSettingsXmlNode>();
      }
    }

    public TesterSettingsXmlNode TesterSettings
    {
      get
      {
        return this.GetChildNode<TesterSettingsXmlNode>();
      }
    }

    public SolutionXmlDocument()
      : base("solution", "solution file")
    {
    }
  }
}
