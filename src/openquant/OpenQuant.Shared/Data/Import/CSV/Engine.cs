using OpenQuant.Shared;
using OpenQuant.Shared.Data;
using FreeQuant;
using FreeQuant.Data;
using FreeQuant.Instruments;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

using TraceLevel = FreeQuant.TraceLevel;

namespace OpenQuant.Shared.Data.Import.CSV
{
	abstract class Engine
	{
		protected Template template;
		private string[] currentItems;
		private FileInfo[] files;
		private EngineState state;
		private FileInfo currentFile;
		private int index;
		private Hashtable clearedSeries;
		private bool skipFile;
		private bool storeObjects;

		public EngineState State
		{
			get
			{
				return this.state;
			}
		}

		public event EventHandler StateChanged;
		public event EventHandler<ErrorEventArgs> Error;
		public event EventHandler<ProgressEventArgs> TotalProgress;
		public event EventHandler<ProgressEventArgs> CurrentFileProgress;
		public event EventHandler<FileEventArgs> FileStatusChanged;

		protected Engine()
		{
			this.state = EngineState.Stopped;
			this.clearedSeries = new Hashtable();
			new Thread(new ThreadStart(this.Run))
			{
				Name = "Import Engine"
			}.Start();
		}

		protected abstract IDataObject Process();

		protected virtual void Add(IDataSeries series, IDataObject obj)
		{
			series.Add(obj.DateTime, obj);
		}

		public static Engine GetEngine(DataType dataType)
		{
			switch (dataType)
			{
				case DataType.Trade:
					return (Engine)new TradeEngine();
				case DataType.Quote:
					return (Engine)new QuoteEngine();
				case DataType.Bar:
					return (Engine)new BarEngine(false);
				case DataType.Daily:
					return (Engine)new BarEngine(true);
				default:
					throw new ArgumentException("Unknown data type - " + ((object)dataType).ToString());
			}
		}

		public void Start(FileInfo[] files, Template template, bool storeObjects)
		{
			this.files = files;
			this.template = template;
			this.storeObjects = storeObjects;
			this.state = EngineState.Running;
		}

		public void Finish()
		{
			this.state = EngineState.Finished;
		}

		public void Stop()
		{
			this.state = EngineState.Stopped;
		}

		public void Pause()
		{
			this.state = EngineState.Paused;
		}

		public void Continue()
		{
			this.state = EngineState.Running;
		}

		public void SkipCurrentFile()
		{
			this.skipFile = true;
		}

		private void EmitError(FileInfo file, string line, string message, int row, int column)
		{
			if (this.Error == null)
				return;
			this.Error((object)this, new ErrorEventArgs(file, line, message, row, column));
		}

		protected DateTime GetDateTime()
		{
			this.index = -1;
			if (this.template.DataOptions.DataType == DataType.Daily)
			{
				this.index = this.GetColumnIndex(ColumnType.Date);
				return this.ParseDateTime(this.currentItems[this.index], this.template.Columns[this.index].ColumnFormat);
			}
			else
			{
				switch (this.template.DateOptions.DateType)
				{
					case DateType.Column:
						this.index = this.GetColumnIndex(ColumnType.DateTime);
						if (this.index != -1)
							return this.ParseDateTime(this.currentItems[this.index], this.template.Columns[this.index].ColumnFormat);
						this.index = this.GetColumnIndex(ColumnType.Date);
						DateTime dateTime1 = this.ParseDateTime(this.currentItems[this.index], this.template.Columns[this.index].ColumnFormat);
						this.index = this.GetColumnIndex(ColumnType.Time);
						DateTime dateTime2 = this.ParseTime(this.currentItems[this.index], this.template.Columns[this.index].ColumnFormat);
						return dateTime1.Add(dateTime2.TimeOfDay);
					case DateType.Manually:
						DateTime date = this.template.DateOptions.Date;
						this.index = this.GetColumnIndex(ColumnType.Time);
						DateTime dateTime3 = this.ParseTime(this.currentItems[this.index], this.template.Columns[this.index].ColumnFormat);
						return date.Add(dateTime3.TimeOfDay);
					default:
						throw new ArgumentException();
				}
			}
		}

		protected double GetDoubleValue(ColumnType columnType)
		{
			this.index = this.GetColumnIndex(columnType);
			if (this.index != -1)
				return double.Parse(this.currentItems[this.index], (IFormatProvider)this.template.CSVOptions.CultureInfo);
			else
				return 0.0;
		}

		protected int GetInt32Value(ColumnType columnType)
		{
			this.index = this.GetColumnIndex(columnType);
			if (this.index != -1)
				return int.Parse(this.currentItems[this.index]);
			else
				return 0;
		}

