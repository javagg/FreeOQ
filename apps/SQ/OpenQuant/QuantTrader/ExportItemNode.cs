// Type: OpenQuant.QuantTrader.ExportItemNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System.Collections.Generic;
using System.Windows.Forms;

namespace OpenQuant.QuantTrader
{
  internal class ExportItemNode : TreeNode
  {
    private int collapsedImageIndex;
    private int expandedImageIndex;

    public virtual bool AutoCheckFromParent
    {
      get
      {
        return true;
      }
    }

    public virtual bool AutoUncheckParent
    {
      get
      {
        return true;
      }
    }

    protected ExportItemNode(string text, int collapsedImageIndex, int expandedImageIndex)
      : base(text)
    {
      this.collapsedImageIndex = collapsedImageIndex;
      this.expandedImageIndex = expandedImageIndex;
      this.Checked = true;
      this.UpdateImage();
    }

    protected ExportItemNode(string text, int imageIndex)
      : this(text, imageIndex, imageIndex)
    {
    }

    public new void UpdateImage()
    {
      this.ImageIndex = this.SelectedImageIndex = this.IsExpanded ? this.expandedImageIndex : this.collapsedImageIndex;
    }

    public T[] GetNodes<T>(bool checkedOnly) where T : ExportItemNode
    {
      List<T> list = new List<T>();
      foreach (TreeNode treeNode in this.Nodes)
      {
        if (treeNode is T && (!checkedOnly || treeNode.Checked))
          list.Add((T) treeNode);
      }
      return list.ToArray();
    }

    public T GetNode<T>() where T : ExportItemNode
    {
      T[] nodes = this.GetNodes<T>(false);
      if (nodes.Length != 1)
        return default (T);
      else
        return nodes[0];
    }
  }
}
