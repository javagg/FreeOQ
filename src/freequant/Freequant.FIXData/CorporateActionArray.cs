using FreeQuant.Data;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIXData
{
  public class CorporateActionArray : DataArray
  {
    public CorporateAction this[int index]
    {
        get
      {
        return base[index] as CorporateAction;
      }
    }

  }
}
