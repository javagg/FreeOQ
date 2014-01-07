// Type: OpenQuant.Scripts.ScriptExplorerWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Shared.Compiler;
using OpenQuant.Shared.Options;
using OpenQuant.Shared.Scripts;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Scripts
{
  internal class ScriptExplorerWindow : ScriptExplorerWindow
  {
    private IContainer components;

    protected virtual BuildOptions BuildOptions
    {
      get
      {
        return Global.Options.Solutions.Build;
      }
    }

    protected virtual ScriptsOptions ScriptsOptions
    {
      get
      {
        return Global.Options.Solutions.Scripts;
      }
    }

    public ScriptExplorerWindow()
    {
      base.\u002Ector();
      this.InitializeComponent();
    }

    protected virtual void OpenEditor(FileInfo file)
    {
      Global.EditorManager.OpenScriptCode(file);
    }

    protected virtual string GetScriptCodeTemplate(CodeLang codeLang)
    {
      string str = string.Empty;
      try
      {
        str = File.ReadAllText(string.Format("{0}\\script{1}", (object) Global.Setup.Folders.Templates.FullName, (object) CodeHelper.GetFileExtension(codeLang)));
      }
      catch
      {
      }
      return str;
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
    }
  }
}
