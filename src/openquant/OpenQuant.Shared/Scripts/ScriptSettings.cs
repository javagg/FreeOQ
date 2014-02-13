using OpenQuant.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

namespace OpenQuant.Shared.Scripts
{
	class ScriptSettings
	{
		private Dictionary<ScriptPropertyKey, ScriptProperty> scriptProperties = new Dictionary<ScriptPropertyKey, ScriptProperty>();
		private FileInfo settingsFile;

		public bool Autostart { get; set; }

		public Script Script { get; set; }

		[Browsable(false)]
		public Dictionary<ScriptPropertyKey, ScriptProperty> ScriptProperties
		{
			get
			{
				return this.scriptProperties;
			}
		}

		public ScriptSettings(FileInfo scriptFile)
		{
			this.settingsFile = new FileInfo(scriptFile.FullName + ".settings");
			if (!scriptFile.Exists)
				return;
			this.Load();
		}

		public void Save()
		{
			XElement xelement1 = new XElement("Script");
			XElement xelement2 = new XElement("Parameters");
			xelement1.Add(xelement2);
			foreach (ScriptProperty scriptProperty in this.scriptProperties.Values)
			{
				object obj = scriptProperty.Value;
				Type type = obj.GetType();
				if (obj != null)
				{
					XElement xelement3 = new XElement(scriptProperty.Name);
					xelement2.Add(xelement3);
					string str;
					if (type == typeof(Color))
					{
						Color color = (Color)obj;
						str = (string)(object)color.A + "," + (string)(object)color.R + "," + (string)(object)color.G + "," + (string)(object)color.B;
					}
					else if (type.IsEnum)
						str = obj.ToString();
					else if (typeof(IConvertible).IsAssignableFrom(type))
						str = (string)Convert.ChangeType(obj, typeof(string), (IFormatProvider)NumberFormatInfo.InvariantInfo);
					else if (type == typeof(TimeSpan))
						str = obj.ToString();
					else
						continue;
					xelement3.Value = str;
					XAttribute xattribute1 = new XAttribute("Type", !type.Assembly.GlobalAssemblyCache ? string.Format("{0}, {1}", type.FullName, type.Assembly.GetName().Name) : type.AssemblyQualifiedName);
					xelement3.Add(xattribute1);
					XAttribute xattribute2 = new XAttribute("IsEnum", type.IsEnum);
					xelement3.Add(xattribute2);
					XAttribute xattribute3 = new XAttribute("Category", scriptProperty.Category);
					xelement3.Add(xattribute3);
					XAttribute xattribute4 = new XAttribute("Description", scriptProperty.Description);
					xelement3.Add(xattribute4);
				}
			}
			xelement1.Save(this.settingsFile.FullName);
		}

