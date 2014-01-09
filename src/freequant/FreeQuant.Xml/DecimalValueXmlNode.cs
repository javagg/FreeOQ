
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Xml
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

	public DecimalValueXmlNode() :  base()
    {

    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Decimal GetValue(Decimal defaultValue)
    {
      return this.GetDecimalValue(defaultValue);
    }
  }
}
