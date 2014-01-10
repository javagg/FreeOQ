using System.ComponentModel;
using System.IO;

namespace FreeQuant
{
	public class CustomReference : Reference
	{
		protected FileInfo file;

		public override string Path
		{
			get
			{
				return (string)null;
			}
		}

		protected CustomReference(FileInfo file, ReferenceType referenceType, bool enabled)
		{
		}
	}
}
