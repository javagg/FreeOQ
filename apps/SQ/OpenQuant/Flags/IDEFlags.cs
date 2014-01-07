// Type: OpenQuant.Flags.IDEFlags
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Config;
using System.IO;

namespace OpenQuant.Flags
{
  internal class IDEFlags
  {
    private const string FILENAME = "flags.xml";
    private const bool DEFAULT_UPDATE_UI = false;
    private bool updateUI;

    public bool UpdateUIRawValue
    {
      get
      {
        return this.updateUI;
      }
      set
      {
        this.updateUI = value;
      }
    }

    public bool ApplicationClosing { get; set; }

    public bool UpdateUI
    {
      get
      {
        if (Configuration.get_ActiveMode() == null)
          return this.updateUI;
        else
          return true;
      }
    }

    public void Load()
    {
      string configurationFileName = this.GetConfigurationFileName();
      if (File.Exists(configurationFileName))
      {
        FlagsXmlDocument flagsXmlDocument = new FlagsXmlDocument();
        flagsXmlDocument.Load(configurationFileName);
        this.updateUI = flagsXmlDocument.UpdateUI.Value;
      }
      else
        this.updateUI = false;
    }

    public void Save()
    {
      new FlagsXmlDocument()
      {
        UpdateUI = {
          Value = this.updateUI
        }
      }.Save(this.GetConfigurationFileName());
    }

    private string GetConfigurationFileName()
    {
      return string.Format("{0}\\{1}", (object) Global.Setup.Folders.Ini.FullName, (object) "flags.xml");
    }
  }
}
