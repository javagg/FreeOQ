using System;

namespace FreeQuant.Docking.WinForms
{
	[Serializable]
	public struct SettingsGroup
	{
		public string TypeName;
		public SettingsItem[] Items;
	}
}
