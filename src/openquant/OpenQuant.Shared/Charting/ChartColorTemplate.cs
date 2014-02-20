using System.Collections.Generic;
using System.Drawing;

namespace OpenQuant.Shared.Charting
{
	class ChartColorTemplate
	{
		public string Name { get; private set; }
		public Dictionary<string, Color> Settings { get; private set; }
		public ChartColorTemplate(string name)
		{
			this.Name = name;
			this.Settings = new Dictionary<string, Color>();
		}
	}
}
