// Type: SmartQuant.Providers.ProviderError
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using dW79p7NPlS6ZxObcx3;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Providers
{
  public class ProviderError
  {
    private DateTime lS8gnOkvq1;
    private IProvider TJQgv5usPA;
    private int Du6gcH6rlf;
    private int OGEgBc6npy;
    private string Lk6gjGn1bF;

    public DateTime DateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.lS8gnOkvq1;
      }
    }

    public IProvider Provider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.TJQgv5usPA;
      }
    }

    public int Id
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Du6gcH6rlf;
      }
    }

    public int Code
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OGEgBc6npy;
      }
    }

    public string Message
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Lk6gjGn1bF;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProviderError(DateTime datetime, IProvider provider, int id, int code, string message)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.lS8gnOkvq1 = datetime;
      this.TJQgv5usPA = provider;
      this.Du6gcH6rlf = id;
      this.OGEgBc6npy = code;
      this.Lk6gjGn1bF = message;
    }
  }
}
