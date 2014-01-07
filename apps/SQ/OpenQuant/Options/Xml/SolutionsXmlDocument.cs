// Type: OpenQuant.Options.Xml.SolutionsXmlDocument
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;

namespace OpenQuant.Options.Xml
{
  internal class SolutionsXmlDocument : XmlDocumentBase
  {
    public RecentSolutionsXmlNode Recent
    {
      get
      {
        return this.GetChildNode<RecentSolutionsXmlNode>();
      }
    }

    public PostRunActionXmlNode PostRunAction
    {
      get
      {
        return this.GetChildNode<PostRunActionXmlNode>();
      }
    }

    public SolutionsXmlDocument()
      : base("solutions")
    {
    }
  }
}
