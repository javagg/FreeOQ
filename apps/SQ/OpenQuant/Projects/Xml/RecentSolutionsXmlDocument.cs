// Type: OpenQuant.Projects.Xml.RecentSolutionsXmlDocument
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Xml;

namespace OpenQuant.Projects.Xml
{
  internal class RecentSolutionsXmlDocument : XmlDocumentBase
  {
    public RecentSolutionListXmlNode Solutions
    {
      get
      {
        return this.GetChildNode<RecentSolutionListXmlNode>();
      }
    }

    public RecentSolutionsXmlDocument()
      : base("document")
    {
    }
  }
}
