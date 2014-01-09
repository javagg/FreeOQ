using System;
namespace FreeQuant.File
{
	public class SeriesEventArgs : EventArgs
	{
		public FileSeries series { get; set; }
	}
	public delegate void SeriesEventHandler(SeriesEventArgs args);
}
