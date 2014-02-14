//using OpenQuant.Shared.Properties;
using FreeQuant;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared
{
    public partial class DemoDialog : Form
	{
		public DemoDialog()
		{
			this.InitializeComponent();
			LicenseInfo license = Framework.Installation.GetLicense();
			this.lblProductInfo.Text = string.Format("You are using an unlicensed copy of {0}.", Global.Setup.Product.Name);
			this.lblDemoMessage.Text = string.Format("Demo will expire in {0} day(s).", (license.EvaluationTime - license.EvaluationTimeCurrent + 1));
			this.Text = string.Format("{0} (unlicensed copy)", Global.Setup.Product.Name);
			try
			{
				this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			}
			catch
			{
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
