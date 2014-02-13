// Type: SmartQuant.Shared.Configuration.ConfigurationForm
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using ArPUwUnRnxWWJvuVIU;
using SmartQuant;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace FreeQuant.Shared.Configuration
{
  public class ConfigurationForm : Form
  {
    private Configuration yX4VEMYZg2;
    private bool NO5VQsv49U;
    private Panel fyZVvFZgLl;
    private TabControl YaXVo7UUvf;
    private TabPage GK1VP5IrF0;
    private Panel zrmVA0X9wI;
    private ColumnHeader sWNVBRbr8M;
    private ColumnHeader kELVcmbY54;
    private ColumnHeader kFxVzI1LW5;
    private ListView WqlRe8iANb;
    private ListView ce5RhR1djy;
    private ColumnHeader lZQRs807ss;
    private ColumnHeader kHqRYc8uyn;
    private ColumnHeader maXRxZg3t4;
    private ColumnHeader fiBRDm686k;
    private ColumnHeader x8JR13bc1G;
    private ColumnHeader hvaRdomkGn;
    private ListView zIORFMEZ4b;
    private ImageList oQvRbRE65j;
    private TabControl NUpRVVGJDA;
    private Button IRRRRIEFmO;
    private Button MloRHdunKk;
    private TabPage AHCRk0Is1s;
    private TabPage pC4RlZS8U7;
    private TabPage lUpRunofVh;
    private Panel Vp5Rg8PfEI;
    private Button WCHRMmcVdR;
    private TabPage AFgRJnuvcM;
    private ColumnHeader hVQRnOf5aZ;
    private ColumnHeader XU4R7ChI4K;
    private ListView xyNRLeQtYj;
    private TabPage vU3RiAQdAA;
    private GroupBox yMgR9PKqNn;
    private PropertyGrid xyKR3EoNCR;
    private GroupBox ivMRW5QsQQ;
    private PropertyGrid VNvRTbRacf;
    private GroupBox JMORf2crKN;
    private Panel YjiRyRVgkQ;
    private Button LW2ROwLjai;
    private Button objRaYwuJB;
    private Splitter a6YRGGKO3C;
    private PropertyGrid YKMRZiZx4j;
    private ColumnHeader z8NR44Tji7;
    private IContainer x41RIDokIQ;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ConfigurationForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.JKXV3aLwJM();
      this.yX4VEMYZg2 = Framework.Configuration;
      this.xyKR3EoNCR.SelectedObject = (object) Framework.Installation;
      this.VNvRTbRacf.SelectedObject = (object) Framework.Configuration;
      this.YKMRZiZx4j.SelectedObject = (object) new HmDaRnJpjsxWFcPgrt();
      foreach (Reference reference in (ReadOnlyCollectionBase) this.yX4VEMYZg2.References)
        this.twFVrby9l0(reference);
      foreach (Plugin plugin in (ReadOnlyCollectionBase) this.yX4VEMYZg2.Plugins)
        this.zggVqt1coG(plugin);
      this.yX4VEMYZg2.ReferenceAdded += new ReferenceEventHandler(this.NLSVXtyAfn);
      this.yX4VEMYZg2.ReferenceRemoved += new ReferenceEventHandler(this.oBBVKrJEAC);
      this.yX4VEMYZg2.ReferenceEnabledChanged += new ReferenceEventHandler(this.YoTVmRp19X);
      this.yX4VEMYZg2.PluginAdded += new PluginEventHandler(this.c15VwwamEb);
      this.yX4VEMYZg2.PluginRemoved += new PluginEventHandler(this.rySV06yZ7L);
      this.yX4VEMYZg2.PluginEnabledChanged += new PluginEventHandler(this.wCZVpCvvsY);
      this.Text = string.Format(RNaihRhYEl0wUmAftnB.aYu7exFQKN(15218), (object) Framework.Installation.MainProduct);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnClosing(CancelEventArgs e)
    {
      this.yX4VEMYZg2.ReferenceAdded -= new ReferenceEventHandler(this.NLSVXtyAfn);
      this.yX4VEMYZg2.ReferenceRemoved -= new ReferenceEventHandler(this.oBBVKrJEAC);
      this.yX4VEMYZg2.ReferenceEnabledChanged -= new ReferenceEventHandler(this.YoTVmRp19X);
      this.yX4VEMYZg2.PluginAdded -= new PluginEventHandler(this.c15VwwamEb);
      this.yX4VEMYZg2.PluginRemoved -= new PluginEventHandler(this.rySV06yZ7L);
      this.yX4VEMYZg2.PluginEnabledChanged -= new PluginEventHandler(this.wCZVpCvvsY);
      base.OnClosing(e);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.x41RIDokIQ != null)
        this.x41RIDokIQ.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void JKXV3aLwJM()
    {
      this.x41RIDokIQ = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ConfigurationForm));
      this.fyZVvFZgLl = new Panel();
      this.Vp5Rg8PfEI = new Panel();
      this.WCHRMmcVdR = new Button();
      this.YaXVo7UUvf = new TabControl();
      this.vU3RiAQdAA = new TabPage();
      this.JMORf2crKN = new GroupBox();
      this.YKMRZiZx4j = new PropertyGrid();
      this.a6YRGGKO3C = new Splitter();
      this.ivMRW5QsQQ = new GroupBox();
      this.VNvRTbRacf = new PropertyGrid();
      this.yMgR9PKqNn = new GroupBox();
      this.xyKR3EoNCR = new PropertyGrid();
      this.GK1VP5IrF0 = new TabPage();
      this.NUpRVVGJDA = new TabControl();
      this.AHCRk0Is1s = new TabPage();
      this.WqlRe8iANb = new ListView();
      this.sWNVBRbr8M = new ColumnHeader();
      this.kELVcmbY54 = new ColumnHeader();
      this.kFxVzI1LW5 = new ColumnHeader();
      this.oQvRbRE65j = new ImageList(this.x41RIDokIQ);
      this.pC4RlZS8U7 = new TabPage();
      this.ce5RhR1djy = new ListView();
      this.lZQRs807ss = new ColumnHeader();
      this.kHqRYc8uyn = new ColumnHeader();
      this.maXRxZg3t4 = new ColumnHeader();
      this.lUpRunofVh = new TabPage();
      this.zIORFMEZ4b = new ListView();
      this.fiBRDm686k = new ColumnHeader();
      this.x8JR13bc1G = new ColumnHeader();
      this.hvaRdomkGn = new ColumnHeader();
      this.zrmVA0X9wI = new Panel();
      this.IRRRRIEFmO = new Button();
      this.MloRHdunKk = new Button();
      this.AFgRJnuvcM = new TabPage();
      this.xyNRLeQtYj = new ListView();
      this.hVQRnOf5aZ = new ColumnHeader();
      this.XU4R7ChI4K = new ColumnHeader();
      this.YjiRyRVgkQ = new Panel();
      this.objRaYwuJB = new Button();
      this.LW2ROwLjai = new Button();
      this.z8NR44Tji7 = new ColumnHeader();
      this.fyZVvFZgLl.SuspendLayout();
      this.Vp5Rg8PfEI.SuspendLayout();
      this.YaXVo7UUvf.SuspendLayout();
      this.vU3RiAQdAA.SuspendLayout();
      this.JMORf2crKN.SuspendLayout();
      this.ivMRW5QsQQ.SuspendLayout();
      this.yMgR9PKqNn.SuspendLayout();
      this.GK1VP5IrF0.SuspendLayout();
      this.NUpRVVGJDA.SuspendLayout();
      this.AHCRk0Is1s.SuspendLayout();
      this.pC4RlZS8U7.SuspendLayout();
      this.lUpRunofVh.SuspendLayout();
      this.zrmVA0X9wI.SuspendLayout();
      this.AFgRJnuvcM.SuspendLayout();
      this.YjiRyRVgkQ.SuspendLayout();
      this.SuspendLayout();
      this.fyZVvFZgLl.Controls.Add((Control) this.Vp5Rg8PfEI);
      this.fyZVvFZgLl.Dock = DockStyle.Bottom;
      this.fyZVvFZgLl.Location = new Point(0, 421);
      this.fyZVvFZgLl.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15260);
      this.fyZVvFZgLl.Size = new Size(690, 40);
      this.fyZVvFZgLl.TabIndex = 0;
      this.Vp5Rg8PfEI.Controls.Add((Control) this.WCHRMmcVdR);
      this.Vp5Rg8PfEI.Dock = DockStyle.Right;
      this.Vp5Rg8PfEI.Location = new Point(434, 0);
      this.Vp5Rg8PfEI.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15276);
      this.Vp5Rg8PfEI.Size = new Size(256, 40);
      this.Vp5Rg8PfEI.TabIndex = 0;
      this.WCHRMmcVdR.DialogResult = DialogResult.OK;
      this.WCHRMmcVdR.Location = new Point(152, 8);
      this.WCHRMmcVdR.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15292);
      this.WCHRMmcVdR.Size = new Size(80, 24);
      this.WCHRMmcVdR.TabIndex = 0;
      this.WCHRMmcVdR.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15312);
      this.WCHRMmcVdR.Click += new EventHandler(this.pJdVWmCLc1);
      this.YaXVo7UUvf.Controls.Add((Control) this.vU3RiAQdAA);
      this.YaXVo7UUvf.Controls.Add((Control) this.GK1VP5IrF0);
      this.YaXVo7UUvf.Controls.Add((Control) this.AFgRJnuvcM);
      this.YaXVo7UUvf.Dock = DockStyle.Fill;
      this.YaXVo7UUvf.Location = new Point(0, 0);
      this.YaXVo7UUvf.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15326);
      this.YaXVo7UUvf.SelectedIndex = 0;
      this.YaXVo7UUvf.Size = new Size(690, 421);
      this.YaXVo7UUvf.TabIndex = 1;
      this.YaXVo7UUvf.SelectedIndexChanged += new EventHandler(this.TphVGIwXbX);
      this.YaXVo7UUvf.Selected += new TabControlEventHandler(this.Er9Va1g0Kv);
      this.vU3RiAQdAA.BorderStyle = BorderStyle.Fixed3D;
      this.vU3RiAQdAA.Controls.Add((Control) this.JMORf2crKN);
      this.vU3RiAQdAA.Controls.Add((Control) this.a6YRGGKO3C);
      this.vU3RiAQdAA.Controls.Add((Control) this.ivMRW5QsQQ);
      this.vU3RiAQdAA.Controls.Add((Control) this.yMgR9PKqNn);
      this.vU3RiAQdAA.Location = new Point(4, 22);
      this.vU3RiAQdAA.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15350);
      this.vU3RiAQdAA.Size = new Size(682, 395);
      this.vU3RiAQdAA.TabIndex = 2;
      this.vU3RiAQdAA.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15370);
      this.JMORf2crKN.Controls.Add((Control) this.YKMRZiZx4j);
      this.JMORf2crKN.Dock = DockStyle.Fill;
      this.JMORf2crKN.Location = new Point(315, 184);
      this.JMORf2crKN.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15388);
      this.JMORf2crKN.Size = new Size(363, 207);
      this.JMORf2crKN.TabIndex = 3;
      this.JMORf2crKN.TabStop = false;
      this.JMORf2crKN.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15410);
      this.YKMRZiZx4j.Dock = DockStyle.Fill;
      this.YKMRZiZx4j.HelpVisible = false;
      this.YKMRZiZx4j.LineColor = SystemColors.ScrollBar;
      this.YKMRZiZx4j.Location = new Point(3, 16);
      this.YKMRZiZx4j.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15438);
      this.YKMRZiZx4j.Size = new Size(357, 188);
      this.YKMRZiZx4j.TabIndex = 0;
      this.YKMRZiZx4j.ToolbarVisible = false;
      this.a6YRGGKO3C.Location = new Point(312, 184);
      this.a6YRGGKO3C.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15470);
      this.a6YRGGKO3C.Size = new Size(3, 207);
      this.a6YRGGKO3C.TabIndex = 4;
      this.a6YRGGKO3C.TabStop = false;
      this.ivMRW5QsQQ.Controls.Add((Control) this.VNvRTbRacf);
      this.ivMRW5QsQQ.Dock = DockStyle.Left;
      this.ivMRW5QsQQ.Location = new Point(0, 184);
      this.ivMRW5QsQQ.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15492);
      this.ivMRW5QsQQ.Size = new Size(312, 207);
      this.ivMRW5QsQQ.TabIndex = 2;
      this.ivMRW5QsQQ.TabStop = false;
      this.ivMRW5QsQQ.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15514);
      this.VNvRTbRacf.Dock = DockStyle.Fill;
      this.VNvRTbRacf.HelpVisible = false;
      this.VNvRTbRacf.LineColor = SystemColors.ScrollBar;
      this.VNvRTbRacf.Location = new Point(3, 16);
      this.VNvRTbRacf.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15544);
      this.VNvRTbRacf.Size = new Size(306, 188);
      this.VNvRTbRacf.TabIndex = 0;
      this.VNvRTbRacf.ToolbarVisible = false;
      this.yMgR9PKqNn.Controls.Add((Control) this.xyKR3EoNCR);
      this.yMgR9PKqNn.Dock = DockStyle.Top;
      this.yMgR9PKqNn.Location = new Point(0, 0);
      this.yMgR9PKqNn.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15580);
      this.yMgR9PKqNn.Size = new Size(678, 184);
      this.yMgR9PKqNn.TabIndex = 1;
      this.yMgR9PKqNn.TabStop = false;
      this.yMgR9PKqNn.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15602);
      this.xyKR3EoNCR.Dock = DockStyle.Fill;
      this.xyKR3EoNCR.HelpVisible = false;
      this.xyKR3EoNCR.LineColor = SystemColors.ScrollBar;
      this.xyKR3EoNCR.Location = new Point(3, 16);
      this.xyKR3EoNCR.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15648);
      this.xyKR3EoNCR.Size = new Size(672, 165);
      this.xyKR3EoNCR.TabIndex = 1;
      this.xyKR3EoNCR.ToolbarVisible = false;
      this.GK1VP5IrF0.BorderStyle = BorderStyle.Fixed3D;
      this.GK1VP5IrF0.Controls.Add((Control) this.NUpRVVGJDA);
      this.GK1VP5IrF0.Controls.Add((Control) this.zrmVA0X9wI);
      this.GK1VP5IrF0.Location = new Point(4, 22);
      this.GK1VP5IrF0.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15682);
      this.GK1VP5IrF0.Size = new Size(682, 395);
      this.GK1VP5IrF0.TabIndex = 0;
      this.GK1VP5IrF0.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15702);
      this.NUpRVVGJDA.Controls.Add((Control) this.AHCRk0Is1s);
      this.NUpRVVGJDA.Controls.Add((Control) this.pC4RlZS8U7);
      this.NUpRVVGJDA.Controls.Add((Control) this.lUpRunofVh);
      this.NUpRVVGJDA.Dock = DockStyle.Fill;
      this.NUpRVVGJDA.Location = new Point(0, 0);
      this.NUpRVVGJDA.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15726);
      this.NUpRVVGJDA.SelectedIndex = 0;
      this.NUpRVVGJDA.Size = new Size(574, 391);
      this.NUpRVVGJDA.TabIndex = 1;
      this.NUpRVVGJDA.SelectedIndexChanged += new EventHandler(this.SoJV4gH317);
      this.AHCRk0Is1s.Controls.Add((Control) this.WqlRe8iANb);
      this.AHCRk0Is1s.Location = new Point(4, 22);
      this.AHCRk0Is1s.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15756);
      this.AHCRk0Is1s.Size = new Size(566, 365);
      this.AHCRk0Is1s.TabIndex = 0;
      this.AHCRk0Is1s.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15786);
      this.WqlRe8iANb.BorderStyle = BorderStyle.None;
      this.WqlRe8iANb.CheckBoxes = true;
      this.WqlRe8iANb.Columns.AddRange(new ColumnHeader[3]
      {
        this.sWNVBRbr8M,
        this.kELVcmbY54,
        this.kFxVzI1LW5
      });
      this.WqlRe8iANb.Dock = DockStyle.Fill;
      this.WqlRe8iANb.FullRowSelect = true;
      this.WqlRe8iANb.GridLines = true;
      this.WqlRe8iANb.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.WqlRe8iANb.HideSelection = false;
      this.WqlRe8iANb.Location = new Point(0, 0);
      this.WqlRe8iANb.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15830);
      this.WqlRe8iANb.ShowGroups = false;
      this.WqlRe8iANb.ShowItemToolTips = true;
      this.WqlRe8iANb.Size = new Size(566, 365);
      this.WqlRe8iANb.SmallImageList = this.oQvRbRE65j;
      this.WqlRe8iANb.Sorting = SortOrder.Ascending;
      this.WqlRe8iANb.TabIndex = 0;
      this.WqlRe8iANb.UseCompatibleStateImageBehavior = false;
      this.WqlRe8iANb.View = View.Details;
      this.WqlRe8iANb.ItemCheck += new ItemCheckEventHandler(this.qeSVTqdgEA);
      this.sWNVBRbr8M.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15860);
      this.sWNVBRbr8M.Width = 140;
      this.kELVcmbY54.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15872);
      this.kELVcmbY54.Width = 86;
      this.kFxVzI1LW5.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15890);
      this.kFxVzI1LW5.Width = 264;
      this.oQvRbRE65j.ImageStream = (ImageListStreamer) componentResourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(15902));
      this.oQvRbRE65j.TransparentColor = Color.Transparent;
      this.oQvRbRE65j.Images.SetKeyName(0, "");
      this.oQvRbRE65j.Images.SetKeyName(1, "");
      this.oQvRbRE65j.Images.SetKeyName(2, "");
      this.pC4RlZS8U7.Controls.Add((Control) this.ce5RhR1djy);
      this.pC4RlZS8U7.Location = new Point(4, 22);
      this.pC4RlZS8U7.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15940);
      this.pC4RlZS8U7.Size = new Size(540, 365);
      this.pC4RlZS8U7.TabIndex = 1;
      this.pC4RlZS8U7.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(15956);
      this.ce5RhR1djy.BorderStyle = BorderStyle.None;
      this.ce5RhR1djy.CheckBoxes = true;
      this.ce5RhR1djy.Columns.AddRange(new ColumnHeader[3]
      {
        this.lZQRs807ss,
        this.kHqRYc8uyn,
        this.maXRxZg3t4
      });
      this.ce5RhR1djy.Dock = DockStyle.Fill;
      this.ce5RhR1djy.FullRowSelect = true;
      this.ce5RhR1djy.GridLines = true;
      this.ce5RhR1djy.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ce5RhR1djy.HideSelection = false;
      this.ce5RhR1djy.Location = new Point(0, 0);
      this.ce5RhR1djy.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16002);
      this.ce5RhR1djy.ShowGroups = false;
      this.ce5RhR1djy.ShowItemToolTips = true;
      this.ce5RhR1djy.Size = new Size(540, 365);
      this.ce5RhR1djy.SmallImageList = this.oQvRbRE65j;
      this.ce5RhR1djy.Sorting = SortOrder.Ascending;
      this.ce5RhR1djy.TabIndex = 1;
      this.ce5RhR1djy.UseCompatibleStateImageBehavior = false;
      this.ce5RhR1djy.View = View.Details;
      this.ce5RhR1djy.ItemCheck += new ItemCheckEventHandler(this.sN1VfmGqIg);
      this.lZQRs807ss.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16018);
      this.lZQRs807ss.Width = 140;
      this.kHqRYc8uyn.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16030);
      this.kHqRYc8uyn.Width = 86;
      this.maXRxZg3t4.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16048);
      this.maXRxZg3t4.Width = 264;
      this.lUpRunofVh.Controls.Add((Control) this.zIORFMEZ4b);
      this.lUpRunofVh.Location = new Point(4, 22);
      this.lUpRunofVh.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16060);
      this.lUpRunofVh.Size = new Size(540, 365);
      this.lUpRunofVh.TabIndex = 2;
      this.lUpRunofVh.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16078);
      this.zIORFMEZ4b.BorderStyle = BorderStyle.None;
      this.zIORFMEZ4b.CheckBoxes = true;
      this.zIORFMEZ4b.Columns.AddRange(new ColumnHeader[3]
      {
        this.fiBRDm686k,
        this.x8JR13bc1G,
        this.hvaRdomkGn
      });
      this.zIORFMEZ4b.Dock = DockStyle.Fill;
      this.zIORFMEZ4b.FullRowSelect = true;
      this.zIORFMEZ4b.GridLines = true;
      this.zIORFMEZ4b.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.zIORFMEZ4b.HideSelection = false;
      this.zIORFMEZ4b.Location = new Point(0, 0);
      this.zIORFMEZ4b.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16106);
      this.zIORFMEZ4b.ShowGroups = false;
      this.zIORFMEZ4b.ShowItemToolTips = true;
      this.zIORFMEZ4b.Size = new Size(540, 365);
      this.zIORFMEZ4b.SmallImageList = this.oQvRbRE65j;
      this.zIORFMEZ4b.Sorting = SortOrder.Ascending;
      this.zIORFMEZ4b.TabIndex = 1;
      this.zIORFMEZ4b.UseCompatibleStateImageBehavior = false;
      this.zIORFMEZ4b.View = View.Details;
      this.zIORFMEZ4b.ItemCheck += new ItemCheckEventHandler(this.MntVycCl3T);
      this.fiBRDm686k.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16124);
      this.fiBRDm686k.Width = 140;
      this.x8JR13bc1G.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16136);
      this.x8JR13bc1G.Width = 86;
      this.hvaRdomkGn.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16154);
      this.hvaRdomkGn.Width = 264;
      this.zrmVA0X9wI.Controls.Add((Control) this.IRRRRIEFmO);
      this.zrmVA0X9wI.Controls.Add((Control) this.MloRHdunKk);
      this.zrmVA0X9wI.Dock = DockStyle.Right;
      this.zrmVA0X9wI.Location = new Point(574, 0);
      this.zrmVA0X9wI.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16166);
      this.zrmVA0X9wI.Size = new Size(104, 391);
      this.zrmVA0X9wI.TabIndex = 0;
      this.IRRRRIEFmO.Enabled = false;
      this.IRRRRIEFmO.Location = new Point(16, 64);
      this.IRRRRIEFmO.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16182);
      this.IRRRRIEFmO.Size = new Size(72, 24);
      this.IRRRRIEFmO.TabIndex = 1;
      this.IRRRRIEFmO.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16204);
      this.IRRRRIEFmO.Click += new EventHandler(this.xhnVSEkhK3);
      this.MloRHdunKk.Enabled = false;
      this.MloRHdunKk.Location = new Point(16, 24);
      this.MloRHdunKk.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16220);
      this.MloRHdunKk.Size = new Size(72, 24);
      this.MloRHdunKk.TabIndex = 0;
      this.MloRHdunKk.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16236);
      this.MloRHdunKk.Click += new EventHandler(this.Hr1VIOhiW5);
      this.AFgRJnuvcM.BorderStyle = BorderStyle.Fixed3D;
      this.AFgRJnuvcM.Controls.Add((Control) this.xyNRLeQtYj);
      this.AFgRJnuvcM.Controls.Add((Control) this.YjiRyRVgkQ);
      this.AFgRJnuvcM.Location = new Point(4, 22);
      this.AFgRJnuvcM.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16246);
      this.AFgRJnuvcM.Size = new Size(682, 395);
      this.AFgRJnuvcM.TabIndex = 1;
      this.AFgRJnuvcM.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16266);
      this.xyNRLeQtYj.BorderStyle = BorderStyle.None;
      this.xyNRLeQtYj.CheckBoxes = true;
      this.xyNRLeQtYj.Columns.AddRange(new ColumnHeader[3]
      {
        this.hVQRnOf5aZ,
        this.XU4R7ChI4K,
        this.z8NR44Tji7
      });
      this.xyNRLeQtYj.Dock = DockStyle.Fill;
      this.xyNRLeQtYj.FullRowSelect = true;
      this.xyNRLeQtYj.GridLines = true;
      this.xyNRLeQtYj.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.xyNRLeQtYj.HideSelection = false;
      this.xyNRLeQtYj.Location = new Point(0, 0);
      this.xyNRLeQtYj.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16288);
      this.xyNRLeQtYj.ShowGroups = false;
      this.xyNRLeQtYj.ShowItemToolTips = true;
      this.xyNRLeQtYj.Size = new Size(574, 391);
      this.xyNRLeQtYj.SmallImageList = this.oQvRbRE65j;
      this.xyNRLeQtYj.Sorting = SortOrder.Ascending;
      this.xyNRLeQtYj.TabIndex = 0;
      this.xyNRLeQtYj.UseCompatibleStateImageBehavior = false;
      this.xyNRLeQtYj.View = View.Details;
      this.xyNRLeQtYj.ItemCheck += new ItemCheckEventHandler(this.fZiVZGmNGW);
      this.hVQRnOf5aZ.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16312);
      this.hVQRnOf5aZ.Width = 303;
      this.XU4R7ChI4K.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16336);
      this.XU4R7ChI4K.Width = 163;
      this.YjiRyRVgkQ.Controls.Add((Control) this.objRaYwuJB);
      this.YjiRyRVgkQ.Controls.Add((Control) this.LW2ROwLjai);
      this.YjiRyRVgkQ.Dock = DockStyle.Right;
      this.YjiRyRVgkQ.Location = new Point(574, 0);
      this.YjiRyRVgkQ.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16366);
      this.YjiRyRVgkQ.Size = new Size(104, 391);
      this.YjiRyRVgkQ.TabIndex = 1;
      this.objRaYwuJB.Location = new Point(24, 48);
      this.objRaYwuJB.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16382);
      this.objRaYwuJB.Size = new Size(64, 24);
      this.objRaYwuJB.TabIndex = 1;
      this.objRaYwuJB.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16420);
      this.objRaYwuJB.Click += new EventHandler(this.WYPVtAjyC2);
      this.LW2ROwLjai.Location = new Point(24, 16);
      this.LW2ROwLjai.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16436);
      this.LW2ROwLjai.Size = new Size(64, 24);
      this.LW2ROwLjai.TabIndex = 0;
      this.LW2ROwLjai.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16468);
      this.LW2ROwLjai.Click += new EventHandler(this.UW8VNUPHkM);
      this.z8NR44Tji7.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16478);
      this.z8NR44Tji7.TextAlign = HorizontalAlignment.Right;
      this.AcceptButton = (IButtonControl) this.WCHRMmcVdR;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.WCHRMmcVdR;
      this.ClientSize = new Size(690, 461);
      this.Controls.Add((Control) this.YaXVo7UUvf);
      this.Controls.Add((Control) this.fyZVvFZgLl);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.HelpButton = true;
      this.Icon = (Icon) componentResourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(16488));
      this.MaximizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16512);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16550);
      this.fyZVvFZgLl.ResumeLayout(false);
      this.Vp5Rg8PfEI.ResumeLayout(false);
      this.YaXVo7UUvf.ResumeLayout(false);
      this.vU3RiAQdAA.ResumeLayout(false);
      this.JMORf2crKN.ResumeLayout(false);
      this.ivMRW5QsQQ.ResumeLayout(false);
      this.yMgR9PKqNn.ResumeLayout(false);
      this.GK1VP5IrF0.ResumeLayout(false);
      this.NUpRVVGJDA.ResumeLayout(false);
      this.AHCRk0Is1s.ResumeLayout(false);
      this.pC4RlZS8U7.ResumeLayout(false);
      this.lUpRunofVh.ResumeLayout(false);
      this.zrmVA0X9wI.ResumeLayout(false);
      this.AFgRJnuvcM.ResumeLayout(false);
      this.YjiRyRVgkQ.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void pJdVWmCLc1([In] object obj0, [In] EventArgs obj1)
    {
      if (this.Modal)
        return;
      this.Close();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void qeSVTqdgEA([In] object obj0, [In] ItemCheckEventArgs obj1)
    {
      this.aTEVOvGlyH(this.WqlRe8iANb.Items[obj1.Index] as ReferenceViewItem, obj1.NewValue);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void sN1VfmGqIg([In] object obj0, [In] ItemCheckEventArgs obj1)
    {
      this.aTEVOvGlyH(this.ce5RhR1djy.Items[obj1.Index] as ReferenceViewItem, obj1.NewValue);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MntVycCl3T([In] object obj0, [In] ItemCheckEventArgs obj1)
    {
      this.aTEVOvGlyH(this.zIORFMEZ4b.Items[obj1.Index] as ReferenceViewItem, obj1.NewValue);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void aTEVOvGlyH([In] ReferenceViewItem obj0, [In] CheckState obj1)
    {
      obj0.Reference.Enabled = obj1 == CheckState.Checked;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Er9Va1g0Kv([In] object obj0, [In] TabControlEventArgs obj1)
    {
      this.NO5VQsv49U = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TphVGIwXbX([In] object obj0, [In] EventArgs obj1)
    {
      this.NO5VQsv49U = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void fZiVZGmNGW([In] object obj0, [In] ItemCheckEventArgs obj1)
    {
      if (this.NO5VQsv49U)
        return;
      Plugin plugin = (this.xyNRLeQtYj.Items[obj1.Index] as PluginViewItem).Plugin;
      if (plugin.AssemblyName == RNaihRhYEl0wUmAftnB.aYu7exFQKN(16590))
      {
        if (obj1.NewValue != CheckState.Unchecked)
          return;
        obj1.NewValue = CheckState.Checked;
      }
      else
      {
        plugin.Enabled = obj1.NewValue == CheckState.Checked;
        if (!plugin.Enabled || plugin.Loaded || MessageBox.Show(RNaihRhYEl0wUmAftnB.aYu7exFQKN(16636), RNaihRhYEl0wUmAftnB.aYu7exFQKN(16718), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
        Framework.LoadPlugin(plugin);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SoJV4gH317([In] object obj0, [In] EventArgs obj1)
    {
      this.MloRHdunKk.Enabled = this.IRRRRIEFmO.Enabled = this.NUpRVVGJDA.SelectedTab != this.AHCRk0Is1s;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Hr1VIOhiW5([In] object obj0, [In] EventArgs obj1)
    {
      if (this.NUpRVVGJDA.SelectedTab == this.pC4RlZS8U7)
      {
        this.wuQVUaGaKK();
      }
      else
      {
        if (this.NUpRVVGJDA.SelectedTab != this.lUpRunofVh)
          return;
        this.AeKVjyIE5B();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void xhnVSEkhK3([In] object obj0, [In] EventArgs obj1)
    {
      if (this.NUpRVVGJDA.SelectedTab == this.pC4RlZS8U7)
      {
        this.wjEV68xRbv(this.ce5RhR1djy);
      }
      else
      {
        if (this.NUpRVVGJDA.SelectedTab != this.lUpRunofVh)
          return;
        this.wjEV68xRbv(this.zIORFMEZ4b);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void wuQVUaGaKK()
    {
      GacBrowserForm gacBrowserForm = new GacBrowserForm();
      if (gacBrowserForm.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        foreach (AssemblyName assemblyName in gacBrowserForm.SelectedAssemblies)
          this.yX4VEMYZg2.AddReference((Reference) new GacReference(assemblyName.Name, assemblyName.Version, true));
      }
      gacBrowserForm.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AeKVjyIE5B()
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.CheckFileExists = true;
      openFileDialog.Multiselect = true;
      openFileDialog.Filter = RNaihRhYEl0wUmAftnB.aYu7exFQKN(16748);
      openFileDialog.RestoreDirectory = true;
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        foreach (string fileName in openFileDialog.FileNames)
          this.yX4VEMYZg2.AddReference((Reference) new UserReference(new FileInfo(fileName), true));
      }
      openFileDialog.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void wjEV68xRbv([In] ListView obj0)
    {
      if (obj0.SelectedItems.Count <= 0 || MessageBox.Show(RNaihRhYEl0wUmAftnB.aYu7exFQKN(16808), RNaihRhYEl0wUmAftnB.aYu7exFQKN(16898), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      ArrayList arrayList = new ArrayList();
      foreach (ReferenceViewItem referenceViewItem in obj0.SelectedItems)
        arrayList.Add((object) referenceViewItem.Reference);
      foreach (Reference reference in arrayList)
        this.yX4VEMYZg2.RemoveReference(reference);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void twFVrby9l0([In] Reference obj0)
    {
      ReferenceViewItem referenceViewItem = new ReferenceViewItem(obj0);
      switch (obj0.ReferenceType)
      {
        case ReferenceType.SmartQuant:
          this.WqlRe8iANb.Items.Add((ListViewItem) referenceViewItem);
          break;
        case ReferenceType.GAC:
          this.ce5RhR1djy.Items.Add((ListViewItem) referenceViewItem);
          break;
        case ReferenceType.User:
          this.zIORFMEZ4b.Items.Add((ListViewItem) referenceViewItem);
          break;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void r8OV8Yytin([In] Reference obj0)
    {
      ListView listView = (ListView) null;
      switch (obj0.ReferenceType)
      {
        case ReferenceType.SmartQuant:
          listView = this.WqlRe8iANb;
          break;
        case ReferenceType.GAC:
          listView = this.ce5RhR1djy;
          break;
        case ReferenceType.User:
          listView = this.zIORFMEZ4b;
          break;
      }
      foreach (ReferenceViewItem referenceViewItem in listView.Items)
      {
        if (referenceViewItem.Reference == obj0)
        {
          referenceViewItem.Remove();
          break;
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HQVV5VtYEH([In] Reference obj0)
    {
      ListView listView = (ListView) null;
      switch (obj0.ReferenceType)
      {
        case ReferenceType.SmartQuant:
          listView = this.WqlRe8iANb;
          break;
        case ReferenceType.GAC:
          listView = this.ce5RhR1djy;
          break;
        case ReferenceType.User:
          listView = this.zIORFMEZ4b;
          break;
      }
      foreach (ReferenceViewItem referenceViewItem in listView.Items)
      {
        if (referenceViewItem.Reference == obj0)
        {
          referenceViewItem.UpdateIcon();
          break;
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void zggVqt1coG([In] Plugin obj0)
    {
      this.xyNRLeQtYj.Items.Add((ListViewItem) new PluginViewItem(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RhnVCwsac7([In] Plugin obj0)
    {
      foreach (PluginViewItem pluginViewItem in this.xyNRLeQtYj.Items)
      {
        if (pluginViewItem.Plugin == obj0)
        {
          pluginViewItem.Remove();
          break;
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void hHqV2bEt1d([In] Plugin obj0)
    {
      foreach (PluginViewItem pluginViewItem in this.xyNRLeQtYj.Items)
      {
        if (pluginViewItem.Plugin == obj0)
        {
          pluginViewItem.UpdateIcon();
          break;
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void NLSVXtyAfn([In] ReferenceEventArgs obj0)
    {
      this.twFVrby9l0(obj0.Reference);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void oBBVKrJEAC([In] ReferenceEventArgs obj0)
    {
      this.r8OV8Yytin(obj0.Reference);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void YoTVmRp19X([In] ReferenceEventArgs obj0)
    {
      this.HQVV5VtYEH(obj0.Reference);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void c15VwwamEb([In] PluginEventArgs obj0)
    {
      this.zggVqt1coG(obj0.Plugin);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void rySV06yZ7L([In] PluginEventArgs obj0)
    {
      this.RhnVCwsac7(obj0.Plugin);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void wCZVpCvvsY([In] PluginEventArgs obj0)
    {
      this.hHqV2bEt1d(obj0.Plugin);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UW8VNUPHkM([In] object obj0, [In] EventArgs obj1)
    {
      if (MessageBox.Show(RNaihRhYEl0wUmAftnB.aYu7exFQKN(16916) + Environment.NewLine + Framework.Installation.BinDir.FullName + Environment.NewLine + RNaihRhYEl0wUmAftnB.aYu7exFQKN(17056), RNaihRhYEl0wUmAftnB.aYu7exFQKN(17128), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
        return;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Multiselect = false;
      openFileDialog.CheckFileExists = true;
      openFileDialog.Filter = RNaihRhYEl0wUmAftnB.aYu7exFQKN(17146);
      openFileDialog.Title = RNaihRhYEl0wUmAftnB.aYu7exFQKN(17198);
      openFileDialog.InitialDirectory = Framework.Installation.BinDir.FullName;
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        try
        {
          Assembly assembly = Assembly.LoadFile(openFileDialog.FileName);
          int num1 = 0;
          foreach (System.Type type in assembly.GetTypes())
          {
            if (type.GetInterface(RNaihRhYEl0wUmAftnB.aYu7exFQKN(17264)) != (System.Type) null)
            {
              this.yX4VEMYZg2.AddPlugin(new Plugin(assembly.GetName().Name, type.FullName, false, true));
              ++num1;
            }
          }
          if (num1 == 0)
          {
            int num2 = (int) MessageBox.Show(RNaihRhYEl0wUmAftnB.aYu7exFQKN(17328) + openFileDialog.FileName, RNaihRhYEl0wUmAftnB.aYu7exFQKN(17404), MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
          else
          {
            int num3 = (int) MessageBox.Show(num1.ToString() + RNaihRhYEl0wUmAftnB.aYu7exFQKN(17418), RNaihRhYEl0wUmAftnB.aYu7exFQKN(17568), MessageBoxButtons.OK, MessageBoxIcon.None);
          }
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show(((object) ex).ToString());
        }
      }
      openFileDialog.Dispose();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WYPVtAjyC2([In] object obj0, [In] EventArgs obj1)
    {
      ArrayList arrayList = new ArrayList();
      foreach (PluginViewItem pluginViewItem in this.xyNRLeQtYj.SelectedItems)
        arrayList.Add((object) pluginViewItem.Plugin);
      if (arrayList.Count <= 0 || MessageBox.Show(RNaihRhYEl0wUmAftnB.aYu7exFQKN(17586), RNaihRhYEl0wUmAftnB.aYu7exFQKN(17674), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      foreach (Plugin plugin in arrayList)
      {
        if (plugin.AssemblyName == RNaihRhYEl0wUmAftnB.aYu7exFQKN(17692))
        {
          int num = (int) MessageBox.Show((IWin32Window) this, RNaihRhYEl0wUmAftnB.aYu7exFQKN(17738) + plugin.TypeName, "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
          this.yX4VEMYZg2.RemovePlugin(plugin);
      }
      int num1 = (int) MessageBox.Show(RNaihRhYEl0wUmAftnB.aYu7exFQKN(17804) + Environment.NewLine + RNaihRhYEl0wUmAftnB.aYu7exFQKN(17950), RNaihRhYEl0wUmAftnB.aYu7exFQKN(18056), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }
}
