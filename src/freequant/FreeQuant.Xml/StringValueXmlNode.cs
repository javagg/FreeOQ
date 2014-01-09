
using System.Runtime.CompilerServices;

namespace FreeQuant.Xml
{
  public class StringValueXmlNode : ValueXmlNode
  {
    public string Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue();
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetValue(value);
      }
    }
  }
}
