using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FreeQuant.FinChart
{
    public partial class PropertyForm : Form
    {
        public PropertyForm(object properties) : base()
        {

            this.InitializeComponent();
            this.propertyGrid.SelectedObject = properties;
        }
    }
}