using OpenQuant.API;
using FreeQuant.Providers;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace OpenQuant.API.Design
{
  internal class AltSourceTypeEditor : ObjectSelectorEditor
  {
    public override bool IsDropDownResizable
    {
      get
      {
        return true;
      }
    }

    protected override void FillTreeWithData(ObjectSelectorEditor.Selector selector, ITypeDescriptorContext context, IServiceProvider provider)
    {
      if (context != null && context.Instance != null)
      {
        AltIDGroup altIdGroup = (AltIDGroup) context.Instance;
        selector.Clear();
				foreach (IProvider provider1 in FreeQuant.Providers.ProviderManager.Providers)
          selector.AddNode(provider1.Name, (object) provider1.Name, (ObjectSelectorEditor.SelectorNode) null);
        selector.Sort();
        foreach (ObjectSelectorEditor.SelectorNode selectorNode in selector.Nodes)
        {
          if (selectorNode.value.Equals((object) altIdGroup.AltSource))
          {
            selector.SelectedNode = (TreeNode) selectorNode;
            break;
          }
        }
        selector.Width = 144;
      }
      else
        base.FillTreeWithData(selector, context, provider);
    }
  }
}
