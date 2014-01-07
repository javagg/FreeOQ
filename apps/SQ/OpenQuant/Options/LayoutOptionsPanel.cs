// Type: OpenQuant.Options.LayoutOptionsPanel
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Shared.Options;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Options
{
  internal class LayoutOptionsPanel : LayoutOptionsPanel
  {
    private IContainer components;
    private GroupBox groupBox3;
    private CheckedListBox chbToolbars;

    public LayoutOptionsPanel()
    {
      base.\u002Ector();
      this.InitializeComponent();
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupBox3 = new GroupBox();
      this.chbToolbars = new CheckedListBox();
      this.groupBox3.SuspendLayout();
      ((Control) this).SuspendLayout();
      this.groupBox3.Controls.Add((Control) this.chbToolbars);
      this.groupBox3.Location = new Point(8, 235);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(384, 110);
      this.groupBox3.TabIndex = 4;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Toolbars";
      this.chbToolbars.CheckOnClick = true;
      this.chbToolbars.FormattingEnabled = true;
      this.chbToolbars.Location = new Point(16, 24);
      this.chbToolbars.Name = "chbToolbars";
      this.chbToolbars.Size = new Size(350, 79);
      this.chbToolbars.TabIndex = 0;
      this.chbToolbars.ItemCheck += new ItemCheckEventHandler(this.chbToolbars_ItemCheck);
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Control) this).Controls.Add((Control) this.groupBox3);
      ((Control) this).Name = "LayoutOptionsPanel";
      ((Control) this).Controls.SetChildIndex((Control) this.groupBox3, 0);
      this.groupBox3.ResumeLayout(false);
      ((Control) this).ResumeLayout(false);
    }

    protected virtual void OnInit()
    {
      base.OnInit();
      this.chbToolbars.BeginUpdate();
      this.chbToolbars.Items.Clear();
      ((ListBox.ObjectCollection) this.chbToolbars.Items).Add((object) new ToolbarItem(Global.Toolbar.File));
      ((ListBox.ObjectCollection) this.chbToolbars.Items).Add((object) new ToolbarItem(Global.Toolbar.Edit));
      ((ListBox.ObjectCollection) this.chbToolbars.Items).Add((object) new ToolbarItem(Global.Toolbar.View));
      ((ListBox.ObjectCollection) this.chbToolbars.Items).Add((object) new ToolbarItem(Global.Toolbar.Project));
      ((ListBox.ObjectCollection) this.chbToolbars.Items).Add((object) new ToolbarItem(Global.Toolbar.ProjectView));
      ((ListBox.ObjectCollection) this.chbToolbars.Items).Add((object) new ToolbarItem((ToolStrip) Global.Toolbar.Chart));
      ((ListBox.ObjectCollection) this.chbToolbars.Items).Add((object) new ToolbarItem((ToolStrip) Global.Toolbar.InstrumentList));
      for (int index = 0; index < this.chbToolbars.Items.Count; ++index)
        this.chbToolbars.SetItemChecked(index, (this.chbToolbars.Items[index] as ToolbarItem).ToolStrip.Visible);
      this.chbToolbars.EndUpdate();
    }

    private void chbToolbars_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      ToolStrip toolStrip = (this.chbToolbars.Items[e.Index] as ToolbarItem).ToolStrip;
      switch (e.NewValue)
      {
        case CheckState.Unchecked:
          toolStrip.Visible = false;
          break;
        case CheckState.Checked:
          toolStrip.Visible = true;
          break;
      }
    }
  }
}
