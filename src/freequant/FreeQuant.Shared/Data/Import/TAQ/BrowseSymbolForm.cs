using FreeQuant.FIX;
using FreeQuant.Instruments;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FreeQuant.Shared.Data.Import.TAQ
{
  public class BrowseSymbolForm : Form
  {
    private bool CkJFs7d208;
    private Panel vKDFYFKuHf;
    private TreeView ahMFxJ76rT;
    private ToolBar Oc5FD4p28H;
    private ImageList t0iF19I8Hd;
    private ToolBarButton IJOFd6RnLu;
    private Button gsqFFG1Lcv;
    private Button lfSFbYSERu;
    private IContainer WoaFVAAmo2;

    public string[] SelectedSymbols
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        ArrayList arrayList = new ArrayList();
        this.hjdFe35Eu0(this.ahMFxJ76rT.Nodes[0], arrayList);
        return arrayList.ToArray(typeof (string)) as string[];
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.CkJFs7d208 = false;
        this.QqXFhomtYZ(this.ahMFxJ76rT.Nodes[0], value);
        this.CkJFs7d208 = true;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BrowseSymbolForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Ox0doCWYyR();
      this.YO6dBPHlEl();
      this.CkJFs7d208 = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.WoaFVAAmo2 != null)
        this.WoaFVAAmo2.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Ox0doCWYyR()
    {
      this.WoaFVAAmo2 = (IContainer) new Container();
      ResourceManager resourceManager = new ResourceManager(typeof (BrowseSymbolForm));
      this.Oc5FD4p28H = new ToolBar();
      this.IJOFd6RnLu = new ToolBarButton();
      this.t0iF19I8Hd = new ImageList(this.WoaFVAAmo2);
      this.vKDFYFKuHf = new Panel();
      this.gsqFFG1Lcv = new Button();
      this.lfSFbYSERu = new Button();
      this.ahMFxJ76rT = new TreeView();
      this.vKDFYFKuHf.SuspendLayout();
      this.SuspendLayout();
      this.Oc5FD4p28H.Appearance = ToolBarAppearance.Flat;
      this.Oc5FD4p28H.Buttons.AddRange(new ToolBarButton[1]
      {
        this.IJOFd6RnLu
      });
      this.Oc5FD4p28H.DropDownArrows = true;
      this.Oc5FD4p28H.ImageList = this.t0iF19I8Hd;
      this.Oc5FD4p28H.Location = new Point(0, 0);
      this.Oc5FD4p28H.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11364);
      this.Oc5FD4p28H.ShowToolTips = true;
      this.Oc5FD4p28H.Size = new Size(218, 28);
      this.Oc5FD4p28H.TabIndex = 0;
      this.Oc5FD4p28H.ButtonClick += new ToolBarButtonClickEventHandler(this.s5YdPh21RX);
      this.IJOFd6RnLu.ImageIndex = 0;
      this.IJOFd6RnLu.Pushed = true;
      this.IJOFd6RnLu.Style = ToolBarButtonStyle.ToggleButton;
      this.IJOFd6RnLu.ToolTipText = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11382);
      this.t0iF19I8Hd.ImageSize = new Size(16, 16);
      this.t0iF19I8Hd.ImageStream = (ImageListStreamer) resourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(11454));
      this.t0iF19I8Hd.TransparentColor = Color.Transparent;
      this.vKDFYFKuHf.Controls.Add((Control) this.gsqFFG1Lcv);
      this.vKDFYFKuHf.Controls.Add((Control) this.lfSFbYSERu);
      this.vKDFYFKuHf.Dock = DockStyle.Bottom;
      this.vKDFYFKuHf.Location = new Point(0, 375);
      this.vKDFYFKuHf.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11494);
      this.vKDFYFKuHf.Size = new Size(218, 40);
      this.vKDFYFKuHf.TabIndex = 1;
      this.gsqFFG1Lcv.DialogResult = DialogResult.Cancel;
      this.gsqFFG1Lcv.Location = new Point(112, 8);
      this.gsqFFG1Lcv.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11510);
      this.gsqFFG1Lcv.Size = new Size(64, 24);
      this.gsqFFG1Lcv.TabIndex = 1;
      this.gsqFFG1Lcv.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11532);
      this.lfSFbYSERu.DialogResult = DialogResult.OK;
      this.lfSFbYSERu.Location = new Point(40, 8);
      this.lfSFbYSERu.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11548);
      this.lfSFbYSERu.Size = new Size(64, 24);
      this.lfSFbYSERu.TabIndex = 0;
      this.lfSFbYSERu.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11562);
      this.ahMFxJ76rT.BorderStyle = BorderStyle.None;
      this.ahMFxJ76rT.CheckBoxes = true;
      this.ahMFxJ76rT.Dock = DockStyle.Fill;
      this.ahMFxJ76rT.ImageList = this.t0iF19I8Hd;
      this.ahMFxJ76rT.Location = new Point(0, 28);
      this.ahMFxJ76rT.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11570);
      this.ahMFxJ76rT.Size = new Size(218, 347);
      this.ahMFxJ76rT.Sorted = true;
      this.ahMFxJ76rT.TabIndex = 2;
      this.ahMFxJ76rT.AfterCheck += new TreeViewEventHandler(this.myNdAbjELk);
      this.AcceptButton = (IButtonControl) this.lfSFbYSERu;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.gsqFFG1Lcv;
      this.ClientSize = new Size(218, 415);
      this.Controls.Add((Control) this.ahMFxJ76rT);
      this.Controls.Add((Control) this.vKDFYFKuHf);
      this.Controls.Add((Control) this.Oc5FD4p28H);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) resourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(11602));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11626);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(11662);
      this.vKDFYFKuHf.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void s5YdPh21RX([In] object obj0, [In] ToolBarButtonClickEventArgs obj1)
    {
      if (obj1.Button != this.IJOFd6RnLu)
        throw new ArgumentException(RNaihRhYEl0wUmAftnB.aYu7exFQKN(11694));
      this.YO6dBPHlEl();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void myNdAbjELk([In] object obj0, [In] TreeViewEventArgs obj1)
    {
      if (!this.CkJFs7d208)
        return;
      this.CkJFs7d208 = false;
      this.Y6hdz9v02O(obj1.Node, obj1.Node.Checked);
      this.CkJFs7d208 = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void YO6dBPHlEl()
    {
      string[] strArray = this.ahMFxJ76rT.Nodes.Count == 0 ? (string[]) null : this.SelectedSymbols;
      this.Cursor = Cursors.WaitCursor;
      this.ahMFxJ76rT.BeginUpdate();
      this.ahMFxJ76rT.Nodes.Clear();
      this.ahMFxJ76rT.Nodes.Add(new TreeNode(RNaihRhYEl0wUmAftnB.aYu7exFQKN(11760), 0, 0));
      foreach (Instrument instrument in (FIXGroupList) InstrumentManager.Instruments)
        this.KaVdceSrdb(instrument);
      this.ahMFxJ76rT.Nodes[0].Expand();
      if (strArray != null)
        this.SelectedSymbols = strArray;
      this.ahMFxJ76rT.EndUpdate();
      this.Cursor = Cursors.Default;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void KaVdceSrdb([In] Instrument obj0)
    {
      if (this.IJOFd6RnLu.Pushed)
      {
        SecurityTypeNode securityTypeNode1 = (SecurityTypeNode) null;
        foreach (SecurityTypeNode securityTypeNode2 in this.ahMFxJ76rT.Nodes[0].Nodes)
        {
          if (securityTypeNode2.SecurityType == obj0.SecurityType)
          {
            securityTypeNode1 = securityTypeNode2;
            break;
          }
        }
        if (securityTypeNode1 == null)
        {
          securityTypeNode1 = new SecurityTypeNode(obj0.SecurityType);
          this.ahMFxJ76rT.Nodes[0].Nodes.Add((TreeNode) securityTypeNode1);
        }
        securityTypeNode1.Nodes.Add((TreeNode) new InstrumentNode(obj0));
      }
      else
        this.ahMFxJ76rT.Nodes[0].Nodes.Add((TreeNode) new InstrumentNode(obj0));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Y6hdz9v02O([In] TreeNode obj0, [In] bool obj1)
    {
      foreach (TreeNode treeNode in obj0.Nodes)
      {
        treeNode.Checked = obj1;
        if (treeNode.GetNodeCount(false) > 0)
          this.Y6hdz9v02O(treeNode, obj1);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void hjdFe35Eu0([In] TreeNode obj0, [In] ArrayList obj1)
    {
      InstrumentNode instrumentNode = obj0 as InstrumentNode;
      if (instrumentNode == null)
      {
        foreach (TreeNode treeNode in obj0.Nodes)
          this.hjdFe35Eu0(treeNode, obj1);
      }
      else
      {
        if (!instrumentNode.Checked)
          return;
        obj1.Add((object) instrumentNode.Instrument.Symbol);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QqXFhomtYZ([In] TreeNode obj0, [In] string[] obj1)
    {
      InstrumentNode instrumentNode = obj0 as InstrumentNode;
      if (instrumentNode == null)
      {
        foreach (TreeNode treeNode in obj0.Nodes)
          this.QqXFhomtYZ(treeNode, obj1);
      }
      else
      {
        foreach (string str in obj1)
        {
          if (instrumentNode.Instrument.Symbol == str)
          {
            instrumentNode.Checked = true;
            break;
          }
        }
      }
    }
  }
}
