// Type: SmartQuant.Xml.BooleanValueXmlNode
// Assembly: SmartQuant.Xml, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 4C8F4348-49D3-4BAF-ACAF-1FA08F95BF23
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Xml.dll

using System.Runtime.CompilerServices;
using wOTnoM0h260SstC0xu;

namespace SmartQuant.Xml
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
