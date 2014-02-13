using OpenQuant.Shared;
using OpenQuant.Shared.Plugins;
using FreeQuant;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace OpenQuant.Shared.Options
{
  class ProvidersOptionsPanel : OptionsPanel
  {
    private IContainer components;
    private TabControl tabControl;
    private TabPage tabSQ;
    private TabPage tabOQ;
    private ListView ltvPlugins_SQ;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ListView ltvPlugins_OQ;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private Panel panel2;
    private Button btnRemove;
    private Button btnAdd;
    private ImageList images;
    private OpenFileDialog dlgOpenUserPlugin;
    private Panel panel1;
    private Label label1;
    private NumericUpDown nudTimeout;
    private ColumnHeader columnHeader5;
    private bool ignoreCheckEvent;

    public ProvidersOptionsPanel()
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
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ProvidersOptionsPanel));
      this.tabControl = new TabControl();
      this.tabSQ = new TabPage();
      this.ltvPlugins_SQ = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader5 = new ColumnHeader();
      this.images = new ImageList(this.components);
      this.tabOQ = new TabPage();
      this.ltvPlugins_OQ = new ListView();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.panel2 = new Panel();
      this.btnRemove = new Button();
      this.btnAdd = new Button();
      this.dlgOpenUserPlugin = new OpenFileDialog();
      this.panel1 = new Panel();
      this.nudTimeout = new NumericUpDown();
      this.label1 = new Label();
      this.tabControl.SuspendLayout();
      this.tabSQ.SuspendLayout();
      this.tabOQ.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.nudTimeout.BeginInit();
      this.SuspendLayout();
      this.tabControl.Controls.Add((Control) this.tabSQ);
      this.tabControl.Controls.Add((Control) this.tabOQ);
      this.tabControl.Dock = DockStyle.Fill;
      this.tabControl.Location = new Point(0, 0);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new Size(400, 324);
      this.tabControl.TabIndex = 0;
      this.tabControl.SelectedIndexChanged += new EventHandler(this.tabControl_SelectedIndexChanged);
      this.tabControl.Selected += new TabControlEventHandler(this.tabControl_Selected);
      this.tabSQ.Controls.Add((Control) this.ltvPlugins_SQ);
      this.tabSQ.Location = new Point(4, 22);
      this.tabSQ.Name = "tabSQ";
      this.tabSQ.Padding = new Padding(3);
      this.tabSQ.Size = new Size(392, 298);
      this.tabSQ.TabIndex = 0;
      this.tabSQ.Text = "Built-in";
      this.tabSQ.UseVisualStyleBackColor = true;
      this.ltvPlugins_SQ.BorderStyle = BorderStyle.None;
      this.ltvPlugins_SQ.CheckBoxes = true;
      this.ltvPlugins_SQ.Columns.AddRange(new ColumnHeader[3]
      {
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader5
      });
      this.ltvPlugins_SQ.Dock = DockStyle.Fill;
      this.ltvPlugins_SQ.FullRowSelect = true;
      this.ltvPlugins_SQ.GridLines = true;
      this.ltvPlugins_SQ.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ltvPlugins_SQ.HideSelection = false;
      this.ltvPlugins_SQ.Location = new Point(3, 3);
      this.ltvPlugins_SQ.MultiSelect = false;
      this.ltvPlugins_SQ.Name = "ltvPlugins_SQ";
      this.ltvPlugins_SQ.ShowGroups = false;
      this.ltvPlugins_SQ.ShowItemToolTips = true;
      this.ltvPlugins_SQ.Size = new Size(386, 292);
      this.ltvPlugins_SQ.SmallImageList = this.images;
      this.ltvPlugins_SQ.Sorting = SortOrder.Ascending;
      this.ltvPlugins_SQ.TabIndex = 0;
      this.ltvPlugins_SQ.UseCompatibleStateImageBehavior = false;
      this.ltvPlugins_SQ.View = View.Details;
      this.ltvPlugins_SQ.ItemCheck += new ItemCheckEventHandler(this.ltvPlugins_SQ_ItemCheck);
      this.columnHeader1.Text = "TypeName";
      this.columnHeader1.Width = 159;
      this.columnHeader2.Text = "AssemblyName";
      this.columnHeader2.TextAlign = HorizontalAlignment.Right;
      this.columnHeader2.Width = 134;
      this.columnHeader5.Text = "x64";
      this.columnHeader5.TextAlign = HorizontalAlignment.Center;
      this.images.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("images.ImageStream");
      this.images.TransparentColor = Color.Transparent;
      this.images.Images.SetKeyName(0, "plugin_unloaded.ico");
      this.images.Images.SetKeyName(1, "plugin_loaded.png");
      this.images.Images.SetKeyName(2, "plugin_error.png");
      this.tabOQ.Controls.Add((Control) this.ltvPlugins_OQ);
      this.tabOQ.Controls.Add((Control) this.panel2);
      this.tabOQ.Location = new Point(4, 22);
      this.tabOQ.Name = "tabOQ";
      this.tabOQ.Padding = new Padding(3);
      this.tabOQ.Size = new Size(392, 298);
      this.tabOQ.TabIndex = 1;
      this.tabOQ.Text = "User";
      this.tabOQ.UseVisualStyleBackColor = true;
      this.ltvPlugins_OQ.BorderStyle = BorderStyle.None;
      this.ltvPlugins_OQ.CheckBoxes = true;
      this.ltvPlugins_OQ.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader3,
        this.columnHeader4
      });
      this.ltvPlugins_OQ.Dock = DockStyle.Fill;
      this.ltvPlugins_OQ.FullRowSelect = true;
      this.ltvPlugins_OQ.GridLines = true;
      this.ltvPlugins_OQ.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.ltvPlugins_OQ.HideSelection = false;
      this.ltvPlugins_OQ.Location = new Point(3, 3);
      this.ltvPlugins_OQ.MultiSelect = false;
      this.ltvPlugins_OQ.Name = "ltvPlugins_OQ";
      this.ltvPlugins_OQ.ShowGroups = false;
      this.ltvPlugins_OQ.ShowItemToolTips = true;
      this.ltvPlugins_OQ.Size = new Size(386, 256);
      this.ltvPlugins_OQ.SmallImageList = this.images;
      this.ltvPlugins_OQ.Sorting = SortOrder.Ascending;
      this.ltvPlugins_OQ.TabIndex = 1;
      this.ltvPlugins_OQ.UseCompatibleStateImageBehavior = false;
      this.ltvPlugins_OQ.View = View.Details;
      this.ltvPlugins_OQ.ItemCheck += new ItemCheckEventHandler(this.ltvPlugins_OQ_ItemCheck);
      this.columnHeader3.Text = "TypeName";
      this.columnHeader3.Width = 210;
      this.columnHeader4.Text = "AssemblyName";
      this.columnHeader4.TextAlign = HorizontalAlignment.Right;
      this.columnHeader4.Width = 141;
      this.panel2.Controls.Add((Control) this.btnRemove);
      this.panel2.Controls.Add((Control) this.btnAdd);
      this.panel2.Dock = DockStyle.Bottom;
      this.panel2.Location = new Point(3, 259);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(386, 36);
      this.panel2.TabIndex = 3;
      this.btnRemove.Location = new Point(81, 8);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new Size(67, 22);
      this.btnRemove.TabIndex = 1;
      this.btnRemove.Text = "Remove";
      this.btnRemove.UseVisualStyleBackColor = true;
      this.btnRemove.Click += new EventHandler(this.btnRemove_Click);
      this.btnAdd.Location = new Point(8, 8);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new Size(67, 22);
      this.btnAdd.TabIndex = 0;
      this.btnAdd.Text = "Add...";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
      this.dlgOpenUserPlugin.Filter = "Assemblies|*.dll";
      this.dlgOpenUserPlugin.Title = "Select custom provider assembly";
      this.panel1.Controls.Add((Control) this.nudTimeout);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Dock = DockStyle.Bottom;
      this.panel1.Location = new Point(0, 324);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(400, 32);
      this.panel1.TabIndex = 1;
      this.nudTimeout.Location = new Point(150, 8);
      NumericUpDown numericUpDown1 = this.nudTimeout;
      int[] bits1 = new int[4];
      bits1[0] = 10000;
      Decimal num1 = new Decimal(bits1);
      numericUpDown1.Maximum = num1;
      NumericUpDown numericUpDown2 = this.nudTimeout;
      int[] bits2 = new int[4];
      bits2[0] = 1;
      Decimal num2 = new Decimal(bits2);
      numericUpDown2.Minimum = num2;
      this.nudTimeout.Name = "nudTimeout";
      this.nudTimeout.Size = new Size(47, 20);
      this.nudTimeout.TabIndex = 1;
      this.nudTimeout.TextAlign = HorizontalAlignment.Center;
      NumericUpDown numericUpDown3 = this.nudTimeout;
      int[] bits3 = new int[4];
      bits3[0] = 1;
      Decimal num3 = new Decimal(bits3);
      numericUpDown3.Value = num3;
      this.nudTimeout.ValueChanged += new EventHandler(this.nudTimeout_ValueChanged);
      this.label1.Location = new Point(8, 8);
      this.label1.Name = "label1";
      this.label1.Size = new Size(136, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Connection timeout (sec)";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.Controls.Add((Control) this.tabControl);
      this.Controls.Add((Control) this.panel1);
      this.Name = "ProvidersOptionsPanel";
      this.Padding = new Padding(0, 0, 0, 4);
      this.tabControl.ResumeLayout(false);
      this.tabSQ.ResumeLayout(false);
      this.tabOQ.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.nudTimeout.EndInit();
      this.ResumeLayout(false);
    }

    protected override void OnLoad(EventArgs e)
    {
      this.ignoreCheckEvent = false;
      base.OnLoad(e);
    }

    protected override void OnInit()
    {
      this.ignoreCheckEvent = true;
      this.ltvPlugins_SQ.BeginUpdate();
      this.ltvPlugins_SQ.Items.Clear();
      foreach (Plugin plugin in (ReadOnlyCollectionBase) Framework.Configuration.Plugins)
        this.ltvPlugins_SQ.Items.Add((ListViewItem) new PluginSQViewItem(plugin));
      this.ltvPlugins_SQ.EndUpdate();
      this.ltvPlugins_OQ.BeginUpdate();
      this.ltvPlugins_OQ.Items.Clear();
      foreach (PluginInfo plugin in Global.PluginManager.Plugins)
        this.ltvPlugins_OQ.Items.Add((ListViewItem) new PluginOQViewItem(plugin));
      this.ltvPlugins_OQ.EndUpdate();
      this.nudTimeout.Value = (Decimal) ((ProvidersOptions) this.Options).ConnectionTimeout;
      base.OnInit();
    }

    protected override void OnCommitChanges()
    {
      foreach (PluginSQViewItem pluginSqViewItem in this.ltvPlugins_SQ.Items)
				pluginSqViewItem.Plugin.Enabled = pluginSqViewItem.Checked;
      Global.PluginManager.Plugins.Clear();
      foreach (PluginOQViewItem pluginOqViewItem in this.ltvPlugins_OQ.Items)
      {
        pluginOqViewItem.Plugin.Enabled = pluginOqViewItem.Checked;
        Global.PluginManager.Plugins.Add(pluginOqViewItem.Plugin);
      }
      Global.PluginManager.SaveConfig();
      ((ProvidersOptions) this.Options).ConnectionTimeout = (int) this.nudTimeout.Value;
      this.Options.Save();
      base.OnCommitChanges();
    }

    private void tabControl_Selected(object sender, TabControlEventArgs e)
    {
      this.ignoreCheckEvent = true;
    }

    private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.ignoreCheckEvent = false;
    }

    private void ltvPlugins_SQ_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      if (this.ignoreCheckEvent)
        return;
      PluginSQViewItem pluginSqViewItem = (PluginSQViewItem) this.ltvPlugins_SQ.Items[e.Index];
      Plugin plugin = pluginSqViewItem.Plugin;
      if (e.NewValue == CheckState.Unchecked && this.IsPluginInUse(plugin))
      {
        int num = (int) MessageBox.Show((IWin32Window) this, "Cannot disable provider because it is used in one of configuration modes.", "Cannot Disable Provider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.NewValue = CheckState.Checked;
      }
      else
      {
        if (e.NewValue == CheckState.Checked && !plugin.Loaded)
        {
          Framework.LoadPlugin(plugin);
          pluginSqViewItem.UpdateIcon(true);
        }
        this.OptionsChanged = true;
      }
    }

    private void ltvPlugins_OQ_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      if (this.ignoreCheckEvent)
        return;
      PluginOQViewItem pluginOqViewItem = (PluginOQViewItem) this.ltvPlugins_OQ.Items[e.Index];
      PluginInfo plugin = pluginOqViewItem.Plugin;
      if (e.NewValue == CheckState.Unchecked && this.IsPluginInUse(plugin))
      {
        int num = (int) MessageBox.Show((IWin32Window) this, "Cannot disable provider because it is used in one of configuration modes.", "Cannot Disable Provider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.NewValue = CheckState.Checked;
      }
      else
      {
        if (e.NewValue == CheckState.Checked && !plugin.Loaded)
        {
          Global.PluginManager.LoadPlugin(plugin);
          pluginOqViewItem.UpdateIcon();
        }
        this.OptionsChanged = true;
      }
    }

    private bool IsPluginInUse(Plugin plugin)
    {
      return this.IsPluginInUse(plugin.TypeName, plugin.AssemblyName);
    }

    private bool IsPluginInUse(PluginInfo plugin)
    {
      return this.IsPluginInUse(plugin.TypeName, plugin.AssemblyName);
    }

    private bool IsPluginInUse(string typeName, string assemblyName)
    {
      return ((ProvidersOptions) this.Options).IsPluginInUse(typeName, assemblyName);
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      this.AddUserPlugin();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      this.RemoveUserPlugin();
    }

    private void AddUserPlugin()
    {
      if (MessageBox.Show((IWin32Window) this, string.Format("Warning! You should copy provider dll to the bin folder: {1}{0}{1} and load the dll from this folder.", (object) ((ProvidersOptions) this.Options).BinDirectory.FullName, (object) Environment.NewLine), "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
        return;
      this.dlgOpenUserPlugin.InitialDirectory = ((ProvidersOptions) this.Options).BinDirectory.FullName;
      if (this.dlgOpenUserPlugin.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      PluginInfo[] plugins = this.ExtractPlugins(this.dlgOpenUserPlugin.FileName, PluginType.UserProvider);
      if (plugins.Length == 0)
      {
        int num1 = (int) MessageBox.Show((IWin32Window) this, "No plugins found.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        int num2 = 0;
        int num3 = 0;
        foreach (PluginInfo pluginInfo in plugins)
        {
          bool flag = false;
          foreach (PluginOQViewItem pluginOqViewItem in this.ltvPlugins_OQ.Items)
          {
            if (this.Equals(pluginInfo, pluginOqViewItem.Plugin))
            {
              flag = true;
              break;
            }
          }
          if (flag)
          {
            ++num3;
          }
          else
          {
            this.ltvPlugins_OQ.Items.Add((ListViewItem) new PluginOQViewItem(pluginInfo));
            ++num2;
          }
        }
        if (num2 > 0)
          this.OptionsChanged = true;
        int num4 = (int) MessageBox.Show((IWin32Window) this, string.Format("Total plugins: {0}, added: {1}, already exists: {2}", (object) plugins.Length, (object) num2, (object) num3), "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private PluginInfo[] ExtractPlugins(string filename, PluginType pluginType)
    {
      List<PluginInfo> list = new List<PluginInfo>();
      System.Type pluginBaseType = Global.PluginManager.GetPluginBaseType(pluginType);
      try
      {
        AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += new ResolveEventHandler(this.CurrentDomain_ReflectionOnlyAssemblyResolve);
        Assembly assembly = Assembly.ReflectionOnlyLoad(AssemblyName.GetAssemblyName(filename).FullName);
        foreach (System.Type type in assembly.GetTypes())
        {
          if (type.BaseType != (System.Type) null && type.BaseType.GUID == pluginBaseType.GUID)
          {
            PluginInfo pluginInfo = new PluginInfo(pluginType, type.FullName, assembly.GetName().Name);
            list.Add(pluginInfo);
          }
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show((IWin32Window) this, ((object) ex).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        list.Clear();
      }
      finally
      {
        AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve -= new ResolveEventHandler(this.CurrentDomain_ReflectionOnlyAssemblyResolve);
      }
      return list.ToArray();
    }

    private Assembly CurrentDomain_ReflectionOnlyAssemblyResolve(object sender, ResolveEventArgs args)
    {
      return Assembly.ReflectionOnlyLoad(args.Name);
    }

    private void RemoveUserPlugin()
    {
      if (this.ltvPlugins_OQ.SelectedItems.Count == 1)
      {
        PluginOQViewItem pluginOqViewItem = (PluginOQViewItem) this.ltvPlugins_OQ.SelectedItems[0];
        PluginInfo plugin = pluginOqViewItem.Plugin;
        if (MessageBox.Show((IWin32Window) this, string.Format("Are you sure to remove {0}, {1} ?", (object) plugin.TypeName, (object) plugin.AssemblyName), "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
        pluginOqViewItem.Remove();
        this.OptionsChanged = true;
      }
      else
      {
        int num = (int) MessageBox.Show((IWin32Window) this, "No provider selected.", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private bool Equals(PluginInfo plugin1, PluginInfo plugin2)
    {
      if (plugin1.TypeName == plugin2.TypeName)
        return plugin1.AssemblyName == plugin2.AssemblyName;
      else
        return false;
    }

    private void nudTimeout_ValueChanged(object sender, EventArgs e)
    {
      if (this.ignoreCheckEvent)
        return;
      this.OptionsChanged = true;
    }
  }
}
