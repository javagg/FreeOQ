using System;
using System.Drawing;
using System.Windows.Forms;

namespace OpenQuant.Shared.Charting
{
  internal class ChartColorPropertyViewItem : ListViewItem
  {
    private Color color;
    private string propertyName;

    public string PropertyName
    {
      get
      {
        return this.propertyName;
      }
      set
      {
        this.propertyName = value;
      }
    }

    public Color Color
    {
      get
      {
        return this.color;
      }
      set
      {
        this.color = value;
        if (this.ColorChanged == null)
          return;
        this.ColorChanged(this, null);
      }
    }

    public event EventHandler ColorChanged;

    public ChartColorPropertyViewItem(string propertyName, string displayName, Color color)
      : base(displayName, 0)
    {
      this.color = color;
      this.propertyName = propertyName;
    }
  }
}
