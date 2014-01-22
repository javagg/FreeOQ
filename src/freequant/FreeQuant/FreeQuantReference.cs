using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant
{
	public class FreeQuantReference : CustomReference
  {
		public FreeQuantReference(string name, bool enabled):base(null,ReferenceType.FreeQuant, enabled)
    {
    }
  }
}
