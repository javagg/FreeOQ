using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace OpenQuant.Shared.Options
{
  internal class ScriptsOptionsPanel : OptionsPanel
  {
    private IContainer components;
    private GroupBox groupBox1;
    private ComboBox cbxApartmentState;

    public ScriptsOptionsPanel()
    {
      this.InitializeComponent();
    }

    protected override void OnInit()
    {
      this.cbxApartmentState.Items.Clear();
      this.cbxApartmentState.Items.Add((object) ApartmentState.STA);
      this.cbxApartmentState.Items.Add((object) ApartmentState.MTA);
      this.cbxApartmentState.SelectedItem = (object) ((ScriptsOptions) this.Options).ApartmentState;
    }

    protected override void OnCommitChanges()
    {
      ((ScriptsOptions) this.Options).ApartmentState = (ApartmentState) this.cbxApartmentState.SelectedItem;
      this.Options.Save();
    }

    private void cbxApartmentState_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.OptionsChanged = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupBox1 = new GroupBox();
      this.cbxApartmentState = new ComboBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.cbxApartmentState);
      this.groupBox1.Location = new Point(16, 16);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(368, 64);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Apartment State";
      this.cbxApartmentState.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxApartmentState.FormattingEnabled = true;
      this.cbxApartmentState.Location = new Point(16, 24);
      this.cbxApartmentState.Name = "cbxApartmentState";
      this.cbxApartmentState.Size = new Size(66, 21);
      this.cbxApartmentState.TabIndex = 2;
      this.cbxApartmentState.SelectedIndexChanged += new EventHandler(this.cbxApartmentState_SelectedIndexChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.groupBox1);
      this.Name = "ScriptsOptionsPanel";
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
