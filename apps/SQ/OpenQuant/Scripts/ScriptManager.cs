// Type: OpenQuant.Scripts.ScriptManager
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Projects;
using OpenQuant.Projects.UI;
using OpenQuant.Shared;
using OpenQuant.Shared.Compiler;
using OpenQuant.Shared.Scripts;
using System.CodeDom.Compiler;
using System.IO;

namespace OpenQuant.Scripts
{
  internal class ScriptManager : ScriptManager
  {
    public ScriptManager()
    {
      base.\u002Ector(Global.Setup.Folders.Scripts, new FileInfo(string.Format("{0}\\scripts.config.xml", (object) Global.Setup.Folders.Ini.FullName)));
    }

    protected virtual void OnBuildErrors(CompilerErrorCollection errors)
    {
      Global.get_ToolWindowManager().SetErrors<ErrorListWindow>((Error[]) new BuildErrorCollection(errors).ToArray());
      if (!errors.HasErrors)
        return;
      Global.get_ToolWindowManager().ShowErrorList<ErrorListWindow>();
    }
  }
}
