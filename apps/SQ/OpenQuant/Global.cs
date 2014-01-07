// Type: OpenQuant.Global
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Flags;
using OpenQuant.Options;
using OpenQuant.Projects;
using OpenQuant.Scripts;
using OpenQuant.Shared;
using OpenQuant.Shared.Editor;
using OpenQuant.Shared.Options;
using OpenQuant.Shared.Scripts;
using System.Windows.Forms;

namespace OpenQuant
{
  internal class Global : Global
  {
    public static Form MainForm
    {
      get
      {
        return (Form) Global.GetObject<Form>("MAIN_FORM");
      }
      set
      {
        Global.SetObject("MAIN_FORM", (object) value);
      }
    }

    public static SetupInfo Setup
    {
      get
      {
        return (SetupInfo) Global.get_Setup();
      }
      set
      {
        Global.set_Setup((SetupInfo) value);
      }
    }

    public static OpenQuantOptions Options
    {
      get
      {
        return (OpenQuantOptions) Global.get_Options();
      }
      set
      {
        Global.set_Options((AppOptions) value);
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

    public Global()
    {
      base.\u002Ector();
    }
  }
}
