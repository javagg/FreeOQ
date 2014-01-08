using System.Runtime.CompilerServices;
using wOTnoM0h260SstC0xu;

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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BooleanValueXmlNode()
    {
      wCdHLSBd0jEmbylf8M.oiA62Aizl0hxD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetValue(bool defaultValue)
    {
      return this.GetBooleanValue(defaultValue);
    }
  }
}
