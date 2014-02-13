using OpenQuant.Shared;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Charting
{
  internal class ChartColorTemplateViewItem : ListViewItem
  {
    private ChartColorTemplate template;

    public ChartColorTemplate Template
    {
      get
      {
        return this.template;
      }
    }

    public ChartColorTemplateViewItem(ChartColorTemplate template)
      : base(template.Name, 0)
    {
      this.template = template;
      this.CheckDefault();
    }

    public void CheckDefault()
    {
      if (this.template == Global.ChartManager.ColorTemplates.DefaultTemplate)
      {
        this.ForeColor = Color.Blue;
      }
      else
      {
        if (!(this.ForeColor != Color.Black))
          return;
        this.ForeColor = Color.Black;
      }
    }
  }
}
