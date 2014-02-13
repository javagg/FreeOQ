namespace OpenQuant.Shared.Data.Import.CSV
{
	internal enum ColumnType
	{
		Symbol = 1,
		DateTime = 2,
		Date = 4,
		Time = 8,
		Price = 16,
		Size = 32,
		Open = 64,
		High = 128,
		Low = 256,
		Close = 512,
		Volume = 1024,
		OpenInt = 2048,
		Bid = 4096,
		BidSize = 8192,
		Ask = 16384,
		AskSize = 32768,
		Skipped = 65536
	}
}
