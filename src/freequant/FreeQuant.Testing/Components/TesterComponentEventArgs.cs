using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Components
{
  public class TesterComponentEventArgs : EventArgs
  {
    private TesterComponentRecord UjAyJfIQgT;

    public TesterComponentRecord Component
    {
       get
      {
        return this.UjAyJfIQgT;
      }
    }

    
		public TesterComponentEventArgs(TesterComponentRecord component):base()
    {
      this.UjAyJfIQgT = component;
    }
  }
}
