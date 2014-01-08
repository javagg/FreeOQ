// Type: SmartQuant.FIXData.FundamentalArray
// Assembly: SmartQuant.FIXData, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: EFFB17F5-E3EE-4C04-A796-299A152DA0CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIXData.dll

using E8idH0Km5kZBKt6QG5;
using FreeQuant.Data;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIXData
{
  public class FundamentalArray : DataArray
  {
    public Fundamental this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return base[index] as Fundamental;
      }
    }

  }
}
