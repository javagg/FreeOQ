using System;

namespace OpenQuant.Shared.Charting
{
	class TemplateActionEventArgs : EventArgs
	{
		public TemplateActionType ActionType { get; private set; }

		public string TemplateName { get; private set; }

		public TemplateActionEventArgs(TemplateActionType actionType, string templateName)
		{
			this.ActionType = actionType;
			this.TemplateName = templateName;
		}
	}
}
