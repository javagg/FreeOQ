using System.IO;

namespace OpenQuant.Shared.Scripts
{
	public class ScriptKey
	{
		private string key;

		public FileInfo File { get; private set; }

		internal ScriptKey(FileInfo file)
		{
			this.File = file;
			this.key = file.FullName.ToUpper().Replace('/', '\\');
		}

		public override int GetHashCode()
		{
			return this.key.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (obj is ScriptKey)
				return this.key.Equals(((ScriptKey)obj).key);
			else
				return base.Equals(obj);
		}

		public override string ToString()
		{
			return this.key;
		}
	}
}
