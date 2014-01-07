// Type: OpenQuant.Projects.UI.Items.CodeNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Projects;
using OpenQuant.Shared.Compiler;
using System;

namespace OpenQuant.Projects.UI.Items
{
  internal class CodeNode : ObjectNode
  {
    private StrategySettings strategySettings;

    public override object Object
    {
      get
      {
        return (object) new StrategySettingsTypeDescriptor(this.strategySettings);
      }
    }

    public CodeNode(CodeLang codeLang, StrategySettings strategySettings)
      : base("Code")
    {
      this.strategySettings = strategySettings;
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
