// Type: SmartQuant.Shared.Controls.NewTradeForm
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
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Controls
{
  public class NewTradeForm : Form
  {
    private IContainer u0ZVuGP9qE;
    private Label i8fVg4bjOL;
    private Label SdsVMex3Kf;
    private Label k1iVJNinWn;
    private DateTimePicker TSqVnf4yrX;
    private NumericUpDown fdXV7Teq0Z;
    private NumericUpDown tbJVLw2mPD;
    private Button uaaViBBkDH;
    private Button oatV95QVRs;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NewTradeForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.dTnVl90dOL();
      DateTimeFormatInfo currentInfo = DateTimeFormatInfo.CurrentInfo;
      this.TSqVnf4yrX.CustomFormat = currentInfo.ShortDatePattern + RNaihRhYEl0wUmAftnB.aYu7exFQKN(14898) + currentInfo.LongTimePattern;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInstrument(Instrument instrument)
    {
      this.Text = string.Format(RNaihRhYEl0wUmAftnB.aYu7exFQKN(14904), (object) instrument.Symbol);
      int num = 2;
      try
      {
        num = int.Parse(instrument.PriceDisplay[1].ToString());
      }
      catch
      {
      }
      this.fdXV7Teq0Z.DecimalPlaces = num;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Trade GetTrade()
    {
      return new Trade(this.TSqVnf4yrX.Value, (double) this.fdXV7Teq0Z.Value, (int) this.tbJVLw2mPD.Value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.u0ZVuGP9qE != null)
        this.u0ZVuGP9qE.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void dTnVl90dOL()
    {
      this.i8fVg4bjOL = new Label();
      this.SdsVMex3Kf = new Label();
      this.k1iVJNinWn = new Label();
      this.TSqVnf4yrX = new DateTimePicker();
      this.fdXV7Teq0Z = new NumericUpDown();
      this.tbJVLw2mPD = new NumericUpDown();
      this.uaaViBBkDH = new Button();
      this.oatV95QVRs = new Button();
      this.fdXV7Teq0Z.BeginInit();
      this.tbJVLw2mPD.BeginInit();
      this.SuspendLayout();
      this.i8fVg4bjOL.Location = new Point(15, 19);
      this.i8fVg4bjOL.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(14946);
      this.i8fVg4bjOL.Size = new Size(63, 19);
      this.i8fVg4bjOL.TabIndex = 0;
      this.i8fVg4bjOL.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(14962);
      this.i8fVg4bjOL.TextAlign = ContentAlignment.MiddleLeft;
      this.SdsVMex3Kf.Location = new Point(15, 45);
      this.SdsVMex3Kf.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(14982);
      this.SdsVMex3Kf.Size = new Size(63, 19);
      this.SdsVMex3Kf.TabIndex = 1;
      this.SdsVMex3Kf.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(14998);
      this.SdsVMex3Kf.TextAlign = ContentAlignment.MiddleLeft;
      this.k1iVJNinWn.Location = new Point(15, 71);
      this.k1iVJNinWn.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15012);
      this.k1iVJNinWn.Size = new Size(63, 19);
      this.k1iVJNinWn.TabIndex = 2;
      this.k1iVJNinWn.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15028);
      this.k1iVJNinWn.TextAlign = ContentAlignment.MiddleLeft;
      this.TSqVnf4yrX.Format = DateTimePickerFormat.Custom;
      this.TSqVnf4yrX.Location = new Point(80, 19);
      this.TSqVnf4yrX.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15040);
      this.TSqVnf4yrX.Size = new Size(176, 20);
      this.TSqVnf4yrX.TabIndex = 3;
      this.fdXV7Teq0Z.Location = new Point(80, 44);
      NumericUpDown numericUpDown1 = this.fdXV7Teq0Z;
      int[] bits1 = new int[4];
      bits1[0] = 10000000;
      Decimal num1 = new Decimal(bits1);
      numericUpDown1.Maximum = num1;
      this.fdXV7Teq0Z.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15066);
      this.fdXV7Teq0Z.Size = new Size(86, 20);
      this.fdXV7Teq0Z.TabIndex = 4;
      this.fdXV7Teq0Z.TextAlign = HorizontalAlignment.Right;
      this.fdXV7Teq0Z.ThousandsSeparator = true;
      this.tbJVLw2mPD.Location = new Point(80, 70);
      NumericUpDown numericUpDown2 = this.tbJVLw2mPD;
      int[] bits2 = new int[4];
      bits2[0] = 10000000;
      Decimal num2 = new Decimal(bits2);
      numericUpDown2.Maximum = num2;
      this.tbJVLw2mPD.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15086);
      this.tbJVLw2mPD.Size = new Size(86, 20);
      this.tbJVLw2mPD.TabIndex = 5;
      this.tbJVLw2mPD.TextAlign = HorizontalAlignment.Right;
      this.tbJVLw2mPD.ThousandsSeparator = true;
      this.uaaViBBkDH.DialogResult = DialogResult.OK;
      this.uaaViBBkDH.Location = new Point(166, 102);
      this.uaaViBBkDH.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15104);
      this.uaaViBBkDH.Size = new Size(66, 22);
      this.uaaViBBkDH.TabIndex = 6;
      this.uaaViBBkDH.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15120);
      this.uaaViBBkDH.UseVisualStyleBackColor = true;
      this.oatV95QVRs.DialogResult = DialogResult.Cancel;
      this.oatV95QVRs.Location = new Point(236, 102);
      this.oatV95QVRs.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15130);
      this.oatV95QVRs.Size = new Size(67, 22);
      this.oatV95QVRs.TabIndex = 7;
      this.oatV95QVRs.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15152);
      this.oatV95QVRs.UseVisualStyleBackColor = true;
      this.AcceptButton = (IButtonControl) this.uaaViBBkDH;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.oatV95QVRs;
      this.ClientSize = new Size(315, 135);
      this.Controls.Add((Control) this.oatV95QVRs);
      this.Controls.Add((Control) this.uaaViBBkDH);
      this.Controls.Add((Control) this.tbJVLw2mPD);
      this.Controls.Add((Control) this.fdXV7Teq0Z);
      this.Controls.Add((Control) this.TSqVnf4yrX);
      this.Controls.Add((Control) this.k1iVJNinWn);
      this.Controls.Add((Control) this.SdsVMex3Kf);
      this.Controls.Add((Control) this.i8fVg4bjOL);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15168);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15196);
      this.fdXV7Teq0Z.EndInit();
      this.tbJVLw2mPD.EndInit();
      this.ResumeLayout(false);
    }
  }
}
