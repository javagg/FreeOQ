// Type: OpenQuant.Options.ConfigurationOptions
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Config;
using OpenQuant.Options.Xml;
using OpenQuant.Shared.Options;
using System;
using System.Collections.Generic;
using System.IO;

namespace OpenQuant.Options
{
  internal class ConfigurationOptions : ConfigurationOptions
  {
    private const string FILENAME = "configuration.xml";

    public ProvidersOptions Providers
    {
      get
      {
        return (ProvidersOptions) ((OptionsBase) this).GetSubOptions<ProvidersOptions>();
      }
    }

    public ConfigurationOptions()
    {
      base.\u002Ector(Global.Setup.Folders.get_Base(), Global.Setup.Folders.AppData);
      ((OptionsBase) this).Add((OptionsBase) new ProvidersOptions());
      ((OptionsBase) this).Add((OptionsBase) new ConfigurationModeOptions());
      Configuration.add_ConfigurationModeChanged(new EventHandler(this.Configuration_ConfigurationModeChanged));
    }

    protected virtual void OnSave()
    {
      ConfigurationXmlDocument configurationXmlDocument = new ConfigurationXmlDocument();
      configurationXmlDocument.ActiveMode.Value = Configuration.get_ActiveMode();
      using (Dictionary<ConfigurationMode, ConfigurationInfo>.Enumerator enumerator = ((Dictionary<ConfigurationMode, ConfigurationInfo>) Configuration.GetConfigurations()).GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          KeyValuePair<ConfigurationMode, ConfigurationInfo> current = enumerator.Current;
          configurationXmlDocument.Modes.Add(current.Key, current.Value);
        }
      }
      configurationXmlDocument.Save(this.GetConfigurationFileName());
    }

    protected virtual void OnLoad()
    {
      string configurationFileName = this.GetConfigurationFileName();
      ConfigurationInfoList configurationInfoList = new ConfigurationInfoList();
      ConfigurationMode configurationMode;
      if (File.Exists(configurationFileName))
      {
        ConfigurationXmlDocument configurationXmlDocument = new ConfigurationXmlDocument();
        configurationXmlDocument.Load(configurationFileName);
        configurationMode = configurationXmlDocument.ActiveMode.Value;
        foreach (ConfigurationModeXmlNode configurationModeXmlNode in configurationXmlDocument.Modes)
          ((Dictionary<ConfigurationMode, ConfigurationInfo>) configurationInfoList).Add(configurationModeXmlNode.Mode, new ConfigurationInfo(configurationModeXmlNode.Portfolio.PortfolioName, configurationModeXmlNode.MarketDataProvider.ProviderId, configurationModeXmlNode.ExecutionProvider.ProviderId));
      }
      else
      {
        configurationMode = (ConfigurationMode) 0;
        ((Dictionary<ConfigurationMode, ConfigurationInfo>) configurationInfoList).Add((ConfigurationMode) 0, new ConfigurationInfo());
        ((Dictionary<ConfigurationMode, ConfigurationInfo>) configurationInfoList).Add((ConfigurationMode) 1, new ConfigurationInfo());
        ((Dictionary<ConfigurationMode, ConfigurationInfo>) configurationInfoList).Add((ConfigurationMode) 2, new ConfigurationInfo());
      }
      Configuration.Init(configurationMode, configurationInfoList);
    }

    private string GetConfigurationFileName()
    {
      return string.Format("{0}\\{1}", (object) Global.Setup.Folders.Ini.FullName, (object) "configuration.xml");
    }

    private void Configuration_ConfigurationModeChanged(object sender, EventArgs e)
    {
      ((OptionsBase) this).Save();
    }
  }
}
