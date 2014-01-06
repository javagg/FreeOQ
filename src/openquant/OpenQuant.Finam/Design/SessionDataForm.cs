// Type: OpenQuant.Finam.Design.SessionDataForm
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

using OpenQuant.Finam;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Finam.Design
{
  public class SessionDataForm : Form
  {
    private IContainer components;
    private ListView contractView;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
    private ColumnHeader columnHeader6;
    private ColumnHeader columnHeader7;
    private ColumnHeader columnHeader8;
    private ColumnHeader columnHeader9;
    private ColumnHeader columnHeader10;
    private ColumnHeader columnHeader11;
    private ColumnHeader columnHeader12;
    private ColumnHeader columnHeader13;
    private ColumnHeader columnHeader14;
    private ColumnHeader columnHeader15;
    private StatusStrip statusStrip1;
    private ColumnHeader columnHeader16;

    public SessionDataForm()
    {
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.contractView = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader15 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.columnHeader5 = new ColumnHeader();
      this.columnHeader6 = new ColumnHeader();
      this.columnHeader7 = new ColumnHeader();
      this.columnHeader8 = new ColumnHeader();
      this.columnHeader9 = new ColumnHeader();
      this.columnHeader10 = new ColumnHeader();
      this.columnHeader11 = new ColumnHeader();
      this.columnHeader12 = new ColumnHeader();
      this.columnHeader13 = new ColumnHeader();
      this.columnHeader14 = new ColumnHeader();
      this.statusStrip1 = new StatusStrip();
      this.columnHeader16 = new ColumnHeader();
      this.SuspendLayout();
      this.contractView.Columns.AddRange(new ColumnHeader[16]
      {
        this.columnHeader1,
        this.columnHeader15,
        this.columnHeader2,
        this.columnHeader16,
        this.columnHeader3,
        this.columnHeader4,
        this.columnHeader5,
        this.columnHeader6,
        this.columnHeader7,
        this.columnHeader8,
        this.columnHeader9,
        this.columnHeader10,
        this.columnHeader11,
        this.columnHeader12,
        this.columnHeader13,
        this.columnHeader14
      });
      this.contractView.Dock = DockStyle.Fill;
      this.contractView.GridLines = true;
      this.contractView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.contractView.HideSelection = false;
      this.contractView.Location = new Point(0, 0);
      this.contractView.MultiSelect = false;
      this.contractView.Name = "contractView";
      this.contractView.ShowGroups = false;
      this.contractView.ShowItemToolTips = true;
      this.contractView.Size = new Size(922, 480);
      this.contractView.TabIndex = 0;
      this.contractView.UseCompatibleStateImageBehavior = false;
      this.contractView.View = View.Details;
      this.columnHeader1.Text = "SecId";
      this.columnHeader1.Width = 40;
      this.columnHeader15.Text = "Active";
      this.columnHeader15.Width = 50;
      this.columnHeader2.Text = "SecCode";
      this.columnHeader2.Width = 100;
      this.columnHeader3.Text = "Market";
      this.columnHeader3.Width = 50;
      this.columnHeader4.Text = "ShortName";
      this.columnHeader4.Width = 105;
      this.columnHeader5.Text = "Decimals";
      this.columnHeader5.Width = 55;
      this.columnHeader6.Text = "MinStep";
      this.columnHeader6.Width = 55;
      this.columnHeader7.Text = "LotSize";
      this.columnHeader7.Width = 50;
      this.columnHeader8.Text = "PointCost";
      this.columnHeader9.Text = "UseCredit";
      this.columnHeader10.Text = "ByMarket";
      this.columnHeader11.Text = "NoSplit";
      this.columnHeader11.Width = 50;
      this.columnHeader12.Text = "ImmOrCancel";
      this.columnHeader13.Text = "CancelBalance";
      this.columnHeader14.Text = "SecType";
      this.statusStrip1.Location = new Point(0, 458);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new Size(922, 22);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      this.columnHeader16.Text = "Board";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(922, 480);
      this.Controls.Add((Control) this.statusStrip1);
      this.Controls.Add((Control) this.contractView);
      this.MinimizeBox = false;
      this.Name = "SessionDataForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Finam Transaq - Session Data";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public void Init(Dictionary<string, TransaqSecurity> instruments, Dictionary<int, string> markets)
    {
      this.contractView.BeginUpdate();
      this.contractView.Items.Clear();
      foreach (TransaqSecurity security in instruments.Values)
        this.contractView.Items.Add((ListViewItem) new ContractViewItem(security, markets[security.Market]));
      this.contractView.EndUpdate();
    }
  }
}
