using System;

namespace OpenQuant.Shared.Data.Import.CSV
{
	class Separator
	{
		public static readonly Separator Tab = new Separator("Tab", '\t');
		public static readonly Separator Comma = new Separator("Comma", ',');
		public static readonly Separator Semicolon = new Separator("Semicolon", ';');
		public static readonly Separator Space = new Separator("Space", ' ');
		private const string TAB = "Tab";
		private const string COMMA = "Comma";
		private const string SEMICOLON = "Semicolon";
		private const string SPACE = "Space";
		private string displayName;
		private char value;

		public string DisplayName
		{
			get
			{
				return this.displayName;
			}
		}

//		static Separator()
//		{
//		}

		public Separator(string displayName, char value)
		{
			this.displayName = displayName;
			this.value = value;
		}

		public static implicit operator char[](Separator separator)
		{
			return new char[] {	separator.value };
		}

		public static Separator GetSeparator(string displayName)
		{
			switch (displayName)
			{
				case "Tab":
					return Separator.Tab;
				case "Comma":
					return Separator.Comma;
				case "Semicolon":
					return Separator.Semicolon;
				case "Space":
					return Separator.Space;
				default:
					throw new ArgumentException("Unknown separator - " + displayName);
			}
		}

		public override string ToString()
		{
			return this.displayName;
		}
	}
}
