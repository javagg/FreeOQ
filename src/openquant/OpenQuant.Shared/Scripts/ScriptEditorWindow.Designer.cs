namespace OpenQuant.Shared.Scripts
{
    public partial class ScriptEditorWindow
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbBuild;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRun;
        private System.Windows.Forms.ToolStripButton tsbStop;

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbBuild = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRun = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            this.textEditor.Braces.BracesOptions = QWhale.Editor.TextSource.BracesOptions.Highlight | QWhale.Editor.TextSource.BracesOptions.HighlightBounds | QWhale.Editor.TextSource.BracesOptions.TempHighlight;
            this.textEditor.Gutter.LineNumbersForeColor = System.Drawing.SystemColors.ControlText;
            this.textEditor.Location = new System.Drawing.Point(0, 25);
            this.textEditor.Outlining.AllowOutlining = true;
            this.textEditor.Size = new System.Drawing.Size(562, 419);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[4]
            {
                this.tsbBuild,
                this.toolStripSeparator1,
                this.tsbRun,
                this.tsbStop
            });
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(562, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            this.tsbBuild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuild.Image = OpenQuant.Shared.Properties.Resources.script_build;
            this.tsbBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuild.Name = "tsbBuild";
            this.tsbBuild.Size = new System.Drawing.Size(23, 22);
            this.tsbBuild.Text = "Build Script";
            this.tsbBuild.Click += new System.EventHandler(this.tsbBuild_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.tsbRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRun.Image = OpenQuant.Shared.Properties.Resources.script_run;
            this.tsbRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRun.Name = "tsbRun";
            this.tsbRun.Size = new System.Drawing.Size(23, 22);
            this.tsbRun.Text = "Run Script";
            this.tsbRun.Click += new System.EventHandler(this.tsbRun_Click);
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStop.Image = OpenQuant.Shared.Properties.Resources.script_stop;
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(23, 22);
            this.tsbStop.Text = "Stop Script";
            this.tsbStop.Click += new System.EventHandler(this.tsbStop_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip);
            this.Name = "ScriptEditorWindow";
            this.Size = new System.Drawing.Size(562, 444);
            this.Text = "ScriptEditorDocument";
            this.Controls.SetChildIndex(this.toolStrip, 0);
            this.Controls.SetChildIndex(this.textEditor, 0);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
