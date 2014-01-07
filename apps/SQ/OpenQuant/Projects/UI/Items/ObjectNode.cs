// Type: OpenQuant.Projects.UI.Items.ObjectNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System.Windows.Forms;

namespace OpenQuant.Projects.UI.Items
{
  internal class ObjectNode : TreeNode
  {
    protected object nodeObject;

    public virtual object Object
    {
      get
      {
        return this.nodeObject;
      }
    }

    protected ObjectNode(string text, int imageIndex)
      : base(text, imageIndex, imageIndex)
    {
    }

    protected ObjectNode(string text)
      : this(text, -1)
    {
    }
  }
}
