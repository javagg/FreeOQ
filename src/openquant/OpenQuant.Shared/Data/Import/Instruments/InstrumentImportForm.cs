using OpenQuant.Shared;
using FreeQuant.FIX;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.Instruments
{
  public class InstrumentImportForm : Form
  {
    private IInstrumentProvider provider;
    private int selectedCount;
    private bool updateSelectedCount;
    private List<bool> sortOrders;
    private IContainer components;
    private GroupBox gbxFilter;
    private ComboBox cbxFilter_InstrumentTypes;
    private CheckBox chbFilter_InstrumentType;
    private CheckBox chbFilter_Exchange;
    private TextBox tbxFilter_Exchange;
    private TextBox tbxFilter_Symbol;
    private CheckBox chbFilter_Symbol;
    private ListView ltvSecurityDefinitions;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private Button btnRequest;
    private Button btnCheckAll;
    private Button btnUncheckAll;
    private Button btnImport;
    private Button btnClose;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private ToolStripStatusLabel toolStripStatusLabel2;
    private ToolStripStatusLabel toolStripStatusLabel3;
    private ToolStripStatusLabel toolStripStatusLabel4;
    private ColumnHeader columnHeader5;
    private ContextMenuStrip ctxSecurityDefinitions;
    private ToolStripMenuItem ctxSecurityDefinitions_ViewDetails;

    public InstrumentImportForm()
    {
      this.InitializeComponent();
      this.selectedCount = 0;
      this.updateSelectedCount = true;
      this.sortOrders = new List<bool>((IEnumerable<bool>) new bool[5]);
      this.cbxFilter_InstrumentTypes.BeginUpdate();
      this.cbxFilter_InstrumentTypes.Items.Clear();
      foreach (OpenQuant.API.InstrumentType instrumentType in Enum.GetValues(typeof (OpenQuant.API.InstrumentType)))
        this.cbxFilter_InstrumentTypes.Items.Add((object) instrumentType);
      this.cbxFilter_InstrumentTypes.SelectedItem = (object) OpenQuant.API.InstrumentType.Stock;
      this.cbxFilter_InstrumentTypes.EndUpdate();
    }

    public void Init(IInstrumentProvider provider)
    {
      this.provider = provider;
      this.Text = string.Format("Import Instruments - {0}", (object) ((IProvider) provider).Name);
    }

    private void chbFilter_InstrumentType_CheckedChanged(object sender, EventArgs e)
    {
      this.cbxFilter_InstrumentTypes.Enabled = this.chbFilter_InstrumentType.Checked;
    }

    private void chbFilter_Exchange_CheckedChanged(object sender, EventArgs e)
    {
      this.tbxFilter_Exchange.Enabled = this.chbFilter_Exchange.Checked;
    }

    private void chbFilter_Symbol_CheckedChanged(object sender, EventArgs e)
    {
      this.tbxFilter_Symbol.Enabled = this.chbFilter_Symbol.Checked;
    }

    private void btnRequest_Click(object sender, EventArgs e)
    {
      if (!((IProvider) this.provider).IsConnected)
      {
        if (MessageBox.Show((IWin32Window) this, ((IProvider) this.provider).Name + " is not connected. Do you want to connect?", "Connect " + ((IProvider) this.provider).Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
        Global.ProviderHelper.Connect((IProvider) this.provider);
        if (!((IProvider) this.provider).IsConnected)
        {
					int num = (int) MessageBox.Show((IWin32Window) this, "Unable to connect to " + ((IProvider) this.provider).Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          return;
        }
      }
      FIXSecurityDefinitionRequest request = new FIXSecurityDefinitionRequest((int) ((IProvider) this.provider).Id == 19 ? "0" : Guid.NewGuid().ToString(), 3);
      if (this.chbFilter_InstrumentType.Checked)
				request.SecurityType = APITypeConverter.InstrumentType.Convert((OpenQuant.API.InstrumentType) this.cbxFilter_InstrumentTypes.SelectedItem);
      if (this.chbFilter_Exchange.Checked)
				request.SecurityExchange = this.tbxFilter_Exchange.Text.Trim();
      if (this.chbFilter_Symbol.Checked)
				request.Symbol = this.tbxFilter_Symbol.Text.Trim();
      ProcessRequestForm processRequestForm = new ProcessRequestForm();
      processRequestForm.Init(this.provider, request);
      if (processRequestForm.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        List<FIXSecurityDefinition> list = new List<FIXSecurityDefinition>((IEnumerable<FIXSecurityDefinition>) processRequestForm.GetSecurityDefinitions());
        list.RemoveAll((Predicate<FIXSecurityDefinition>) (definition => !APITypeConverter.InstrumentType.CanConvert(definition.SecurityType)));
        this.UpdateSecurityDefinitionList(list.ToArray());
      }
      processRequestForm.Dispose();
      this.btnCheckAll.Enabled = true;
      this.btnUncheckAll.Enabled = true;
      this.btnImport.Enabled = true;
    }

    private void btnCheckAll_Click(object sender, EventArgs e)
    {
      this.updateSelectedCount = false;
      this.SetAllChecked(true);
      this.updateSelectedCount = true;
      this.UpdateSelectedCount();
    }

    private void btnUncheckAll_Click(object sender, EventArgs e)
    {
      this.updateSelectedCount = false;
      this.SetAllChecked(false);
      this.updateSelectedCount = true;
      this.UpdateSelectedCount();
    }

    private void btnImport_Click(object sender, EventArgs e)
    {
      if (this.ltvSecurityDefinitions.CheckedItems.Count == 0)
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, "No instruments selected.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        this.Cursor = Cursors.WaitCursor;
        List<FIXSecurityDefinition> list = new List<FIXSecurityDefinition>();
        foreach (SecurityDefinitionViewItem definitionViewItem in this.ltvSecurityDefinitions.Items)
        {
          if (definitionViewItem.Checked)
            list.Add(definitionViewItem.SecurityDefinition);
        }
        this.Cursor = Cursors.Default;
        ProcessImportForm processImportForm = new ProcessImportForm();
        processImportForm.Init(this.provider, list.ToArray());
        int num2 = (int) processImportForm.ShowDialog((IWin32Window) this);
        processImportForm.Dispose();
      }
    }

    private void ltvSecurityDefinitions_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      switch (e.NewValue)
      {
        case CheckState.Unchecked:
          --this.selectedCount;
          break;
        case CheckState.Checked:
          ++this.selectedCount;
          break;
      }
      if (!this.updateSelectedCount)
        return;
      this.UpdateSelectedCount();
    }

    private void ltvSecurityDefinitions_ColumnClick(object sender, ColumnClickEventArgs e)
    {
      bool descending = this.sortOrders[e.Column];
      this.ltvSecurityDefinitions.ListViewItemSorter = (IComparer) new SecurityDefinitionComparer(e.Column, descending);
      this.sortOrders[e.Column] = !descending;
    }

    private void ctxSecurityDefinitions_Opening(object sender, CancelEventArgs e)
    {
      if (this.ltvSecurityDefinitions.SelectedItems.Count == 0)
        this.ctxSecurityDefinitions_ViewDetails.Enabled = false;
      else
        this.ctxSecurityDefinitions_ViewDetails.Enabled = true;
    }

    private void ctxSecurityDefinitions_ViewDetails_Click(object sender, EventArgs e)
    {
      SecurityDefinitionViewItem definitionViewItem = (SecurityDefinitionViewItem) this.ltvSecurityDefinitions.SelectedItems[0];
      InstrumentDetailsForm instrumentDetailsForm = new InstrumentDetailsForm();
      instrumentDetailsForm.Init(definitionViewItem.SecurityDefinition);
      int num = (int) instrumentDetailsForm.ShowDialog((IWin32Window) this);
      instrumentDetailsForm.Dispose();
    }

    private void UpdateSelectedCount()
    {
      this.statusStrip.Items[3].Text = this.selectedCount.ToString("n0");
    }

    private void UpdateSecurityDefinitionList(FIXSecurityDefinition[] securityDefinitions)
    {
      this.Cursor = Cursors.WaitCursor;
      this.ltvSecurityDefinitions.BeginUpdate();
      this.ltvSecurityDefinitions.Items.Clear();
      foreach (FIXSecurityDefinition securityDefinition in securityDefinitions)
        this.ltvSecurityDefinitions.Items.Add((ListViewItem) new SecurityDefinitionViewItem(securityDefinition, ((IProvider) this.provider).Id));
      this.ltvSecurityDefinitions.EndUpdate();
      this.statusStrip.Items[1].Text = securityDefinitions.Length.ToString("n0");
      this.statusStrip.Items[3].Text = "0";
      this.selectedCount = 0;
      this.Cursor = Cursors.Default;
    }

    private void SetAllChecked(bool checked_)
    {
      this.Cursor = Cursors.WaitCursor;
      this.ltvSecurityDefinitions.BeginUpdate();
      foreach (ListViewItem listViewItem in this.ltvSecurityDefinitions.Items)
        listViewItem.Checked = checked_;
      this.ltvSecurityDefinitions.EndUpdate();
      this.Cursor = Cursors.Default;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.gbxFilter = new GroupBox();
      this.tbxFilter_Symbol = new TextBox();
      this.chbFilter_Symbol = new CheckBox();
      this.tbxFilter_Exchange = new TextBox();
      this.chbFilter_Exchange = new CheckBox();
      this.cbxFilter_InstrumentTypes = new ComboBox();
      this.chbFilter_InstrumentType = new CheckBox();
      this.ltvSecurityDefinitions = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.columnHeader5 = new ColumnHeader();
      this.ctxSecurityDefinitions = new ContextMenuStrip(this.components);
      this.ctxSecurityDefinitions_ViewDetails = new ToolStripMenuItem();
      this.btnRequest = new Button();
      this.btnCheckAll = new Button();
      this.btnUncheckAll = new Button();
      this.btnImport = new Button();
      this.btnClose = new Button();
      this.statusStrip = new StatusStrip();
      this.toolStripStatusLabel1 = new ToolStripStatusLabel();
      this.toolStripStatusLabel2 = new ToolStripStatusLabel();
      this.toolStripStatusLabel3 = new ToolStripStatusLabel();
      this.toolStripStatusLabel4 = new ToolStripStatusLabel();
      this.gbxFilter.SuspendLayout();
      this.ctxSecurityDefinitions.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.SuspendLayout();
      this.gbxFilter.Controls.Add((Control) this.tbxFilter_Symbol);
      this.gbxFilter.Controls.Add((Control) this.chbFilter_Symbol);
      this.gbxFilter.Controls.Add((Control) this.tbxFilter_Exchange);
      this.gbxFilter.Controls.Add((Control) this.chbFilter_Exchange);
      this.gbxFilter.Controls.Add((Control) this.cbxFilter_InstrumentTypes);
      this.gbxFilter.Controls.Add((Control) this.chbFilter_InstrumentType);
      this.gbxFilter.Location = new Point(16, 16);
      this.gbxFilter.Name = "gbxFilter";
      this.gbxFilter.Size = new Size(550, 73);
      this.gbxFilter.TabIndex = 0;
      this.gbxFilter.TabStop = false;
      this.gbxFilter.Text = "Filter";
      this.tbxFilter_Symbol.Enabled = false;
      this.tbxFilter_Symbol.Location = new Point(248, 40);
      this.tbxFilter_Symbol.Name = "tbxFilter_Symbol";
      this.tbxFilter_Symbol.Size = new Size(95, 20);
      this.tbxFilter_Symbol.TabIndex = 5;
      this.chbFilter_Symbol.Location = new Point(248, 20);
      this.chbFilter_Symbol.Name = "chbFilter_Symbol";
      this.chbFilter_Symbol.Size = new Size(97, 19);
      this.chbFilter_Symbol.TabIndex = 4;
      this.chbFilter_Symbol.Text = "Symbol";
      this.chbFilter_Symbol.UseVisualStyleBackColor = true;
      this.chbFilter_Symbol.CheckedChanged += new EventHandler(this.chbFilter_Symbol_CheckedChanged);
      this.tbxFilter_Exchange.Enabled = false;
      this.tbxFilter_Exchange.Location = new Point(140, 40);
      this.tbxFilter_Exchange.Name = "tbxFilter_Exchange";
      this.tbxFilter_Exchange.Size = new Size(95, 20);
      this.tbxFilter_Exchange.TabIndex = 3;
      this.chbFilter_Exchange.Location = new Point(140, 20);
      this.chbFilter_Exchange.Name = "chbFilter_Exchange";
      this.chbFilter_Exchange.Size = new Size(97, 19);
      this.chbFilter_Exchange.TabIndex = 2;
      this.chbFilter_Exchange.Text = "Exchange";
      this.chbFilter_Exchange.UseVisualStyleBackColor = true;
      this.chbFilter_Exchange.CheckedChanged += new EventHandler(this.chbFilter_Exchange_CheckedChanged);
      this.cbxFilter_InstrumentTypes.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxFilter_InstrumentTypes.Enabled = false;
      this.cbxFilter_InstrumentTypes.FormattingEnabled = true;
      this.cbxFilter_InstrumentTypes.Location = new Point(16, 40);
      this.cbxFilter_InstrumentTypes.Name = "cbxFilter_InstrumentTypes";
      this.cbxFilter_InstrumentTypes.Size = new Size(109, 21);
      this.cbxFilter_InstrumentTypes.Sorted = true;
      this.cbxFilter_InstrumentTypes.TabIndex = 1;
      this.chbFilter_InstrumentType.Location = new Point(16, 20);
      this.chbFilter_InstrumentType.Name = "chbFilter_InstrumentType";
      this.chbFilter_InstrumentType.Size = new Size(109, 19);
      this.chbFilter_InstrumentType.TabIndex = 0;
      this.chbFilter_InstrumentType.Text = "Instrument Type";
      this.chbFilter_InstrumentType.UseVisualStyleBackColor = true;
      this.chbFilter_InstrumentType.CheckedChanged += new EventHandler(this.chbFilter_InstrumentType_CheckedChanged);
      this.ltvSecurityDefinitions.CheckBoxes = true;
      this.ltvSecurityDefinitions.Columns.AddRange(new ColumnHeader[5]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3,
        this.columnHeader4,
        this.columnHeader5
      });
      this.ltvSecurityDefinitions.ContextMenuStrip = this.ctxSecurityDefinitions;
      this.ltvSecurityDefinitions.FullRowSelect = true;
      this.ltvSecurityDefinitions.GridLines = true;
      this.ltvSecurityDefinitions.HideSelection = false;
      this.ltvSecurityDefinitions.Location = new Point(16, 102);
      this.ltvSecurityDefinitions.Name = "ltvSecurityDefinitions";
      this.ltvSecurityDefinitions.ShowGroups = false;
      this.ltvSecurityDefinitions.ShowItemToolTips = true;
      this.ltvSecurityDefinitions.Size = new Size(550, 270);
      this.ltvSecurityDefinitions.TabIndex = 1;
      this.ltvSecurityDefinitions.UseCompatibleStateImageBehavior = false;
      this.ltvSecurityDefinitions.View = View.Details;
      this.ltvSecurityDefinitions.ColumnClick += new ColumnClickEventHandler(this.ltvSecurityDefinitions_ColumnClick);
      this.ltvSecurityDefinitions.ItemCheck += new ItemCheckEventHandler(this.ltvSecurityDefinitions_ItemCheck);
      this.columnHeader1.Text = "Symbol";
      this.columnHeader1.Width = 120;
      this.columnHeader2.Text = "InstrumentType";
      this.columnHeader2.TextAlign = HorizontalAlignment.Right;
      this.columnHeader2.Width = 100;
      this.columnHeader3.Text = "Exchange";
      this.columnHeader3.TextAlign = HorizontalAlignment.Right;
      this.columnHeader3.Width = 100;
      this.columnHeader4.Text = "Currency";
      this.columnHeader4.TextAlign = HorizontalAlignment.Right;
      this.columnHeader4.Width = 100;
      this.columnHeader5.Text = "Maturity";
      this.columnHeader5.TextAlign = HorizontalAlignment.Right;
      this.columnHeader5.Width = 100;
      this.ctxSecurityDefinitions.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.ctxSecurityDefinitions_ViewDetails
      });
      this.ctxSecurityDefinitions.Name = "ctxSecurityDefinitions";
      this.ctxSecurityDefinitions.Size = new Size(147, 26);
      this.ctxSecurityDefinitions.Opening += new CancelEventHandler(this.ctxSecurityDefinitions_Opening);
      this.ctxSecurityDefinitions_ViewDetails.Name = "ctxSecurityDefinitions_ViewDetails";
      this.ctxSecurityDefinitions_ViewDetails.Size = new Size(146, 22);
      this.ctxSecurityDefinitions_ViewDetails.Text = "View Details...";
      this.ctxSecurityDefinitions_ViewDetails.Click += new EventHandler(this.ctxSecurityDefinitions_ViewDetails_Click);
      this.btnRequest.Location = new Point(580, 22);
      this.btnRequest.Name = "btnRequest";
      this.btnRequest.Size = new Size(80, 22);
      this.btnRequest.TabIndex = 2;
      this.btnRequest.Text = "Request";
      this.btnRequest.UseVisualStyleBackColor = true;
      this.btnRequest.Click += new EventHandler(this.btnRequest_Click);
      this.btnCheckAll.Enabled = false;
      this.btnCheckAll.Location = new Point(580, 102);
      this.btnCheckAll.Name = "btnCheckAll";
      this.btnCheckAll.Size = new Size(80, 22);
      this.btnCheckAll.TabIndex = 3;
      this.btnCheckAll.Text = "Check all";
      this.btnCheckAll.UseVisualStyleBackColor = true;
      this.btnCheckAll.Click += new EventHandler(this.btnCheckAll_Click);
      this.btnUncheckAll.Enabled = false;
      this.btnUncheckAll.Location = new Point(580, 130);
      this.btnUncheckAll.Name = "btnUncheckAll";
      this.btnUncheckAll.Size = new Size(80, 22);
      this.btnUncheckAll.TabIndex = 4;
      this.btnUncheckAll.Text = "Uncheck all";
      this.btnUncheckAll.UseVisualStyleBackColor = true;
      this.btnUncheckAll.Click += new EventHandler(this.btnUncheckAll_Click);
      this.btnImport.Enabled = false;
      this.btnImport.Location = new Point(580, 170);
      this.btnImport.Name = "btnImport";
      this.btnImport.Size = new Size(80, 22);
      this.btnImport.TabIndex = 5;
      this.btnImport.Text = "Import";
      this.btnImport.UseVisualStyleBackColor = true;
      this.btnImport.Click += new EventHandler(this.btnImport_Click);
      this.btnClose.DialogResult = DialogResult.Cancel;
      this.btnClose.Location = new Point(580, 350);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(80, 22);
      this.btnClose.TabIndex = 6;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.statusStrip.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.toolStripStatusLabel1,
        (ToolStripItem) this.toolStripStatusLabel2,
        (ToolStripItem) this.toolStripStatusLabel3,
        (ToolStripItem) this.toolStripStatusLabel4
      });
      this.statusStrip.Location = new Point(0, 386);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new Size(674, 22);
      this.statusStrip.SizingGrip = false;
      this.statusStrip.TabIndex = 7;
      this.statusStrip.Text = "statusStrip1";
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new Size(73, 17);
      this.toolStripStatusLabel1.Text = "Instruments:";
      this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
      this.toolStripStatusLabel2.Size = new Size(13, 17);
      this.toolStripStatusLabel2.Text = "0";
      this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
      this.toolStripStatusLabel3.Size = new Size(54, 17);
      this.toolStripStatusLabel3.Text = "Selected:";
      this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
      this.toolStripStatusLabel4.Size = new Size(13, 17);
      this.toolStripStatusLabel4.Text = "0";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnClose;
      this.ClientSize = new Size(674, 408);
      this.Controls.Add((Control) this.statusStrip);
      this.Controls.Add((Control) this.btnClose);
      this.Controls.Add((Control) this.btnImport);
      this.Controls.Add((Control) this.btnUncheckAll);
      this.Controls.Add((Control) this.btnCheckAll);
      this.Controls.Add((Control) this.btnRequest);
      this.Controls.Add((Control) this.ltvSecurityDefinitions);
      this.Controls.Add((Control) this.gbxFilter);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "InstrumentImportForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Import Instruments";
      this.gbxFilter.ResumeLayout(false);
      this.gbxFilter.PerformLayout();
      this.ctxSecurityDefinitions.ResumeLayout(false);
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
