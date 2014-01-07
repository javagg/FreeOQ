// Type: OpenQuant.QuantTrader.StrategyPropertyNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Projects;

namespace OpenQuant.QuantTrader
{
  internal class StrategyPropertyNode : ExportItemNode
  {
    public StrategyProperty Property { get; private set; }

    public StrategyPropertyNode(StrategyProperty property)
      : base(string.Format("{0} ({1})", (object) property.Name, property.Value), 7)
    {
      this.Property = property;
    }
  }
}
