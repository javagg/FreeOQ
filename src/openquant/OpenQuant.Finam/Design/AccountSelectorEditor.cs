// Type: OpenQuant.Finam.Design.AccountSelectorEditor
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace OpenQuant.Finam.Design
{
  public class AccountSelectorEditor : ObjectSelectorEditor
  {
    public static List<string> clients = new List<string>();

    public override bool IsDropDownResizable
    {
      get
      {
        return true;
      }
    }

    static AccountSelectorEditor()
    {
    }

    protected override void FillTreeWithData(ObjectSelectorEditor.Selector selector, ITypeDescriptorContext context, IServiceProvider provider)
    {
      if (context == null || context.Instance == null)
        return;
      selector.Clear();
      if (AccountSelectorEditor.clients.Count <= 0)
        return;
      foreach (string label in AccountSelectorEditor.clients)
        selector.AddNode(label, (object) label, (ObjectSelectorEditor.SelectorNode) null);
      selector.Sort();
    }
  }
}
