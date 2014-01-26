using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FreeQuant.Trading.Design
{
  public abstract class ComboBoxTypeEditor : ObjectSelectorEditor
  {
    private bool BdDbx0JCT;
    protected object instance;

    public override bool IsDropDownResizable
    {
       get
      {
        return true;
      }
    }

    
		protected ComboBoxTypeEditor(bool allowNull):base()
    {
      this.BdDbx0JCT = allowNull;
    }

    protected abstract List<KeyValuePair<string, object>> GetItems();

    
    protected override void FillTreeWithData(ObjectSelectorEditor.Selector selector, ITypeDescriptorContext context, IServiceProvider provider)
    {
      if (context == null || context.Instance == null)
        return;
      this.instance = context.Instance;
      selector.Clear();
      if (this.BdDbx0JCT)
        selector.AddNode(USaG3GpjZagj1iVdv4u.Y4misFk9D9(424), (object) null, (ObjectSelectorEditor.SelectorNode) null);
      foreach (KeyValuePair<string, object> keyValuePair in this.GetItems())
        selector.AddNode(keyValuePair.Key, keyValuePair.Value, (ObjectSelectorEditor.SelectorNode) null);
      object obj = context.PropertyDescriptor.GetValue(context.Instance);
      if (obj == null && this.BdDbx0JCT)
      {
        selector.SelectedNode = selector.Nodes[0];
      }
      else
      {
        foreach (ObjectSelectorEditor.SelectorNode selectorNode in selector.Nodes)
        {
          if (selectorNode.value != null && selectorNode.value.Equals(obj))
          {
            selector.SelectedNode = (TreeNode) selectorNode;
            break;
          }
        }
      }
    }
  }
}
