// Type: OpenQuant.Projects.Xml.PropertyXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;
using System;

namespace OpenQuant.Projects.Xml
{
  internal class PropertyXmlNode : XmlNodeBase
  {
    private const string ATTR_TYPE = "type";
    private const string ATTR_NAME = "name";
    private const string ATTR_IS_ENUM = "is_enum";
    private const string ATTR_CATEGORY = "category";
    private const string ATTR_DESCRIPTION = "description";

    public override string NodeName
    {
      get
      {
        return "property";
      }
    }

    public Type Type
    {
      get
      {
        return this.GetTypeAttribute("type");
      }
      set
      {
        this.SetAttribute("type", value);
      }
    }

    public string Name
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

    public string Value
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

    public bool IsEnum
    {
      get
      {
        if (this.ContainsAttribute("is_enum"))
          return this.GetBooleanAttribute("is_enum");
        else
          return false;
      }
      set
      {
        this.SetAttribute("is_enum", value);
      }
    }

    public string Category
    {
      get
      {
        return this.GetStringAttribute("category");
      }
      set
      {
        this.SetAttribute("category", value);
      }
    }

    public string Descrition
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
  }
}
