// Type: OpenQuant.Projects.UI.UserCommandsWindow
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Projects;
using OpenQuant.Properties;
using OpenQuant.Trading;
using SmartQuant.Docking.WinForms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock;

namespace OpenQuant.Projects.UI
{
  internal class UserCommandsWindow : DockControl
  {
    private IContainer components;
    private GroupBox groupBox1;
    private ListView ltvUserCommands;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private TextBox tbxUserCommand;
    private Button btnSend;
    private string strategy;

    public UserCommandsWindow()
    {
      base.\u002Ector();
      this.InitializeComponent();
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      ((DockControl) this).Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupBox1 = new GroupBox();
      this.btnSend = new Button();
      this.tbxUserCommand = new TextBox();
      this.ltvUserCommands = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.groupBox1.SuspendLayout();
      ((Control) this).SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.btnSend);
      this.groupBox1.Controls.Add((Control) this.tbxUserCommand);
      this.groupBox1.Dock = DockStyle.Bottom;
      this.groupBox1.Location = new Point(0, 214);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(739, 63);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Command";
      this.btnSend.Location = new Point(388, 24);
      this.btnSend.Name = "btnSend";
      this.btnSend.Size = new Size(84, 22);
      this.btnSend.TabIndex = 2;
      this.btnSend.Text = "Send";
      this.btnSend.UseVisualStyleBackColor = true;
      this.btnSend.Click += new EventHandler(this.btnSend_Click);
      this.tbxUserCommand.HideSelection = false;
      this.tbxUserCommand.Location = new Point(16, 24);
      this.tbxUserCommand.Name = "tbxUserCommand";
      this.tbxUserCommand.Size = new Size(362, 20);
      this.tbxUserCommand.TabIndex = 1;
      this.tbxUserCommand.KeyDown += new KeyEventHandler(this.tbxUserCommand_KeyDown);
      this.ltvUserCommands.Columns.AddRange(new ColumnHeader[3]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3
      });
      this.ltvUserCommands.Dock = DockStyle.Fill;
      this.ltvUserCommands.FullRowSelect = true;
      this.ltvUserCommands.GridLines = true;
      this.ltvUserCommands.HideSelection = false;
      this.ltvUserCommands.Location = new Point(0, 0);
      this.ltvUserCommands.MultiSelect = false;
      this.ltvUserCommands.Name = "ltvUserCommands";
      this.ltvUserCommands.ShowGroups = false;
      this.ltvUserCommands.ShowItemToolTips = true;
      this.ltvUserCommands.Size = new Size(739, 214);
      this.ltvUserCommands.TabIndex = 2;
      this.ltvUserCommands.UseCompatibleStateImageBehavior = false;
      this.ltvUserCommands.View = View.Details;
      this.columnHeader1.Text = "DateTime";
      this.columnHeader1.Width = 141;
      this.columnHeader2.Text = "Strategy";
      this.columnHeader2.TextAlign = HorizontalAlignment.Right;
      this.columnHeader2.Width = 107;
      this.columnHeader3.Text = "Text";
      this.columnHeader3.Width = 383;
      ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Control) this).Controls.Add((Control) this.ltvUserCommands);
      ((Control) this).Controls.Add((Control) this.groupBox1);
      this.set_DefaultDockLocation((ContainerDockLocation) 4);
      ((DockControl) this).set_FloatingSize(new Size(600, 300));
      ((Control) this).Name = "UserCommandsWindow";
      ((DockControl) this).set_PersistState(false);
      ((Control) this).Size = new Size(739, 277);
      ((DockControl) this).set_TabImage((Image) Resources.user_command);
      ((Control) this).Text = "User Commands";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((Control) this).ResumeLayout(false);
    }

    protected virtual void OnInit()
    {
      if (this.get_Key() is StrategyProject)
      {
        this.strategy = ((StrategyProject) this.get_Key()).Name;
        ((Control) this).Text = string.Format("User Commands ({0})", (object) this.strategy);
        this.ltvUserCommands.Columns[1].Width = 0;
      }
      else
      {
        this.strategy = (string) null;
        ((Control) this).Text = "User Commands";
      }
      this.ltvUserCommands.BeginUpdate();
      this.ltvUserCommands.Items.Clear();
      foreach (UserCommand command in UserCommandManager.get_Commands())
        this.AddUserCommand(command);
      this.ltvUserCommands.EndUpdate();
      UserCommandManager.add_NewCommand(new EventHandler<UserCommandEventArgs>(this.UserCommandManager_NewCommand));
      UserCommandManager.add_Cleared(new EventHandler(this.UserCommandManager_Cleared));
    }

    protected virtual void OnClosing(DockControlClosingEventArgs e)
    {
      UserCommandManager.remove_NewCommand(new EventHandler<UserCommandEventArgs>(this.UserCommandManager_NewCommand));
      UserCommandManager.remove_Cleared(new EventHandler(this.UserCommandManager_Cleared));
      ((DockControl) this).OnClosing(e);
    }

    private void AddUserCommand(UserCommand command)
    {
      if (this.strategy != null && command.get_Strategy() != null && this.strategy != command.get_Strategy())
        return;
      Action action = (Action) (() => this.ltvUserCommands.Items.Add((ListViewItem) new UserCommandViewItem(command)));
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (((Control) this).InvokeRequired))
        ((Control) this).Invoke((Delegate) action);
      else
        action();
    }

    private void UserCommandManager_NewCommand(object sender, UserCommandEventArgs e)
    {
      this.AddUserCommand(e.get_Command());
    }

    private void UserCommandManager_Cleared(object sender, EventArgs e)
    {
      Action action = (Action) (() => this.ltvUserCommands.Items.Clear());
      // ISSUE: explicit non-virtual call
      if (__nonvirtual (((Control) this).InvokeRequired))
        ((Control) this).Invoke((Delegate) action);
      else
        action();
    }

    private void btnSend_Click(object sender, EventArgs e)
    {
      this.SendCommand();
    }

    private void tbxUserCommand_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData != Keys.Return)
        return;
      this.SendCommand();
    }

    private void SendCommand()
    {
      string str = this.tbxUserCommand.Text.Trim();
      if (string.IsNullOrWhiteSpace(str))
      {
        int num = (int) MessageBox.Show("Nothing to send", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        UserCommandManager.Send(this.strategy, str);
        this.tbxUserCommand.Select(0, this.tbxUserCommand.Text.Length);
      }
    }
  }
}
