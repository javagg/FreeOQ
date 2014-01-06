// Type: SmartQuant.Trading.IntParam
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SmartQuant.Instruments;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
{
  public class IntParam
  {
    private Hashtable Whi61bRdZC;

    public int this[Instrument instrument]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        object obj = this.Whi61bRdZC[(object) instrument];
        if (obj != null)
          return (int) obj;
        else
          return 0;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.Whi61bRdZC[(object) instrument] = (object) value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntParam()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      this.Whi61bRdZC = new Hashtable();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