		protected long GetInt64Value(ColumnType columnType)
		{
			this.index = this.GetColumnIndex(columnType);
			if (this.index != -1)
				return long.Parse(this.currentItems[this.index]);
			else
				return 0L;
		}

		protected int GetColumnIndex(ColumnType columnType)
		{
			for (int index = 0; index < this.template.Columns.Count; ++index)
			{
				if (this.template.Columns[index].ColumnType == columnType)
					return index;
			}
			return -1;
		}

		private void Run()
		{
			while (true)
			{
				this.WaitForState(new EngineState[2]
				{
					EngineState.Running,
					EngineState.Finished
				});
				if (this.state != EngineState.Finished)
				{
					this.EmitStateChanged();
					this.EmitTotalProgress(0);
					this.clearedSeries.Clear();
					for (int index = 0; index < this.files.Length; ++index)
					{
						if (this.state == EngineState.Paused)
						{
							this.EmitStateChanged();
							this.WaitForState(new EngineState[2]
							{
								EngineState.Running,
								EngineState.Stopped
							});
							this.EmitStateChanged();
						}
						if (this.state != EngineState.Stopped)
						{
							this.ProcessFile(this.files[index]);
							this.EmitTotalProgress(index + 1);
						}
						else
							break;
					}
					DataManager.Server.Flush();
					this.state = EngineState.Stopped;
					this.EmitStateChanged();
				}
				else
					break;
			}
		}

		private void ProcessFile(FileInfo file)
		{
			this.currentFile = file;
			this.skipFile = false;
			this.EmitFileStatusChanged(file, this.storeObjects ? FileStatus.Importing : FileStatus.Testing);
			this.EmitCurrentFileProgress(0);
			StreamReader streamReader;
			try
			{
				streamReader = new StreamReader((Stream)file.OpenRead());
			}
			catch (IOException ex)
			{
				this.EmitError(file, (string)null, ex.Message, -1, -1);
				this.EmitFileStatusChanged(file, FileStatus.DoneError);
				return;
			}
			int headerLineCount1 = this.template.CSVOptions.HeaderLineCount;
			while (headerLineCount1-- > 0)
				streamReader.ReadLine();
			int objectCount = 0;
			bool flag1 = false;
			int headerLineCount2 = this.template.CSVOptions.HeaderLineCount;
			int progress = 0;
			Dictionary<IDataSeries, Tuple<DateTime, DateTime>> dictionary = new Dictionary<IDataSeries, Tuple<DateTime, DateTime>>();
			string str;
			while ((str = streamReader.ReadLine()) != null)
			{
				++headerLineCount2;
				if (this.state == EngineState.Paused)
				{
					this.EmitStateChanged();
					this.WaitForState(new EngineState[2]
					{
						EngineState.Running,
						EngineState.Stopped
					});
					this.EmitStateChanged();
				}
				if (this.state == EngineState.Stopped)
				{
					this.EmitStateChanged();
					break;
				}
				else
				{
					string line = str.Trim();
					if (!(line == ""))
					{
						this.currentItems = line.Split((char[])this.template.CSVOptions.Separator);
						for (int index = 0; index < this.currentItems.Length; ++index)
							this.currentItems[index] = this.currentItems[index].Trim(' ', '\t', '"');
						if (this.currentItems.Length == this.template.Columns.Count)
						{
							try
							{
								IDataObject idataObject = this.Process();
								if (this.storeObjects)
								{
									bool flag2 = true;
									if (this.template.OtherOptions.ImportOnlyRange && (idataObject.DateTime < this.template.OtherOptions.ImportRangeBegin || idataObject.DateTime > this.template.OtherOptions.ImportRangeEnd))
										flag2 = false;
									if (flag2)
									{
										IDataSeries dataSeries = this.GetDataSeries();
										if (this.template.OtherOptions.SkipDataInsideExistingRange)
										{
											Tuple<DateTime, DateTime> tuple = (Tuple<DateTime, DateTime>)null;
											if (!dictionary.TryGetValue(dataSeries, out tuple))
											{
												DateTime dateTime1 = DateTime.MaxValue;
												DateTime dateTime2 = DateTime.MinValue;
												if (dataSeries.Count != 0)
												{
													dateTime1 = dataSeries.FirstDateTime;
													dateTime2 = dataSeries.LastDateTime;
												}
												tuple = new Tuple<DateTime, DateTime>(dateTime1, dateTime2);
												dictionary[dataSeries] = tuple;
											}
											if (idataObject.DateTime > tuple.Item2 || idataObject.DateTime < tuple.Item1)
												this.Add(dataSeries, idataObject);
										}
										else
											this.Add(dataSeries, idataObject);
									}
								}
								++objectCount;
							}
							catch (Exception ex)
							{
								if (FreeQuant.Trace.IsLevelEnabled(TraceLevel.Error))
									FreeQuant.Trace.WriteLine(((object)ex).ToString());
								flag1 = true;
								this.EmitError(this.currentFile, line, ex.Message, headerLineCount2, this.index);
								if (this.skipFile)
									break;
							}
						}
						else
						{
							flag1 = true;
							this.EmitError(file, line, string.Concat(new object[4]
							{
								(object)"Actual column count - ",
								(object)this.currentItems.Length,
								(object)", expected - ",
								(object)this.template.Columns.Count
							}), headerLineCount2, -1);
							if (this.skipFile)
								break;
						}
						int num = (int)(streamReader.BaseStream.Position * 100L / streamReader.BaseStream.Length);
						if (num > progress)
						{
							progress = num;
							this.EmitCurrentFileProgress(progress);
						}
					}
				}
			}
			streamReader.Close();
			FileStatus status = FileStatus.DoneOk;
			if (flag1)
				status = FileStatus.DoneError;
			if (this.skipFile)
				status = FileStatus.Aborted;
			this.EmitFileStatusChanged(file, status, objectCount);
		}

