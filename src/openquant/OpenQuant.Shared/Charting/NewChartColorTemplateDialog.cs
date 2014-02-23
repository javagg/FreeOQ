using OpenQuant.Shared;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Charting
{
    partial class NewChartColorTemplateDialog : Form
    {
        private bool allowInput = true;

        public string TemplateName
        {
            get
            {
                return this.textBox1.Text;
            }
        }

        public NewChartColorTemplateDialog()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Global.ChartManager.ColorTemplates.Contains(this.TemplateName))
            {
                int num = (int)MessageBox.Show((IWin32Window)this, "Template with the same name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
                this.DialogResult = DialogResult.OK;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control || (e.KeyCode < Keys.A || e.KeyCode > Keys.Z) && (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && (e.KeyCode != Keys.Space && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete))
                this.allowInput = true;
            else
                this.allowInput = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = this.allowInput;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.button1.Enabled = this.textBox1.Text.Trim() != "";
        }
    }
}
