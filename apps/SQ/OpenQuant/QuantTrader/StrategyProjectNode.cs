// Type: OpenQuant.QuantTrader.StrategyProjectNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Projects;

namespace OpenQuant.QuantTrader
{
  internal class StrategyProjectNode : ExportItemNode
  {
    public StrategyProject Project { get; private set; }

    public override bool AutoUncheckParent
    {
      get
      {
        return false;
      }
    }

    public StrategyProjectNode(StrategyProject project)
      : base(project.Name, 3)
    {
      this.Project = project;
    }
  }
}
