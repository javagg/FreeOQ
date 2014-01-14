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
	public ScriptManager() :  base(Global.Setup.Folders.Scripts, new FileInfo(string.Format("{0}\\scripts.config.xml", Global.Setup.Folders.Ini.FullName)))

    {
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
