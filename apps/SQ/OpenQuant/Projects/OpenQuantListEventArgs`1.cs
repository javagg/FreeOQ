// Type: OpenQuant.Projects.OpenQuantListEventArgs`1
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using System;

namespace OpenQuant.Projects
{
  internal class OpenQuantListEventArgs<T> : EventArgs
  {
    private T obj;

    public T Object
    {
      get
      {
        return this.obj;
      }
    }

    public OpenQuantListEventArgs(T obj)
    {
      this.obj = obj;
    }
  }
}
