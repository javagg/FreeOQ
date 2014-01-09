using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXStringField : FIXField
  {
    public const string Empty = "";
    public string Value;

    public override FIXType FIXType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXType.String;
      }
    }

    public FIXStringField(int tag):this(tag, "")
    {
    }

    public FIXStringField(int tag, string value):this(tag, value, false)
    {
    }

    public FIXStringField(int tag, string value, bool invariantCulture):base(tag)
    {
      this.Value = invariantCulture ? value : value;
    }

    public override string ToString()
    {
      return ((object) this.Value).ToString();
    }

    public override string ToInvariantString()
    {
      return this.ToString();
    }

    public override object GetValue()
    {
      return (object) this.Value;
    }
  }
}
