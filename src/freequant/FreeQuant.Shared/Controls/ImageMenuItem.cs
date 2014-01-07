// Type: SmartQuant.Shared.Controls.ImageMenuItem
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Controls
{
  public class ImageMenuItem : MenuItem
  {
    private const int wB3JbCKRoy = 24;
    private ImageList Rj0JV9pT8G;
    private int eZfJRkVTPe;
    private int LGXJHk0oQM;

    public ImageList ImageList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Rj0JV9pT8G;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Rj0JV9pT8G = value;
      }
    }

    [DefaultValue(-1)]
    [TypeConverter(typeof (ImageIndexConverter))]
    [Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design", typeof (UITypeEditor))]
    public int ImageIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.eZfJRkVTPe;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.eZfJRkVTPe = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ImageMenuItem()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OwnerDraw = true;
      this.Rj0JV9pT8G = (ImageList) null;
      this.eZfJRkVTPe = -1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ImageMenuItem(string text)
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      this.\u002Ector();
      this.Text = text;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnMeasureItem(MeasureItemEventArgs e)
    {
      base.OnMeasureItem(e);
      Font menuFont = SystemInformation.MenuFont;
      if (this.Text == RNaihRhYEl0wUmAftnB.aYu7exFQKN(33336))
      {
        e.ItemWidth = 24;
        e.ItemHeight = 3;
      }
      else
      {
        SizeF sizeF1 = e.Graphics.MeasureString(this.Text, menuFont);
        SizeF sizeF2 = !this.ShowShortcut || this.Shortcut == Shortcut.None ? SizeF.Empty : e.Graphics.MeasureString(this.avOJF7XDrs(), menuFont);
        e.ItemWidth = 24 + (int) sizeF1.Width + (int) sizeF2.Width;
        e.ItemHeight = SystemInformation.MenuHeight;
        if (this.MenuItems.Count > 0)
          e.ItemWidth += 16;
        this.LGXJHk0oQM = (int) sizeF2.Width;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDrawItem(DrawItemEventArgs e)
    {
      base.OnDrawItem(e);
      bool flag = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
      Color color1 = SystemColors.MenuText;
      Color color2 = SystemColors.Menu;
      if (flag)
      {
        color1 = SystemColors.HighlightText;
        color2 = SystemColors.Highlight;
      }
      if (!this.Enabled)
      {
        color1 = SystemColors.GrayText;
        color2 = SystemColors.Menu;
      }
      e.Graphics.FillRectangle((Brush) new SolidBrush(color2), e.Bounds);
      if (this.Checked)
      {
        if (this.RadioCheck)
        {
          e.Graphics.FillEllipse((Brush) new SolidBrush(color1), 8, e.Bounds.Y + (e.Bounds.Height - 7) / 2, 7, 7);
        }
        else
        {
          int x2 = 12;
          int num = e.Bounds.Y + e.Bounds.Height / 2;
          Point[] points = new Point[3]
          {
            new Point(x2 - 4, num - 1),
            new Point(x2 - 2, num + 3),
            new Point(x2 + 4, num - 3)
          };
          e.Graphics.DrawLines(new Pen(color1), points);
          e.Graphics.DrawLine(new Pen(color1), x2 - 4, num + 5, x2, num + 5);
        }
      }
      if (this.eZfJRkVTPe != -1)
      {
        int x = 2;
        int y = e.Bounds.Y + (e.Bounds.Height - 16) / 2;
        if (flag && this.Enabled)
        {
          --x;
          --y;
        }
        Image image = this.Rj0JV9pT8G.Images[this.eZfJRkVTPe];
        if (this.Enabled)
          e.Graphics.DrawImage(image, x, y);
        else
          ControlPaint.DrawImageDisabled(e.Graphics, image, x, y, color2);
      }
      if (this.Text == RNaihRhYEl0wUmAftnB.aYu7exFQKN(33342))
      {
        e.Graphics.DrawLine(Pens.Gray, 22, e.Bounds.Y + 1, e.Bounds.Width - 2, e.Bounds.Y + 1);
      }
      else
      {
        Brush brush = (Brush) new SolidBrush(color1);
        e.Graphics.DrawString(this.Text, e.Font, brush, 24f, (float) (e.Bounds.Y + 3));
        if (!this.ShowShortcut || this.Shortcut == Shortcut.None)
          return;
        e.Graphics.DrawString(this.avOJF7XDrs(), e.Font, brush, (float) (e.Bounds.Width - this.LGXJHk0oQM - 5), (float) (e.Bounds.Y + 3));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string avOJF7XDrs()
    {
      string s = ((object) this.Shortcut).ToString();
      for (int index = 1; index < s.Length; ++index)
      {
        if (char.IsUpper(s, index))
        {
          s = s.Insert(index, RNaihRhYEl0wUmAftnB.aYu7exFQKN(33348));
          ++index;
        }
      }
      return s;
    }
  }
}
