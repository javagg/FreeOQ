using System;
using System.ComponentModel;

namespace FreeQuant
{
	public class GacReference : Reference
	{
		public override string Path
		{
			get
			{
				return null;
			}
		}

		public GacReference(string name, Version version, bool enabled) : base(ReferenceType.FreeQuant,enabled)
		{
		}
	}
}
