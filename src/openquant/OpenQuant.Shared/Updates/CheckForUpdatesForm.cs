using OpenQuant.Shared;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace OpenQuant.Shared.Updates
{
    public partial class CheckForUpdatesForm : Form
    {
        private string uri;

        public CheckForUpdatesForm()
        {
            this.InitializeComponent();
        }

        public void Init(string uri)
        {
            this.uri = uri;
        }

        protected override void OnLoad(EventArgs e)
        {
            this.Text = string.Format("{0} - Updates", (object)Global.Setup.Product.Name);
            this.lblStatus.Text = "Checking for updates...";
            this.ctrReleases.Visible = false;
            this.btnClose.Visible = false;
            this.Height = 144;
            base.OnLoad(e);
        }

        protected override void OnShown(EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.CheckThread));
            base.OnShown(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = !this.btnClose.Visible;
            base.OnFormClosing(e);
        }

        private void CheckThread(object state)
        {
            try
            {
                ReleaseInfo[] releases = new UpdateManager().GetReleases(this.uri);
                Version version = releases.Length == 0 ? new Version(0, 0) : releases[0].Version;
                Version userVersion = Global.Setup.Product.Version;
                if (version > userVersion)
                    this.Invoke((Action)(() =>
                    {
                        this.lblStatus.Text = string.Format("You are currently using version {0}", (object)userVersion.ToString(3));
                        this.progressBar.Visible = false;
                        this.ctrReleases.Init(userVersion, releases);
                        this.ctrReleases.Visible = true;
                        this.btnClose.Visible = true;
                        if (this.Height >= 360)
                            return;
                        CheckForUpdatesForm temp_91 = this;
                        int temp_100 = temp_91.Top - (360 - this.Height) / 2;
                        temp_91.Top = temp_100;
                        if (this.Top < 0)
                            this.Top = 0;
                        this.Height = 360;
                    }));
                else
                    this.Invoke((Action)(() =>
                    {
                        this.lblStatus.Text = string.Format("You are currently using version {0}. No newer version available.", (object)userVersion.ToString(3));
                        this.progressBar.Visible = false;
                        this.btnClose.Visible = true;
                    }));
            }
            catch (Exception ex)
            {
                CheckForUpdatesForm checkForUpdatesForm = this;
                this.Invoke((Action)(() =>
                {
                    checkForUpdatesForm.lblStatus.Text = "Error checking for updates.";
                    checkForUpdatesForm.progressBar.Visible = false;
                    int temp_144 = (int)MessageBox.Show((IWin32Window)checkForUpdatesForm, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    checkForUpdatesForm.btnClose.Visible = true;
                    checkForUpdatesForm.Close();
                }));
            }
        }

        private void ctrReleases_DownloadRequested(object sender, UriEventArgs args)
        {
            try
            {
                Process.Start(args.Uri.AbsoluteUri);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
