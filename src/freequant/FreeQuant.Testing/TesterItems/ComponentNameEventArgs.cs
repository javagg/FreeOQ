using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.TesterItems
{
  public class ComponentNameEventArgs : EventArgs
  {
    private string m0Iy4y68Z2;
    private string xwuyByZiJp;

    public string OldName
    {
       get
      {
        return this.m0Iy4y68Z2;
      }
    }

    public string NewName
    {
       get
      {
        return this.xwuyByZiJp;
      }
    }

    
    public ComponentNameEventArgs(string oldName, string newName)
			: base()  {
      this.m0Iy4y68Z2 = oldName;
      this.xwuyByZiJp = newName;
    }
  }
}
