// Type: OpenQuant.Shared.Data.Management.DataSeriesCalendarForm
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Management
{
  internal class DataSeriesCalendarForm : Form
  {
    private IContainer components;
    private Panel panel;
    private Button btnOK;
    private Button btnCancel;
    private GroupBox groupBox1;
    private TreeView treeView;

    public DateTime SelectedDate
    {
      get
      {
        if (this.treeView.SelectedNode != null && this.treeView.SelectedNode is DayNode)
          return ((DateNode) this.treeView.SelectedNode).Date;
        else
          throw new ApplicationException("Day is not selected!");
      }
    }

    public DataSeriesCalendarForm()
    {
      this.InitializeComponent();
    }

    public void Init(IDictionary<DateTime, int> dates, DateTime selectedDate)
    {
      Dictionary<int, TreeNode> dictionary1 = new Dictionary<int, TreeNode>();
      Dictionary<int, TreeNode> dictionary2 = new Dictionary<int, TreeNode>();
      this.treeView.BeginUpdate();
      foreach (KeyValuePair<DateTime, int> keyValuePair in (IEnumerable<KeyValuePair<DateTime, int>>) dates)
      {
        DateTime key = keyValuePair.Key;
        int year = key.Year;
        int month = key.Month;
        int day = key.Day;
        TreeNode node1;
        if (!dictionary1.TryGetValue(year, out node1))
        {
          node1 = (TreeNode) new DateNode(key, "yyyy");
          dictionary1.Add(year, node1);
          this.treeView.Nodes.Add(node1);
        }
        TreeNode node2;
        if (!dictionary2.TryGetValue(month, out node2))
        {
          node2 = (TreeNode) new DateNode(key, "MMM");
          dictionary2.Add(month, node2);
          node1.Nodes.Add(node2);
        }
        DayNode dayNode = new DayNode(key, keyValuePair.Value);
        node2.Nodes.Add((TreeNode) dayNode);
        if (key == selectedDate)
          this.treeView.SelectedNode = (TreeNode) dayNode;
      }
      this.treeView.TreeViewNodeSorter = (IComparer) new DateNodeComparer();
      this.treeView.Sort();
      this.treeView.EndUpdate();
      this.UpdateOKButtonStatus();
    }

    private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
      this.UpdateOKButtonStatus();
    }

    private void treeView_DoubleClick(object sender, EventArgs e)
    {
      if (this.treeView.SelectedNode == null || !(this.treeView.SelectedNode is DayNode))
        return;
      this.btnOK.PerformClick();
    }

    private void UpdateOKButtonStatus()
    {
      this.btnOK.Enabled = this.treeView.SelectedNode != null && this.treeView.SelectedNode is DayNode;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.panel = new Panel();
      this.btnCancel = new Button();
      this.btnOK = new Button();
      this.groupBox1 = new GroupBox();
      this.treeView = new TreeView();
      this.panel.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.panel.Controls.Add((Control) this.btnCancel);
      this.panel.Controls.Add((Control) this.btnOK);
      this.panel.Dock = DockStyle.Bottom;
      this.panel.Location = new Point(0, 333);
      this.panel.Name = "panel";
      this.panel.Size = new Size(228, 41);
      this.panel.TabIndex = 0;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(118, 11);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(58, 22);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnOK.DialogResult = DialogResult.OK;
      this.btnOK.Location = new Point(54, 11);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(58, 22);
      this.btnOK.TabIndex = 0;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.groupBox1.Controls.Add((Control) this.treeView);
      this.groupBox1.Dock = DockStyle.Fill;
      this.groupBox1.Location = new Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(228, 333);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.treeView.BorderStyle = BorderStyle.None;
      this.treeView.Dock = DockStyle.Fill;
      this.treeView.FullRowSelect = true;
      this.treeView.HideSelection = false;
      this.treeView.Location = new Point(3, 16);
      this.treeView.Name = "treeView";
      this.treeView.ShowNodeToolTips = true;
      this.treeView.Size = new Size(222, 314);
      this.treeView.TabIndex = 2;
      this.treeView.DoubleClick += new EventHandler(this.treeView_DoubleClick);
      this.treeView.AfterSelect += new TreeViewEventHandler(this.treeView_AfterSelect);
      this.AcceptButton = (IButtonControl) this.btnOK;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(228, 374);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.panel);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DataSeriesCalendarForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Data Series Calendar";
      this.panel.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
