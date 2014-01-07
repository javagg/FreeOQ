// Type: SmartQuant.Shared.Controls.SeriesViewer
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using SmartQuant;
using SmartQuant.Data;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Wt5ZNWhetVWfreAj4KS;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Controls
{
  public class SeriesViewer : UserControl
  {
    private IDataSeries ASnMxoTP6b;
    private ArrayList LOMMDbeLeH;
    private SmartQuant.Data.IDataObject X3kM1SNaDn;
    private string XymMdYIa1B;
    private ListView KlQMF7RVxb;
    private ContextMenu TdbMb4bv5E;
    private ImageMenuItem TbWMVlOeSu;
    private ImageList yaiMRbN932;
    private ImageMenuItem AG2MHgs8S0;
    private ImageMenuItem R6XMk2WNPT;
    private ImageMenuItem uVkMlKEBEN;
    private ImageMenuItem rcqMuOG1No;
    private IContainer sSnMgflqxc;

    public IDataSeries DataSeries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ASnMxoTP6b;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.ASnMxoTP6b = value;
        this.X3kM1SNaDn = (SmartQuant.Data.IDataObject) null;
        this.a26MewQeye();
      }
    }

    public string PriceDisplay
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.XymMdYIa1B;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.XymMdYIa1B = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SeriesViewer()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.dO5gPIHHpR();
      this.XymMdYIa1B = (string) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.sSnMgflqxc != null)
        this.sSnMgflqxc.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void dO5gPIHHpR()
    {
      this.sSnMgflqxc = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SeriesViewer));
      this.KlQMF7RVxb = new ListView();
      this.TdbMb4bv5E = new ContextMenu();
      this.yaiMRbN932 = new ImageList(this.sSnMgflqxc);
      this.uVkMlKEBEN = new ImageMenuItem();
      this.rcqMuOG1No = new ImageMenuItem();
      this.R6XMk2WNPT = new ImageMenuItem();
      this.AG2MHgs8S0 = new ImageMenuItem();
      this.TbWMVlOeSu = new ImageMenuItem();
      this.SuspendLayout();
      this.KlQMF7RVxb.BorderStyle = BorderStyle.None;
      this.KlQMF7RVxb.ContextMenu = this.TdbMb4bv5E;
      this.KlQMF7RVxb.Dock = DockStyle.Fill;
      this.KlQMF7RVxb.FullRowSelect = true;
      this.KlQMF7RVxb.GridLines = true;
      this.KlQMF7RVxb.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.KlQMF7RVxb.HideSelection = false;
      this.KlQMF7RVxb.Location = new Point(0, 0);
      this.KlQMF7RVxb.MultiSelect = false;
      this.KlQMF7RVxb.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31022);
      this.KlQMF7RVxb.ShowGroups = false;
      this.KlQMF7RVxb.Size = new Size(328, 235);
      this.KlQMF7RVxb.TabIndex = 1;
      this.KlQMF7RVxb.UseCompatibleStateImageBehavior = false;
      this.KlQMF7RVxb.View = View.Details;
      this.KlQMF7RVxb.VirtualMode = true;
      this.KlQMF7RVxb.DoubleClick += new EventHandler(this.mGWMsx5KNk);
      this.KlQMF7RVxb.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(this.YiXMht6Xbj);
      this.TdbMb4bv5E.MenuItems.AddRange(new MenuItem[5]
      {
        (MenuItem) this.uVkMlKEBEN,
        (MenuItem) this.rcqMuOG1No,
        (MenuItem) this.R6XMk2WNPT,
        (MenuItem) this.AG2MHgs8S0,
        (MenuItem) this.TbWMVlOeSu
      });
      this.TdbMb4bv5E.Popup += new EventHandler(this.IcqgANSyGk);
      this.yaiMRbN932.ImageStream = (ImageListStreamer) componentResourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(31042));
      this.yaiMRbN932.TransparentColor = Color.Transparent;
      this.yaiMRbN932.Images.SetKeyName(0, "");
      this.yaiMRbN932.Images.SetKeyName(1, RNaihRhYEl0wUmAftnB.aYu7exFQKN(31082));
      this.uVkMlKEBEN.ImageIndex = 1;
      this.uVkMlKEBEN.ImageList = this.yaiMRbN932;
      this.uVkMlKEBEN.Index = 0;
      this.uVkMlKEBEN.OwnerDraw = true;
      this.uVkMlKEBEN.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31120);
      this.uVkMlKEBEN.Click += new EventHandler(this.dj6gBivWDb);
      this.rcqMuOG1No.ImageList = (ImageList) null;
      this.rcqMuOG1No.Index = 1;
      this.rcqMuOG1No.OwnerDraw = true;
      this.rcqMuOG1No.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31152);
      this.R6XMk2WNPT.ImageList = (ImageList) null;
      this.R6XMk2WNPT.Index = 2;
      this.R6XMk2WNPT.OwnerDraw = true;
      this.R6XMk2WNPT.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31158);
      this.R6XMk2WNPT.Click += new EventHandler(this.CKSgcVdeNY);
      this.AG2MHgs8S0.ImageList = (ImageList) null;
      this.AG2MHgs8S0.Index = 3;
      this.AG2MHgs8S0.OwnerDraw = true;
      this.AG2MHgs8S0.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31178);
      this.TbWMVlOeSu.ImageIndex = 0;
      this.TbWMVlOeSu.ImageList = this.yaiMRbN932;
      this.TbWMVlOeSu.Index = 4;
      this.TbWMVlOeSu.OwnerDraw = true;
      this.TbWMVlOeSu.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31184);
      this.TbWMVlOeSu.Click += new EventHandler(this.zbkgzZu1Oo);
      this.Controls.Add((Control) this.KlQMF7RVxb);
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31200);
      this.Size = new Size(328, 235);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IcqgANSyGk([In] object obj0, [In] EventArgs obj1)
    {
      if (this.KlQMF7RVxb.SelectedIndices.Count == 1)
      {
        this.uVkMlKEBEN.Enabled = true;
        this.TbWMVlOeSu.Enabled = true;
      }
      else
      {
        this.uVkMlKEBEN.Enabled = false;
        this.TbWMVlOeSu.Enabled = false;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void dj6gBivWDb([In] object obj0, [In] EventArgs obj1)
    {
      this.NHGMYq0bqU();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CKSgcVdeNY([In] object obj0, [In] EventArgs obj1)
    {
      if (this.ASnMxoTP6b.Count == 0)
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, RNaihRhYEl0wUmAftnB.aYu7exFQKN(31228), "", MessageBoxButtons.OK, MessageBoxIcon.None);
      }
      else
      {
        GotoForm gotoForm = new GotoForm();
        gotoForm.cMWbyXRTvJ(this.ASnMxoTP6b.FirstDateTime, this.ASnMxoTP6b.LastDateTime, this.ASnMxoTP6b.Count);
        if (gotoForm.ShowDialog((IWin32Window) this) == DialogResult.OK)
        {
          try
          {
            this.Cursor = Cursors.WaitCursor;
            int index = -1;
            if (gotoForm.w2tbZT9kLy() is int)
              index = (int) gotoForm.w2tbZT9kLy();
            if (gotoForm.w2tbZT9kLy() is DateTime)
              index = this.ASnMxoTP6b.IndexOf((DateTime) gotoForm.w2tbZT9kLy(), SearchOption.Next);
            if (index != -1)
            {
              this.KlQMF7RVxb.EnsureVisible(index);
              this.KlQMF7RVxb.Items[index].Selected = true;
            }
            this.Cursor = Cursors.Default;
          }
          catch (Exception ex)
          {
            this.Cursor = Cursors.Default;
            if (Trace.IsLevelEnabled(TraceLevel.Error))
              Trace.WriteLine(((object) ex).ToString());
            int num2 = (int) MessageBox.Show((IWin32Window) this, RNaihRhYEl0wUmAftnB.aYu7exFQKN(31272), RNaihRhYEl0wUmAftnB.aYu7exFQKN(31414), MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
        gotoForm.Dispose();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void zbkgzZu1Oo([In] object obj0, [In] EventArgs obj1)
    {
      int index = this.KlQMF7RVxb.SelectedIndices[0];
      if (MessageBox.Show(RNaihRhYEl0wUmAftnB.aYu7exFQKN(31428), RNaihRhYEl0wUmAftnB.aYu7exFQKN(31510), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      this.ASnMxoTP6b.RemoveAt(index);
      if (index == this.ASnMxoTP6b.Count)
        this.X3kM1SNaDn = (SmartQuant.Data.IDataObject) null;
      this.KlQMF7RVxb.VirtualListSize = this.ASnMxoTP6b.Count;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void a26MewQeye()
    {
      this.KlQMF7RVxb.VirtualListSize = 0;
      this.KlQMF7RVxb.Columns.Clear();
      if (this.ASnMxoTP6b == null || this.ASnMxoTP6b.Count <= 0)
        return;
      this.KlQMF7RVxb.VirtualListSize = this.ASnMxoTP6b.Count;
      this.KlQMF7RVxb.Columns.Add(RNaihRhYEl0wUmAftnB.aYu7exFQKN(31540), 30, HorizontalAlignment.Left);
      this.KlQMF7RVxb.Columns.Add(RNaihRhYEl0wUmAftnB.aYu7exFQKN(31546), 130, HorizontalAlignment.Left);
      this.LOMMDbeLeH = new ArrayList();
      foreach (PropertyInfo propertyInfo in this.ASnMxoTP6b[0].GetType().GetProperties())
      {
        object[] customAttributes = propertyInfo.GetCustomAttributes(typeof (ViewAttribute), true);
        if (customAttributes.Length > 0)
        {
          ViewAttribute viewAttribute = customAttributes[0] as ViewAttribute;
          string name = propertyInfo.Name;
          string str = viewAttribute is PriceViewAttribute ? this.XymMdYIa1B : (string) null;
          this.KlQMF7RVxb.Columns.Add(name, 75, HorizontalAlignment.Right);
          this.LOMMDbeLeH.Add((object) new i4bbcTzQMD8sE0b5HS(str, propertyInfo));
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void YiXMht6Xbj([In] object obj0, [In] RetrieveVirtualItemEventArgs obj1)
    {
      ListViewItem listViewItem = new ListViewItem(new string[this.LOMMDbeLeH.Count + 2]);
      listViewItem.SubItems[0].Text = obj1.ItemIndex.ToString();
      try
      {
        SmartQuant.Data.IDataObject dataObject;
        if (obj1.ItemIndex == this.KlQMF7RVxb.VirtualListSize - 1)
        {
          if (this.X3kM1SNaDn == null)
            this.X3kM1SNaDn = this.ASnMxoTP6b[obj1.ItemIndex] as SmartQuant.Data.IDataObject;
          dataObject = this.X3kM1SNaDn;
        }
        else
          dataObject = this.ASnMxoTP6b[obj1.ItemIndex] as SmartQuant.Data.IDataObject;
        listViewItem.SubItems[1].Text = dataObject.DateTime.ToString();
        for (int index = 0; index < this.LOMMDbeLeH.Count; ++index)
          listViewItem.SubItems[index + 2].Text = (this.LOMMDbeLeH[index] as i4bbcTzQMD8sE0b5HS).SsKnATHOMW((object) dataObject);
      }
      catch (Exception ex)
      {
        for (int index = 0; index < this.LOMMDbeLeH.Count; ++index)
          listViewItem.SubItems[index + 2].Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(31566);
      }
      obj1.Item = listViewItem;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void mGWMsx5KNk([In] object obj0, [In] EventArgs obj1)
    {
      this.NHGMYq0bqU();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void NHGMYq0bqU()
    {
      int index = this.KlQMF7RVxb.SelectedIndices[0];
      SmartQuant.Data.IDataObject dataObject = this.ASnMxoTP6b[index] as SmartQuant.Data.IDataObject;
      EditObjectForm editObjectForm = new EditObjectForm();
      editObjectForm.SetDataObject(dataObject, index);
      if (editObjectForm.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        this.ASnMxoTP6b.Update(index, (object) dataObject);
        if (index == this.ASnMxoTP6b.Count - 1)
          this.X3kM1SNaDn = (SmartQuant.Data.IDataObject) null;
        this.KlQMF7RVxb.RedrawItems(index, index, false);
      }
      editObjectForm.Dispose();
    }
  }
}
