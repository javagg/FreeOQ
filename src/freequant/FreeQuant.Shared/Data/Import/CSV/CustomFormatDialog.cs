// Type: SmartQuant.Shared.Data.Import.CSV.CustomFormatDialog
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class CustomFormatDialog : Form
  {
    private const string ljfxhG366w = "datetime.formats.htm";
    private Process lrWxshXtQ8;
    private Label oVjxY6uFNi;
    private TextBox dsMxxv1x56;
    private Button eLmxDZDYdB;
    private Button Xnyx12pX9y;
    private LinkLabel FGQxdMdVcc;
    private Container vE2xFJItiH;

    public string Format
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.dsMxxv1x56.Text.Trim();
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.dsMxxv1x56.Text = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CustomFormatDialog()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.xJVYPgi6w3();
      this.lrWxshXtQ8 = (Process) null;
      this.a5ZYcgIVdO();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.vE2xFJItiH != null)
        this.vE2xFJItiH.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void xJVYPgi6w3()
    {
      this.oVjxY6uFNi = new Label();
      this.dsMxxv1x56 = new TextBox();
      this.eLmxDZDYdB = new Button();
      this.Xnyx12pX9y = new Button();
      this.FGQxdMdVcc = new LinkLabel();
      this.SuspendLayout();
      this.oVjxY6uFNi.Location = new Point(8, 8);
      this.oVjxY6uFNi.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(5514);
      this.oVjxY6uFNi.Size = new Size(216, 40);
      this.oVjxY6uFNi.TabIndex = 0;
      this.oVjxY6uFNi.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(5530);
      this.dsMxxv1x56.Location = new Point(16, 72);
      this.dsMxxv1x56.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(5686);
      this.dsMxxv1x56.Size = new Size(232, 20);
      this.dsMxxv1x56.TabIndex = 1;
      this.dsMxxv1x56.Text = "";
      this.dsMxxv1x56.TextChanged += new EventHandler(this.lRHYA9rr5L);
      this.eLmxDZDYdB.DialogResult = DialogResult.OK;
      this.eLmxDZDYdB.Location = new Point(40, 104);
      this.eLmxDZDYdB.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(5708);
      this.eLmxDZDYdB.Size = new Size(80, 24);
      this.eLmxDZDYdB.TabIndex = 2;
      this.eLmxDZDYdB.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(5722);
      this.Xnyx12pX9y.DialogResult = DialogResult.Cancel;
      this.Xnyx12pX9y.Location = new Point(136, 104);
      this.Xnyx12pX9y.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(5730);
      this.Xnyx12pX9y.Size = new Size(80, 24);
      this.Xnyx12pX9y.TabIndex = 3;
      this.Xnyx12pX9y.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(5752);
      this.FGQxdMdVcc.Location = new Point(184, 48);
      this.FGQxdMdVcc.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(5768);
      this.FGQxdMdVcc.Size = new Size(72, 16);
      this.FGQxdMdVcc.TabIndex = 4;
      this.FGQxdMdVcc.TabStop = true;
      this.FGQxdMdVcc.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(5786);
      this.FGQxdMdVcc.LinkClicked += new LinkLabelLinkClickedEventHandler(this.LsAYBqVUCO);
      this.AcceptButton = (IButtonControl) this.eLmxDZDYdB;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.Xnyx12pX9y;
      this.ClientSize = new Size(266, 143);
      this.Controls.Add((Control) this.FGQxdMdVcc);
      this.Controls.Add((Control) this.Xnyx12pX9y);
      this.Controls.Add((Control) this.eLmxDZDYdB);
      this.Controls.Add((Control) this.dsMxxv1x56);
      this.Controls.Add((Control) this.oVjxY6uFNi);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(5812);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(5852);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void lRHYA9rr5L([In] object obj0, [In] EventArgs obj1)
    {
      this.a5ZYcgIVdO();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LsAYBqVUCO([In] object obj0, [In] LinkLabelLinkClickedEventArgs obj1)
    {
      if (this.lrWxshXtQ8 == null)
      {
        string fileName = Framework.Installation.HelpDir.FullName + RNaihRhYEl0wUmAftnB.aYu7exFQKN(5882);
        try
        {
          this.lrWxshXtQ8 = Process.Start(fileName);
          this.lrWxshXtQ8.EnableRaisingEvents = true;
          this.lrWxshXtQ8.Exited += new EventHandler(this.mvixeS72lg);
        }
        catch (Exception ex)
        {
          if (SmartQuant.Trace.IsLevelEnabled(SmartQuant.TraceLevel.Error))
            SmartQuant.Trace.WriteLine(((object) ex).ToString());
          int num = (int) MessageBox.Show((IWin32Window) this, RNaihRhYEl0wUmAftnB.aYu7exFQKN(5928) + fileName, RNaihRhYEl0wUmAftnB.aYu7exFQKN(5980), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
        CustomFormatDialog.GUrYzUGLAo(this.lrWxshXtQ8.MainWindowHandle);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void a5ZYcgIVdO()
    {
      this.eLmxDZDYdB.Enabled = this.Format != "";
    }

    [DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
    private static bool GUrYzUGLAo([In] IntPtr obj0);

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void mvixeS72lg([In] object obj0, [In] EventArgs obj1)
    {
      this.lrWxshXtQ8 = (Process) null;
    }
  }
}
