// Type: SmartQuant.Shared.Data.Management.QuantServer.NewSeriesDialog
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Management.QuantServer
{
  public class NewSeriesDialog : Form
  {
    private Label ByjhmxERlA;
    private TextBox O80hwRDkUM;
    private Button xQwh0jIAXV;
    private Button Wd3hphIWZD;
    private Label JlMhN3NeC4;
    private TextBox fIVhtLYq3I;
    private Container UuvhEG9xTM;

    public string SeriesName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.O80hwRDkUM.Text.Trim();
      }
    }

    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fIVhtLYq3I.Text.Trim();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NewSeriesDialog(string filename)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.AJ4hXB33BN();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.UuvhEG9xTM != null)
        this.UuvhEG9xTM.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AJ4hXB33BN()
    {
      this.ByjhmxERlA = new Label();
      this.O80hwRDkUM = new TextBox();
      this.xQwh0jIAXV = new Button();
      this.Wd3hphIWZD = new Button();
      this.JlMhN3NeC4 = new Label();
      this.fIVhtLYq3I = new TextBox();
      this.SuspendLayout();
      this.ByjhmxERlA.Location = new Point(8, 16);
      this.ByjhmxERlA.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2588);
      this.ByjhmxERlA.Size = new Size(72, 16);
      this.ByjhmxERlA.TabIndex = 2;
      this.ByjhmxERlA.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2604);
      this.ByjhmxERlA.TextAlign = ContentAlignment.MiddleLeft;
      this.O80hwRDkUM.Location = new Point(88, 16);
      this.O80hwRDkUM.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2630);
      this.O80hwRDkUM.Size = new Size(184, 20);
      this.O80hwRDkUM.TabIndex = 0;
      this.O80hwRDkUM.Text = "";
      this.O80hwRDkUM.TextChanged += new EventHandler(this.KtahKYPG7L);
      this.xQwh0jIAXV.DialogResult = DialogResult.OK;
      this.xQwh0jIAXV.Enabled = false;
      this.xQwh0jIAXV.Location = new Point(96, 80);
      this.xQwh0jIAXV.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2660);
      this.xQwh0jIAXV.Size = new Size(80, 24);
      this.xQwh0jIAXV.TabIndex = 4;
      this.xQwh0jIAXV.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2674);
      this.Wd3hphIWZD.DialogResult = DialogResult.Cancel;
      this.Wd3hphIWZD.Location = new Point(184, 80);
      this.Wd3hphIWZD.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2682);
      this.Wd3hphIWZD.Size = new Size(80, 24);
      this.Wd3hphIWZD.TabIndex = 5;
      this.Wd3hphIWZD.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2704);
      this.JlMhN3NeC4.Location = new Point(8, 48);
      this.JlMhN3NeC4.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2720);
      this.JlMhN3NeC4.Size = new Size(72, 16);
      this.JlMhN3NeC4.TabIndex = 6;
      this.JlMhN3NeC4.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2736);
      this.JlMhN3NeC4.TextAlign = ContentAlignment.MiddleLeft;
      this.fIVhtLYq3I.Location = new Point(88, 48);
      this.fIVhtLYq3I.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2762);
      this.fIVhtLYq3I.Size = new Size(184, 20);
      this.fIVhtLYq3I.TabIndex = 7;
      this.fIVhtLYq3I.Text = "";
      this.AcceptButton = (IButtonControl) this.xQwh0jIAXV;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.Wd3hphIWZD;
      this.ClientSize = new Size(282, 119);
      this.Controls.Add((Control) this.fIVhtLYq3I);
      this.Controls.Add((Control) this.JlMhN3NeC4);
      this.Controls.Add((Control) this.Wd3hphIWZD);
      this.Controls.Add((Control) this.xQwh0jIAXV);
      this.Controls.Add((Control) this.O80hwRDkUM);
      this.Controls.Add((Control) this.ByjhmxERlA);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2794);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2828);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void KtahKYPG7L([In] object obj0, [In] EventArgs obj1)
    {
      this.xQwh0jIAXV.Enabled = this.SeriesName != "";
    }
  }
}
