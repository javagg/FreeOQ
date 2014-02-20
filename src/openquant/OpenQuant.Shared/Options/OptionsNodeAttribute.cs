using System;

namespace OpenQuant.Shared.Options
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class OptionsNodeAttribute : Attribute
	{
		public string Text { get; private set; }
		public Type PanelType { get; private set; }

		public OptionsNodeAttribute(string text, Type panelType)
		{
			this.Text = text;
			this.PanelType = panelType;
		}

		public OptionsNodeAttribute(string text) : this(text, typeof(OptionsPanel))
		{
		}
	}
}
