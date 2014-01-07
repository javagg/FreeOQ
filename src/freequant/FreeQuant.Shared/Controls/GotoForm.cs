// Type: SmartQuant.Shared.Controls.GotoForm
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Controls
{
  public class GotoForm : Form
  {
    private Button J1QbIxa4HC;
    private Button PkGbSK4ODC;
    private RadioButton V73bUwIIkx;
    private RadioButton h1JbjuirwP;
    private NumericUpDown CTub6s4Dwb;
    private DateTimePicker Y8lbrOUkOu;
    private Container AJJb8yNTA8;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GotoForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.jwHbfAxeFI();
      this.Y8lbrOUkOu.CustomFormat = DateTimeFormatInfo.CurrentInfo.ShortDatePattern + RNaihRhYEl0wUmAftnB.aYu7exFQKN(13846) + DateTimeFormatInfo.CurrentInfo.LongTimePattern;
      this.V73bUwIIkx.Checked = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.AJJb8yNTA8 != null)
        this.AJJb8yNTA8.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void jwHbfAxeFI()
    {
      ResourceManager resourceManager = new ResourceManager(typeof (GotoForm));
      this.J1QbIxa4HC = new Button();
      this.PkGbSK4ODC = new Button();
      this.V73bUwIIkx = new RadioButton();
      this.Y8lbrOUkOu = new DateTimePicker();
      this.h1JbjuirwP = new RadioButton();
      this.CTub6s4Dwb = new NumericUpDown();
      this.CTub6s4Dwb.BeginInit();
      this.SuspendLayout();
      this.J1QbIxa4HC.DialogResult = DialogResult.OK;
      this.J1QbIxa4HC.Location = new Point(136, 80);
      this.J1QbIxa4HC.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(13852);
      this.J1QbIxa4HC.Size = new Size(72, 24);
      this.J1QbIxa4HC.TabIndex = 0;
      this.J1QbIxa4HC.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(13866);
      this.PkGbSK4ODC.DialogResult = DialogResult.Cancel;
      this.PkGbSK4ODC.Location = new Point(216, 80);
      this.PkGbSK4ODC.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(13874);
      this.PkGbSK4ODC.Size = new Size(72, 24);
      this.PkGbSK4ODC.TabIndex = 1;
      this.PkGbSK4ODC.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(13896);
      this.V73bUwIIkx.Location = new Point(24, 18);
      this.V73bUwIIkx.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(13912);
      this.V73bUwIIkx.Size = new Size(80, 16);
      this.V73bUwIIkx.TabIndex = 2;
      this.V73bUwIIkx.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(13938);
      this.V73bUwIIkx.CheckedChanged += new EventHandler(this.RySbOaHXZb);
      this.Y8lbrOUkOu.Format = DateTimePickerFormat.Custom;
      this.Y8lbrOUkOu.Location = new Point(112, 16);
      this.Y8lbrOUkOu.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(13958);
      this.Y8lbrOUkOu.Size = new Size(160, 20);
      this.Y8lbrOUkOu.TabIndex = 3;
      this.h1JbjuirwP.Location = new Point(24, 48);
      this.h1JbjuirwP.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(13984);
      this.h1JbjuirwP.Size = new Size(72, 16);
      this.h1JbjuirwP.TabIndex = 5;
      this.h1JbjuirwP.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(14010);
      this.h1JbjuirwP.CheckedChanged += new EventHandler(this.t2obawreQA);
      this.CTub6s4Dwb.Location = new Point(112, 46);
      this.CTub6s4Dwb.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(14030);
      this.CTub6s4Dwb.Size = new Size(160, 20);
      this.CTub6s4Dwb.TabIndex = 6;
      this.CTub6s4Dwb.TextAlign = HorizontalAlignment.Right;
      this.CTub6s4Dwb.ThousandsSeparator = true;
      this.AcceptButton = (IButtonControl) this.J1QbIxa4HC;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.PkGbSK4ODC;
      this.ClientSize = new Size(306, 111);
      this.Controls.Add((Control) this.CTub6s4Dwb);
      this.Controls.Add((Control) this.h1JbjuirwP);
      this.Controls.Add((Control) this.Y8lbrOUkOu);
      this.Controls.Add((Control) this.V73bUwIIkx);
      this.Controls.Add((Control) this.PkGbSK4ODC);
      this.Controls.Add((Control) this.J1QbIxa4HC);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) resourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(14056));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(14080);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(14100);
      this.CTub6s4Dwb.EndInit();
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void cMWbyXRTvJ([In] DateTime obj0, [In] DateTime obj1, [In] int obj2)
    {
      this.Y8lbrOUkOu.MinDate = obj0;
      this.Y8lbrOUkOu.MaxDate = obj1;
      this.Y8lbrOUkOu.Value = obj0;
      this.CTub6s4Dwb.Minimum = new Decimal(0);
      this.CTub6s4Dwb.Maximum = (Decimal) (obj2 - 1);
      this.CTub6s4Dwb.Value = new Decimal(0);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal object w2tbZT9kLy()
    {
      object obj = (object) null;
      if (this.V73bUwIIkx.Checked)
        obj = (object) this.Y8lbrOUkOu.Value;
      if (this.h1JbjuirwP.Checked)
        obj = (object) (int) this.CTub6s4Dwb.Value;
      return obj;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RySbOaHXZb([In] object obj0, [In] EventArgs obj1)
    {
      this.HAgbGZNaiF();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void t2obawreQA([In] object obj0, [In] EventArgs obj1)
    {
      this.HAgbGZNaiF();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HAgbGZNaiF()
    {
      if (this.V73bUwIIkx.Checked)
      {
        this.Y8lbrOUkOu.Enabled = true;
        this.CTub6s4Dwb.Enabled = false;
      }
      if (!this.h1JbjuirwP.Checked)
        return;
      this.Y8lbrOUkOu.Enabled = false;
      this.CTub6s4Dwb.Enabled = true;
    }
  }
}
