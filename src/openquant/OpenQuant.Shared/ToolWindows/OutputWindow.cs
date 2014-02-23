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
  public partial class OutputWindow : FreeQuant.Docking.WinForms.DockControl
  {
    private const string KEY_WORD_WRAP = "wordwrap";
    private const bool DEFAULT_WORD_WRAP = false;
 

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
