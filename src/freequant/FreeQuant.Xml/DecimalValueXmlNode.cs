// Type: SmartQuant.Xml.DecimalValueXmlNode
// Assembly: SmartQuant.Xml, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 4C8F4348-49D3-4BAF-ACAF-1FA08F95BF23
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Xml.dll

using System;
using System.Runtime.CompilerServices;
using wOTnoM0h260SstC0xu;

namespace SmartQuant.Xml
{
  public class DecimalValueXmlNode : ValueXmlNode
  {
    public Decimal Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDecimalValue();
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetValue(value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DecimalValueXmlNode()
    {
      wCdHLSBd0jEmbylf8M.oiA62Aizl0hxD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Decimal GetValue(Decimal defaultValue)
    {
      return this.GetDecimalValue(defaultValue);
    }
  }
}
