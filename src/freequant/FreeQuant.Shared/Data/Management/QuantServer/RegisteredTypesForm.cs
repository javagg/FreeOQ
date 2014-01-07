// Type: SmartQuant.Shared.Data.Management.QuantServer.RegisteredTypesForm
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant.File;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Management.QuantServer
{
  public class RegisteredTypesForm : Form
  {
    private ListView gVoHu4ORvw;
    private IContainer C45HgqkAbh;
    private Button QQrHMdSmYx;
    private ColumnHeader kX6HJ9j5Vb;
    private ColumnHeader U4OHnO0Xe4;
    private ColumnHeader tGrH7RKFMj;
    private ContextMenu J4rHL4wP1g;
    private MenuItem Xw0HiZX7pt;
    private MenuItem Jv6H9wcoGe;
    private MenuItem CXlH3qCfgv;
    private MenuItem jLGHWfxDA1;
    private MenuItem D5aHTymUR1;
    private ImageList F6JHfovOkf;
    private ImageList kyyHyZmS0P;
    private ColumnHeader haNHO0x5w2;
    private DataFile pwWHaRsjYg;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RegisteredTypesForm(DataFile file)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.ToBHFtQWwi();
      this.pwWHaRsjYg = file;
      this.ATvHbY9WDd(View.Details);
      this.F4xHlmYhTc();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.C45HgqkAbh != null)
        this.C45HgqkAbh.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToBHFtQWwi()
    {
      this.C45HgqkAbh = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (RegisteredTypesForm));
      this.gVoHu4ORvw = new ListView();
      this.kX6HJ9j5Vb = new ColumnHeader();
      this.haNHO0x5w2 = new ColumnHeader();
      this.U4OHnO0Xe4 = new ColumnHeader();
      this.tGrH7RKFMj = new ColumnHeader();
      this.J4rHL4wP1g = new ContextMenu();
      this.Xw0HiZX7pt = new MenuItem();
      this.Jv6H9wcoGe = new MenuItem();
      this.CXlH3qCfgv = new MenuItem();
      this.D5aHTymUR1 = new MenuItem();
      this.jLGHWfxDA1 = new MenuItem();
      this.kyyHyZmS0P = new ImageList(this.C45HgqkAbh);
      this.F6JHfovOkf = new ImageList(this.C45HgqkAbh);
      this.QQrHMdSmYx = new Button();
      this.SuspendLayout();
      this.gVoHu4ORvw.Columns.AddRange(new ColumnHeader[4]
      {
        this.kX6HJ9j5Vb,
        this.haNHO0x5w2,
        this.U4OHnO0Xe4,
        this.tGrH7RKFMj
      });
      this.gVoHu4ORvw.ContextMenu = this.J4rHL4wP1g;
      this.gVoHu4ORvw.FullRowSelect = true;
      this.gVoHu4ORvw.LargeImageList = this.kyyHyZmS0P;
      this.gVoHu4ORvw.Location = new Point(16, 12);
      this.gVoHu4ORvw.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18736);
      this.gVoHu4ORvw.Size = new Size(496, 228);
      this.gVoHu4ORvw.SmallImageList = this.F6JHfovOkf;
      this.gVoHu4ORvw.TabIndex = 0;
      this.gVoHu4ORvw.UseCompatibleStateImageBehavior = false;
      this.kX6HJ9j5Vb.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18756);
      this.kX6HJ9j5Vb.Width = 150;
      this.haNHO0x5w2.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18778);
      this.haNHO0x5w2.TextAlign = HorizontalAlignment.Right;
      this.U4OHnO0Xe4.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18796);
      this.U4OHnO0Xe4.TextAlign = HorizontalAlignment.Right;
      this.U4OHnO0Xe4.Width = 150;
      this.tGrH7RKFMj.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18826);
      this.tGrH7RKFMj.TextAlign = HorizontalAlignment.Right;
      this.J4rHL4wP1g.MenuItems.AddRange(new MenuItem[1]
      {
        this.Xw0HiZX7pt
      });
      this.Xw0HiZX7pt.Index = 0;
      this.Xw0HiZX7pt.MenuItems.AddRange(new MenuItem[4]
      {
        this.Jv6H9wcoGe,
        this.CXlH3qCfgv,
        this.D5aHTymUR1,
        this.jLGHWfxDA1
      });
      this.Xw0HiZX7pt.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18844);
      this.Jv6H9wcoGe.Index = 0;
      this.Jv6H9wcoGe.RadioCheck = true;
      this.Jv6H9wcoGe.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18856);
      this.Jv6H9wcoGe.Click += new EventHandler(this.zZwHVX7R9I);
      this.CXlH3qCfgv.Index = 1;
      this.CXlH3qCfgv.RadioCheck = true;
      this.CXlH3qCfgv.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18882);
      this.CXlH3qCfgv.Click += new EventHandler(this.LU6HRCePXP);
      this.D5aHTymUR1.Index = 2;
      this.D5aHTymUR1.RadioCheck = true;
      this.D5aHTymUR1.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18908);
      this.D5aHTymUR1.Click += new EventHandler(this.iJuHHOrtEo);
      this.jLGHWfxDA1.Index = 3;
      this.jLGHWfxDA1.RadioCheck = true;
      this.jLGHWfxDA1.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(18920);
      this.jLGHWfxDA1.Click += new EventHandler(this.SvqHk0E13J);
      this.kyyHyZmS0P.ImageStream = (ImageListStreamer) componentResourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(18938));
      this.kyyHyZmS0P.TransparentColor = Color.Transparent;
      this.kyyHyZmS0P.Images.SetKeyName(0, "");
      this.F6JHfovOkf.ImageStream = (ImageListStreamer) componentResourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(18986));
      this.F6JHfovOkf.TransparentColor = Color.Transparent;
      this.F6JHfovOkf.Images.SetKeyName(0, "");
      this.QQrHMdSmYx.DialogResult = DialogResult.Cancel;
      this.QQrHMdSmYx.Location = new Point(424, 248);
      this.QQrHMdSmYx.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(19034);
      this.QQrHMdSmYx.Size = new Size(88, 24);
      this.QQrHMdSmYx.TabIndex = 3;
      this.QQrHMdSmYx.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(19054);
      this.AcceptButton = (IButtonControl) this.QQrHMdSmYx;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.QQrHMdSmYx;
      this.ClientSize = new Size(530, 279);
      this.Controls.Add((Control) this.QQrHMdSmYx);
      this.Controls.Add((Control) this.gVoHu4ORvw);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(19068);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(19110);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ATvHbY9WDd([In] View obj0)
    {
      this.Jv6H9wcoGe.Checked = obj0 == View.LargeIcon;
      this.CXlH3qCfgv.Checked = obj0 == View.SmallIcon;
      this.D5aHTymUR1.Checked = obj0 == View.List;
      this.jLGHWfxDA1.Checked = obj0 == View.Details;
      this.gVoHu4ORvw.View = obj0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void zZwHVX7R9I([In] object obj0, [In] EventArgs obj1)
    {
      this.ATvHbY9WDd(View.LargeIcon);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LU6HRCePXP([In] object obj0, [In] EventArgs obj1)
    {
      this.ATvHbY9WDd(View.SmallIcon);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void iJuHHOrtEo([In] object obj0, [In] EventArgs obj1)
    {
      this.ATvHbY9WDd(View.List);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SvqHk0E13J([In] object obj0, [In] EventArgs obj1)
    {
      this.ATvHbY9WDd(View.Details);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void F4xHlmYhTc()
    {
      this.gVoHu4ORvw.Items.Clear();
      foreach (KeyValuePair<System.Type, byte> keyValuePair in (IEnumerable<KeyValuePair<System.Type, byte>>) this.pwWHaRsjYg.RegisteredTypes)
      {
        AssemblyName name = keyValuePair.Key.Assembly.GetName();
        this.gVoHu4ORvw.Items.Add(new ListViewItem(keyValuePair.Key.FullName, 0)
        {
          SubItems = {
            keyValuePair.Value.ToString(),
            name.Name,
            name.Version.ToString(4)
          }
        });
      }
    }
  }
}
