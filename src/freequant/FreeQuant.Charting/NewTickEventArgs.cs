// Type: SmartQuant.Charting.NewTickEventArgs
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

using cPAIWng0kq1SUTh6h4;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Charting
{
  public class NewTickEventArgs : EventArgs
  {
    private DateTime KbAS54W9O;

    public DateTime DateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.KbAS54W9O;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.KbAS54W9O = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NewTickEventArgs(DateTime datetime)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.KbAS54W9O = datetime;
    }
  }
}
