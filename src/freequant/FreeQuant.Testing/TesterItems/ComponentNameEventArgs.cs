// Type: SmartQuant.Testing.TesterItems.ComponentNameEventArgs
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.TesterItems
{
  public class ComponentNameEventArgs : EventArgs
  {
    private string m0Iy4y68Z2;
    private string xwuyByZiJp;

    public string OldName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.m0Iy4y68Z2;
      }
    }

    public string NewName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.xwuyByZiJp;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ComponentNameEventArgs(string oldName, string newName)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.m0Iy4y68Z2 = oldName;
      this.xwuyByZiJp = newName;
    }
  }
}
