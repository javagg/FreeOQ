// Type: OpenQuant.Projects.StrategySettings
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.API;
using OpenQuant.Trading;
using SmartQuant.Instruments;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace OpenQuant.Projects
{
  internal class StrategySettings
  {
    private InstrumentList instruments = new InstrumentList();
    private Dictionary<StrategyPropertyKey, StrategyProperty> strategyProperties = new Dictionary<StrategyPropertyKey, StrategyProperty>();

    [Browsable(false)]
    public Dictionary<StrategyPropertyKey, StrategyProperty> StrategyProperties
    {
      get
      {
        return this.strategyProperties;
      }
    }

    [Browsable(false)]
    public OpenQuantList<Instrument> Instruments
    {
      get
      {
        return (OpenQuantList<Instrument>) this.instruments;
      }
    }

    public void Populate(StrategyRunner strategyRunner)
    {
      foreach (Instrument instrument in (IEnumerable) this.instruments)
        strategyRunner.get_Instruments().Add(instrument);
    }

    public void Populate(Strategy strategy)
    {
      foreach (StrategyProperty strategyProperty in this.strategyProperties.Values)
        ((object) strategy).GetType().GetField(strategyProperty.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).SetValue((object) strategy, strategyProperty.Value);
    }

    public void Merge(Strategy strategy)
    {
      Dictionary<StrategyPropertyKey, FieldInfo> dictionary1 = new Dictionary<StrategyPropertyKey, FieldInfo>();
      Dictionary<string, FieldInfo> dictionary2 = new Dictionary<string, FieldInfo>();
      foreach (FieldInfo fieldInfo in ((object) strategy).GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
      {
        if ((fieldInfo.FieldType.IsValueType || fieldInfo.FieldType.IsEnum || fieldInfo.FieldType == typeof (string)) && fieldInfo.GetCustomAttributes(typeof (ParameterAttribute), true).Length > 0)
        {
          dictionary1.Add(new StrategyPropertyKey(fieldInfo.Name, fieldInfo.FieldType), fieldInfo);
          if (fieldInfo.FieldType.IsEnum)
            dictionary2[fieldInfo.Name] = fieldInfo;
        }
      }
      List<StrategyPropertyKey> list = new List<StrategyPropertyKey>();
      foreach (StrategyPropertyKey key in this.strategyProperties.Keys)
      {
        if (!dictionary1.ContainsKey(key))
          list.Add(key);
      }
      foreach (StrategyPropertyKey key in list)
      {
        StrategyProperty strategyProperty = this.strategyProperties[key];
        if ((strategyProperty.Type == (Type) null || strategyProperty.Type.IsEnum) && dictionary2.ContainsKey(strategyProperty.Name))
        {
          FieldInfo fieldInfo = dictionary2[strategyProperty.Name];
          if (fieldInfo != (FieldInfo) null && Enum.IsDefined(fieldInfo.FieldType, (object) strategyProperty.Value.ToString()))
          {
            strategyProperty.Type = fieldInfo.FieldType;
            strategyProperty.Value = Enum.Parse(fieldInfo.FieldType, strategyProperty.Value.ToString());
            this.strategyProperties.Add(new StrategyPropertyKey(strategyProperty.Name, strategyProperty.Type), strategyProperty);
          }
        }
        this.strategyProperties.Remove(key);
      }
      foreach (KeyValuePair<StrategyPropertyKey, FieldInfo> keyValuePair in dictionary1)
      {
        StrategyProperty strategyProperty;
        if (this.strategyProperties.ContainsKey(keyValuePair.Key))
        {
          strategyProperty = this.strategyProperties[keyValuePair.Key];
        }
        else
        {
          strategyProperty = this.CreateProperty(keyValuePair.Value, strategy);
          this.strategyProperties.Add(new StrategyPropertyKey(strategyProperty.Name, strategyProperty.Type), strategyProperty);
        }
        this.UpdateValue(strategyProperty, keyValuePair.Value.GetValue((object) strategy));
        this.UpdateAttributes(keyValuePair.Value, strategyProperty);
      }
    }

    private void UpdateValue(StrategyProperty property, object codeValue)
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

    private void UpdateAttributes(FieldInfo field, StrategyProperty strategyProperty)
    {
      object[] customAttributes = field.GetCustomAttributes(typeof (ParameterAttribute), true);
      ParameterAttribute parameterAttribute = (ParameterAttribute) null;
      if (customAttributes.Length > 0)
        parameterAttribute = (ParameterAttribute) customAttributes[0];
      if (parameterAttribute != null)
      {
        strategyProperty.Category = parameterAttribute.get_Category();
        strategyProperty.Description = parameterAttribute.get_Description();
      }
      else
      {
        strategyProperty.Category = "";
        strategyProperty.Description = "";
      }
    }

    private StrategyProperty CreateProperty(FieldInfo field, Strategy strategy)
    {
      return new StrategyProperty(field.Name, field.FieldType, field.GetValue((object) strategy));
    }

    public void Clear()
    {
      this.instruments.Clear();
      this.strategyProperties.Clear();
    }
  }
}
