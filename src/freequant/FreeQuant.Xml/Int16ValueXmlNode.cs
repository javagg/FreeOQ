using System.Runtime.CompilerServices;

namespace FreeQuant.Xml
{
  public class Int16ValueXmlNode : ValueXmlNode
  {
    public short Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetInt16Value();
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetValue(value);
      }
    }

	public Int16ValueXmlNode()  :  base()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public short GetValue(short defaultValue)
    {
      return this.GetInt16Value(defaultValue);
    }
  }
}
