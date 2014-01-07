// Type: SmartQuant.Shared.Data.Management.QuantServer.BarMakerForm
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant;
using SmartQuant.Data;
using SmartQuant.File;
using SmartQuant.Instruments;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Management.QuantServer
{
  public class BarMakerForm : Form
  {
    private DataFile N9jutll7YX;
    private FileSeries NkcuEat6q3;
    private BarType AuauQBi8MV;
    private Container hqAuvjFqYk;
    private GroupBox B0FuoBuajY;
    private Label x2FuPk1cRm;
    private Label OiiuABVuho;
    private GroupBox aSZuBj7N1r;
    private Label amkucV8nlP;
    private TextBox InDuzorDTN;
    private Label fovgeTeQKD;
    private NumericUpDown yllghcYE0S;
    private ProgressBar xZLgsFyR1P;
    private Button mgNgYYRPpu;
    private Button WIVgxlyXXL;
    private Label dK1gD43RR5;
    private ComboBox wbYg1gUF09;
    private GroupBox a8kgdNRPPZ;
    private Label VXugFYcElV;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarMakerForm(DataFile file, FileSeries tradeSeries)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.v2huqKah7Q();
      this.N9jutll7YX = file;
      this.NkcuEat6q3 = tradeSeries;
      foreach (BarType barType in Enum.GetValues(typeof (BarType)))
      {
        int num = this.wbYg1gUF09.Items.Add((object) barType);
        if (barType == DataManager.DefaultBarType)
          this.wbYg1gUF09.SelectedIndex = num;
      }
      this.yllghcYE0S.Value = (Decimal) DataManager.DefaultBarSize;
      this.crIuKCOCsn();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.hqAuvjFqYk != null)
        this.hqAuvjFqYk.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnClosing(CancelEventArgs e)
    {
      if (!this.WIVgxlyXXL.Enabled)
        e.Cancel = true;
      else
        base.OnClosing(e);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void v2huqKah7Q()
    {
      this.B0FuoBuajY = new GroupBox();
      this.OiiuABVuho = new Label();
      this.x2FuPk1cRm = new Label();
      this.aSZuBj7N1r = new GroupBox();
      this.InDuzorDTN = new TextBox();
      this.amkucV8nlP = new Label();
      this.a8kgdNRPPZ = new GroupBox();
      this.wbYg1gUF09 = new ComboBox();
      this.dK1gD43RR5 = new Label();
      this.yllghcYE0S = new NumericUpDown();
      this.fovgeTeQKD = new Label();
      this.xZLgsFyR1P = new ProgressBar();
      this.mgNgYYRPpu = new Button();
      this.WIVgxlyXXL = new Button();
      this.VXugFYcElV = new Label();
      this.B0FuoBuajY.SuspendLayout();
      this.aSZuBj7N1r.SuspendLayout();
      this.a8kgdNRPPZ.SuspendLayout();
      this.yllghcYE0S.BeginInit();
      this.SuspendLayout();
      this.B0FuoBuajY.Controls.Add((Control) this.OiiuABVuho);
      this.B0FuoBuajY.Controls.Add((Control) this.x2FuPk1cRm);
      this.B0FuoBuajY.Location = new Point(8, 8);
      this.B0FuoBuajY.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(28660);
      this.B0FuoBuajY.Size = new Size(208, 56);
      this.B0FuoBuajY.TabIndex = 0;
      this.B0FuoBuajY.TabStop = false;
      this.B0FuoBuajY.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(28682);
      this.OiiuABVuho.Location = new Point(72, 24);
      this.OiiuABVuho.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(28698);
      this.OiiuABVuho.Size = new Size(120, 16);
      this.OiiuABVuho.TabIndex = 3;
      this.OiiuABVuho.TextAlign = ContentAlignment.MiddleLeft;
      this.x2FuPk1cRm.Font = new Font(RNaihRhYEl0wUmAftnB.aYu7exFQKN(28720), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.x2FuPk1cRm.Location = new Point(16, 24);
      this.x2FuPk1cRm.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(28764);
      this.x2FuPk1cRm.Size = new Size(40, 16);
      this.x2FuPk1cRm.TabIndex = 1;
      this.x2FuPk1cRm.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(28780);
      this.x2FuPk1cRm.TextAlign = ContentAlignment.MiddleLeft;
      this.aSZuBj7N1r.Controls.Add((Control) this.InDuzorDTN);
      this.aSZuBj7N1r.Controls.Add((Control) this.amkucV8nlP);
      this.aSZuBj7N1r.Location = new Point(224, 8);
      this.aSZuBj7N1r.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(28796);
      this.aSZuBj7N1r.Size = new Size(232, 56);
      this.aSZuBj7N1r.TabIndex = 1;
      this.aSZuBj7N1r.TabStop = false;
      this.aSZuBj7N1r.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(28818);
      this.InDuzorDTN.Location = new Point(56, 24);
      this.InDuzorDTN.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(28844);
      this.InDuzorDTN.Size = new Size(160, 20);
      this.InDuzorDTN.TabIndex = 4;
      this.InDuzorDTN.Text = "";
      this.amkucV8nlP.Font = new Font(RNaihRhYEl0wUmAftnB.aYu7exFQKN(28866), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.amkucV8nlP.Location = new Point(8, 24);
      this.amkucV8nlP.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(28910);
      this.amkucV8nlP.Size = new Size(40, 16);
      this.amkucV8nlP.TabIndex = 3;
      this.amkucV8nlP.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(28926);
      this.amkucV8nlP.TextAlign = ContentAlignment.MiddleLeft;
      this.a8kgdNRPPZ.Controls.Add((Control) this.wbYg1gUF09);
      this.a8kgdNRPPZ.Controls.Add((Control) this.dK1gD43RR5);
      this.a8kgdNRPPZ.Controls.Add((Control) this.yllghcYE0S);
      this.a8kgdNRPPZ.Controls.Add((Control) this.fovgeTeQKD);
      this.a8kgdNRPPZ.Location = new Point(8, 80);
      this.a8kgdNRPPZ.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(28942);
      this.a8kgdNRPPZ.Size = new Size(448, 64);
      this.a8kgdNRPPZ.TabIndex = 2;
      this.a8kgdNRPPZ.TabStop = false;
      this.a8kgdNRPPZ.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(28974);
      this.wbYg1gUF09.DropDownStyle = ComboBoxStyle.DropDownList;
      this.wbYg1gUF09.Location = new Point(88, 22);
      this.wbYg1gUF09.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29002);
      this.wbYg1gUF09.Size = new Size(80, 21);
      this.wbYg1gUF09.TabIndex = 3;
      this.wbYg1gUF09.SelectedIndexChanged += new EventHandler(this.LgOu2aQsxW);
      this.dK1gD43RR5.Location = new Point(16, 24);
      this.dK1gD43RR5.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29022);
      this.dK1gD43RR5.Size = new Size(64, 16);
      this.dK1gD43RR5.TabIndex = 2;
      this.dK1gD43RR5.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29038);
      this.dK1gD43RR5.TextAlign = ContentAlignment.MiddleLeft;
      this.yllghcYE0S.Location = new Point(336, 22);
      NumericUpDown numericUpDown1 = this.yllghcYE0S;
      int[] bits1 = new int[4];
      bits1[0] = 1000000;
      Decimal num1 = new Decimal(bits1);
      numericUpDown1.Maximum = num1;
      NumericUpDown numericUpDown2 = this.yllghcYE0S;
      int[] bits2 = new int[4];
      bits2[0] = 1;
      Decimal num2 = new Decimal(bits2);
      numericUpDown2.Minimum = num2;
      this.yllghcYE0S.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29058);
      this.yllghcYE0S.Size = new Size(80, 20);
      this.yllghcYE0S.TabIndex = 1;
      this.yllghcYE0S.TextAlign = HorizontalAlignment.Right;
      NumericUpDown numericUpDown3 = this.yllghcYE0S;
      int[] bits3 = new int[4];
      bits3[0] = 60;
      Decimal num3 = new Decimal(bits3);
      numericUpDown3.Value = num3;
      this.yllghcYE0S.ValueChanged += new EventHandler(this.jdPuX47QKj);
      this.fovgeTeQKD.Location = new Point(272, 24);
      this.fovgeTeQKD.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29082);
      this.fovgeTeQKD.Size = new Size(56, 16);
      this.fovgeTeQKD.TabIndex = 0;
      this.fovgeTeQKD.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29098);
      this.fovgeTeQKD.TextAlign = ContentAlignment.MiddleLeft;
      this.xZLgsFyR1P.Location = new Point(8, 184);
      this.xZLgsFyR1P.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29118);
      this.xZLgsFyR1P.Size = new Size(448, 20);
      this.xZLgsFyR1P.TabIndex = 3;
      this.mgNgYYRPpu.Location = new Point(272, 216);
      this.mgNgYYRPpu.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29144);
      this.mgNgYYRPpu.Size = new Size(80, 24);
      this.mgNgYYRPpu.TabIndex = 5;
      this.mgNgYYRPpu.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29162);
      this.mgNgYYRPpu.Click += new EventHandler(this.SH5uCsCZTM);
      this.WIVgxlyXXL.DialogResult = DialogResult.Cancel;
      this.WIVgxlyXXL.Location = new Point(368, 216);
      this.WIVgxlyXXL.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29174);
      this.WIVgxlyXXL.Size = new Size(80, 24);
      this.WIVgxlyXXL.TabIndex = 6;
      this.WIVgxlyXXL.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29194);
      this.VXugFYcElV.Location = new Point(8, 160);
      this.VXugFYcElV.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29208);
      this.VXugFYcElV.Size = new Size(448, 16);
      this.VXugFYcElV.TabIndex = 7;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.WIVgxlyXXL;
      this.ClientSize = new Size(466, (int) byte.MaxValue);
      this.Controls.Add((Control) this.VXugFYcElV);
      this.Controls.Add((Control) this.WIVgxlyXXL);
      this.Controls.Add((Control) this.mgNgYYRPpu);
      this.Controls.Add((Control) this.xZLgsFyR1P);
      this.Controls.Add((Control) this.a8kgdNRPPZ);
      this.Controls.Add((Control) this.aSZuBj7N1r);
      this.Controls.Add((Control) this.B0FuoBuajY);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29226);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29254);
      this.B0FuoBuajY.ResumeLayout(false);
      this.aSZuBj7N1r.ResumeLayout(false);
      this.a8kgdNRPPZ.ResumeLayout(false);
      this.yllghcYE0S.EndInit();
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SH5uCsCZTM([In] object obj0, [In] EventArgs obj1)
    {
      this.InDuzorDTN.Enabled = false;
      this.a8kgdNRPPZ.Enabled = false;
      this.mgNgYYRPpu.Enabled = false;
      this.WIVgxlyXXL.Enabled = false;
      this.AuauQBi8MV = (BarType) this.wbYg1gUF09.SelectedItem;
      new Thread(new ThreadStart(this.auBuNyxC5G)).Start();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LgOu2aQsxW([In] object obj0, [In] EventArgs obj1)
    {
      this.crIuKCOCsn();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void jdPuX47QKj([In] object obj0, [In] EventArgs obj1)
    {
      this.crIuKCOCsn();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void crIuKCOCsn()
    {
      string name = this.NkcuEat6q3.Name;
      this.OiiuABVuho.Text = name;
      try
      {
        this.InDuzorDTN.Text = name.Split(new char[1]
        {
          '.'
        })[0] + (object) '.' + RNaihRhYEl0wUmAftnB.aYu7exFQKN(29284) + (string) (object) '.' + this.wbYg1gUF09.SelectedItem.ToString() + (string) (object) '.' + (long) this.yllghcYE0S.Value.ToString();
      }
      catch
      {
        this.InDuzorDTN.Text = name;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void tb1umaM8wV(params object[] args)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new BarMakerForm.dERlAwt80RDkUMfQwj(this.tb1umaM8wV), new object[1]
        {
          (object) args
        });
      else
        this.VXugFYcElV.Text = (string) args[0];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void or3uwmNsMC(params object[] args)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new BarMakerForm.dERlAwt80RDkUMfQwj(this.or3uwmNsMC), new object[1]
        {
          (object) args
        });
      else
        this.xZLgsFyR1P.Value = (int) args[0];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Dhsu0b1ZWm(params object[] args)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) new BarMakerForm.dERlAwt80RDkUMfQwj(this.Dhsu0b1ZWm), new object[1]
        {
          (object) args
        });
      }
      else
      {
        int num = (int) MessageBox.Show((IWin32Window) this, (string) args[0], RNaihRhYEl0wUmAftnB.aYu7exFQKN(29294), MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void KpSupXOOeG()
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new MethodInvoker(this.KpSupXOOeG));
      else
        this.WIVgxlyXXL.Enabled = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void auBuNyxC5G()
    {
      try
      {
        string name = this.InDuzorDTN.Text.Trim();
        FileSeries fileSeries = this.N9jutll7YX.Series[name] ?? this.N9jutll7YX.Series.Add(name);
        this.tb1umaM8wV(new object[1]
        {
          (object) (this.NkcuEat6q3.Name + RNaihRhYEl0wUmAftnB.aYu7exFQKN(29308) + fileSeries.Name)
        });
        this.or3uwmNsMC(new object[1]
        {
          (object) 50
        });
        BarMaker.MakeBars((IDataSeries) this.NkcuEat6q3, (IDataSeries) fileSeries, this.AuauQBi8MV, (long) this.yllghcYE0S.Value);
        this.or3uwmNsMC(new object[1]
        {
          (object) 100
        });
        fileSeries.Flush();
      }
      catch (Exception ex)
      {
        if (Trace.IsLevelEnabled(TraceLevel.Error))
          Trace.WriteLine(((object) ex).ToString());
        this.Dhsu0b1ZWm(new object[1]
        {
          (object) (RNaihRhYEl0wUmAftnB.aYu7exFQKN(29322) + Environment.NewLine + Environment.NewLine + ex.Message + Environment.NewLine + Environment.NewLine + RNaihRhYEl0wUmAftnB.aYu7exFQKN(29396))
        });
      }
      finally
      {
        this.tb1umaM8wV(new object[1]
        {
          (object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(29450)
        });
        this.KpSupXOOeG();
      }
    }

    private delegate void dERlAwt80RDkUMfQwj(params object[] args);
  }
}
