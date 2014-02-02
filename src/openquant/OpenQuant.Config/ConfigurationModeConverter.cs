using System;

namespace OpenQuant.Config
{
	public static class ConfigurationModeConverter
	{
		private static char MODE_SIMULATION = 'S';
		private static char MODE_LIVE = 'L';

		static ConfigurationModeConverter()
		{
		}

		public static char ModeToChar(ConfigurationMode mode)
		{
			switch (mode)
			{
				case ConfigurationMode.Simulation:
				case ConfigurationMode.Paper:
					return ConfigurationModeConverter.MODE_SIMULATION;
				case ConfigurationMode.Live:
					return ConfigurationModeConverter.MODE_LIVE;
				default:
					throw new ArgumentException("Unknown configuration mode");
			}
		}
	}
}
