using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
  public class TTextBoxItem
  {
    private string aGsoVk3Bc;
    private Color kP83TXqlQ;
    private Font jLCCwmdU2;

    public string Text
    {
       get
      {
        return this.aGsoVk3Bc;
      }
       set
      {
        this.aGsoVk3Bc = value;
      }
    }

    public Color Color
    {
       get
      {
        return this.kP83TXqlQ;
      }
       set
      {
        this.kP83TXqlQ = value;
      }
    }

    public Font Font
    {
       get
      {
        return this.jLCCwmdU2;
      }
       set
      {
        this.jLCCwmdU2 = value;
      }
    }

    
    public TTextBoxItem(string Text, Color Color, Font Font) :base()
    {

      this.aGsoVk3Bc = Text;
      this.kP83TXqlQ = Color;
      this.jLCCwmdU2 = Font;
    }


    public TTextBoxItem(string Text, Color Color):base()
    {
      this.aGsoVk3Bc = Text;
      this.kP83TXqlQ = Color;
	this.jLCCwmdU2 = new Font("Times New Roman", 8);
    }
  }
}
