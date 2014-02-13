using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace FreeQuant.Xml
{
	public abstract class XmlNodeBase
	{
		private XmlNode An8ZGJdGe;

		public abstract string NodeName { get; }

		public static implicit operator XmlNode(XmlNodeBase xmlNodeBase)
		{
			return xmlNodeBase.An8ZGJdGe;
		}

		internal static T YJKde7XAt<T>(XmlNode obj0) where T : XmlNodeBase, new()
		{
			T instance = Activator.CreateInstance<T>();
			instance.An8ZGJdGe = obj0;
			return instance;
		}

		internal static T FwCxuX4sF<T>(XmlNode obj0, string obj1) where T : ValueXmlNode, new()
		{
			T instance = Activator.CreateInstance<T>();
			instance.An8ZGJdGe = obj0;
			instance.pb8cIZ4pY = obj1;
			return instance;
		}

		protected bool ContainsAttribute(string name)
		{
			return this.An8ZGJdGe.Attributes[name] != null;
		}

		protected string GetStringAttribute(string name)
		{
			XmlAttribute xmlAttribute = this.An8ZGJdGe.Attributes[name];
			if (xmlAttribute != null)
				return xmlAttribute.Value;
			else
				return (string)null;
		}

		protected int GetInt32Attribute(string name)
		{
			return int.Parse(this.GetStringAttribute(name), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected uint GetUInt32Attribute(string name)
		{
			return uint.Parse(this.GetStringAttribute(name), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected long GetInt64Attribute(string name)
		{
			return long.Parse(this.GetStringAttribute(name), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected ulong GetUInt64Attribute(string name)
		{
			return ulong.Parse(this.GetStringAttribute(name), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected short GetInt16Attribute(string name)
		{
			return short.Parse(this.GetStringAttribute(name), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected ushort GetUInt16Attribute(string name)
		{
			return ushort.Parse(this.GetStringAttribute(name), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected byte GetByteAttribute(string name)
		{
			return byte.Parse(this.GetStringAttribute(name), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected sbyte GetSByteAttribute(string name)
		{
			return sbyte.Parse(this.GetStringAttribute(name), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected float GetFloatAttribute(string name)
		{
			return float.Parse(this.GetStringAttribute(name), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected double GetDoubleAttribute(string name)
		{
			return double.Parse(this.GetStringAttribute(name), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected Decimal GetDecimalAttribute(string name)
		{
			return Decimal.Parse(this.GetStringAttribute(name), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected DateTime GetDateTimeAttribute(string name)
		{
			return DateTime.Parse(this.GetStringAttribute(name), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected bool GetBooleanAttribute(string name)
		{
			return bool.Parse(this.GetStringAttribute(name));
		}

		protected object GetEnumAttribute(string name, Type type)
		{
			return Enum.Parse(type, this.GetStringAttribute(name));
		}

		protected Type GetTypeAttribute(string name)
		{
			return Type.GetType(this.GetStringAttribute(name));
		}

		protected Guid GetGuidAttribute(string name)
		{
			return new Guid(this.GetStringAttribute(name));
		}

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

		protected void SetAttribute(string name, int value)
		{
			this.SetAttribute(name, value.ToString((IFormatProvider)CultureInfo.InvariantCulture));
		}

		protected void SetAttribute(string name, uint value)
		{
			this.SetAttribute(name, value.ToString((IFormatProvider)CultureInfo.InvariantCulture));
		}

		protected void SetAttribute(string name, long value)
		{
			this.SetAttribute(name, value.ToString((IFormatProvider)CultureInfo.InvariantCulture));
		}

		protected void SetAttribute(string name, ulong value)
		{
			this.SetAttribute(name, value.ToString((IFormatProvider)CultureInfo.InvariantCulture));
		}

		protected void SetAttribute(string name, short value)
		{
			this.SetAttribute(name, value.ToString((IFormatProvider)CultureInfo.InvariantCulture));
		}

		protected void SetAttribute(string name, ushort value)
		{
			this.SetAttribute(name, value.ToString((IFormatProvider)CultureInfo.InvariantCulture));
		}

		protected void SetAttribute(string name, byte value)
		{
			this.SetAttribute(name, value.ToString((IFormatProvider)CultureInfo.InvariantCulture));
		}

		protected void SetAttribute(string name, sbyte value)
		{
			this.SetAttribute(name, value.ToString((IFormatProvider)CultureInfo.InvariantCulture));
		}

		protected void SetAttribute(string name, float value)
		{
			this.SetAttribute(name, value.ToString((IFormatProvider)CultureInfo.InvariantCulture));
		}

		protected void SetAttribute(string name, double value)
		{
			this.SetAttribute(name, value.ToString((IFormatProvider)CultureInfo.InvariantCulture));
		}

		protected void SetAttribute(string name, Decimal value)
		{
			this.SetAttribute(name, value.ToString((IFormatProvider)CultureInfo.InvariantCulture));
		}

		protected void SetAttribute(string name, DateTime value)
		{
			this.SetAttribute(name, value.ToString((IFormatProvider)CultureInfo.InvariantCulture));
		}

		protected void SetAttribute(string name, bool value)
		{
			this.SetAttribute(name, value.ToString());
		}

		protected void SetAttribute(string name, Enum value)
		{
			this.SetAttribute(name, ((object)value).ToString());
		}

		protected void SetAttribute(string name, Type value)
		{
			if (value.Assembly.GlobalAssemblyCache)
				this.SetAttribute(name, value.AssemblyQualifiedName);
			else
				this.SetAttribute(name, string.Format("", (object)value.FullName, (object)value.Assembly.GetName().Name));
		}

		protected void SetAttribute(string name, Guid value)
		{
			this.SetAttribute(name, value.ToString((string)null, (IFormatProvider)CultureInfo.InvariantCulture));
		}

		protected string GetStringValue()
		{
			return this.An8ZGJdGe.InnerText;
		}

		protected int GetInt32Value()
		{
			return int.Parse(this.GetStringValue(), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected int GetInt32Value(int defaultValue)
		{
			int result;
			if (int.TryParse(this.GetStringValue(), NumberStyles.Integer, (IFormatProvider)CultureInfo.InvariantCulture, out result))
				return result;
			else
				return defaultValue;
		}

		protected uint GetUInt32Value()
		{
			return uint.Parse(this.GetStringValue(), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected uint GetUInt32Value(uint defaultValue)
		{
			uint result;
			if (uint.TryParse(this.GetStringValue(), NumberStyles.Integer, (IFormatProvider)CultureInfo.InvariantCulture, out result))
				return result;
			else
				return defaultValue;
		}

		protected long GetInt64Value()
		{
			return long.Parse(this.GetStringValue(), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected long GetInt64Value(long defaultValue)
		{
			long result;
			if (long.TryParse(this.GetStringValue(), NumberStyles.Integer, (IFormatProvider)CultureInfo.InvariantCulture, out result))
				return result;
			else
				return defaultValue;
		}

		protected ulong GetUInt64Value()
		{
			return ulong.Parse(this.GetStringValue(), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected ulong GetUInt64Value(ulong defaultValue)
		{
			ulong result;
			if (ulong.TryParse(this.GetStringValue(), NumberStyles.Integer, (IFormatProvider)CultureInfo.InvariantCulture, out result))
				return result;
			else
				return defaultValue;
		}

		protected short GetInt16Value()
		{
			return short.Parse(this.GetStringValue(), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected short GetInt16Value(short defaultValue)
		{
			short result;
			if (short.TryParse(this.GetStringValue(), NumberStyles.Integer, (IFormatProvider)CultureInfo.InvariantCulture, out result))
				return result;
			else
				return defaultValue;
		}

		protected ushort GetUInt16Value()
		{
			return ushort.Parse(this.GetStringValue(), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected ushort GetUInt16Value(ushort defaultValue)
		{
			ushort result;
			if (ushort.TryParse(this.GetStringValue(), NumberStyles.Integer, (IFormatProvider)CultureInfo.InvariantCulture, out result))
				return result;
			else
				return defaultValue;
		}

		protected byte GetByteValue()
		{
			return byte.Parse(this.GetStringValue(), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected byte GetByteValue(byte defaultValue)
		{
			byte result;
			if (byte.TryParse(this.GetStringValue(), NumberStyles.Integer, (IFormatProvider)CultureInfo.InvariantCulture, out result))
				return result;
			else
				return defaultValue;
		}

		protected sbyte GetSByteValue()
		{
			return sbyte.Parse(this.GetStringValue(), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected sbyte GetSByteValue(sbyte defaultValue)
		{
			sbyte result;
			if (sbyte.TryParse(this.GetStringValue(), NumberStyles.Integer, (IFormatProvider)CultureInfo.InvariantCulture, out result))
				return result;
			else
				return defaultValue;
		}

		protected float GetFloatValue()
		{
			return float.Parse(this.GetStringValue(), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected float GetFloatValue(float defaultValue)
		{
			float result;
			if (float.TryParse(this.GetStringValue(), NumberStyles.Float | NumberStyles.AllowThousands, (IFormatProvider)CultureInfo.InvariantCulture, out result))
				return result;
			else
				return defaultValue;
		}

		protected double GetDoubleValue()
		{
			return double.Parse(this.GetStringValue(), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected double GetDoubleValue(double defaultValue)
		{
			double result;
			if (double.TryParse(this.GetStringValue(), NumberStyles.Float | NumberStyles.AllowThousands, (IFormatProvider)CultureInfo.InvariantCulture, out result))
				return result;
			else
				return defaultValue;
		}

		protected Decimal GetDecimalValue()
		{
			return Decimal.Parse(this.GetStringValue(), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected Decimal GetDecimalValue(Decimal defaultValue)
		{
			Decimal result;
			if (Decimal.TryParse(this.GetStringValue(), NumberStyles.Number, (IFormatProvider)CultureInfo.InvariantCulture, out result))
				return result;
			else
				return defaultValue;
		}

		protected DateTime GetDateTimeValue()
		{
			return DateTime.Parse(this.GetStringValue(), (IFormatProvider)CultureInfo.InvariantCulture);
		}

		protected DateTime GetDateTimeValue(DateTime defaultValue)
		{
			DateTime result;
			if (DateTime.TryParse(this.GetStringValue(), (IFormatProvider)CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
				return result;
			else
				return defaultValue;
		}

		protected bool GetBooleanValue()
		{
			return bool.Parse(this.GetStringValue());
		}

		protected bool GetBooleanValue(bool defaultValue)
		{
			bool result;
			if (bool.TryParse(this.GetStringValue(), out result))
				return result;
			else
				return defaultValue;
		}

		protected object GetEnumValue(Type type)
		{
			return Enum.Parse(type, this.GetStringValue());
		}

		protected T GetEnumValue<T>(T defaultValue) where T : struct
		{
			T result;
			if (Enum.TryParse<T>(this.GetStringValue(), out result))
				return result;
			else
				return defaultValue;
		}

		protected Type GetTypeValue()
		{
			return Type.GetType(this.GetStringValue());
		}

		protected Guid GetGuidValue()
		{
			return new Guid(this.GetStringValue());
		}

		protected Guid GetGuidValue(Guid defaultValue)
		{
			Guid result;
			if (Guid.TryParse(this.GetStringValue(), out result))
				return result;
			else
				return defaultValue;
		}

		protected void SetValue(string value)
		{
			this.An8ZGJdGe.InnerText = value;
		}

		protected void SetValue(int value)
		{
			this.SetValue(value.ToString());
		}

		protected void SetValue(uint value)
		{
			this.SetValue(value.ToString());
		}

		protected void SetValue(long value)
		{
			this.SetValue(value.ToString());
		}

		protected void SetValue(ulong value)
		{
			this.SetValue(value.ToString());
		}

		protected void SetValue(short value)
		{
			this.SetValue(value.ToString());
		}

		protected void SetValue(ushort value)
		{
			this.SetValue(value.ToString());
		}

		protected void SetValue(byte value)
		{
			this.SetValue(value.ToString());
		}

		protected void SetValue(sbyte value)
		{
			this.SetValue(value.ToString());
		}

		protected void SetValue(double value)
		{
			this.SetValue(value.ToString((IFormatProvider)CultureInfo.InvariantCulture));
		}

		protected void SetValue(float value)
		{
			this.SetValue(value.ToString((IFormatProvider)CultureInfo.InvariantCulture));
		}

		protected void SetValue(Decimal value)
		{
			this.SetValue(value.ToString((IFormatProvider)CultureInfo.InvariantCulture));
		}

		protected void SetValue(DateTime value)
		{
			this.SetValue(value.ToString((IFormatProvider)CultureInfo.InvariantCulture));
		}

		protected void SetValue(bool value)
		{
			this.SetValue(value.ToString());
		}

		protected void SetValue(Enum value)
		{
			this.SetValue(((object)value).ToString());
		}

		protected void SetValue(Type value)
		{
			if (value.Assembly.GlobalAssemblyCache)
				this.SetValue(value.AssemblyQualifiedName);
			else
				this.SetValue(string.Format("", (object)value.FullName, (object)value.Assembly.GetName().Name));
		}

		protected void SetValue(Guid value)
		{
			this.SetValue(value.ToString((string)null, (IFormatProvider)CultureInfo.InvariantCulture));
		}

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

		protected T GetChildNode<T>(string name) where T : ValueXmlNode, new()
		{
			foreach (XmlNode xmlNode in this.An8ZGJdGe)
			{
				if (xmlNode.Name == name)
					return XmlNodeBase.FwCxuX4sF<T>(xmlNode, name);
			}
			return this.AppendChildNode<T>(name);
		}

		protected T AppendChildNode<T>() where T : XmlNodeBase, new()
		{
			T obj = XmlNodeBase.YJKde7XAt<T>((XmlNode)this.An8ZGJdGe.OwnerDocument.CreateElement(Activator.CreateInstance<T>().NodeName));
			this.An8ZGJdGe.AppendChild((XmlNode)((XmlNodeBase)obj));
			return obj;
		}

		protected T AppendChildNode<T>(string name) where T : ValueXmlNode, new()
		{
			T obj = XmlNodeBase.YJKde7XAt<T>((XmlNode)this.An8ZGJdGe.OwnerDocument.CreateElement(name));
			this.An8ZGJdGe.AppendChild((XmlNode)((XmlNodeBase)obj));
			return obj;
		}

		protected StringValueXmlNode GetStringValueNode(string name)
		{
			return this.GetChildNode<StringValueXmlNode>(name);
		}

		protected BooleanValueXmlNode GetBooleanValueNode(string name)
		{
			return this.GetChildNode<BooleanValueXmlNode>(name);
		}

		protected ByteValueXmlNode GetByteValueNode(string name)
		{
			return this.GetChildNode<ByteValueXmlNode>(name);
		}

		protected DateTimeValueXmlNode GetDateTimeValueNode(string name)
		{
			return this.GetChildNode<DateTimeValueXmlNode>(name);
		}

		protected DecimalValueXmlNode GetDecimalValueNode(string name)
		{
			return this.GetChildNode<DecimalValueXmlNode>(name);
		}

		protected DoubleValueXmlNode GetDoubleValueNode(string name)
		{
			return this.GetChildNode<DoubleValueXmlNode>(name);
		}

		protected FloatValueXmlNode GetFloatValueNode(string name)
		{
			return this.GetChildNode<FloatValueXmlNode>(name);
		}

		protected GuidValueXmlNode GetGuidValueNode(string name)
		{
			return this.GetChildNode<GuidValueXmlNode>(name);
		}

		protected Int16ValueXmlNode GetInt16ValueNode(string name)
		{
			return this.GetChildNode<Int16ValueXmlNode>(name);
		}

		protected Int32ValueXmlNode GetInt32ValueNode(string name)
		{
			return this.GetChildNode<Int32ValueXmlNode>(name);
		}

		protected Int64ValueXmlNode GetInt64ValueNode(string name)
		{
			return this.GetChildNode<Int64ValueXmlNode>(name);
		}

		protected TypeValueXmlNode GetTypeValueNode(string name)
		{
			return this.GetChildNode<TypeValueXmlNode>(name);
		}

		protected EnumValueXmlNode<T> GetEnumValueXmlNode<T>(string name) where T : struct
		{
			return this.GetChildNode<EnumValueXmlNode<T>>(name);
		}
	}
}
