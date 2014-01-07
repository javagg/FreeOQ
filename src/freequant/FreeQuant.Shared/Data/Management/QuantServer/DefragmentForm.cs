// Type: SmartQuant.Shared.Data.Management.QuantServer.DefragmentForm
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant.File;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Management.QuantServer
{
  public class DefragmentForm : Form
  {
    private DataFile yEyxyJy3ij;
    private int Y6MxOTIbaL;
    private int moexa7EZ2t;
    private bool OO4xGvAMQF;
    private Button ECPxZVYxKj;
    private Label gbxx4aoTox;
    private ProgressBar viUxIawTxt;
    private Container J3QxSjpM11;
    private Button fNKxUTM6WA;
    private GroupBox uBoxjZkO1j;
    private Panel qywx6Wi6Dk;
    private NumericUpDown jA5xrJtsOJ;
    private CheckBox esyx8DkDkU;
    private Panel pYKx5WSPvs;
    private NumericUpDown WrxxqhtuDd;
    private CheckBox VYuxCno5Zm;
    private Button et6x2xtr4m;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefragmentForm(DataFile file)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.qr0xlIbQ1m();
      this.yEyxyJy3ij = file;
      this.moexa7EZ2t = file.Series.Count;
      this.jA5xrJtsOJ.Value = (Decimal) file.DefaultZipLevel;
      this.WrxxqhtuDd.Value = (Decimal) file.DefaultBlockSize;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.J3QxSjpM11 != null)
        this.J3QxSjpM11.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void qr0xlIbQ1m()
    {
      this.fNKxUTM6WA = new Button();
      this.ECPxZVYxKj = new Button();
      this.gbxx4aoTox = new Label();
      this.viUxIawTxt = new ProgressBar();
      this.uBoxjZkO1j = new GroupBox();
      this.pYKx5WSPvs = new Panel();
      this.VYuxCno5Zm = new CheckBox();
      this.WrxxqhtuDd = new NumericUpDown();
      this.qywx6Wi6Dk = new Panel();
      this.esyx8DkDkU = new CheckBox();
      this.jA5xrJtsOJ = new NumericUpDown();
      this.et6x2xtr4m = new Button();
      this.uBoxjZkO1j.SuspendLayout();
      this.pYKx5WSPvs.SuspendLayout();
      this.WrxxqhtuDd.BeginInit();
      this.qywx6Wi6Dk.SuspendLayout();
      this.jA5xrJtsOJ.BeginInit();
      this.SuspendLayout();
      this.fNKxUTM6WA.Location = new Point(160, 184);
      this.fNKxUTM6WA.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6008);
      this.fNKxUTM6WA.Size = new Size(72, 24);
      this.fNKxUTM6WA.TabIndex = 0;
      this.fNKxUTM6WA.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6038);
      this.fNKxUTM6WA.Click += new EventHandler(this.I27xM0gjDp);
      this.ECPxZVYxKj.DialogResult = DialogResult.Cancel;
      this.ECPxZVYxKj.Location = new Point(238, 184);
      this.ECPxZVYxKj.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6062);
      this.ECPxZVYxKj.Size = new Size(72, 24);
      this.ECPxZVYxKj.TabIndex = 1;
      this.ECPxZVYxKj.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6082);
      this.gbxx4aoTox.Location = new Point(16, 120);
      this.gbxx4aoTox.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6096);
      this.gbxx4aoTox.Size = new Size(288, 16);
      this.gbxx4aoTox.TabIndex = 2;
      this.gbxx4aoTox.TextAlign = ContentAlignment.MiddleLeft;
      this.viUxIawTxt.Location = new Point(8, 144);
      this.viUxIawTxt.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6114);
      this.viUxIawTxt.Size = new Size(304, 20);
      this.viUxIawTxt.TabIndex = 4;
      this.uBoxjZkO1j.Controls.Add((Control) this.pYKx5WSPvs);
      this.uBoxjZkO1j.Controls.Add((Control) this.qywx6Wi6Dk);
      this.uBoxjZkO1j.Location = new Point(8, 8);
      this.uBoxjZkO1j.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6140);
      this.uBoxjZkO1j.Size = new Size(304, 96);
      this.uBoxjZkO1j.TabIndex = 9;
      this.uBoxjZkO1j.TabStop = false;
      this.uBoxjZkO1j.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6166);
      this.pYKx5WSPvs.Controls.Add((Control) this.VYuxCno5Zm);
      this.pYKx5WSPvs.Controls.Add((Control) this.WrxxqhtuDd);
      this.pYKx5WSPvs.Location = new Point(32, 56);
      this.pYKx5WSPvs.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6186);
      this.pYKx5WSPvs.Size = new Size(240, 24);
      this.pYKx5WSPvs.TabIndex = 1;
      this.VYuxCno5Zm.Dock = DockStyle.Fill;
      this.VYuxCno5Zm.Location = new Point(0, 0);
      this.VYuxCno5Zm.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6202);
      this.VYuxCno5Zm.Size = new Size(168, 24);
      this.VYuxCno5Zm.TabIndex = 10;
      this.VYuxCno5Zm.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6236);
      this.VYuxCno5Zm.CheckedChanged += new EventHandler(this.W6WxgPOigm);
      this.WrxxqhtuDd.Dock = DockStyle.Right;
      this.WrxxqhtuDd.Enabled = false;
      this.WrxxqhtuDd.Location = new Point(168, 0);
      NumericUpDown numericUpDown1 = this.WrxxqhtuDd;
      int[] bits1 = new int[4];
      bits1[0] = 1000000;
      Decimal num1 = new Decimal(bits1);
      numericUpDown1.Maximum = num1;
      NumericUpDown numericUpDown2 = this.WrxxqhtuDd;
      int[] bits2 = new int[4];
      bits2[0] = 2;
      Decimal num2 = new Decimal(bits2);
      numericUpDown2.Minimum = num2;
      this.WrxxqhtuDd.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6276);
      this.WrxxqhtuDd.Size = new Size(72, 20);
      this.WrxxqhtuDd.TabIndex = 9;
      this.WrxxqhtuDd.TextAlign = HorizontalAlignment.Right;
      this.WrxxqhtuDd.ThousandsSeparator = true;
      NumericUpDown numericUpDown3 = this.WrxxqhtuDd;
      int[] bits3 = new int[4];
      bits3[0] = 1000;
      Decimal num3 = new Decimal(bits3);
      numericUpDown3.Value = num3;
      this.qywx6Wi6Dk.Controls.Add((Control) this.esyx8DkDkU);
      this.qywx6Wi6Dk.Controls.Add((Control) this.jA5xrJtsOJ);
      this.qywx6Wi6Dk.Location = new Point(32, 24);
      this.qywx6Wi6Dk.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6310);
      this.qywx6Wi6Dk.Size = new Size(240, 24);
      this.qywx6Wi6Dk.TabIndex = 0;
      this.esyx8DkDkU.Dock = DockStyle.Fill;
      this.esyx8DkDkU.Location = new Point(0, 0);
      this.esyx8DkDkU.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6326);
      this.esyx8DkDkU.Size = new Size(168, 24);
      this.esyx8DkDkU.TabIndex = 9;
      this.esyx8DkDkU.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6352);
      this.esyx8DkDkU.CheckedChanged += new EventHandler(this.jMUxuM9W3Z);
      this.jA5xrJtsOJ.Dock = DockStyle.Right;
      this.jA5xrJtsOJ.Enabled = false;
      this.jA5xrJtsOJ.Location = new Point(168, 0);
      NumericUpDown numericUpDown4 = this.jA5xrJtsOJ;
      int[] bits4 = new int[4];
      bits4[0] = 9;
      Decimal num4 = new Decimal(bits4);
      numericUpDown4.Maximum = num4;
      this.jA5xrJtsOJ.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6390);
      this.jA5xrJtsOJ.Size = new Size(72, 20);
      this.jA5xrJtsOJ.TabIndex = 8;
      this.jA5xrJtsOJ.TextAlign = HorizontalAlignment.Right;
      NumericUpDown numericUpDown5 = this.jA5xrJtsOJ;
      int[] bits5 = new int[4];
      bits5[0] = 1;
      Decimal num5 = new Decimal(bits5);
      numericUpDown5.Value = num5;
      this.et6x2xtr4m.Location = new Point(56, 184);
      this.et6x2xtr4m.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6416);
      this.et6x2xtr4m.Size = new Size(72, 24);
      this.et6x2xtr4m.TabIndex = 10;
      this.et6x2xtr4m.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6438);
      this.et6x2xtr4m.Visible = false;
      this.et6x2xtr4m.Click += new EventHandler(this.fPMxJ5dGcE);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.ECPxZVYxKj;
      this.ClientSize = new Size(322, 223);
      this.ControlBox = false;
      this.Controls.Add((Control) this.et6x2xtr4m);
      this.Controls.Add((Control) this.uBoxjZkO1j);
      this.Controls.Add((Control) this.viUxIawTxt);
      this.Controls.Add((Control) this.gbxx4aoTox);
      this.Controls.Add((Control) this.ECPxZVYxKj);
      this.Controls.Add((Control) this.fNKxUTM6WA);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6454);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6486);
      this.uBoxjZkO1j.ResumeLayout(false);
      this.pYKx5WSPvs.ResumeLayout(false);
      this.WrxxqhtuDd.EndInit();
      this.qywx6Wi6Dk.ResumeLayout(false);
      this.jA5xrJtsOJ.EndInit();
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void jMUxuM9W3Z([In] object obj0, [In] EventArgs obj1)
    {
      this.jA5xrJtsOJ.Enabled = this.esyx8DkDkU.Checked;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void W6WxgPOigm([In] object obj0, [In] EventArgs obj1)
    {
      this.WrxxqhtuDd.Enabled = this.VYuxCno5Zm.Checked;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void I27xM0gjDp([In] object obj0, [In] EventArgs obj1)
    {
      this.fNKxUTM6WA.Visible = false;
      this.ECPxZVYxKj.Enabled = false;
      this.et6x2xtr4m.Location = this.fNKxUTM6WA.Location;
      this.et6x2xtr4m.Visible = true;
      this.uBoxjZkO1j.Enabled = false;
      this.yEyxyJy3ij.SeriesDefragmentStarted += new SeriesEventHandler(this.GPyx7YwQbU);
      this.yEyxyJy3ij.SeriesDefragmentFinished += new SeriesEventHandler(this.y7XxLtDJDU);
      this.yEyxyJy3ij.DefragmentCancelRequest += new DefragmentCancelEventHandler(this.vNKxiMwgqA);
      new Thread(new ThreadStart(this.BAexn754WI))
      {
        Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6520)
      }.Start();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void fPMxJ5dGcE([In] object obj0, [In] EventArgs obj1)
    {
      this.jbbx9LkaD2(this.gbxx4aoTox, RNaihRhYEl0wUmAftnB.aYu7exFQKN(6544));
      this.et6x2xtr4m.Visible = false;
      this.OO4xGvAMQF = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BAexn754WI()
    {
      try
      {
        this.yEyxyJy3ij.Defragment(this.esyx8DkDkU.Checked ? (int) this.jA5xrJtsOJ.Value : -1, this.VYuxCno5Zm.Checked ? (int) this.WrxxqhtuDd.Value : -1);
      }
      catch (Exception ex)
      {
        this.opsxfwLCyG(((object) ex).ToString());
      }
      finally
      {
        this.yEyxyJy3ij.SeriesDefragmentStarted -= new SeriesEventHandler(this.GPyx7YwQbU);
        this.yEyxyJy3ij.SeriesDefragmentFinished -= new SeriesEventHandler(this.y7XxLtDJDU);
        this.yEyxyJy3ij.DefragmentCancelRequest -= new DefragmentCancelEventHandler(this.vNKxiMwgqA);
        if (this.OO4xGvAMQF)
          this.jbbx9LkaD2(this.gbxx4aoTox, RNaihRhYEl0wUmAftnB.aYu7exFQKN(6618));
        else
          this.jbbx9LkaD2(this.gbxx4aoTox, RNaihRhYEl0wUmAftnB.aYu7exFQKN(6662));
        this.TngxWH0v2N();
        this.A9lxTCqSVI();
        this.R4Yx3UcYaf();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GPyx7YwQbU([In] SeriesEventArgs obj0)
    {
      NumberFormatInfo numberFormatInfo = (NumberFormatInfo) NumberFormatInfo.CurrentInfo.Clone();
      numberFormatInfo.NumberDecimalDigits = 0;
      this.jbbx9LkaD2(this.gbxx4aoTox, string.Format((IFormatProvider) numberFormatInfo, RNaihRhYEl0wUmAftnB.aYu7exFQKN(6676), (object) obj0.Series.Name, (object) (this.Y6MxOTIbaL + 1), (object) this.moexa7EZ2t));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void y7XxLtDJDU([In] SeriesEventArgs obj0)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new SeriesEventHandler(this.y7XxLtDJDU), new object[1]
        {
          (object) obj0
        });
      }
      else
      {
        ++this.Y6MxOTIbaL;
        this.viUxIawTxt.Value = this.Y6MxOTIbaL * 100 / this.moexa7EZ2t;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void vNKxiMwgqA([In] DefragmentCancelEventArgs obj0)
    {
      obj0.Cancel = this.OO4xGvAMQF;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void jbbx9LkaD2([In] Label obj0, [In] string obj1)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new DefragmentForm.lPEBaYgUAfeTP1emcc(this.jbbx9LkaD2), (object) obj0, (object) obj1);
      else
        obj0.Text = obj1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void R4Yx3UcYaf()
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new MethodInvoker(this.R4Yx3UcYaf));
      else
        this.ECPxZVYxKj.Enabled = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TngxWH0v2N()
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new MethodInvoker(this.TngxWH0v2N));
      else
        this.fNKxUTM6WA.Visible = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void A9lxTCqSVI()
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new MethodInvoker(this.A9lxTCqSVI));
      else
        this.et6x2xtr4m.Visible = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void opsxfwLCyG([In] string obj0)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new DefragmentForm.uKdCwQMCdmBHS3Nmi6(this.opsxfwLCyG), new object[1]
        {
          (object) obj0
        });
      }
      else
      {
        int num = (int) MessageBox.Show((IWin32Window) this, obj0, RNaihRhYEl0wUmAftnB.aYu7exFQKN(6748), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private delegate void lPEBaYgUAfeTP1emcc(Label label, string text);

    private delegate void uKdCwQMCdmBHS3Nmi6(string value);
  }
}
