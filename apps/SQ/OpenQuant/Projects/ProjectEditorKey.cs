// Type: OpenQuant.Projects.ProjectEditorKey
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared.Editor;
using System.IO;

namespace OpenQuant.Projects
{
  internal class ProjectEditorKey : EditorKey
  {
    public StrategyProject Project { get; private set; }

    public ProjectEditorKey(FileInfo file, StrategyProject project)
    {
      base.\u002Ector(file);
      this.Project = project;
    }
  }
}
