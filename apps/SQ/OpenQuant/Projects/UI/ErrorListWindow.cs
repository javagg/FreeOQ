// Type: OpenQuant.Projects.UI.ErrorListWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Projects;
using OpenQuant.Shared.ToolWindows;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI
{
  internal class ErrorListWindow : ErrorListWindow
  {
    private IContainer components;

    public ErrorListWindow()
    {
      base.\u002Ector();
      this.InitializeComponent();
    }

    private void ltvErrors_DoubleClick(object sender, EventArgs e)
    {
      BuildError buildError = (BuildError) this.GetSelectedError();
      if (buildError == null || buildError.get_Line() <= 0)
        return;
      Global.EditorManager.MoveTo(buildError.Project, buildError.Solution, buildError.get_FileName(), buildError.get_Line(), buildError.get_Column());
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ((Control) this).SuspendLayout();
      ((Control) this.ltvErrors).DoubleClick += new EventHandler(this.ltvErrors_DoubleClick);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((Control) this).Name = "ErrorListWindow";
      ((Control) this).ResumeLayout(false);
      ((Control) this).PerformLayout();
    }
  }
}
