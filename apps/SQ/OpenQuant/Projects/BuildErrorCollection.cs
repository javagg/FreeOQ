// Type: OpenQuant.Projects.BuildErrorCollection
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared.Compiler;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;

namespace OpenQuant.Projects
{
  internal class BuildErrorCollection : List<BuildError>
  {
    public bool HasErrors
    {
      get
      {
        foreach (Error error in (List<BuildError>) this)
        {
          if (!error.get_IsWarning())
            return true;
        }
        return false;
      }
    }

    public bool HasWarnings
    {
      get
      {
        foreach (Error error in (List<BuildError>) this)
        {
          if (error.get_IsWarning())
            return true;
        }
        return false;
      }
    }

    public BuildErrorCollection()
    {
    }

    public BuildErrorCollection(CompilerErrorCollection collection)
    {
      foreach (CompilerError error in (CollectionBase) collection)
        this.Add(new BuildError(error));
    }

    public BuildErrorCollection(CompilerErrorCollection collection, StrategyProject project)
    {
      foreach (CompilerError error in (CollectionBase) collection)
        this.Add(new BuildError(project, error));
    }

    public BuildErrorCollection(CompilerErrorCollection collection, Solution solution)
    {
      foreach (CompilerError error in (CollectionBase) collection)
        this.Add(new BuildError(solution, error));
    }
  }
}
