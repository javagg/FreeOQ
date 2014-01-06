// Type: SmartQuant.Instruments.MarginPosition
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using System.Runtime.CompilerServices;

namespace SmartQuant.Instruments
{
  public class MarginPosition
  {
    public Position fPosition;
    public double fMargin;

    public Position Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fPosition;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fPosition = value;
      }
    }

    public double Margin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMargin;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMargin = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarginPosition(Position position)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fPosition = position;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarginPosition(Position position, double margin)
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fPosition = position;
      this.fMargin = margin;
    }
  }
}
