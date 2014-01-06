// Type: SmartQuant.Trading.MetaStrategyErrorEventArgs
// Assembly: SmartQuant.Trading, Version=1.0.5036.28355, Culture=neutral, PublicKeyToken=null
// MVID: C5705820-2ED1-4F4A-8256-821635A4814B
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Trading.dll

using l3Z5ZAp2dkqyZZDck9P;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Trading
{
  public class MetaStrategyErrorEventArgs : EventArgs
  {
    private Exception lfjir9QWdQ;
    private bool PMmiI44IpQ;

    public Exception Exception
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.lfjir9QWdQ;
      }
    }

    public bool Ignore
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.PMmiI44IpQ;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.PMmiI44IpQ = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MetaStrategyErrorEventArgs(Exception exception)
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.lfjir9QWdQ = exception;
      this.PMmiI44IpQ = false;
    }
  }
}
