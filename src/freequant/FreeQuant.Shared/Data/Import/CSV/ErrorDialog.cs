// Type: SmartQuant.Shared.Data.Import.CSV.ErrorDialog
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class ErrorDialog : Form
  {
    private ErrorDialog.Result l8fKaEZ51;
    private ListView TA5mQZ64t;
    private Panel ksRwIN1Yx;
    private Label Qmd0xGKus;
    private Label gIipe64SM;
    private Panel rfKNWplsf;
    private Label rfZttgRJX;
    private Label dwtEcJHif;
    private Button axtQWG9el;
    private Button VC3vv1YLi;
    private Button WJAosA6Fq;
    private Container WhLPOkrsl;

    public ErrorDialog.Result DialogResult
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.l8fKaEZ51;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ErrorDialog()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.RSJqePpaL();
      this.l8fKaEZ51 = ErrorDialog.Result.None;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.WhLPOkrsl != null)
        this.WhLPOkrsl.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RSJqePpaL()
    {
      ResourceManager resourceManager = new ResourceManager(typeof (ErrorDialog));
      this.TA5mQZ64t = new ListView();
      this.ksRwIN1Yx = new Panel();
      this.gIipe64SM = new Label();
      this.Qmd0xGKus = new Label();
      this.rfKNWplsf = new Panel();
      this.rfZttgRJX = new Label();
      this.dwtEcJHif = new Label();
      this.axtQWG9el = new Button();
      this.VC3vv1YLi = new Button();
      this.WJAosA6Fq = new Button();
      this.ksRwIN1Yx.SuspendLayout();
      this.rfKNWplsf.SuspendLayout();
      this.SuspendLayout();
      this.TA5mQZ64t.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.TA5mQZ64t.HideSelection = false;
      this.TA5mQZ64t.Location = new Point(16, 80);
      this.TA5mQZ64t.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(918);
      this.TA5mQZ64t.Size = new Size(632, 64);
      this.TA5mQZ64t.TabIndex = 0;
      this.TA5mQZ64t.View = View.Details;
      this.ksRwIN1Yx.Controls.Add((Control) this.gIipe64SM);
      this.ksRwIN1Yx.Controls.Add((Control) this.Qmd0xGKus);
      this.ksRwIN1Yx.Location = new Point(16, 16);
      this.ksRwIN1Yx.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(944);
      this.ksRwIN1Yx.Size = new Size(616, 20);
      this.ksRwIN1Yx.TabIndex = 1;
      this.gIipe64SM.Dock = DockStyle.Fill;
      this.gIipe64SM.Location = new Point(64, 0);
      this.gIipe64SM.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(960);
      this.gIipe64SM.Size = new Size(552, 20);
      this.gIipe64SM.TabIndex = 1;
      this.gIipe64SM.TextAlign = ContentAlignment.MiddleLeft;
      this.Qmd0xGKus.Dock = DockStyle.Left;
      this.Qmd0xGKus.Location = new Point(0, 0);
      this.Qmd0xGKus.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(978);
      this.Qmd0xGKus.Size = new Size(64, 20);
      this.Qmd0xGKus.TabIndex = 0;
      this.Qmd0xGKus.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(994);
      this.Qmd0xGKus.TextAlign = ContentAlignment.MiddleLeft;
      this.rfKNWplsf.Controls.Add((Control) this.rfZttgRJX);
      this.rfKNWplsf.Controls.Add((Control) this.dwtEcJHif);
      this.rfKNWplsf.Location = new Point(16, 40);
      this.rfKNWplsf.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1008);
      this.rfKNWplsf.Size = new Size(616, 32);
      this.rfKNWplsf.TabIndex = 2;
      this.rfZttgRJX.Dock = DockStyle.Fill;
      this.rfZttgRJX.Location = new Point(64, 0);
      this.rfZttgRJX.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1024);
      this.rfZttgRJX.Size = new Size(552, 32);
      this.rfZttgRJX.TabIndex = 1;
      this.dwtEcJHif.Dock = DockStyle.Left;
      this.dwtEcJHif.Location = new Point(0, 0);
      this.dwtEcJHif.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1048);
      this.dwtEcJHif.Size = new Size(64, 32);
      this.dwtEcJHif.TabIndex = 0;
      this.dwtEcJHif.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1064);
      this.axtQWG9el.Location = new Point(360, 160);
      this.axtQWG9el.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1084);
      this.axtQWG9el.Size = new Size(80, 24);
      this.axtQWG9el.TabIndex = 3;
      this.axtQWG9el.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1106);
      this.axtQWG9el.Click += new EventHandler(this.LyxC4W3wv);
      this.VC3vv1YLi.Location = new Point(560, 160);
      this.VC3vv1YLi.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1122);
      this.VC3vv1YLi.Size = new Size(80, 24);
      this.VC3vv1YLi.TabIndex = 4;
      this.VC3vv1YLi.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1140);
      this.VC3vv1YLi.Click += new EventHandler(this.zlg25nOdj);
      this.WJAosA6Fq.Location = new Point(448, 160);
      this.WJAosA6Fq.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1152);
      this.WJAosA6Fq.Size = new Size(80, 24);
      this.WJAosA6Fq.TabIndex = 5;
      this.WJAosA6Fq.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1178);
      this.WJAosA6Fq.Click += new EventHandler(this.L3NXk6JLq);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(664, 199);
      this.Controls.Add((Control) this.WJAosA6Fq);
      this.Controls.Add((Control) this.VC3vv1YLi);
      this.Controls.Add((Control) this.axtQWG9el);
      this.Controls.Add((Control) this.rfKNWplsf);
      this.Controls.Add((Control) this.ksRwIN1Yx);
      this.Controls.Add((Control) this.TA5mQZ64t);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) resourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(1200));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1224);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(1250);
      this.ksRwIN1Yx.ResumeLayout(false);
      this.rfKNWplsf.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnClosing(CancelEventArgs e)
    {
      e.Cancel = this.l8fKaEZ51 == ErrorDialog.Result.None;
      base.OnClosing(e);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetError(Template template, ErrorEventArgs args)
    {
      this.gIipe64SM.Text = args.File.FullName;
      this.rfZttgRJX.Text = args.Message;
      this.TA5mQZ64t.Columns.Add(RNaihRhYEl0wUmAftnB.aYu7exFQKN(1328), 60, HorizontalAlignment.Left);
      foreach (Column column in (CollectionBase) template.Columns)
      {
        string text = Column.ToString(column.ColumnType);
        if (column.ColumnFormat != "")
          text = text + RNaihRhYEl0wUmAftnB.aYu7exFQKN(1344) + column.ColumnFormat + RNaihRhYEl0wUmAftnB.aYu7exFQKN(1352);
        this.TA5mQZ64t.Columns.Add(text, 100, HorizontalAlignment.Center);
      }
      ListViewItem listViewItem = new ListViewItem(args.Row.ToString());
      listViewItem.UseItemStyleForSubItems = false;
      string[] strArray = args.Line.Split((char[]) template.CSVOptions.Separator);
      for (int index = 0; index < strArray.Length; ++index)
        listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem()
        {
          Text = strArray[index],
          BackColor = index == args.Column ? Color.Red : listViewItem.BackColor
        });
      this.TA5mQZ64t.Items.Add(listViewItem);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LyxC4W3wv([In] object obj0, [In] EventArgs obj1)
    {
      this.l8fKaEZ51 = ErrorDialog.Result.Ignore;
      this.Close();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void zlg25nOdj([In] object obj0, [In] EventArgs obj1)
    {
      this.l8fKaEZ51 = ErrorDialog.Result.Stop;
      this.Close();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void L3NXk6JLq([In] object obj0, [In] EventArgs obj1)
    {
      this.l8fKaEZ51 = ErrorDialog.Result.SkipFile;
      this.Close();
    }

    public enum Result
    {
      None,
      Ignore,
      Stop,
      SkipFile,
    }
  }
}
