// Type: SmartQuant.Shared.Controls.NewBarForm
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant.Data;
using SmartQuant.Instruments;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Controls
{
  public class NewBarForm : Form
  {
    private IContainer MN4hgxHlKa;
    private Label uOJhMTR4Xf;
    private Label KHxhJBDCAE;
    private Label RPBhnU9FLy;
    private Label IXoh7Zt3KV;
    private Label cs0hL2fKS3;
    private Label jIUhicgmp5;
    private Label Jy3h9pl442;
    private Label nT6h3GFxwd;
    private Label oRGhWU6NHj;
    private Label llMhTu5svT;
    private ComboBox vpShfU52vM;
    private NumericUpDown ixLhyvWvAB;
    private DateTimePicker eq2hO8Uoby;
    private DateTimePicker i0qhanct4K;
    private NumericUpDown tXRhGXgWAt;
    private NumericUpDown QVGhZR89b4;
    private NumericUpDown S7Ah4LG3VM;
    private NumericUpDown rKHhI97UFC;
    private NumericUpDown iIIhSIvIUn;
    private NumericUpDown GdkhUUutSt;
    private Button El7hj6A9MK;
    private Button wTZh6B0DQS;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NewBarForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.VyxhV1QZSV();
      DateTimeFormatInfo currentInfo = DateTimeFormatInfo.CurrentInfo;
      string str = string.Format(RNaihRhYEl0wUmAftnB.aYu7exFQKN(2422), (object) currentInfo.ShortDatePattern, (object) currentInfo.LongTimePattern);
      this.eq2hO8Uoby.CustomFormat = str;
      this.i0qhanct4K.CustomFormat = str;
      foreach (BarType barType in Enum.GetValues(typeof (BarType)))
        this.vpShfU52vM.Items.Add((object) barType);
      this.vpShfU52vM.SelectedItem = (object) DataManager.DefaultBarType;
      this.ixLhyvWvAB.Value = (Decimal) DataManager.DefaultBarSize;
      this.eq2hO8Uoby.Value = this.xAqhuhiXnb(DataManager.DefaultBarSize);
      if ((BarType) this.vpShfU52vM.SelectedItem == BarType.Time)
        this.Vorhl5jNmr();
      else
        this.i0qhanct4K.Value = this.eq2hO8Uoby.Value;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.MN4hgxHlKa != null)
        this.MN4hgxHlKa.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VyxhV1QZSV()
    {
      this.uOJhMTR4Xf = new Label();
      this.KHxhJBDCAE = new Label();
      this.RPBhnU9FLy = new Label();
      this.IXoh7Zt3KV = new Label();
      this.cs0hL2fKS3 = new Label();
      this.jIUhicgmp5 = new Label();
      this.Jy3h9pl442 = new Label();
      this.nT6h3GFxwd = new Label();
      this.oRGhWU6NHj = new Label();
      this.llMhTu5svT = new Label();
      this.vpShfU52vM = new ComboBox();
      this.ixLhyvWvAB = new NumericUpDown();
      this.eq2hO8Uoby = new DateTimePicker();
      this.i0qhanct4K = new DateTimePicker();
      this.tXRhGXgWAt = new NumericUpDown();
      this.QVGhZR89b4 = new NumericUpDown();
      this.S7Ah4LG3VM = new NumericUpDown();
      this.rKHhI97UFC = new NumericUpDown();
      this.iIIhSIvIUn = new NumericUpDown();
      this.GdkhUUutSt = new NumericUpDown();
      this.El7hj6A9MK = new Button();
      this.wTZh6B0DQS = new Button();
      this.ixLhyvWvAB.BeginInit();
      this.tXRhGXgWAt.BeginInit();
      this.QVGhZR89b4.BeginInit();
      this.S7Ah4LG3VM.BeginInit();
      this.rKHhI97UFC.BeginInit();
      this.iIIhSIvIUn.BeginInit();
      this.GdkhUUutSt.BeginInit();
      this.SuspendLayout();
      this.uOJhMTR4Xf.Location = new Point(12, 16);
      this.uOJhMTR4Xf.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1782);
      this.uOJhMTR4Xf.Size = new Size(71, 20);
      this.uOJhMTR4Xf.TabIndex = 0;
      this.uOJhMTR4Xf.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1798);
      this.uOJhMTR4Xf.TextAlign = ContentAlignment.MiddleLeft;
      this.KHxhJBDCAE.Location = new Point(12, 40);
      this.KHxhJBDCAE.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1816);
      this.KHxhJBDCAE.Size = new Size(71, 20);
      this.KHxhJBDCAE.TabIndex = 1;
      this.KHxhJBDCAE.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1832);
      this.KHxhJBDCAE.TextAlign = ContentAlignment.MiddleLeft;
      this.RPBhnU9FLy.Location = new Point(12, 64);
      this.RPBhnU9FLy.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1844);
      this.RPBhnU9FLy.Size = new Size(71, 20);
      this.RPBhnU9FLy.TabIndex = 2;
      this.RPBhnU9FLy.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1860);
      this.RPBhnU9FLy.TextAlign = ContentAlignment.MiddleLeft;
      this.IXoh7Zt3KV.Location = new Point(12, 88);
      this.IXoh7Zt3KV.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1882);
      this.IXoh7Zt3KV.Size = new Size(71, 20);
      this.IXoh7Zt3KV.TabIndex = 3;
      this.IXoh7Zt3KV.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1898);
      this.IXoh7Zt3KV.TextAlign = ContentAlignment.MiddleLeft;
      this.cs0hL2fKS3.Location = new Point(12, 112);
      this.cs0hL2fKS3.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1916);
      this.cs0hL2fKS3.Size = new Size(71, 20);
      this.cs0hL2fKS3.TabIndex = 4;
      this.cs0hL2fKS3.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1932);
      this.cs0hL2fKS3.TextAlign = ContentAlignment.MiddleLeft;
      this.jIUhicgmp5.Location = new Point(12, 136);
      this.jIUhicgmp5.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1944);
      this.jIUhicgmp5.Size = new Size(71, 20);
      this.jIUhicgmp5.TabIndex = 5;
      this.jIUhicgmp5.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1960);
      this.jIUhicgmp5.TextAlign = ContentAlignment.MiddleLeft;
      this.Jy3h9pl442.Location = new Point(12, 160);
      this.Jy3h9pl442.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1972);
      this.Jy3h9pl442.Size = new Size(71, 20);
      this.Jy3h9pl442.TabIndex = 6;
      this.Jy3h9pl442.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1988);
      this.Jy3h9pl442.TextAlign = ContentAlignment.MiddleLeft;
      this.nT6h3GFxwd.Location = new Point(12, 184);
      this.nT6h3GFxwd.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1998);
      this.nT6h3GFxwd.Size = new Size(71, 20);
      this.nT6h3GFxwd.TabIndex = 7;
      this.nT6h3GFxwd.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2014);
      this.nT6h3GFxwd.TextAlign = ContentAlignment.MiddleLeft;
      this.oRGhWU6NHj.Location = new Point(12, 208);
      this.oRGhWU6NHj.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2028);
      this.oRGhWU6NHj.Size = new Size(71, 20);
      this.oRGhWU6NHj.TabIndex = 8;
      this.oRGhWU6NHj.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2044);
      this.oRGhWU6NHj.TextAlign = ContentAlignment.MiddleLeft;
      this.llMhTu5svT.Location = new Point(12, 232);
      this.llMhTu5svT.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2060);
      this.llMhTu5svT.Size = new Size(71, 20);
      this.llMhTu5svT.TabIndex = 9;
      this.llMhTu5svT.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2078);
      this.llMhTu5svT.TextAlign = ContentAlignment.MiddleLeft;
      this.vpShfU52vM.DropDownStyle = ComboBoxStyle.DropDownList;
      this.vpShfU52vM.FormattingEnabled = true;
      this.vpShfU52vM.Location = new Point(76, 16);
      this.vpShfU52vM.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2096);
      this.vpShfU52vM.Size = new Size(80, 21);
      this.vpShfU52vM.Sorted = true;
      this.vpShfU52vM.TabIndex = 10;
      this.vpShfU52vM.SelectedIndexChanged += new EventHandler(this.XiShRt5bTR);
      this.ixLhyvWvAB.Location = new Point(76, 40);
      NumericUpDown numericUpDown1 = this.ixLhyvWvAB;
      int[] bits1 = new int[4];
      bits1[0] = 1000000;
      Decimal num1 = new Decimal(bits1);
      numericUpDown1.Maximum = num1;
      this.ixLhyvWvAB.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2122);
      this.ixLhyvWvAB.Size = new Size(80, 20);
      this.ixLhyvWvAB.TabIndex = 11;
      this.ixLhyvWvAB.TextAlign = HorizontalAlignment.Right;
      this.ixLhyvWvAB.ThousandsSeparator = true;
      this.ixLhyvWvAB.ValueChanged += new EventHandler(this.quLhH0UjZK);
      this.eq2hO8Uoby.Format = DateTimePickerFormat.Custom;
      this.eq2hO8Uoby.Location = new Point(76, 64);
      this.eq2hO8Uoby.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2140);
      this.eq2hO8Uoby.Size = new Size(192, 20);
      this.eq2hO8Uoby.TabIndex = 12;
      this.eq2hO8Uoby.ValueChanged += new EventHandler(this.Oy9hkwIOM0);
      this.i0qhanct4K.Format = DateTimePickerFormat.Custom;
      this.i0qhanct4K.Location = new Point(76, 88);
      this.i0qhanct4K.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2168);
      this.i0qhanct4K.Size = new Size(192, 20);
      this.i0qhanct4K.TabIndex = 13;
      this.tXRhGXgWAt.Location = new Point(76, 112);
      NumericUpDown numericUpDown2 = this.tXRhGXgWAt;
      int[] bits2 = new int[4];
      bits2[0] = 1000000;
      Decimal num2 = new Decimal(bits2);
      numericUpDown2.Maximum = num2;
      this.tXRhGXgWAt.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2192);
      this.tXRhGXgWAt.Size = new Size(80, 20);
      this.tXRhGXgWAt.TabIndex = 14;
      this.tXRhGXgWAt.TextAlign = HorizontalAlignment.Right;
      this.tXRhGXgWAt.ThousandsSeparator = true;
      this.QVGhZR89b4.Location = new Point(76, 136);
      NumericUpDown numericUpDown3 = this.QVGhZR89b4;
      int[] bits3 = new int[4];
      bits3[0] = 1000000;
      Decimal num3 = new Decimal(bits3);
      numericUpDown3.Maximum = num3;
      this.QVGhZR89b4.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2210);
      this.QVGhZR89b4.Size = new Size(80, 20);
      this.QVGhZR89b4.TabIndex = 15;
      this.QVGhZR89b4.TextAlign = HorizontalAlignment.Right;
      this.QVGhZR89b4.ThousandsSeparator = true;
      this.S7Ah4LG3VM.Location = new Point(76, 160);
      NumericUpDown numericUpDown4 = this.S7Ah4LG3VM;
      int[] bits4 = new int[4];
      bits4[0] = 1000000;
      Decimal num4 = new Decimal(bits4);
      numericUpDown4.Maximum = num4;
      this.S7Ah4LG3VM.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2228);
      this.S7Ah4LG3VM.Size = new Size(80, 20);
      this.S7Ah4LG3VM.TabIndex = 16;
      this.S7Ah4LG3VM.TextAlign = HorizontalAlignment.Right;
      this.S7Ah4LG3VM.ThousandsSeparator = true;
      this.rKHhI97UFC.Location = new Point(76, 184);
      NumericUpDown numericUpDown5 = this.rKHhI97UFC;
      int[] bits5 = new int[4];
      bits5[0] = 1000000;
      Decimal num5 = new Decimal(bits5);
      numericUpDown5.Maximum = num5;
      this.rKHhI97UFC.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2244);
      this.rKHhI97UFC.Size = new Size(80, 20);
      this.rKHhI97UFC.TabIndex = 17;
      this.rKHhI97UFC.TextAlign = HorizontalAlignment.Right;
      this.rKHhI97UFC.ThousandsSeparator = true;
      this.iIIhSIvIUn.Location = new Point(76, 208);
      NumericUpDown numericUpDown6 = this.iIIhSIvIUn;
      int[] bits6 = new int[4];
      bits6[0] = 1000000;
      Decimal num6 = new Decimal(bits6);
      numericUpDown6.Maximum = num6;
      this.iIIhSIvIUn.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2264);
      this.iIIhSIvIUn.Size = new Size(80, 20);
      this.iIIhSIvIUn.TabIndex = 18;
      this.iIIhSIvIUn.TextAlign = HorizontalAlignment.Right;
      this.iIIhSIvIUn.ThousandsSeparator = true;
      this.GdkhUUutSt.Location = new Point(76, 232);
      NumericUpDown numericUpDown7 = this.GdkhUUutSt;
      int[] bits7 = new int[4];
      bits7[0] = 1000000;
      Decimal num7 = new Decimal(bits7);
      numericUpDown7.Maximum = num7;
      this.GdkhUUutSt.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2286);
      this.GdkhUUutSt.Size = new Size(80, 20);
      this.GdkhUUutSt.TabIndex = 19;
      this.GdkhUUutSt.TextAlign = HorizontalAlignment.Right;
      this.GdkhUUutSt.ThousandsSeparator = true;
      this.El7hj6A9MK.DialogResult = DialogResult.OK;
      this.El7hj6A9MK.Location = new Point(113, 271);
      this.El7hj6A9MK.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2310);
      this.El7hj6A9MK.Size = new Size(70, 22);
      this.El7hj6A9MK.TabIndex = 20;
      this.El7hj6A9MK.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2326);
      this.El7hj6A9MK.UseVisualStyleBackColor = true;
      this.wTZh6B0DQS.DialogResult = DialogResult.Cancel;
      this.wTZh6B0DQS.Location = new Point(189, 271);
      this.wTZh6B0DQS.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2336);
      this.wTZh6B0DQS.Size = new Size(70, 22);
      this.wTZh6B0DQS.TabIndex = 21;
      this.wTZh6B0DQS.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2358);
      this.wTZh6B0DQS.UseVisualStyleBackColor = true;
      this.AcceptButton = (IButtonControl) this.El7hj6A9MK;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.wTZh6B0DQS;
      this.ClientSize = new Size(284, 309);
      this.Controls.Add((Control) this.wTZh6B0DQS);
      this.Controls.Add((Control) this.El7hj6A9MK);
      this.Controls.Add((Control) this.GdkhUUutSt);
      this.Controls.Add((Control) this.iIIhSIvIUn);
      this.Controls.Add((Control) this.rKHhI97UFC);
      this.Controls.Add((Control) this.S7Ah4LG3VM);
      this.Controls.Add((Control) this.QVGhZR89b4);
      this.Controls.Add((Control) this.tXRhGXgWAt);
      this.Controls.Add((Control) this.i0qhanct4K);
      this.Controls.Add((Control) this.eq2hO8Uoby);
      this.Controls.Add((Control) this.ixLhyvWvAB);
      this.Controls.Add((Control) this.vpShfU52vM);
      this.Controls.Add((Control) this.llMhTu5svT);
      this.Controls.Add((Control) this.oRGhWU6NHj);
      this.Controls.Add((Control) this.nT6h3GFxwd);
      this.Controls.Add((Control) this.Jy3h9pl442);
      this.Controls.Add((Control) this.jIUhicgmp5);
      this.Controls.Add((Control) this.cs0hL2fKS3);
      this.Controls.Add((Control) this.IXoh7Zt3KV);
      this.Controls.Add((Control) this.RPBhnU9FLy);
      this.Controls.Add((Control) this.KHxhJBDCAE);
      this.Controls.Add((Control) this.uOJhMTR4Xf);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2374);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(2398);
      this.ixLhyvWvAB.EndInit();
      this.tXRhGXgWAt.EndInit();
      this.QVGhZR89b4.EndInit();
      this.S7Ah4LG3VM.EndInit();
      this.rKHhI97UFC.EndInit();
      this.iIIhSIvIUn.EndInit();
      this.GdkhUUutSt.EndInit();
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInstrument(Instrument instrument)
    {
      this.Text = string.Format(RNaihRhYEl0wUmAftnB.aYu7exFQKN(2440), (object) instrument.Symbol);
      int num = 2;
      try
      {
        num = int.Parse(instrument.PriceDisplay[1].ToString());
      }
      catch
      {
      }
      this.tXRhGXgWAt.DecimalPlaces = num;
      this.QVGhZR89b4.DecimalPlaces = num;
      this.S7Ah4LG3VM.DecimalPlaces = num;
      this.rKHhI97UFC.DecimalPlaces = num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Bar GetBar()
    {
      return new Bar((BarType) this.vpShfU52vM.SelectedItem, (long) this.ixLhyvWvAB.Value, this.eq2hO8Uoby.Value, this.i0qhanct4K.Value, (double) this.tXRhGXgWAt.Value, (double) this.QVGhZR89b4.Value, (double) this.S7Ah4LG3VM.Value, (double) this.rKHhI97UFC.Value, (long) this.iIIhSIvIUn.Value, (long) this.GdkhUUutSt.Value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void XiShRt5bTR([In] object obj0, [In] EventArgs obj1)
    {
      if ((BarType) this.vpShfU52vM.SelectedItem == BarType.Time)
      {
        this.Vorhl5jNmr();
        this.i0qhanct4K.Enabled = false;
      }
      else
        this.i0qhanct4K.Enabled = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void quLhH0UjZK([In] object obj0, [In] EventArgs obj1)
    {
      if ((BarType) this.vpShfU52vM.SelectedItem != BarType.Time)
        return;
      this.Vorhl5jNmr();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Oy9hkwIOM0([In] object obj0, [In] EventArgs obj1)
    {
      if ((BarType) this.vpShfU52vM.SelectedItem != BarType.Time)
        return;
      this.Vorhl5jNmr();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Vorhl5jNmr()
    {
      this.i0qhanct4K.Value = this.eq2hO8Uoby.Value.AddSeconds((double) (long) this.ixLhyvWvAB.Value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DateTime xAqhuhiXnb([In] long obj0)
    {
      DateTime now = DateTime.Now;
      long num = (long) now.TimeOfDay.TotalSeconds / obj0 * obj0;
      return now.Date.AddSeconds((double) num);
    }
  }
}
