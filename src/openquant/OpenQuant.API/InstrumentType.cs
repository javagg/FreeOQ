namespace OpenQuant.API
{
	///<summary>
	///  Financial instrument type (stock, bond, futures, option, etc.)
	///</summary>
	public enum InstrumentType
	{
		Stock,
		Futures,
		Option,
		FutOpt,
		Bond,
		Index,
		ETF,
		FX,
		MultiLeg,
		Commodity
	}
}
