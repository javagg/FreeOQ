// Type: SmartQuant.Business.Holiday
// Assembly: SmartQuant.Business, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 8728B172-6D66-401A-ACE9-1E591C9804EB
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Business.dll

using System;
using System.Runtime.CompilerServices;
using VQ9v10m5lBQXWUX1qW;

namespace SmartQuant.Business
{
  [Serializable]
  public class Holiday
  {
    private string LwMBbTJV8;
    private string sUwWdUTFH;
    private DateTime CGPoreO3J;

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.LwMBbTJV8;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.LwMBbTJV8 = value;
      }
    }

    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.sUwWdUTFH;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.sUwWdUTFH = value;
      }
    }

    public DateTime Date
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.CGPoreO3J;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.CGPoreO3J = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Holiday()
    {
      daSFLBUgUxHG6jMMC5.S0BNF3rzWBODw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Holiday(DateTime date, string name)
    {
      daSFLBUgUxHG6jMMC5.S0BNF3rzWBODw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.CGPoreO3J = this.Date;
      this.LwMBbTJV8 = name;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Holiday(DateTime date, string name, string description)
    {
      daSFLBUgUxHG6jMMC5.S0BNF3rzWBODw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.CGPoreO3J = date;
      this.LwMBbTJV8 = name;
      this.sUwWdUTFH = description;
    }
  }
}
