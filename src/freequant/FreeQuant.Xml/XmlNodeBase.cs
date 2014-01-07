// Type: SmartQuant.Xml.XmlNodeBase
// Assembly: SmartQuant.Xml, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 4C8F4348-49D3-4BAF-ACAF-1FA08F95BF23
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Xml.dll

using naygH2hw2me9oFIyF5;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;
using wOTnoM0h260SstC0xu;

namespace SmartQuant.Xml
{
  public abstract class XmlNodeBase
  {
    private XmlNode An8ZGJdGe;

    public abstract string NodeName { get; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected XmlNodeBase()
    {
      wCdHLSBd0jEmbylf8M.oiA62Aizl0hxD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator XmlNode(XmlNodeBase xmlNodeBase)
    {
      return xmlNodeBase.An8ZGJdGe;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static T YJKde7XAt<T>([In] XmlNode obj0) where T : XmlNodeBase, new()
    {
      T instance = Activator.CreateInstance<T>();
      instance.An8ZGJdGe = obj0;
      return instance;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static T FwCxuX4sF<T>([In] XmlNode obj0, [In] string obj1) where T : ValueXmlNode, new()
    {
      T instance = Activator.CreateInstance<T>();
      instance.An8ZGJdGe = obj0;
      instance.pb8cIZ4pY = obj1;
      return instance;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool ContainsAttribute(string name)
    {
      return this.An8ZGJdGe.Attributes[name] != null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected string GetStringAttribute(string name)
    {
      XmlAttribute xmlAttribute = this.An8ZGJdGe.Attributes[name];
      if (xmlAttribute != null)
        return xmlAttribute.Value;
      else
        return (string) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected int GetInt32Attribute(string name)
    {
      return int.Parse(this.GetStringAttribute(name), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
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

    [MethodImpl(MethodImplOptions.NoInlining)]
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
      XmlAttribute node = this.An8ZGJdGe.Attributes[name];
      if (node == null)
      {
        node = this.An8ZGJdGe.OwnerDocument.CreateAttribute(name);
        this.An8ZGJdGe.Attributes.Append(node);
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetAttribute(string name, bool value)
    {
      this.SetAttribute(name, value.ToString());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetAttribute(string name, Enum value)
    {
      this.SetAttribute(name, ((object) value).ToString());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetAttribute(string name, Type value)
    {
      if (value.Assembly.GlobalAssemblyCache)
        this.SetAttribute(name, value.AssemblyQualifiedName);
      else
        this.SetAttribute(name, string.Format(adDoDiJH1mdTdOllhW.JY4ws5fy8(0), (object) value.FullName, (object) value.Assembly.GetName().Name));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetAttribute(string name, Guid value)
    {
      this.SetAttribute(name, value.ToString((string) null, (IFormatProvider) CultureInfo.InvariantCulture));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected string GetStringValue()
    {
      return this.An8ZGJdGe.InnerText;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected int GetInt32Value()
    {
      return int.Parse(this.GetStringValue(), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected int GetInt32Value(int defaultValue)
    {
      int result;
      if (int.TryParse(this.GetStringValue(), NumberStyles.Integer, (IFormatProvider) CultureInfo.InvariantCulture, out result))
        return result;
      else
        return defaultValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected uint GetUInt32Value()
    {
      return uint.Parse(this.GetStringValue(), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected uint GetUInt32Value(uint defaultValue)
    {
      uint result;
      if (uint.TryParse(this.GetStringValue(), NumberStyles.Integer, (IFormatProvider) CultureInfo.InvariantCulture, out result))
        return result;
      else
        return defaultValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected long GetInt64Value()
    {
      return long.Parse(this.GetStringValue(), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected long GetInt64Value(long defaultValue)
    {
      long result;
      if (long.TryParse(this.GetStringValue(), NumberStyles.Integer, (IFormatProvider) CultureInfo.InvariantCulture, out result))
        return result;
      else
        return defaultValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ulong GetUInt64Value()
    {
      return ulong.Parse(this.GetStringValue(), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ulong GetUInt64Value(ulong defaultValue)
    {
      ulong result;
      if (ulong.TryParse(this.GetStringValue(), NumberStyles.Integer, (IFormatProvider) CultureInfo.InvariantCulture, out result))
        return result;
      else
        return defaultValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected short GetInt16Value()
    {
      return short.Parse(this.GetStringValue(), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected short GetInt16Value(short defaultValue)
    {
      short result;
      if (short.TryParse(this.GetStringValue(), NumberStyles.Integer, (IFormatProvider) CultureInfo.InvariantCulture, out result))
        return result;
      else
        return defaultValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ushort GetUInt16Value()
    {
      return ushort.Parse(this.GetStringValue(), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ushort GetUInt16Value(ushort defaultValue)
    {
      ushort result;
      if (ushort.TryParse(this.GetStringValue(), NumberStyles.Integer, (IFormatProvider) CultureInfo.InvariantCulture, out result))
        return result;
      else
        return defaultValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected byte GetByteValue()
    {
      return byte.Parse(this.GetStringValue(), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected byte GetByteValue(byte defaultValue)
    {
      byte result;
      if (byte.TryParse(this.GetStringValue(), NumberStyles.Integer, (IFormatProvider) CultureInfo.InvariantCulture, out result))
        return result;
      else
        return defaultValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected sbyte GetSByteValue()
    {
      return sbyte.Parse(this.GetStringValue(), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected sbyte GetSByteValue(sbyte defaultValue)
    {
      sbyte result;
      if (sbyte.TryParse(this.GetStringValue(), NumberStyles.Integer, (IFormatProvider) CultureInfo.InvariantCulture, out result))
        return result;
      else
        return defaultValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected float GetFloatValue()
    {
      return float.Parse(this.GetStringValue(), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected float GetFloatValue(float defaultValue)
    {
      float result;
      if (float.TryParse(this.GetStringValue(), NumberStyles.Float | NumberStyles.AllowThousands, (IFormatProvider) CultureInfo.InvariantCulture, out result))
        return result;
      else
        return defaultValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected double GetDoubleValue()
    {
      return double.Parse(this.GetStringValue(), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected double GetDoubleValue(double defaultValue)
    {
      double result;
      if (double.TryParse(this.GetStringValue(), NumberStyles.Float | NumberStyles.AllowThousands, (IFormatProvider) CultureInfo.InvariantCulture, out result))
        return result;
      else
        return defaultValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Decimal GetDecimalValue()
    {
      return Decimal.Parse(this.GetStringValue(), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Decimal GetDecimalValue(Decimal defaultValue)
    {
      Decimal result;
      if (Decimal.TryParse(this.GetStringValue(), NumberStyles.Number, (IFormatProvider) CultureInfo.InvariantCulture, out result))
        return result;
      else
        return defaultValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected DateTime GetDateTimeValue()
    {
      return DateTime.Parse(this.GetStringValue(), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected DateTime GetDateTimeValue(DateTime defaultValue)
    {
      DateTime result;
      if (DateTime.TryParse(this.GetStringValue(), (IFormatProvider) CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
        return result;
      else
        return defaultValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool GetBooleanValue()
    {
      return bool.Parse(this.GetStringValue());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool GetBooleanValue(bool defaultValue)
    {
      bool result;
      if (bool.TryParse(this.GetStringValue(), out result))
        return result;
      else
        return defaultValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected object GetEnumValue(Type type)
    {
      return Enum.Parse(type, this.GetStringValue());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected T GetEnumValue<T>(T defaultValue) where T : struct
    {
      T result;
      if (Enum.TryParse<T>(this.GetStringValue(), out result))
        return result;
      else
        return defaultValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Type GetTypeValue()
    {
      return Type.GetType(this.GetStringValue());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Guid GetGuidValue()
    {
      return new Guid(this.GetStringValue());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Guid GetGuidValue(Guid defaultValue)
    {
      Guid result;
      if (Guid.TryParse(this.GetStringValue(), out result))
        return result;
      else
        return defaultValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetValue(string value)
    {
      this.An8ZGJdGe.InnerText = value;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetValue(int value)
    {
      this.SetValue(value.ToString());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetValue(uint value)
    {
      this.SetValue(value.ToString());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetValue(long value)
    {
      this.SetValue(value.ToString());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetValue(ulong value)
    {
      this.SetValue(value.ToString());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetValue(short value)
    {
      this.SetValue(value.ToString());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetValue(ushort value)
    {
      this.SetValue(value.ToString());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetValue(byte value)
    {
      this.SetValue(value.ToString());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetValue(sbyte value)
    {
      this.SetValue(value.ToString());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetValue(double value)
    {
      this.SetValue(value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetValue(float value)
    {
      this.SetValue(value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetValue(Decimal value)
    {
      this.SetValue(value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetValue(DateTime value)
    {
      this.SetValue(value.ToString((IFormatProvider) CultureInfo.InvariantCulture));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetValue(bool value)
    {
      this.SetValue(value.ToString());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetValue(Enum value)
    {
      this.SetValue(((object) value).ToString());
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetValue(Type value)
    {
      if (value.Assembly.GlobalAssemblyCache)
        this.SetValue(value.AssemblyQualifiedName);
      else
        this.SetValue(string.Format(adDoDiJH1mdTdOllhW.JY4ws5fy8(20), (object) value.FullName, (object) value.Assembly.GetName().Name));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetValue(Guid value)
    {
      this.SetValue(value.ToString((string) null, (IFormatProvider) CultureInfo.InvariantCulture));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected List<T> GetChildNodes<T>() where T : XmlNodeBase, new()
    {
      string nodeName = Activator.CreateInstance<T>().NodeName;
      List<T> list = new List<T>();
      foreach (XmlNode xmlNode in this.An8ZGJdGe)
      {
        if (xmlNode.Name == nodeName)
          list.Add(XmlNodeBase.YJKde7XAt<T>(xmlNode));
      }
      return list;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected T GetChildNode<T>() where T : XmlNodeBase, new()
    {
      string nodeName = Activator.CreateInstance<T>().NodeName;
      foreach (XmlNode xmlNode in this.An8ZGJdGe)
      {
        if (xmlNode.Name == nodeName)
          return XmlNodeBase.YJKde7XAt<T>(xmlNode);
      }
      return this.AppendChildNode<T>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected T GetChildNode<T>(string name) where T : ValueXmlNode, new()
    {
      foreach (XmlNode xmlNode in this.An8ZGJdGe)
      {
        if (xmlNode.Name == name)
          return XmlNodeBase.FwCxuX4sF<T>(xmlNode, name);
      }
      return this.AppendChildNode<T>(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected T AppendChildNode<T>() where T : XmlNodeBase, new()
    {
      T obj = XmlNodeBase.YJKde7XAt<T>((XmlNode) this.An8ZGJdGe.OwnerDocument.CreateElement(Activator.CreateInstance<T>().NodeName));
      this.An8ZGJdGe.AppendChild((XmlNode) ((XmlNodeBase) obj));
      return obj;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected T AppendChildNode<T>(string name) where T : ValueXmlNode, new()
    {
      T obj = XmlNodeBase.YJKde7XAt<T>((XmlNode) this.An8ZGJdGe.OwnerDocument.CreateElement(name));
      this.An8ZGJdGe.AppendChild((XmlNode) ((XmlNodeBase) obj));
      return obj;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected StringValueXmlNode GetStringValueNode(string name)
    {
      return this.GetChildNode<StringValueXmlNode>(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected BooleanValueXmlNode GetBooleanValueNode(string name)
    {
      return this.GetChildNode<BooleanValueXmlNode>(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ByteValueXmlNode GetByteValueNode(string name)
    {
      return this.GetChildNode<ByteValueXmlNode>(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected DateTimeValueXmlNode GetDateTimeValueNode(string name)
    {
      return this.GetChildNode<DateTimeValueXmlNode>(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected DecimalValueXmlNode GetDecimalValueNode(string name)
    {
      return this.GetChildNode<DecimalValueXmlNode>(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected DoubleValueXmlNode GetDoubleValueNode(string name)
    {
      return this.GetChildNode<DoubleValueXmlNode>(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected FloatValueXmlNode GetFloatValueNode(string name)
    {
      return this.GetChildNode<FloatValueXmlNode>(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected GuidValueXmlNode GetGuidValueNode(string name)
    {
      return this.GetChildNode<GuidValueXmlNode>(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Int16ValueXmlNode GetInt16ValueNode(string name)
    {
      return this.GetChildNode<Int16ValueXmlNode>(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Int32ValueXmlNode GetInt32ValueNode(string name)
    {
      return this.GetChildNode<Int32ValueXmlNode>(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Int64ValueXmlNode GetInt64ValueNode(string name)
    {
      return this.GetChildNode<Int64ValueXmlNode>(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected TypeValueXmlNode GetTypeValueNode(string name)
    {
      return this.GetChildNode<TypeValueXmlNode>(name);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected EnumValueXmlNode<T> GetEnumValueXmlNode<T>(string name) where T : struct
    {
      return this.GetChildNode<EnumValueXmlNode<T>>(name);
    }
  }
}
