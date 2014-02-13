using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TD.SandDock.Rendering;

namespace OpenQuant.Shared.Options
{
  public class LayoutOptionsPanel : OptionsPanel
  {
    private IContainer components;

    private GroupBox groupBox1;
    private RadioButton rbnOffice2003;
    private RadioButton rbnVisualStudio2005;
    private RadioButton rbnVisualStudio2002;
    private GroupBox groupBox2;
    private ComboBox cbxColorSchemes;
    private GroupBox groupBox4;
    private CheckBox chbIntegralClose;

    public LayoutOptionsPanel()
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
      this.groupBox1 = new GroupBox();
      this.rbnOffice2003 = new RadioButton();
      this.rbnVisualStudio2005 = new RadioButton();
      this.rbnVisualStudio2002 = new RadioButton();
      this.groupBox2 = new GroupBox();
      this.cbxColorSchemes = new ComboBox();
      this.groupBox4 = new GroupBox();
      this.chbIntegralClose = new CheckBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.rbnOffice2003);
      this.groupBox1.Controls.Add((Control) this.rbnVisualStudio2005);
      this.groupBox1.Controls.Add((Control) this.rbnVisualStudio2002);
      this.groupBox1.Location = new Point(8, 8);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(384, 101);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Style";
      this.rbnOffice2003.AutoSize = true;
      this.rbnOffice2003.Location = new Point(16, 72);
      this.rbnOffice2003.Name = "rbnOffice2003";
      this.rbnOffice2003.Size = new Size(80, 17);
      this.rbnOffice2003.TabIndex = 2;
      this.rbnOffice2003.TabStop = true;
      this.rbnOffice2003.Text = "Office 2003";
      this.rbnOffice2003.UseVisualStyleBackColor = true;
      this.rbnOffice2003.CheckedChanged += new EventHandler(this.rbnOffice2003_CheckedChanged);
      this.rbnVisualStudio2005.AutoSize = true;
      this.rbnVisualStudio2005.Location = new Point(16, 48);
      this.rbnVisualStudio2005.Name = "rbnVisualStudio2005";
      this.rbnVisualStudio2005.Size = new Size(113, 17);
      this.rbnVisualStudio2005.TabIndex = 1;
      this.rbnVisualStudio2005.TabStop = true;
      this.rbnVisualStudio2005.Text = "Visual Studio 2005";
      this.rbnVisualStudio2005.UseVisualStyleBackColor = true;
      this.rbnVisualStudio2005.CheckedChanged += new EventHandler(this.rbnVisualStudio2005_CheckedChanged);
      this.rbnVisualStudio2002.AutoSize = true;
      this.rbnVisualStudio2002.Location = new Point(16, 24);
      this.rbnVisualStudio2002.Name = "rbnVisualStudio2002";
      this.rbnVisualStudio2002.Size = new Size(113, 17);
      this.rbnVisualStudio2002.TabIndex = 0;
      this.rbnVisualStudio2002.TabStop = true;
      this.rbnVisualStudio2002.Text = "Visual Studio 2002";
      this.rbnVisualStudio2002.UseVisualStyleBackColor = true;
      this.rbnVisualStudio2002.CheckedChanged += new EventHandler(this.rbnVisualStudio2002_CheckedChanged);
      this.groupBox2.Controls.Add((Control) this.cbxColorSchemes);
      this.groupBox2.Location = new Point(8, 112);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(384, 58);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Color Scheme";
      this.cbxColorSchemes.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbxColorSchemes.FormattingEnabled = true;
      this.cbxColorSchemes.Location = new Point(16, 24);
      this.cbxColorSchemes.Name = "cbxColorSchemes";
      this.cbxColorSchemes.Size = new Size(181, 21);
      this.cbxColorSchemes.Sorted = true;
      this.cbxColorSchemes.TabIndex = 0;
      this.cbxColorSchemes.SelectedIndexChanged += new EventHandler(this.cbxColorSchemes_SelectedIndexChanged);
      this.groupBox4.Controls.Add((Control) this.chbIntegralClose);
      this.groupBox4.Location = new Point(8, 174);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(384, 58);
      this.groupBox4.TabIndex = 3;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Document";
      this.chbIntegralClose.Location = new Point(16, 24);
      this.chbIntegralClose.Name = "chbIntegralClose";
      this.chbIntegralClose.Size = new Size(209, 21);
      this.chbIntegralClose.TabIndex = 0;
      this.chbIntegralClose.Text = "Integral Tab Close Buttons";
      this.chbIntegralClose.UseVisualStyleBackColor = true;
      this.chbIntegralClose.CheckedChanged += new EventHandler(this.chbIntegralClose_CheckedChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.BackColor = SystemColors.Control;
      this.Controls.Add((Control) this.groupBox4);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Name = "LayoutOptionsPanel";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    protected override void OnInit()
    {
      LayoutOptions layoutOptions = (LayoutOptions) this.Options;
      LayoutRenderer renderer = layoutOptions.Renderer;
      this.rbnVisualStudio2002.Checked = renderer == LayoutRenderer.VisualStudio2002;
      this.rbnVisualStudio2005.Checked = renderer == LayoutRenderer.VisualStudio2005;
      this.rbnOffice2003.Checked = renderer == LayoutRenderer.Office2003;
      this.cbxColorSchemes.BeginUpdate();
      this.cbxColorSchemes.Items.Clear();
      foreach (WindowsColorScheme windowsColorScheme in Enum.GetValues(typeof (WindowsColorScheme)))
        this.cbxColorSchemes.Items.Add((object) windowsColorScheme);
      this.cbxColorSchemes.SelectedItem = (object) layoutOptions.ColorScheme;
      this.cbxColorSchemes.EndUpdate();
      this.chbIntegralClose.Checked = layoutOptions.IntegralClose;
    }

    protected override void OnCommitChanges()
    {
      this.Options.Save();
    }

    protected override void OnCancelChanges()
    {
      ((LayoutOptions) this.Options).Restore();
    }

    private void rbnVisualStudio2002_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.rbnVisualStudio2002.Checked)
        return;
      this.UpdateRenderer(LayoutRenderer.VisualStudio2002);
    }

    private void rbnVisualStudio2005_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.rbnVisualStudio2005.Checked)
        return;
      this.UpdateRenderer(LayoutRenderer.VisualStudio2005);
    }

    private void rbnOffice2003_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.rbnOffice2003.Checked)
        return;
      this.UpdateRenderer(LayoutRenderer.Office2003);
    }

    private void cbxColorSchemes_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.UpdateColorScheme((WindowsColorScheme) this.cbxColorSchemes.SelectedItem);
    }

    private void chbIntegralClose_CheckedChanged(object sender, EventArgs e)
    {
      this.UpdateIntegralClose(this.chbIntegralClose.Checked);
    }

    private void UpdateRenderer(LayoutRenderer renderer)
    {
      LayoutOptions layoutOptions = (LayoutOptions) this.Options;
      if (layoutOptions.Renderer == renderer)
        return;
      layoutOptions.Renderer = renderer;
      layoutOptions.Apply();
      this.OptionsChanged = true;
    }

    private void UpdateColorScheme(WindowsColorScheme scheme)
    {
      LayoutOptions layoutOptions = (LayoutOptions) this.Options;
      if (layoutOptions.ColorScheme == scheme)
        return;
      layoutOptions.ColorScheme = scheme;
      layoutOptions.Apply();
      this.OptionsChanged = true;
    }

    private void UpdateIntegralClose(bool value)
    {
      LayoutOptions layoutOptions = (LayoutOptions) this.Options;
      if (layoutOptions.IntegralClose == value)
        return;
      layoutOptions.IntegralClose = value;
      layoutOptions.Apply();
      this.OptionsChanged = true;
    }
  }
}
