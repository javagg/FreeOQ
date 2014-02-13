namespace OpenQuant.Shared.Data.Import.CSV
{
	internal enum FileStatus
	{
		Waiting,
		Importing,
		Testing,
		DoneOk,
		DoneError,
		Aborted
	}
}
