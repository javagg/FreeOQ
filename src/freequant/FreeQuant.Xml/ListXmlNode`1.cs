using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Xml
{
  public abstract class ListXmlNode<T> : XmlNodeBase, IEnumerable where T : XmlNodeBase, new()
  {

	protected ListXmlNode() :  base()
    {
    }

    protected T AppendChildNode()
    {
      return base.AppendChildNode<T>();
    }

    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.GetChildNodes<T>().GetEnumerator();
    }
  }
}
