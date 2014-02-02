using System.ComponentModel;

namespace OpenQuant.Config
{
	public class ConfigurationModeChangingEventArgs : CancelEventArgs
	{
		public ConfigurationMode ActiveMode { get; private set; }
		public ConfigurationMode NewMode { get; private set; }

		public ConfigurationModeChangingEventArgs(ConfigurationMode activeMode, ConfigurationMode newMode) : base(false)
		{
			this.ActiveMode = activeMode;
			this.NewMode = newMode;
		}
	}
}
