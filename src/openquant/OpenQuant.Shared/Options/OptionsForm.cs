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
        private IContainer components = null;
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.trvOptions = new System.Windows.Forms.TreeView();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.gbxBottom = new System.Windows.Forms.GroupBox();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnOk);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(8, 372);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(623, 47);
            this.pnlBottom.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(528, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 24);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(440, 16);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(76, 24);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // trvOptions
            // 
            this.trvOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvOptions.HideSelection = false;
            this.trvOptions.Location = new System.Drawing.Point(8, 8);
            this.trvOptions.Name = "trvOptions";
            this.trvOptions.Size = new System.Drawing.Size(215, 364);
            this.trvOptions.TabIndex = 1;
            this.trvOptions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvOptions_AfterSelect);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(223, 8);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(8, 364);
            this.pnlLeft.TabIndex = 2;
            // 
            // gbxBottom
            // 
            this.gbxBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxBottom.Location = new System.Drawing.Point(231, 368);
            this.gbxBottom.Name = "gbxBottom";
            this.gbxBottom.Size = new System.Drawing.Size(400, 4);
            this.gbxBottom.TabIndex = 3;
            this.gbxBottom.TabStop = false;
            // 
            // pnlOptions
            // 
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptions.Location = new System.Drawing.Point(231, 8);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(400, 360);
            this.pnlOptions.TabIndex = 4;
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(639, 427);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.gbxBottom);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.trvOptions);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

    }

  }
}
