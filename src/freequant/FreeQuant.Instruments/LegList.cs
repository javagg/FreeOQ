// Type: SmartQuant.Instruments.LegList
// Assembly: SmartQuant.Instruments, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: FEB2224D-772C-409E-AF2C-0F179BA2AEB6
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Instruments.dll

using nlmLboft3R6jnhSDBs;
using SmartQuant.FIX;
using System.Runtime.CompilerServices;

namespace SmartQuant.Instruments
{
  public class LegList : FIXGroupList
  {
    public Leg this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fList[index] as Leg;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegList()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
