using OpenQuant.Shared;
using System;
using System.IO;
using System.Xml;

namespace OpenQuant.Shared.Options
{
  [OptionsNode("Providers", typeof (ProvidersOptionsPanel))]
  public class ProvidersOptions : OptionsBase
  {
    private FileInfo configFile;

    internal DirectoryInfo BinDirectory { get; private set; }

    internal int ConnectionTimeout
    {
      get
      {
        return (int) Global.ProviderHelper.ConnectionTimeout.TotalSeconds;
      }
      set
      {
        Global.ProviderHelper.ConnectionTimeout = TimeSpan.FromSeconds((double) value);
      }
    }

    public ProvidersOptions(FileInfo configFile, DirectoryInfo binDirectory)
    {
      this.configFile = configFile;
      this.BinDirectory = binDirectory;
    }

    protected override void OnLoad()
    {
      if (!this.configFile.Exists)
        return;
      ProvidersXmlDocument providersXmlDocument = new ProvidersXmlDocument();
      ((XmlDocument) providersXmlDocument).Load(this.configFile.FullName);
      this.ConnectionTimeout = providersXmlDocument.Settings.ConnectionTimeout.Value;
    }

    protected override void OnSave()
    {
      ProvidersXmlDocument providersXmlDocument = new ProvidersXmlDocument();
			providersXmlDocument.Settings.ConnectionTimeout.Value = this.ConnectionTimeout;
      ((XmlDocument) providersXmlDocument).Save(this.configFile.FullName);
    }

    protected internal virtual bool IsPluginInUse(string typeName, string assemblyName)
    {
      return false;
    }
  }
}
