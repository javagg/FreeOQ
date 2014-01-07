// Type: OpenQuant.Projects.Xml.ProjectListXmlNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using SmartQuant.Xml;
using System.Collections;
using System.IO;

namespace OpenQuant.Projects.Xml
{
  internal class ProjectListXmlNode : XmlNodeBase, IEnumerable
  {
    public override string NodeName
    {
      get
      {
        return "projects";
      }
    }

    public void Add(FileInfo file, bool enabled)
    {
      ProjectXmlNode projectXmlNode = this.AppendChildNode<ProjectXmlNode>();
      projectXmlNode.Path.SetValue(file, Global.Setup.Folders.Projects);
      projectXmlNode.Enabled = enabled;
    }

    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.GetChildNodes<ProjectXmlNode>().GetEnumerator();
    }
  }
}
