// Type: OpenQuant.Shared.Data.Import.Realtime.CheckboxToolStripItem
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.Realtime
{
  internal class CheckboxToolStripItem : ToolStripControlHost
  {
    public bool Checked
    {
      get
      {
        return this.CheckBoxControl.Checked;
      }
      set
      {
        this.CheckBoxControl.Checked = value;
      }
    }

    public string CheckBoxText
    {
      get
      {
        return this.CheckBoxControl.Text;
      }
      set
      {
        this.CheckBoxControl.Text = value;
      }
    }

    private CheckBox CheckBoxControl
    {
      get
      {
        return (CheckBox) this.Control;
      }
    }

    public CheckboxToolStripItem()
      : base((Control) new CheckBox())
    {
      this.CheckBoxControl.Width = 120;
      this.CheckBoxControl.BackColor = Color.Transparent;
      this.Alignment = ToolStripItemAlignment.Right;
    }
  }
}
