using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
  [Serializable]
  public class TLabel : TMarker
  {
    [Category("Text")]
    [Description("Text that this label displays")]
		public new string Text { get; set; }

    [Description("Text position of this label")]
    [Category("Text")]
		new public ETextPosition TextPosition { get; set; }

    [Description("Text font of this label")]
    [Category("Text")]
		public new Font TextFont { get; set; }

    [Description("Text color of this label")]
    [Category("Text")]
		public new Color TextColor { get; set; }
    [Description("Text offset in pixels alone X coordinate")]
    [Category("Text")]
		public int TextOffsetX { get; set; }

    [Category("Text")]
    [Description("Text offset in pixels alone Y coordinate")]
		public int TextOffsetY { get; set; }


		public TLabel(string text, double x, double y):base(x,y)
    {
		this.Text = text;
      this.Init();
    }

    
    public TLabel(string text, double x, double y, Color markerColor): base(x, y, markerColor)
    {
			this.Text = text;
      this.Init();
    }

    public TLabel(string text, double x, double y, Color markerColor, Color textColor) :base(x, y, markerColor)
    {
			this.Text = text;
      this.Init();
			this.TextColor = textColor;
    }

    
    private void Init()
    {
			this.TextFont = new Font("Arial", 8);
			this.TextPosition = ETextPosition.RightBottom;
			this.TextColor = Color.Black;
			this.TextOffsetX = 0;
			this.TextOffsetY = 2;
    }

    
    public override void Paint(Pad pad, double minX, double maxX, double minY, double maxY)
    {
      base.Paint(pad, minX, maxX, minY, maxY);
			if (this.Text == null)
        return;
      int num1 = (int) pad.Graphics.MeasureString(this.Text, this.TextFont).Width;
      int num2 = (int) pad.Graphics.MeasureString(this.Text, this.TextFont).Height;
      switch (this.TextPosition)
      {
        case ETextPosition.RightTop:
          pad.Graphics.DrawString(this.Text, this.TextFont, new SolidBrush(this.TextColor), (float) (pad.ClientX(this.fX) + this.TextOffsetX), (float) (pad.ClientY(this.fY) - num2 - this.TextOffsetY));
          break;
        case ETextPosition.LeftTop:
          pad.Graphics.DrawString(this.Text, this.TextFont, new SolidBrush(this.TextColor), (float) (pad.ClientX(this.fX) - num1 - this.TextOffsetX), (float) (pad.ClientY(this.fY) - num2 - this.TextOffsetY));
          break;
        case ETextPosition.CentreTop:
          pad.Graphics.DrawString(this.Text, this.TextFont, (Brush) new SolidBrush(this.TextColor), (float) (pad.ClientX(this.fX) - num1 / 2 - this.TextOffsetX), (float) (pad.ClientY(this.fY) - num2 - this.TextOffsetY));
          break;
        case ETextPosition.RightBottom:
          pad.Graphics.DrawString(this.Text, this.TextFont, (Brush) new SolidBrush(this.TextColor), (float) (pad.ClientX(this.fX) + this.TextOffsetX), (float) (pad.ClientY(this.fY) + this.Size / 2 + this.TextOffsetY));
          break;
        case ETextPosition.LeftBottom:
          pad.Graphics.DrawString(this.Text, this.TextFont, (Brush) new SolidBrush(this.TextColor), (float) (pad.ClientX(this.fX) - num1 - this.TextOffsetX), (float) (pad.ClientY(this.fY) + this.Size / 2 + this.TextOffsetY));
          break;
        case ETextPosition.CentreBottom:
          pad.Graphics.DrawString(this.Text, this.TextFont, (Brush) new SolidBrush(this.TextColor), (float) (pad.ClientX(this.fX) - num1 / 2 - this.TextOffsetX), (float) (pad.ClientY(this.fY) + this.Size / 2 + this.TextOffsetY));
          break;
      }
    }
  }
}
