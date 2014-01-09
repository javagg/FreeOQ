// Type: SmartQuant.Xml.GuidValueXmlNode
// Assembly: SmartQuant.Xml, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 4C8F4348-49D3-4BAF-ACAF-1FA08F95BF23
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Xml.dll

using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Xml
{
  public class GuidValueXmlNode : ValueXmlNode
  {
    public Guid Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetGuidValue();
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetValue(value);
      }
    }

	public GuidValueXmlNode()  : base()
    {
     }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Guid GetValue(Guid defaultValue)
    {
      return this.GetGuidValue(defaultValue);
    }
  }
}
