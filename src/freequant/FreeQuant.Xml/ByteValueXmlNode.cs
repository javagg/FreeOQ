using System.Runtime.CompilerServices;

namespace FreeQuant.Xml
{
  public class ByteValueXmlNode : ValueXmlNode
  {
    public byte Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetByteValue();
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetValue(value);
      }
    }

	public ByteValueXmlNode() :  base()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public byte GetValue(byte defaultValue)
    {
      return this.GetByteValue(defaultValue);
    }
  }
}
