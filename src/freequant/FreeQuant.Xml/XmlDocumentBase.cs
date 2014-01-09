using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace FreeQuant.Xml
{
  public class XmlDocumentBase : XmlDocument
  {
    protected const int DEFAULT_SCHEMA_VERSION = 1;
    private const string Ognhwwmqi = "schemaVersion";

    public int SchemaVersion
    {
        get
      {
				if (!this.DocumentElement.HasAttribute(Ognhwwmqi))
          return 1;
        else
			return this.GetInt32Attribute(Ognhwwmqi);
      }
    }

 	protected XmlDocumentBase(string name, string description, int schemaVersion) :base()
    {
	this.LoadXml(name);
	this.InsertBefore((XmlNode) this.CreateXmlDeclaration("", Encoding.Unicode.HeaderName, (string) null), (XmlNode) this.DocumentElement);
      if (description != null)
        this.InsertBefore((XmlNode) this.CreateComment(description), (XmlNode) this.DocumentElement);
			this.SetAttribute(Ognhwwmqi, schemaVersion);
    }

	protected XmlDocumentBase(string name, string description) : this(name, description, 1)
    {
    }

	protected XmlDocumentBase(string name, int schemaVersion) : this(name, (string) null, schemaVersion)
    {
    }

	protected XmlDocumentBase(string name) :  this(name, 1)
    {
    }

    protected T GetChildNode<T>() where T : XmlNodeBase, new()
    {
      string nodeName = Activator.CreateInstance<T>().NodeName;
      foreach (XmlNode xmlNode in (XmlNode) this.DocumentElement)
      {
        if (xmlNode.Name == nodeName)
          return XmlNodeBase.YJKde7XAt<T>(xmlNode);
      }
      T obj = XmlNodeBase.YJKde7XAt<T>((XmlNode) this.CreateElement(nodeName));
      this.DocumentElement.AppendChild((XmlNode) ((XmlNodeBase) obj));
      return obj;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected List<T> GetChildNodes<T>() where T : XmlNodeBase, new()
    {
      string nodeName = Activator.CreateInstance<T>().NodeName;
      List<T> list = new List<T>();
      foreach (XmlNode xmlNode in (XmlNode) this.DocumentElement)
      {
        if (xmlNode.Name == nodeName)
          list.Add(XmlNodeBase.YJKde7XAt<T>(xmlNode));
      }
      return list;
    }

    protected bool ContainsAttribute(string name)
    {
      return this.DocumentElement.Attributes[name] != null;
    }

    protected string GetStringAttribute(string name)
    {
      XmlAttribute xmlAttribute = this.DocumentElement.Attributes[name];
      if (xmlAttribute != null)
        return xmlAttribute.Value;
      else
        return (string) null;
    }

    protected int GetInt32Attribute(string name)
    {
      return int.Parse(this.GetStringAttribute(name), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    protected uint GetUInt32Attribute(string name)
    {
      return uint.Parse(this.GetStringAttribute(name), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected long GetInt64Attribute(string name)
    {
      return long.Parse(this.GetStringAttribute(name), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ulong GetUInt64Attribute(string name)
    {
      return ulong.Parse(this.GetStringAttribute(name), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected short GetInt16Attribute(string name)
    {
      return short.Parse(this.GetStringAttribute(name), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    protected ushort GetUInt16Attribute(string name)
    {
      return ushort.Parse(this.GetStringAttribute(name), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected byte GetByteAttribute(string name)
    {
      return byte.Parse(this.GetStringAttribute(name), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected sbyte GetSByteAttribute(string name)
    {
      return sbyte.Parse(this.GetStringAttribute(name), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected float GetFloatAttribute(string name)
    {
      return float.Parse(this.GetStringAttribute(name), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected double GetDoubleAttribute(string name)
    {
      return double.Parse(this.GetStringAttribute(name), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Decimal GetDecimalAttribute(string name)
    {
      return Decimal.Parse(this.GetStringAttribute(name), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected DateTime GetDateTimeAttribute(string name)
    {
      return DateTime.Parse(this.GetStringAttribute(name), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool GetBooleanAttribute(string name)
    {
      return bool.Parse(this.GetStringAttribute(name));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected object GetEnumAttribute(string name, Type type)
    {
      return Enum.Parse(type, this.GetStringAttribute(name));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Type GetTypeAttribute(string name)
    {
      return Type.GetType(this.GetStringAttribute(name));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Guid GetGuidAttribute(string name)
    {
      return new Guid(this.GetStringAttribute(name));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetAttribute(string name, string value)
    {
      XmlAttribute node = this.DocumentElement.Attributes[name];
      if (node == null)
      {
        node = this.CreateAttribute(name);
        this.DocumentElement.Attributes.Append(node);
      }
      node.Value = value;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetAttribute(string name, int value)
    {
      this.SetAttribute(name, value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetAttribute(string name, uint value)
    {
      this.SetAttribute(name, value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetAttribute(string name, long value)
    {
      this.SetAttribute(name, value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetAttribute(string name, ulong value)
    {
      this.SetAttribute(name, value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetAttribute(string name, short value)
    {
      this.SetAttribute(name, value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetAttribute(string name, ushort value)
    {
      this.SetAttribute(name, value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetAttribute(string name, byte value)
    {
      this.SetAttribute(name, value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetAttribute(string name, sbyte value)
    {
      this.SetAttribute(name, value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetAttribute(string name, float value)
    {
      this.SetAttribute(name, value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetAttribute(string name, double value)
    {
      this.SetAttribute(name, value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetAttribute(string name, Decimal value)
    {
      this.SetAttribute(name, value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetAttribute(string name, DateTime value)
    {
      this.SetAttribute(name, value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    protected void SetAttribute(string name, bool value)
    {
      this.SetAttribute(name, value.ToString());
    }

    protected void SetAttribute(string name, Enum value)
    {
      this.SetAttribute(name, ((object) value).ToString());
    }

    protected void SetAttribute(string name, Type value)
    {
      if (value.Assembly.GlobalAssemblyCache)
        this.SetAttribute(name, value.AssemblyQualifiedName);
      else
				this.SetAttribute(name, string.Format("", (object) value.FullName, (object) value.Assembly.GetName().Name));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetAttribute(string name, Guid value)
    {
      this.SetAttribute(name, value.ToString((string) null, (IFormatProvider) CultureInfo.InvariantCulture));
    }
  }
}
