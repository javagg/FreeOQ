using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace OpenQuant.Shared.Charting
{
  internal class ColorEditor : ComboBox
  {
    private Dictionary<string, Color> colors = new Dictionary<string, Color>();

    public ColorEditor()
    {
      this.DrawMode = DrawMode.OwnerDrawFixed;
      this.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    public void Init()
    {
      List<Color> list = new List<Color>();
      foreach (PropertyInfo propertyInfo in typeof (Color).GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.GetProperty))
      {
        if (propertyInfo.PropertyType == typeof (Color))
        {
          Color color = (Color) propertyInfo.GetValue((object) typeof (Color), (object[]) null);
          this.colors[(string) (object) color.A + (object) ", " + (string) (object) color.R + ", " + (string) (object) color.G + ", " + (string) (object) color.B] = color;
          list.Add(color);
        }
      }
      list.Sort((IComparer<Color>) new ColorComparer());
      foreach (Color color in list)
        this.Items.Add((object) color);
    }

    public void Select(Color color)
    {
      this.SelectedItem = (object) this.colors[(string) (object) color.A + (object) ", " + (string) (object) color.R + ", " + (string) (object) color.G + ", " + (string) (object) color.B];
    }

    protected override void OnDrawItem(DrawItemEventArgs e)
    {
      if (e.Index == -1)
        return;
      e.DrawBackground();
      Color color = (Color) this.Items[e.Index];
      Brush brush = (Brush) new SolidBrush(color);
      int num1 = 3;
      int height = e.Bounds.Height - 2 * num1;
      int num2 = 5;
      string str = color.ToString().Remove(0, 7).TrimEnd(new char[1]
      {
        ']'
      });
      Rectangle rect = new Rectangle(e.Bounds.X + num1, e.Bounds.Y + num1, height + 2, height);
      int num3 = (int) e.Graphics.MeasureString(str, e.Font).Height;
      e.Graphics.DrawString(str, e.Font, Brushes.Black, (float) (e.Bounds.X + num1 + height + num2), (float) (e.Bounds.Y + (e.Bounds.Height - num3) / 2 + 1));
      e.Graphics.FillRectangle(brush, rect);
      e.Graphics.DrawRectangle(new Pen(Color.Black), rect);
      e.DrawFocusRectangle();
    }
  }
}
