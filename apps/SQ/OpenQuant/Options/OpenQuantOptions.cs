// Type: OpenQuant.Options.OpenQuantOptions
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using OpenQuant.Shared.Options;

namespace OpenQuant.Options
{
  internal class OpenQuantOptions : AppOptions
  {
    public EnvironmentOptions Environment
    {
      get
      {
        return (EnvironmentOptions) ((OptionsBase) this).GetSubOptions<EnvironmentOptions>();
      }
    }

    public ConfigurationOptions Configuration
    {
      get
      {
        return (ConfigurationOptions) ((OptionsBase) this).GetSubOptions<ConfigurationOptions>();
      }
    }

    public SolutionsOptions Solutions
    {
      get
      {
        return (SolutionsOptions) ((OptionsBase) this).GetSubOptions<SolutionsOptions>();
      }
    }

    public MemoryManagementOptions MemoryManagement
    {
      get
      {
        return (MemoryManagementOptions) ((OptionsBase) this).GetSubOptions<MemoryManagementOptions>();
      }
    }

    public OpenQuantOptions()
    {
      base.\u002Ector();
      ((OptionsBase) this).Add((OptionsBase) new ConfigurationOptions());
      ((OptionsBase) this).Add((OptionsBase) new EnvironmentOptions());
      ((OptionsBase) this).Add((OptionsBase) new SolutionsOptions());
      ((OptionsBase) this).Add((OptionsBase) new MemoryManagementOptions());
    }
  }
}
