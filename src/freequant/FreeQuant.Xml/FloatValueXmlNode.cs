using System.Runtime.CompilerServices;

namespace FreeQuant.Xml
{
  public class FloatValueXmlNode : ValueXmlNode
  {
    public float Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetFloatValue();
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetValue(value);
      }
    }

		public FloatValueXmlNode() : base()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetValue(float defaultValue)
    {
      return this.GetFloatValue(defaultValue);
    }
  }
}
