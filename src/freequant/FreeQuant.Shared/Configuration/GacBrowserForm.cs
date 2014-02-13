// Type: SmartQuant.Shared.Configuration.GacBrowserForm
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using FreeQuant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace FreeQuant.Shared.Configuration
{
  public class GacBrowserForm : Form
  {
    private Panel KF1lSrmQWn;
    private ListView AuClUN8Sui;
    private ColumnHeader oKZljKC8Vt;
    private ColumnHeader PqKl6Z57m0;
    private Button xqKlr32eny;
    private Button RbCl8VSBXY;
    private ColumnHeader QsOl5VNVCS;
    private Container lqFlqZcgC3;

    public AssemblyName[] SelectedAssemblies
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        List<AssemblyName> list = new List<AssemblyName>();
        foreach (GacViewItem gacViewItem in this.AuClUN8Sui.SelectedItems)
          list.Add(gacViewItem.AssemblyName);
        return list.ToArray();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GacBrowserForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.p8Rl4MTJr9();
      this.AuClUN8Sui.BeginUpdate();
      this.AuClUN8Sui.Items.Clear();
      foreach (AssemblyName assemblyName in GAC.Assemblies)
        this.AuClUN8Sui.Items.Add((ListViewItem) new GacViewItem(assemblyName));
      this.AuClUN8Sui.EndUpdate();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.lqFlqZcgC3 != null)
        this.lqFlqZcgC3.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void p8Rl4MTJr9()
    {
      this.KF1lSrmQWn = new Panel();
      this.RbCl8VSBXY = new Button();
      this.xqKlr32eny = new Button();
      this.AuClUN8Sui = new ListView();
      this.oKZljKC8Vt = new ColumnHeader();
      this.PqKl6Z57m0 = new ColumnHeader();
      this.QsOl5VNVCS = new ColumnHeader();
      this.KF1lSrmQWn.SuspendLayout();
      this.SuspendLayout();
      this.KF1lSrmQWn.Controls.Add((Control) this.RbCl8VSBXY);
      this.KF1lSrmQWn.Controls.Add((Control) this.xqKlr32eny);
      this.KF1lSrmQWn.Dock = DockStyle.Bottom;
      this.KF1lSrmQWn.Location = new Point(0, 287);
      this.KF1lSrmQWn.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21804);
      this.KF1lSrmQWn.Size = new Size(453, 40);
      this.KF1lSrmQWn.TabIndex = 0;
      this.RbCl8VSBXY.DialogResult = DialogResult.Cancel;
      this.RbCl8VSBXY.Location = new Point(224, 8);
      this.RbCl8VSBXY.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21820);
      this.RbCl8VSBXY.Size = new Size(72, 24);
      this.RbCl8VSBXY.TabIndex = 1;
      this.RbCl8VSBXY.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21842);
      this.xqKlr32eny.DialogResult = DialogResult.OK;
      this.xqKlr32eny.Location = new Point(143, 8);
      this.xqKlr32eny.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21858);
      this.xqKlr32eny.Size = new Size(72, 24);
      this.xqKlr32eny.TabIndex = 0;
      this.xqKlr32eny.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21872);
      this.AuClUN8Sui.BorderStyle = BorderStyle.None;
      this.AuClUN8Sui.Columns.AddRange(new ColumnHeader[3]
      {
        this.oKZljKC8Vt,
        this.PqKl6Z57m0,
        this.QsOl5VNVCS
      });
      this.AuClUN8Sui.Dock = DockStyle.Fill;
      this.AuClUN8Sui.FullRowSelect = true;
      this.AuClUN8Sui.GridLines = true;
      this.AuClUN8Sui.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.AuClUN8Sui.HideSelection = false;
      this.AuClUN8Sui.Location = new Point(0, 0);
      this.AuClUN8Sui.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21880);
      this.AuClUN8Sui.ShowGroups = false;
      this.AuClUN8Sui.ShowItemToolTips = true;
      this.AuClUN8Sui.Size = new Size(453, 287);
      this.AuClUN8Sui.Sorting = SortOrder.Ascending;
      this.AuClUN8Sui.TabIndex = 1;
      this.AuClUN8Sui.UseCompatibleStateImageBehavior = false;
      this.AuClUN8Sui.View = View.Details;
      this.AuClUN8Sui.DoubleClick += new EventHandler(this.S9KlI5dcDj);
      this.oKZljKC8Vt.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21896);
      this.oKZljKC8Vt.Width = 184;
      this.PqKl6Z57m0.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21908);
      this.PqKl6Z57m0.Width = 109;
      this.QsOl5VNVCS.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21926);
      this.QsOl5VNVCS.TextAlign = HorizontalAlignment.Right;
      this.QsOl5VNVCS.Width = 130;
      this.AcceptButton = (IButtonControl) this.xqKlr32eny;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.RbCl8VSBXY;
      this.ClientSize = new Size(453, 327);
      this.Controls.Add((Control) this.AuClUN8Sui);
      this.Controls.Add((Control) this.KF1lSrmQWn);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(21972);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(22004);
      this.KF1lSrmQWn.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void S9KlI5dcDj([In] object obj0, [In] EventArgs obj1)
    {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }
}
