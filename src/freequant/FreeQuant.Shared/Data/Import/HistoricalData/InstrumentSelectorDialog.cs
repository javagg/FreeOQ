using FreeQuant.FIX;
using FreeQuant.Instruments;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FreeQuant.Shared.Data.Import.HistoricalData
{
  public class InstrumentSelectorDialog : Form
  {
    private Dictionary<string, TreeNode> cBisXY3223;
    private Dictionary<Instrument, TreeNode> JsFsKKlfcM;
    private bool AMcsmUCK4L;
    private IContainer W2cswxNpCu;
    private Panel Ufes02OYYV;
    private Button TZ2spYLimT;
    private TreeView Mo8sNT9dXR;
    private Button dLrstGkjTP;
    private ImageList W4osEa3Hyj;

    public Instrument[] SelectedInstruments
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        List<Instrument> list = new List<Instrument>();
        foreach (KeyValuePair<Instrument, TreeNode> keyValuePair in this.JsFsKKlfcM)
        {
          if (keyValuePair.Value.Checked)
            list.Add(keyValuePair.Key);
        }
        return list.ToArray();
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        foreach (Instrument index in value)
        {
          TreeNode treeNode = this.JsFsKKlfcM[index];
          treeNode.Checked = true;
          treeNode.Parent.Expand();
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InstrumentSelectorDialog()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.lUls2UvpV2();
      this.cBisXY3223 = new Dictionary<string, TreeNode>();
      this.JsFsKKlfcM = new Dictionary<Instrument, TreeNode>();
      this.AMcsmUCK4L = false;
      this.Mo8sNT9dXR.BeginUpdate();
      foreach (Instrument key in (FIXGroupList) InstrumentManager.Instruments)
      {
        string securityType = key.SecurityType;
        TreeNode node1 = (TreeNode) null;
        if (!this.cBisXY3223.TryGetValue(securityType, out node1))
        {
          node1 = new TreeNode(securityType, 0, 0);
          this.cBisXY3223.Add(securityType, node1);
          this.Mo8sNT9dXR.Nodes.Add(node1);
        }
        TreeNode node2 = new TreeNode(key.Symbol, 2, 2);
        this.JsFsKKlfcM.Add(key, node2);
        node1.Nodes.Add(node2);
      }
      this.Mo8sNT9dXR.Sort();
      this.Mo8sNT9dXR.EndUpdate();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CTAs8mNp3D([In] object obj0, [In] TreeViewEventArgs obj1)
    {
      if (this.AMcsmUCK4L)
        return;
      this.AMcsmUCK4L = true;
      foreach (TreeNode treeNode in obj1.Node.Nodes)
        treeNode.Checked = obj1.Node.Checked;
      if (obj1.Node.Parent != null)
      {
        bool flag = true;
        foreach (TreeNode treeNode in obj1.Node.Parent.Nodes)
        {
          if (!treeNode.Checked)
          {
            flag = false;
            break;
          }
        }
        obj1.Node.Parent.Checked = flag;
      }
      this.AMcsmUCK4L = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Ilfs5gckU1([In] object obj0, [In] TreeViewEventArgs obj1)
    {
      this.o6fsCEqcdx(obj1.Node);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void eV9sqmB8EL([In] object obj0, [In] TreeViewEventArgs obj1)
    {
      this.o6fsCEqcdx(obj1.Node);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void o6fsCEqcdx([In] TreeNode obj0)
    {
      obj0.ImageIndex = obj0.SelectedImageIndex = obj0.IsExpanded ? 1 : 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.W2cswxNpCu != null)
        this.W2cswxNpCu.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void lUls2UvpV2()
    {
      this.W2cswxNpCu = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (InstrumentSelectorDialog));
      this.Ufes02OYYV = new Panel();
      this.dLrstGkjTP = new Button();
      this.TZ2spYLimT = new Button();
      this.Mo8sNT9dXR = new TreeView();
      this.W4osEa3Hyj = new ImageList(this.W2cswxNpCu);
      this.Ufes02OYYV.SuspendLayout();
      this.SuspendLayout();
      this.Ufes02OYYV.Controls.Add((Control) this.dLrstGkjTP);
      this.Ufes02OYYV.Controls.Add((Control) this.TZ2spYLimT);
      this.Ufes02OYYV.Dock = DockStyle.Bottom;
      this.Ufes02OYYV.Location = new Point(4, 300);
      this.Ufes02OYYV.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4092);
      this.Ufes02OYYV.Size = new Size(218, 40);
      this.Ufes02OYYV.TabIndex = 0;
      this.dLrstGkjTP.DialogResult = DialogResult.Cancel;
      this.dLrstGkjTP.Location = new Point(117, 11);
      this.dLrstGkjTP.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4108);
      this.dLrstGkjTP.Size = new Size(57, 22);
      this.dLrstGkjTP.TabIndex = 1;
      this.dLrstGkjTP.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4130);
      this.dLrstGkjTP.UseVisualStyleBackColor = true;
      this.TZ2spYLimT.DialogResult = DialogResult.OK;
      this.TZ2spYLimT.Location = new Point(54, 11);
      this.TZ2spYLimT.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4146);
      this.TZ2spYLimT.Size = new Size(57, 22);
      this.TZ2spYLimT.TabIndex = 0;
      this.TZ2spYLimT.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4160);
      this.TZ2spYLimT.UseVisualStyleBackColor = true;
      this.Mo8sNT9dXR.CheckBoxes = true;
      this.Mo8sNT9dXR.Dock = DockStyle.Fill;
      this.Mo8sNT9dXR.ImageIndex = 0;
      this.Mo8sNT9dXR.ImageList = this.W4osEa3Hyj;
      this.Mo8sNT9dXR.Indent = 19;
      this.Mo8sNT9dXR.Location = new Point(4, 4);
      this.Mo8sNT9dXR.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4168);
      this.Mo8sNT9dXR.SelectedImageIndex = 0;
      this.Mo8sNT9dXR.Size = new Size(218, 296);
      this.Mo8sNT9dXR.TabIndex = 1;
      this.Mo8sNT9dXR.AfterCheck += new TreeViewEventHandler(this.CTAs8mNp3D);
      this.Mo8sNT9dXR.AfterCollapse += new TreeViewEventHandler(this.Ilfs5gckU1);
      this.Mo8sNT9dXR.AfterExpand += new TreeViewEventHandler(this.eV9sqmB8EL);
      this.W4osEa3Hyj.ImageStream = (ImageListStreamer) componentResourceManager.GetObject(RNaihRhYEl0wUmAftnB.aYu7exFQKN(4200));
      this.W4osEa3Hyj.TransparentColor = Color.Transparent;
      this.W4osEa3Hyj.Images.SetKeyName(0, RNaihRhYEl0wUmAftnB.aYu7exFQKN(4240));
      this.W4osEa3Hyj.Images.SetKeyName(1, RNaihRhYEl0wUmAftnB.aYu7exFQKN(4278));
      this.W4osEa3Hyj.Images.SetKeyName(2, RNaihRhYEl0wUmAftnB.aYu7exFQKN(4302));
      this.AcceptButton = (IButtonControl) this.TZ2spYLimT;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.dLrstGkjTP;
      this.ClientSize = new Size(226, 340);
      this.Controls.Add((Control) this.Mo8sNT9dXR);
      this.Controls.Add((Control) this.Ufes02OYYV);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4334);
      this.Padding = new Padding(4, 4, 4, 0);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(4386);
      this.Ufes02OYYV.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
