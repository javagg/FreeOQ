using OpenQuant.Shared.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Shared.ToolWindows
{
	public class PropertiesWindow : FreeQuant.Docking.WinForms.DockControl
  {
    private IContainer components;
    private PropertyGrid propertyGrid;

    public object PropertyObject
    {
      get
      {
        return this.propertyGrid.SelectedObject;
      }
      set
      {
        this.propertyGrid.SelectedObject = value;
      }
    }

    public event EventHandler PropertyValueChanged;

    public PropertiesWindow()
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
      this.SuspendLayout();
      this.propertyGrid.Dock = DockStyle.Fill;
      this.propertyGrid.Location = new Point(0, 0);
      this.propertyGrid.Name = "propertyGrid";
      this.propertyGrid.Size = new Size(250, 400);
      this.propertyGrid.TabIndex = 0;
      this.propertyGrid.PropertyValueChanged += new PropertyValueChangedEventHandler(this.propertyGrid_PropertyValueChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.propertyGrid);
      this.DefaultDockLocation = ContainerDockLocation.Right;
      this.Name = "PropertiesWindow";
      this.TabImage = (Image) Resources.properties;
      this.Text = "Properties";
      this.ResumeLayout(false);
    }

    private void propertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
    {
      if (this.PropertyValueChanged == null)
        return;
      this.PropertyValueChanged((object) this, EventArgs.Empty);
    }
  }
}
