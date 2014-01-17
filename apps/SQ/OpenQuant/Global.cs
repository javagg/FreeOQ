using OpenQuant.Flags;
using OpenQuant.Options;
using OpenQuant.Projects;
using OpenQuant.Scripts;
using OpenQuant.Shared;
//using OpenQuant.Shared.Editor;
//using OpenQuant.Shared.Options;
//using OpenQuant.Shared.Scripts;
using System.Windows.Forms;

namespace OpenQuant
{
  internal class Global : Global
  {
    public static Form MainForm
    {
      get
      {
        return Global.GetObject<Form>("MAIN_FORM");
      }
      set
      {
        Global.SetObject("MAIN_FORM", value);
      }
    }

    public static SetupInfo Setup
    {
      get
      {
				return Global.get_Setup();
      }
      set
      {
        Global.set_Setup(value);
      }
    }

    public static OpenQuantOptions Options
    {
      get
      {
        return Global.get_Options();
      }
      set
      {
        Global.set_Options(value);
      }
    }

    public static ProjectManager ProjectManager
    {
      get
      {
        return (ProjectManager) Global.GetObject<ProjectManager>();
      }
      set
      {
        Global.SetObject((object) value);
      }
    }

    public static EditorManager EditorManager
    {
      get
      {
        return (EditorManager) Global.get_EditorManager();
      }
      set
      {
        Global.set_EditorManager((EditorManager) value);
      }
    }

    public static ScriptManager ScriptManager
    {
      get
      {
        return (ScriptManager) Global.get_ScriptManager();
      }
      set
      {
        Global.set_ScriptManager((ScriptManager) value);
      }
    }

    public static ToolbarManager Toolbar
    {
      get
      {
        return (ToolbarManager) Global.GetObject<ToolbarManager>();
      }
      set
      {
        Global.SetObject((object) value);
      }
    }

    public static IDEFlags Flags
    {
      get
      {
        return (IDEFlags) Global.GetObject<IDEFlags>();
      }
      set
      {
        Global.SetObject((object) value);
      }
    }

	public Global() : base()
    {
    }
  }
}
