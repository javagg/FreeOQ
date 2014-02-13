namespace FreeQuant.Docking.WinForms
{
	class DockControlKey
	{
		private static object NULL_KEY = new object();
		private object key;

		static DockControlKey()
		{
		}

		public DockControlKey(object key)
		{
			this.key = key == null ? DockControlKey.NULL_KEY : key;
		}

		public override int GetHashCode()
		{
			return this.key.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (obj is DockControlKey)
				return this.key.Equals(((DockControlKey)obj).key);
			else
				return base.Equals(obj);
		}
	}
}
