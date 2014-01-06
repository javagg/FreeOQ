// Type: OpenQuant.Finam.Design.ProxyUsingSelectorEditor
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

using OpenQuant.Finam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace OpenQuant.Finam.Design
{
  public class ProxyUsingSelectorEditor : ObjectSelectorEditor
  {
    public List<string> types = new List<string>()
    {
      "True",
      "False"
    };
    public static Transaq t;

    public override bool IsDropDownResizable
    {
      get
      {
        return true;
      }
    }

    protected override void FillTreeWithData(ObjectSelectorEditor.Selector selector, ITypeDescriptorContext context, IServiceProvider provider)
    {
      if (context == null || context.Instance == null)
        return;
      selector.Clear();
      foreach (string label in this.types)
        selector.AddNode(label, (object) label, (ObjectSelectorEditor.SelectorNode) null);
    }
  }
}
