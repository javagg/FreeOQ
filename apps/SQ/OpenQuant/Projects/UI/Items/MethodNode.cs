// Type: OpenQuant.Projects.UI.Items.MethodNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System.Windows.Forms;

namespace OpenQuant.Projects.UI.Items
{
  internal class MethodNode : TreeNode
  {
    private string methodName;

    public string MethodName
    {
      get
      {
        return this.methodName;
      }
    }

    public MethodNode(string methodName)
      : base(methodName, 8, 8)
    {
      this.methodName = methodName;
    }
  }
}
