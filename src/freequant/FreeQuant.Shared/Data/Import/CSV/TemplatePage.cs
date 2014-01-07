// Type: SmartQuant.Shared.Data.Import.CSV.TemplatePage
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using BtHsRI9N1YxNmdxGKu;
using SmartQuant;
using SmartQuant.Data;
using SmartQuant.FIX;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class TemplatePage : WizardPage
  {
    private const int g9WJm8UYZu = 50;
    private const string L6VJwt1Nlu = "import.templates.xml";
    private ArrayList PROJ0pMlxQ;
    private bool poFJp4VXTE;
    private ColumnHeader fpSJNS1ZsV;
    private ListView o1vJtAKLoE;
    private ColumnContextMenu cOfJEtN14g;
    private Panel aqxJQqkJQs;
    private Label TvAJv2gsSL;
    private ComboBox odJJoglvD1;
    private Button SeGJPna2pr;
    private Panel gj1JAjlSK2;
    private Button U9EJBX5T3a;
    private Panel CD8Jck5CIt;
    private TabControl BalJz8TAlv;
    private TabPage kGknefHTCu;
    private TabPage ixgnhay4kI;
    private GroupBox A4WnsRxjeC;
    private Panel QXknY1c4j9;
    private NumericUpDown uUxnxoWa5U;
    private Label E9lnDmQcp5;
    private Label a0hn1vkO1J;
    private Panel AEQndPNctO;
    private ComboBox zxNnFhDigO;
    private Label IIbnb6FcOw;
    private GroupBox ucSnVeNbra;
    private Panel OiFnRw7HJC;
    private Label kAOnHJrBJu;
    private ComboBox W1Rnki5Z0d;
    private GroupBox wvNnlXtLAl;
    private Panel vndnuCG4Gr;
    private NumericUpDown MDmngl746B;
    private Label mWEnM7RqtZ;
    private Panel ebsnJ8QWUl;
    private ComboBox he6nnuddXV;
    private Label plen7X4Uhd;
    private GroupBox uaOnLVIuNQ;
    private Panel jLAniL5iWW;
    private DateTimePicker tPOn9R3O5A;
    private Panel AIxn3N4E03;
    private RadioButton ostnWa3s9R;
    private RadioButton NC8nTHgJ9H;
    private Panel hN0nfE4S3W;
    private GroupBox qQInyfbg1f;
    private Panel NUhnOV4LxZ;
    private TextBox Ru1naDpysJ;
    private Panel J4LnGlTHkF;
    private RadioButton DJ7nZBFY6P;
    private Panel vBBn4k9axr;
    private CheckBox VBmnIr1pAt;
    private RadioButton UG9nSZN8QV;
    private RadioButton g5CnUvEp8S;
    private Panel H1RnjAhgpq;
    private Panel Lx9n6FKw6I;
    private ImageList zwunrkjwSe;
    private Label BaGn8AfOyP;
    private Label fJ3n5NGNGC;
    private GroupBox j8Tnq97LBA;
    private RadioButton hG0nC0QP0h;
    private Panel krSn2PnvwE;
    private Panel dA7nX4P7UC;
    private Label NcNnKW3Y4O;
    private Panel Lw5nm3kjg1;
    private RadioButton Ce2nwgqXC7;
    private TextBox vaon02QBvb;
    private GroupBox hX5npFEjSn;
    private Panel dT5nNE3K7s;
    private CheckBox V8sntmTDZc;
    private Panel NtSnEnPlhY;
    private ComboBox kUOnQ34Fm2;
    private CheckBox OjynvOA3Z9;
    private IContainer K1kno9QTxu;

    public override bool CanNext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.settings.Template.IsCompleted;
      }
    }

    public override string Title
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return RNaihRhYEl0wUmAftnB.aYu7exFQKN(35944);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TemplatePage()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.R3xJuDxvLw();
      this.PROJ0pMlxQ = new ArrayList();
      this.zxNnFhDigO.Items.Add((object) new SeparatorItem(Separator.Tab));
      this.zxNnFhDigO.Items.Add((object) new SeparatorItem(Separator.Comma));
      this.zxNnFhDigO.Items.Add((object) new SeparatorItem(Separator.Semicolon));
      this.zxNnFhDigO.Items.Add((object) new SeparatorItem(Separator.Space));
      this.W1Rnki5Z0d.BeginUpdate();
      foreach (CultureInfo cultureInfo in CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures))
        this.W1Rnki5Z0d.Items.Add((object) new CultureInfoItem(cultureInfo));
      this.W1Rnki5Z0d.Sorted = true;
      this.W1Rnki5Z0d.EndUpdate();
      this.he6nnuddXV.Items.AddRange((object[]) new DataTypeItem[4]
      {
        new DataTypeItem(DataType.Daily, new ColumnType[9]
        {
          ColumnType.Symbol,
          ColumnType.Date,
          ColumnType.Open,
          ColumnType.High,
          ColumnType.Low,
          ColumnType.Close,
          ColumnType.Volume,
          ColumnType.OpenInt,
          ColumnType.Skipped
        }),
        new DataTypeItem(DataType.Bar, new ColumnType[11]
        {
          ColumnType.Symbol,
          ColumnType.DateTime,
          ColumnType.Date,
          ColumnType.Time,
          ColumnType.Open,
          ColumnType.High,
          ColumnType.Low,
          ColumnType.Close,
          ColumnType.Volume,
          ColumnType.OpenInt,
          ColumnType.Skipped
        }),
        new DataTypeItem(DataType.Trade, new ColumnType[7]
        {
          ColumnType.Symbol,
          ColumnType.DateTime,
          ColumnType.Date,
          ColumnType.Time,
          ColumnType.Price,
          ColumnType.Size,
          ColumnType.Skipped
        }),
        new DataTypeItem(DataType.Quote, new ColumnType[9]
        {
          ColumnType.Symbol,
          ColumnType.DateTime,
          ColumnType.Date,
          ColumnType.Time,
          ColumnType.Bid,
          ColumnType.BidSize,
          ColumnType.Ask,
          ColumnType.AskSize,
          ColumnType.Skipped
        })
      });
      this.cOfJEtN14g.MenuItems.AddRange(new MenuItem[20]
      {
        (MenuItem) new ColumnMenuItem(ColumnType.Symbol, new EventHandler(this.krhJ3KCqf3)),
        new MenuItem(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33430)),
        (MenuItem) new ColumnMenuItem(ColumnType.DateTime, new MenuItem[3]
        {
          (MenuItem) new ColumnMenuItem(ColumnType.DateTime, RNaihRhYEl0wUmAftnB.aYu7exFQKN(33436), new EventHandler(this.krhJ3KCqf3)),
          new MenuItem(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33478)),
          new MenuItem(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33484), new EventHandler(this.Wt8JWhWpkK))
        }),
        (MenuItem) new ColumnMenuItem(ColumnType.Date, new MenuItem[7]
        {
          (MenuItem) new ColumnMenuItem(ColumnType.Date, RNaihRhYEl0wUmAftnB.aYu7exFQKN(33506), new EventHandler(this.krhJ3KCqf3)),
          (MenuItem) new ColumnMenuItem(ColumnType.Date, RNaihRhYEl0wUmAftnB.aYu7exFQKN(33526), new EventHandler(this.krhJ3KCqf3)),
          (MenuItem) new ColumnMenuItem(ColumnType.Date, RNaihRhYEl0wUmAftnB.aYu7exFQKN(33546), new EventHandler(this.krhJ3KCqf3)),
          (MenuItem) new ColumnMenuItem(ColumnType.Date, RNaihRhYEl0wUmAftnB.aYu7exFQKN(33566), new EventHandler(this.krhJ3KCqf3)),
          (MenuItem) new ColumnMenuItem(ColumnType.Date, RNaihRhYEl0wUmAftnB.aYu7exFQKN(33586), new EventHandler(this.krhJ3KCqf3)),
          new MenuItem(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33606)),
          new MenuItem(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33612), new EventHandler(this.Wt8JWhWpkK))
        }),
        (MenuItem) new ColumnMenuItem(ColumnType.Time, new MenuItem[3]
        {
          (MenuItem) new ColumnMenuItem(ColumnType.Time, RNaihRhYEl0wUmAftnB.aYu7exFQKN(33634), new EventHandler(this.krhJ3KCqf3)),
          new MenuItem(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33654)),
          new MenuItem(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33660), new EventHandler(this.Wt8JWhWpkK))
        }),
        new MenuItem(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33682)),
        (MenuItem) new ColumnMenuItem(ColumnType.Price, new EventHandler(this.krhJ3KCqf3)),
        (MenuItem) new ColumnMenuItem(ColumnType.Size, new EventHandler(this.krhJ3KCqf3)),
        (MenuItem) new ColumnMenuItem(ColumnType.Bid, new EventHandler(this.krhJ3KCqf3)),
        (MenuItem) new ColumnMenuItem(ColumnType.BidSize, new EventHandler(this.krhJ3KCqf3)),
        (MenuItem) new ColumnMenuItem(ColumnType.Ask, new EventHandler(this.krhJ3KCqf3)),
        (MenuItem) new ColumnMenuItem(ColumnType.AskSize, new EventHandler(this.krhJ3KCqf3)),
        (MenuItem) new ColumnMenuItem(ColumnType.Open, new EventHandler(this.krhJ3KCqf3)),
        (MenuItem) new ColumnMenuItem(ColumnType.High, new EventHandler(this.krhJ3KCqf3)),
        (MenuItem) new ColumnMenuItem(ColumnType.Low, new EventHandler(this.krhJ3KCqf3)),
        (MenuItem) new ColumnMenuItem(ColumnType.Close, new EventHandler(this.krhJ3KCqf3)),
        (MenuItem) new ColumnMenuItem(ColumnType.Volume, new EventHandler(this.krhJ3KCqf3)),
        (MenuItem) new ColumnMenuItem(ColumnType.OpenInt, new EventHandler(this.krhJ3KCqf3)),
        new MenuItem(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33688)),
        (MenuItem) new ColumnMenuItem(ColumnType.Skipped, new EventHandler(this.krhJ3KCqf3))
      });
      foreach (FieldInfo fieldInfo in typeof (FIXSecurityType).GetFields(BindingFlags.Static | BindingFlags.Public))
        this.kUOnQ34Fm2.Items.Add((object) new pLqk8fiaEZ51QA5QZ6(fieldInfo.Name, fieldInfo.GetValue((object) null) as string));
      this.kUOnQ34Fm2.Sorted = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.K1kno9QTxu != null)
        this.K1kno9QTxu.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void R3xJuDxvLw()
    {
      this.K1kno9QTxu = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TemplatePage));
      this.o1vJtAKLoE = new ListView();
      this.fpSJNS1ZsV = new ColumnHeader();
      this.cOfJEtN14g = new ColumnContextMenu();
      this.aqxJQqkJQs = new Panel();
      this.fJ3n5NGNGC = new Label();
      this.BaGn8AfOyP = new Label();
      this.zwunrkjwSe = new ImageList(this.K1kno9QTxu);
      this.SeGJPna2pr = new Button();
      this.CD8Jck5CIt = new Panel();
      this.U9EJBX5T3a = new Button();
      this.gj1JAjlSK2 = new Panel();
      this.odJJoglvD1 = new ComboBox();
      this.TvAJv2gsSL = new Label();
      this.BalJz8TAlv = new TabControl();
      this.kGknefHTCu = new TabPage();
      this.qQInyfbg1f = new GroupBox();
      this.NUhnOV4LxZ = new Panel();
      this.Ru1naDpysJ = new TextBox();
      this.J4LnGlTHkF = new Panel();
      this.DJ7nZBFY6P = new RadioButton();
      this.vBBn4k9axr = new Panel();
      this.VBmnIr1pAt = new CheckBox();
      this.UG9nSZN8QV = new RadioButton();
      this.g5CnUvEp8S = new RadioButton();
      this.H1RnjAhgpq = new Panel();
      this.uaOnLVIuNQ = new GroupBox();
      this.jLAniL5iWW = new Panel();
      this.tPOn9R3O5A = new DateTimePicker();
      this.AIxn3N4E03 = new Panel();
      this.ostnWa3s9R = new RadioButton();
      this.NC8nTHgJ9H = new RadioButton();
      this.hN0nfE4S3W = new Panel();
      this.wvNnlXtLAl = new GroupBox();
      this.vndnuCG4Gr = new Panel();
      this.MDmngl746B = new NumericUpDown();
      this.mWEnM7RqtZ = new Label();
      this.ebsnJ8QWUl = new Panel();
      this.he6nnuddXV = new ComboBox();
      this.plen7X4Uhd = new Label();
      this.A4WnsRxjeC = new GroupBox();
      this.QXknY1c4j9 = new Panel();
      this.uUxnxoWa5U = new NumericUpDown();
      this.E9lnDmQcp5 = new Label();
      this.a0hn1vkO1J = new Label();
      this.AEQndPNctO = new Panel();
      this.zxNnFhDigO = new ComboBox();
      this.IIbnb6FcOw = new Label();
      this.ixgnhay4kI = new TabPage();
      this.hX5npFEjSn = new GroupBox();
      this.V8sntmTDZc = new CheckBox();
      this.NtSnEnPlhY = new Panel();
      this.OjynvOA3Z9 = new CheckBox();
      this.kUOnQ34Fm2 = new ComboBox();
      this.dT5nNE3K7s = new Panel();
      this.j8Tnq97LBA = new GroupBox();
      this.dA7nX4P7UC = new Panel();
      this.vaon02QBvb = new TextBox();
      this.Lw5nm3kjg1 = new Panel();
      this.NcNnKW3Y4O = new Label();
      this.Ce2nwgqXC7 = new RadioButton();
      this.hG0nC0QP0h = new RadioButton();
      this.krSn2PnvwE = new Panel();
      this.ucSnVeNbra = new GroupBox();
      this.OiFnRw7HJC = new Panel();
      this.kAOnHJrBJu = new Label();
      this.W1Rnki5Z0d = new ComboBox();
      this.Lx9n6FKw6I = new Panel();
      this.aqxJQqkJQs.SuspendLayout();
      this.BalJz8TAlv.SuspendLayout();
      this.kGknefHTCu.SuspendLayout();
      this.qQInyfbg1f.SuspendLayout();
      this.NUhnOV4LxZ.SuspendLayout();
      this.vBBn4k9axr.SuspendLayout();
      this.uaOnLVIuNQ.SuspendLayout();
      this.jLAniL5iWW.SuspendLayout();
      this.wvNnlXtLAl.SuspendLayout();
      this.vndnuCG4Gr.SuspendLayout();
      this.MDmngl746B.BeginInit();
      this.ebsnJ8QWUl.SuspendLayout();
      this.A4WnsRxjeC.SuspendLayout();
      this.QXknY1c4j9.SuspendLayout();
      this.uUxnxoWa5U.BeginInit();
      this.AEQndPNctO.SuspendLayout();
      this.ixgnhay4kI.SuspendLayout();
      this.hX5npFEjSn.SuspendLayout();
      this.NtSnEnPlhY.SuspendLayout();
      this.j8Tnq97LBA.SuspendLayout();
      this.dA7nX4P7UC.SuspendLayout();
      this.ucSnVeNbra.SuspendLayout();
      this.OiFnRw7HJC.SuspendLayout();
      this.SuspendLayout();
      this.o1vJtAKLoE.BorderStyle = BorderStyle.None;
      this.o1vJtAKLoE.Columns.AddRange(new ColumnHeader[1]
      {
        this.fpSJNS1ZsV
      });
      this.o1vJtAKLoE.Dock = DockStyle.Fill;
      this.o1vJtAKLoE.Location = new Point(0, 136);
      this.o1vJtAKLoE.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(33694);
      this.o1vJtAKLoE.Size = new Size(680, 144);
      this.o1vJtAKLoE.TabIndex = 4;
      this.o1vJtAKLoE.UseCompatibleStateImageBehavior = false;
      this.o1vJtAKLoE.View = View.Details;
      this.o1vJtAKLoE.ColumnClick += new ColumnClickEventHandler(this.yukJiX0y2y);
      this.fpSJNS1ZsV.Text = "";
      this.fpSJNS1ZsV.Width = 0;
      this.cOfJEtN14g.Column = 0;
      this.cOfJEtN14g.Popup += new EventHandler(this.FYmJ9npO5F);
      this.aqxJQqkJQs.Controls.Add((Control) this.fJ3n5NGNGC);
      this.aqxJQqkJQs.Controls.Add((Control) this.BaGn8AfOyP);
      this.aqxJQqkJQs.Controls.Add((Control) this.SeGJPna2pr);
      this.aqxJQqkJQs.Controls.Add((Control) this.CD8Jck5CIt);
      this.aqxJQqkJQs.Controls.Add((Control) this.U9EJBX5T3a);
      this.aqxJQqkJQs.Controls.Add((Control) this.gj1JAjlSK2);
      this.aqxJQqkJQs.Controls.Add((Control) this.odJJoglvD1);
      this.aqxJQqkJQs.Controls.Add((Control) this.TvAJv2gsSL);
      this.aqxJQqkJQs.Dock = DockStyle.Bottom;
      this.aqxJQqkJQs.Location = new Point(0, 288);
      this.aqxJQqkJQs.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(33710);
      this.aqxJQqkJQs.Size = new Size(680, 24);
      this.aqxJQqkJQs.TabIndex = 5;
      this.fJ3n5NGNGC.Dock = DockStyle.Right;
      this.fJ3n5NGNGC.Location = new Point(416, 0);
      this.fJ3n5NGNGC.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(33726);
      this.fJ3n5NGNGC.Size = new Size(240, 24);
      this.fJ3n5NGNGC.TabIndex = 7;
      this.fJ3n5NGNGC.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(33764);
      this.fJ3n5NGNGC.TextAlign = ContentAlignment.MiddleRight;
      this.fJ3n5NGNGC.Click += new EventHandler(this.JH0JCZ5mdt);
      this.BaGn8AfOyP.Dock = DockStyle.Right;
      this.BaGn8AfOyP.ImageList = this.zwunrkjwSe;
      this.BaGn8AfOyP.Location = new Point(656, 0);
      this.BaGn8AfOyP.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(33780);
      this.BaGn8AfOyP.Size = new Size(24, 24);
      this.BaGn8AfOyP.TabIndex = 6;
      this.BaGn8AfOyP.Click += new EventHandler(this.SHvJ22DdQJ);
      this.zwunrkjwSe.ImageStream = (ImageListStreamer) componentResourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(33828));
      this.zwunrkjwSe.TransparentColor = Color.Transparent;
      this.zwunrkjwSe.Images.SetKeyName(0, "");
      this.zwunrkjwSe.Images.SetKeyName(1, "");
      this.SeGJPna2pr.Dock = DockStyle.Left;
      this.SeGJPna2pr.Location = new Point(264, 0);
      this.SeGJPna2pr.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(33868);
      this.SeGJPna2pr.Size = new Size(64, 24);
      this.SeGJPna2pr.TabIndex = 2;
      this.SeGJPna2pr.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(33890);
      this.SeGJPna2pr.Click += new EventHandler(this.ARUJXlghVJ);
      this.CD8Jck5CIt.Dock = DockStyle.Left;
      this.CD8Jck5CIt.Location = new Point(256, 0);
      this.CD8Jck5CIt.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(33914);
      this.CD8Jck5CIt.Size = new Size(8, 24);
      this.CD8Jck5CIt.TabIndex = 5;
      this.U9EJBX5T3a.Dock = DockStyle.Left;
      this.U9EJBX5T3a.Location = new Point(192, 0);
      this.U9EJBX5T3a.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(33932);
      this.U9EJBX5T3a.Size = new Size(64, 24);
      this.U9EJBX5T3a.TabIndex = 4;
      this.U9EJBX5T3a.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(33952);
      this.U9EJBX5T3a.Click += new EventHandler(this.F3HJKmRlmE);
      this.gj1JAjlSK2.Dock = DockStyle.Left;
      this.gj1JAjlSK2.Location = new Point(184, 0);
      this.gj1JAjlSK2.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(33966);
      this.gj1JAjlSK2.Size = new Size(8, 24);
      this.gj1JAjlSK2.TabIndex = 3;
      this.odJJoglvD1.Dock = DockStyle.Left;
      this.odJJoglvD1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.odJJoglvD1.Location = new Point(56, 0);
      this.odJJoglvD1.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(33984);
      this.odJJoglvD1.Size = new Size(128, 21);
      this.odJJoglvD1.TabIndex = 1;
      this.TvAJv2gsSL.Dock = DockStyle.Left;
      this.TvAJv2gsSL.Location = new Point(0, 0);
      this.TvAJv2gsSL.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34012);
      this.TvAJv2gsSL.Size = new Size(56, 24);
      this.TvAJv2gsSL.TabIndex = 0;
      this.TvAJv2gsSL.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34028);
      this.TvAJv2gsSL.TextAlign = ContentAlignment.MiddleLeft;
      this.BalJz8TAlv.Controls.Add((Control) this.kGknefHTCu);
      this.BalJz8TAlv.Controls.Add((Control) this.ixgnhay4kI);
      this.BalJz8TAlv.Dock = DockStyle.Top;
      this.BalJz8TAlv.Location = new Point(0, 0);
      this.BalJz8TAlv.Multiline = true;
      this.BalJz8TAlv.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34048);
      this.BalJz8TAlv.SelectedIndex = 0;
      this.BalJz8TAlv.Size = new Size(680, 136);
      this.BalJz8TAlv.TabIndex = 6;
      this.kGknefHTCu.Controls.Add((Control) this.qQInyfbg1f);
      this.kGknefHTCu.Controls.Add((Control) this.uaOnLVIuNQ);
      this.kGknefHTCu.Controls.Add((Control) this.wvNnlXtLAl);
      this.kGknefHTCu.Controls.Add((Control) this.A4WnsRxjeC);
      this.kGknefHTCu.Location = new Point(4, 22);
      this.kGknefHTCu.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34074);
      this.kGknefHTCu.Size = new Size(672, 110);
      this.kGknefHTCu.TabIndex = 0;
      this.kGknefHTCu.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34094);
      this.qQInyfbg1f.Controls.Add((Control) this.NUhnOV4LxZ);
      this.qQInyfbg1f.Controls.Add((Control) this.vBBn4k9axr);
      this.qQInyfbg1f.Controls.Add((Control) this.g5CnUvEp8S);
      this.qQInyfbg1f.Controls.Add((Control) this.H1RnjAhgpq);
      this.qQInyfbg1f.Location = new Point(504, 8);
      this.qQInyfbg1f.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34112);
      this.qQInyfbg1f.Size = new Size(160, 96);
      this.qQInyfbg1f.TabIndex = 4;
      this.qQInyfbg1f.TabStop = false;
      this.qQInyfbg1f.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34134);
      this.NUhnOV4LxZ.Controls.Add((Control) this.Ru1naDpysJ);
      this.NUhnOV4LxZ.Controls.Add((Control) this.J4LnGlTHkF);
      this.NUhnOV4LxZ.Controls.Add((Control) this.DJ7nZBFY6P);
      this.NUhnOV4LxZ.Dock = DockStyle.Top;
      this.NUhnOV4LxZ.Location = new Point(8, 64);
      this.NUhnOV4LxZ.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34166);
      this.NUhnOV4LxZ.Size = new Size(149, 24);
      this.NUhnOV4LxZ.TabIndex = 3;
      this.Ru1naDpysJ.Dock = DockStyle.Fill;
      this.Ru1naDpysJ.Location = new Point(72, 0);
      this.Ru1naDpysJ.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34184);
      this.Ru1naDpysJ.Size = new Size(69, 20);
      this.Ru1naDpysJ.TabIndex = 2;
      this.Ru1naDpysJ.TextChanged += new EventHandler(this.reOJUJvrOK);
      this.J4LnGlTHkF.Dock = DockStyle.Right;
      this.J4LnGlTHkF.Location = new Point(141, 0);
      this.J4LnGlTHkF.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34222);
      this.J4LnGlTHkF.Size = new Size(8, 24);
      this.J4LnGlTHkF.TabIndex = 1;
      this.DJ7nZBFY6P.AutoCheck = false;
      this.DJ7nZBFY6P.Dock = DockStyle.Left;
      this.DJ7nZBFY6P.Location = new Point(0, 0);
      this.DJ7nZBFY6P.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34240);
      this.DJ7nZBFY6P.Size = new Size(72, 24);
      this.DJ7nZBFY6P.TabIndex = 0;
      this.DJ7nZBFY6P.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34278);
      this.DJ7nZBFY6P.Click += new EventHandler(this.FRXJIdE8IK);
      this.vBBn4k9axr.Controls.Add((Control) this.VBmnIr1pAt);
      this.vBBn4k9axr.Controls.Add((Control) this.UG9nSZN8QV);
      this.vBBn4k9axr.Dock = DockStyle.Top;
      this.vBBn4k9axr.Location = new Point(8, 40);
      this.vBBn4k9axr.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34298);
      this.vBBn4k9axr.Size = new Size(149, 24);
      this.vBBn4k9axr.TabIndex = 1;
      this.VBmnIr1pAt.Dock = DockStyle.Fill;
      this.VBmnIr1pAt.Location = new Point(72, 0);
      this.VBmnIr1pAt.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34316);
      this.VBmnIr1pAt.Size = new Size(77, 24);
      this.VBmnIr1pAt.TabIndex = 1;
      this.VBmnIr1pAt.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34346);
      this.VBmnIr1pAt.CheckStateChanged += new EventHandler(this.k6MJSvrOA1);
      this.UG9nSZN8QV.AutoCheck = false;
      this.UG9nSZN8QV.Dock = DockStyle.Left;
      this.UG9nSZN8QV.Location = new Point(0, 0);
      this.UG9nSZN8QV.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34376);
      this.UG9nSZN8QV.Size = new Size(72, 24);
      this.UG9nSZN8QV.TabIndex = 0;
      this.UG9nSZN8QV.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34406);
      this.UG9nSZN8QV.Click += new EventHandler(this.FRXJIdE8IK);
      this.g5CnUvEp8S.AutoCheck = false;
      this.g5CnUvEp8S.Dock = DockStyle.Top;
      this.g5CnUvEp8S.Location = new Point(8, 16);
      this.g5CnUvEp8S.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34428);
      this.g5CnUvEp8S.Size = new Size(149, 24);
      this.g5CnUvEp8S.TabIndex = 2;
      this.g5CnUvEp8S.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34462);
      this.g5CnUvEp8S.Click += new EventHandler(this.FRXJIdE8IK);
      this.H1RnjAhgpq.Dock = DockStyle.Left;
      this.H1RnjAhgpq.Location = new Point(3, 16);
      this.H1RnjAhgpq.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34478);
      this.H1RnjAhgpq.Size = new Size(5, 77);
      this.H1RnjAhgpq.TabIndex = 0;
      this.uaOnLVIuNQ.Controls.Add((Control) this.jLAniL5iWW);
      this.uaOnLVIuNQ.Controls.Add((Control) this.ostnWa3s9R);
      this.uaOnLVIuNQ.Controls.Add((Control) this.NC8nTHgJ9H);
      this.uaOnLVIuNQ.Controls.Add((Control) this.hN0nfE4S3W);
      this.uaOnLVIuNQ.Location = new Point(352, 8);
      this.uaOnLVIuNQ.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34494);
      this.uaOnLVIuNQ.Size = new Size(144, 96);
      this.uaOnLVIuNQ.TabIndex = 3;
      this.uaOnLVIuNQ.TabStop = false;
      this.uaOnLVIuNQ.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34526);
      this.jLAniL5iWW.Controls.Add((Control) this.tPOn9R3O5A);
      this.jLAniL5iWW.Controls.Add((Control) this.AIxn3N4E03);
      this.jLAniL5iWW.Dock = DockStyle.Fill;
      this.jLAniL5iWW.Location = new Point(8, 64);
      this.jLAniL5iWW.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34554);
      this.jLAniL5iWW.Size = new Size(133, 29);
      this.jLAniL5iWW.TabIndex = 3;
      this.tPOn9R3O5A.Dock = DockStyle.Right;
      this.tPOn9R3O5A.Format = DateTimePickerFormat.Short;
      this.tPOn9R3O5A.Location = new Point(21, 0);
      this.tPOn9R3O5A.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34570);
      this.tPOn9R3O5A.Size = new Size(104, 20);
      this.tPOn9R3O5A.TabIndex = 1;
      this.tPOn9R3O5A.ValueChanged += new EventHandler(this.m8OJ4ZlgH3);
      this.AIxn3N4E03.Dock = DockStyle.Right;
      this.AIxn3N4E03.Location = new Point(125, 0);
      this.AIxn3N4E03.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34604);
      this.AIxn3N4E03.Size = new Size(8, 29);
      this.AIxn3N4E03.TabIndex = 0;
      this.ostnWa3s9R.Dock = DockStyle.Top;
      this.ostnWa3s9R.Location = new Point(8, 40);
      this.ostnWa3s9R.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34620);
      this.ostnWa3s9R.Size = new Size(133, 24);
      this.ostnWa3s9R.TabIndex = 2;
      this.ostnWa3s9R.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34654);
      this.ostnWa3s9R.CheckedChanged += new EventHandler(this.MPIJZ9vPsC);
      this.NC8nTHgJ9H.Dock = DockStyle.Top;
      this.NC8nTHgJ9H.Location = new Point(8, 16);
      this.NC8nTHgJ9H.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34674);
      this.NC8nTHgJ9H.Size = new Size(133, 24);
      this.NC8nTHgJ9H.TabIndex = 1;
      this.NC8nTHgJ9H.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34704);
      this.NC8nTHgJ9H.CheckedChanged += new EventHandler(this.eENJGrt29d);
      this.hN0nfE4S3W.Dock = DockStyle.Left;
      this.hN0nfE4S3W.Location = new Point(3, 16);
      this.hN0nfE4S3W.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34720);
      this.hN0nfE4S3W.Size = new Size(5, 77);
      this.hN0nfE4S3W.TabIndex = 0;
      this.wvNnlXtLAl.Controls.Add((Control) this.vndnuCG4Gr);
      this.wvNnlXtLAl.Controls.Add((Control) this.ebsnJ8QWUl);
      this.wvNnlXtLAl.Location = new Point(184, 8);
      this.wvNnlXtLAl.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34736);
      this.wvNnlXtLAl.Size = new Size(160, 96);
      this.wvNnlXtLAl.TabIndex = 2;
      this.wvNnlXtLAl.TabStop = false;
      this.wvNnlXtLAl.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34758);
      this.vndnuCG4Gr.Controls.Add((Control) this.MDmngl746B);
      this.vndnuCG4Gr.Controls.Add((Control) this.mWEnM7RqtZ);
      this.vndnuCG4Gr.Location = new Point(8, 48);
      this.vndnuCG4Gr.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34786);
      this.vndnuCG4Gr.Size = new Size(144, 24);
      this.vndnuCG4Gr.TabIndex = 1;
      this.MDmngl746B.Dock = DockStyle.Fill;
      this.MDmngl746B.Location = new Point(74, 0);
      NumericUpDown numericUpDown1 = this.MDmngl746B;
      int[] bits1 = new int[4];
      bits1[0] = 86400;
      Decimal num1 = new Decimal(bits1);
      numericUpDown1.Maximum = num1;
      NumericUpDown numericUpDown2 = this.MDmngl746B;
      int[] bits2 = new int[4];
      bits2[0] = 1;
      Decimal num2 = new Decimal(bits2);
      numericUpDown2.Minimum = num2;
      this.MDmngl746B.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34814);
      this.MDmngl746B.Size = new Size(70, 20);
      this.MDmngl746B.TabIndex = 1;
      this.MDmngl746B.TextAlign = HorizontalAlignment.Right;
      NumericUpDown numericUpDown3 = this.MDmngl746B;
      int[] bits3 = new int[4];
      bits3[0] = 60;
      Decimal num3 = new Decimal(bits3);
      numericUpDown3.Value = num3;
      this.MDmngl746B.ValueChanged += new EventHandler(this.AiGJaHTxLu);
      this.mWEnM7RqtZ.Dock = DockStyle.Left;
      this.mWEnM7RqtZ.Location = new Point(0, 0);
      this.mWEnM7RqtZ.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34838);
      this.mWEnM7RqtZ.Size = new Size(74, 24);
      this.mWEnM7RqtZ.TabIndex = 0;
      this.mWEnM7RqtZ.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34854);
      this.mWEnM7RqtZ.TextAlign = ContentAlignment.MiddleLeft;
      this.ebsnJ8QWUl.Controls.Add((Control) this.he6nnuddXV);
      this.ebsnJ8QWUl.Controls.Add((Control) this.plen7X4Uhd);
      this.ebsnJ8QWUl.Location = new Point(8, 16);
      this.ebsnJ8QWUl.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34886);
      this.ebsnJ8QWUl.Size = new Size(144, 24);
      this.ebsnJ8QWUl.TabIndex = 0;
      this.he6nnuddXV.Dock = DockStyle.Fill;
      this.he6nnuddXV.DropDownStyle = ComboBoxStyle.DropDownList;
      this.he6nnuddXV.Location = new Point(48, 0);
      this.he6nnuddXV.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34902);
      this.he6nnuddXV.Size = new Size(96, 21);
      this.he6nnuddXV.TabIndex = 1;
      this.he6nnuddXV.SelectedIndexChanged += new EventHandler(this.RXnJOXKNpE);
      this.plen7X4Uhd.Dock = DockStyle.Left;
      this.plen7X4Uhd.Location = new Point(0, 0);
      this.plen7X4Uhd.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34930);
      this.plen7X4Uhd.Size = new Size(48, 24);
      this.plen7X4Uhd.TabIndex = 0;
      this.plen7X4Uhd.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34946);
      this.plen7X4Uhd.TextAlign = ContentAlignment.MiddleLeft;
      this.A4WnsRxjeC.Controls.Add((Control) this.QXknY1c4j9);
      this.A4WnsRxjeC.Controls.Add((Control) this.AEQndPNctO);
      this.A4WnsRxjeC.Location = new Point(8, 8);
      this.A4WnsRxjeC.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34958);
      this.A4WnsRxjeC.Size = new Size(168, 96);
      this.A4WnsRxjeC.TabIndex = 1;
      this.A4WnsRxjeC.TabStop = false;
      this.A4WnsRxjeC.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34980);
      this.QXknY1c4j9.Controls.Add((Control) this.uUxnxoWa5U);
      this.QXknY1c4j9.Controls.Add((Control) this.E9lnDmQcp5);
      this.QXknY1c4j9.Controls.Add((Control) this.a0hn1vkO1J);
      this.QXknY1c4j9.Location = new Point(8, 48);
      this.QXknY1c4j9.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(34990);
      this.QXknY1c4j9.Size = new Size(152, 24);
      this.QXknY1c4j9.TabIndex = 6;
      this.uUxnxoWa5U.BackColor = SystemColors.Window;
      this.uUxnxoWa5U.Dock = DockStyle.Fill;
      this.uUxnxoWa5U.Location = new Point(72, 0);
      this.uUxnxoWa5U.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35006);
      this.uUxnxoWa5U.ReadOnly = true;
      this.uUxnxoWa5U.Size = new Size(48, 20);
      this.uUxnxoWa5U.TabIndex = 6;
      this.uUxnxoWa5U.TextAlign = HorizontalAlignment.Center;
      this.uUxnxoWa5U.ValueChanged += new EventHandler(this.O9gJfkAnte);
      this.E9lnDmQcp5.Dock = DockStyle.Right;
      this.E9lnDmQcp5.Location = new Point(120, 0);
      this.E9lnDmQcp5.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35038);
      this.E9lnDmQcp5.Size = new Size(32, 24);
      this.E9lnDmQcp5.TabIndex = 5;
      this.E9lnDmQcp5.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35054);
      this.E9lnDmQcp5.TextAlign = ContentAlignment.MiddleLeft;
      this.a0hn1vkO1J.Dock = DockStyle.Left;
      this.a0hn1vkO1J.Location = new Point(0, 0);
      this.a0hn1vkO1J.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35068);
      this.a0hn1vkO1J.Size = new Size(72, 24);
      this.a0hn1vkO1J.TabIndex = 3;
      this.a0hn1vkO1J.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35084);
      this.a0hn1vkO1J.TextAlign = ContentAlignment.MiddleLeft;
      this.AEQndPNctO.Controls.Add((Control) this.zxNnFhDigO);
      this.AEQndPNctO.Controls.Add((Control) this.IIbnb6FcOw);
      this.AEQndPNctO.Location = new Point(8, 16);
      this.AEQndPNctO.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35110);
      this.AEQndPNctO.Size = new Size(152, 24);
      this.AEQndPNctO.TabIndex = 5;
      this.zxNnFhDigO.Dock = DockStyle.Fill;
      this.zxNnFhDigO.DropDownStyle = ComboBoxStyle.DropDownList;
      this.zxNnFhDigO.Location = new Point(72, 0);
      this.zxNnFhDigO.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35126);
      this.zxNnFhDigO.Size = new Size(80, 21);
      this.zxNnFhDigO.TabIndex = 2;
      this.zxNnFhDigO.SelectedIndexChanged += new EventHandler(this.NoxJTyfMev);
      this.IIbnb6FcOw.Dock = DockStyle.Left;
      this.IIbnb6FcOw.Location = new Point(0, 0);
      this.IIbnb6FcOw.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35156);
      this.IIbnb6FcOw.Size = new Size(72, 24);
      this.IIbnb6FcOw.TabIndex = 1;
      this.IIbnb6FcOw.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35172);
      this.IIbnb6FcOw.TextAlign = ContentAlignment.MiddleLeft;
      this.ixgnhay4kI.Controls.Add((Control) this.hX5npFEjSn);
      this.ixgnhay4kI.Controls.Add((Control) this.j8Tnq97LBA);
      this.ixgnhay4kI.Controls.Add((Control) this.ucSnVeNbra);
      this.ixgnhay4kI.Location = new Point(4, 22);
      this.ixgnhay4kI.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35194);
      this.ixgnhay4kI.Size = new Size(672, 110);
      this.ixgnhay4kI.TabIndex = 1;
      this.ixgnhay4kI.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35214);
      this.hX5npFEjSn.Controls.Add((Control) this.V8sntmTDZc);
      this.hX5npFEjSn.Controls.Add((Control) this.NtSnEnPlhY);
      this.hX5npFEjSn.Controls.Add((Control) this.dT5nNE3K7s);
      this.hX5npFEjSn.Location = new Point(360, 8);
      this.hX5npFEjSn.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35234);
      this.hX5npFEjSn.Size = new Size(292, 96);
      this.hX5npFEjSn.TabIndex = 2;
      this.hX5npFEjSn.TabStop = false;
      this.hX5npFEjSn.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35256);
      this.V8sntmTDZc.Dock = DockStyle.Top;
      this.V8sntmTDZc.Location = new Point(8, 40);
      this.V8sntmTDZc.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35270);
      this.V8sntmTDZc.Size = new Size(281, 23);
      this.V8sntmTDZc.TabIndex = 4;
      this.V8sntmTDZc.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35302);
      this.V8sntmTDZc.CheckedChanged += new EventHandler(this.p1LJq2RbPc);
      this.NtSnEnPlhY.Controls.Add((Control) this.OjynvOA3Z9);
      this.NtSnEnPlhY.Controls.Add((Control) this.kUOnQ34Fm2);
      this.NtSnEnPlhY.Dock = DockStyle.Top;
      this.NtSnEnPlhY.Location = new Point(8, 16);
      this.NtSnEnPlhY.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35330);
      this.NtSnEnPlhY.Size = new Size(281, 24);
      this.NtSnEnPlhY.TabIndex = 5;
      this.OjynvOA3Z9.Dock = DockStyle.Fill;
      this.OjynvOA3Z9.Location = new Point(0, 0);
      this.OjynvOA3Z9.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35348);
      this.OjynvOA3Z9.Size = new Size(110, 24);
      this.OjynvOA3Z9.TabIndex = 4;
      this.OjynvOA3Z9.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35390);
      this.OjynvOA3Z9.CheckedChanged += new EventHandler(this.ij4J8uF1T1);
      this.kUOnQ34Fm2.Dock = DockStyle.Right;
      this.kUOnQ34Fm2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.kUOnQ34Fm2.FormattingEnabled = true;
      this.kUOnQ34Fm2.Location = new Point(110, 0);
      this.kUOnQ34Fm2.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35428);
      this.kUOnQ34Fm2.Size = new Size(160, 21);
      this.kUOnQ34Fm2.TabIndex = 0;
      this.kUOnQ34Fm2.SelectedIndexChanged += new EventHandler(this.A5ZJ555R8N);
      this.dT5nNE3K7s.Dock = DockStyle.Left;
      this.dT5nNE3K7s.Location = new Point(3, 16);
      this.dT5nNE3K7s.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35464);
      this.dT5nNE3K7s.Size = new Size(5, 77);
      this.dT5nNE3K7s.TabIndex = 2;
      this.j8Tnq97LBA.Controls.Add((Control) this.dA7nX4P7UC);
      this.j8Tnq97LBA.Controls.Add((Control) this.Ce2nwgqXC7);
      this.j8Tnq97LBA.Controls.Add((Control) this.hG0nC0QP0h);
      this.j8Tnq97LBA.Controls.Add((Control) this.krSn2PnvwE);
      this.j8Tnq97LBA.Location = new Point(184, 8);
      this.j8Tnq97LBA.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35482);
      this.j8Tnq97LBA.Size = new Size(168, 96);
      this.j8Tnq97LBA.TabIndex = 1;
      this.j8Tnq97LBA.TabStop = false;
      this.j8Tnq97LBA.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35504);
      this.dA7nX4P7UC.Controls.Add((Control) this.vaon02QBvb);
      this.dA7nX4P7UC.Controls.Add((Control) this.Lw5nm3kjg1);
      this.dA7nX4P7UC.Controls.Add((Control) this.NcNnKW3Y4O);
      this.dA7nX4P7UC.Dock = DockStyle.Top;
      this.dA7nX4P7UC.Location = new Point(8, 64);
      this.dA7nX4P7UC.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35530);
      this.dA7nX4P7UC.Size = new Size(157, 24);
      this.dA7nX4P7UC.TabIndex = 3;
      this.vaon02QBvb.Dock = DockStyle.Fill;
      this.vaon02QBvb.Location = new Point(64, 0);
      this.vaon02QBvb.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35548);
      this.vaon02QBvb.Size = new Size(85, 20);
      this.vaon02QBvb.TabIndex = 2;
      this.vaon02QBvb.TextChanged += new EventHandler(this.UmLJrur8jL);
      this.Lw5nm3kjg1.Dock = DockStyle.Right;
      this.Lw5nm3kjg1.Location = new Point(149, 0);
      this.Lw5nm3kjg1.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35582);
      this.Lw5nm3kjg1.Size = new Size(8, 24);
      this.Lw5nm3kjg1.TabIndex = 1;
      this.NcNnKW3Y4O.Dock = DockStyle.Left;
      this.NcNnKW3Y4O.Location = new Point(0, 0);
      this.NcNnKW3Y4O.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35600);
      this.NcNnKW3Y4O.Size = new Size(64, 24);
      this.NcNnKW3Y4O.TabIndex = 0;
      this.NcNnKW3Y4O.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35616);
      this.NcNnKW3Y4O.TextAlign = ContentAlignment.MiddleRight;
      this.Ce2nwgqXC7.Dock = DockStyle.Top;
      this.Ce2nwgqXC7.Location = new Point(8, 40);
      this.Ce2nwgqXC7.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35638);
      this.Ce2nwgqXC7.Size = new Size(157, 24);
      this.Ce2nwgqXC7.TabIndex = 2;
      this.Ce2nwgqXC7.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35680);
      this.Ce2nwgqXC7.CheckedChanged += new EventHandler(this.RwTJ6std95);
      this.hG0nC0QP0h.Dock = DockStyle.Top;
      this.hG0nC0QP0h.Location = new Point(8, 16);
      this.hG0nC0QP0h.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35696);
      this.hG0nC0QP0h.Size = new Size(157, 24);
      this.hG0nC0QP0h.TabIndex = 0;
      this.hG0nC0QP0h.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35742);
      this.hG0nC0QP0h.CheckedChanged += new EventHandler(this.fd7JjPjrd6);
      this.krSn2PnvwE.Dock = DockStyle.Left;
      this.krSn2PnvwE.Location = new Point(3, 16);
      this.krSn2PnvwE.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35762);
      this.krSn2PnvwE.Size = new Size(5, 77);
      this.krSn2PnvwE.TabIndex = 1;
      this.ucSnVeNbra.Controls.Add((Control) this.OiFnRw7HJC);
      this.ucSnVeNbra.Location = new Point(8, 8);
      this.ucSnVeNbra.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35780);
      this.ucSnVeNbra.Size = new Size(168, 96);
      this.ucSnVeNbra.TabIndex = 0;
      this.ucSnVeNbra.TabStop = false;
      this.ucSnVeNbra.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35802);
      this.OiFnRw7HJC.Controls.Add((Control) this.kAOnHJrBJu);
      this.OiFnRw7HJC.Controls.Add((Control) this.W1Rnki5Z0d);
      this.OiFnRw7HJC.Location = new Point(8, 16);
      this.OiFnRw7HJC.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35812);
      this.OiFnRw7HJC.Size = new Size(152, 40);
      this.OiFnRw7HJC.TabIndex = 8;
      this.kAOnHJrBJu.Dock = DockStyle.Fill;
      this.kAOnHJrBJu.Location = new Point(0, 0);
      this.kAOnHJrBJu.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35828);
      this.kAOnHJrBJu.Size = new Size(152, 19);
      this.kAOnHJrBJu.TabIndex = 1;
      this.kAOnHJrBJu.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35844);
      this.kAOnHJrBJu.TextAlign = ContentAlignment.MiddleLeft;
      this.W1Rnki5Z0d.Dock = DockStyle.Bottom;
      this.W1Rnki5Z0d.DropDownStyle = ComboBoxStyle.DropDownList;
      this.W1Rnki5Z0d.Location = new Point(0, 19);
      this.W1Rnki5Z0d.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35872);
      this.W1Rnki5Z0d.Size = new Size(152, 21);
      this.W1Rnki5Z0d.TabIndex = 0;
      this.W1Rnki5Z0d.SelectedIndexChanged += new EventHandler(this.Y89JyASM8N);
      this.Lx9n6FKw6I.Dock = DockStyle.Bottom;
      this.Lx9n6FKw6I.Location = new Point(0, 280);
      this.Lx9n6FKw6I.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35898);
      this.Lx9n6FKw6I.Size = new Size(680, 8);
      this.Lx9n6FKw6I.TabIndex = 7;
      this.Controls.Add((Control) this.o1vJtAKLoE);
      this.Controls.Add((Control) this.BalJz8TAlv);
      this.Controls.Add((Control) this.Lx9n6FKw6I);
      this.Controls.Add((Control) this.aqxJQqkJQs);
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35916);
      this.Size = new Size(680, 312);
      this.aqxJQqkJQs.ResumeLayout(false);
      this.BalJz8TAlv.ResumeLayout(false);
      this.kGknefHTCu.ResumeLayout(false);
      this.qQInyfbg1f.ResumeLayout(false);
      this.NUhnOV4LxZ.ResumeLayout(false);
      this.NUhnOV4LxZ.PerformLayout();
      this.vBBn4k9axr.ResumeLayout(false);
      this.uaOnLVIuNQ.ResumeLayout(false);
      this.jLAniL5iWW.ResumeLayout(false);
      this.wvNnlXtLAl.ResumeLayout(false);
      this.vndnuCG4Gr.ResumeLayout(false);
      this.MDmngl746B.EndInit();
      this.ebsnJ8QWUl.ResumeLayout(false);
      this.A4WnsRxjeC.ResumeLayout(false);
      this.QXknY1c4j9.ResumeLayout(false);
      this.uUxnxoWa5U.EndInit();
      this.AEQndPNctO.ResumeLayout(false);
      this.ixgnhay4kI.ResumeLayout(false);
      this.hX5npFEjSn.ResumeLayout(false);
      this.NtSnEnPlhY.ResumeLayout(false);
      this.j8Tnq97LBA.ResumeLayout(false);
      this.dA7nX4P7UC.ResumeLayout(false);
      this.dA7nX4P7UC.PerformLayout();
      this.ucSnVeNbra.ResumeLayout(false);
      this.OiFnRw7HJC.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void BeforeLoad()
    {
      this.PROJ0pMlxQ.Clear();
      StreamReader streamReader = new StreamReader(this.settings.Files[0].FullName);
      for (int index = 0; index < 50; ++index)
      {
        string str = streamReader.ReadLine();
        if (str != null)
          this.PROJ0pMlxQ.Add((object) str);
        else
          break;
      }
      streamReader.Close();
      this.y7gJg3V3Wo();
      this.alwJM3EfWV();
      this.JNEJ735LSl();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void y7gJg3V3Wo()
    {
      Template template = this.settings.Template;
      int num = 0;
      foreach (string str in this.PROJ0pMlxQ)
      {
        string[] strArray = str.Split((char[]) template.CSVOptions.Separator);
        if (strArray.Length > num)
          num = strArray.Length;
      }
      while (template.Columns.Count > num)
        template.Columns.RemoveAt(template.Columns.Count - 1);
      while (template.Columns.Count < num)
        template.Columns.Add(new Column());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void alwJM3EfWV()
    {
      Template template = this.settings.Template;
      this.poFJp4VXTE = false;
      foreach (SeparatorItem separatorItem in this.zxNnFhDigO.Items)
      {
        if (separatorItem.Separator == template.CSVOptions.Separator)
        {
          this.zxNnFhDigO.SelectedItem = (object) separatorItem;
          break;
        }
      }
      this.uUxnxoWa5U.Value = (Decimal) template.CSVOptions.HeaderLineCount;
      foreach (CultureInfoItem cultureInfoItem in this.W1Rnki5Z0d.Items)
      {
        if (cultureInfoItem.CultureInfo.Equals((object) template.CSVOptions.CultureInfo))
        {
          this.W1Rnki5Z0d.SelectedItem = (object) cultureInfoItem;
          break;
        }
      }
      foreach (DataTypeItem dataTypeItem in this.he6nnuddXV.Items)
      {
        if (dataTypeItem.DataType == template.DataOptions.DataType)
        {
          this.he6nnuddXV.SelectedItem = (object) dataTypeItem;
          IEnumerator enumerator = template.Columns.GetEnumerator();
          try
          {
            while (enumerator.MoveNext())
            {
              Column column = (Column) enumerator.Current;
              if (!dataTypeItem.IsColumnAllowed(column.ColumnType))
              {
                column.ColumnType = ColumnType.Skipped;
                column.ColumnFormat = "";
              }
            }
            break;
          }
          finally
          {
            IDisposable disposable = enumerator as IDisposable;
            if (disposable != null)
              disposable.Dispose();
          }
        }
      }
      this.MDmngl746B.Value = (Decimal) template.DataOptions.BarSize;
      this.vndnuCG4Gr.Enabled = template.DataOptions.DataType == DataType.Bar;
      switch (template.DateOptions.DateType)
      {
        case DateType.Column:
          this.NC8nTHgJ9H.Checked = true;
          this.tPOn9R3O5A.Enabled = false;
          break;
        case DateType.Manually:
          this.ostnWa3s9R.Checked = true;
          this.tPOn9R3O5A.Enabled = true;
          this.wx5JJ905QK((ColumnType) 6);
          break;
      }
      this.tPOn9R3O5A.Value = template.DateOptions.Date;
      this.uaOnLVIuNQ.Enabled = template.DataOptions.DataType != DataType.Daily;
      this.g5CnUvEp8S.Checked = this.UG9nSZN8QV.Checked = this.DJ7nZBFY6P.Checked = false;
      switch (template.SymbolOptions.Option)
      {
        case SymbolOption.FileName:
          this.UG9nSZN8QV.Checked = true;
          this.VBmnIr1pAt.Enabled = true;
          this.Ru1naDpysJ.Enabled = false;
          this.wx5JJ905QK(ColumnType.Symbol);
          break;
        case SymbolOption.Column:
          this.g5CnUvEp8S.Checked = true;
          this.VBmnIr1pAt.Enabled = false;
          this.Ru1naDpysJ.Enabled = false;
          break;
        case SymbolOption.Manually:
          this.DJ7nZBFY6P.Checked = true;
          this.VBmnIr1pAt.Enabled = false;
          this.Ru1naDpysJ.Enabled = true;
          this.wx5JJ905QK(ColumnType.Symbol);
          break;
      }
      this.VBmnIr1pAt.Checked = template.SymbolOptions.CutFileExt;
      this.Ru1naDpysJ.Text = template.SymbolOptions.Name;
      switch (template.SeriesOptions.Option)
      {
        case SeriesNameOption.Standard:
          this.hG0nC0QP0h.Checked = true;
          this.vaon02QBvb.Enabled = false;
          string str1;
          switch (template.DataOptions.DataType)
          {
            case DataType.Daily:
              str1 = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35996);
              break;
            case DataType.Trade:
              str1 = RNaihRhYEl0wUmAftnB.aYu7exFQKN(36010);
              break;
            case DataType.Quote:
              str1 = RNaihRhYEl0wUmAftnB.aYu7exFQKN(36024);
              break;
            case DataType.Bar:
              str1 = RNaihRhYEl0wUmAftnB.aYu7exFQKN(35986) + (object) '.' + ((object) BarType.Time).ToString() + (string) (object) '.' + template.DataOptions.BarSize.ToString();
              break;
            default:
              throw new ArgumentException(RNaihRhYEl0wUmAftnB.aYu7exFQKN(36038) + ((object) template.DataOptions.DataType).ToString());
          }
          this.vaon02QBvb.Text = str1;
          break;
        case SeriesNameOption.Custom:
          this.Ce2nwgqXC7.Checked = true;
          this.vaon02QBvb.Enabled = true;
          break;
      }
      this.OjynvOA3Z9.Checked = template.OtherOptions.CreateInstrument;
      this.V8sntmTDZc.Checked = template.OtherOptions.ClearSeries;
      foreach (pLqk8fiaEZ51QA5QZ6 lqk8fiaEz51Qa5Qz6 in this.kUOnQ34Fm2.Items)
      {
        if (lqk8fiaEz51Qa5Qz6.yQ9Fk8kxDA() == template.OtherOptions.SecurityType)
        {
          this.kUOnQ34Fm2.SelectedItem = (object) lqk8fiaEz51Qa5Qz6;
          break;
        }
      }
      this.kUOnQ34Fm2.Enabled = template.OtherOptions.CreateInstrument;
      this.o1vJtAKLoE.BeginUpdate();
      this.o1vJtAKLoE.Items.Clear();
      while (this.o1vJtAKLoE.Columns.Count > template.Columns.Count + 1)
        this.o1vJtAKLoE.Columns.RemoveAt(this.o1vJtAKLoE.Columns.Count - 1);
      for (int index = 0; index < template.Columns.Count; ++index)
      {
        string str2 = Column.ToString(template.Columns[index].ColumnType);
        if (template.Columns[index].ColumnFormat != "")
          str2 = str2 + RNaihRhYEl0wUmAftnB.aYu7exFQKN(36082) + template.Columns[index].ColumnFormat + RNaihRhYEl0wUmAftnB.aYu7exFQKN(36090);
        if (this.o1vJtAKLoE.Columns.Count <= index + 1)
          this.o1vJtAKLoE.Columns.Add("", 100, HorizontalAlignment.Center);
        this.o1vJtAKLoE.Columns[index + 1].Text = str2;
      }
      foreach (string str2 in this.PROJ0pMlxQ)
      {
        string[] strArray = str2.Split((char[]) template.CSVOptions.Separator);
        ListViewItem listViewItem = new ListViewItem("");
        listViewItem.UseItemStyleForSubItems = true;
        if (this.o1vJtAKLoE.Items.Count < template.CSVOptions.HeaderLineCount)
          listViewItem.BackColor = Color.Red;
        foreach (string text in strArray)
          listViewItem.SubItems.Add(text);
        this.o1vJtAKLoE.Items.Add(listViewItem);
      }
      this.o1vJtAKLoE.EndUpdate();
      template.Validate();
      if (template.IsCompleted)
      {
        this.fJ3n5NGNGC.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(36096);
        this.BaGn8AfOyP.ImageIndex = 1;
      }
      else
      {
        this.fJ3n5NGNGC.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(36142);
        this.BaGn8AfOyP.ImageIndex = 0;
      }
      this.EmitButtonEnabledChanged();
      this.poFJp4VXTE = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void wx5JJ905QK([In] ColumnType obj0)
    {
      foreach (Column column in (CollectionBase) this.settings.Template.Columns)
      {
        if ((column.ColumnType & obj0) > (ColumnType) 0)
        {
          column.ColumnType = ColumnType.Skipped;
          column.ColumnFormat = "";
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExuJnDq4Px()
    {
      if (this.settings.Template.IsCompleted)
        return;
      TemplateErrorForm templateErrorForm = new TemplateErrorForm();
      templateErrorForm.SetErrors(this.settings.Template.Validate());
      int num = (int) templateErrorForm.ShowDialog();
      templateErrorForm.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void JNEJ735LSl()
    {
      this.odJJoglvD1.BeginUpdate();
      this.odJJoglvD1.Items.Clear();
      foreach (Template template in this.SNpJLFn9ue())
        this.odJJoglvD1.Items.Add((object) template);
      this.odJJoglvD1.EndUpdate();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private TemplateCollection SNpJLFn9ue()
    {
      if (!File.Exists(Framework.Installation.IniDir.FullName + RNaihRhYEl0wUmAftnB.aYu7exFQKN(36226)))
        return new TemplateCollection();
      try
      {
        TemplateXmlDocument templateXmlDocument = new TemplateXmlDocument();
        templateXmlDocument.Load(Framework.Installation.IniDir.FullName + RNaihRhYEl0wUmAftnB.aYu7exFQKN(36272));
        return templateXmlDocument.ReadTemplates();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(RNaihRhYEl0wUmAftnB.aYu7exFQKN(36318) + Environment.NewLine + Environment.NewLine + RNaihRhYEl0wUmAftnB.aYu7exFQKN(36376), RNaihRhYEl0wUmAftnB.aYu7exFQKN(36430), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        if (Trace.IsLevelEnabled(TraceLevel.Error))
          Trace.WriteLine(((object) ex).ToString());
        return new TemplateCollection();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void yukJiX0y2y([In] object obj0, [In] ColumnClickEventArgs obj1)
    {
      this.cOfJEtN14g.Column = obj1.Column;
      this.cOfJEtN14g.Show((Control) this, this.PointToClient(Cursor.Position));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FYmJ9npO5F([In] object obj0, [In] EventArgs obj1)
    {
      DataTypeItem dataTypeItem = this.he6nnuddXV.SelectedItem as DataTypeItem;
      foreach (MenuItem menuItem in this.cOfJEtN14g.MenuItems)
      {
        ColumnMenuItem columnMenuItem = menuItem as ColumnMenuItem;
        if (columnMenuItem != null)
        {
          columnMenuItem.Visible = dataTypeItem.IsColumnAllowed(columnMenuItem.ColumnType);
          if (this.ostnWa3s9R.Checked && (columnMenuItem.ColumnType == ColumnType.Date || columnMenuItem.ColumnType == ColumnType.DateTime))
            columnMenuItem.Visible = false;
          if (!this.g5CnUvEp8S.Checked && columnMenuItem.ColumnType == ColumnType.Symbol)
            columnMenuItem.Visible = false;
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void krhJ3KCqf3([In] object obj0, [In] EventArgs obj1)
    {
      ColumnMenuItem columnMenuItem = obj0 as ColumnMenuItem;
      Column column = this.settings.Template.Columns[this.cOfJEtN14g.Column - 1];
      if (columnMenuItem.ColumnType != ColumnType.Skipped)
        this.wx5JJ905QK(columnMenuItem.ColumnType);
      column.ColumnType = columnMenuItem.ColumnType;
      column.ColumnFormat = columnMenuItem.ColumnFormat;
      switch (columnMenuItem.ColumnType)
      {
        case ColumnType.DateTime:
          this.wx5JJ905QK((ColumnType) 12);
          break;
        case ColumnType.Date:
        case ColumnType.Time:
          this.wx5JJ905QK(ColumnType.DateTime);
          break;
      }
      this.alwJM3EfWV();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Wt8JWhWpkK([In] object obj0, [In] EventArgs obj1)
    {
      Column column = this.settings.Template.Columns[this.cOfJEtN14g.Column - 1];
      CustomFormatDialog customFormatDialog = new CustomFormatDialog();
      customFormatDialog.Format = column.ColumnFormat;
      if (customFormatDialog.ShowDialog() == DialogResult.OK)
      {
        ColumnMenuItem columnMenuItem = (obj0 as MenuItem).Parent as ColumnMenuItem;
        if (columnMenuItem.ColumnType != ColumnType.Skipped)
          this.wx5JJ905QK(columnMenuItem.ColumnType);
        column.ColumnType = columnMenuItem.ColumnType;
        column.ColumnFormat = customFormatDialog.Format;
        switch (columnMenuItem.ColumnType)
        {
          case ColumnType.DateTime:
            this.wx5JJ905QK((ColumnType) 12);
            break;
          case ColumnType.Date:
          case ColumnType.Time:
            this.wx5JJ905QK(ColumnType.DateTime);
            break;
        }
        this.alwJM3EfWV();
      }
      customFormatDialog.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void NoxJTyfMev([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.poFJp4VXTE)
        return;
      this.settings.Template.CSVOptions.Separator = (this.zxNnFhDigO.SelectedItem as SeparatorItem).Separator;
      this.y7gJg3V3Wo();
      this.alwJM3EfWV();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void O9gJfkAnte([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.poFJp4VXTE)
        return;
      this.settings.Template.CSVOptions.HeaderLineCount = (int) this.uUxnxoWa5U.Value;
      this.alwJM3EfWV();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Y89JyASM8N([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.poFJp4VXTE)
        return;
      this.settings.Template.CSVOptions.CultureInfo = (this.W1Rnki5Z0d.SelectedItem as CultureInfoItem).CultureInfo;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RXnJOXKNpE([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.poFJp4VXTE)
        return;
      Template template = this.settings.Template;
      DataTypeItem dataTypeItem = this.he6nnuddXV.SelectedItem as DataTypeItem;
      template.DataOptions.DataType = dataTypeItem.DataType;
      if (dataTypeItem.DataType == DataType.Daily)
        template.DateOptions.DateType = DateType.Column;
      this.alwJM3EfWV();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AiGJaHTxLu([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.poFJp4VXTE)
        return;
      this.settings.Template.DataOptions.BarSize = (int) this.MDmngl746B.Value;
      this.alwJM3EfWV();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void eENJGrt29d([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.poFJp4VXTE || !this.NC8nTHgJ9H.Checked)
        return;
      this.settings.Template.DateOptions.DateType = DateType.Column;
      this.alwJM3EfWV();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MPIJZ9vPsC([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.poFJp4VXTE || !this.ostnWa3s9R.Checked)
        return;
      this.settings.Template.DateOptions.DateType = DateType.Manually;
      this.alwJM3EfWV();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void m8OJ4ZlgH3([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.poFJp4VXTE)
        return;
      this.settings.Template.DateOptions.Date = this.tPOn9R3O5A.Value.Date;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FRXJIdE8IK([In] object obj0, [In] EventArgs obj1)
    {
      if ((obj0 as RadioButton).Checked)
        return;
      SymbolOption symbolOption = SymbolOption.Column;
      if (obj0 == this.g5CnUvEp8S)
        symbolOption = SymbolOption.Column;
      if (obj0 == this.UG9nSZN8QV)
        symbolOption = SymbolOption.FileName;
      if (obj0 == this.DJ7nZBFY6P)
        symbolOption = SymbolOption.Manually;
      this.settings.Template.SymbolOptions.Option = symbolOption;
      this.alwJM3EfWV();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void k6MJSvrOA1([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.poFJp4VXTE)
        return;
      this.settings.Template.SymbolOptions.CutFileExt = this.VBmnIr1pAt.Checked;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void reOJUJvrOK([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.poFJp4VXTE)
        return;
      this.settings.Template.SymbolOptions.Name = this.Ru1naDpysJ.Text.Trim();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void fd7JjPjrd6([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.poFJp4VXTE || !this.hG0nC0QP0h.Checked)
        return;
      this.settings.Template.SeriesOptions.Option = SeriesNameOption.Standard;
      this.alwJM3EfWV();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RwTJ6std95([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.poFJp4VXTE || !this.Ce2nwgqXC7.Checked)
        return;
      this.settings.Template.SeriesOptions.Option = SeriesNameOption.Custom;
      this.alwJM3EfWV();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UmLJrur8jL([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.poFJp4VXTE)
        return;
      this.settings.Template.SeriesOptions.SeriesSuffix = this.vaon02QBvb.Text.Trim();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ij4J8uF1T1([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.poFJp4VXTE)
        return;
      this.settings.Template.OtherOptions.CreateInstrument = this.OjynvOA3Z9.Checked;
      this.alwJM3EfWV();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void A5ZJ555R8N([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.poFJp4VXTE)
        return;
      this.settings.Template.OtherOptions.SecurityType = (this.kUOnQ34Fm2.SelectedItem as pLqk8fiaEZ51QA5QZ6).yQ9Fk8kxDA();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void p1LJq2RbPc([In] object obj0, [In] EventArgs obj1)
    {
      if (!this.poFJp4VXTE)
        return;
      this.settings.Template.OtherOptions.ClearSeries = this.V8sntmTDZc.Checked;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void JH0JCZ5mdt([In] object obj0, [In] EventArgs obj1)
    {
      this.ExuJnDq4Px();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SHvJ22DdQJ([In] object obj0, [In] EventArgs obj1)
    {
      this.ExuJnDq4Px();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ARUJXlghVJ([In] object obj0, [In] EventArgs obj1)
    {
      TemplateCollection templates = this.SNpJLFn9ue();
      SaveTemplateDialog saveTemplateDialog = new SaveTemplateDialog();
      saveTemplateDialog.SetNames(templates.Names);
      if (saveTemplateDialog.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        Template template = this.settings.Template;
        template.Name = saveTemplateDialog.TemplateName;
        templates[template.Name] = template;
        TemplateXmlDocument templateXmlDocument = new TemplateXmlDocument();
        templateXmlDocument.WriteTemplates(templates);
        templateXmlDocument.Save(Framework.Installation.IniDir.FullName + RNaihRhYEl0wUmAftnB.aYu7exFQKN(36444));
        this.JNEJ735LSl();
      }
      saveTemplateDialog.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void F3HJKmRlmE([In] object obj0, [In] EventArgs obj1)
    {
      Template template = this.odJJoglvD1.SelectedItem as Template;
      if (template == null)
        return;
      this.settings.Template = template;
      this.y7gJg3V3Wo();
      this.alwJM3EfWV();
      this.JNEJ735LSl();
    }
  }
}
