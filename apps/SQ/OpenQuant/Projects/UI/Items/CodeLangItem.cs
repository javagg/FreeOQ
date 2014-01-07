// Type: OpenQuant.Projects.UI.Items.CodeLangItem
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared.Compiler;
using System;

namespace OpenQuant.Projects.UI.Items
{
  internal class CodeLangItem
  {
    private CodeLang codeLang;

    public CodeLang CodeLang
    {
      get
      {
        return this.codeLang;
      }
    }

    public CodeLangItem(CodeLang codeLang)
    {
      this.codeLang = codeLang;
    }

    public override string ToString()
    {
      switch (this.codeLang - 1)
      {
        case 0:
          return "Visual C#";
        case 1:
          return "Visual Basic";
        default:
          throw new ArgumentException(string.Format("Not supported code language - {0}", (object) this.codeLang));
      }
    }
  }
}
