// Type: OpenQuant.Options.EnvironmentOptions
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared.Options;

namespace OpenQuant.Options
{
  [OptionsNode("Environment")]
  internal class EnvironmentOptions : OptionsBase
  {
    public LayoutOptions Layout
    {
      get
      {
        return (LayoutOptions) this.GetSubOptions<LayoutOptions>();
      }
    }

    public StartupOptions Startup
    {
      get
      {
        return (StartupOptions) this.GetSubOptions<StartupOptions>();
      }
    }

    public EnvironmentOptions()
    {
      base.\u002Ector();
      this.Add((OptionsBase) new LayoutOptions());
      this.Add((OptionsBase) new StartupOptions());
    }
  }
}
