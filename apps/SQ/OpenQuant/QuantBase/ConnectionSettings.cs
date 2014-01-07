// Type: OpenQuant.QuantBase.ConnectionSettings
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Docking.WinForms;
using System;

namespace OpenQuant.QuantBase
{
  internal class ConnectionSettings
  {
    private DockControlSettings settings;

    public string URL
    {
      get
      {
        return this.settings.GetStringValue("URL", "tcp://localhost:5333/QB");
      }
      set
      {
        this.settings.SetValue("URL", value);
      }
    }

    public string Username
    {
      get
      {
        return this.settings.GetStringValue("Username", this.GetDefaultUsername());
      }
      set
      {
        this.settings.SetValue("Username", value);
      }
    }

    public string Password
    {
      get
      {
        return this.settings.GetStringValue("Password", string.Empty);
      }
    }

    public ConnectionSettings(DockControlSettings settings)
    {
      this.settings = settings;
    }

    private string GetDefaultUsername()
    {
      try
      {
        return string.Format("{0}\\{1}", (object) Environment.MachineName, (object) Environment.UserName);
      }
      catch
      {
        return string.Empty;
      }
    }
  }
}
