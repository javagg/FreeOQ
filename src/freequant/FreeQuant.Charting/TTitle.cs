using System;
using System.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
  [Serializable]
  public class TTitle
  {
    private Pad zeN3moyxtg;
    private ArrayList items;
    private bool itemsEnabled;
    private string text;
    private Font font;
    private Color color;
    private ETitlePosition qiA358ZZi0;
    private int f5e3L6gA5t;
    private int GYu3Ak0B6x;
    private ETitleStrategy GT83QjlMJ1;

    public ArrayList Items
    {
       get
      {
				return this.items; 
      }
    }

    public bool ItemsEnabled
    {
       get
      {
				return this.itemsEnabled; 
      }
       set
      {
        this.itemsEnabled = value;
      }
    }

    public string Text
    {
       get
      {
				return this.text; 
      }
       set
      {
        this.text = value;
      }
    }

    public Font Font
    {
       get
      {
				return this.font; 
      }
       set
      {
        this.font = value;
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
      }
    }

    public ETitlePosition Position
    {
       get
      {
        return this.qiA358ZZi0;
      }
       set
      {
        this.qiA358ZZi0 = value;
      }
    }

    public int X
    {
       get
      {
        return this.f5e3L6gA5t;
      }
       set
      {
        this.f5e3L6gA5t = value;
      }
    }

    public int Y
    {
       get
      {
        return this.GYu3Ak0B6x;
      }
       set
      {
        this.GYu3Ak0B6x = value;
      }
    }

    public int Width
    {
       get
      {
        return (int) this.zeN3moyxtg.Graphics.MeasureString(this.vsC3u6p1dQ(), this.font).Width;
      }
    }

    public int Height
    {
       get
      {
        return (int) this.zeN3moyxtg.Graphics.MeasureString(this.vsC3u6p1dQ(), this.font).Height;
      }
    }

    public ETitleStrategy Strategy
    {
       get
      {
        return this.GT83QjlMJ1;
      }
       set
      {
        this.GT83QjlMJ1 = value;
      }
    }

    
    public TTitle(Pad Pad):base()
    {

      this.zeN3moyxtg = Pad;
      this.text = "";
      this.Rgq3k0SxCt();
    }

    
    public TTitle(Pad Pad, string Text):base()
    {

      this.zeN3moyxtg = Pad;
      this.text = Text;
      this.Rgq3k0SxCt();
    }

    
    private void Rgq3k0SxCt()
    {
      this.items = new ArrayList();
      this.itemsEnabled = false;
      this.text = "";
		this.font = new Font("Times New Roman", 8);
      this.color = Color.Black;
      this.qiA358ZZi0 = ETitlePosition.Left;
      this.GT83QjlMJ1 = ETitleStrategy.Smart;
      this.f5e3L6gA5t = 0;
      this.GYu3Ak0B6x = 0;
    }

    
    public void Add(string Text, Color Color)
    {
      this.items.Add((object) new TTitleItem(Text, Color));
    }

    
    private string vsC3u6p1dQ()
    {
      string str = this.text;
      foreach (TTitleItem ttitleItem in this.items)
				str = str + "" + ttitleItem.Text;
      return str;
    }

    
    public void Paint()
    {
      SolidBrush solidBrush1 = new SolidBrush(this.color);
      if (this.text != "")
        this.zeN3moyxtg.Graphics.DrawString(this.text, this.font, (Brush) solidBrush1, (float) this.f5e3L6gA5t, (float) this.GYu3Ak0B6x);
      if (this.GT83QjlMJ1 == ETitleStrategy.Smart && this.text == "" && (!this.itemsEnabled && this.items.Count != 0))
        this.zeN3moyxtg.Graphics.DrawString(((TTitleItem) this.items[0]).Text, this.font, (Brush) new SolidBrush(this.color), (float) this.f5e3L6gA5t, (float) this.GYu3Ak0B6x);
      if (!this.itemsEnabled)
        return;
      string str = this.text;
      foreach (TTitleItem ttitleItem in this.items)
      {
        SolidBrush solidBrush2 = new SolidBrush(ttitleItem.Color);
				string text = str + "";
        int num = this.f5e3L6gA5t + (int) this.zeN3moyxtg.Graphics.MeasureString(text, this.font).Width;
        this.zeN3moyxtg.Graphics.DrawString(ttitleItem.Text, this.font, (Brush) solidBrush2, (float) num, (float) this.GYu3Ak0B6x);
        str = text + ttitleItem.Text;
      }
    }
  }
}
