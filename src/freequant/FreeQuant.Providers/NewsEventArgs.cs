using dW79p7NPlS6ZxObcx3;
using FreeQuant.FIX;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Providers
{
  public class NewsEventArgs : EventArgs
  {
    private FIXNews yjMt20TPRv;

    public FIXNews News
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.yjMt20TPRv;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NewsEventArgs(FIXNews news)
    {
      Y8h1Gnp6qhyPRT2DDw.iUP8o3RzIib3P();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.yjMt20TPRv = news;
    }
  }
}
