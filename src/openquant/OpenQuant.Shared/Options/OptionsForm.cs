using OpenQuant.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Options
{
  public class OptionsForm : Form
  {
    private Dictionary<System.Type, OptionsPanel> optionsPanels;
    private Dictionary<System.Type, OptionsNode> optionsNodes;
    private System.Type selectedOptionsType;
    private IContainer components;
    private Panel pnlBottom;
    private TreeView trvOptions;
    private Panel pnlLeft;
    private GroupBox gbxBottom;
    private Panel pnlOptions;
    private Button btnCancel;
    private Button btnOk;

    public OptionsForm()
    {
      this.InitializeComponent();
      this.optionsPanels = new Dictionary<System.Type, OptionsPanel>();
      this.optionsNodes = new Dictionary<System.Type, OptionsNode>();
      this.selectedOptionsType = (System.Type) null;
    }

    public void SetSelectedOptionsType(System.Type selectedOptionsType)
    {
      this.selectedOptionsType = selectedOptionsType;
    }

    protected override void OnLoad(EventArgs e)
    {
      this.AddNodes(this.trvOptions.Nodes, (OptionsBase) Global.Options);
      if (this.selectedOptionsType == (System.Type) null)
      {
        if (this.trvOptions.Nodes.Count > 0 && this.trvOptions.Nodes[0].Nodes.Count > 0)
          this.trvOptions.SelectedNode = this.trvOptions.Nodes[0].Nodes[0];
      }
      else
        this.trvOptions.SelectedNode = (TreeNode) this.optionsNodes[this.selectedOptionsType];
      base.OnLoad(e);
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      switch (this.DialogResult)
      {
        case DialogResult.OK:
          this.Save();
          break;
        case DialogResult.Cancel:
          bool flag = false;
		  foreach (OptionsPanel panel in this.optionsPanels.Values) 
          {
            if (panel.OptionsChanged)
            {
              flag = true;
              break;
            }
          }
          if (flag)
          {
            switch (MessageBox.Show(this, "Some options were changed. Do you want to save its?", "Options Changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
            {
              case DialogResult.Cancel:
                e.Cancel = true;
                break;
              case DialogResult.Yes:
                this.Save();
                break;
              case DialogResult.No:
                this.Cancel();
                break;
            }
          }
          break;
      }
      base.OnFormClosing(e);
    }

    private void AddNodes(TreeNodeCollection nodes, OptionsBase options)
    {
      foreach (OptionsBase options1 in (IEnumerable<OptionsBase>) options.SubOptions)
      {
        OptionsNode optionsNode = new OptionsNode(options1);
        nodes.Add((TreeNode) optionsNode);
        if (!this.optionsNodes.ContainsKey(options1.GetType()))
          this.optionsNodes.Add(options1.GetType(), optionsNode);
        this.AddNodes(optionsNode.Nodes, options1);
      }
      if (nodes.Count <= 0 || options is AppOptions)
        return;
      GeneralOptionsNode generalOptionsNode = new GeneralOptionsNode(options);
      nodes.Insert(0, (TreeNode) generalOptionsNode);
    }

    private void trvOptions_AfterSelect(object sender, TreeViewEventArgs e)
    {
      OptionsNode optionsNode = this.trvOptions.SelectedNode as OptionsNode;
      System.Type type = optionsNode.Options.GetType();
      this.pnlOptions.Controls.Clear();
      if (!this.optionsPanels.ContainsKey(type))
      {
        OptionsPanel optionsPanel = (OptionsPanel) Activator.CreateInstance(optionsNode.Options.PanelType);
        this.optionsPanels.Add(type, optionsPanel);
        optionsPanel.Init(optionsNode.Options);
      }
      this.pnlOptions.Controls.Add((Control) this.optionsPanels[type]);
    }

    private void Save()
    {
      foreach (OptionsPanel optionsPanel in this.optionsPanels.Values)
      {
        if (optionsPanel.OptionsChanged)
          optionsPanel.CommitChanges();
      }
    }

    private void Cancel()
    {
      foreach (OptionsPanel optionsPanel in this.optionsPanels.Values)
      {
        if (optionsPanel.OptionsChanged)
          optionsPanel.CancelChanges();
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.pnlBottom = new Panel();
      this.btnCancel = new Button();
      this.btnOk = new Button();
      this.trvOptions = new TreeView();
      this.pnlLeft = new Panel();
      this.gbxBottom = new GroupBox();
      this.pnlOptions = new Panel();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      this.pnlBottom.Controls.Add((Control) this.btnCancel);
      this.pnlBottom.Controls.Add((Control) this.btnOk);
      this.pnlBottom.Dock = DockStyle.Bottom;
      this.pnlBottom.Location = new Point(8, 372);
      this.pnlBottom.Name = "pnlBottom";
      this.pnlBottom.Size = new Size(623, 47);
      this.pnlBottom.TabIndex = 0;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      this.btnCancel.Location = new Point(528, 16);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(76, 24);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnOk.DialogResult = DialogResult.OK;
      this.btnOk.Location = new Point(440, 16);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new Size(76, 24);
      this.btnOk.TabIndex = 0;
      this.btnOk.Text = "OK";
      this.btnOk.UseVisualStyleBackColor = true;
      this.trvOptions.Dock = DockStyle.Left;
      this.trvOptions.HideSelection = false;
      this.trvOptions.Location = new Point(8, 8);
      this.trvOptions.Name = "trvOptions";
      this.trvOptions.Size = new Size(215, 364);
      this.trvOptions.TabIndex = 1;
      this.trvOptions.AfterSelect += new TreeViewEventHandler(this.trvOptions_AfterSelect);
      this.pnlLeft.Dock = DockStyle.Left;
      this.pnlLeft.Location = new Point(223, 8);
      this.pnlLeft.Name = "pnlLeft";
      this.pnlLeft.Size = new Size(8, 364);
      this.pnlLeft.TabIndex = 2;
      this.gbxBottom.Dock = DockStyle.Bottom;
      this.gbxBottom.Location = new Point(231, 368);
      this.gbxBottom.Name = "gbxBottom";
      this.gbxBottom.Size = new Size(400, 4);
      this.gbxBottom.TabIndex = 3;
      this.gbxBottom.TabStop = false;
      this.pnlOptions.Dock = DockStyle.Fill;
      this.pnlOptions.Location = new Point(231, 8);
      this.pnlOptions.Name = "pnlOptions";
      this.pnlOptions.Size = new Size(400, 360);
      this.pnlOptions.TabIndex = 4;
      this.AcceptButton = (IButtonControl) this.btnOk;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancel;
      this.ClientSize = new Size(639, 427);
      this.Controls.Add((Control) this.pnlOptions);
      this.Controls.Add((Control) this.gbxBottom);
      this.Controls.Add((Control) this.pnlLeft);
      this.Controls.Add((Control) this.trvOptions);
      this.Controls.Add((Control) this.pnlBottom);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "OptionsForm";
      this.Padding = new Padding(8);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Options";
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
