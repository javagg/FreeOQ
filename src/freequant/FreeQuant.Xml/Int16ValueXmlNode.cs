// Type: SmartQuant.Xml.Int16ValueXmlNode
// Assembly: SmartQuant.Xml, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 4C8F4348-49D3-4BAF-ACAF-1FA08F95BF23
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Xml.dll

using System.Runtime.CompilerServices;
using wOTnoM0h260SstC0xu;

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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Int16ValueXmlNode()
    {
      wCdHLSBd0jEmbylf8M.oiA62Aizl0hxD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public short GetValue(short defaultValue)
    {
      return this.GetInt16Value(defaultValue);
    }
  }
}
