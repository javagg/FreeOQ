// Type: OpenQuant.Projects.Xml.RecentSolutionListXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Projects;
using SmartQuant.Xml;

namespace OpenQuant.Projects.Xml
{
  internal class RecentSolutionListXmlNode : ListXmlNode<RecentSolutionXmlNode>
  {
    public override string NodeName
    {
      get
      {
        return "solutions";
      }
    }

    public void Add(SolutionInfo info)
    {
      RecentSolutionXmlNode recentSolutionXmlNode = base.AppendChildNode<RecentSolutionXmlNode>();
      recentSolutionXmlNode.Path.SetValue(info.File, Global.Setup.Folders.Solutions);
      recentSolutionXmlNode.Name.Value = info.Name;
      recentSolutionXmlNode.Description.Value = info.Description;
      recentSolutionXmlNode.DateModified.Value = info.DateModified;
    }
  }
}
