using System.Runtime.CompilerServices;

namespace FreeQuant.Xml
{
  public class Int32ValueXmlNode : ValueXmlNode
  {
    public int Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetInt32Value();
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetValue(value);
      }
    }

	public Int32ValueXmlNode() : base()
    {
    }

    public int GetValue(int defaultValue)
    {
      return this.GetInt32Value(defaultValue);
    }
  }
}
