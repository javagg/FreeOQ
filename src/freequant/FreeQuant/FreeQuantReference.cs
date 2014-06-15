using System.ComponentModel;

namespace FreeQuant
{
    // extra
    public class FreeQuantReference : CustomReference
	{
		public FreeQuantReference(string name, bool enabled) : base(null, ReferenceType.FreeQuant, enabled)
		{
		}
	}
}
