// Type: OpenQuant.EditorManager
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Projects;
using OpenQuant.Projects.UI;
using OpenQuant.Scripts;
using OpenQuant.Shared.Editor;
using System;
using System.IO;

namespace OpenQuant
{
  internal class EditorManager : EditorManager
  {
    public EditorManager()
    {
      base.\u002Ector();
    }

    public void OpenProjectCode(FileInfo file, StrategyProject project)
    {
      this.Open(typeof (ProjectEditorWindow), (EditorKey) new ProjectEditorKey(file, project));
    }

    public void OpenScenarioCode(FileInfo file, Solution solution)
    {
      this.Open(typeof (ProjectEditorWindow), (EditorKey) new SolutionEditorKey(file, solution));
    }

    public void OpenScriptCode(FileInfo file)
    {
      this.Open(typeof (ScriptEditorWindow), (EditorKey) new ScriptEditorKey(file));
    }

    public void MoveTo(StrategyProject project, Solution solution, string filename, int line, int column)
    {
      Type type;
      EditorKey editorKey;
      if (project == null)
      {
        if (solution == null)
        {
          type = typeof (ScriptEditorWindow);
          editorKey = (EditorKey) new ScriptEditorKey(new FileInfo(filename));
        }
        else
        {
          type = typeof (ProjectEditorWindow);
          editorKey = (EditorKey) new SolutionEditorKey(new FileInfo(filename), solution);
        }
      }
      else
      {
        type = typeof (ProjectEditorWindow);
        editorKey = (EditorKey) new ProjectEditorKey(new FileInfo(filename), project);
      }
      base.MoveTo(type, editorKey, line, column);
    }

    public void MoveTo(StrategyProject project, string filename, string methodName, string[] methodDefinition)
    {
      base.MoveTo(typeof (ProjectEditorWindow), (EditorKey) new ProjectEditorKey(new FileInfo(filename), project), methodName, methodDefinition);
    }
  }
}
