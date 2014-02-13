using System;

namespace FreeQuant.Xml
{
  public class GuidValueXmlNode : ValueXmlNode
  {
    public Guid Value
    {
       get
      {
        return this.GetGuidValue();
      }
       set
      {
        this.SetValue(value);
      }
    }

	public GuidValueXmlNode()  : base()
    {
     }

    
    public Guid GetValue(Guid defaultValue)
    {
      return this.GetGuidValue(defaultValue);
    }
  }
}
