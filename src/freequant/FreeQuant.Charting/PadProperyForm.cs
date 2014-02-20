using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace FreeQuant.Charting
{
    public partial class PadProperyForm : Form
    {
        private object KtO3rBrbaI;
        private Pad evD3c4dHMV;

        public PadProperyForm(object Object, Pad Pad) : base()
        {
            this.InitializeComponent();
            this.KtO3rBrbaI = Object;
            this.evD3c4dHMV = Pad;
            this.Text = Object.GetType().Name + "Pad";
            this.propertyGrid.SelectedObject = Object;
        }

        private void mV134Z7kpS(object obj0, PropertyValueChangedEventArgs obj1)
        {
            this.evD3c4dHMV.Update();
        }
    }
}
