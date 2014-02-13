using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Options
{
  internal class EditorOptionsPanel : OptionsPanel
  {
    private IContainer components;
    private GroupBox groupBox1;
    private PropertyGrid propertyGrid;

    public EditorOptionsPanel()
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
      this.groupBox1 = new GroupBox();
      this.propertyGrid = new PropertyGrid();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.propertyGrid);
      this.groupBox1.Location = new Point(16, 16);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(368, 328);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Settings";
      this.propertyGrid.Dock = DockStyle.Fill;
      this.propertyGrid.HelpVisible = false;
      this.propertyGrid.Location = new Point(3, 16);
      this.propertyGrid.Name = "propertyGrid";
      this.propertyGrid.Size = new Size(362, 309);
      this.propertyGrid.TabIndex = 0;
      this.propertyGrid.ToolbarVisible = false;
      this.propertyGrid.PropertyValueChanged += new PropertyValueChangedEventHandler(this.propertyGrid_PropertyValueChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.Controls.Add((Control) this.groupBox1);
      this.Name = "EditorOptionsPanel";
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    protected override void OnInit()
    {
      this.propertyGrid.SelectedObject = (object) this.Options;
    }

    protected override void OnCommitChanges()
    {
      this.Options.Save();
    }

    private void propertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
    {
      this.OptionsChanged = true;
    }
  }
}
