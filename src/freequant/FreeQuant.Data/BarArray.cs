namespace FreeQuant.Data
{
	public class BarArray : DataArray
	{
		public new Bar this[int index]
		{
			get
			{
				return base[index] as Bar;
			}
		}

		public BarArray() : base()
		{
		}
	}
}
