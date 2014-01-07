// Type: OpenQuant.QuantTrader.ReferencesNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

namespace OpenQuant.QuantTrader
{
  internal class ReferencesNode : ExportItemNode
  {
    public override bool AutoCheckFromParent
    {
      get
      {
        return false;
      }
    }

    public override bool AutoUncheckParent
    {
      get
      {
        return false;
      }
    }

    public ReferencesNode()
      : base("References", 8, 9)
    {
      this.Checked = false;
    }
  }
}
