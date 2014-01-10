using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace FreeQuant.Shared.Data.Import.HistoricalData
{
  public class DownloadForm : Form
  {
    private IContainer KoHkSFwpQh;
    private ListView vY9kUsI2Ej;
    private ColumnHeader lPvkj0Ndeh;
    private ColumnHeader Noyk6thNcB;
    private ColumnHeader gkZkrB8mQD;
    private ColumnHeader B5pk8jHQYX;
    private Button qy2k5NRmE4;
    private ImageList WNakqgKhty;
    private ContextMenuStrip R4pkC7FUJ5;
    private ToolStripMenuItem dVWk21DFUE;
    private Button Do1kX8Voem;
    private ProgressBar YhakKNtGsn;
    private Button srEkmli0kD;
    private TabControl TTEkwwnSFG;
    private TabPage Eavk0sM3Zx;
    private GroupBox i0nkpjc7Mk;
    private DateTimePicker CuMkNNYEDG;
    private DateTimePicker Nk6ktIV1Ba;
    private Label YMZkELWOqr;
    private TabPage lpqkQ3VDOM;
    private Label FflkvgcUww;
    private Label NfekouVArc;
    private ComboBox j4UkPEuPyL;
    private GroupBox vWUkAGiTtg;
    private Label IAVkBlDVxf;
    private TrackBar ItskcDWUqc;
    private TextBox HV3kzfxOak;
    private ColumnHeader cRLlehRDZd;
    private ComboBox UkjlhoxVlP;
    private Label CM4lsLEeIO;
    private CheckBox SOqlYER34W;
    private IHistoricalDataProvider tlNlxfyMLv;
    private Dictionary<string, HistoricalDataRequest> NLklDLbERp;
    private Dictionary<string, HistoricalDataRequest> hRhl1skFVG;
    private Dictionary<string, uRIUcg8mp5qy3pl442> V43ldlVmhs;
    private Dictionary<Instrument, dtWG9eTloC3v1YLiPJ> sUBlFVkkCB;
    private bool zw8lbdiSvG;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DownloadForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.kWZkbV0xiJ();
      this.NLklDLbERp = new Dictionary<string, HistoricalDataRequest>();
      this.hRhl1skFVG = new Dictionary<string, HistoricalDataRequest>();
      this.V43ldlVmhs = new Dictionary<string, uRIUcg8mp5qy3pl442>();
      this.sUBlFVkkCB = new Dictionary<Instrument, dtWG9eTloC3v1YLiPJ>();
      this.Nk6ktIV1Ba.Value = DateTime.Today.AddDays(-1.0);
      this.CuMkNNYEDG.Value = DateTime.Today;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.KoHkSFwpQh != null)
        this.KoHkSFwpQh.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void kWZkbV0xiJ()
    {
      this.KoHkSFwpQh = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (DownloadForm));
      this.vY9kUsI2Ej = new ListView();
      this.lPvkj0Ndeh = new ColumnHeader();
      this.Noyk6thNcB = new ColumnHeader();
      this.gkZkrB8mQD = new ColumnHeader();
      this.B5pk8jHQYX = new ColumnHeader();
      this.cRLlehRDZd = new ColumnHeader();
      this.R4pkC7FUJ5 = new ContextMenuStrip(this.KoHkSFwpQh);
      this.dVWk21DFUE = new ToolStripMenuItem();
      this.WNakqgKhty = new ImageList(this.KoHkSFwpQh);
      this.qy2k5NRmE4 = new Button();
      this.Do1kX8Voem = new Button();
      this.YhakKNtGsn = new ProgressBar();
      this.srEkmli0kD = new Button();
      this.TTEkwwnSFG = new TabControl();
      this.Eavk0sM3Zx = new TabPage();
      this.i0nkpjc7Mk = new GroupBox();
      this.UkjlhoxVlP = new ComboBox();
      this.CM4lsLEeIO = new Label();
      this.j4UkPEuPyL = new ComboBox();
      this.FflkvgcUww = new Label();
      this.NfekouVArc = new Label();
      this.CuMkNNYEDG = new DateTimePicker();
      this.Nk6ktIV1Ba = new DateTimePicker();
      this.YMZkELWOqr = new Label();
      this.lpqkQ3VDOM = new TabPage();
      this.vWUkAGiTtg = new GroupBox();
      this.ItskcDWUqc = new TrackBar();
      this.HV3kzfxOak = new TextBox();
      this.IAVkBlDVxf = new Label();
      this.SOqlYER34W = new CheckBox();
      this.R4pkC7FUJ5.SuspendLayout();
      this.TTEkwwnSFG.SuspendLayout();
      this.Eavk0sM3Zx.SuspendLayout();
      this.i0nkpjc7Mk.SuspendLayout();
      this.lpqkQ3VDOM.SuspendLayout();
      this.vWUkAGiTtg.SuspendLayout();
      this.ItskcDWUqc.BeginInit();
      this.SuspendLayout();
      this.vY9kUsI2Ej.Columns.AddRange(new ColumnHeader[5]
      {
        this.lPvkj0Ndeh,
        this.Noyk6thNcB,
        this.gkZkrB8mQD,
        this.B5pk8jHQYX,
        this.cRLlehRDZd
      });
      this.vY9kUsI2Ej.ContextMenuStrip = this.R4pkC7FUJ5;
      this.vY9kUsI2Ej.FullRowSelect = true;
      this.vY9kUsI2Ej.GridLines = true;
      this.vY9kUsI2Ej.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.vY9kUsI2Ej.HideSelection = false;
      this.vY9kUsI2Ej.Location = new Point(8, 104);
      this.vY9kUsI2Ej.MultiSelect = false;
      this.vY9kUsI2Ej.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(19472);
      this.vY9kUsI2Ej.ShowGroups = false;
      this.vY9kUsI2Ej.ShowItemToolTips = true;
      this.vY9kUsI2Ej.Size = new Size(510, 217);
      this.vY9kUsI2Ej.SmallImageList = this.WNakqgKhty;
      this.vY9kUsI2Ej.TabIndex = 0;
      this.vY9kUsI2Ej.UseCompatibleStateImageBehavior = false;
      this.vY9kUsI2Ej.View = View.Details;
      this.lPvkj0Ndeh.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(19498);
      this.lPvkj0Ndeh.Width = 96;
      this.Noyk6thNcB.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(19514);
      this.Noyk6thNcB.TextAlign = HorizontalAlignment.Right;
      this.Noyk6thNcB.Width = 92;
      this.gkZkrB8mQD.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(19530);
      this.gkZkrB8mQD.TextAlign = HorizontalAlignment.Right;
      this.gkZkrB8mQD.Width = 101;
      this.B5pk8jHQYX.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(19544);
      this.B5pk8jHQYX.TextAlign = HorizontalAlignment.Right;
      this.B5pk8jHQYX.Width = 103;
      this.cRLlehRDZd.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(19558);
      this.cRLlehRDZd.Width = 91;
      this.R4pkC7FUJ5.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.dVWk21DFUE
      });
      this.R4pkC7FUJ5.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(19576);
      this.R4pkC7FUJ5.Size = new Size(235, 26);
      this.R4pkC7FUJ5.Opening += new CancelEventHandler(this.EmgkftmnIY);
      this.dVWk21DFUE.Image = (Image) componentResourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(19602));
      this.dVWk21DFUE.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(19682);
      this.dVWk21DFUE.Size = new Size(234, 22);
      this.dVWk21DFUE.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(19750);
      this.dVWk21DFUE.Click += new EventHandler(this.CXZkyy1EdI);
      this.WNakqgKhty.ImageStream = (ImageListStreamer) componentResourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(19810));
      this.WNakqgKhty.TransparentColor = Color.Transparent;
      this.WNakqgKhty.Images.SetKeyName(0, RNaihRhYEl0wUmAftnB.aYu7exFQKN(19850));
      this.WNakqgKhty.Images.SetKeyName(1, RNaihRhYEl0wUmAftnB.aYu7exFQKN(19880));
      this.WNakqgKhty.Images.SetKeyName(2, RNaihRhYEl0wUmAftnB.aYu7exFQKN(19908));
      this.WNakqgKhty.Images.SetKeyName(3, RNaihRhYEl0wUmAftnB.aYu7exFQKN(19934));
      this.WNakqgKhty.Images.SetKeyName(4, RNaihRhYEl0wUmAftnB.aYu7exFQKN(19966));
      this.qy2k5NRmE4.Location = new Point(536, 104);
      this.qy2k5NRmE4.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20002);
      this.qy2k5NRmE4.Size = new Size(80, 22);
      this.qy2k5NRmE4.TabIndex = 1;
      this.qy2k5NRmE4.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20028);
      this.qy2k5NRmE4.UseVisualStyleBackColor = true;
      this.qy2k5NRmE4.Click += new EventHandler(this.mlykVinkmu);
      this.Do1kX8Voem.DialogResult = DialogResult.Cancel;
      this.Do1kX8Voem.Location = new Point(536, 302);
      this.Do1kX8Voem.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20048);
      this.Do1kX8Voem.Size = new Size(80, 22);
      this.Do1kX8Voem.TabIndex = 3;
      this.Do1kX8Voem.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20068);
      this.Do1kX8Voem.UseVisualStyleBackColor = true;
      this.YhakKNtGsn.Location = new Point(8, 335);
      this.YhakKNtGsn.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20082);
      this.YhakKNtGsn.Size = new Size(510, 17);
      this.YhakKNtGsn.TabIndex = 4;
      this.srEkmli0kD.Enabled = false;
      this.srEkmli0kD.Location = new Point(536, 136);
      this.srEkmli0kD.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20108);
      this.srEkmli0kD.Size = new Size(80, 22);
      this.srEkmli0kD.TabIndex = 5;
      this.srEkmli0kD.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20126);
      this.srEkmli0kD.UseVisualStyleBackColor = true;
      this.srEkmli0kD.Click += new EventHandler(this.JUykRXSZPA);
      this.TTEkwwnSFG.Controls.Add((Control) this.Eavk0sM3Zx);
      this.TTEkwwnSFG.Controls.Add((Control) this.lpqkQ3VDOM);
      this.TTEkwwnSFG.Location = new Point(8, 4);
      this.TTEkwwnSFG.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20138);
      this.TTEkwwnSFG.SelectedIndex = 0;
      this.TTEkwwnSFG.Size = new Size(624, 90);
      this.TTEkwwnSFG.TabIndex = 6;
      this.Eavk0sM3Zx.Controls.Add((Control) this.i0nkpjc7Mk);
      this.Eavk0sM3Zx.Location = new Point(4, 22);
      this.Eavk0sM3Zx.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20164);
      this.Eavk0sM3Zx.Size = new Size(616, 64);
      this.Eavk0sM3Zx.TabIndex = 0;
      this.Eavk0sM3Zx.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20184);
      this.Eavk0sM3Zx.UseVisualStyleBackColor = true;
      this.i0nkpjc7Mk.Controls.Add((Control) this.SOqlYER34W);
      this.i0nkpjc7Mk.Controls.Add((Control) this.UkjlhoxVlP);
      this.i0nkpjc7Mk.Controls.Add((Control) this.CM4lsLEeIO);
      this.i0nkpjc7Mk.Controls.Add((Control) this.j4UkPEuPyL);
      this.i0nkpjc7Mk.Controls.Add((Control) this.FflkvgcUww);
      this.i0nkpjc7Mk.Controls.Add((Control) this.NfekouVArc);
      this.i0nkpjc7Mk.Controls.Add((Control) this.CuMkNNYEDG);
      this.i0nkpjc7Mk.Controls.Add((Control) this.Nk6ktIV1Ba);
      this.i0nkpjc7Mk.Controls.Add((Control) this.YMZkELWOqr);
      this.i0nkpjc7Mk.Dock = DockStyle.Fill;
      this.i0nkpjc7Mk.Location = new Point(0, 0);
      this.i0nkpjc7Mk.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20204);
      this.i0nkpjc7Mk.Size = new Size(616, 64);
      this.i0nkpjc7Mk.TabIndex = 3;
      this.i0nkpjc7Mk.TabStop = false;
      this.UkjlhoxVlP.Enabled = false;
      this.UkjlhoxVlP.FormattingEnabled = true;
      this.UkjlhoxVlP.Location = new Point(72, 36);
      this.UkjlhoxVlP.MaxLength = 10;
      this.UkjlhoxVlP.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20230);
      this.UkjlhoxVlP.Size = new Size(100, 21);
      this.UkjlhoxVlP.TabIndex = 12;
      this.CM4lsLEeIO.Enabled = false;
      this.CM4lsLEeIO.Location = new Point(8, 36);
      this.CM4lsLEeIO.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20254);
      this.CM4lsLEeIO.Size = new Size(63, 20);
      this.CM4lsLEeIO.TabIndex = 11;
      this.CM4lsLEeIO.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20278);
      this.CM4lsLEeIO.TextAlign = ContentAlignment.MiddleLeft;
      this.j4UkPEuPyL.DropDownStyle = ComboBoxStyle.DropDownList;
      this.j4UkPEuPyL.FormattingEnabled = true;
      this.j4UkPEuPyL.Location = new Point(72, 12);
      this.j4UkPEuPyL.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20298);
      this.j4UkPEuPyL.Size = new Size(100, 21);
      this.j4UkPEuPyL.Sorted = true;
      this.j4UkPEuPyL.TabIndex = 10;
      this.j4UkPEuPyL.SelectedIndexChanged += new EventHandler(this.rVvkGSZZmw);
      this.FflkvgcUww.Location = new Point(8, 12);
      this.FflkvgcUww.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20326);
      this.FflkvgcUww.Size = new Size(63, 20);
      this.FflkvgcUww.TabIndex = 9;
      this.FflkvgcUww.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20342);
      this.FflkvgcUww.TextAlign = ContentAlignment.MiddleLeft;
      this.NfekouVArc.Location = new Point(192, 12);
      this.NfekouVArc.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20364);
      this.NfekouVArc.Size = new Size(63, 20);
      this.NfekouVArc.TabIndex = 7;
      this.NfekouVArc.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20380);
      this.NfekouVArc.TextAlign = ContentAlignment.MiddleRight;
      this.CuMkNNYEDG.Format = DateTimePickerFormat.Short;
      this.CuMkNNYEDG.Location = new Point(268, 36);
      this.CuMkNNYEDG.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20404);
      this.CuMkNNYEDG.Size = new Size(107, 20);
      this.CuMkNNYEDG.TabIndex = 5;
      this.Nk6ktIV1Ba.Format = DateTimePickerFormat.Short;
      this.Nk6ktIV1Ba.Location = new Point(268, 12);
      this.Nk6ktIV1Ba.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20420);
      this.Nk6ktIV1Ba.Size = new Size(107, 20);
      this.Nk6ktIV1Ba.TabIndex = 4;
      this.Nk6ktIV1Ba.Value = new DateTime(1980, 1, 1, 0, 0, 0, 0);
      this.YMZkELWOqr.Location = new Point(192, 36);
      this.YMZkELWOqr.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20440);
      this.YMZkELWOqr.Size = new Size(63, 20);
      this.YMZkELWOqr.TabIndex = 3;
      this.YMZkELWOqr.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20456);
      this.YMZkELWOqr.TextAlign = ContentAlignment.MiddleRight;
      this.lpqkQ3VDOM.Controls.Add((Control) this.vWUkAGiTtg);
      this.lpqkQ3VDOM.Location = new Point(4, 22);
      this.lpqkQ3VDOM.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20476);
      this.lpqkQ3VDOM.Size = new Size(616, 64);
      this.lpqkQ3VDOM.TabIndex = 1;
      this.lpqkQ3VDOM.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20496);
      this.lpqkQ3VDOM.UseVisualStyleBackColor = true;
      this.vWUkAGiTtg.Controls.Add((Control) this.ItskcDWUqc);
      this.vWUkAGiTtg.Controls.Add((Control) this.HV3kzfxOak);
      this.vWUkAGiTtg.Controls.Add((Control) this.IAVkBlDVxf);
      this.vWUkAGiTtg.Dock = DockStyle.Fill;
      this.vWUkAGiTtg.Location = new Point(0, 0);
      this.vWUkAGiTtg.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20516);
      this.vWUkAGiTtg.Size = new Size(616, 64);
      this.vWUkAGiTtg.TabIndex = 0;
      this.vWUkAGiTtg.TabStop = false;
      this.ItskcDWUqc.AutoSize = false;
      this.ItskcDWUqc.Location = new Point(8, 36);
      this.ItskcDWUqc.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20542);
      this.ItskcDWUqc.Size = new Size(168, 20);
      this.ItskcDWUqc.TabIndex = 12;
      this.ItskcDWUqc.ValueChanged += new EventHandler(this.zSTkakvcFn);
      this.HV3kzfxOak.Location = new Point(144, 12);
      this.HV3kzfxOak.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20574);
      this.HV3kzfxOak.ReadOnly = true;
      this.HV3kzfxOak.Size = new Size(32, 20);
      this.HV3kzfxOak.TabIndex = 11;
      this.HV3kzfxOak.TextAlign = HorizontalAlignment.Center;
      this.IAVkBlDVxf.Location = new Point(8, 12);
      this.IAVkBlDVxf.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20606);
      this.IAVkBlDVxf.Size = new Size(140, 20);
      this.IAVkBlDVxf.TabIndex = 10;
      this.IAVkBlDVxf.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20622);
      this.IAVkBlDVxf.TextAlign = ContentAlignment.MiddleLeft;
      this.SOqlYER34W.Checked = true;
      this.SOqlYER34W.CheckState = CheckState.Checked;
      this.SOqlYER34W.Location = new Point(389, 12);
      this.SOqlYER34W.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20674);
      this.SOqlYER34W.Size = new Size(206, 20);
      this.SOqlYER34W.TabIndex = 13;
      this.SOqlYER34W.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20696);
      this.SOqlYER34W.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.Do1kX8Voem;
      this.ClientSize = new Size(634, 360);
      this.Controls.Add((Control) this.TTEkwwnSFG);
      this.Controls.Add((Control) this.srEkmli0kD);
      this.Controls.Add((Control) this.YhakKNtGsn);
      this.Controls.Add((Control) this.Do1kX8Voem);
      this.Controls.Add((Control) this.qy2k5NRmE4);
      this.Controls.Add((Control) this.vY9kUsI2Ej);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20766);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20794);
      this.R4pkC7FUJ5.ResumeLayout(false);
      this.TTEkwwnSFG.ResumeLayout(false);
      this.Eavk0sM3Zx.ResumeLayout(false);
      this.i0nkpjc7Mk.ResumeLayout(false);
      this.lpqkQ3VDOM.ResumeLayout(false);
      this.vWUkAGiTtg.ResumeLayout(false);
      this.vWUkAGiTtg.PerformLayout();
      this.ItskcDWUqc.EndInit();
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnLoad(EventArgs e)
    {
      this.tlNlxfyMLv.NewHistoricalTrade += new HistoricalTradeEventHandler(this.JwIkuMWKfe);
      this.tlNlxfyMLv.NewHistoricalQuote += new HistoricalQuoteEventHandler(this.A6IkgWjeaP);
      this.tlNlxfyMLv.NewHistoricalBar += new HistoricalBarEventHandler(this.dQGkMVk1Fr);
      this.tlNlxfyMLv.NewHistoricalMarketDepth += new HistoricalMarketDepthEventHandler(this.iitkJnDu9a);
      this.tlNlxfyMLv.HistoricalDataRequestCompleted += new HistoricalDataEventHandler(this.NhvknhbWi9);
      this.tlNlxfyMLv.HistoricalDataRequestCancelled += new HistoricalDataEventHandler(this.aNXk7gk8ZR);
      this.tlNlxfyMLv.HistoricalDataRequestError += new HistoricalDataErrorEventHandler(this.FAkkLYX03J);
      base.OnLoad(e);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (!this.Do1kX8Voem.Enabled)
      {
        e.Cancel = true;
      }
      else
      {
        this.tlNlxfyMLv.NewHistoricalTrade -= new HistoricalTradeEventHandler(this.JwIkuMWKfe);
        this.tlNlxfyMLv.NewHistoricalQuote -= new HistoricalQuoteEventHandler(this.A6IkgWjeaP);
        this.tlNlxfyMLv.NewHistoricalBar -= new HistoricalBarEventHandler(this.dQGkMVk1Fr);
        this.tlNlxfyMLv.NewHistoricalMarketDepth -= new HistoricalMarketDepthEventHandler(this.iitkJnDu9a);
        this.tlNlxfyMLv.HistoricalDataRequestCompleted -= new HistoricalDataEventHandler(this.NhvknhbWi9);
        this.tlNlxfyMLv.HistoricalDataRequestCancelled -= new HistoricalDataEventHandler(this.aNXk7gk8ZR);
        this.tlNlxfyMLv.HistoricalDataRequestError -= new HistoricalDataErrorEventHandler(this.FAkkLYX03J);
        base.OnFormClosing(e);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShown(EventArgs e)
    {
      this.LCZkOA30rW();
      base.OnShown(e);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetProvider(IHistoricalDataProvider provider)
    {
      this.tlNlxfyMLv = provider;
      foreach (HistoricalDataType historicalDataType in Enum.GetValues(typeof (HistoricalDataType)))
      {
        if ((provider.DataType & historicalDataType) == historicalDataType)
          this.j4UkPEuPyL.Items.Add((object) historicalDataType);
      }
      if (provider.BarSizes.Length == 0)
      {
        this.UkjlhoxVlP.DropDownStyle = ComboBoxStyle.Simple;
      }
      else
      {
        this.UkjlhoxVlP.DropDownStyle = ComboBoxStyle.DropDownList;
        List<int> list = new List<int>((IEnumerable<int>) provider.BarSizes);
        list.Sort();
        foreach (int num in list)
          this.UkjlhoxVlP.Items.Add((object) num);
      }
      this.ItskcDWUqc.Minimum = 1;
      this.ItskcDWUqc.Value = 1;
      this.ItskcDWUqc.Maximum = provider.MaxConcurrentRequests != -1 ? provider.MaxConcurrentRequests : 5;
      this.HV3kzfxOak.Text = this.ItskcDWUqc.Value.ToString();
      this.Text = string.Format(RNaihRhYEl0wUmAftnB.aYu7exFQKN(20846), (object) provider.Name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void mlykVinkmu([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.FgnkHl3Y97())
        return;
      this.NLklDLbERp.Clear();
      this.V43ldlVmhs.Clear();
      this.hRhl1skFVG.Clear();
      this.sUBlFVkkCB.Clear();
      foreach (uRIUcg8mp5qy3pl442 riUcg8mp5qy3pl442 in this.vY9kUsI2Ej.Items)
      {
        riUcg8mp5qy3pl442.rUvH6gPc7i();
        HistoricalDataRequest historicalDataRequest = new HistoricalDataRequest();
        historicalDataRequest.Instrument = (IFIXInstrument) riUcg8mp5qy3pl442.tRpHqexTIJ();
        historicalDataRequest.DataType = (HistoricalDataType) this.j4UkPEuPyL.SelectedItem;
        historicalDataRequest.BeginDate = this.Nk6ktIV1Ba.Value.Date;
        historicalDataRequest.EndDate = this.CuMkNNYEDG.Value.Date;
        if (historicalDataRequest.DataType == HistoricalDataType.Bar)
          historicalDataRequest.BarSize = long.Parse(this.UkjlhoxVlP.Text);
        this.NLklDLbERp.Add(historicalDataRequest.RequestId, historicalDataRequest);
        this.V43ldlVmhs.Add(historicalDataRequest.RequestId, riUcg8mp5qy3pl442);
        if (this.SOqlYER34W.Checked)
        {
          IDataSeries dataSeries = (IDataSeries) null;
          switch (historicalDataRequest.DataType)
          {
            case HistoricalDataType.Trade:
              dataSeries = DataManager.GetDataSeries(riUcg8mp5qy3pl442.tRpHqexTIJ(), RNaihRhYEl0wUmAftnB.aYu7exFQKN(20924));
              break;
            case HistoricalDataType.Quote:
              dataSeries = DataManager.GetDataSeries(riUcg8mp5qy3pl442.tRpHqexTIJ(), RNaihRhYEl0wUmAftnB.aYu7exFQKN(20910));
              break;
          }
          if (dataSeries != null && dataSeries.Count > 0)
          {
            dtWG9eTloC3v1YLiPJ wg9eTloC3v1YliPj = new dtWG9eTloC3v1YLiPJ(dataSeries.FirstDateTime, dataSeries.LastDateTime);
            this.sUBlFVkkCB.Add(riUcg8mp5qy3pl442.tRpHqexTIJ(), wg9eTloC3v1YliPj);
          }
        }
      }
      this.i0nkpjc7Mk.Enabled = false;
      this.vWUkAGiTtg.Enabled = false;
      this.qy2k5NRmE4.Enabled = false;
      this.srEkmli0kD.Enabled = true;
      this.Do1kX8Voem.Enabled = false;
      this.YhakKNtGsn.Value = 0;
      this.YhakKNtGsn.Minimum = 0;
      this.YhakKNtGsn.Maximum = this.NLklDLbERp.Count;
      this.YhakKNtGsn.Step = 1;
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.iWVkkmJrHP), (object) this.ItskcDWUqc.Value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void JUykRXSZPA([In] object obj0, [In] EventArgs obj1)
    {
      this.NLklDLbERp.Clear();
      foreach (HistoricalDataRequest historicalDataRequest in new List<HistoricalDataRequest>((IEnumerable<HistoricalDataRequest>) this.hRhl1skFVG.Values))
        this.tlNlxfyMLv.CancelHistoricalDataRequest(historicalDataRequest.RequestId);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool FgnkHl3Y97()
    {
      string text = (string) null;
      if (this.vY9kUsI2Ej.Items.Count == 0)
        text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20938);
      else if (this.j4UkPEuPyL.SelectedIndex == -1)
        text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(20996);
      else if (this.CuMkNNYEDG.Value.Date < this.Nk6ktIV1Ba.Value.Date)
        text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21050);
      if (text == null && (HistoricalDataType) this.j4UkPEuPyL.SelectedItem == HistoricalDataType.Bar)
      {
        long result = 0L;
        if (!long.TryParse(this.UkjlhoxVlP.Text, out result))
          text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21140);
      }
      if (text != null)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, text, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      return text == null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void iWVkkmJrHP([In] object obj0)
    {
      this.zw8lbdiSvG = false;
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.IjmklsnVLm));
      List<HistoricalDataRequest> list = new List<HistoricalDataRequest>((IEnumerable<HistoricalDataRequest>) this.NLklDLbERp.Values);
      int num = (int) obj0;
      int index = 0;
      while (true)
      {
        while (this.hRhl1skFVG.Count == num)
          Thread.Sleep(1);
        if (index < this.NLklDLbERp.Count)
        {
          HistoricalDataRequest historicalDataRequest = list[index];
          ++index;
          this.hRhl1skFVG.Add(historicalDataRequest.RequestId, historicalDataRequest);
          WaitCallback callBack = (WaitCallback) (obj0 => this.tlNlxfyMLv.SendHistoricalDataRequest((HistoricalDataRequest) obj0));
          this.zYhk9pJVyB(this.V43ldlVmhs[historicalDataRequest.RequestId], nB29ckVlruqARiYysQ.Downloading);
          ThreadPool.QueueUserWorkItem(callBack, (object) historicalDataRequest);
        }
        else
          break;
      }
      while (this.hRhl1skFVG.Count > 0)
        Thread.Sleep(1);
      this.zw8lbdiSvG = true;
      this.CgEkTZcADa();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IjmklsnVLm([In] object obj0)
    {
      while (!this.zw8lbdiSvG)
      {
        using (Dictionary<string, uRIUcg8mp5qy3pl442>.ValueCollection.Enumerator enumerator = this.V43ldlVmhs.Values.GetEnumerator())
        {
          while (enumerator.MoveNext())
          {
            uRIUcg8mp5qy3pl442 item = enumerator.Current;
            this.Invoke((Delegate) (() => item.caPH8H5As3()));
          }
        }
        Thread.Sleep(1000);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void JwIkuMWKfe([In] object obj0, [In] HistoricalTradeEventArgs obj1)
    {
      uRIUcg8mp5qy3pl442 riUcg8mp5qy3pl442 = (uRIUcg8mp5qy3pl442) null;
      if (!this.V43ldlVmhs.TryGetValue(obj1.RequestId, out riUcg8mp5qy3pl442))
        return;
      Instrument key = riUcg8mp5qy3pl442.tRpHqexTIJ();
      Trade trade = obj1.Trade;
      dtWG9eTloC3v1YLiPJ wg9eTloC3v1YliPj = (dtWG9eTloC3v1YLiPJ) null;
      if (this.sUBlFVkkCB.TryGetValue(key, out wg9eTloC3v1YliPj))
      {
        if (trade.DateTime < wg9eTloC3v1YliPj.aZTF2X8GaL() || trade.DateTime > wg9eTloC3v1YliPj.Kd2FKl42yG())
          key.Add(trade);
      }
      else
        key.Add(trade);
      this.mwOkiJi9kn(riUcg8mp5qy3pl442, (HistoricalDataEventArgs) obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void A6IkgWjeaP([In] object obj0, [In] HistoricalQuoteEventArgs obj1)
    {
      uRIUcg8mp5qy3pl442 riUcg8mp5qy3pl442 = (uRIUcg8mp5qy3pl442) null;
      if (!this.V43ldlVmhs.TryGetValue(obj1.RequestId, out riUcg8mp5qy3pl442))
        return;
      Instrument key = riUcg8mp5qy3pl442.tRpHqexTIJ();
      Quote quote = obj1.Quote;
      dtWG9eTloC3v1YLiPJ wg9eTloC3v1YliPj = (dtWG9eTloC3v1YLiPJ) null;
      if (this.sUBlFVkkCB.TryGetValue(key, out wg9eTloC3v1YliPj))
      {
        if (quote.DateTime < wg9eTloC3v1YliPj.aZTF2X8GaL() || quote.DateTime > wg9eTloC3v1YliPj.Kd2FKl42yG())
          key.Add(quote);
      }
      else
        key.Add(quote);
      this.mwOkiJi9kn(riUcg8mp5qy3pl442, (HistoricalDataEventArgs) obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void dQGkMVk1Fr([In] object obj0, [In] HistoricalBarEventArgs obj1)
    {
      uRIUcg8mp5qy3pl442 riUcg8mp5qy3pl442 = (uRIUcg8mp5qy3pl442) null;
      if (!this.V43ldlVmhs.TryGetValue(obj1.RequestId, out riUcg8mp5qy3pl442))
        return;
      if (obj1.Bar is Daily)
        riUcg8mp5qy3pl442.tRpHqexTIJ().Add(obj1.Bar as Daily);
      else
        riUcg8mp5qy3pl442.tRpHqexTIJ().Add(obj1.Bar);
      this.mwOkiJi9kn(riUcg8mp5qy3pl442, (HistoricalDataEventArgs) obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void iitkJnDu9a([In] object obj0, [In] HistoricalMarketDepthEventArgs obj1)
    {
      uRIUcg8mp5qy3pl442 riUcg8mp5qy3pl442 = (uRIUcg8mp5qy3pl442) null;
      if (!this.V43ldlVmhs.TryGetValue(obj1.RequestId, out riUcg8mp5qy3pl442))
        return;
      Instrument key = riUcg8mp5qy3pl442.tRpHqexTIJ();
      MarketDepth marketDepth = obj1.MarketDepth;
      dtWG9eTloC3v1YLiPJ wg9eTloC3v1YliPj = (dtWG9eTloC3v1YLiPJ) null;
      if (this.sUBlFVkkCB.TryGetValue(key, out wg9eTloC3v1YliPj))
      {
        if (marketDepth.DateTime < wg9eTloC3v1YliPj.aZTF2X8GaL() || marketDepth.DateTime > wg9eTloC3v1YliPj.Kd2FKl42yG())
          key.Add(marketDepth);
      }
      else
        key.Add(marketDepth);
      this.mwOkiJi9kn(riUcg8mp5qy3pl442, (HistoricalDataEventArgs) obj1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void NhvknhbWi9([In] object obj0, [In] HistoricalDataEventArgs obj1)
    {
      uRIUcg8mp5qy3pl442 riUcg8mp5qy3pl442 = (uRIUcg8mp5qy3pl442) null;
      if (!this.V43ldlVmhs.TryGetValue(obj1.RequestId, out riUcg8mp5qy3pl442))
        return;
      this.zYhk9pJVyB(riUcg8mp5qy3pl442, nB29ckVlruqARiYysQ.Done);
      this.puvkWE62bU();
      this.hRhl1skFVG.Remove(obj1.RequestId);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void aNXk7gk8ZR([In] object obj0, [In] HistoricalDataEventArgs obj1)
    {
      uRIUcg8mp5qy3pl442 riUcg8mp5qy3pl442 = (uRIUcg8mp5qy3pl442) null;
      if (!this.V43ldlVmhs.TryGetValue(obj1.RequestId, out riUcg8mp5qy3pl442))
        return;
      this.zYhk9pJVyB(riUcg8mp5qy3pl442, nB29ckVlruqARiYysQ.Cancelled);
      this.hRhl1skFVG.Remove(obj1.RequestId);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FAkkLYX03J([In] object obj0, [In] HistoricalDataErrorEventArgs obj1)
    {
      uRIUcg8mp5qy3pl442 riUcg8mp5qy3pl442 = (uRIUcg8mp5qy3pl442) null;
      if (!this.V43ldlVmhs.TryGetValue(obj1.RequestId, out riUcg8mp5qy3pl442))
        return;
      this.zYhk9pJVyB(riUcg8mp5qy3pl442, nB29ckVlruqARiYysQ.Error);
      this.PUwk3oEbct(riUcg8mp5qy3pl442, obj1.Message);
      this.puvkWE62bU();
      this.hRhl1skFVG.Remove(obj1.RequestId);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void mwOkiJi9kn([In] uRIUcg8mp5qy3pl442 obj0, [In] HistoricalDataEventArgs obj1)
    {
      ++obj0.Count;
      obj0.Total = obj1.DataLength <= 0 ? obj0.Count : obj1.DataLength;
      Thread.Sleep(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void zYhk9pJVyB([In] uRIUcg8mp5qy3pl442 obj0, [In] nB29ckVlruqARiYysQ obj1)
    {
      obj0.Status = obj1;
      this.Invoke((Delegate) (() => obj0.UKIHruQFSn()));
      Thread.Sleep(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PUwk3oEbct([In] uRIUcg8mp5qy3pl442 obj0, [In] string obj1)
    {
      obj0.Message = obj1;
      this.Invoke((Delegate) (() => obj0.EoCH5L2J2e()));
      Thread.Sleep(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void puvkWE62bU()
    {
      this.Invoke((Delegate) (() => this.YhakKNtGsn.PerformStep()));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CgEkTZcADa()
    {
      this.Invoke((Delegate) (() =>
      {
        foreach (uRIUcg8mp5qy3pl442 item_0 in this.V43ldlVmhs.Values)
          item_0.caPH8H5As3();
        this.i0nkpjc7Mk.Enabled = true;
        this.vWUkAGiTtg.Enabled = true;
        this.qy2k5NRmE4.Enabled = true;
        this.srEkmli0kD.Enabled = false;
        this.Do1kX8Voem.Enabled = true;
      }));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EmgkftmnIY([In] object obj0, [In] CancelEventArgs obj1)
    {
      this.dVWk21DFUE.Enabled = this.Do1kX8Voem.Enabled;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CXZkyy1EdI([In] object obj0, [In] EventArgs obj1)
    {
      this.LCZkOA30rW();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LCZkOA30rW()
    {
      List<Instrument> list = new List<Instrument>();
      foreach (uRIUcg8mp5qy3pl442 riUcg8mp5qy3pl442 in this.vY9kUsI2Ej.Items)
        list.Add(riUcg8mp5qy3pl442.tRpHqexTIJ());
      InstrumentSelectorDialog instrumentSelectorDialog = new InstrumentSelectorDialog();
      instrumentSelectorDialog.SelectedInstruments = list.ToArray();
      if (instrumentSelectorDialog.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        this.vY9kUsI2Ej.BeginUpdate();
        this.vY9kUsI2Ej.Items.Clear();
        foreach (Instrument instrument in instrumentSelectorDialog.SelectedInstruments)
          this.vY9kUsI2Ej.Items.Add((ListViewItem) new uRIUcg8mp5qy3pl442(instrument));
        this.vY9kUsI2Ej.EndUpdate();
      }
      instrumentSelectorDialog.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void zSTkakvcFn([In] object obj0, [In] EventArgs obj1)
    {
      this.HV3kzfxOak.Text = this.ItskcDWUqc.Value.ToString();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void rVvkGSZZmw([In] object obj0, [In] EventArgs obj1)
    {
      if ((HistoricalDataType) this.j4UkPEuPyL.SelectedItem == HistoricalDataType.Bar)
      {
        this.CM4lsLEeIO.Enabled = true;
        this.UkjlhoxVlP.Enabled = true;
      }
      else
      {
        this.CM4lsLEeIO.Enabled = false;
        this.UkjlhoxVlP.Enabled = false;
      }
    }
  }
}
