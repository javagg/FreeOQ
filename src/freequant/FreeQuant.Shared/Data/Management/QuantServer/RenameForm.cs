// Type: SmartQuant.Shared.Data.Management.QuantServer.RenameForm
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
  public class RenameForm : Form
  {
    private TextBox LClFAR8v9l;
    private Button OFhFBPvb4d;
    private Button VGNFcMsPoZ;
    private Container RkQFzSeLMZ;

    public string SeriesName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.LClFAR8v9l.Text.Trim();
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.LClFAR8v9l.Text = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RenameForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.oKCFo98fxs();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.RkQFzSeLMZ != null)
        this.RkQFzSeLMZ.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void oKCFo98fxs()
    {
      this.LClFAR8v9l = new TextBox();
      this.OFhFBPvb4d = new Button();
      this.VGNFcMsPoZ = new Button();
      this.SuspendLayout();
      this.LClFAR8v9l.Location = new Point(16, 16);
      this.LClFAR8v9l.MaxLength = (int) sbyte.MaxValue;
      this.LClFAR8v9l.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12454);
      this.LClFAR8v9l.Size = new Size(232, 20);
      this.LClFAR8v9l.TabIndex = 0;
      this.LClFAR8v9l.Text = "";
      this.LClFAR8v9l.TextChanged += new EventHandler(this.t4dFPp5j2N);
      this.OFhFBPvb4d.DialogResult = DialogResult.OK;
      this.OFhFBPvb4d.Location = new Point(104, 48);
      this.OFhFBPvb4d.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12484);
      this.OFhFBPvb4d.Size = new Size(64, 24);
      this.OFhFBPvb4d.TabIndex = 1;
      this.OFhFBPvb4d.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12498);
      this.VGNFcMsPoZ.DialogResult = DialogResult.Cancel;
      this.VGNFcMsPoZ.Location = new Point(176, 48);
      this.VGNFcMsPoZ.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12506);
      this.VGNFcMsPoZ.Size = new Size(64, 24);
      this.VGNFcMsPoZ.TabIndex = 2;
      this.VGNFcMsPoZ.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12528);
      this.AcceptButton = (IButtonControl) this.OFhFBPvb4d;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.VGNFcMsPoZ;
      this.ClientSize = new Size(264, 79);
      this.Controls.Add((Control) this.VGNFcMsPoZ);
      this.Controls.Add((Control) this.OFhFBPvb4d);
      this.Controls.Add((Control) this.LClFAR8v9l);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12544);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12568);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void t4dFPp5j2N([In] object obj0, [In] EventArgs obj1)
    {
      this.OFhFBPvb4d.Enabled = this.SeriesName != "";
    }
  }
}
