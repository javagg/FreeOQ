using System;
using System.Collections.Generic;

namespace FreeQuant.QuantBaseLib
{
	[Serializable]
	public class Instrument
	{
		public Dictionary<int, object> Fields { get; private set; }

		public Instrument()
		{
			this.Fields = new Dictionary<int, object>();
		}
	}
}
