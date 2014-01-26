namespace FreeQuant.Data
{
	public enum MDOperation : byte
	{
		Insert = 0,
		Update = 1,
		Delete = 2,
		Reset = 4,
		Undefined = 255,
	}
}
