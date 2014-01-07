// Type: SmartQuant.Shared.Data.Management.QuantServer.SeriesManagerForm
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant.Data;
using SmartQuant.File;
using SmartQuant.Instruments;
using SmartQuant.Shared.Controls;
using SmartQuant.Shared.Data.Export.CSV;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Management.QuantServer
{
  public class SeriesManagerForm : Form
  {
    private DataFile kvT1dEnNxu;
    private MainMenu KY91FBJcan;
    private MenuItem Rs31bAZ0B1;
    private MenuItem g011VdYgic;
    private MenuItem n371RwrGE3;
    private MenuItem IRl1HE36aV;
    private MenuItem swa1kD7Sn0;
    private MenuItem IgM1lQw97e;
    private MenuItem L8p1uLZqfn;
    private StatusBar YbM1gChNq9;
    private TabControl YII1MnUGGH;
    private TabPage ENh1JRcBCw;
    private Splitter o1c1nio2lA;
    private TabPage RHM17aw4hG;
    private PropertyGrid hH31Lb9Ni6;
    private Splitter IyB1iFH4Wj;
    private TreeView ehC19bHreh;
    private StatusBarPanel ak8137KnCc;
    private StatusBarPanel rDf1Wjgpel;
    private ImageList mrq1TgBDY8;
    private ImageList o6r1fBCYOq;
    private ListView rBs1yJ9gPQ;
    private IContainer hXp1OYqgeh;
    private TabControl eO71aQYGiy;
    private ContextMenu DG01GlEeGw;
    private ImageMenuItem Mrh1Zbf0Tc;
    private ImageMenuItem oqv14YgXFd;
    private ImageMenuItem DYk1I7AaLy;
    private ImageMenuItem Gas1ScSjF1;
    private ImageMenuItem jIR1U4UaNJ;
    private ImageMenuItem xs31j2ZLfx;
    private ImageMenuItem aF916gyfV3;
    private ImageMenuItem wBQ1rvIquS;
    private ImageMenuItem N9u18u9VDY;
    private ImageMenuItem l0r150HCGb;
    private ImageMenuItem x6E1qmBjkB;
    private ContextMenu JEE1Cav0de;
    private ImageMenuItem Bse12PX3M4;
    private ImageMenuItem Mmn1X8k4Wb;
    private ImageMenuItem iuy1KZwcy3;
    private ImageMenuItem qO41mhxVay;
    private ImageMenuItem EKc1wuEuFP;
    private ImageMenuItem GbD10SGwgx;
    private ImageMenuItem idP1pAyQ5U;
    private ImageMenuItem zGs1NdHFrk;
    private ImageMenuItem HQ21t0kE2O;
    private ImageMenuItem g1v1E826T7;
    private ImageMenuItem LLy1QqkG8u;
    private ImageMenuItem ghu1vfbg1E;
    private ImageMenuItem a4P1oipGeo;
    private ContextMenu oZN1P7MZNp;
    private ImageMenuItem tHE1ANVAnj;
    private ImageMenuItem TBW1Bs9of2;
    private ImageMenuItem Lrx1cK2iWt;
    private ImageMenuItem i861zVkViW;
    private ImageMenuItem Rl5deo6X82;
    private ImageMenuItem r7LdheIOVg;
    private ImageMenuItem yFAds5hBPf;
    private ImageMenuItem T7odY2tRl7;
    private ImageMenuItem AWmdxe7vCd;
    private ImageMenuItem krydDWL2WL;
    private ImageList lwkd13i741;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SeriesManagerForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.MqmD7g3Mk5();
      this.kvT1dEnNxu = (DataManager.Server as FileDataServer).File;
      this.NrYDLZdsHS(View.Details);
      this.vMvDiP1a34();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.hXp1OYqgeh != null)
        this.hXp1OYqgeh.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MqmD7g3Mk5()
    {
      this.hXp1OYqgeh = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SeriesManagerForm));
      this.KY91FBJcan = new MainMenu(this.hXp1OYqgeh);
      this.Rs31bAZ0B1 = new MenuItem();
      this.g011VdYgic = new MenuItem();
      this.n371RwrGE3 = new MenuItem();
      this.IRl1HE36aV = new MenuItem();
      this.swa1kD7Sn0 = new MenuItem();
      this.IgM1lQw97e = new MenuItem();
      this.L8p1uLZqfn = new MenuItem();
      this.YbM1gChNq9 = new StatusBar();
      this.ak8137KnCc = new StatusBarPanel();
      this.rDf1Wjgpel = new StatusBarPanel();
      this.YII1MnUGGH = new TabControl();
      this.ENh1JRcBCw = new TabPage();
      this.ehC19bHreh = new TreeView();
      this.mrq1TgBDY8 = new ImageList(this.hXp1OYqgeh);
      this.IyB1iFH4Wj = new Splitter();
      this.hH31Lb9Ni6 = new PropertyGrid();
      this.o1c1nio2lA = new Splitter();
      this.eO71aQYGiy = new TabControl();
      this.RHM17aw4hG = new TabPage();
      this.rBs1yJ9gPQ = new ListView();
      this.o6r1fBCYOq = new ImageList(this.hXp1OYqgeh);
      this.JEE1Cav0de = new ContextMenu();
      this.Bse12PX3M4 = new ImageMenuItem();
      this.lwkd13i741 = new ImageList(this.hXp1OYqgeh);
      this.EKc1wuEuFP = new ImageMenuItem();
      this.Mmn1X8k4Wb = new ImageMenuItem();
      this.iuy1KZwcy3 = new ImageMenuItem();
      this.zGs1NdHFrk = new ImageMenuItem();
      this.HQ21t0kE2O = new ImageMenuItem();
      this.idP1pAyQ5U = new ImageMenuItem();
      this.GbD10SGwgx = new ImageMenuItem();
      this.Gas1ScSjF1 = new ImageMenuItem();
      this.qO41mhxVay = new ImageMenuItem();
      this.DG01GlEeGw = new ContextMenu();
      this.oqv14YgXFd = new ImageMenuItem();
      this.Mrh1Zbf0Tc = new ImageMenuItem();
      this.jIR1U4UaNJ = new ImageMenuItem();
      this.aF916gyfV3 = new ImageMenuItem();
      this.l0r150HCGb = new ImageMenuItem();
      this.x6E1qmBjkB = new ImageMenuItem();
      this.ghu1vfbg1E = new ImageMenuItem();
      this.a4P1oipGeo = new ImageMenuItem();
      this.g1v1E826T7 = new ImageMenuItem();
      this.LLy1QqkG8u = new ImageMenuItem();
      this.N9u18u9VDY = new ImageMenuItem();
      this.wBQ1rvIquS = new ImageMenuItem();
      this.xs31j2ZLfx = new ImageMenuItem();
      this.DYk1I7AaLy = new ImageMenuItem();
      this.oZN1P7MZNp = new ContextMenu();
      this.tHE1ANVAnj = new ImageMenuItem();
      this.TBW1Bs9of2 = new ImageMenuItem();
      this.Lrx1cK2iWt = new ImageMenuItem();
      this.i861zVkViW = new ImageMenuItem();
      this.Rl5deo6X82 = new ImageMenuItem();
      this.r7LdheIOVg = new ImageMenuItem();
      this.yFAds5hBPf = new ImageMenuItem();
      this.T7odY2tRl7 = new ImageMenuItem();
      this.AWmdxe7vCd = new ImageMenuItem();
      this.krydDWL2WL = new ImageMenuItem();
      this.ak8137KnCc.BeginInit();
      this.rDf1Wjgpel.BeginInit();
      this.YII1MnUGGH.SuspendLayout();
      this.ENh1JRcBCw.SuspendLayout();
      this.eO71aQYGiy.SuspendLayout();
      this.RHM17aw4hG.SuspendLayout();
      this.SuspendLayout();
      this.KY91FBJcan.MenuItems.AddRange(new MenuItem[2]
      {
        this.Rs31bAZ0B1,
        this.n371RwrGE3
      });
      this.Rs31bAZ0B1.Index = 0;
      this.Rs31bAZ0B1.MenuItems.AddRange(new MenuItem[1]
      {
        this.g011VdYgic
      });
      this.Rs31bAZ0B1.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6970);
      this.g011VdYgic.Index = 0;
      this.g011VdYgic.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6982);
      this.g011VdYgic.Click += new EventHandler(this.isZD5rGZtt);
      this.n371RwrGE3.Index = 1;
      this.n371RwrGE3.MenuItems.AddRange(new MenuItem[4]
      {
        this.IRl1HE36aV,
        this.swa1kD7Sn0,
        this.IgM1lQw97e,
        this.L8p1uLZqfn
      });
      this.n371RwrGE3.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(6994);
      this.IRl1HE36aV.Index = 0;
      this.IRl1HE36aV.RadioCheck = true;
      this.IRl1HE36aV.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7006);
      this.IRl1HE36aV.Click += new EventHandler(this.eTxDWs2r6g);
      this.swa1kD7Sn0.Index = 1;
      this.swa1kD7Sn0.RadioCheck = true;
      this.swa1kD7Sn0.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7032);
      this.swa1kD7Sn0.Click += new EventHandler(this.DVQDTTVlRe);
      this.IgM1lQw97e.Index = 2;
      this.IgM1lQw97e.RadioCheck = true;
      this.IgM1lQw97e.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7058);
      this.IgM1lQw97e.Click += new EventHandler(this.WQ4Dftdx7W);
      this.L8p1uLZqfn.Index = 3;
      this.L8p1uLZqfn.RadioCheck = true;
      this.L8p1uLZqfn.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7070);
      this.L8p1uLZqfn.Click += new EventHandler(this.WKPDyZtwh6);
      this.YbM1gChNq9.Location = new Point(0, 533);
      this.YbM1gChNq9.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7088);
      this.YbM1gChNq9.Panels.AddRange(new StatusBarPanel[2]
      {
        this.ak8137KnCc,
        this.rDf1Wjgpel
      });
      this.YbM1gChNq9.ShowPanels = true;
      this.YbM1gChNq9.Size = new Size(928, 20);
      this.YbM1gChNq9.TabIndex = 0;
      this.YbM1gChNq9.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7110);
      this.ak8137KnCc.AutoSize = StatusBarPanelAutoSize.Spring;
      this.ak8137KnCc.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7134);
      this.ak8137KnCc.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7168);
      this.ak8137KnCc.Width = 811;
      this.rDf1Wjgpel.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7182);
      this.YII1MnUGGH.Controls.Add((Control) this.ENh1JRcBCw);
      this.YII1MnUGGH.Dock = DockStyle.Left;
      this.YII1MnUGGH.Location = new Point(0, 0);
      this.YII1MnUGGH.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7216);
      this.YII1MnUGGH.SelectedIndex = 0;
      this.YII1MnUGGH.Size = new Size(248, 533);
      this.YII1MnUGGH.TabIndex = 1;
      this.ENh1JRcBCw.Controls.Add((Control) this.ehC19bHreh);
      this.ENh1JRcBCw.Controls.Add((Control) this.IyB1iFH4Wj);
      this.ENh1JRcBCw.Controls.Add((Control) this.hH31Lb9Ni6);
      this.ENh1JRcBCw.Location = new Point(4, 22);
      this.ENh1JRcBCw.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7242);
      this.ENh1JRcBCw.Size = new Size(240, 507);
      this.ENh1JRcBCw.TabIndex = 0;
      this.ENh1JRcBCw.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7262);
      this.ehC19bHreh.BorderStyle = BorderStyle.None;
      this.ehC19bHreh.Dock = DockStyle.Fill;
      this.ehC19bHreh.HideSelection = false;
      this.ehC19bHreh.ImageIndex = 0;
      this.ehC19bHreh.ImageList = this.mrq1TgBDY8;
      this.ehC19bHreh.Location = new Point(0, 0);
      this.ehC19bHreh.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7274);
      this.ehC19bHreh.SelectedImageIndex = 0;
      this.ehC19bHreh.Size = new Size(240, 280);
      this.ehC19bHreh.TabIndex = 2;
      this.ehC19bHreh.AfterCollapse += new TreeViewEventHandler(this.TZoDONv3da);
      this.ehC19bHreh.AfterSelect += new TreeViewEventHandler(this.cWtDGeKYLH);
      this.ehC19bHreh.AfterExpand += new TreeViewEventHandler(this.dPEDaUNyQi);
      this.mrq1TgBDY8.ImageStream = (ImageListStreamer) componentResourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(7292));
      this.mrq1TgBDY8.TransparentColor = Color.Transparent;
      this.mrq1TgBDY8.Images.SetKeyName(0, "");
      this.mrq1TgBDY8.Images.SetKeyName(1, "");
      this.mrq1TgBDY8.Images.SetKeyName(2, "");
      this.mrq1TgBDY8.Images.SetKeyName(3, "");
      this.IyB1iFH4Wj.Dock = DockStyle.Bottom;
      this.IyB1iFH4Wj.Location = new Point(0, 280);
      this.IyB1iFH4Wj.MinExtra = 100;
      this.IyB1iFH4Wj.MinSize = 100;
      this.IyB1iFH4Wj.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7340);
      this.IyB1iFH4Wj.Size = new Size(240, 3);
      this.IyB1iFH4Wj.TabIndex = 1;
      this.IyB1iFH4Wj.TabStop = false;
      this.hH31Lb9Ni6.Dock = DockStyle.Bottom;
      this.hH31Lb9Ni6.LineColor = SystemColors.ScrollBar;
      this.hH31Lb9Ni6.Location = new Point(0, 283);
      this.hH31Lb9Ni6.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7362);
      this.hH31Lb9Ni6.Size = new Size(240, 224);
      this.hH31Lb9Ni6.TabIndex = 0;
      this.o1c1nio2lA.Location = new Point(248, 0);
      this.o1c1nio2lA.MinExtra = 100;
      this.o1c1nio2lA.MinSize = 100;
      this.o1c1nio2lA.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7392);
      this.o1c1nio2lA.Size = new Size(3, 533);
      this.o1c1nio2lA.TabIndex = 2;
      this.o1c1nio2lA.TabStop = false;
      this.eO71aQYGiy.Controls.Add((Control) this.RHM17aw4hG);
      this.eO71aQYGiy.Dock = DockStyle.Fill;
      this.eO71aQYGiy.Location = new Point(251, 0);
      this.eO71aQYGiy.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7414);
      this.eO71aQYGiy.SelectedIndex = 0;
      this.eO71aQYGiy.Size = new Size(677, 533);
      this.eO71aQYGiy.TabIndex = 3;
      this.RHM17aw4hG.Controls.Add((Control) this.rBs1yJ9gPQ);
      this.RHM17aw4hG.Location = new Point(4, 22);
      this.RHM17aw4hG.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7438);
      this.RHM17aw4hG.Size = new Size(669, 507);
      this.RHM17aw4hG.TabIndex = 0;
      this.RHM17aw4hG.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7458);
      this.rBs1yJ9gPQ.BorderStyle = BorderStyle.None;
      this.rBs1yJ9gPQ.Dock = DockStyle.Fill;
      this.rBs1yJ9gPQ.FullRowSelect = true;
      this.rBs1yJ9gPQ.HideSelection = false;
      this.rBs1yJ9gPQ.LargeImageList = this.o6r1fBCYOq;
      this.rBs1yJ9gPQ.Location = new Point(0, 0);
      this.rBs1yJ9gPQ.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7476);
      this.rBs1yJ9gPQ.Size = new Size(669, 507);
      this.rBs1yJ9gPQ.SmallImageList = this.mrq1TgBDY8;
      this.rBs1yJ9gPQ.TabIndex = 0;
      this.rBs1yJ9gPQ.UseCompatibleStateImageBehavior = false;
      this.rBs1yJ9gPQ.DoubleClick += new EventHandler(this.XRqD2Bcj5L);
      this.rBs1yJ9gPQ.ColumnClick += new ColumnClickEventHandler(this.aIjDm38adF);
      this.rBs1yJ9gPQ.MouseDown += new MouseEventHandler(this.OjYDSLi896);
      this.rBs1yJ9gPQ.Click += new EventHandler(this.WoqDI9BSBh);
      this.o6r1fBCYOq.ImageStream = (ImageListStreamer) componentResourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(7500));
      this.o6r1fBCYOq.TransparentColor = Color.Transparent;
      this.o6r1fBCYOq.Images.SetKeyName(0, "");
      this.o6r1fBCYOq.Images.SetKeyName(1, "");
      this.o6r1fBCYOq.Images.SetKeyName(2, "");
      this.o6r1fBCYOq.Images.SetKeyName(3, "");
      this.JEE1Cav0de.MenuItems.AddRange(new MenuItem[10]
      {
        (MenuItem) this.Bse12PX3M4,
        (MenuItem) this.EKc1wuEuFP,
        (MenuItem) this.Mmn1X8k4Wb,
        (MenuItem) this.iuy1KZwcy3,
        (MenuItem) this.zGs1NdHFrk,
        (MenuItem) this.HQ21t0kE2O,
        (MenuItem) this.idP1pAyQ5U,
        (MenuItem) this.GbD10SGwgx,
        (MenuItem) this.Gas1ScSjF1,
        (MenuItem) this.qO41mhxVay
      });
      this.JEE1Cav0de.Popup += new EventHandler(this.kj7D42YMB2);
      this.Bse12PX3M4.ImageIndex = 0;
      this.Bse12PX3M4.ImageList = this.lwkd13i741;
      this.Bse12PX3M4.Index = 0;
      this.Bse12PX3M4.OwnerDraw = true;
      this.Bse12PX3M4.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7548);
      this.Bse12PX3M4.Click += new EventHandler(this.ecBD6LJBUu);
      this.lwkd13i741.ImageStream = (ImageListStreamer) componentResourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(7580));
      this.lwkd13i741.TransparentColor = Color.Transparent;
      this.lwkd13i741.Images.SetKeyName(0, "");
      this.lwkd13i741.Images.SetKeyName(1, "");
      this.lwkd13i741.Images.SetKeyName(2, "");
      this.lwkd13i741.Images.SetKeyName(3, RNaihRhYEl0wUmAftnB.aYu7exFQKN(7618));
      this.EKc1wuEuFP.ImageList = (ImageList) null;
      this.EKc1wuEuFP.Index = 1;
      this.EKc1wuEuFP.OwnerDraw = true;
      this.EKc1wuEuFP.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7636);
      this.Mmn1X8k4Wb.ImageList = (ImageList) null;
      this.Mmn1X8k4Wb.Index = 2;
      this.Mmn1X8k4Wb.OwnerDraw = true;
      this.Mmn1X8k4Wb.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7642);
      this.Mmn1X8k4Wb.Click += new EventHandler(this.g3pDKHcgGF);
      this.iuy1KZwcy3.ImageList = (ImageList) null;
      this.iuy1KZwcy3.Index = 3;
      this.iuy1KZwcy3.OwnerDraw = true;
      this.iuy1KZwcy3.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7672);
      this.iuy1KZwcy3.Click += new EventHandler(this.CTADNjh6My);
      this.zGs1NdHFrk.ImageList = (ImageList) null;
      this.zGs1NdHFrk.Index = 4;
      this.zGs1NdHFrk.OwnerDraw = true;
      this.zGs1NdHFrk.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7710);
      this.HQ21t0kE2O.ImageIndex = 3;
      this.HQ21t0kE2O.ImageList = this.lwkd13i741;
      this.HQ21t0kE2O.Index = 5;
      this.HQ21t0kE2O.OwnerDraw = true;
      this.HQ21t0kE2O.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7716);
      this.HQ21t0kE2O.Click += new EventHandler(this.pwBDoKRXZa);
      this.idP1pAyQ5U.ImageList = (ImageList) null;
      this.idP1pAyQ5U.Index = 6;
      this.idP1pAyQ5U.OwnerDraw = true;
      this.idP1pAyQ5U.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7752);
      this.GbD10SGwgx.ImageList = (ImageList) null;
      this.GbD10SGwgx.Index = 7;
      this.GbD10SGwgx.OwnerDraw = true;
      this.GbD10SGwgx.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7758);
      this.GbD10SGwgx.Click += new EventHandler(this.wtpDvTyM5q);
      this.Gas1ScSjF1.ImageList = (ImageList) null;
      this.Gas1ScSjF1.Index = 8;
      this.Gas1ScSjF1.OwnerDraw = true;
      this.Gas1ScSjF1.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7788);
      this.qO41mhxVay.ImageIndex = 1;
      this.qO41mhxVay.ImageList = this.lwkd13i741;
      this.qO41mhxVay.Index = 9;
      this.qO41mhxVay.OwnerDraw = true;
      this.qO41mhxVay.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7794);
      this.qO41mhxVay.Click += new EventHandler(this.DqJDqJKDFc);
      this.DG01GlEeGw.MenuItems.AddRange(new MenuItem[14]
      {
        (MenuItem) this.oqv14YgXFd,
        (MenuItem) this.Mrh1Zbf0Tc,
        (MenuItem) this.jIR1U4UaNJ,
        (MenuItem) this.aF916gyfV3,
        (MenuItem) this.l0r150HCGb,
        (MenuItem) this.x6E1qmBjkB,
        (MenuItem) this.ghu1vfbg1E,
        (MenuItem) this.a4P1oipGeo,
        (MenuItem) this.g1v1E826T7,
        (MenuItem) this.LLy1QqkG8u,
        (MenuItem) this.N9u18u9VDY,
        (MenuItem) this.wBQ1rvIquS,
        (MenuItem) this.xs31j2ZLfx,
        (MenuItem) this.DYk1I7AaLy
      });
      this.DG01GlEeGw.Popup += new EventHandler(this.mqLDUSY7C9);
      this.oqv14YgXFd.ImageIndex = 0;
      this.oqv14YgXFd.ImageList = this.lwkd13i741;
      this.oqv14YgXFd.Index = 0;
      this.oqv14YgXFd.OwnerDraw = true;
      this.oqv14YgXFd.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7838);
      this.oqv14YgXFd.Click += new EventHandler(this.Sy0DjKdLX4);
      this.Mrh1Zbf0Tc.ImageList = (ImageList) null;
      this.Mrh1Zbf0Tc.Index = 1;
      this.Mrh1Zbf0Tc.OwnerDraw = true;
      this.Mrh1Zbf0Tc.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7870);
      this.jIR1U4UaNJ.ImageList = (ImageList) null;
      this.jIR1U4UaNJ.Index = 2;
      this.jIR1U4UaNJ.OwnerDraw = true;
      this.jIR1U4UaNJ.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7876);
      this.jIR1U4UaNJ.Click += new EventHandler(this.V7sDCK2bnn);
      this.aF916gyfV3.ImageList = (ImageList) null;
      this.aF916gyfV3.Index = 3;
      this.aF916gyfV3.OwnerDraw = true;
      this.aF916gyfV3.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7904);
      this.l0r150HCGb.ImageList = (ImageList) null;
      this.l0r150HCGb.Index = 4;
      this.l0r150HCGb.OwnerDraw = true;
      this.l0r150HCGb.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7910);
      this.l0r150HCGb.Click += new EventHandler(this.QSwDpNUQin);
      this.x6E1qmBjkB.ImageList = (ImageList) null;
      this.x6E1qmBjkB.Index = 5;
      this.x6E1qmBjkB.OwnerDraw = true;
      this.x6E1qmBjkB.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7942);
      this.x6E1qmBjkB.Click += new EventHandler(this.pvwDt9uebI);
      this.ghu1vfbg1E.ImageList = (ImageList) null;
      this.ghu1vfbg1E.Index = 6;
      this.ghu1vfbg1E.OwnerDraw = true;
      this.ghu1vfbg1E.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7964);
      this.a4P1oipGeo.ImageIndex = 3;
      this.a4P1oipGeo.ImageList = this.lwkd13i741;
      this.a4P1oipGeo.Index = 7;
      this.a4P1oipGeo.OwnerDraw = true;
      this.a4P1oipGeo.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(7970);
      this.a4P1oipGeo.Click += new EventHandler(this.SHgDEQmHW7);
      this.g1v1E826T7.ImageList = (ImageList) null;
      this.g1v1E826T7.Index = 8;
      this.g1v1E826T7.OwnerDraw = true;
      this.g1v1E826T7.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8006);
      this.LLy1QqkG8u.ImageList = (ImageList) null;
      this.LLy1QqkG8u.Index = 9;
      this.LLy1QqkG8u.OwnerDraw = true;
      this.LLy1QqkG8u.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8012);
      this.LLy1QqkG8u.Click += new EventHandler(this.WDXDQkgNqS);
      this.N9u18u9VDY.ImageList = (ImageList) null;
      this.N9u18u9VDY.Index = 10;
      this.N9u18u9VDY.OwnerDraw = true;
      this.N9u18u9VDY.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8028);
      this.wBQ1rvIquS.ImageList = (ImageList) null;
      this.wBQ1rvIquS.Index = 11;
      this.wBQ1rvIquS.OwnerDraw = true;
      this.wBQ1rvIquS.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8034);
      this.wBQ1rvIquS.Click += new EventHandler(this.XLsDwOQqnh);
      this.xs31j2ZLfx.ImageList = (ImageList) null;
      this.xs31j2ZLfx.Index = 12;
      this.xs31j2ZLfx.OwnerDraw = true;
      this.xs31j2ZLfx.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8048);
      this.DYk1I7AaLy.ImageIndex = 2;
      this.DYk1I7AaLy.ImageList = this.lwkd13i741;
      this.DYk1I7AaLy.Index = 13;
      this.DYk1I7AaLy.OwnerDraw = true;
      this.DYk1I7AaLy.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8054);
      this.DYk1I7AaLy.Click += new EventHandler(this.YAODrASBmm);
      this.oZN1P7MZNp.MenuItems.AddRange(new MenuItem[10]
      {
        (MenuItem) this.tHE1ANVAnj,
        (MenuItem) this.TBW1Bs9of2,
        (MenuItem) this.Lrx1cK2iWt,
        (MenuItem) this.i861zVkViW,
        (MenuItem) this.Rl5deo6X82,
        (MenuItem) this.r7LdheIOVg,
        (MenuItem) this.yFAds5hBPf,
        (MenuItem) this.T7odY2tRl7,
        (MenuItem) this.AWmdxe7vCd,
        (MenuItem) this.krydDWL2WL
      });
      this.tHE1ANVAnj.ImageIndex = 0;
      this.tHE1ANVAnj.ImageList = this.lwkd13i741;
      this.tHE1ANVAnj.Index = 0;
      this.tHE1ANVAnj.OwnerDraw = true;
      this.tHE1ANVAnj.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8070);
      this.tHE1ANVAnj.Click += new EventHandler(this.QEIDPhTHAs);
      this.TBW1Bs9of2.ImageList = (ImageList) null;
      this.TBW1Bs9of2.Index = 1;
      this.TBW1Bs9of2.OwnerDraw = true;
      this.TBW1Bs9of2.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8102);
      this.Lrx1cK2iWt.ImageList = (ImageList) null;
      this.Lrx1cK2iWt.Index = 2;
      this.Lrx1cK2iWt.OwnerDraw = true;
      this.Lrx1cK2iWt.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8108);
      this.Lrx1cK2iWt.Click += new EventHandler(this.L0FDAsGGyl);
      this.i861zVkViW.ImageList = (ImageList) null;
      this.i861zVkViW.Index = 3;
      this.i861zVkViW.OwnerDraw = true;
      this.i861zVkViW.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8138);
      this.i861zVkViW.Click += new EventHandler(this.JHcDBCr8KA);
      this.Rl5deo6X82.ImageList = (ImageList) null;
      this.Rl5deo6X82.Index = 4;
      this.Rl5deo6X82.OwnerDraw = true;
      this.Rl5deo6X82.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8176);
      this.r7LdheIOVg.ImageIndex = 3;
      this.r7LdheIOVg.ImageList = this.lwkd13i741;
      this.r7LdheIOVg.Index = 5;
      this.r7LdheIOVg.OwnerDraw = true;
      this.r7LdheIOVg.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8182);
      this.r7LdheIOVg.Click += new EventHandler(this.jxaDcD0r72);
      this.yFAds5hBPf.ImageList = (ImageList) null;
      this.yFAds5hBPf.Index = 6;
      this.yFAds5hBPf.OwnerDraw = true;
      this.yFAds5hBPf.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8218);
      this.T7odY2tRl7.ImageList = (ImageList) null;
      this.T7odY2tRl7.Index = 7;
      this.T7odY2tRl7.OwnerDraw = true;
      this.T7odY2tRl7.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8224);
      this.T7odY2tRl7.Click += new EventHandler(this.UVZDz0QTDu);
      this.AWmdxe7vCd.ImageList = (ImageList) null;
      this.AWmdxe7vCd.Index = 8;
      this.AWmdxe7vCd.OwnerDraw = true;
      this.AWmdxe7vCd.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8254);
      this.krydDWL2WL.ImageIndex = 1;
      this.krydDWL2WL.ImageList = this.lwkd13i741;
      this.krydDWL2WL.Index = 9;
      this.krydDWL2WL.OwnerDraw = true;
      this.krydDWL2WL.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8260);
      this.krydDWL2WL.Click += new EventHandler(this.Fl61euYxxy);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(928, 553);
      this.Controls.Add((Control) this.eO71aQYGiy);
      this.Controls.Add((Control) this.o1c1nio2lA);
      this.Controls.Add((Control) this.YII1MnUGGH);
      this.Controls.Add((Control) this.YbM1gChNq9);
      this.Icon = (Icon) componentResourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(8304));
      this.MaximizeBox = false;
      this.Menu = this.KY91FBJcan;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8328);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8366);
      this.ak8137KnCc.EndInit();
      this.rDf1Wjgpel.EndInit();
      this.YII1MnUGGH.ResumeLayout(false);
      this.ENh1JRcBCw.ResumeLayout(false);
      this.eO71aQYGiy.ResumeLayout(false);
      this.RHM17aw4hG.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void NrYDLZdsHS([In] View obj0)
    {
      this.IRl1HE36aV.Checked = obj0 == View.LargeIcon;
      this.swa1kD7Sn0.Checked = obj0 == View.SmallIcon;
      this.IgM1lQw97e.Checked = obj0 == View.List;
      this.L8p1uLZqfn.Checked = obj0 == View.Details;
      this.rBs1yJ9gPQ.View = obj0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void vMvDiP1a34()
    {
      TreeNode node = (TreeNode) new ServerNode(RNaihRhYEl0wUmAftnB.aYu7exFQKN(8410), 0, 1);
      this.ehC19bHreh.Nodes.Add(node);
      node.Nodes.Add((TreeNode) new FileNode(this.kvT1dEnNxu, 2));
      node.Nodes[0].ContextMenu = this.oZN1P7MZNp;
      this.ehC19bHreh.SelectedNode = node.Nodes[0];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void x3xD9PDaqW()
    {
      this.zrQD3QXhBR(this.ehC19bHreh.Nodes[0].Nodes[0]);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void zrQD3QXhBR([In] TreeNode obj0)
    {
      this.rBs1yJ9gPQ.BeginUpdate();
      this.rBs1yJ9gPQ.Columns.Clear();
      this.rBs1yJ9gPQ.Items.Clear();
      this.rBs1yJ9gPQ.ContextMenu = (ContextMenu) null;
      if (obj0 == null)
      {
        this.rBs1yJ9gPQ.EndUpdate();
      }
      else
      {
        if (obj0 is ServerNode)
        {
          this.rBs1yJ9gPQ.Columns.Add((ColumnHeader) new StringColumn(RNaihRhYEl0wUmAftnB.aYu7exFQKN(8430), 100, HorizontalAlignment.Left));
          this.rBs1yJ9gPQ.Columns.Add((ColumnHeader) new StringColumn(RNaihRhYEl0wUmAftnB.aYu7exFQKN(8442), 100, HorizontalAlignment.Left));
          this.rBs1yJ9gPQ.Columns.Add((ColumnHeader) new IntegerColumn(RNaihRhYEl0wUmAftnB.aYu7exFQKN(8468), 100, HorizontalAlignment.Right));
          this.rBs1yJ9gPQ.Columns.Add((ColumnHeader) new LongColumn(RNaihRhYEl0wUmAftnB.aYu7exFQKN(8496), 120, HorizontalAlignment.Right));
          this.rBs1yJ9gPQ.Columns.Add((ColumnHeader) new LongColumn(RNaihRhYEl0wUmAftnB.aYu7exFQKN(8544), 120, HorizontalAlignment.Right));
          this.rBs1yJ9gPQ.Columns.Add((ColumnHeader) new LongColumn(RNaihRhYEl0wUmAftnB.aYu7exFQKN(8596), 120, HorizontalAlignment.Right));
          this.rBs1yJ9gPQ.Items.Add((ListViewItem) new FileViewItem(this.kvT1dEnNxu, 2));
          this.rBs1yJ9gPQ.ContextMenu = this.JEE1Cav0de;
        }
        if (obj0 is FileNode)
        {
          string text = this.YbM1gChNq9.Panels[0].Text;
          Cursor cursor = this.Cursor;
          DataFile file = ((FileNode) obj0).File;
          this.YbM1gChNq9.Panels[0].Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(8646) + file.Name + RNaihRhYEl0wUmAftnB.aYu7exFQKN(8716);
          this.Cursor = Cursors.WaitCursor;
          this.rBs1yJ9gPQ.Columns.Add((ColumnHeader) new StringColumn(RNaihRhYEl0wUmAftnB.aYu7exFQKN(8722), 150, HorizontalAlignment.Left));
          this.rBs1yJ9gPQ.Columns.Add((ColumnHeader) new IntegerColumn(RNaihRhYEl0wUmAftnB.aYu7exFQKN(8734), 80, HorizontalAlignment.Right));
          this.rBs1yJ9gPQ.Columns.Add((ColumnHeader) new DateTimeColumn(RNaihRhYEl0wUmAftnB.aYu7exFQKN(8762), 150, HorizontalAlignment.Right));
          this.rBs1yJ9gPQ.Columns.Add((ColumnHeader) new DateTimeColumn(RNaihRhYEl0wUmAftnB.aYu7exFQKN(8794), 150, HorizontalAlignment.Right));
          this.rBs1yJ9gPQ.Columns.Add((ColumnHeader) new StringColumn(RNaihRhYEl0wUmAftnB.aYu7exFQKN(8824), 60, HorizontalAlignment.Right));
          this.rBs1yJ9gPQ.Columns.Add((ColumnHeader) new StringColumn(RNaihRhYEl0wUmAftnB.aYu7exFQKN(8842), 60, HorizontalAlignment.Right));
          foreach (FileSeries series in file.Series)
            this.rBs1yJ9gPQ.Items.Add((ListViewItem) new SeriesViewItem(series, 3));
          this.rBs1yJ9gPQ.ContextMenu = this.DG01GlEeGw;
          this.YbM1gChNq9.Panels[0].Text = text;
          this.Cursor = cursor;
        }
        this.rBs1yJ9gPQ.EndUpdate();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void eTxDWs2r6g([In] object obj0, [In] EventArgs obj1)
    {
      this.NrYDLZdsHS(View.LargeIcon);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DVQDTTVlRe([In] object obj0, [In] EventArgs obj1)
    {
      this.NrYDLZdsHS(View.SmallIcon);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WQ4Dftdx7W([In] object obj0, [In] EventArgs obj1)
    {
      this.NrYDLZdsHS(View.List);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WKPDyZtwh6([In] object obj0, [In] EventArgs obj1)
    {
      this.NrYDLZdsHS(View.Details);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TZoDONv3da([In] object obj0, [In] TreeViewEventArgs obj1)
    {
      if (!(obj1.Node is ServerNode))
        return;
      ((ServerNode) obj1.Node).UpdateIcon();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void dPEDaUNyQi([In] object obj0, [In] TreeViewEventArgs obj1)
    {
      if (!(obj1.Node is ServerNode))
        return;
      ((ServerNode) obj1.Node).UpdateIcon();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void cWtDGeKYLH([In] object obj0, [In] TreeViewEventArgs obj1)
    {
      object obj = (object) null;
      if (obj1.Node is FileNode)
        obj = (object) ((FileNode) obj1.Node).File;
      this.XopDZMPQlv(obj);
      this.zrQD3QXhBR(obj1.Node);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void XopDZMPQlv([In] object obj0)
    {
      this.hH31Lb9Ni6.SelectedObject = obj0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void kj7D42YMB2([In] object obj0, [In] EventArgs obj1)
    {
      ListView.SelectedListViewItemCollection selectedItems = this.rBs1yJ9gPQ.SelectedItems;
      this.Bse12PX3M4.Enabled = false;
      this.Mmn1X8k4Wb.Enabled = false;
      this.iuy1KZwcy3.Enabled = false;
      this.qO41mhxVay.Enabled = false;
      this.GbD10SGwgx.Enabled = false;
      this.HQ21t0kE2O.Enabled = false;
      if (selectedItems.Count != 1)
        return;
      this.Bse12PX3M4.Enabled = true;
      this.Mmn1X8k4Wb.Enabled = true;
      this.iuy1KZwcy3.Enabled = true;
      this.qO41mhxVay.Enabled = true;
      this.GbD10SGwgx.Enabled = true;
      this.HQ21t0kE2O.Enabled = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WoqDI9BSBh([In] object obj0, [In] EventArgs obj1)
    {
      ListView.SelectedListViewItemCollection selectedItems = this.rBs1yJ9gPQ.SelectedItems;
      object obj = (object) null;
      if (selectedItems.Count == 1)
      {
        if (selectedItems[0] is FileViewItem)
          obj = (object) ((FileViewItem) selectedItems[0]).File;
        if (selectedItems[0] is SeriesViewItem)
          obj = (object) ((SeriesViewItem) selectedItems[0]).Series;
      }
      this.XopDZMPQlv(obj);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OjYDSLi896([In] object obj0, [In] MouseEventArgs obj1)
    {
      if (this.rBs1yJ9gPQ.GetItemAt(obj1.X, obj1.Y) != null)
        return;
      this.XopDZMPQlv((object) null);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void mqLDUSY7C9([In] object obj0, [In] EventArgs obj1)
    {
      ListView.SelectedListViewItemCollection selectedItems = this.rBs1yJ9gPQ.SelectedItems;
      this.jIR1U4UaNJ.Enabled = false;
      this.l0r150HCGb.Enabled = false;
      this.x6E1qmBjkB.Enabled = false;
      this.a4P1oipGeo.Enabled = false;
      this.LLy1QqkG8u.Enabled = false;
      this.wBQ1rvIquS.Enabled = false;
      this.DYk1I7AaLy.Enabled = false;
      if (selectedItems.Count == 1)
      {
        this.jIR1U4UaNJ.Enabled = true;
        this.l0r150HCGb.Enabled = true;
        this.a4P1oipGeo.Enabled = true;
        this.LLy1QqkG8u.Enabled = true;
        this.x6E1qmBjkB.Enabled = true;
      }
      if (selectedItems.Count <= 0)
        return;
      this.wBQ1rvIquS.Enabled = true;
      this.DYk1I7AaLy.Enabled = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Sy0DjKdLX4([In] object obj0, [In] EventArgs obj1)
    {
      this.L9v1h8QfgX();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ecBD6LJBUu([In] object obj0, [In] EventArgs obj1)
    {
      this.L9v1h8QfgX();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void YAODrASBmm([In] object obj0, [In] EventArgs obj1)
    {
      ArrayList arrayList = new ArrayList();
      foreach (SeriesViewItem seriesViewItem in this.rBs1yJ9gPQ.SelectedItems)
        arrayList.Add((object) seriesViewItem.Series.Name);
      this.jLID8gX80W(arrayList.ToArray(typeof (string)) as string[]);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void jLID8gX80W([In] string[] obj0)
    {
      if (MessageBox.Show((IWin32Window) this, obj0.Length == 1 ? RNaihRhYEl0wUmAftnB.aYu7exFQKN(8960) + obj0[0] + RNaihRhYEl0wUmAftnB.aYu7exFQKN(9024) : RNaihRhYEl0wUmAftnB.aYu7exFQKN(8870), RNaihRhYEl0wUmAftnB.aYu7exFQKN(9030), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      foreach (string name in obj0)
        this.kvT1dEnNxu.Series.Remove(name);
      this.x3xD9PDaqW();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void isZD5rGZtt([In] object obj0, [In] EventArgs obj1)
    {
      this.Close();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DqJDqJKDFc([In] object obj0, [In] EventArgs obj1)
    {
      this.AQp11uPRcD();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void V7sDCK2bnn([In] object obj0, [In] EventArgs obj1)
    {
      this.pMcDXLNckH((this.rBs1yJ9gPQ.SelectedItems[0] as SeriesViewItem).Series);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void XRqD2Bcj5L([In] object obj0, [In] EventArgs obj1)
    {
      if (!(this.rBs1yJ9gPQ.SelectedItems[0] is SeriesViewItem))
        return;
      this.pMcDXLNckH((this.rBs1yJ9gPQ.SelectedItems[0] as SeriesViewItem).Series);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void pMcDXLNckH([In] FileSeries obj0)
    {
      if (obj0.Count > 0)
      {
        ObjectViewer objectViewer = new ObjectViewer(obj0);
        int num = (int) objectViewer.ShowDialog((IWin32Window) this);
        objectViewer.Dispose();
      }
      else
      {
        int num1 = (int) MessageBox.Show(RNaihRhYEl0wUmAftnB.aYu7exFQKN(9048));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void g3pDKHcgGF([In] object obj0, [In] EventArgs obj1)
    {
      this.cFG1sRCahC();
      this.zrQD3QXhBR(this.ehC19bHreh.Nodes[0]);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void aIjDm38adF([In] object obj0, [In] ColumnClickEventArgs obj1)
    {
      string text = this.YbM1gChNq9.Panels[0].Text;
      Cursor cursor = this.Cursor;
      this.YbM1gChNq9.Panels[0].Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(9090);
      this.Cursor = Cursors.WaitCursor;
      SortedColumnHeader column = this.rBs1yJ9gPQ.Columns[obj1.Column] as SortedColumnHeader;
      column.ChangeOrder();
      this.rBs1yJ9gPQ.ListViewItemSorter = (IComparer) new ListViewItemComparer(column);
      this.rBs1yJ9gPQ.Sort();
      this.rBs1yJ9gPQ.ListViewItemSorter = (IComparer) null;
      this.YbM1gChNq9.Panels[0].Text = text;
      this.Cursor = cursor;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void XLsDwOQqnh([In] object obj0, [In] EventArgs obj1)
    {
      ArrayList arrayList = new ArrayList();
      foreach (SeriesViewItem seriesViewItem in this.rBs1yJ9gPQ.SelectedItems)
        arrayList.Add((object) seriesViewItem.Series.Name);
      this.cxZD0FU9ZM(arrayList.ToArray(typeof (string)) as string[]);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void cxZD0FU9ZM([In] string[] obj0)
    {
      if (MessageBox.Show((IWin32Window) this, obj0.Length == 1 ? RNaihRhYEl0wUmAftnB.aYu7exFQKN(9202) + obj0[0] + RNaihRhYEl0wUmAftnB.aYu7exFQKN(9264) : RNaihRhYEl0wUmAftnB.aYu7exFQKN(9114), RNaihRhYEl0wUmAftnB.aYu7exFQKN(9270), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      foreach (string index in obj0)
        this.kvT1dEnNxu.Series[index].Clear();
      this.x3xD9PDaqW();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QSwDpNUQin([In] object obj0, [In] EventArgs obj1)
    {
      ReindexForm reindexForm = new ReindexForm(this.kvT1dEnNxu, (this.rBs1yJ9gPQ.SelectedItems[0] as SeriesViewItem).Series);
      int num = (int) reindexForm.ShowDialog();
      reindexForm.Dispose();
      this.x3xD9PDaqW();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CTADNjh6My([In] object obj0, [In] EventArgs obj1)
    {
      this.U8O1YJ1aQ2();
      this.zrQD3QXhBR(this.ehC19bHreh.Nodes[0]);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void pvwDt9uebI([In] object obj0, [In] EventArgs obj1)
    {
      BarMakerForm barMakerForm = new BarMakerForm(this.kvT1dEnNxu, (this.rBs1yJ9gPQ.SelectedItems[0] as SeriesViewItem).Series);
      int num = (int) barMakerForm.ShowDialog();
      barMakerForm.Dispose();
      this.x3xD9PDaqW();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SHgDEQmHW7([In] object obj0, [In] EventArgs obj1)
    {
      FileSeries series = (this.rBs1yJ9gPQ.SelectedItems[0] as SeriesViewItem).Series;
      ExportSingleSeriesForm singleSeriesForm = new ExportSingleSeriesForm();
      singleSeriesForm.SetDataSeries((IDataSeries) series);
      int num = (int) singleSeriesForm.ShowDialog((IWin32Window) this);
      singleSeriesForm.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WDXDQkgNqS([In] object obj0, [In] EventArgs obj1)
    {
      FileSeries series = (this.rBs1yJ9gPQ.SelectedItems[0] as SeriesViewItem).Series;
      RenameForm renameForm = new RenameForm();
      renameForm.SeriesName = series.Name;
      if (renameForm.ShowDialog((IWin32Window) this) == DialogResult.OK && renameForm.SeriesName != series.Name)
      {
        if (this.kvT1dEnNxu.Series.Contains(renameForm.SeriesName))
        {
          int num = (int) MessageBox.Show((IWin32Window) this, RNaihRhYEl0wUmAftnB.aYu7exFQKN(9288) + renameForm.SeriesName + RNaihRhYEl0wUmAftnB.aYu7exFQKN(9314), RNaihRhYEl0wUmAftnB.aYu7exFQKN(9350), MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
          this.kvT1dEnNxu.Series.Rename(series.Name, renameForm.SeriesName);
          this.x3xD9PDaqW();
        }
      }
      renameForm.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void wtpDvTyM5q([In] object obj0, [In] EventArgs obj1)
    {
      this.M6K1DXgKpj();
      this.zrQD3QXhBR(this.ehC19bHreh.Nodes[0]);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void pwBDoKRXZa([In] object obj0, [In] EventArgs obj1)
    {
      this.EDK1xt0lLq();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QEIDPhTHAs([In] object obj0, [In] EventArgs obj1)
    {
      this.L9v1h8QfgX();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void L0FDAsGGyl([In] object obj0, [In] EventArgs obj1)
    {
      this.cFG1sRCahC();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void JHcDBCr8KA([In] object obj0, [In] EventArgs obj1)
    {
      this.U8O1YJ1aQ2();
      this.x3xD9PDaqW();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void jxaDcD0r72([In] object obj0, [In] EventArgs obj1)
    {
      this.EDK1xt0lLq();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UVZDz0QTDu([In] object obj0, [In] EventArgs obj1)
    {
      this.M6K1DXgKpj();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Fl61euYxxy([In] object obj0, [In] EventArgs obj1)
    {
      this.AQp11uPRcD();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void L9v1h8QfgX()
    {
      NewSeriesDialog newSeriesDialog = new NewSeriesDialog(this.kvT1dEnNxu.Name);
      bool flag = true;
      while (flag)
      {
        switch (newSeriesDialog.ShowDialog((IWin32Window) this))
        {
          case DialogResult.OK:
            string seriesName = newSeriesDialog.SeriesName;
            if (this.kvT1dEnNxu.Series.Contains(seriesName))
            {
              int num = (int) MessageBox.Show((IWin32Window) this, RNaihRhYEl0wUmAftnB.aYu7exFQKN(9364), RNaihRhYEl0wUmAftnB.aYu7exFQKN(9452), MessageBoxButtons.OK, MessageBoxIcon.Hand);
              continue;
            }
            else
            {
              this.kvT1dEnNxu.Series.Add(seriesName);
              this.x3xD9PDaqW();
              flag = false;
              continue;
            }
          case DialogResult.Cancel:
            flag = false;
            continue;
          default:
            continue;
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void cFG1sRCahC()
    {
      DefragmentForm defragmentForm = new DefragmentForm(this.kvT1dEnNxu);
      int num = (int) defragmentForm.ShowDialog();
      defragmentForm.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void U8O1YJ1aQ2()
    {
      ReindexForm reindexForm = new ReindexForm(this.kvT1dEnNxu, (FileSeries) null);
      int num = (int) reindexForm.ShowDialog();
      reindexForm.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EDK1xt0lLq()
    {
      ExportSeriesForm exportSeriesForm = new ExportSeriesForm();
      exportSeriesForm.SetDataSeriesList(DataManager.Server.GetDataSeries());
      int num = (int) exportSeriesForm.ShowDialog((IWin32Window) this);
      exportSeriesForm.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void M6K1DXgKpj()
    {
      if (MessageBox.Show(RNaihRhYEl0wUmAftnB.aYu7exFQKN(9466), RNaihRhYEl0wUmAftnB.aYu7exFQKN(9576), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      string text = this.YbM1gChNq9.Panels[0].Text;
      this.YbM1gChNq9.Panels[0].Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(9604);
      foreach (FileSeries fileSeries in this.kvT1dEnNxu.Series)
        fileSeries.Flush();
      this.YbM1gChNq9.Panels[0].Text = text;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AQp11uPRcD()
    {
      RegisteredTypesForm registeredTypesForm = new RegisteredTypesForm(this.kvT1dEnNxu);
      int num = (int) registeredTypesForm.ShowDialog();
      registeredTypesForm.Dispose();
    }
  }
}
