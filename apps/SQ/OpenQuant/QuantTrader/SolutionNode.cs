// Type: OpenQuant.QuantTrader.SolutionNode
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Projects;

namespace OpenQuant.QuantTrader
{
  internal class SolutionNode : ExportItemNode
  {
    public Solution Solution { get; private set; }

    public SolutionNode(Solution solution)
      : base(solution.Name, 2)
    {
      this.Solution = solution;
    }
  }
}
