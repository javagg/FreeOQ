// Type: OpenQuant.QuantBase.ImportOptionsWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace OpenQuant.QuantBase
{
  internal class ImportOptionsWindow : Form
  {
    private ImportSettings settings;
    private IContainer components;
    private Button btnImport;
    private Button btnCancel;
    private Label label2;
    private Label label3;
    private Label label4;
    private DateTimePicker dtpFrom;
    private DateTimePicker dtpTo;
    private ComboBox cbxImportMode;
    private Label label5;

    public ImportOptionsWindow()
    {
      this.InitializeComponent();
    }

    public void Init(ImportSettings settings)
    {
      this.settings = settings;
    }

    protected override void OnShown(EventArgs e)
    {
      SortedSet<DateTime> sortedSet = new SortedSet<DateTime>();
      foreach (DataSeriesItem dataSeriesItem in this.settings.Items)
      {
        if (dataSeriesItem.QB_Info.Begin.HasValue)
          sortedSet.Add(dataSeriesItem.QB_Info.Begin.Value);
        if (dataSeriesItem.QB_Info.End.HasValue)
          sortedSet.Add(dataSeriesItem.QB_Info.End.Value);
      }
      if (sortedSet.Count == 0)
      {
        this.dtpFrom.MinDate = DateTime.Today;
        this.dtpFrom.MaxDate = DateTime.Today;
        this.dtpFrom.Value = DateTime.Today;
        this.dtpTo.MinDate = DateTime.Today;
        this.dtpTo.MaxDate = DateTime.Today;
        this.dtpTo.Value = DateTime.Today;
      }
      else
      {
        this.dtpFrom.MinDate = sortedSet.Min;
        this.dtpFrom.MaxDate = sortedSet.Max;
        this.dtpFrom.Value = sortedSet.Min;
        this.dtpTo.MinDate = sortedSet.Min;
        this.dtpTo.MaxDate = sortedSet.Max;
        this.dtpTo.Value = sortedSet.Max;
      }
      string fullDateTimePattern = CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern;
      this.dtpFrom.CustomFormat = fullDateTimePattern;
      this.dtpTo.CustomFormat = fullDateTimePattern;
      this.dtpFrom.Checked = false;
      this.dtpTo.Checked = false;
      this.cbxImportMode.BeginUpdate();
      this.cbxImportMode.Items.Clear();
      foreach (ImportMode importMode in Enum.GetValues(typeof (ImportMode)))
        this.cbxImportMode.Items.Add((object) importMode);
      this.cbxImportMode.SelectedItem = (object) this.settings.ImportMode;
      this.cbxImportMode.EndUpdate();
      base.OnShown(e);
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
      if (this.DialogResult == DialogResult.OK)
      {
        this.settings.From = this.dtpFrom.Checked ? new DateTime?(this.dtpFrom.Value) : new DateTime?();
        this.settings.To = this.dtpTo.Checked ? new DateTime?(this.dtpTo.Value) : new DateTime?();
        this.settings.ImportMode = (ImportMode) this.cbxImportMode.SelectedItem;
      }
      base.OnFormClosed(e);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.btnImport = new Button();
      this.btnCancel = new Button();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.dtpFrom = new DateTimePicker();
      this.dtpTo = new DateTimePicker();
      this.cbxImportMode = new ComboBox();
      this.label5 = new Label();
      this.SuspendLayout();
      this.btnImport.DialogResult = DialogResult.OK;
      this.btnImport.Location = new Point(74, 175);
      this.btnImport.Name = "btnImport";
      this.btnImport.Size = new Size(101, 27);
      this.btnImport.TabIndex = 1;
      this.btnImport.Text = "Import";
      this.btnImport.UseVisualStyleBackColor = true;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(181, 175);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(101, 27);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.label2.Location = new Point(20, 16);
      this.label2.Name = "label2";
      this.label2.Size = new Size(104, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "Import date range";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.label3.Location = new Point(56, 40);
      this.label3.Name = "label3";
      this.label3.Size = new Size(43, 20);
      this.label3.TabIndex = 6;
      this.label3.Text = "From";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.label4.Location = new Point(56, 72);
      this.label4.Name = "label4";
      this.label4.Size = new Size(43, 20);
      this.label4.TabIndex = 7;
      this.label4.Text = "To";
      this.label4.TextAlign = ContentAlignment.MiddleLeft;
      this.dtpFrom.Checked = false;
      this.dtpFrom.Format = DateTimePickerFormat.Custom;
      this.dtpFrom.Location = new Point(96, 40);
      this.dtpFrom.Name = "dtpFrom";
      this.dtpFrom.ShowCheckBox = true;
      this.dtpFrom.Size = new Size(225, 20);
      this.dtpFrom.TabIndex = 8;
      this.dtpTo.Checked = false;
      this.dtpTo.Format = DateTimePickerFormat.Custom;
      this.dtpTo.Location = new Point(96, 72);
      this.dtpTo.Name = "dtpTo";
      this.dtpTo.ShowCheckBox = true;
      this.dtpTo.Size = new Size(225, 20);
      this.dtpTo.TabIndex = 9;
      this.cbxImportMode.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxImportMode.FormattingEnabled = true;
      this.cbxImportMode.Location = new Point(20, 120);
      this.cbxImportMode.Name = "cbxImportMode";
      this.cbxImportMode.Size = new Size(100, 21);
      this.cbxImportMode.TabIndex = 10;
      this.label5.Location = new Point(128, 120);
      this.label5.Name = "label5";
      this.label5.Size = new Size(86, 20);
      this.label5.TabIndex = 11;
      this.label5.Text = "existent series";
      this.label5.TextAlign = ContentAlignment.MiddleLeft;
      this.AcceptButton = (IButtonControl) this.btnImport;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(346, 222);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.cbxImportMode);
      this.Controls.Add((Control) this.dtpTo);
      this.Controls.Add((Control) this.dtpFrom);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnImport);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ImportOptionsWindow";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Import Options";
      this.ResumeLayout(false);
    }
  }
}
