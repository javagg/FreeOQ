using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Import.CSV
{
  class ErrorDialog : Form
  {
    private ErrorDialog.Result result;
    private ListView ltvFragment;
    private Panel panel1;
    private Label label1;
    private Label lblFile;
    private Panel panel2;
    private Label lblMessage;
    private Label label3;
    private Button btnIgnore;
    private Button btnStop;
    private Button btnSkipFile;
    private Container components;

		public new ErrorDialog.Result DialogResult
    {
      get
      {
        return this.result;
      }
    }

    public ErrorDialog()
    {
      this.InitializeComponent();
      this.result = ErrorDialog.Result.None;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ErrorDialog));
      this.ltvFragment = new ListView();
      this.panel1 = new Panel();
      this.lblFile = new Label();
      this.label1 = new Label();
      this.panel2 = new Panel();
      this.lblMessage = new Label();
      this.label3 = new Label();
      this.btnIgnore = new Button();
      this.btnStop = new Button();
      this.btnSkipFile = new Button();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      this.ltvFragment.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ltvFragment.HideSelection = false;
      this.ltvFragment.Location = new Point(16, 80);
      this.ltvFragment.Name = "ltvFragment";
      this.ltvFragment.Size = new Size(632, 64);
      this.ltvFragment.TabIndex = 0;
      this.ltvFragment.UseCompatibleStateImageBehavior = false;
      this.ltvFragment.View = View.Details;
      this.panel1.Controls.Add((Control) this.lblFile);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Location = new Point(16, 16);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(616, 20);
      this.panel1.TabIndex = 1;
      this.lblFile.Dock = DockStyle.Fill;
      this.lblFile.Location = new Point(64, 0);
      this.lblFile.Name = "lblFile";
      this.lblFile.Size = new Size(552, 20);
      this.lblFile.TabIndex = 1;
      this.lblFile.TextAlign = ContentAlignment.MiddleLeft;
      this.label1.Dock = DockStyle.Left;
      this.label1.Location = new Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(64, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "File:";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.panel2.Controls.Add((Control) this.lblMessage);
      this.panel2.Controls.Add((Control) this.label3);
      this.panel2.Location = new Point(16, 40);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(616, 32);
      this.panel2.TabIndex = 2;
      this.lblMessage.Dock = DockStyle.Fill;
      this.lblMessage.Location = new Point(64, 0);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.Size = new Size(552, 32);
      this.lblMessage.TabIndex = 1;
      this.label3.Dock = DockStyle.Left;
      this.label3.Location = new Point(0, 0);
      this.label3.Name = "label3";
      this.label3.Size = new Size(64, 32);
      this.label3.TabIndex = 0;
      this.label3.Text = "Message:";
      this.btnIgnore.Location = new Point(360, 160);
      this.btnIgnore.Name = "btnIgnore";
      this.btnIgnore.Size = new Size(80, 24);
      this.btnIgnore.TabIndex = 3;
      this.btnIgnore.Text = "Ignore";
      this.btnIgnore.Click += new EventHandler(this.btnIgnore_Click);
      this.btnStop.Location = new Point(560, 160);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new Size(80, 24);
      this.btnStop.TabIndex = 4;
      this.btnStop.Text = "Stop";
      this.btnStop.Click += new EventHandler(this.btnStop_Click);
      this.btnSkipFile.Location = new Point(448, 160);
      this.btnSkipFile.Name = "btnSkipFile";
      this.btnSkipFile.Size = new Size(80, 24);
      this.btnSkipFile.TabIndex = 5;
      this.btnSkipFile.Text = "Skip file";
      this.btnSkipFile.Click += new EventHandler(this.btnSkipFile_Click);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(664, 199);
      this.Controls.Add((Control) this.btnSkipFile);
      this.Controls.Add((Control) this.btnStop);
      this.Controls.Add((Control) this.btnIgnore);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.ltvFragment);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ErrorDialog";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "An Error Occured While Importing Data";
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    protected override void OnClosing(CancelEventArgs e)
    {
      e.Cancel = this.result == ErrorDialog.Result.None;
      base.OnClosing(e);
    }

    public void SetError(Template template, ErrorEventArgs args)
    {
      this.lblFile.Text = args.File.FullName;
      this.lblMessage.Text = args.Message;
      this.ltvFragment.Columns.Add("Line #", 60, HorizontalAlignment.Left);
      foreach (Column column in (List<Column>) template.Columns)
      {
        string text = Column.ToString(column.ColumnType);
        if (column.ColumnFormat != "")
          text = text + " (" + column.ColumnFormat + ")";
        this.ltvFragment.Columns.Add(text, 100, HorizontalAlignment.Center);
      }
      ListViewItem listViewItem = new ListViewItem(args.Row.ToString());
      listViewItem.UseItemStyleForSubItems = false;
      string[] strArray = args.Line.Split((char[]) template.CSVOptions.Separator);
      for (int index = 0; index < strArray.Length; ++index)
        listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem()
        {
          Text = strArray[index],
          BackColor = index == args.Column ? Color.Red : listViewItem.BackColor
        });
      this.ltvFragment.Items.Add(listViewItem);
    }

    private void btnIgnore_Click(object sender, EventArgs e)
    {
      this.result = ErrorDialog.Result.Ignore;
      this.Close();
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
      this.result = ErrorDialog.Result.Stop;
      this.Close();
    }

    private void btnSkipFile_Click(object sender, EventArgs e)
    {
      this.result = ErrorDialog.Result.SkipFile;
      this.Close();
    }

    public enum Result
    {
      None,
      Ignore,
      Stop,
      SkipFile,
    }
  }
}
