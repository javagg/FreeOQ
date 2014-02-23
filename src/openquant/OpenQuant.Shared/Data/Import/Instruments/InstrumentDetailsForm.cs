using FreeQuant.FIX;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.Instruments
{
  internal class InstrumentDetailsForm : Form
  {
        private IContainer components = null;
    private PropertyGrid propertyGrid;
    private Panel panel1;
    private Button btnClose;
    private FIXSecurityDefinition definition;

    public InstrumentDetailsForm()
    {
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.propertyGrid = new PropertyGrid();
      this.panel1 = new Panel();
      this.btnClose = new Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.propertyGrid.Dock = DockStyle.Fill;
      this.propertyGrid.HelpVisible = false;
      this.propertyGrid.Location = new Point(0, 0);
      this.propertyGrid.Name = "propertyGrid";
      this.propertyGrid.Size = new Size(270, 326);
      this.propertyGrid.TabIndex = 0;
      this.propertyGrid.ToolbarVisible = false;
      this.panel1.Controls.Add((Control) this.btnClose);
      this.panel1.Dock = DockStyle.Bottom;
      this.panel1.Location = new Point(0, 326);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(270, 48);
      this.panel1.TabIndex = 1;
      this.btnClose.Anchor = AnchorStyles.Top;
      this.btnClose.DialogResult = DialogResult.Cancel;
      this.btnClose.Location = new Point(98, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(70, 24);
      this.btnClose.TabIndex = 0;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnClose;
      this.ClientSize = new Size(270, 374);
      this.Controls.Add((Control) this.propertyGrid);
      this.Controls.Add((Control) this.panel1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "InstrumentDetailsForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Instrument Details";
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public void Init(FIXSecurityDefinition definition)
    {
      this.definition = definition;
    }

    protected override void OnShown(EventArgs e)
    {
      this.propertyGrid.SelectedObject = (object) new SecurityDefinitionTypeDescriptor(this.definition);
      base.OnShown(e);
    }
  }
}
