using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  public class ComponentTypeEventArgs : EventArgs
  {
    private ComponentType wKejFonsYj;

    public ComponentType ComponentType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.wKejFonsYj;
      }
    }

    public ComponentTypeEventArgs(ComponentType componentType)
    {
      this.wKejFonsYj = componentType;
    }
  }
}
