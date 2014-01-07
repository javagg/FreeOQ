// Type: OpenQuant.Options.StartupOptions
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant;
using OpenQuant.Options.Xml;
using OpenQuant.Shared.Options;
using OpenQuant.Startup;
using System.IO;

namespace OpenQuant.Options
{
  [OptionsNode("Startup", typeof (StartupOptionsPanel))]
  internal class StartupOptions : OptionsBase
  {
    private const string FILENAME = "startup.xml";
    private const StartupAction DEFAULT_STARTUP_ACTION = StartupAction.ShowStartPage;
    public const bool DEFAULT_CHECK_FOR_UPDATES = true;
    private StartupAction action;
    private bool checkForUpdates;

    public StartupAction Action
    {
      get
      {
        return this.action;
      }
      set
      {
        this.action = value;
      }
    }

    public bool CheckForUpdates
    {
      get
      {
        return this.checkForUpdates;
      }
      set
      {
        this.checkForUpdates = value;
      }
    }

    public StartupOptions()
    {
      base.\u002Ector();
    }

    protected virtual void OnLoad()
    {
      string configFileName = this.GetConfigFileName();
      if (File.Exists(configFileName))
      {
        StartupXmlDocument startupXmlDocument = new StartupXmlDocument();
        startupXmlDocument.Load(configFileName);
        this.action = startupXmlDocument.Action.Value;
        this.checkForUpdates = startupXmlDocument.CheckForUpdates.Value;
      }
      else
      {
        this.action = StartupAction.ShowStartPage;
        this.checkForUpdates = true;
      }
    }

    protected virtual void OnSave()
    {
      new StartupXmlDocument()
      {
        Action = {
          Value = this.action
        },
        CheckForUpdates = {
          Value = this.checkForUpdates
        }
      }.Save(this.GetConfigFileName());
    }

    private string GetConfigFileName()
    {
      return string.Format("{0}\\{1}", (object) Global.Setup.Folders.Ini.FullName, (object) "startup.xml");
    }
  }
}
