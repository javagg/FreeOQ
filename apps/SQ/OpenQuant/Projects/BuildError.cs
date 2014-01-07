// Type: OpenQuant.Projects.BuildError
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

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
