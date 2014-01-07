// Type: SmartQuant.Shared.Data.Import.TAQ.TAQImportForm
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.TAQ
{
  public class TAQImportForm : Form
  {
    private string[] lCBg3KbIj8;
    private Label uCsgWk8vX0;
    private TextBox dIhgTXFKKW;
    private Button RjigfHJyNx;
    private RadioButton TJwgylPw5p;
    private RadioButton kFDgOTJaFb;
    private TextBox j5jgatsMIh;
    private Label N0jgGHoRAX;
    private GroupBox KGvgZkoscj;
    private ProgressBar J8dg4Fk4Kt;
    private RadioButton hDjgIMkWvV;
    private RadioButton sKcgS1rIWT;
    private Button LSLgUOfD5j;
    private Button qAZgjdlHht;
    private Button YK9g6DedP5;
    private GroupBox LGVgrZY4yT;
    private GroupBox IYxg8nGt37;
    private GroupBox T5Xg5R9FoZ;
    private RadioButton aNdgq2votA;
    private RadioButton TXcgCaoj4c;
    private RadioButton fbdg2QpLdD;
    private Button sfGgXgaTGh;
    private Container RF2gKyD1fO;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TAQImportForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.GHqgbF9nxf();
      this.lCBg3KbIj8 = new string[0];
      Importer.Stopped += new EventHandler(this.wRogMrJvSG);
      Importer.Progress += new EventHandler(this.DQ5gJQRaht);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.RF2gKyD1fO != null)
        this.RF2gKyD1fO.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnClosing(CancelEventArgs e)
    {
      if (this.YK9g6DedP5.Enabled)
      {
        Importer.Stopped -= new EventHandler(this.wRogMrJvSG);
        Importer.Progress -= new EventHandler(this.DQ5gJQRaht);
        Importer.Dispose();
      }
      else
        e.Cancel = true;
      base.OnClosing(e);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GHqgbF9nxf()
    {
      ResourceManager resourceManager = new ResourceManager(typeof (TAQImportForm));
      this.uCsgWk8vX0 = new Label();
      this.dIhgTXFKKW = new TextBox();
      this.RjigfHJyNx = new Button();
      this.LGVgrZY4yT = new GroupBox();
      this.TJwgylPw5p = new RadioButton();
      this.kFDgOTJaFb = new RadioButton();
      this.j5jgatsMIh = new TextBox();
      this.N0jgGHoRAX = new Label();
      this.KGvgZkoscj = new GroupBox();
      this.J8dg4Fk4Kt = new ProgressBar();
      this.IYxg8nGt37 = new GroupBox();
      this.hDjgIMkWvV = new RadioButton();
      this.sKcgS1rIWT = new RadioButton();
      this.LSLgUOfD5j = new Button();
      this.qAZgjdlHht = new Button();
      this.YK9g6DedP5 = new Button();
      this.T5Xg5R9FoZ = new GroupBox();
      this.sfGgXgaTGh = new Button();
      this.fbdg2QpLdD = new RadioButton();
      this.TXcgCaoj4c = new RadioButton();
      this.aNdgq2votA = new RadioButton();
      this.LGVgrZY4yT.SuspendLayout();
      this.KGvgZkoscj.SuspendLayout();
      this.IYxg8nGt37.SuspendLayout();
      this.T5Xg5R9FoZ.SuspendLayout();
      this.SuspendLayout();
      this.uCsgWk8vX0.Location = new Point(16, 16);
      this.uCsgWk8vX0.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29464);
      this.uCsgWk8vX0.Size = new Size(80, 16);
      this.uCsgWk8vX0.TabIndex = 0;
      this.uCsgWk8vX0.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29480);
      this.uCsgWk8vX0.TextAlign = ContentAlignment.MiddleLeft;
      this.dIhgTXFKKW.Location = new Point(104, 16);
      this.dIhgTXFKKW.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29510);
      this.dIhgTXFKKW.ReadOnly = true;
      this.dIhgTXFKKW.Size = new Size(272, 20);
      this.dIhgTXFKKW.TabIndex = 2;
      this.dIhgTXFKKW.Text = "";
      this.RjigfHJyNx.Location = new Point(392, 16);
      this.RjigfHJyNx.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29536);
      this.RjigfHJyNx.Size = new Size(64, 20);
      this.RjigfHJyNx.TabIndex = 4;
      this.RjigfHJyNx.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29574);
      this.RjigfHJyNx.Click += new EventHandler(this.R4ngVjrYLE);
      this.LGVgrZY4yT.Controls.Add((Control) this.TJwgylPw5p);
      this.LGVgrZY4yT.Controls.Add((Control) this.kFDgOTJaFb);
      this.LGVgrZY4yT.Location = new Point(240, 72);
      this.LGVgrZY4yT.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29598);
      this.LGVgrZY4yT.Size = new Size(216, 80);
      this.LGVgrZY4yT.TabIndex = 7;
      this.LGVgrZY4yT.TabStop = false;
      this.LGVgrZY4yT.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29628);
      this.TJwgylPw5p.Location = new Point(16, 48);
      this.TJwgylPw5p.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29654);
      this.TJwgylPw5p.Size = new Size(56, 16);
      this.TJwgylPw5p.TabIndex = 1;
      this.TJwgylPw5p.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29680);
      this.kFDgOTJaFb.Checked = true;
      this.kFDgOTJaFb.Location = new Point(16, 24);
      this.kFDgOTJaFb.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29692);
      this.kFDgOTJaFb.Size = new Size(48, 16);
      this.kFDgOTJaFb.TabIndex = 0;
      this.kFDgOTJaFb.TabStop = true;
      this.kFDgOTJaFb.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29718);
      this.j5jgatsMIh.Location = new Point(104, 40);
      this.j5jgatsMIh.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29728);
      this.j5jgatsMIh.ReadOnly = true;
      this.j5jgatsMIh.Size = new Size(272, 20);
      this.j5jgatsMIh.TabIndex = 10;
      this.j5jgatsMIh.Text = "";
      this.N0jgGHoRAX.Location = new Point(16, 40);
      this.N0jgGHoRAX.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29756);
      this.N0jgGHoRAX.Size = new Size(80, 16);
      this.N0jgGHoRAX.TabIndex = 11;
      this.N0jgGHoRAX.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29772);
      this.N0jgGHoRAX.TextAlign = ContentAlignment.MiddleLeft;
      this.KGvgZkoscj.Controls.Add((Control) this.J8dg4Fk4Kt);
      this.KGvgZkoscj.Location = new Point(8, 280);
      this.KGvgZkoscj.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29804);
      this.KGvgZkoscj.Size = new Size(456, 48);
      this.KGvgZkoscj.TabIndex = 14;
      this.KGvgZkoscj.TabStop = false;
      this.J8dg4Fk4Kt.Location = new Point(8, 16);
      this.J8dg4Fk4Kt.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29826);
      this.J8dg4Fk4Kt.Size = new Size(440, 20);
      this.J8dg4Fk4Kt.TabIndex = 0;
      this.IYxg8nGt37.Controls.Add((Control) this.hDjgIMkWvV);
      this.IYxg8nGt37.Controls.Add((Control) this.sKcgS1rIWT);
      this.IYxg8nGt37.Location = new Point(16, 72);
      this.IYxg8nGt37.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29852);
      this.IYxg8nGt37.Size = new Size(208, 80);
      this.IYxg8nGt37.TabIndex = 15;
      this.IYxg8nGt37.TabStop = false;
      this.IYxg8nGt37.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29878);
      this.hDjgIMkWvV.Checked = true;
      this.hDjgIMkWvV.Location = new Point(16, 24);
      this.hDjgIMkWvV.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29900);
      this.hDjgIMkWvV.Size = new Size(56, 16);
      this.hDjgIMkWvV.TabIndex = 1;
      this.hDjgIMkWvV.TabStop = true;
      this.hDjgIMkWvV.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29922);
      this.sKcgS1rIWT.Location = new Point(16, 48);
      this.sKcgS1rIWT.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29938);
      this.sKcgS1rIWT.Size = new Size(64, 16);
      this.sKcgS1rIWT.TabIndex = 0;
      this.sKcgS1rIWT.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29960);
      this.LSLgUOfD5j.Enabled = false;
      this.LSLgUOfD5j.Location = new Point(160, 336);
      this.LSLgUOfD5j.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29976);
      this.LSLgUOfD5j.Size = new Size(72, 24);
      this.LSLgUOfD5j.TabIndex = 16;
      this.LSLgUOfD5j.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(29998);
      this.LSLgUOfD5j.Click += new EventHandler(this.LAngROi4Oc);
      this.qAZgjdlHht.Enabled = false;
      this.qAZgjdlHht.Location = new Point(240, 336);
      this.qAZgjdlHht.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(30014);
      this.qAZgjdlHht.Size = new Size(72, 24);
      this.qAZgjdlHht.TabIndex = 17;
      this.qAZgjdlHht.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(30032);
      this.qAZgjdlHht.Click += new EventHandler(this.aPngHtuc1w);
      this.YK9g6DedP5.DialogResult = DialogResult.Cancel;
      this.YK9g6DedP5.Location = new Point(384, 336);
      this.YK9g6DedP5.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(30044);
      this.YK9g6DedP5.Size = new Size(72, 24);
      this.YK9g6DedP5.TabIndex = 18;
      this.YK9g6DedP5.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(30064);
      this.T5Xg5R9FoZ.Controls.Add((Control) this.sfGgXgaTGh);
      this.T5Xg5R9FoZ.Controls.Add((Control) this.fbdg2QpLdD);
      this.T5Xg5R9FoZ.Controls.Add((Control) this.TXcgCaoj4c);
      this.T5Xg5R9FoZ.Controls.Add((Control) this.aNdgq2votA);
      this.T5Xg5R9FoZ.Location = new Point(16, 160);
      this.T5Xg5R9FoZ.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(30078);
      this.T5Xg5R9FoZ.Size = new Size(440, 104);
      this.T5Xg5R9FoZ.TabIndex = 20;
      this.T5Xg5R9FoZ.TabStop = false;
      this.T5Xg5R9FoZ.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(30100);
      this.sfGgXgaTGh.Enabled = false;
      this.sfGgXgaTGh.Location = new Point(160, 68);
      this.sfGgXgaTGh.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(30116);
      this.sfGgXgaTGh.Size = new Size(168, 20);
      this.sfGgXgaTGh.TabIndex = 3;
      this.sfGgXgaTGh.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(30138);
      this.sfGgXgaTGh.Click += new EventHandler(this.phCggP0b8F);
      this.fbdg2QpLdD.Location = new Point(16, 72);
      this.fbdg2QpLdD.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(30160);
      this.fbdg2QpLdD.Size = new Size(136, 16);
      this.fbdg2QpLdD.TabIndex = 2;
      this.fbdg2QpLdD.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(30182);
      this.fbdg2QpLdD.CheckedChanged += new EventHandler(this.TK5guomajs);
      this.TXcgCaoj4c.Checked = true;
      this.TXcgCaoj4c.Location = new Point(16, 48);
      this.TXcgCaoj4c.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(30198);
      this.TXcgCaoj4c.Size = new Size(136, 16);
      this.TXcgCaoj4c.TabIndex = 1;
      this.TXcgCaoj4c.TabStop = true;
      this.TXcgCaoj4c.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(30226);
      this.TXcgCaoj4c.CheckedChanged += new EventHandler(this.M9sglvNEc5);
      this.aNdgq2votA.Location = new Point(16, 24);
      this.aNdgq2votA.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(30272);
      this.aNdgq2votA.Size = new Size(136, 16);
      this.aNdgq2votA.TabIndex = 0;
      this.aNdgq2votA.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(30288);
      this.aNdgq2votA.CheckedChanged += new EventHandler(this.PAQgkxprI7);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.YK9g6DedP5;
      this.ClientSize = new Size(474, 375);
      this.Controls.Add((Control) this.T5Xg5R9FoZ);
      this.Controls.Add((Control) this.YK9g6DedP5);
      this.Controls.Add((Control) this.qAZgjdlHht);
      this.Controls.Add((Control) this.LSLgUOfD5j);
      this.Controls.Add((Control) this.IYxg8nGt37);
      this.Controls.Add((Control) this.KGvgZkoscj);
      this.Controls.Add((Control) this.N0jgGHoRAX);
      this.Controls.Add((Control) this.j5jgatsMIh);
      this.Controls.Add((Control) this.dIhgTXFKKW);
      this.Controls.Add((Control) this.LGVgrZY4yT);
      this.Controls.Add((Control) this.RjigfHJyNx);
      this.Controls.Add((Control) this.uCsgWk8vX0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.HelpButton = true;
      this.Icon = (Icon) resourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(30314));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(30338);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(30368);
      this.LGVgrZY4yT.ResumeLayout(false);
      this.KGvgZkoscj.ResumeLayout(false);
      this.IYxg8nGt37.ResumeLayout(false);
      this.T5Xg5R9FoZ.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void R4ngVjrYLE([In] object obj0, [In] EventArgs obj1)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Multiselect = false;
      openFileDialog.Filter = RNaihRhYEl0wUmAftnB.aYu7exFQKN(30428);
      if (this.dIhgTXFKKW.Text != "")
        openFileDialog.FileName = this.dIhgTXFKKW.Text;
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        string fileName = openFileDialog.FileName;
        this.dIhgTXFKKW.Text = fileName;
        this.j5jgatsMIh.Text = fileName.Substring(0, fileName.LastIndexOf(RNaihRhYEl0wUmAftnB.aYu7exFQKN(30486))) + RNaihRhYEl0wUmAftnB.aYu7exFQKN(30492);
      }
      this.otUgndZZ4J();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LAngROi4Oc([In] object obj0, [In] EventArgs obj1)
    {
      this.a0NgiAnSj1();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void aPngHtuc1w([In] object obj0, [In] EventArgs obj1)
    {
      Importer.Stop();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PAQgkxprI7([In] object obj0, [In] EventArgs obj1)
    {
      this.m14g7l66bl();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void M9sglvNEc5([In] object obj0, [In] EventArgs obj1)
    {
      this.m14g7l66bl();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TK5guomajs([In] object obj0, [In] EventArgs obj1)
    {
      this.m14g7l66bl();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void phCggP0b8F([In] object obj0, [In] EventArgs obj1)
    {
      BrowseSymbolForm browseSymbolForm = new BrowseSymbolForm();
      browseSymbolForm.SelectedSymbols = this.lCBg3KbIj8;
      if (browseSymbolForm.ShowDialog((IWin32Window) this) == DialogResult.OK)
        this.lCBg3KbIj8 = browseSymbolForm.SelectedSymbols;
      browseSymbolForm.Dispose();
      this.sfGgXgaTGh.Text = string.Format(RNaihRhYEl0wUmAftnB.aYu7exFQKN(30504), (object) this.lCBg3KbIj8.Length);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void wRogMrJvSG([In] object obj0, [In] EventArgs obj1)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new EventHandler(this.wRogMrJvSG), obj0, (object) obj1);
      else
        this.nTUgL7cMky(true);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DQ5gJQRaht([In] object obj0, [In] EventArgs obj1)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new EventHandler(this.DQ5gJQRaht), obj0, (object) obj1);
      else
        this.J8dg4Fk4Kt.Value = Importer.PercentDone;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void otUgndZZ4J()
    {
      this.LSLgUOfD5j.Enabled = this.dIhgTXFKKW.Text != "";
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void m14g7l66bl()
    {
      this.sfGgXgaTGh.Enabled = this.fbdg2QpLdD.Checked;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void nTUgL7cMky([In] bool obj0)
    {
      this.RjigfHJyNx.Enabled = obj0;
      this.IYxg8nGt37.Enabled = obj0;
      this.LGVgrZY4yT.Enabled = obj0;
      this.T5Xg5R9FoZ.Enabled = obj0;
      this.LSLgUOfD5j.Enabled = obj0;
      this.qAZgjdlHht.Enabled = !obj0;
      this.YK9g6DedP5.Enabled = obj0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void a0NgiAnSj1()
    {
      this.J8dg4Fk4Kt.Value = 0;
      this.nTUgL7cMky(false);
      Importer.SetSettings(this.AB7g93gpbe());
      Importer.Start();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ImportSettings AB7g93gpbe()
    {
      ImportSettings importSettings = new ImportSettings();
      importSettings.TAQDataFile = new FileInfo(this.dIhgTXFKKW.Text);
      importSettings.TAQIndexFile = new FileInfo(this.j5jgatsMIh.Text);
      if (this.kFDgOTJaFb.Checked)
        importSettings.DataFormatVersion = DataFormatVersion.Version1;
      if (this.TJwgylPw5p.Checked)
        importSettings.DataFormatVersion = DataFormatVersion.Version2;
      if (this.hDjgIMkWvV.Checked)
        importSettings.DataType = DataType.Quotes;
      if (this.sKcgS1rIWT.Checked)
        importSettings.DataType = DataType.Trades;
      if (this.aNdgq2votA.Checked)
        importSettings.SymbolOption = SymbolOption.All;
      if (this.TXcgCaoj4c.Checked)
        importSettings.SymbolOption = SymbolOption.Existents;
      if (this.fbdg2QpLdD.Checked)
        importSettings.SymbolOption = SymbolOption.Custom;
      importSettings.Symbols = this.lCBg3KbIj8;
      return importSettings;
    }
  }
}