		private void Load()
		{
			if (!this.settingsFile.Exists)
				return;
			foreach (XElement xelement in XElement.Load(this.settingsFile.FullName).Element( "Parameters").Nodes())
			{
				string typeName = "";
				if (xelement.Attribute("Type") != null)
					typeName = xelement.Attribute("Type").Value;
				Type type = Type.GetType(typeName);
				bool result = false;
				if (xelement.Attribute("IsEnum") != null)
					bool.TryParse(xelement.Attribute("IsEnum").Value, out result);
				if (!(type == null) || result)
				{
					string description = "";
					if (xelement.Attribute("Description") != null)
						description = xelement.Attribute("Description").Value;
					string category = "";
					if (xelement.Attribute("Category") != null)
						category = xelement.Attribute("Category").Value;
					object obj;
					if (type != null)
					{
						if (type.IsEnum)
							obj = Enum.Parse(type, xelement.Value);
						else if (type == typeof(Color))
						{
							string[] strArray = xelement.Value.Split(new char[1]
							{
								','
							});
							obj = Color.FromArgb(int.Parse(strArray[0]), int.Parse(strArray[1]), int.Parse(strArray[2]), int.Parse(strArray[3]));
						}
						else if (typeof(IConvertible).IsAssignableFrom(type))
							obj = Convert.ChangeType(xelement.Value, type, (IFormatProvider)NumberFormatInfo.InvariantInfo);
						else if (type == typeof(TimeSpan))
							obj = TimeSpan.Parse(xelement.Value);
						else
							continue;
					}
					else
					{
						obj = xelement.Value;
						if (this.Script != null)
						{
							FieldInfo field = this.Script.GetType().GetField(xelement.Name.ToString(), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
							if (field != (FieldInfo)null && field.FieldType.IsEnum)
							{
								type = field.FieldType;
								if (Enum.IsDefined(field.FieldType, xelement.Value))
									obj = Enum.Parse(field.FieldType, xelement.Value);
							}
						}
					}
					this.scriptProperties.Add(new ScriptPropertyKey(xelement.Name.ToString(), type), new ScriptProperty(xelement.Name.ToString(), type, obj, category, description));
				}
			}
		}

		public void Populate(Script script)
		{
			foreach (ScriptProperty scriptProperty in this.scriptProperties.Values)
				script.GetType().GetField(scriptProperty.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).SetValue(script, scriptProperty.Value);
		}

		public void Merge(Script script)
		{
			Dictionary<ScriptPropertyKey, FieldInfo> dictionary1 = new Dictionary<ScriptPropertyKey, FieldInfo>();
			Dictionary<string, FieldInfo> dictionary2 = new Dictionary<string, FieldInfo>();
			foreach (FieldInfo fieldInfo in script.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			{
				if ((fieldInfo.FieldType.IsValueType || fieldInfo.FieldType.IsEnum || fieldInfo.FieldType == typeof(string)) && fieldInfo.GetCustomAttributes(typeof(ParameterAttribute), true).Length > 0)
				{
					dictionary1.Add(new ScriptPropertyKey(fieldInfo.Name, fieldInfo.FieldType), fieldInfo);
					if (fieldInfo.FieldType.IsEnum)
						dictionary2[fieldInfo.Name] = fieldInfo;
				}
			}
			List<ScriptPropertyKey> list = new List<ScriptPropertyKey>();
			foreach (ScriptPropertyKey key in this.scriptProperties.Keys)
			{
				if (!dictionary1.ContainsKey(key))
					list.Add(key);
			}
			foreach (ScriptPropertyKey key in list)
			{
				ScriptProperty scriptProperty = this.scriptProperties[key];
				if ((scriptProperty.Type == (Type)null || scriptProperty.Type.IsEnum) && dictionary2.ContainsKey(scriptProperty.Name))
				{
					FieldInfo fieldInfo = dictionary2[scriptProperty.Name];
					if (fieldInfo != (FieldInfo)null && Enum.IsDefined(fieldInfo.FieldType, scriptProperty.Value.ToString()))
					{
						scriptProperty.Type = fieldInfo.FieldType;
						scriptProperty.Value = Enum.Parse(fieldInfo.FieldType, scriptProperty.Value.ToString());
						this.scriptProperties.Add(new ScriptPropertyKey(scriptProperty.Name, scriptProperty.Type), scriptProperty);
					}
				}
				this.scriptProperties.Remove(key);
			}
			foreach (KeyValuePair<ScriptPropertyKey, FieldInfo> keyValuePair in dictionary1)
			{
				ScriptProperty scriptProperty;
				if (this.scriptProperties.ContainsKey(keyValuePair.Key))
				{
					scriptProperty = this.scriptProperties[keyValuePair.Key];
				}
				else
				{
					scriptProperty = this.CreateProperty(keyValuePair.Value, script);
					this.scriptProperties.Add(new ScriptPropertyKey(scriptProperty.Name, scriptProperty.Type), scriptProperty);
				}
				this.UpdateValue(scriptProperty, keyValuePair.Value.GetValue(script));
				this.UpdateAttributes(keyValuePair.Value, scriptProperty);
			}
		}

		private void UpdateValue(ScriptProperty property, object codeValue)
		{
			if (property.CodeValue == null)
				property.CodeValue = codeValue;
			if (this.EqualValues(property.CodeValue, codeValue))
				return;
			property.Value = codeValue;
			property.CodeValue = codeValue;
		}

		public bool EqualValues(object o1, object o2)
		{
			if (o1 == null && o2 == null)
				return true;
			if (o1 == null || o2 == null)
				return false;
			if (o1.GetType().IsEnum && o2.GetType().IsEnum && o1.ToString() == o2.ToString())
				return true;
			else
				return object.Equals(o1, o2);
		}

		private void UpdateAttributes(FieldInfo field, ScriptProperty scriptProperty)
		{
			object[] customAttributes = field.GetCustomAttributes(typeof(ParameterAttribute), true);
			ParameterAttribute parameterAttribute = (ParameterAttribute)null;
			if (customAttributes.Length > 0)
				parameterAttribute = (ParameterAttribute)customAttributes[0];
			if (parameterAttribute != null)
			{
				scriptProperty.Category = parameterAttribute.Category;
				scriptProperty.Description = parameterAttribute.Description;
			}
			else
			{
				scriptProperty.Category = "";
				scriptProperty.Description = "";
			}
		}

		private ScriptProperty CreateProperty(FieldInfo field, Script script)
		{
			return new ScriptProperty(field.Name, field.FieldType, field.GetValue(script));
		}

		public void Clear()
		{
			this.scriptProperties.Clear();
		}
	}
}
