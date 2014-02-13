using OpenQuant.Shared.Compiler;
using System.Windows.Forms;

namespace OpenQuant.Shared.ToolWindows
{
  class ErrorViewItem : ListViewItem
  {
    public Error Error { get; private set; }

    public ErrorViewItem(Error error)
      : base(new string[4])
    {
      this.Error = error;
      this.SubItems[1].Text = error.Line.ToString();
      this.SubItems[2].Text = error.Column.ToString();
      this.SubItems[3].Text = error.Description;
      this.ImageIndex = error.IsWarning ? 1 : 0;
    }
  }
}
