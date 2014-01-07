// Type: SmartQuant.Shared.Controls.NewDailyForm
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant.Data;
using SmartQuant.Instruments;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Controls
{
  public class NewDailyForm : Form
  {
    private IContainer vnDFJN4e50;
    private Label AyUFnKfvfN;
    private Label gu3F7VIx3o;
    private Label le5FLm5NbF;
    private Label PrQFi3oUtG;
    private Label kXSF9igG7G;
    private Label zglF36hReM;
    private Label VaPFWtcM6R;
    private DateTimePicker zHCFTPgaOW;
    private NumericUpDown e53Fftw5Fl;
    private NumericUpDown xahFycrab3;
    private NumericUpDown LA6FOE4gqU;
    private NumericUpDown AHmFaJPeZ0;
    private NumericUpDown c7eFGIQWxy;
    private NumericUpDown m9CFZlfoHE;
    private Button g0NF49kPsB;
    private Button XqPFIcKTyT;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NewDailyForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.kKJFMmkl54();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInstrument(Instrument instrument)
    {
      this.Text = string.Format(RNaihRhYEl0wUmAftnB.aYu7exFQKN(11770), (object) instrument.Symbol);
      int num = 2;
      try
      {
        num = int.Parse(instrument.PriceDisplay[1].ToString());
      }
      catch
      {
      }
      this.e53Fftw5Fl.DecimalPlaces = num;
      this.xahFycrab3.DecimalPlaces = num;
      this.LA6FOE4gqU.DecimalPlaces = num;
      this.AHmFaJPeZ0.DecimalPlaces = num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Daily GetDaily()
    {
      return new Daily(this.zHCFTPgaOW.Value.Date, (double) this.e53Fftw5Fl.Value, (double) this.xahFycrab3.Value, (double) this.LA6FOE4gqU.Value, (double) this.AHmFaJPeZ0.Value, (long) this.c7eFGIQWxy.Value, (long) this.m9CFZlfoHE.Value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.vnDFJN4e50 != null)
        this.vnDFJN4e50.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void kKJFMmkl54()
    {
      this.AyUFnKfvfN = new Label();
      this.gu3F7VIx3o = new Label();
      this.le5FLm5NbF = new Label();
      this.PrQFi3oUtG = new Label();
      this.kXSF9igG7G = new Label();
      this.zglF36hReM = new Label();
      this.VaPFWtcM6R = new Label();
      this.zHCFTPgaOW = new DateTimePicker();
      this.e53Fftw5Fl = new NumericUpDown();
      this.xahFycrab3 = new NumericUpDown();
      this.LA6FOE4gqU = new NumericUpDown();
      this.AHmFaJPeZ0 = new NumericUpDown();
      this.c7eFGIQWxy = new NumericUpDown();
      this.m9CFZlfoHE = new NumericUpDown();
      this.g0NF49kPsB = new Button();
      this.XqPFIcKTyT = new Button();
      this.e53Fftw5Fl.BeginInit();
      this.xahFycrab3.BeginInit();
      this.LA6FOE4gqU.BeginInit();
      this.AHmFaJPeZ0.BeginInit();
      this.c7eFGIQWxy.BeginInit();
      this.m9CFZlfoHE.BeginInit();
      this.SuspendLayout();
      this.AyUFnKfvfN.Location = new Point(12, 16);
      this.AyUFnKfvfN.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11812);
      this.AyUFnKfvfN.Size = new Size(79, 20);
      this.AyUFnKfvfN.TabIndex = 0;
      this.AyUFnKfvfN.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11828);
      this.AyUFnKfvfN.TextAlign = ContentAlignment.MiddleLeft;
      this.gu3F7VIx3o.Location = new Point(12, 40);
      this.gu3F7VIx3o.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11840);
      this.gu3F7VIx3o.Size = new Size(79, 20);
      this.gu3F7VIx3o.TabIndex = 1;
      this.gu3F7VIx3o.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11856);
      this.gu3F7VIx3o.TextAlign = ContentAlignment.MiddleLeft;
      this.le5FLm5NbF.Location = new Point(12, 64);
      this.le5FLm5NbF.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11868);
      this.le5FLm5NbF.Size = new Size(79, 20);
      this.le5FLm5NbF.TabIndex = 2;
      this.le5FLm5NbF.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11884);
      this.le5FLm5NbF.TextAlign = ContentAlignment.MiddleLeft;
      this.PrQFi3oUtG.Location = new Point(12, 88);
      this.PrQFi3oUtG.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11896);
      this.PrQFi3oUtG.Size = new Size(79, 20);
      this.PrQFi3oUtG.TabIndex = 3;
      this.PrQFi3oUtG.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11912);
      this.PrQFi3oUtG.TextAlign = ContentAlignment.MiddleLeft;
      this.kXSF9igG7G.Location = new Point(12, 112);
      this.kXSF9igG7G.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11922);
      this.kXSF9igG7G.Size = new Size(79, 20);
      this.kXSF9igG7G.TabIndex = 4;
      this.kXSF9igG7G.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11938);
      this.kXSF9igG7G.TextAlign = ContentAlignment.MiddleLeft;
      this.zglF36hReM.Location = new Point(12, 136);
      this.zglF36hReM.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11952);
      this.zglF36hReM.Size = new Size(79, 20);
      this.zglF36hReM.TabIndex = 5;
      this.zglF36hReM.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11968);
      this.zglF36hReM.TextAlign = ContentAlignment.MiddleLeft;
      this.VaPFWtcM6R.Location = new Point(12, 160);
      this.VaPFWtcM6R.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11984);
      this.VaPFWtcM6R.Size = new Size(79, 20);
      this.VaPFWtcM6R.TabIndex = 6;
      this.VaPFWtcM6R.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12000);
      this.VaPFWtcM6R.TextAlign = ContentAlignment.MiddleLeft;
      this.zHCFTPgaOW.Format = DateTimePickerFormat.Short;
      this.zHCFTPgaOW.Location = new Point(76, 16);
      this.zHCFTPgaOW.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12018);
      this.zHCFTPgaOW.Size = new Size(115, 20);
      this.zHCFTPgaOW.TabIndex = 7;
      this.e53Fftw5Fl.Location = new Point(76, 40);
      NumericUpDown numericUpDown1 = this.e53Fftw5Fl;
      int[] bits1 = new int[4];
      bits1[0] = 1000000;
      Decimal num1 = new Decimal(bits1);
      numericUpDown1.Maximum = num1;
      this.e53Fftw5Fl.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12036);
      this.e53Fftw5Fl.Size = new Size(80, 20);
      this.e53Fftw5Fl.TabIndex = 12;
      this.e53Fftw5Fl.TextAlign = HorizontalAlignment.Right;
      this.e53Fftw5Fl.ThousandsSeparator = true;
      this.xahFycrab3.Location = new Point(76, 64);
      NumericUpDown numericUpDown2 = this.xahFycrab3;
      int[] bits2 = new int[4];
      bits2[0] = 1000000;
      Decimal num2 = new Decimal(bits2);
      numericUpDown2.Maximum = num2;
      this.xahFycrab3.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12054);
      this.xahFycrab3.Size = new Size(80, 20);
      this.xahFycrab3.TabIndex = 13;
      this.xahFycrab3.TextAlign = HorizontalAlignment.Right;
      this.xahFycrab3.ThousandsSeparator = true;
      this.LA6FOE4gqU.Location = new Point(76, 88);
      NumericUpDown numericUpDown3 = this.LA6FOE4gqU;
      int[] bits3 = new int[4];
      bits3[0] = 1000000;
      Decimal num3 = new Decimal(bits3);
      numericUpDown3.Maximum = num3;
      this.LA6FOE4gqU.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12072);
      this.LA6FOE4gqU.Size = new Size(80, 20);
      this.LA6FOE4gqU.TabIndex = 14;
      this.LA6FOE4gqU.TextAlign = HorizontalAlignment.Right;
      this.LA6FOE4gqU.ThousandsSeparator = true;
      this.AHmFaJPeZ0.Location = new Point(76, 112);
      NumericUpDown numericUpDown4 = this.AHmFaJPeZ0;
      int[] bits4 = new int[4];
      bits4[0] = 1000000;
      Decimal num4 = new Decimal(bits4);
      numericUpDown4.Maximum = num4;
      this.AHmFaJPeZ0.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12088);
      this.AHmFaJPeZ0.Size = new Size(80, 20);
      this.AHmFaJPeZ0.TabIndex = 15;
      this.AHmFaJPeZ0.TextAlign = HorizontalAlignment.Right;
      this.AHmFaJPeZ0.ThousandsSeparator = true;
      this.c7eFGIQWxy.Location = new Point(76, 136);
      NumericUpDown numericUpDown5 = this.c7eFGIQWxy;
      int[] bits5 = new int[4];
      bits5[0] = 1000000;
      Decimal num5 = new Decimal(bits5);
      numericUpDown5.Maximum = num5;
      this.c7eFGIQWxy.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12108);
      this.c7eFGIQWxy.Size = new Size(80, 20);
      this.c7eFGIQWxy.TabIndex = 16;
      this.c7eFGIQWxy.TextAlign = HorizontalAlignment.Right;
      this.c7eFGIQWxy.ThousandsSeparator = true;
      this.m9CFZlfoHE.Location = new Point(76, 160);
      NumericUpDown numericUpDown6 = this.m9CFZlfoHE;
      int[] bits6 = new int[4];
      bits6[0] = 1000000;
      Decimal num6 = new Decimal(bits6);
      numericUpDown6.Maximum = num6;
      this.m9CFZlfoHE.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12130);
      this.m9CFZlfoHE.Size = new Size(80, 20);
      this.m9CFZlfoHE.TabIndex = 17;
      this.m9CFZlfoHE.TextAlign = HorizontalAlignment.Right;
      this.m9CFZlfoHE.ThousandsSeparator = true;
      this.g0NF49kPsB.DialogResult = DialogResult.OK;
      this.g0NF49kPsB.Location = new Point(35, 195);
      this.g0NF49kPsB.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12154);
      this.g0NF49kPsB.Size = new Size(70, 22);
      this.g0NF49kPsB.TabIndex = 21;
      this.g0NF49kPsB.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12170);
      this.g0NF49kPsB.UseVisualStyleBackColor = true;
      this.XqPFIcKTyT.DialogResult = DialogResult.Cancel;
      this.XqPFIcKTyT.Location = new Point(111, 195);
      this.XqPFIcKTyT.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12180);
      this.XqPFIcKTyT.Size = new Size(70, 22);
      this.XqPFIcKTyT.TabIndex = 22;
      this.XqPFIcKTyT.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12202);
      this.XqPFIcKTyT.UseVisualStyleBackColor = true;
      this.AcceptButton = (IButtonControl) this.g0NF49kPsB;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.XqPFIcKTyT;
      this.ClientSize = new Size(208, 229);
      this.Controls.Add((Control) this.XqPFIcKTyT);
      this.Controls.Add((Control) this.g0NF49kPsB);
      this.Controls.Add((Control) this.m9CFZlfoHE);
      this.Controls.Add((Control) this.c7eFGIQWxy);
      this.Controls.Add((Control) this.AHmFaJPeZ0);
      this.Controls.Add((Control) this.LA6FOE4gqU);
      this.Controls.Add((Control) this.xahFycrab3);
      this.Controls.Add((Control) this.e53Fftw5Fl);
      this.Controls.Add((Control) this.zHCFTPgaOW);
      this.Controls.Add((Control) this.VaPFWtcM6R);
      this.Controls.Add((Control) this.zglF36hReM);
      this.Controls.Add((Control) this.kXSF9igG7G);
      this.Controls.Add((Control) this.PrQFi3oUtG);
      this.Controls.Add((Control) this.le5FLm5NbF);
      this.Controls.Add((Control) this.gu3F7VIx3o);
      this.Controls.Add((Control) this.AyUFnKfvfN);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12218);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(12246);
      this.e53Fftw5Fl.EndInit();
      this.xahFycrab3.EndInit();
      this.LA6FOE4gqU.EndInit();
      this.AHmFaJPeZ0.EndInit();
      this.c7eFGIQWxy.EndInit();
      this.m9CFZlfoHE.EndInit();
      this.ResumeLayout(false);
    }
  }
}
