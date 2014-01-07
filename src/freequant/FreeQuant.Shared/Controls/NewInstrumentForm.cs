// Type: SmartQuant.Shared.Controls.NewInstrumentForm
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using CB33BNNCtaYPG7L4yj;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Controls
{
  public class NewInstrumentForm : Form
  {
    private Label t7WuGjiONU;
    private TextBox RoWuZFPRF7;
    private Button yRpu4hCXgT;
    private Button gBTuITiFmH;
    private Label NKIuSJIHeH;
    private ComboBox l3MuUw9HUI;
    private Label APpujP5a3B;
    private TextBox Jktu6i43wd;
    private Container JaHurHyRak;

    public string Symbol
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.RoWuZFPRF7.Text.Trim();
      }
    }

    public string SecurityType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Jktu6i43wd.Text.Trim();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NewInstrumentForm()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.aowuWXIHfj();
      this.TWluaeenYQ();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.JaHurHyRak != null)
        this.JaHurHyRak.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void aowuWXIHfj()
    {
      this.t7WuGjiONU = new Label();
      this.RoWuZFPRF7 = new TextBox();
      this.yRpu4hCXgT = new Button();
      this.gBTuITiFmH = new Button();
      this.NKIuSJIHeH = new Label();
      this.l3MuUw9HUI = new ComboBox();
      this.APpujP5a3B = new Label();
      this.Jktu6i43wd = new TextBox();
      this.SuspendLayout();
      this.t7WuGjiONU.Location = new Point(16, 16);
      this.t7WuGjiONU.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(23118);
      this.t7WuGjiONU.Size = new Size(48, 20);
      this.t7WuGjiONU.TabIndex = 0;
      this.t7WuGjiONU.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(23134);
      this.t7WuGjiONU.TextAlign = ContentAlignment.MiddleLeft;
      this.RoWuZFPRF7.Location = new Point(104, 16);
      this.RoWuZFPRF7.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(23150);
      this.RoWuZFPRF7.Size = new Size(104, 20);
      this.RoWuZFPRF7.TabIndex = 1;
      this.RoWuZFPRF7.TextChanged += new EventHandler(this.zhFuTe3Vf7);
      this.yRpu4hCXgT.DialogResult = DialogResult.OK;
      this.yRpu4hCXgT.Location = new Point(128, 97);
      this.yRpu4hCXgT.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(23172);
      this.yRpu4hCXgT.Size = new Size(80, 24);
      this.yRpu4hCXgT.TabIndex = 2;
      this.yRpu4hCXgT.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(23186);
      this.gBTuITiFmH.DialogResult = DialogResult.Cancel;
      this.gBTuITiFmH.Location = new Point(214, 97);
      this.gBTuITiFmH.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(23194);
      this.gBTuITiFmH.Size = new Size(80, 24);
      this.gBTuITiFmH.TabIndex = 3;
      this.gBTuITiFmH.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(23216);
      this.NKIuSJIHeH.Location = new Point(16, 40);
      this.NKIuSJIHeH.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(23232);
      this.NKIuSJIHeH.Size = new Size(80, 20);
      this.NKIuSJIHeH.TabIndex = 4;
      this.NKIuSJIHeH.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(23248);
      this.NKIuSJIHeH.TextAlign = ContentAlignment.MiddleLeft;
      this.l3MuUw9HUI.DropDownStyle = ComboBoxStyle.DropDownList;
      this.l3MuUw9HUI.DropDownWidth = 250;
      this.l3MuUw9HUI.Location = new Point(104, 40);
      this.l3MuUw9HUI.MaxDropDownItems = 20;
      this.l3MuUw9HUI.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(23278);
      this.l3MuUw9HUI.Size = new Size(176, 21);
      this.l3MuUw9HUI.TabIndex = 5;
      this.l3MuUw9HUI.SelectedIndexChanged += new EventHandler(this.aJwuyrlOu5);
      this.APpujP5a3B.Location = new Point(16, 64);
      this.APpujP5a3B.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(23312);
      this.APpujP5a3B.Size = new Size(80, 20);
      this.APpujP5a3B.TabIndex = 6;
      this.APpujP5a3B.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(23328);
      this.APpujP5a3B.TextAlign = ContentAlignment.MiddleLeft;
      this.Jktu6i43wd.Enabled = false;
      this.Jktu6i43wd.Location = new Point(104, 64);
      this.Jktu6i43wd.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(23338);
      this.Jktu6i43wd.Size = new Size(104, 20);
      this.Jktu6i43wd.TabIndex = 7;
      this.Jktu6i43wd.TextChanged += new EventHandler(this.gN8ufcGfjb);
      this.AcceptButton = (IButtonControl) this.yRpu4hCXgT;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.gBTuITiFmH;
      this.ClientSize = new Size(316, 133);
      this.Controls.Add((Control) this.Jktu6i43wd);
      this.Controls.Add((Control) this.RoWuZFPRF7);
      this.Controls.Add((Control) this.APpujP5a3B);
      this.Controls.Add((Control) this.l3MuUw9HUI);
      this.Controls.Add((Control) this.NKIuSJIHeH);
      this.Controls.Add((Control) this.gBTuITiFmH);
      this.Controls.Add((Control) this.yRpu4hCXgT);
      this.Controls.Add((Control) this.t7WuGjiONU);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(23372);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = RNaihRhYEl0wUmAftnB.aYu7exFQKN(23410);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSecurityType(string securityType)
    {
      if (securityType == null)
        securityType = RNaihRhYEl0wUmAftnB.aYu7exFQKN(23442);
      foreach (object obj in this.l3MuUw9HUI.Items)
      {
        aUnqtIpxoD0rtIQVGJ unqtIpxoD0rtIqvgj = obj as aUnqtIpxoD0rtIQVGJ;
        if (unqtIpxoD0rtIqvgj != null && unqtIpxoD0rtIqvgj.TNTuL9pAwZ() == securityType)
        {
          this.l3MuUw9HUI.SelectedItem = (object) unqtIpxoD0rtIqvgj;
          break;
        }
      }
      if (this.l3MuUw9HUI.SelectedItem == null)
      {
        this.l3MuUw9HUI.SelectedIndex = this.l3MuUw9HUI.Items.Count - 1;
        this.Jktu6i43wd.Text = securityType;
      }
      this.kIYuO15Fgl();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void zhFuTe3Vf7([In] object obj0, [In] EventArgs obj1)
    {
      this.kIYuO15Fgl();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void gN8ufcGfjb([In] object obj0, [In] EventArgs obj1)
    {
      this.kIYuO15Fgl();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void aJwuyrlOu5([In] object obj0, [In] EventArgs obj1)
    {
      aUnqtIpxoD0rtIQVGJ unqtIpxoD0rtIqvgj = this.l3MuUw9HUI.SelectedItem as aUnqtIpxoD0rtIQVGJ;
      if (unqtIpxoD0rtIqvgj == null)
      {
        this.Jktu6i43wd.Text = "";
        this.Jktu6i43wd.Enabled = false;
      }
      else if (unqtIpxoD0rtIqvgj.TNTuL9pAwZ() == null)
      {
        this.Jktu6i43wd.Text = "";
        this.Jktu6i43wd.Enabled = true;
      }
      else
      {
        this.Jktu6i43wd.Text = unqtIpxoD0rtIqvgj.TNTuL9pAwZ();
        this.Jktu6i43wd.Enabled = false;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void kIYuO15Fgl()
    {
      this.yRpu4hCXgT.Enabled = this.Symbol != "" && this.SecurityType != "";
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TWluaeenYQ()
    {
      this.l3MuUw9HUI.Items.Add((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(23450));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(23478), RNaihRhYEl0wUmAftnB.aYu7exFQKN(23530)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(23548), RNaihRhYEl0wUmAftnB.aYu7exFQKN(23590)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(23600), RNaihRhYEl0wUmAftnB.aYu7exFQKN(23654)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(23666), RNaihRhYEl0wUmAftnB.aYu7exFQKN(23710)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(23720), RNaihRhYEl0wUmAftnB.aYu7exFQKN(23770)));
      this.l3MuUw9HUI.Items.Add((object) "");
      this.l3MuUw9HUI.Items.Add((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(23784));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(23818), RNaihRhYEl0wUmAftnB.aYu7exFQKN(23834)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(23844), RNaihRhYEl0wUmAftnB.aYu7exFQKN(23860)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(23870), RNaihRhYEl0wUmAftnB.aYu7exFQKN(23898)));
      this.l3MuUw9HUI.Items.Add((object) "");
      this.l3MuUw9HUI.Items.Add((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(23908));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(23942), RNaihRhYEl0wUmAftnB.aYu7exFQKN(23972)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(23984), RNaihRhYEl0wUmAftnB.aYu7exFQKN(24038)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(24048), RNaihRhYEl0wUmAftnB.aYu7exFQKN(24082)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(24090), RNaihRhYEl0wUmAftnB.aYu7exFQKN(24118)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(24130), RNaihRhYEl0wUmAftnB.aYu7exFQKN(24168)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(24184), RNaihRhYEl0wUmAftnB.aYu7exFQKN(24214)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(24230), RNaihRhYEl0wUmAftnB.aYu7exFQKN(24264)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(24280), RNaihRhYEl0wUmAftnB.aYu7exFQKN(24322)));
      this.l3MuUw9HUI.Items.Add((object) "");
      this.l3MuUw9HUI.Items.Add((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(24334));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(24366), RNaihRhYEl0wUmAftnB.aYu7exFQKN(24416)));
      this.l3MuUw9HUI.Items.Add((object) "");
      this.l3MuUw9HUI.Items.Add((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(24426));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(24454), RNaihRhYEl0wUmAftnB.aYu7exFQKN(24480)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(24488), RNaihRhYEl0wUmAftnB.aYu7exFQKN(24520)));
      this.l3MuUw9HUI.Items.Add((object) "");
      this.l3MuUw9HUI.Items.Add((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(24528));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(24564), RNaihRhYEl0wUmAftnB.aYu7exFQKN(24586)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(24600), RNaihRhYEl0wUmAftnB.aYu7exFQKN(24632)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(24646), RNaihRhYEl0wUmAftnB.aYu7exFQKN(24678)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(24692), RNaihRhYEl0wUmAftnB.aYu7exFQKN(24756)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(24768), RNaihRhYEl0wUmAftnB.aYu7exFQKN(24844)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(24856), RNaihRhYEl0wUmAftnB.aYu7exFQKN(24930)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(24942), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25026)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25038), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25070)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25084), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25116)));
      this.l3MuUw9HUI.Items.Add((object) "");
      this.l3MuUw9HUI.Items.Add((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(25130));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25164), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25188)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25200), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25218)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25236), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25262)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25280), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25312)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25330), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25366)));
      this.l3MuUw9HUI.Items.Add((object) "");
      this.l3MuUw9HUI.Items.Add((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(25388));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25414), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25428)));
      this.l3MuUw9HUI.Items.Add((object) "");
      this.l3MuUw9HUI.Items.Add((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(25438));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25462), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25482)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25494), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25522)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25534), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25570)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25588), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25612)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25628), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25660)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25672), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25710)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25724), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25764)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25776), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25798)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25816), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25838)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25856), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25876)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25894), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25912)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25930), RNaihRhYEl0wUmAftnB.aYu7exFQKN(25970)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(25988), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26006)));
      this.l3MuUw9HUI.Items.Add((object) "");
      this.l3MuUw9HUI.Items.Add((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(26024));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26062), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26100)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26108), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26130)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26138), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26172)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26182), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26226)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26234), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26256)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26264), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26298)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26306), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26334)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26342), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26394)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26406), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26448)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26460), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26490)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26500), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26534)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26544), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26566)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26580), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26612)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26620), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26646)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26658), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26696)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26706), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26732)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26740), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26776)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26786), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26842)));
      this.l3MuUw9HUI.Items.Add((object) "");
      this.l3MuUw9HUI.Items.Add((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(26852));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26884), RNaihRhYEl0wUmAftnB.aYu7exFQKN(26930)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(26940), RNaihRhYEl0wUmAftnB.aYu7exFQKN(27000)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(27012), RNaihRhYEl0wUmAftnB.aYu7exFQKN(27080)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(27090), RNaihRhYEl0wUmAftnB.aYu7exFQKN(27122)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(27132), RNaihRhYEl0wUmAftnB.aYu7exFQKN(27184)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(27194), RNaihRhYEl0wUmAftnB.aYu7exFQKN(27238)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(27248), RNaihRhYEl0wUmAftnB.aYu7exFQKN(27294)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(27304), RNaihRhYEl0wUmAftnB.aYu7exFQKN(27356)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(27366), RNaihRhYEl0wUmAftnB.aYu7exFQKN(27418)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(27428), RNaihRhYEl0wUmAftnB.aYu7exFQKN(27454)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(27468), RNaihRhYEl0wUmAftnB.aYu7exFQKN(27498)));
      this.l3MuUw9HUI.Items.Add((object) "");
      this.l3MuUw9HUI.Items.Add((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(27508));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(27542), RNaihRhYEl0wUmAftnB.aYu7exFQKN(27590)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(27598), RNaihRhYEl0wUmAftnB.aYu7exFQKN(27648)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(27660), RNaihRhYEl0wUmAftnB.aYu7exFQKN(27716)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(27728), RNaihRhYEl0wUmAftnB.aYu7exFQKN(27776)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(27784), RNaihRhYEl0wUmAftnB.aYu7exFQKN(27818)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(27826), RNaihRhYEl0wUmAftnB.aYu7exFQKN(27876)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(27886), RNaihRhYEl0wUmAftnB.aYu7exFQKN(27914)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(27924), RNaihRhYEl0wUmAftnB.aYu7exFQKN(27962)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(27976), RNaihRhYEl0wUmAftnB.aYu7exFQKN(28014)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(28028), RNaihRhYEl0wUmAftnB.aYu7exFQKN(28052)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(28066), RNaihRhYEl0wUmAftnB.aYu7exFQKN(28108)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(28118), RNaihRhYEl0wUmAftnB.aYu7exFQKN(28148)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(28160), RNaihRhYEl0wUmAftnB.aYu7exFQKN(28212)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(28224), RNaihRhYEl0wUmAftnB.aYu7exFQKN(28286)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(28298), RNaihRhYEl0wUmAftnB.aYu7exFQKN(28346)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(28358), RNaihRhYEl0wUmAftnB.aYu7exFQKN(28376)));
      this.l3MuUw9HUI.Items.Add((object) "");
      this.l3MuUw9HUI.Items.Add((object) RNaihRhYEl0wUmAftnB.aYu7exFQKN(28386));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(28412), RNaihRhYEl0wUmAftnB.aYu7exFQKN(28452)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(28462), RNaihRhYEl0wUmAftnB.aYu7exFQKN(28486)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(28494), RNaihRhYEl0wUmAftnB.aYu7exFQKN(28534)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(28546), RNaihRhYEl0wUmAftnB.aYu7exFQKN(28578)));
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(28590), RNaihRhYEl0wUmAftnB.aYu7exFQKN(28610)));
      this.l3MuUw9HUI.Items.Add((object) "");
      this.l3MuUw9HUI.Items.Add((object) new aUnqtIpxoD0rtIQVGJ(RNaihRhYEl0wUmAftnB.aYu7exFQKN(28616), (string) null));
    }
  }
}
