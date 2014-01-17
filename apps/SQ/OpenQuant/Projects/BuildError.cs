using OpenQuant.Shared.Compiler;
using System.CodeDom.Compiler;

namespace OpenQuant.Projects
{
  internal class BuildError : Error
  {
    public StrategyProject Project { get; private set; }

    public Solution Solution { get; private set; }

    public BuildError(CompilerError error)
    {
      base.\u002Ector(error);
    }

    public BuildError(StrategyProject project, CompilerError error)
      : this(error)
    {
      this.Project = project;
    }

    public BuildError(Solution solution, CompilerError error)
      : this(error)
    {
      this.Solution = solution;
    }
  }
}