		private IDataSeries GetDataSeries()
		{
			string str1 = (string)null;
			switch (this.template.SymbolOptions.Option)
			{
				case SymbolOption.FileName:
					str1 = this.currentFile.Name;
					if (this.currentFile.Extension != string.Empty)
					{
						str1 = str1.Substring(0, str1.IndexOf('.'));
						break;
					}
					else
						break;
				case SymbolOption.Column:
					str1 = this.currentItems[this.GetColumnIndex(ColumnType.Symbol)].Trim();
					break;
				case SymbolOption.Manually:
					str1 = this.template.SymbolOptions.Name;
					break;
			}
			if (this.template.OtherOptions.CreateInstrument && InstrumentManager.Instruments[str1] == null)
				new Instrument(str1, APITypeConverter.InstrumentType.Convert(this.template.OtherOptions.InstrumentType)).Save();
			string str2 = (string)null;
			switch (this.template.DataOptions.DataType)
			{
				case DataType.Trade:
					str2 = "Trade";
					break;
				case DataType.Quote:
					str2 = "Quote";
					break;
				case DataType.Bar:
					str2 = "Bar" + (object)'.' + ((object)(BarType)1).ToString() + (string)(object)'.' + this.template.DataOptions.BarSize.ToString();
					break;
				case DataType.Daily:
					str2 = "Daily";
					break;
			}
			string str3 = str1 + (object)'.' + str2;
			IDataSeries idataSeries = DataManager.Server.GetDataSeries(str3) ?? DataManager.Server.AddDataSeries(str3);
			if (this.template.OtherOptions.ClearSeries && !this.clearedSeries.ContainsKey((object)idataSeries))
			{
				idataSeries.Clear();
				this.clearedSeries.Add((object)idataSeries, (object)true);
			}
			return idataSeries;
		}

		private void WaitForState(EngineState[] expectedStates)
		{
			while (true)
			{
				foreach (EngineState engineState in expectedStates)
				{
					if (this.state == engineState)
						return;
				}
				Thread.Sleep(1);
			}
		}

		private DateTime ParseDateTime(string str, string format)
		{
			return DateTime.ParseExact(str, format, (IFormatProvider)this.template.CSVOptions.CultureInfo);
		}

		private DateTime ParseTime(string str, string format)
		{
			if (format.Length > str.Length)
				str = "0" + str;
			return this.ParseDateTime(str, format);
		}

		private void EmitStateChanged()
		{
			if (this.StateChanged == null)
				return;
			this.StateChanged((object)this, EventArgs.Empty);
		}

		private void EmitTotalProgress(int progress)
		{
			if (this.TotalProgress == null)
				return;
			this.TotalProgress((object)this, new ProgressEventArgs(progress));
		}

		private void EmitCurrentFileProgress(int progress)
		{
			if (this.CurrentFileProgress == null)
				return;
			this.CurrentFileProgress((object)this, new ProgressEventArgs(progress));
		}

		private void EmitFileStatusChanged(FileInfo file, FileStatus status, int objectCount)
		{
			if (this.FileStatusChanged == null)
				return;
			this.FileStatusChanged((object)this, new FileEventArgs(file, status, objectCount));
		}

		private void EmitFileStatusChanged(FileInfo file, FileStatus status)
		{
			this.EmitFileStatusChanged(file, status, 0);
		}
	}
}
