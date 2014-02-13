using OpenQuant.Shared.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Shared.ToolWindows
{
  public class OutputWindow : FreeQuant.Docking.WinForms.DockControl
  {
    private const string KEY_WORD_WRAP = "wordwrap";
    private const bool DEFAULT_WORD_WRAP = false;
    private IContainer components;
    private TextBox tbxOutput;
    private ContextMenuStrip ctxOutput;
    private ToolStripMenuItem ctxOutput_ClearOutput;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem ctxOutput_CopyToClipboard;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem ctxOutput_WordWrap;
    private TextWriter standardOut;

    public bool WordWrap
    {
      get
      {
        return this.Settings.GetBooleanValue("wordwrap", false);
      }
      set
      {
        if (this.WordWrap == value)
          return;
        this.Settings.SetValue("wordwrap", value);
        this.tbxOutput.WordWrap = value;
      }
    }

    public OutputWindow()
    {
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.tbxOutput = new TextBox();
      this.ctxOutput = new ContextMenuStrip(this.components);
      this.ctxOutput_CopyToClipboard = new ToolStripMenuItem();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.ctxOutput_WordWrap = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.ctxOutput_ClearOutput = new ToolStripMenuItem();
      this.ctxOutput.SuspendLayout();
      this.SuspendLayout();
      this.tbxOutput.BackColor = SystemColors.Window;
      this.tbxOutput.ContextMenuStrip = this.ctxOutput;
      this.tbxOutput.Dock = DockStyle.Fill;
      this.tbxOutput.Location = new Point(0, 0);
      this.tbxOutput.MaxLength = 0;
      this.tbxOutput.Multiline = true;
      this.tbxOutput.Name = "tbxOutput";
      this.tbxOutput.ReadOnly = true;
      this.tbxOutput.ScrollBars = ScrollBars.Both;
      this.tbxOutput.Size = new Size(566, 254);
      this.tbxOutput.TabIndex = 1;
      this.tbxOutput.WordWrap = false;
      this.ctxOutput.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.ctxOutput_CopyToClipboard,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.ctxOutput_WordWrap,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.ctxOutput_ClearOutput
      });
      this.ctxOutput.Name = "ctxOutput";
      this.ctxOutput.Size = new Size(174, 104);
      this.ctxOutput.Opening += new CancelEventHandler(this.ctxOutput_Opening);
      this.ctxOutput_CopyToClipboard.Image = (Image) Resources.clipboard;
      this.ctxOutput_CopyToClipboard.Name = "ctxOutput_CopyToClipboard";
      this.ctxOutput_CopyToClipboard.Size = new Size(173, 22);
      this.ctxOutput_CopyToClipboard.Text = "Copy To Clipboard";
      this.ctxOutput_CopyToClipboard.Click += new EventHandler(this.ctxOutput_CopyToClipboard_Click);
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new Size(170, 6);
      this.ctxOutput_WordWrap.CheckOnClick = true;
      this.ctxOutput_WordWrap.Name = "ctxOutput_WordWrap";
      this.ctxOutput_WordWrap.Size = new Size(173, 22);
      this.ctxOutput_WordWrap.Text = "Word Wrap";
      this.ctxOutput_WordWrap.Click += new EventHandler(this.ctxOutput_WordWrap_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(170, 6);
      this.ctxOutput_ClearOutput.Image = (Image) Resources.clear;
      this.ctxOutput_ClearOutput.Name = "ctxOutput_ClearOutput";
      this.ctxOutput_ClearOutput.Size = new Size(173, 22);
      this.ctxOutput_ClearOutput.Text = "Clear Output";
      this.ctxOutput_ClearOutput.Click += new EventHandler(this.ctxOutput_ClearOutput_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.Controls.Add((Control) this.tbxOutput);
      this.DefaultDockLocation = ContainerDockLocation.Bottom;
      this.Name = "OutputWindow";
      this.Size = new Size(566, 254);
      this.TabImage = (Image) Resources.output;
      this.Text = "Output";
      this.ctxOutput.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    protected override void OnInit()
    {
      this.standardOut = Console.Out;
      typeof (Console).GetField("_out", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.SetField).SetValue((object) typeof (Console), (object) new OutputWriter(this.tbxOutput));
      this.tbxOutput.WordWrap = this.WordWrap;
    }

    protected override void OnClosing(DockControlClosingEventArgs e)
    {
      Console.SetOut(this.standardOut);
      base.OnClosing(e);
    }

    public void ClearOutput()
    {
      this.tbxOutput.Clear();
    }

    private void ctxOutput_Opening(object sender, CancelEventArgs e)
    {
      this.ctxOutput_WordWrap.Checked = this.WordWrap;
    }

    private void ctxOutput_CopyToClipboard_Click(object sender, EventArgs e)
    {
      string text = this.tbxOutput.Text;
      if (string.IsNullOrEmpty(text))
        return;
      Clipboard.SetText(text, TextDataFormat.Text);
    }

    private void ctxOutput_WordWrap_Click(object sender, EventArgs e)
    {
      this.WordWrap = this.ctxOutput_WordWrap.Checked;
    }

    private void ctxOutput_ClearOutput_Click(object sender, EventArgs e)
    {
      this.ClearOutput();
    }
  }
}
