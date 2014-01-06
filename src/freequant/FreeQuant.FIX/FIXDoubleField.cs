// Type: SmartQuant.FIX.FIXDoubleField
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXDoubleField : FIXField
  {
    public const double Empty = 0.0;
    public double Value;

    public override FIXType FIXType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXType.Double;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXDoubleField(int tag)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      this.\u002Ector(tag, 0.0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXDoubleField(int tag, double value)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(tag);
      this.Value = value;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXDoubleField(int tag, string value)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      this.\u002Ector(tag, value, false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXDoubleField(int tag, string value, bool invariantCulture)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      this.\u002Ector(tag, invariantCulture ? double.Parse(value, (IFormatProvider) CultureInfo.InvariantCulture) : double.Parse(value));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return this.Value.ToString();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToInvariantString()
    {
      return this.Value.ToString((IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetValue()
    {
      return (object) this.Value;
    }
  }
}
