using OpenQuant.Shared.Properties;
using FreeQuant;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared
{
	public partial class SplashScreen : Form
	{
        public bool HasError { get; private set; }

		public SplashScreen()
		{
			this.InitializeComponent();
		}
        
		protected override void OnShown(EventArgs e)
		{
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += new DoWorkEventHandler(this.worker_DoWork);
			backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
			backgroundWorker.RunWorkerAsync();
			base.OnShown(e);
		}

		private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null)
			{
				MessageBox.Show(this, e.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.HasError = true;
			}
			else
				this.HasError = false;
			this.Close();
		}

		private void worker_DoWork(object sender, DoWorkEventArgs e)
		{
			this.OnDoWork(sender, e);
		}

		protected virtual void OnDoWork(object sender, DoWorkEventArgs e)
		{
		}

		protected void SetProgressText(string text)
		{
			this.lblProgress.Invoke((Action)(() => this.lblProgress.Text = text));
		}

		protected void AddPlugin(string assemblyName, string typeName, bool x64Supported)
		{
			foreach (Plugin plugin in (ReadOnlyCollectionBase) Framework.Configuration.Plugins)
			{
				if (plugin.AssemblyName == assemblyName && plugin.TypeName == typeName)
					return;
			}
			Framework.Configuration.AddPlugin(new Plugin(assemblyName, typeName, true, x64Supported));
		}

		protected void RemovePlugin(string assemblyName, string typeName)
		{
			foreach (Plugin plugin in (ReadOnlyCollectionBase) Framework.Configuration.Plugins)
			{
				if (plugin.AssemblyName == assemblyName && plugin.TypeName == typeName)
				{
					Framework.Configuration.RemovePlugin(plugin);
					break;
				}
			}
		}

		protected void EnablePlugin(string assemblyName, string typeName, bool enable)
		{
			foreach (Plugin plugin in (ReadOnlyCollectionBase) Framework.Configuration.Plugins)
			{
				if (plugin.AssemblyName == assemblyName && plugin.TypeName == typeName)
				{
                    plugin.Enabled = enable;
					break;
				}
			}
		}
	}
}
