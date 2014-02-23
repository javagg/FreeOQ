using OpenQuant.Shared.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Shared.ToolWindows
{
    public partial class PropertiesWindow : FreeQuant.Docking.WinForms.DockControl
    {
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

        private void propertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (this.PropertyValueChanged == null)
                return;
            this.PropertyValueChanged(this, EventArgs.Empty);
        }
    }
}
