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
				return file.DirectoryName + file.FullName;
			}
		}

		protected CustomReference(FileInfo file, ReferenceType referenceType, bool enabled) : base(referenceType, enabled)
		{
		}
	}
}
