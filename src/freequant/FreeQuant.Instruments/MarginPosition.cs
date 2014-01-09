using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class MarginPosition
  {
    public Position fPosition;
    public double fMargin;

    public Position Position
    {
       get
      {
        return this.fPosition;
      }
       set
      {
        this.fPosition = value;
      }
    }

    public double Margin
    {
     get
      {
        return this.fMargin;
      }
      set
      {
        this.fMargin = value;
      }
    }


    public MarginPosition(Position position)
    {
      this.fPosition = position;
    }


    public MarginPosition(Position position, double margin)
    {
      this.fPosition = position;
      this.fMargin = margin;
    }
  }
}
