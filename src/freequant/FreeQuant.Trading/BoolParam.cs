// Type: SmartQuant.Trading.BoolParam
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SmartQuant.Instruments;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
{
  public class BoolParam
  {
    private Hashtable GCRR8QLLE5;

    public bool this[Instrument instrument]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        object obj = this.GCRR8QLLE5[(object) instrument];
        if (obj != null)
          return (bool) obj;
        else
          return false;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.GCRR8QLLE5[(object) instrument] = (object) (bool) (value ? 1 : 0);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoolParam()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      this.GCRR8QLLE5 = new Hashtable();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
