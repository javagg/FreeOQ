namespace OpenQuant.Shared.Data.Bars
{
	class DataSource
	{
		public DataSourceInput Input { get; private set; }

		public DataSource(DataSourceInput input)
		{
			this.Input = input;
		}

		public override string ToString()
		{
			return ((object)this.Input).ToString();
		}

		public override int GetHashCode()
		{
			return this.Input.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			return (obj is DataSource) ? ((DataSource)obj).Input == this.Input : base.Equals(obj);
		}
	}
}
