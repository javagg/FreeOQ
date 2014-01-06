// Type: SmartQuant.Trading.Design.ComboBoxTypeEditor
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SlN8f6pWyHStvuMgWbM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SmartQuant.Trading.Design
{
  public abstract class ComboBoxTypeEditor : ObjectSelectorEditor
  {
    private bool BdDbx0JCT;
    protected object instance;

    public override bool IsDropDownResizable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return true;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ComboBoxTypeEditor(bool allowNull)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.BdDbx0JCT = allowNull;
    }

    protected abstract List<KeyValuePair<string, object>> GetItems();

    [MethodImpl(MethodImplOptions.NoInlining)]
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
