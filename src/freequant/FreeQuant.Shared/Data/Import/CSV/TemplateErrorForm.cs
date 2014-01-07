// Type: SmartQuant.Shared.Data.Import.CSV.TemplateErrorForm
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class TemplateErrorForm : Form
  {
    private TextBox PjssPDW8Vg;
    private Button PywsAi5NGL;
    private Container h4asB9DHlf;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TemplateErrorForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.rbmsoIRySi();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.h4asB9DHlf != null)
        this.h4asB9DHlf.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void rbmsoIRySi()
    {
      this.PjssPDW8Vg = new TextBox();
      this.PywsAi5NGL = new Button();
      this.SuspendLayout();
      this.PjssPDW8Vg.BackColor = SystemColors.Window;
      this.PjssPDW8Vg.Location = new Point(8, 8);
      this.PjssPDW8Vg.Multiline = true;
      this.PjssPDW8Vg.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4482);
      this.PjssPDW8Vg.ReadOnly = true;
      this.PjssPDW8Vg.ScrollBars = ScrollBars.Both;
      this.PjssPDW8Vg.Size = new Size(440, 216);
      this.PjssPDW8Vg.TabIndex = 0;
      this.PjssPDW8Vg.Text = "";
      this.PjssPDW8Vg.WordWrap = false;
      this.PywsAi5NGL.DialogResult = DialogResult.Cancel;
      this.PywsAi5NGL.Location = new Point(200, 232);
      this.PywsAi5NGL.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4504);
      this.PywsAi5NGL.Size = new Size(72, 24);
      this.PywsAi5NGL.TabIndex = 1;
      this.PywsAi5NGL.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4518);
      this.AcceptButton = (IButtonControl) this.PywsAi5NGL;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.PywsAi5NGL;
      this.ClientSize = new Size(458, 269);
      this.Controls.Add((Control) this.PywsAi5NGL);
      this.Controls.Add((Control) this.PjssPDW8Vg);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4526);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4564);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetErrors(string[] lines)
    {
      this.PjssPDW8Vg.Clear();
      foreach (string str in lines)
        this.PjssPDW8Vg.AppendText(str + Environment.NewLine);
    }
  }
}
