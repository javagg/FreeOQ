
using System.Runtime.CompilerServices;

namespace FreeQuant.Xml
{
  public class EnumValueXmlNode<T> : ValueXmlNode where T : struct
  {
    public T Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (T) this.GetEnumValue(typeof (T));
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetValue(value.ToString());
      }
    }

		public EnumValueXmlNode() : base()
    {

    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T GetValue(T defaultValue)
    {
      return this.GetEnumValue<T>(defaultValue);
    }
  }
}
