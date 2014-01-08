// Type: SmartQuant.Xml.ListXmlNode`1
// Assembly: SmartQuant.Xml, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 4C8F4348-49D3-4BAF-ACAF-1FA08F95BF23
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Xml.dll

using System.Collections;
using System.Runtime.CompilerServices;
using wOTnoM0h260SstC0xu;

namespace FreeQuant.Xml
{
  public abstract class ListXmlNode<T> : XmlNodeBase, IEnumerable where T : XmlNodeBase, new()
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ListXmlNode()
    {
      wCdHLSBd0jEmbylf8M.oiA62Aizl0hxD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected T AppendChildNode()
    {
      return base.AppendChildNode<T>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.GetChildNodes<T>().GetEnumerator();
    }
  }
}
