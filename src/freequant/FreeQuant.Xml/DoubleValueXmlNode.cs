
using System.Runtime.CompilerServices;

namespace FreeQuant.Xml
{
  public class DoubleValueXmlNode : ValueXmlNode
  {
    public double Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue();
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetValue(value);
      }
    }

	public DoubleValueXmlNode() :  base()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(double defaultValue)
    {
      return this.GetDoubleValue(defaultValue);
    }
  }
}
