using FreeQuant.FIX;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class LegList : FIXGroupList
  {
    public Leg this[int index]
    {
       get
      {
        return this.fList[index] as Leg;
      }
    }

    }
  }
}
