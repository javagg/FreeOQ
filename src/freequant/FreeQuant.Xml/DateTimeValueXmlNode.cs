// Type: SmartQuant.Xml.DateTimeValueXmlNode
// Assembly: SmartQuant.Xml, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 4C8F4348-49D3-4BAF-ACAF-1FA08F95BF23
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Xml.dll

using System;
using System.Runtime.CompilerServices;
using wOTnoM0h260SstC0xu;

namespace SmartQuant.Xml
{
  public class DateTimeValueXmlNode : ValueXmlNode
  {
    public DateTime Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDateTimeValue();
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetValue(value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTimeValueXmlNode()
    {
      wCdHLSBd0jEmbylf8M.oiA62Aizl0hxD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTime GetValue(DateTime defaultValue)
    {
      return this.GetDateTimeValue(defaultValue);
    }
  }
}
