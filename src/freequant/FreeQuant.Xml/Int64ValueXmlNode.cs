using System.Runtime.CompilerServices;

namespace FreeQuant.Xml
{
  public class Int64ValueXmlNode : ValueXmlNode
  {
    public long Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetInt64Value();
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetValue(value);
      }
    }

	public Int64ValueXmlNode() : base()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public long GetValue(long defaultValue)
    {
      return this.GetInt64Value(defaultValue);
    }
  }
}
