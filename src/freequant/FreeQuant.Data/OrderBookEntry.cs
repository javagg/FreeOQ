// Type: SmartQuant.Data.OrderBookEntry
// Assembly: SmartQuant.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=844f265c18b031f9
// MVID: FAB3F3C9-6D4A-4391-AE43-0CE5E1C624DD
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Data.dll

using oL6nXjcX2wYBRbhX2q;
using RadDBE9P5I945u5gCE;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Data
{
  public class OrderBookEntry
  {
    private DateTime vtGLY0ZpH;
    private double m7mBaRIwn;
    private int oL69nXjX2;

    public DateTime DateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.vtGLY0ZpH;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.vtGLY0ZpH = value;
      }
    }

    public double Price
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.m7mBaRIwn;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.m7mBaRIwn = value;
      }
    }

    public int Size
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.oL69nXjX2;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.oL69nXjX2 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrderBookEntry(DateTime datetime, double price, int size)
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.vtGLY0ZpH = datetime;
      this.m7mBaRIwn = price;
      this.oL69nXjX2 = size;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return string.Format(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(758), (object) this.vtGLY0ZpH, (object) this.m7mBaRIwn, (object) this.oL69nXjX2);
    }
  }
}
