namespace OpenQuant.Shared
{
	public interface IBusyWindow
	{
		bool IsBusy { get; }
		string BusyWindowMessage { get; }
	}
}
