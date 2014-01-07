// Type: OpenQuant.ExpandableTabControl
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant
{
  public class ExpandableTabControl : TabControl
  {
    private const bool DEFAULT_EXPANDED = true;
    private bool expanded;
    private int expandedHeight;
    private IContainer components;
    private ImageList images;

    [DefaultValue(true)]
    public bool Expanded
    {
      get
      {
        return this.expanded;
      }
      set
      {
        if (this.expanded == value)
          return;
        this.expanded = value;
        this.UpdateView();
      }
    }

    public ExpandableTabControl()
    {
      this.InitializeComponent();
      this.expanded = true;
      this.expandedHeight = this.Height;
      this.UpdateView();
    }

    protected override void OnCreateControl()
    {
      this.UpdateView();
      base.OnCreateControl();
    }

    protected override void OnSizeChanged(EventArgs e)
    {
      if (this.expanded)
        this.expandedHeight = this.Height;
      base.OnSizeChanged(e);
    }

    protected override void OnClick(EventArgs e)
    {
      this.Expanded = !this.Expanded;
      base.OnClick(e);
    }

    private void UpdateView()
    {
      this.Height = this.expanded ? this.expandedHeight : this.ItemSize.Height + 2;
      this.UpdateImage();
      this.UpdateToolTipText();
    }

    private void UpdateImage()
    {
      int num;
      switch (this.Alignment)
      {
        case TabAlignment.Top:
          num = this.expanded ? 1 : 0;
          break;
        case TabAlignment.Bottom:
          num = this.expanded ? 0 : 1;
          break;
        default:
          throw new ArgumentException(string.Format("Unsupported Aligment - {0}", (object) this.Alignment));
      }
      if (this.TabPages.Count <= 0)
        return;
      this.TabPages[0].ImageIndex = num;
    }

    private void UpdateToolTipText()
    {
      if (this.TabPages.Count <= 0)
        return;
      if (this.expanded)
        this.TabPages[0].ToolTipText = "Collapse";
      else
        this.TabPages[0].ToolTipText = "Expand";
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ExpandableTabControl));
      this.images = new ImageList(this.components);
      this.SuspendLayout();
      this.images.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("images.ImageStream");
      this.images.TransparentColor = Color.Transparent;
      this.images.Images.SetKeyName(0, "up.png");
      this.images.Images.SetKeyName(1, "down.png");
      this.ImageList = this.images;
      this.ShowToolTips = true;
      this.ResumeLayout(false);
    }
  }
}
