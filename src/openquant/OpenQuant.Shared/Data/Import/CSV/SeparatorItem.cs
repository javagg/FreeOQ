namespace OpenQuant.Shared.Data.Import.CSV
{
	class SeparatorItem
	{
		private Separator separator;

		public Separator Separator
		{
			get
			{
				return this.separator;
			}
		}

		public SeparatorItem(Separator separator)
		{
			this.separator = separator;
		}

		public override string ToString()
		{
			return this.separator.DisplayName;
		}
	}
}
