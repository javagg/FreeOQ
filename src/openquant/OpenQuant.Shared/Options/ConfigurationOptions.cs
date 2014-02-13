using System.IO;

namespace OpenQuant.Shared.Options
{
	[OptionsNode("Configuration", typeof(ConfigurationOptionsPanel))]
	public class ConfigurationOptions : OptionsBase
	{
		internal DirectoryInfo BaseDirectory { get; private set; }

		internal DirectoryInfo AppDataDirectory { get; private set; }

		public ConfigurationOptions(DirectoryInfo baseDirectory, DirectoryInfo appDataDirectory)
		{
			this.BaseDirectory = baseDirectory;
			this.AppDataDirectory = appDataDirectory;
		}
	}
}
