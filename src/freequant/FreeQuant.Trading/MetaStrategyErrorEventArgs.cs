using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class MetaStrategyErrorEventArgs : EventArgs
  {
    private Exception lfjir9QWdQ;
    private bool PMmiI44IpQ;

    public Exception Exception
    {
       get
      {
        return this.lfjir9QWdQ;
      }
    }

    public bool Ignore
    {
       get
      {
        return this.PMmiI44IpQ;
      }
       set
      {
        this.PMmiI44IpQ = value;
      }
    }

    
		public MetaStrategyErrorEventArgs(Exception exception):base()
    {
      this.lfjir9QWdQ = exception;
      this.PMmiI44IpQ = false;
    }
  }
}
