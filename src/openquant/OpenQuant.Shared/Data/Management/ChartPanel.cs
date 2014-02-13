using OpenQuant.Shared.Charting;
using FreeQuant.Data;
using System.ComponentModel;
using System.Windows.Forms;

namespace OpenQuant.Shared.Data.Management
{
  internal class ChartPanel : UserControl
  {
    private IContainer components;
    protected IDataSeries dataSeries;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public virtual Chart ChartControl
    {
      get
      {
        return (Chart) null;
      }
    }

    public ChartPanel()
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
      this.AutoScaleMode = AutoScaleMode.Font;
    }

    protected virtual void OnInit()
    {
    }

    public void Init(IDataSeries dataSeries)
    {
      this.dataSeries = dataSeries;
      this.OnInit();
    }
  }
}
