using System;
using FreeQuant;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace OpenQuant.Shared
{
	public partial class AboutForm : Form
	{
		private const string KEY_USER = "User";
		private const string KEY_COMPANY = "Company";
		private const string KEY_COMMENT = "Comment";

		public string AssemblyTitle
		{
			get
			{   
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
				if (customAttributes.Length > 0)
				{
					AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute)customAttributes[0];
					if (assemblyTitleAttribute.Title != "")
						return assemblyTitleAttribute.Title;
				}
				return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
			}
		}

		public string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
			}
		}

		public string AssemblyDescription
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
				if (customAttributes.Length == 0)
					return "";
				else
					return ((AssemblyDescriptionAttribute)customAttributes[0]).Description;
			}
		}

		public string AssemblyProduct
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
				if (customAttributes.Length == 0)
					return "";
				else
					return ((AssemblyProductAttribute)customAttributes[0]).Product;
			}
		}

		public string AssemblyCopyright
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
				if (customAttributes.Length == 0)
					return "";
				else
					return ((AssemblyCopyrightAttribute)customAttributes[0]).Copyright;
			}
		}

		public string AssemblyCompany
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
				if (customAttributes.Length == 0)
					return "";
				else
					return ((AssemblyCompanyAttribute)customAttributes[0]).Company;
			}
		}

		public AboutForm()
		{
			this.InitializeComponent();
			this.Text = string.Format("About {0}", (object)Global.Setup.Product.Name);
			this.lblProductName.Text = Global.Setup.Product.Name;
			this.lblVersion.Text = string.Format("Version {0} {1}", (object)Global.Setup.Product.Version.ToString(3), Global.Setup.Product.Platform);
			this.lblCopyright.Text = Global.Setup.Product.Copyright;
			this.tbxDescription.Text = this.AssemblyDescription;
			LicenseInfo license = Framework.Installation.GetLicense();
			if (license.Licensed != null)
				this.tbxDescription.Text = string.Format("Licensed to:{0}  {1}{0}  {2}{0}{0}Comment:{0}  {3}", Environment.NewLine, (object)(((SortedList<string, string>)license.KeyValueList).ContainsKey("User") ? ((SortedList<string, string>)license.KeyValueList)["User"] : string.Empty), (object)(((SortedList<string, string>)license.KeyValueList).ContainsKey("Company") ? ((SortedList<string, string>)license.KeyValueList)["Company"] : string.Empty), (object)(((SortedList<string, string>)license.KeyValueList).ContainsKey("Comment") ? ((SortedList<string, string>)license.KeyValueList)["Comment"] : string.Empty));
			else
				this.tbxDescription.Text = "Unlicensed copy.";
			try
			{
				this.logoPictureBox.Image = (Image)Icon.ExtractAssociatedIcon(Application.ExecutablePath).ToBitmap();
			}
			catch
			{
			}
		}

        private void logoPictureBox_Click(object sender, EventArgs e)
        {

        }
	}
}
