// Type: OpenQuant.QuantTrader.ReferenceNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared.Compiler;

namespace OpenQuant.QuantTrader
{
  internal class ReferenceNode : ExportItemNode
  {
    public BuildReference Reference { get; private set; }

    public ReferenceNode(BuildReference reference)
      : base(reference.get_Name(), 10)
    {
      this.Reference = reference;
      this.Checked = false;
    }
  }
}
