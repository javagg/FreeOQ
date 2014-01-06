// Type: SmartQuant.FIX.FIXField
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using iL6jh33hEcPk05eVIF;
using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXField
  {
    public int Tag;

    public virtual FIXType FIXType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXType.Unknown;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected FIXField(int tag)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Tag = tag;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return "";
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string ToInvariantString()
    {
      return "";
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object GetValue()
    {
      return (object) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static FIXField Field(FIXType type, int tag)
    {
      switch (type)
      {
        case FIXType.Bool:
          return (FIXField) new FIXBoolField(tag);
        case FIXType.Int:
          return (FIXField) new FIXIntField(tag);
        case FIXType.Double:
          return (FIXField) new FIXDoubleField(tag);
        case FIXType.Char:
          return (FIXField) new FIXCharField(tag);
        case FIXType.String:
          return (FIXField) new FIXStringField(tag);
        case FIXType.DateTime:
          return (FIXField) new FIXDateTimeField(tag);
        case FIXType.NumInGroup:
          return (FIXField) new FIXNumInGroupField(tag);
        default:
          throw new ArgumentException(Ugjylcah9mCMM4kO7N.tLah92SpBQ(432) + ((object) type).ToString());
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static FIXField Field(FIXType type, int tag, string value)
    {
      return FIXField.Field(type, tag, value, false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static FIXField Field(FIXType type, int tag, string value, bool invariantCulture)
    {
      switch (type)
      {
        case FIXType.Bool:
          return (FIXField) new FIXBoolField(tag, value, invariantCulture);
        case FIXType.Int:
          return (FIXField) new FIXIntField(tag, value, invariantCulture);
        case FIXType.Double:
          return (FIXField) new FIXDoubleField(tag, value, invariantCulture);
        case FIXType.Char:
          return (FIXField) new FIXCharField(tag, value, invariantCulture);
        case FIXType.String:
          return (FIXField) new FIXStringField(tag, value, invariantCulture);
        case FIXType.DateTime:
          return (FIXField) new FIXDateTimeField(tag, value, invariantCulture);
        default:
          throw new ArgumentException(Ugjylcah9mCMM4kO7N.tLah92SpBQ(486) + ((object) type).ToString());
      }
    }
  }
}
