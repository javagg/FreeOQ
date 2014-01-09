using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXField
  {
    public int Tag;

    public virtual FIXType FIXType
    {
       get
      {
        return FIXType.Unknown;
      }
    }

    protected FIXField(int tag)
    {
      this.Tag = tag;
    }

    public override string ToString()
    {
      return "";
    }

    public virtual string ToInvariantString()
    {
      return "";
    }

    public virtual object GetValue()
    {
      return (object) null;
    }

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
