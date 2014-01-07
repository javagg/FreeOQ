// Type: OpenQuant.Projects.UI.Items.ScenarioNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared.Compiler;
using System;

namespace OpenQuant.Projects.UI.Items
{
  internal class ScenarioNode : ObjectNode
  {
    public ScenarioNode(CodeLang codeLang)
      : base("Scenario")
    {
      this.nodeObject = (object) null;
      int num;
      switch (codeLang - 1)
      {
        case 0:
          num = 9;
          break;
        case 1:
          num = 10;
          break;
        default:
          throw new ArgumentException(string.Format("Unknown code language - {0}", (object) codeLang));
      }
      this.ImageIndex = this.SelectedImageIndex = num;
    }
  }
}
