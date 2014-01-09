using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Xml
{
  public class PropertyXmlNode : XmlNodeBase
  {
    private const string YISEWI7PD = "name";
    private const string f5FJf7ixS = "type";

    public override string NodeName
    {
      get
      {
			return YISEWI7PD;
      }
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
				return this.GetStringAttribute(YISEWI7PD);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
				this.SetAttribute(YISEWI7PD, value);
      }
    }

    public Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
				return this.GetTypeAttribute(f5FJf7ixS);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
				this.SetAttribute(f5FJf7ixS, value);
      }
    }

    public string Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue();
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetValue(value);
      }
    }

	public PropertyXmlNode() : base()
    {
    }
  }
}
