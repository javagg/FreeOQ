using System.ComponentModel;
using System.IO;

namespace FreeQuant
{
  public class UserReference : CustomReference
  {
		public UserReference(FileInfo file, bool enabled) : base(file, ReferenceType.FreeQuant, enabled)
    {
    }
  }
}
