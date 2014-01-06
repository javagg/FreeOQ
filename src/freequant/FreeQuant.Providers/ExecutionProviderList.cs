// Type: SmartQuant.Providers.ExecutionProviderList
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using dW79p7NPlS6ZxObcx3;
using System.Runtime.CompilerServices;

namespace SmartQuant.Providers
{
  public class ExecutionProviderList : ProviderList
  {
    public IExecutionProvider this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return base[name] as IExecutionProvider;
      }
    }

    public IExecutionProvider this[byte id]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return base[id] as IExecutionProvider;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ExecutionProviderList()
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
