using System;

namespace OpenQuant.Shared.Updates
{
    public partial class ReleaseNotesControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.CheckBox chbDisplayAll;

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.chbDisplayAll = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.SuspendLayout();
            this.tabControl1.Controls.Add(this.tabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(300, 300);
            this.tabControl1.TabIndex = 0;
            this.tabPage.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage.Controls.Add(this.browser);
            this.tabPage.Controls.Add(this.chbDisplayAll);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(292, 274);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Release Notes";
            this.browser.AllowWebBrowserDrop = false;
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.IsWebBrowserContextMenuEnabled = false;
            this.browser.Location = new System.Drawing.Point(3, 3);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.ScriptErrorsSuppressed = true;
            this.browser.Size = new System.Drawing.Size(282, 240);
            this.browser.TabIndex = 0;
            this.browser.WebBrowserShortcutsEnabled = false;
            this.browser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.browser_Navigating);
            this.chbDisplayAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chbDisplayAll.Location = new System.Drawing.Point(3, 243);
            this.chbDisplayAll.Name = "chbDisplayAll";
            this.chbDisplayAll.Size = new System.Drawing.Size(282, 24);
            this.chbDisplayAll.TabIndex = 1;
            this.chbDisplayAll.Text = "Display all";
            this.chbDisplayAll.UseVisualStyleBackColor = true;
            this.chbDisplayAll.CheckedChanged += new EventHandler(this.chbDisplayAll_CheckedChanged);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ReleaseNotesControl";
            this.Size = new System.Drawing.Size(300, 300);
            this.tabControl1.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
