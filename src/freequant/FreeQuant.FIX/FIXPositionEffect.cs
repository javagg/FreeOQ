using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXPositionEffect : FIXCharField
  {
    public const char Open = 'O';
    public const char Close = 'C';
    public const char Rolled = 'R';
    public const char FIFO = 'F';

    public FIXPositionEffect(char val):base(77, val)
    {

    }

    public static char Value(string Name)
    {
			if (Name == "Open")
        return 'O';
			if (Name == "Close")
        return 'C';
			if (Name == "Rolled")
        return 'R';
			return Name == "FIFO" ? 'F' : char.MinValue;
    }

    public static string ToString(char c)
    {
      switch (c)
      {
        case 'O':
					return "Open";
        case 'R':
					return "Rolled";
        case 'C':
					return "Close";
        case 'F':
					return "FIFO";
        default:
					return "[unknown]";
      }
    }
  }
}
