// Type: OpenQuant.Options.ProvidersOptions
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Config;
using OpenQuant.Shared.Options;
using System;
using System.Collections.Generic;
using System.IO;

namespace OpenQuant.Options
{
  internal class ProvidersOptions : ProvidersOptions
  {
    public ProvidersOptions()
    {
      base.\u002Ector(new FileInfo(string.Format("{0}\\providers.config.xml", (object) Global.Setup.Folders.Ini.FullName)), Global.Setup.Folders.Bin);
    }

    protected virtual bool IsPluginInUse(string typeName, string assemblyName)
    {
      using (Dictionary<ConfigurationMode, ConfigurationInfo>.ValueCollection.Enumerator enumerator = ((Dictionary<ConfigurationMode, ConfigurationInfo>) Configuration.GetConfigurations()).Values.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          ConfigurationInfo current = enumerator.Current;
          if (this.Equals(typeName, assemblyName, current.get_MarketDataProvider().GetType()) || this.Equals(typeName, assemblyName, current.get_ExecutionProvider().GetType()))
            return true;
        }
      }
      return false;
    }

    private bool Equals(string typeName, string assemblyName, Type type)
    {
      if (typeName == type.FullName)
        return assemblyName == type.Assembly.GetName().Name;
      else
        return false;
    }
  }
}
