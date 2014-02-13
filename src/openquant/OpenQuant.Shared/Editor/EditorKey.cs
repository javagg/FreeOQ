using System.IO;

namespace OpenQuant.Shared.Editor
{
	public class EditorKey
	{
		private string key;

		public FileInfo File { get; private set; }

		public EditorKey(FileInfo file)
		{
			this.File = file;
			this.key = file.FullName.Replace('/', '\\').ToUpper();
		}

		public EditorKey(string filename) : this(new FileInfo(filename))
		{
		}

		public override int GetHashCode()
		{
			return this.key.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (obj is EditorKey)
				return this.key.Equals(((EditorKey)obj).key);
			else
				return base.Equals(obj);
		}
	}
}
