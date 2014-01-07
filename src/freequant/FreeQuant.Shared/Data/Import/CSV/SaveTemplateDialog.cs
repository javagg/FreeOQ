// Type: SmartQuant.Shared.Data.Import.CSV.SaveTemplateDialog
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

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class SaveTemplateDialog : Form
  {
    private string[] xtiYeQG9Qr;
    private Label KlOYhdgnkW;
    private ComboBox cByYsi8jXg;
    private Button NvdYY4Ss8K;
    private Button pljYxFUBDK;
    private Container gdbYDM6qIK;

    public string TemplateName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.cByYsi8jXg.Text.Trim();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SaveTemplateDialog()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.KVBscRtiXM();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.gdbYDM6qIK != null)
        this.gdbYDM6qIK.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void KVBscRtiXM()
    {
      this.KlOYhdgnkW = new Label();
      this.cByYsi8jXg = new ComboBox();
      this.NvdYY4Ss8K = new Button();
      this.pljYxFUBDK = new Button();
      this.SuspendLayout();
      this.KlOYhdgnkW.Location = new Point(8, 8);
      this.KlOYhdgnkW.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4598);
      this.KlOYhdgnkW.Size = new Size(152, 24);
      this.KlOYhdgnkW.TabIndex = 0;
      this.KlOYhdgnkW.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4614);
      this.cByYsi8jXg.Location = new Point(32, 32);
      this.cByYsi8jXg.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4674);
      this.cByYsi8jXg.Size = new Size(160, 21);
      this.cByYsi8jXg.TabIndex = 1;
      this.cByYsi8jXg.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4694);
      this.cByYsi8jXg.TextChanged += new EventHandler(this.TD5sz3IZDx);
      this.NvdYY4Ss8K.DialogResult = DialogResult.OK;
      this.NvdYY4Ss8K.Location = new Point(40, 64);
      this.NvdYY4Ss8K.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4716);
      this.NvdYY4Ss8K.Size = new Size(72, 24);
      this.NvdYY4Ss8K.TabIndex = 2;
      this.NvdYY4Ss8K.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4730);
      this.pljYxFUBDK.DialogResult = DialogResult.Cancel;
      this.pljYxFUBDK.Location = new Point(120, 64);
      this.pljYxFUBDK.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4738);
      this.pljYxFUBDK.Size = new Size(64, 24);
      this.pljYxFUBDK.TabIndex = 3;
      this.pljYxFUBDK.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4760);
      this.AcceptButton = (IButtonControl) this.NvdYY4Ss8K;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.pljYxFUBDK;
      this.ClientSize = new Size(226, 103);
      this.Controls.Add((Control) this.pljYxFUBDK);
      this.Controls.Add((Control) this.NvdYY4Ss8K);
      this.Controls.Add((Control) this.cByYsi8jXg);
      this.Controls.Add((Control) this.KlOYhdgnkW);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.HelpButton = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4776);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4816);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNames(string[] names)
    {
      this.xtiYeQG9Qr = names;
      this.cByYsi8jXg.BeginUpdate();
      this.cByYsi8jXg.Items.Clear();
      foreach (object obj in names)
        this.cByYsi8jXg.Items.Add(obj);
      this.cByYsi8jXg.Text = "";
      this.cByYsi8jXg.EndUpdate();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnClosing(CancelEventArgs e)
    {
      string templateName = this.TemplateName;
      bool flag = false;
      foreach (string str in this.xtiYeQG9Qr)
      {
        if (str == templateName)
        {
          flag = true;
          break;
        }
      }
      if (flag)
      {
        if (MessageBox.Show(RNaihRhYEl0wUmAftnB.aYu7exFQKN(4858) + templateName + RNaihRhYEl0wUmAftnB.aYu7exFQKN(4902) + Environment.NewLine + RNaihRhYEl0wUmAftnB.aYu7exFQKN(4940), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
          e.Cancel = true;
      }
      base.OnClosing(e);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TD5sz3IZDx([In] object obj0, [In] EventArgs obj1)
    {
      this.NvdYY4Ss8K.Enabled = this.TemplateName != "";
    }
  }
}
