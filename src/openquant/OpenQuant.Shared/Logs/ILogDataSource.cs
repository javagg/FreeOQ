namespace OpenQuant.Shared.Logs
{
	internal interface ILogDataSource
	{
		int Count { get; }

		object this [int rowIndex, int columnIndex] { get; }

		bool HasChanges(bool reset);

		void AddColumn(string columnName);

		void Add(object key, string columnName, object value);
	}
}
