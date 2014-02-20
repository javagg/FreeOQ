using OpenQuant.Shared.Compiler;
using OpenQuant.Shared.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Shared.ToolWindows
{
    public partial class ErrorListWindow : FreeQuant.Docking.WinForms.DockControl
  {
  
    public ErrorListWindow()
    {
      this.InitializeComponent();
    }

    public void SetErrors(Error[] errors)
    {
      this.ltvErrors.BeginUpdate();
      this.ltvErrors.Items.Clear();
      foreach (Error error in errors)
        this.ltvErrors.Items.Add((ListViewItem) new ErrorViewItem(error));
      this.ltvErrors.EndUpdate();
    }

    public void ClearErrors()
    {
      this.ltvErrors.Items.Clear();
    }

    public Error GetSelectedError()
    {
      if (this.ltvErrors.SelectedItems.Count > 0)
        return ((ErrorViewItem) this.ltvErrors.SelectedItems[0]).Error;
      else
        return (Error) null;
    }
  }
}
