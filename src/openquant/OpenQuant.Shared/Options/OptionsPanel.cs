using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Options
{
  public class OptionsPanel : UserControl
  {
    private OptionsBase options;
    private bool optionsChanged;
    private bool isInitializing;
    private IContainer components;

    protected OptionsBase Options
    {
      get
      {
        return this.options;
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    protected internal bool OptionsChanged
    {
      get
      {
        return this.optionsChanged;
      }
      set
      {
        if (this.isInitializing)
          return;
        this.optionsChanged = value;
      }
    }

    public OptionsPanel()
    {
      this.InitializeComponent();
      this.optionsChanged = false;
    }

    internal void Init(OptionsBase options)
    {
      this.isInitializing = true;
      this.options = options;
      this.OnInit();
      this.isInitializing = false;
    }

    protected virtual void OnInit()
    {
    }

    internal void CommitChanges()
    {
      this.OnCommitChanges();
    }

    protected virtual void OnCommitChanges()
    {
    }

    internal void CancelChanges()
    {
      this.OnCancelChanges();
    }

    protected virtual void OnCancelChanges()
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.SuspendLayout();
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Name = "OptionsPanel";
      this.Size = new Size(400, 360);
      this.ResumeLayout(false);
    }
  }
}
