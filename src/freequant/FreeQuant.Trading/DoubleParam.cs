// Type: SmartQuant.Trading.DoubleParam
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using SmartQuant.Instruments;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
{
  public class DoubleParam
  {
    private Hashtable yvNRbXLeMW;

    public double this[Instrument instrument]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        object obj = this.yvNRbXLeMW[(object) instrument];
        if (obj != null)
          return (double) obj;
        else
          return 0.0;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.yvNRbXLeMW[(object) instrument] = (object) value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DoubleParam()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      this.yvNRbXLeMW = new Hashtable();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
