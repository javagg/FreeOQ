using System.Runtime.CompilerServices;

namespace FreeQuant.Xml
{
  public class BooleanValueXmlNode : ValueXmlNode
  {
    public bool Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetBooleanValue();
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetValue(value);
      }
    }

	public BooleanValueXmlNode() :  base()
	{ 
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetValue(bool defaultValue)
    {
      return this.GetBooleanValue(defaultValue);
    }
  }
}
