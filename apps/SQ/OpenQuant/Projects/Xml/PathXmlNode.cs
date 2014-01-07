// Type: OpenQuant.Projects.Xml.PathXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;
using System;
using System.IO;

namespace OpenQuant.Projects.Xml
{
  internal class PathXmlNode : XmlNodeBase
  {
    private const string ATTR_TYPE = "type";

    public override string NodeName
    {
      get
      {
        return "path";
      }
    }

    private PathXmlNode.PathType Type
    {
      get
      {
        return (PathXmlNode.PathType) Enum.Parse(typeof (PathXmlNode.PathType), this.GetStringAttribute("type"));
      }
      set
      {
        this.SetAttribute("type", (Enum) value);
      }
    }

    private string Path
    {
      get
      {
        return this.GetStringValue();
      }
      set
      {
        base.SetValue(value);
      }
    }

    public FileInfo GetValue(DirectoryInfo directory)
    {
      PathXmlNode.PathType type = this.Type;
      switch (type)
      {
        case PathXmlNode.PathType.Absolute:
          return new FileInfo(this.Path);
        case PathXmlNode.PathType.Relative:
          return new FileInfo(string.Format("{0}\\{1}", (object) directory.FullName, (object) this.Path));
        default:
          throw new NotSupportedException(string.Format("Unknown path type - {0}", (object) type));
      }
    }

    public void SetValue(FileInfo value, DirectoryInfo directory)
    {
      string fullName = directory.FullName;
      if (value.FullName.ToUpper().StartsWith(fullName.ToUpper()))
      {
        this.Type = PathXmlNode.PathType.Relative;
        this.Path = value.FullName.Substring(fullName.Length + 1);
      }
      else
      {
        this.Type = PathXmlNode.PathType.Absolute;
        this.Path = value.FullName;
      }
    }

    public enum PathType
    {
      Absolute,
      Relative,
    }
  }
}
