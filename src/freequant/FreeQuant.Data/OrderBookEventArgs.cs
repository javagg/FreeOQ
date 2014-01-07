// Type: SmartQuant.Data.OrderBookEventArgs
// Assembly: SmartQuant.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=844f265c18b031f9
// MVID: FAB3F3C9-6D4A-4391-AE43-0CE5E1C624DD
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Data.dll

using RadDBE9P5I945u5gCE;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Data
{
  public class OrderBookEventArgs : EventArgs
  {
    private MDSide q7DtYpaWL;
    private MDOperation vUvYPrgSy;
    private int UmPrlIUm1;

    public MDSide Side
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.q7DtYpaWL;
      }
    }

    public MDOperation Operation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.vUvYPrgSy;
      }
    }

    public int Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.UmPrlIUm1;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrderBookEventArgs(MDSide side, MDOperation operation, int position)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.q7DtYpaWL = side;
      this.vUvYPrgSy = operation;
      this.UmPrlIUm1 = position;
    }
  }
}
