// Type: SmartQuant.Data.DailyArrayEventArgs
// Assembly: SmartQuant.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=844f265c18b031f9
// MVID: FAB3F3C9-6D4A-4391-AE43-0CE5E1C624DD
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Data.dll

using RadDBE9P5I945u5gCE;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Data
{
  public class DailyArrayEventArgs : EventArgs
  {
    private DailyArray YRS1pknR8;

    public DailyArray DailyArray
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.YRS1pknR8;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DailyArrayEventArgs(DailyArray dailyArray)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.YRS1pknR8 = dailyArray;
    }
  }
}
