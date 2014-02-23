namespace OpenQuant.Shared.ToolWindows
{
    public partial class OutputWindow
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.ContextMenuStrip ctxOutput;
        private System.Windows.Forms.ToolStripMenuItem ctxOutput_ClearOutput;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ctxOutput_CopyToClipboard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctxOutput_WordWrap;
        private System.IO.TextWriter standardOut;

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components =new System.ComponentModel.Container();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.ctxOutput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxOutput_CopyToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxOutput_WordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxOutput_ClearOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxOutput.SuspendLayout();
            this.SuspendLayout();
            this.tbxOutput.BackColor = System.Drawing.SystemColors.Window;
            this.tbxOutput.ContextMenuStrip = this.ctxOutput;
            this.tbxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxOutput.Location = new System.Drawing.Point(0, 0);
            this.tbxOutput.MaxLength = 0;
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ReadOnly = true;
            this.tbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxOutput.Size = new System.Drawing.Size(566, 254);
            this.tbxOutput.TabIndex = 1;
            this.tbxOutput.WordWrap = false;
            this.ctxOutput.Items.AddRange(new System.Windows.Forms.ToolStripItem[5]
            {
                this.ctxOutput_CopyToClipboard,
                this.toolStripSeparator2,
                this.ctxOutput_WordWrap,
                this.toolStripSeparator1,
                this.ctxOutput_ClearOutput
            });
            this.ctxOutput.Name = "ctxOutput";
            this.ctxOutput.Size = new System.Drawing.Size(174, 104);
            this.ctxOutput.Opening += new System.ComponentModel.CancelEventHandler(this.ctxOutput_Opening);
            this.ctxOutput_CopyToClipboard.Image = OpenQuant.Shared.Properties.Resources.clipboard;
            this.ctxOutput_CopyToClipboard.Name = "ctxOutput_CopyToClipboard";
            this.ctxOutput_CopyToClipboard.Size = new System.Drawing.Size(173, 22);
            this.ctxOutput_CopyToClipboard.Text = "Copy To Clipboard";
            this.ctxOutput_CopyToClipboard.Click += new System.EventHandler(this.ctxOutput_CopyToClipboard_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            this.ctxOutput_WordWrap.CheckOnClick = true;
            this.ctxOutput_WordWrap.Name = "ctxOutput_WordWrap";
            this.ctxOutput_WordWrap.Size = new System.Drawing.Size(173, 22);
            this.ctxOutput_WordWrap.Text = "Word Wrap";
            this.ctxOutput_WordWrap.Click += new System.EventHandler(this.ctxOutput_WordWrap_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            this.ctxOutput_ClearOutput.Image =  OpenQuant.Shared.Properties.Resources.clear;
            this.ctxOutput_ClearOutput.Name = "ctxOutput_ClearOutput";
            this.ctxOutput_ClearOutput.Size = new System.Drawing.Size(173, 22);
            this.ctxOutput_ClearOutput.Text = "Clear Output";
            this.ctxOutput_ClearOutput.Click += new System.EventHandler(this.ctxOutput_ClearOutput_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            this.Controls.Add( this.tbxOutput);
            this.DefaultDockLocation = TD.SandDock.ContainerDockLocation.Bottom;
            this.Name = "OutputWindow";
            this.Size = new System.Drawing.Size(566, 254);
            this.TabImage =  OpenQuant.Shared.Properties.Resources.output;
            this.Text = "Output";
            this.ctxOutput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
