using System;

namespace OpenQuant.Shared.Scripts
{
	class ScriptPropertyKey
	{
		private string name;
		private Type type;

		public ScriptPropertyKey(string name, Type type)
		{
			this.name = name;
			this.type = type;
		}

		public override int GetHashCode()
		{
			return this.name.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			ScriptPropertyKey scriptPropertyKey = (ScriptPropertyKey)obj;
			return scriptPropertyKey != null && !(scriptPropertyKey.name != this.name) && !(scriptPropertyKey.type != this.type);
		}
	}
}
